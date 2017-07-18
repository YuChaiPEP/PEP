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

        public static bool uploadLogFile(string sourceName, string targetName)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
            targetName = @"log_file/" + targetName;
            return ftp.upload(targetName, sourceName);
        }
        
        public static bool downloadLogFile(string sourceName, string targetName)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
            sourceName = @"log_file/" + sourceName;
            return ftp.download(sourceName, targetName);
        }

        public void uploadTaskFile(string filename)
        {

        }

        public void downloadTaskFile(string filename)
        {

        }
    }
}
