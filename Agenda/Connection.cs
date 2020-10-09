using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class Connection
    {
        private MySqlCommand cmd;
        private MySqlConnection conn;
        private string connection;

        private string server;
        private string database;
        private string user;
        private string password;
        private string door;
        private string charset;

        public static string ErrorMessage;
        public static long LastInsertID;
        public static DataTable SelectedTable;

        // Define a linha de conexão.
        private void SetConnInfo()
        {
            this.server = "127.0.0.1";
            this.database = "teste";
            this.user = "root";
            this.password = "root";
            this.door = "3306";
            this.charset = "utf8";

            this.connection = "SERVER =" + this.server + ";";
            this.connection += "DATABASE =" + this.database + ";";
            this.connection += "UID =" + this.user + ";";
            this.connection += "PASSWORD =" + this.password + ";";
            this.connection += "PORT =" + this.door + ";";
            this.connection += "CHARSET =" + this.charset + ";";
        }

        private MySqlConnection Conn()
        {
            SetConnInfo();
            this.conn = new MySqlConnection(connection);
            this.conn.Open();
            return this.conn;
        }

        public static bool ConnectionTest()
        {
            Connection connection = new Connection();
            try
            {
                MySqlConnection conn = connection.Conn();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Connection.ErrorMessage = e.Message;
                return false;
            }
        }

        protected bool Execute()
        {
            try
            {
                this.cmd.Connection = Conn();
                this.cmd.ExecuteNonQuery();
                Connection.LastInsertID = this.cmd.LastInsertedId;
                this.conn.Close();
                return true;
            }
            catch (Exception e)
            {
                this.conn.Close();
                Connection.ErrorMessage = e.Message;
                return false;
            }
        }

        protected bool ExecuteQuery()
        {
            try
            {
                DataTable table = new DataTable();
                this.cmd.Connection = Conn();
                MySqlDataAdapter data = new MySqlDataAdapter(this.cmd);
                data.Fill(table);
                this.conn.Close();
                Connection.SelectedTable = table;
                return true;
            }
            catch (Exception e)
            {
                this.conn.Close();
                Connection.ErrorMessage = e.Message;
                return false;
            }
        }


        protected void TextCommand(string sql)
        {
            this.cmd = new MySqlCommand(sql);
            this.cmd.CommandType = CommandType.Text;
        }

        protected void SPCommand(string sql)
        {
            this.cmd = new MySqlCommand(sql);
            this.cmd.CommandType = CommandType.StoredProcedure;
        }

        protected void AddParameter(string parameter, object value)
        {
            this.cmd.Parameters.AddWithValue(parameter, value);
        }
    }
}
