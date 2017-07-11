using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PEP
{
    class SQLHandler
    {
        private MySqlConnection connect;
        public void SQLConnect()
        {
            String mysqlConfigure = SQLConfigure();
            this.connect = new MySqlConnection(mysqlConfigure);
            this.connect.Open();
        }
        public void SQLDisconnect()
        {
            this.connect.Close();
        }
        public void SQLInsertOneEntry(String target, String value)
        {
            String cmd = "insert into " + target + " values" + value;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public void SQLDelete(String table, String condition)
        {
            String cmd = "delete from " + table + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public void SQLUpdate(String table, String content, String condition)
        {
            String cmd = "update " + table + " set " + content + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public bool SQLQuery(String table, String condition)
        {
            String cmd = "select * from " + table + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            if (result.HasRows)
            {
                result.Close();
                return true;
            }
            else
            {
                result.Close();
                return false;
            }
        }
        public MySqlDataReader SQLGet(String column, String table, String condition)
        {
            String cmd = "select " + column + " from " + table + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            return result;
        }
        private MySqlDataReader SQLExecute(String cmd)
        {
            MySqlCommand exe = new MySqlCommand(cmd, this.connect);
            return exe.ExecuteReader();
        }
        private String SQLConfigure()
        {
            String server = "127.0.0.1";
            String db = "pep_yy";
            String uid = "root";
            String pwd = "123456";
            String charset = "utf8";
            return "server=" + server + ";database=" + db + ";user id=" + uid + ";password=" + pwd + ";charset=" + charset + ";";
        }
    }
}
