using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

/************************2017/7/17*****************************
 * 
 * Back.Loader
 * 功能：处理接口层与载入数据相关的操作，用于将某些版本的数据文件加载入当前数据库
 * 主要接口：load
 * 注意事项：老版本的数据文件用.txt存储，由原excel文件另存为得到
 *           为导入数据方便，本文件处理的原excel每个单元格若存在换行符，需要手动清理掉\r\n
 *           ATTR11 \t ATTR12 \t ATTR13 \t ATTR14 \r\n
 *           ATTR21 \t ATTR22 \t ATTR23 \t ATTR24 \r\n
 *           加载正确顺序：用户、推送、项目、任务、项目任务、项目人员
 * 
 *************************************************************/

namespace PEP
{
    class Loader
    {
        private SQLHandler sql;
        private FileHandler file;

        public Loader()
        {
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
        }
        ~Loader()
        {
            this.sql.SQLDisconnect();
        }
        public bool loadPush(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    UserInfo user = new UserInfo(subarray[1]);
                    this.sql.SQLInsertOneEntry("pushs(uid, timestamp, push)", "("+ user.getUID() +",'" + subarray[2] + "','" + subarray[3] + "')");
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool loadUser(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    String is_manager = "N";
                    String post = "其它";
                    if (subarray[3] == "1")
                    {
                        is_manager = "Y";
                        post = "管理人员";
                    }
                    for (int j = 4; j < 12; j ++)
                    {
                        if (subarray[j] == "1")
                        {
                            post = (array[0].Split('\t'))[j];
                        }
                    }
                    this.sql.SQLInsertOneEntry("users(uname, password, is_manager, post)", "('" + subarray[1] + "','" + CryptoHandler.MD5Encrypt(subarray[2]) + "','"+is_manager+"','"+ post +"')");
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool loadProject(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    UserInfo user = new UserInfo(subarray[2]);
                    this.sql.SQLInsertOneEntry("projects(pname, timestamp, manager_id, project_state)", "('" + subarray[1] + "','" + subarray[3] + "'," + user.getUID() + ",'进行中')");
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool loadTask(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    TaskInfo task = new TaskInfo();
                    if (task.getTaskID(subarray[4]) == -1)
                        this.sql.SQLInsertOneEntry("tasks(tname)", "('"+subarray[4]+"')");
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool loadProjectTask(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                String last = "";
                int index = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    ProjectInfo pro = new ProjectInfo();
                    pro.identifyProject(subarray[2]);
                    int pid = pro.getPid();
                    if (subarray[2] != last)
                    {
                        index = 1;
                        last = subarray[2];
                    }
                    else
                    {
                        index++;
                    }
                    TaskInfo task = new TaskInfo();
                    int tid = task.getTaskID(subarray[4]);
                    this.sql.SQLInsertOneEntry("projects2tasks(pid,tid,task_state,ord)", "(" + pid + "," + tid + ",'未开始'," + index + ")");
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true; 
        }

        public bool loadUserProject(String address, String file)
        {
            try
            {
                String content = FileHandler.fileRead(address, file);
                String[] array = content.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                String last = "";
                for (int i = 1; i < array.Length; i++)
                {
                    String[] subarray = array[i].Split('\t');
                    if (subarray[3] == "1")
                        continue;
                    UserInfo user = new UserInfo(subarray[1]);
                    ProjectInfo pro = new ProjectInfo();
                    String[] spearray = subarray[14].Split(';');
                    for (int j = 0; j < spearray.Length; j++)
                    {
                        pro.identifyProject(spearray[j]);
                        if (pro.getPid() == -1)
                            continue;
                        this.sql.SQLInsertOneEntry("users2projects(uid,pid)", "(" + user.getUID() + "," + pro.getPid() + ")");
                    }
                    GC.Collect();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
