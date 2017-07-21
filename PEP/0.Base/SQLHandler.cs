using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

/************************2017/7/19*****************************
 * 
 * Base.SQLHandler
 * 功能：处理底层与mysql相关的增删改查操作
 * 主要接口：connect, insert, delete, update, get
 * 注意事项：新建类后需要执行connect操作，释放类前需要执行disconnect操作，get到reader后读取完需要立即close
 *           若查询条件中出现字符串，需要前后加单引号* 
 *************************************************************/

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
            //example: insert into table1(column1, column2) values("exp1", 666)
            String cmd = "insert into " + target + " values" + value;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public void SQLDelete(String table, String condition)
        {
            //example: delete from table1 where column1=233
            String cmd = "delete from " + table + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public void SQLUpdate(String table, String content, String condition)
        {
            //example: update table1 set column1="exp1" where column2="exp2"
            String cmd = "update " + table + " set " + content + " where " + condition;
            MySqlDataReader result = SQLExecute(cmd);
            result.Close();
        }
        public bool SQLQuery(String table, String condition)
        {
            //仅用来判断符合的表项是否存在
            //example: select from table1 where true
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
            //用来读取满足指定条件的数据库内容
            //example: select from table1 where true
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
            //数据库配置，若数据库变化，需要修改该配置内容
            String server = "172.16.90.73";
            String db = "pep";
            String uid = "root";
            String pwd = "123456";
            String charset = "utf8";
            return "server=" + server + ";database=" + db + ";user id=" + uid + ";password=" + pwd + ";charset=" + charset + ";";
        }
    }
}
