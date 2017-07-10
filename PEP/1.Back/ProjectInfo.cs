using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            MySqlDataReader dr = this.sql.SQLGet("tasks.tname,projects2tasks.*", "tasks,projects2tasks", "projects2tasks.pid=" + this.pid + " and tasks.tid = projects2tasks.tid");
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
        public void modifyDetail(String pname)
        {
            this.sql.SQLUpdate("projects", "pname='" + pname+"'", "pid=" + this.pid);
        }
    }
}
