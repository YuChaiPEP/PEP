using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/************************2017/7/14*****************************
 * 
 * Back.TaskInfo
 * 功能：处理接口层与任务有关的操作，主要为所有项目的相关信息
 * 主要接口：get, search
 * 注意事项：-
 * 
 *************************************************************/

namespace PEP
{
    class TaskInfo
    {
        private SQLHandler sql;
        public TaskInfo()
        {
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
        }
        ~TaskInfo()
        {
            sql.SQLDisconnect();
        }
        public MySqlDataReader getAllTask()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "1=1 order by tid");
            return dr;
        }
        public int getTaskID(String tname)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tname='" + tname + "'"); //单引号
            int tid;
            if (dr.Read())
                tid = (int)dr["tid"];
            else
                tid = -1;
            dr.Close();
            return tid;
        }
        public String searchTask(int tid)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tid=" + tid);
            dr.Read();
            String uname = dr["tname"].ToString();
            dr.Close();
            return uname;
        }
    }
}
