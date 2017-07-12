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
        public MySqlDataReader getMember()
        {
            MySqlDataReader dr = this.sql.SQLGet("users.* ", "users, users2projects", "users2projects.pid = " + this.pid + " and users.uid = users2projects.uid");
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

        public MySqlDataReader getLogInfo(int lid = -1)
        {
            MySqlDataReader dr;
            if (lid == -1)
            {
                dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid);
            } else
            {
                dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid + " and lid=" + lid);
            }
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
                TaskInfo task = new TaskInfo();
                int tid = task.getTaskID(obj.ToString());
                this.sql.SQLInsertOneEntry("projects2tasks(pid,tid,task_state,ord)", "(" + this.pid + "," + tid + ",'未开始'," + ++i + ")");
            }
        }
        public void modifyPerson(ListBox lb)
        {
            this.sql.SQLDelete("users2projects", "pid=" + this.pid);
            int i = 0;
            foreach (object obj in lb.Items)
            {
                UserInfo user = new UserInfo(obj.ToString());
                int uid = user.getUID();
                this.sql.SQLInsertOneEntry("users2projects(uid,pid)", "(" + uid + "," + this.pid + ")");
            }
        }
        public void modifyChecker(String tname, bool empty, String uname)
        {
            if (empty)
            {
                TaskInfo task = new TaskInfo();
                int tid = task.getTaskID(tname);
                this.sql.SQLUpdate("projects2tasks", "checker=null", "pid=" + this.pid + " and tid=" + tid);
            }
            else
            {
                TaskInfo task = new TaskInfo();
                int tid = task.getTaskID(tname);
                this.sql.SQLUpdate("projects2tasks", "checker='"+uname+"'", "pid=" + this.pid + " and tid=" + tid);
            }
        }

        public void modifyLogChecked(int lid, string check)
        {
            this.sql.SQLUpdate("logs", "checked='" + check + "'", "pid=" + this.pid + " and lid=" + lid);
        }

        public void modifyProcess(String tname, String p)
        {
            TaskInfo task = new TaskInfo();
            int tid = task.getTaskID(tname);
            this.sql.SQLUpdate("projects2tasks", "task_state='" + p + "'", "pid=" + this.pid + " and tid=" + tid);
        }
    }
}
