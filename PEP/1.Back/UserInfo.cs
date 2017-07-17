using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

/************************2017/7/14*****************************
 * 
 * Back.UserInfo
 * 功能：处理接口层与用户有关的操作，包括当前用户的相关信息与所有用户的相关信息
 * 主要接口：attended, managed, count, modify
 * 注意事项：部分接口涉及mysql的多表查询，查询项为字符串时一定加单引号
 *           users表的is_manager是枚举类型，只有'Y'和'N'值
 *           项目的状态分为进行中、暂停中和已完成，active特指进行中状态，live指代进行中和暂停中两个状态
 * 
 *************************************************************/

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
            identifyUser(u); //已登录用户不可切换
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
        public MySqlDataReader getAttendedActiveProjects()
        {
            MySqlDataReader dr = this.sql.SQLGet("projects.*", "projects,users2projects", "users2projects.uid=" + this.uid + " and projects.pid=users2projects.pid and projects.project_state='进行中'");
            return dr;
        }
        public MySqlDataReader getManagedLiveProjects()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "manager_id=" + this.uid + " and project_state!='已完成'");
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
        public int modifyPwd(String oldpwd, String newpwd, String repeat)
        {
            //调用者需要对返回值进行处理
            if (newpwd == "" || repeat == "")
                return 1;//password should not be empty
            if (newpwd != repeat)
                return 2;//password should be equal to repeated one
            if (!this.sql.SQLQuery("users", "uid=" + this.uid + " and password='" + CryptoHandler.MD5Encrypt(oldpwd) + "'"))
                return 3;//old password is wrong
            this.sql.SQLUpdate("users", "password='" + CryptoHandler.MD5Encrypt(newpwd) + "'", "uid=" + this.uid);
            return 0;//password modify successfully
        }
    }
}
