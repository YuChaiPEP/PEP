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

        public static bool uploadLogFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
            if (!ftp.exists(@"log_file", pname))
            {
                ftp.createDirectory(@"log_file/" + pname);
            }
            if (!ftp.exists(@"log_file/" + pname, tname))
            {
                ftp.createDirectory(@"log_file/" + pname + "/" + tname);
            }
            targetName = @"log_file/" + pname + "/" + tname + "/" + targetName;
            return ftp.upload(targetName, sourceName);
        }
        
        public static bool downloadLogFile(string sourceName, string targetName, string pname, string tname)
        {
            FtpHandler ftp = new FtpHandler(IP, username, password);
            sourceName = @"log_file/" + pname + "/" + tname + "/" + sourceName;
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
