using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEP
{
    class FileManager
    {
        private FtpHandler ftp;
        private string IP = "192.168.158.117";
        private string username = "";
        private string password = "";

        public FileManager()
        {
            ftp = new FtpHandler(IP, username, password);
        }

        public void uploadLogFile(string filename)
        {

        }

        public void downloadLogFile(string filename)
        {

        }

        public void uploadTaskFile(string filename)
        {

        }

        public void downloadTaskFile(string filename)
        {

        }
    }
}
