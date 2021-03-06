﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/************************2017/7/14*****************************
 * 
 * Back.ProjectInfo
 * 功能：处理接口层与项目有关的操作，包括当前项目的相关信息与所有项目的相关信息
 * 主要接口：identify, task, member, log, create, modify
 * 注意事项：部分接口涉及mysql的多表查询，查询项为字符串时一定加单引号
 * 
 *************************************************************/

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
        /*项目管理*/
        public void identifyProject(String p)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "pname='" + p + "'");
            if (dr.Read())
                this.pid = (int)dr["pid"];
            else
                this.pid = -1;
            dr.Close();
        }

        public void clearProject()
        {
            this.pid = -1;
        }
        /*项目个人接口*/
        public int getPid()
        {
            return this.pid;
        }
        public MySqlDataReader getDetail()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "pid=" + this.pid);
            return dr;
        }
        public MySqlDataReader getTaskInfo()
        {
            //多表查询，注意查询结果进行阅读时，注意列名（建议在数据库中输入查询语句观察列名）
            MySqlDataReader dr = this.sql.SQLGet("tasks.tname,projects2tasks.*", "tasks,projects2tasks", "projects2tasks.pid=" + this.pid + " and tasks.tid = projects2tasks.tid order by ord");
            return dr;
        }
        public MySqlDataReader getMember()
        {
            MySqlDataReader dr = this.sql.SQLGet("users.* ", "users, users2projects", "users2projects.pid = " + this.pid + " and users.uid = users2projects.uid");
            return dr;
        }
        public void submitLog(int uid, String time, String tname, String content, String filename)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tname='" + tname + "'");
            dr.Read();
            int tid = (int)dr["tid"];
            dr.Close();
            if (filename == null)
            {
                this.sql.SQLInsertOneEntry("logs(uid,timestamp,pid,tid,content)", "(" + uid + ",'" + time + "'," + this.pid + "," + tid + ",'" + content + "')");
            }
            else
            {
                this.sql.SQLInsertOneEntry("logs(uid,timestamp,pid,tid,content,filename)", "(" + uid + ",'" + time + "'," + this.pid + "," + tid + ",'" + content + "','" + filename + "')");
            }
        }

        public void submitFile(String tname, String filename)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "tname='" + tname + "'");
            dr.Read();
            int tid = (int)dr["tid"];
            dr.Close();
            this.sql.SQLInsertOneEntry("projects2files(pid,tid,filename)", "(" + this.pid + "," + tid + ",'" + filename + "')");
        }

        public MySqlDataReader getLogInfo(int lid = -1, int uid = -1, bool watch = true)
        {
            MySqlDataReader dr = null;
            if (lid == -1)
            {
                if (uid == -1)
                {
                    dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid);
                }
                else if (watch)
                {
                    dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid + " and uid=" + uid);
                }
                else
                {
                    dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid + " and uid!=" + uid);
                }
            }
            else
            {
                dr = this.sql.SQLGet("*", "logs", "pid=" + this.pid + " and lid=" + lid);
            }
            return dr;
        }

        public MySqlDataReader getFileInfo(String tname)
        {
            int tid = new TaskInfo().getTaskID(tname);
            return this.sql.SQLGet("*", "projects2files", "pid=" + this.pid + " and tid=" + tid);
        }

        public void modifyDetail(String pname, int stateNo)
        {
            string state = "";
            if (stateNo == 1)
                state = "进行中";
            if (stateNo == 2)
                state = "暂停中";
            this.sql.SQLUpdate("projects", "pname='" + pname+ "',project_state='" + state + "'", "pid=" + this.pid);
        }
        public void modifyTask(List<string> lb)
        {
            this.sql.SQLDelete("projects2tasks", "pid=" + this.pid);
            int i = 0;
            foreach (string tname in lb)
            {
                TaskInfo task = new TaskInfo();
                int tid = task.getTaskID(tname);
                this.sql.SQLInsertOneEntry("projects2tasks(pid,tid,task_state,ord)", "(" + this.pid + "," + tid + ",'未开始'," + ++i + ")");
            }
            this.sql.SQLUpdate("projects", "task=" + lb.Count, "pid=" + this.pid);
        }
        public void modifyPerson(List<string> lb)
        {
            this.sql.SQLDelete("users2projects", "pid=" + this.pid);
            foreach (string uname in lb)
            {
                UserInfo user = new UserInfo(uname);
                int uid = user.getUID();
                this.sql.SQLInsertOneEntry("users2projects(uid,pid)", "(" + uid + "," + this.pid + ")");
            }
        }
        public void modifyChecker(String tname, bool empty, String uname)
        {
            //checker可能为空，需单独处理，否则数据库中存入的不是null而是空字符串，可能引发bug
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

        public void modifyLogChecked(int lid, bool check)
        {
            String state = "";
            if (check)
                state = "已批阅";
            else
                state = "未批阅";
            this.sql.SQLUpdate("logs", "checked='" + state + "'", "pid=" + this.pid + " and lid=" + lid);
        }

        public void modifyProcess(String tname, String p, String date) //输入字符串d为"xxxx年yy月zz日"格式，统一格式在下层就要处理完毕
        {
            TaskInfo task = new TaskInfo();
            int tid = task.getTaskID(tname);
            int y = 0;
            int m = 0;
            int d = 0;
            parseDate(date, ref y, ref m, ref d);
            String afterdate = "" + y + "-" + m + "-" + d + " 00:00:00";
            this.sql.SQLUpdate("projects2tasks", "task_state='" + p + "',deadline='"+afterdate+"'", "pid=" + this.pid + " and tid=" + tid);
        }

        public void finishProject()
        {
            this.sql.SQLUpdate("projects", "project_state='已完成'", "pid=" + this.pid);
            this.pid = -1;
        }

        public void abortProject()
        {
            this.sql.SQLDelete("projects", "pid="+this.pid);
            this.sql.SQLDelete("users2projects", "pid=" + this.pid);
            this.sql.SQLDelete("projects2tasks", "pid=" + this.pid);
            this.sql.SQLDelete("projects2files", "pid=" + this.pid);
            this.sql.SQLDelete("logs", "pid=" + this.pid);
            this.pid = -1;
        }
        /*项目通用接口*/
        public void createProject(string pname, string time, int manager_id, List<string> tasks, List<string> persons)
        {
            this.sql.SQLInsertOneEntry("projects(pname,timestamp,task,process,manager_id,project_state)", "('" + pname + "','" + time + "'," + tasks.Count + ",0," + manager_id + ",'进行中')");
            MySqlDataReader dr = this.sql.SQLGet("pid", "projects", "pname='" + pname + "'");
            int pid = -1;
            if (dr.Read())
                pid = Convert.ToInt32(dr["pid"]);
            dr.Close();
            int ord = 1;
            TaskInfo task = new TaskInfo();
            foreach (string tname in tasks)
            {
                int tid = task.getTaskID(tname);
                this.sql.SQLInsertOneEntry("projects2tasks(pid, tid, task_state, ord)", "(" + pid + "," + tid + ",'未开始'," + ord + ")");
                ++ord;
            }
            foreach (string uname in persons)
            {
                UserInfo user = new UserInfo(uname);
                int uid = user.getUID();
                this.sql.SQLInsertOneEntry("users2projects", "(" + uid + "," + pid + ")");
            }
        }
        public String searchProject(int pid)
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "projects", "pid=" + pid);
            dr.Read();
            String pname = dr["pname"].ToString();
            dr.Close();
            return pname;
        }
        public int getMaxPid()
        {
            MySqlDataReader dr = this.sql.SQLGet("max(pid)", "projects", "true");
            dr.Read();
            int x = Convert.ToInt32(dr["max(pid)"]);
            dr.Close();
            return x;
        }
        private void parseDate(String date, ref int year, ref int month, ref int day) //输入为"xxxx年yy月zz日"，解析xxxx/yy/zz
        {
            String [] tmp1 = date.Split('年');
            year = Convert.ToInt32(tmp1[0]);
            String[] tmp2 = tmp1[1].Split('月');
            month = Convert.ToInt32(tmp2[0]);
            String[] tmp3 = tmp2[1].Split('日');
            day = Convert.ToInt32(tmp3[0]);
        }
    }
}
