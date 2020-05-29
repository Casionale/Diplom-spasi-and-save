using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Diplom2
{
    public class MySQLWorker
    {
        private string user;
        private string password;
        private string db;
        private string server;
        MySqlConnection conn;

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Db { get => db; set => db = value; }
        public string Server { get => server; set => server = value; }

        public MySQLWorker()
        {
            this.User = "root";
            this.Password = "";
            this.Db = "ремонтиукладкакровли";
            this.Server = "localhost";
        }

        public MySQLWorker(string user, string password, string db, string server) 
        {
            this.User = user;
            this.Password = password;
            this.Db = db;
            this.Server = server;
        }

        public void Connection()
        {
            MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder();
            csb.UserID = User;
            csb.Password = Password;
            csb.Database = Db;
            csb.Server = Server;
            conn = new MySqlConnection(csb.ToString());
            try
            {
                conn.Open();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Соединение не удалось!","Ошибка соединения с сервером",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public List<string> GetTableNames() 
        {
            conn.Open();
            List <string> tableNames = new List<string>();
            string sqlCommand = "SHOW TABLES";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tableNames.Add(dr.GetString(0));
            }
            conn.Close();
            return tableNames;
        }

        public List<Field> GetFieldsInTable(string table)
        {
            List<Field> fields = new List<Field>();
            conn.Open();
            string sqlCommand = "SHOW COLUMNS FROM `"+table+"`";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string key, defaul, extra;
                try 
                {
                    key = dr.GetString(3);
                    if (key == "PRI")
                        key = "PK";
                    if (key == "MUL")
                        key = "FK";
                }
                catch 
                {
                    key = "";
                }
                try 
                {
                    defaul = dr.GetString(4);
                }
                catch 
                {
                    defaul = "";
                }
                try 
                {
                    extra = dr.GetString(5);
                }
                catch 
                {
                    extra = "";
                }
                Field field = new Field(key, dr.GetString(0), dr.GetString(1),
                                        dr.GetString(2), defaul, extra);
                fields.Add(field);
            }
            conn.Close();
            return fields;
        }

        public List<Relationship> GetRelationships(List<string> tables)
        {
            List<Relationship> rel = new List<Relationship>();
            
            foreach (string table in tables)
            {
                conn.Open();
                string sqlCommand = "SELECT TABLE_NAME, COLUMN_NAME, CONSTRAINT_NAME, " +
                                    "REFERENCED_TABLE_NAME,REFERENCED_COLUMN_NAME " +
                                    "FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE " +
                                    "WHERE TABLE_NAME LIKE '"+table+"' AND CONSTRAINT_NAME != 'PRIMARY'";
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Relationship r = new Relationship(dr.GetString(0), dr.GetString(1), dr.GetString(2),
                                                        dr.GetString(3), dr.GetString(4));
                    rel.Add(r);
                }
                conn.Close();
            }
            
            return rel;
        }

        public DataTable GetResultCommand(string sqlCommand)
        {
            try
            {
                conn.Open();
                DataTable t = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(t);
                conn.Close();
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            
        }
    }
}
