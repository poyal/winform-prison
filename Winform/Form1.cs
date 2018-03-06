using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;

using System.IO.Ports;
using System.Collections;
using DigestTest;
using Newtonsoft.Json.Linq;

namespace Winform
{
    public partial class Form1 : Form
    {
        List<Hashtable> groupList = new List<Hashtable>();
        List<Hashtable> roomList = new List<Hashtable>();

        DataTable groupDataTable = new DataTable();
        DataTable roomDataTable = new DataTable();

        string selectGroupCode = "";
        string selectRoomCode = "";

        string cameraGroupCode = "";
        string cameraRoomCode = "";
        System.Timers.Timer aTimer;

        string rtspHeader = Properties.NVRAccessSetting.Default.RTSP_HEADER;
        string httpHeader = Properties.NVRAccessSetting.Default.HTTP_HEADER;
        string userName = Properties.NVRAccessSetting.Default.NVR_USER_NAME;
        string userPw = Properties.NVRAccessSetting.Default.NVR_USER_PW;
        string nvrIp = Properties.NVRAccessSetting.Default.NVR_IP;

        string channel = "2";
        string level = "1";
        string preset = "1";

        Boolean isOpenFlag = true;

        DBConnection dbc = new DBConnection();

        public Form1()
        {
            InitializeComponent();

            dbc.Open();

            GroupButtonSetting();
            OpenLogHistiorySetting();
            GroupChange(selectGroupCode);
            RoomChange(selectGroupCode, selectRoomCode);
            SensorSearchTimer();
            //SensorSetting();
        }

        private void SensorSearchTimer()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            string comportStr = "";
            foreach (string comport in SerialPort.GetPortNames())
            {
                comportStr = comport;
            }

            if (!comportStr.Equals(""))
            {
                aTimer.Stop();
                SensorSetting(comportStr);
            }
        }

        private void SensorSetting(string comportStr)
        {
            Console.WriteLine("Sensor IN -------------------");
            Console.WriteLine("PortName = " + comportStr);
            Console.WriteLine("BaudRate = " + 9600);
            Console.WriteLine("DataBits = " + 8);
            Console.WriteLine("Parity = " + Parity.None);
            Console.WriteLine("StopBits = " + StopBits.One);
            serialPort1.PortName = comportStr;
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            btnPortOpen_Click();
        }

        private void btnPortOpen_Click()
        {
            try
            {
                serialPort1.Open();
            }
            catch
            {
                Console.WriteLine("해당 포트는 사용 중입니다.");
                return;
            }

            if (serialPort1.IsOpen)
            {
                Console.WriteLine("포트가 연결되었습니다.");
            }
            else
            {
                Console.WriteLine("포트를 연결하지 못했습니다.");
            }
        }

        string sensorSignal = "";

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string data = serialPort1.ReadExisting();

                if (data.Trim() != string.Empty)
                {
                    char[] values = data.ToCharArray();
                    int value = Convert.ToInt32(values[0]);


                    if (data.Trim() != sensorSignal)
                    {
                        if (sensorSignal == "")
                        {
                            isOpenFlag = true;
                        }

                        sensorSignal = data.Trim();

                        //Console.WriteLine("-------------------------");
                        //Console.WriteLine("data = " + data.Trim());

                        string status = "";
                        if (data.Trim() == "1")
                        {
                            status = "C";
                            RoomStatusUpdate(1, 1, status);
                            SensorSignalCollector(1, 1, status);
                        }
                        else if (data.Trim() == "0")
                        {
                            status = "O";
                            RoomStatusUpdate(1, 1, status);
                            SensorSignalCollector(1, 1, status);
                        }
                    }
                }
            }
        }

        // 테스트 버튼 클릭
        private void testButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string status = "O";
            if (random.Next(0, 2) == 1)
            {
                status = "C";
            }
            int group = random.Next(1, 6);
            int room = random.Next(1, 21);
            RoomStatusUpdate(group, room, status);
            SensorSignalCollector(group, room, status);
        }

        // 센서정보 수신
        private void SensorSignalCollector(int group, int room, string status)
        {
            OpenLogHistiorySetting();
            GroupButtonColorChange();
            selectGroupCode = "G" + ReturnIntToString(group.ToString());
            selectRoomCode = "R" + ReturnIntToString(room.ToString());
            GroupChange(selectGroupCode);
            RoomChange(selectGroupCode, selectRoomCode);
            Console.WriteLine("isOpenFlag = " + isOpenFlag);
            if (!isOpenFlag)
            {
                CameraPTZ();
            }
            else
            {
                isOpenFlag = false;
            }
        }

        // 방 상태 변경
        private void RoomStatusUpdate(int group, int room, string status)
        {
            Console.WriteLine(" ================================== RoomStatusUpdate ==========================");
            Console.WriteLine("group = " + group);
            Console.WriteLine("room = " + room);
            Console.WriteLine("status = " + status);
            string groupStr = group.ToString();
            string roomStr = room.ToString();
            string sql = "";
            sql += "UPDATE room_info ";
            sql += "SET ";
            if (status.Equals("O"))
            {
                sql += "room_status = 'O', ";
                sql += "room_open_time = now() ";

                //preset 조정
                preset = "2";
            }
            else if (status.Equals("C"))
            {
                sql += "room_status = 'C', ";
                sql += "room_close_time = now() ";

                //preset 조정
                preset = "1";
            }
            sql += "WHERE ";
            sql += "group_code = 'G" + ReturnIntToString(groupStr) + "' AND room_code = 'R" + ReturnIntToString(roomStr) + "'";

            dbc.Update(sql);
        }

        // 사동 그룹 정보 셋팅
        private void GroupButtonSetting()
        {
            string sql = "";
            sql += "SELECT ";
            sql += "    (SELECT group_name ";
            sql += "     FROM group_info G ";
            sql += "     WHERE G.group_code = A.group_code) AS group_code_name, ";
            sql += "    group_code                          AS group_code, ";
            sql += "    COUNT(CASE";
            sql += "          WHEN room_status = 'O' ";
            sql += "            THEN ";
            sql += "              '1' END)                  AS open_cnt ";
            sql += "FROM room_info A ";
            sql += "GROUP BY group_code ";
            sql += "ORDER BY group_code ASC ";

            groupDataTable = dbc.SelectDataTable(sql);

            int seq = 0;
            int btnHeight = 70;
            foreach (DataRow row in groupDataTable.Rows)
            {
                seq++;
                string group_code_name = row["group_code_name"].ToString();
                string group_code = row["group_code"].ToString();
                string open_cnt = row["open_cnt"].ToString();

                Button newBtn = new Button();
                newBtn.Size = new Size(panel1.Width - 19, btnHeight);
                newBtn.Text = group_code_name;
                newBtn.Name = group_code;
                if (open_cnt.Equals("0"))
                {
                    newBtn.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    newBtn.BackColor = System.Drawing.Color.Red;
                }

                int YPos = 0;
                foreach (Control items in panel1.Controls)
                {
                    YPos += items.Height;
                }

                newBtn.Location = new Point(0, YPos);

                newBtn.Tag = seq.ToString();
                newBtn.Click += new EventHandler(Group_Click);
                panel1.Controls.Add(newBtn);
            }
        }

        // 버튼색 변경
        private void GroupButtonColorChange()
        {
            string sql = "";
            sql += "SELECT ";
            sql += "    (SELECT group_name ";
            sql += "     FROM group_info G ";
            sql += "     WHERE G.group_code = A.group_code) AS group_code_name, ";
            sql += "    group_code                          AS group_code, ";
            sql += "    COUNT(CASE";
            sql += "          WHEN room_status = 'O' ";
            sql += "            THEN ";
            sql += "              '1' END)                  AS open_cnt ";
            sql += "FROM room_info A ";
            sql += "GROUP BY group_code ";
            sql += "ORDER BY group_code ASC ";

            groupDataTable = dbc.SelectDataTable(sql);

            foreach (DataRow row in groupDataTable.Rows)
            {
                string group_code_name = row["group_code_name"].ToString();
                string group_code = row["group_code"].ToString();
                string open_cnt = row["open_cnt"].ToString();

                Button searchBtn = this.Controls.Find(group_code, true).FirstOrDefault() as Button;
                if (open_cnt.Equals("0"))
                {
                    searchBtn.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    searchBtn.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        // 방열림 이벤트 로그
        delegate void SetDataGridView1();
        private void OpenLogHistiorySetting()
        {
            if (dataGridView1.InvokeRequired)
            {
                SetDataGridView1 dele = new SetDataGridView1(OpenLogHistiorySetting);
                this.Invoke(dele, new object[] { });
            }
            else
            {
                string sql = "";
                sql += "SELECT ";
                sql += "    group_code                          AS group_code, ";
                sql += "    (SELECT group_name ";
                sql += "     FROM group_info G ";
                sql += "     WHERE G.group_code = A.group_code) AS group_code_name, ";
                sql += "    room_code                           AS room_code, ";
                sql += "    room_name                           AS room_code_name, ";
                sql += "    room_status                         AS room_status, ";
                sql += "    (CASE WHEN room_status = 'O' ";
                sql += "     THEN '열림' ";
                sql += "     ELSE '닫힘' ";
                sql += "     END)                               AS room_status_name, ";
                sql += "    (CASE WHEN room_status = 'O'";
                sql += "     THEN to_char(room_open_time, 'YYYY-MM-DD HH24:MI:SS') ";
                sql += "     ELSE to_char(room_close_time, 'YYYY-MM-DD HH24:MI:SS') ";
                sql += "     END)                               AS event_time ";
                sql += "FROM room_status_history A ";
                sql += "WHERE room_status = 'O' ";
                sql += "ORDER BY event_time DESC ";
                sql += "LIMIT 20 ";

                DataTable historyDataTable = dbc.SelectDataTable(sql);
                dataGridView1.DataSource = historyDataTable;

                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;

                int dataCount = historyDataTable.Select().Length;

                if (dataCount > 0)
                {
                    DataRow[] rows = historyDataTable.Select();
                    selectGroupCode = rows[0]["group_code"].ToString();
                    selectRoomCode = rows[0]["room_code"].ToString();
                }
                else
                {
                    selectGroupCode = "G01";
                    selectRoomCode = "";
                }
            }
        }

        // 사동 버튼 클릭 이벤트
        private void Group_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            selectGroupCode = button.Name.ToString();
            selectRoomCode = "";
            GroupChange(selectGroupCode);
            RoomChange(selectGroupCode, selectRoomCode);
        }

        // 그룹별 방 상태 조회
        delegate void SetRoomTextBox(string groupCode);
        private void GroupChange(string groupCode)
        {
            if (room_textBox.InvokeRequired)
            {
                SetRoomTextBox dele = new SetRoomTextBox(GroupChange);
                this.Invoke(dele, new object[] { groupCode });
            }
            else
            {
                string group_code_name = "";
                foreach (DataRow row in groupDataTable.Rows)
                {
                    string group_code = row["group_code"].ToString();
                    if (group_code.Equals(groupCode))
                    {
                        group_code_name = row["group_code_name"].ToString();
                    }
                }

                room_textBox.Text = group_code_name + " 상태";

                string sql = "";
                sql += "SELECT ";
                sql += "    group_code  AS group_code, ";
                sql += "    room_code   AS room_code, ";
                sql += "    room_name   AS room_name, ";
                sql += "    room_status AS room_status ";
                sql += "FROM room_info ";
                sql += "WHERE group_code = '" + groupCode + "' ";
                sql += "ORDER BY room_code ASC";

                roomDataTable = dbc.SelectDataTable(sql);

                foreach (DataRow row in roomDataTable.Rows)
                {
                    Button searchBtn = this.Controls.Find(row["room_code"].ToString(), true).FirstOrDefault() as Button;
                    if (row["room_status"].ToString().Equals("O"))
                    {
                        searchBtn.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        searchBtn.BackColor = System.Drawing.Color.White;
                    }
                }
            }
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            selectRoomCode = button.Name.ToString();
            RoomChange(selectGroupCode, selectRoomCode);
        }

        // 호실 상세
        delegate void SetDataGridView2(string groupCode, string roomCode);
        private void RoomChange(string groupCode, string roomCode)
        {
            if (dataGridView2.InvokeRequired)
            {
                SetDataGridView2 dele = new SetDataGridView2(RoomChange);
                this.Invoke(dele, new object[] { groupCode, roomCode });
            }
            else
            {
                if (roomCode.Equals(""))
                {
                    roomCode = "R01";
                }

                string group_code_name = "";
                foreach (DataRow row in groupDataTable.Rows)
                {
                    string group_code = row["group_code"].ToString();
                    if (group_code.Equals(groupCode))
                    {
                        group_code_name = row["group_code_name"].ToString();
                    }
                }

                string room_name = "";
                foreach (DataRow row in roomDataTable.Rows)
                {
                    string room_code = row["room_code"].ToString();
                    if (room_code.Equals(roomCode))
                    {
                        room_name = row["room_name"].ToString();
                    }
                }

                room_detail_textBox.Text = group_code_name + " " + room_name + "호 이력";

                string sql = "";
                sql += "SELECT ";
                sql += "    group_code                          AS group_code, ";
                sql += "    (SELECT group_name ";
                sql += "     FROM group_info G ";
                sql += "     WHERE G.group_code = A.group_code) AS group_code_name, ";
                sql += "    room_code                           AS room_code, ";
                sql += "    room_name                           AS room_code_name, ";
                sql += "    room_status                         AS room_status, ";
                sql += "    (CASE WHEN room_status = 'O' ";
                sql += "      THEN '열림' ";
                sql += "     ELSE '닫힘' ";
                sql += "     END)                               AS room_status_name, ";
                sql += "    (CASE WHEN room_status = 'O' ";
                sql += "     THEN to_char(room_open_time, 'YYYY-MM-DD HH24:MI:SS') ";
                sql += "     ELSE to_char(room_close_time, 'YYYY-MM-DD HH24:MI:SS') ";
                sql += "     END)                               AS event_time ";
                sql += "FROM room_status_history A ";
                sql += "WHERE group_code = '" + groupCode + "' ";
                sql += "      AND room_code = '" + roomCode + "' ";
                sql += "ORDER BY event_time DESC ";
                sql += "LIMIT 10";

                DataTable roomHistoryDataTable = dbc.SelectDataTable(sql);
                dataGridView2.DataSource = roomHistoryDataTable;

                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[7].Visible = false;

                CameraSetting(groupCode, roomCode);
            }
        }

        // 카메라 변경
        private void CameraSetting(string groupCode, string roomCode)
        {
            string sql = "";
            sql += "SELECT ";
            sql += "    group_code AS group_code, ";
            sql += "    room_code  AS room_code, ";
            sql += "    camera     AS camera, ";
            sql += "    preset     AS preset ";
            sql += "FROM room_info ";
            sql += "WHERE group_code = '" + groupCode + "' ";
            sql += "AND room_code = '" + roomCode + "'";

            DataTable roomDetailDataTable = dbc.SelectDataTable(sql);

            int dataCount = roomDetailDataTable.Select().Length;

            DataRow[] rows = roomDetailDataTable.Select();
            string group_code = rows[0]["group_code"].ToString();
            string room_code = rows[0]["room_code"].ToString();
            string camera = rows[0]["camera"].ToString();
            string preset = "1";
            camera_preset_info.Text = camera + " / " + preset;

            CameraChange(groupCode, roomCode, camera, preset);
        }

        // string 숫자 두자리 변형
        private string ReturnIntToString(string number)
        {
            string strNum = "";
            strNum = number;
            if (strNum.Length == 1)
            {
                strNum = "0" + strNum;
            }
            return strNum;
        }

        private void CameraChange(string groupCode, string roomCode, string camera, string preset)
        {
            Console.WriteLine(" ============= CameraChange ==============");
            if (!(selectGroupCode == cameraGroupCode && selectRoomCode == cameraRoomCode))
            {
                cameraGroupCode = selectGroupCode;
                cameraRoomCode = selectRoomCode;

                axVLCPlugin21.playlist.add(rtspHeader + userName + ":" + userPw + "@" + nvrIp + "/" + channel + "/high", null, null);
                axVLCPlugin21.playlist.next();
                axVLCPlugin21.playlist.play();
            }
        }

        private void CameraPTZ()
        {
            Console.WriteLine("======================================== CameraPTZ =================================");
            DigestAuthFixer digest = new DigestAuthFixer(httpHeader + nvrIp, userName, userPw);
            JObject jsonReturn = digest.GrabResponse("/control/ptz.cgi?channel=" + channel + " &level=" + level + "&preset=" + preset);
            Console.WriteLine("jsonReturn = " + jsonReturn["Result"]["Code"]);
        }
    }
}
