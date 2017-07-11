using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PEP
{
    public class UserInfo
    {
        private int uid;
        private String uname;
        private SQLHandler sql;
        public UserInfo(String u)
        {
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
            this.uid = -1;
            this.uname = u;
            identifyUser(u);
        }
        ~UserInfo()
        {
            this.sql.SQLDisconnect();
        }
        public int getUID()
        {
            return this.uid;
        }
        public String getUname()
        {
            return this.uname;
        }
        public bool isManager()
        {
            return this.sql.SQLQuery("users", "uid="+this.uid +" and is_manager='Y'");
        }
        private void identifyUser(String u)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "users",  "uname='" + u + "'");
            dr.Read();
            this.uid = (int)dr["uid"];
            dr.Close();
        }
        public MySqlDataReader getAttendedProjects()
        {
            MySqlDataReader dr = this.sql.SQLGet("projects.*", "projects,users2projects", "users2projects.uid=" + this.uid + " and projects.pid=users2projects.pid");
            return dr;
        }
        public MySqlDataReader getManagedProjects()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "manager_id=" + this.uid);
            return dr;
        }
        public String searchUser(int uid)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "users", "uid=" + uid);
            dr.Read();
            String uname = dr["uname"].ToString();
            dr.Close();
            return uname;
        }
        public MySqlDataReader getAllUser()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "users", "1=1 order by uid");
            return dr;
        }
        public String getAttendedProjectsCount()
        {
            MySqlDataReader dr = this.sql.SQLGet("count(projects.pid)", "projects,users2projects", "users2projects.uid=" + this.uid + " and projects.pid=users2projects.pid");
            dr.Read();
            String count = dr["count(projects.pid)"].ToString();
            dr.Close();
            return count;
        }
        public String getLogCount()
        {
            MySqlDataReader dr = this.sql.SQLGet("count(lid)", "logs", "uid=" + this.uid);
            dr.Read();
            String count = dr["count(lid)"].ToString();
            dr.Close();
            return count;
        }
        public String getPushCount()
        {
            MySqlDataReader dr = this.sql.SQLGet("count(fid)", "pushs", "uid=" + this.uid);
            dr.Read();
            String count = dr["count(fid)"].ToString();
            dr.Close();
            return count;
        }
    }
}
