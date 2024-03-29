﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Properties;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class Connection
    {
        private MySqlCommand cmd { set; get; }
        private MySqlConnection conn { set; get; }
        private string connection { set; get; }
        private string server { set; get; }
        private string database { set; get; }
        private string user { set; get; }
        private string password { set; get; }
        private string door { set; get; }
        private string charset { set; get; }

        public static string ErrorMessage { private set; get; }
        public static long LastInsertID { private set; get; }
        public static DataTable SelectedTable { private set; get; }

        // Define a linha de conexão.
        private void SetConnInfo()
        {
            this.server = Settings.Default.Server;
            this.database = Settings.Default.Database;
            this.user = Settings.Default.User;
            this.password = Settings.Default.Password;
            this.door = Settings.Default.Port;
            this.charset = Settings.Default.Charset;

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
