namespace Winform {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.camera_preset_info = new System.Windows.Forms.TextBox();
            this.room_detail_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.room_textBox = new System.Windows.Forms.TextBox();
            this.R20 = new System.Windows.Forms.Button();
            this.R19 = new System.Windows.Forms.Button();
            this.R18 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.R17 = new System.Windows.Forms.Button();
            this.room_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R16 = new System.Windows.Forms.Button();
            this.R15 = new System.Windows.Forms.Button();
            this.R14 = new System.Windows.Forms.Button();
            this.R13 = new System.Windows.Forms.Button();
            this.R12 = new System.Windows.Forms.Button();
            this.R11 = new System.Windows.Forms.Button();
            this.room_status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R10 = new System.Windows.Forms.Button();
            this.room_code_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R09 = new System.Windows.Forms.Button();
            this.event_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R08 = new System.Windows.Forms.Button();
            this.group_code_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.R07 = new System.Windows.Forms.Button();
            this.R06 = new System.Windows.Forms.Button();
            this.R05 = new System.Windows.Forms.Button();
            this.R04 = new System.Windows.Forms.Button();
            this.R03 = new System.Windows.Forms.Button();
            this.R02 = new System.Windows.Forms.Button();
            this.R01 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "센서신호";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.testButton_Click);
            // 
            // camera_preset_info
            // 
            this.camera_preset_info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.camera_preset_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.camera_preset_info.Font = new System.Drawing.Font("굴림", 10F);
            this.camera_preset_info.ForeColor = System.Drawing.SystemColors.Menu;
            this.camera_preset_info.Location = new System.Drawing.Point(873, 201);
            this.camera_preset_info.Margin = new System.Windows.Forms.Padding(0);
            this.camera_preset_info.Multiline = true;
            this.camera_preset_info.Name = "camera_preset_info";
            this.camera_preset_info.Size = new System.Drawing.Size(253, 16);
            this.camera_preset_info.TabIndex = 64;
            // 
            // room_detail_textBox
            // 
            this.room_detail_textBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.room_detail_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.room_detail_textBox.Font = new System.Drawing.Font("굴림", 15F);
            this.room_detail_textBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.room_detail_textBox.Location = new System.Drawing.Point(271, 224);
            this.room_detail_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.room_detail_textBox.Multiline = true;
            this.room_detail_textBox.Name = "room_detail_textBox";
            this.room_detail_textBox.Size = new System.Drawing.Size(510, 27);
            this.room_detail_textBox.TabIndex = 63;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(271, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(510, 184);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.Tag = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "event_time";
            this.dataGridViewTextBoxColumn1.HeaderText = "시간";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "group_code_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "사동";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "room_code_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "호실";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "room_status_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "상태";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "group_code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "room_code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "room_status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(873, 441);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 16);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "시스템 상태";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(787, 201);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(338, 16);
            this.textBox5.TabIndex = 61;
            this.textBox5.Text = "CCTV 화면";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(13, 441);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(854, 16);
            this.textBox4.TabIndex = 60;
            this.textBox4.Text = "알림상황";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(12, 7);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 16);
            this.textBox3.TabIndex = 59;
            this.textBox3.Text = "수감동";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 10F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(271, 201);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 16);
            this.textBox2.TabIndex = 58;
            this.textBox2.Text = "도어 상태";
            // 
            // room_textBox
            // 
            this.room_textBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.room_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.room_textBox.Font = new System.Drawing.Font("굴림", 10F);
            this.room_textBox.ForeColor = System.Drawing.SystemColors.Window;
            this.room_textBox.Location = new System.Drawing.Point(271, 7);
            this.room_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.room_textBox.Name = "room_textBox";
            this.room_textBox.Size = new System.Drawing.Size(854, 16);
            this.room_textBox.TabIndex = 57;
            this.room_textBox.Text = "1사동 상태";
            // 
            // R20
            // 
            this.R20.BackColor = System.Drawing.Color.White;
            this.R20.Location = new System.Drawing.Point(1045, 118);
            this.R20.Name = "R20";
            this.R20.Size = new System.Drawing.Size(80, 80);
            this.R20.TabIndex = 56;
            this.R20.Text = "20";
            this.R20.UseVisualStyleBackColor = false;
            this.R20.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R19
            // 
            this.R19.BackColor = System.Drawing.Color.White;
            this.R19.Location = new System.Drawing.Point(959, 118);
            this.R19.Name = "R19";
            this.R19.Size = new System.Drawing.Size(80, 80);
            this.R19.TabIndex = 55;
            this.R19.Text = "19";
            this.R19.UseVisualStyleBackColor = false;
            this.R19.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R18
            // 
            this.R18.BackColor = System.Drawing.Color.White;
            this.R18.Location = new System.Drawing.Point(873, 118);
            this.R18.Name = "R18";
            this.R18.Size = new System.Drawing.Size(80, 80);
            this.R18.TabIndex = 54;
            this.R18.Text = "18";
            this.R18.UseVisualStyleBackColor = false;
            this.R18.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // R17
            // 
            this.R17.BackColor = System.Drawing.Color.White;
            this.R17.Location = new System.Drawing.Point(787, 118);
            this.R17.Name = "R17";
            this.R17.Size = new System.Drawing.Size(80, 80);
            this.R17.TabIndex = 53;
            this.R17.Text = "17";
            this.R17.UseVisualStyleBackColor = false;
            this.R17.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // room_status
            // 
            this.room_status.HeaderText = "room_status";
            this.room_status.Name = "room_status";
            this.room_status.ReadOnly = true;
            this.room_status.Visible = false;
            // 
            // group_code
            // 
            this.group_code.HeaderText = "group_code";
            this.group_code.Name = "group_code";
            this.group_code.ReadOnly = true;
            this.group_code.Visible = false;
            // 
            // R16
            // 
            this.R16.BackColor = System.Drawing.Color.White;
            this.R16.Location = new System.Drawing.Point(701, 118);
            this.R16.Name = "R16";
            this.R16.Size = new System.Drawing.Size(80, 80);
            this.R16.TabIndex = 52;
            this.R16.Text = "16";
            this.R16.UseVisualStyleBackColor = false;
            this.R16.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R15
            // 
            this.R15.BackColor = System.Drawing.Color.White;
            this.R15.Location = new System.Drawing.Point(615, 118);
            this.R15.Name = "R15";
            this.R15.Size = new System.Drawing.Size(80, 80);
            this.R15.TabIndex = 51;
            this.R15.Text = "15";
            this.R15.UseVisualStyleBackColor = false;
            this.R15.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R14
            // 
            this.R14.BackColor = System.Drawing.Color.White;
            this.R14.Location = new System.Drawing.Point(529, 118);
            this.R14.Name = "R14";
            this.R14.Size = new System.Drawing.Size(80, 80);
            this.R14.TabIndex = 50;
            this.R14.Text = "14";
            this.R14.UseVisualStyleBackColor = false;
            this.R14.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R13
            // 
            this.R13.BackColor = System.Drawing.Color.White;
            this.R13.Location = new System.Drawing.Point(443, 118);
            this.R13.Name = "R13";
            this.R13.Size = new System.Drawing.Size(80, 80);
            this.R13.TabIndex = 49;
            this.R13.Text = "13";
            this.R13.UseVisualStyleBackColor = false;
            this.R13.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R12
            // 
            this.R12.BackColor = System.Drawing.Color.White;
            this.R12.Location = new System.Drawing.Point(357, 118);
            this.R12.Name = "R12";
            this.R12.Size = new System.Drawing.Size(80, 80);
            this.R12.TabIndex = 48;
            this.R12.Text = "12";
            this.R12.UseVisualStyleBackColor = false;
            this.R12.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R11
            // 
            this.R11.BackColor = System.Drawing.Color.White;
            this.R11.Location = new System.Drawing.Point(271, 118);
            this.R11.Name = "R11";
            this.R11.Size = new System.Drawing.Size(80, 80);
            this.R11.TabIndex = 47;
            this.R11.Text = "11";
            this.R11.UseVisualStyleBackColor = false;
            this.R11.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // room_status_name
            // 
            this.room_status_name.DataPropertyName = "room_status_name";
            this.room_status_name.HeaderText = "상태";
            this.room_status_name.Name = "room_status_name";
            this.room_status_name.ReadOnly = true;
            // 
            // R10
            // 
            this.R10.BackColor = System.Drawing.Color.White;
            this.R10.Location = new System.Drawing.Point(1045, 32);
            this.R10.Name = "R10";
            this.R10.Size = new System.Drawing.Size(80, 80);
            this.R10.TabIndex = 46;
            this.R10.Text = "10";
            this.R10.UseVisualStyleBackColor = false;
            this.R10.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // room_code_name
            // 
            this.room_code_name.DataPropertyName = "room_code_name";
            this.room_code_name.HeaderText = "호실";
            this.room_code_name.Name = "room_code_name";
            this.room_code_name.ReadOnly = true;
            // 
            // R09
            // 
            this.R09.BackColor = System.Drawing.Color.White;
            this.R09.Location = new System.Drawing.Point(959, 32);
            this.R09.Name = "R09";
            this.R09.Size = new System.Drawing.Size(80, 80);
            this.R09.TabIndex = 45;
            this.R09.Text = "9";
            this.R09.UseVisualStyleBackColor = false;
            this.R09.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // event_time
            // 
            this.event_time.DataPropertyName = "event_time";
            this.event_time.HeaderText = "시간";
            this.event_time.Name = "event_time";
            this.event_time.ReadOnly = true;
            // 
            // room_code
            // 
            this.room_code.HeaderText = "room_code";
            this.room_code.Name = "room_code";
            this.room_code.ReadOnly = true;
            this.room_code.Visible = false;
            // 
            // R08
            // 
            this.R08.BackColor = System.Drawing.Color.White;
            this.R08.Location = new System.Drawing.Point(873, 32);
            this.R08.Name = "R08";
            this.R08.Size = new System.Drawing.Size(80, 80);
            this.R08.TabIndex = 44;
            this.R08.Text = "8";
            this.R08.UseVisualStyleBackColor = false;
            this.R08.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // group_code_name
            // 
            this.group_code_name.DataPropertyName = "group_code_name";
            this.group_code_name.HeaderText = "사동";
            this.group_code_name.Name = "group_code_name";
            this.group_code_name.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.event_time,
            this.group_code_name,
            this.room_code_name,
            this.room_status_name,
            this.group_code,
            this.room_code,
            this.room_status});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(855, 147);
            this.dataGridView1.TabIndex = 4;
            // 
            // R07
            // 
            this.R07.BackColor = System.Drawing.Color.White;
            this.R07.Location = new System.Drawing.Point(787, 32);
            this.R07.Name = "R07";
            this.R07.Size = new System.Drawing.Size(80, 80);
            this.R07.TabIndex = 43;
            this.R07.Text = "7";
            this.R07.UseVisualStyleBackColor = false;
            this.R07.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R06
            // 
            this.R06.BackColor = System.Drawing.Color.White;
            this.R06.Location = new System.Drawing.Point(701, 32);
            this.R06.Name = "R06";
            this.R06.Size = new System.Drawing.Size(80, 80);
            this.R06.TabIndex = 42;
            this.R06.Text = "6";
            this.R06.UseVisualStyleBackColor = false;
            this.R06.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R05
            // 
            this.R05.BackColor = System.Drawing.Color.White;
            this.R05.Location = new System.Drawing.Point(615, 32);
            this.R05.Name = "R05";
            this.R05.Size = new System.Drawing.Size(80, 80);
            this.R05.TabIndex = 41;
            this.R05.Text = "5";
            this.R05.UseVisualStyleBackColor = false;
            this.R05.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R04
            // 
            this.R04.BackColor = System.Drawing.Color.White;
            this.R04.Location = new System.Drawing.Point(529, 32);
            this.R04.Name = "R04";
            this.R04.Size = new System.Drawing.Size(80, 80);
            this.R04.TabIndex = 40;
            this.R04.Text = "4";
            this.R04.UseVisualStyleBackColor = false;
            this.R04.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R03
            // 
            this.R03.BackColor = System.Drawing.Color.White;
            this.R03.Location = new System.Drawing.Point(443, 32);
            this.R03.Name = "R03";
            this.R03.Size = new System.Drawing.Size(80, 80);
            this.R03.TabIndex = 39;
            this.R03.Text = "3";
            this.R03.UseVisualStyleBackColor = false;
            this.R03.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R02
            // 
            this.R02.BackColor = System.Drawing.Color.White;
            this.R02.Location = new System.Drawing.Point(357, 32);
            this.R02.Name = "R02";
            this.R02.Size = new System.Drawing.Size(80, 80);
            this.R02.TabIndex = 37;
            this.R02.Text = "2";
            this.R02.UseVisualStyleBackColor = false;
            this.R02.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // R01
            // 
            this.R01.BackColor = System.Drawing.Color.White;
            this.R01.Location = new System.Drawing.Point(271, 32);
            this.R01.Name = "R01";
            this.R01.Size = new System.Drawing.Size(80, 80);
            this.R01.TabIndex = 35;
            this.R01.Text = "1";
            this.R01.UseVisualStyleBackColor = false;
            this.R01.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1113, 147);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 406);
            this.panel1.TabIndex = 33;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(787, 220);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(333, 218);
            this.axVLCPlugin21.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 618);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.camera_preset_info);
            this.Controls.Add(this.room_detail_textBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.room_textBox);
            this.Controls.Add(this.R20);
            this.Controls.Add(this.R19);
            this.Controls.Add(this.R18);
            this.Controls.Add(this.R17);
            this.Controls.Add(this.R16);
            this.Controls.Add(this.R15);
            this.Controls.Add(this.R14);
            this.Controls.Add(this.R13);
            this.Controls.Add(this.R12);
            this.Controls.Add(this.R11);
            this.Controls.Add(this.R10);
            this.Controls.Add(this.R09);
            this.Controls.Add(this.R08);
            this.Controls.Add(this.R07);
            this.Controls.Add(this.R06);
            this.Controls.Add(this.R05);
            this.Controls.Add(this.R04);
            this.Controls.Add(this.R03);
            this.Controls.Add(this.R02);
            this.Controls.Add(this.R01);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox camera_preset_info;
        private System.Windows.Forms.TextBox room_detail_textBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox room_textBox;
        private System.Windows.Forms.Button R20;
        private System.Windows.Forms.Button R19;
        private System.Windows.Forms.Button R18;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button R17;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code;
        private System.Windows.Forms.Button R16;
        private System.Windows.Forms.Button R15;
        private System.Windows.Forms.Button R14;
        private System.Windows.Forms.Button R13;
        private System.Windows.Forms.Button R12;
        private System.Windows.Forms.Button R11;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_status_name;
        private System.Windows.Forms.Button R10;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_code_name;
        private System.Windows.Forms.Button R09;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_code;
        private System.Windows.Forms.Button R08;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button R07;
        private System.Windows.Forms.Button R06;
        private System.Windows.Forms.Button R05;
        private System.Windows.Forms.Button R04;
        private System.Windows.Forms.Button R03;
        private System.Windows.Forms.Button R02;
        private System.Windows.Forms.Button R01;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
    }
}

