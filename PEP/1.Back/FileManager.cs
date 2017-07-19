using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP
{
    class FileManager
    {
        private static string IP = @"ftp://192.168.158.117/";
        private static string username = "";
        private static string password = "";
        private static string logFilePath = @"log_file";
        private static string taskFilePath = @"task_file";

        public static bool uploadLogFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
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
            FtpHandler ftp = new FtpHandler(IP, username, password);
            sourceName = logFilePath + "/" + pname + "/" + tname + "/" + sourceName;
            return ftp.download(sourceName, targetName);
        }

        public static bool uploadTaskFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
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
            FtpHandler ftp = new FtpHandler(IP, username, password);
            sourceName = taskFilePath + "/" + pname + "/" + tname + "/" + sourceName;
            return ftp.download(sourceName, targetName);
        }
    }
}
