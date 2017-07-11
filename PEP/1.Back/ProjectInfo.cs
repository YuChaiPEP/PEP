using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PEP
{
    public class ProjectInfo
    {
        private SQLHandler sql;
        private int pid;
        public ProjectInfo()
        {
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
            this.pid = -1;
        }
        ~ProjectInfo()
        {
            sql.SQLDisconnect();
        }
        public void identifyProject(String p)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "pname='" + p + "'");
            dr.Read();
            this.pid = (int)dr["pid"];
            dr.Close();
        }
        public MySqlDataReader getDetail()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "pid=" + this.pid);
            return dr;
        }
        public MySqlDataReader getTaskInfo()
        {
            MySqlDataReader dr = this.sql.SQLGet("tasks.tname,projects2tasks.*", "tasks,projects2tasks", "projects2tasks.pid=" + this.pid + " and tasks.tid = projects2tasks.tid order by ord");
            return dr;
        }
        
        public void submitLog(int uid, String time, String tname, String content)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tname='" + tname + "'");
            dr.Read();
            int tid = (int)dr["tid"];
            dr.Close();
            this.sql.SQLInsertOneEntry("logs(uid,timestamp,pid,tid,content)", "(" + uid + ",'" + time + "'," + this.pid + "," + tid + ",'" + content + "')");
        }

        public MySqlDataReader getLogInfo()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid);
            return dr;
        }

        public void modifyDetail(String pname)
        {
            this.sql.SQLUpdate("projects", "pname='" + pname+"'", "pid=" + this.pid);
        }
        public void modifyTask(ListBox lb)
        {
            this.sql.SQLDelete("projects2tasks", "pid=" + this.pid);
            int i = 0;
            foreach (object obj in lb.Items)
            {
                MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tname='" + obj.ToString() + "'");
                dr.Read();
                int tid = (int)dr["tid"];
                dr.Close();
                this.sql.SQLInsertOneEntry("projects2tasks(pid,tid,task_state,ord)", "(" + this.pid + "," + tid + ",'未开始'," + ++i + ")");
            }
        }
    }
}
