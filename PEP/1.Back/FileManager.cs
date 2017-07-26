using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************2017/7/26*****************************
 * 
 * Back.FileManager
 * 功能：对项目的任务和日志文件进行管理
 * 主要接口：download, upload, delete
 * 注意事项：日志文件和项目文件分别在ftp的log_file和task_file文件夹中
 * 
 *************************************************************/

namespace PEP
{
    class FileManager
    {
        private static string logFilePath = @"log_file";
        private static string taskFilePath = @"task_file";

        public static bool uploadLogFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler();
            if (!ftp.exists(logFilePath, pname))
            {
                ftp.createDirectory(logFilePath + "/" + pname);
            }
            if (!ftp.exists(logFilePath + "/" + pname, tname))
            {
                ftp.createDirectory(logFilePath + "/" + pname + "/" + tname);
            }
            targetName = logFilePath + "/" + pname + "/" + tname + "/" + targetName;
            return ftp.upload(targetName, sourceName);
        }
        
        public static bool downloadLogFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler();
            sourceName = logFilePath + "/" + pname + "/" + tname + "/" + sourceName;
            return ftp.download(sourceName, targetName);
        }

        public static bool uploadTaskFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler();
            if (!ftp.exists(taskFilePath, pname))
            {
                ftp.createDirectory(taskFilePath + "/" + pname);
            }
            if (!ftp.exists(taskFilePath + "/" + pname, tname))
            {
                ftp.createDirectory(taskFilePath + "/" + pname + "/" + tname);
            }
            targetName = taskFilePath + "/" + pname + "/" + tname + "/" + targetName;
            return ftp.upload(targetName, sourceName);
        }

        public static bool downloadTaskFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler();
            sourceName = taskFilePath + "/" + pname + "/" + tname + "/" + sourceName;
            return ftp.download(sourceName, targetName);
        }

        public static void deleteProjectFiles(string pname)
        {
            FtpHandler ftp = new FtpHandler();
            ftp.delete(logFilePath + "/" + pname);
            ftp.delete(taskFilePath + "/" + pname);
        }

        public static void renameProjectDirectory(string oldName, string newName)
        {
            FtpHandler ftp = new FtpHandler();
            ftp.rename(logFilePath + "/" + oldName, newName);
            ftp.rename(taskFilePath + "/" + oldName, newName);
        }
    }
}
