using Npgsql;
using System.Data;

namespace Winform
{
    public class DBConnection
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand query = null;
        private NpgsqlDataAdapter da;

        /// <summary>
        /// DB 연결 정보 (Host, Username, Password, Database)
        /// </summary>
        private string dbSource = "Host=" + Properties.DBProperties.Default.Host + ";" +
            "Username=" + Properties.DBProperties.Default.Username + ";" +
            "Password=" + Properties.DBProperties.Default.Password + ";" +
            "Database=" + Properties.DBProperties.Default.Database;

        /// <summary>
        /// DB 연결
        /// </summary>
        public void Open()
        {
            conn = new NpgsqlConnection(dbSource);
            conn.Open();
        }

        /// <summary>
        /// DB close
        /// </summary>
        public void Close()
        {
            conn.Close();
        }

        /// <summary>
        /// Update query
        /// </summary>
        /// <param name="sql">SQL query</param>
        public void Update(string sql)
        {
            query = new NpgsqlCommand(sql, conn);
            query.ExecuteNonQuery();
            query.Dispose();
        }

        /// <summary>
        /// Select return DataTable
        /// </summary>
        /// <param name="sql">SQL query</param>
        public DataTable SelectDataTable(string sql)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            ds.Dispose();
            return dt;
        }
    }
}
