using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEP
{
    class FileHandler
    {
        public void fileSave(String address, String filename, String content)
        {
            FileStream fs = new FileStream(address + filename, FileMode.Create);
            byte[] data = new UTF8Encoding().GetBytes(content);
            fs.Write(data, 0, data.Length);
        }
    }
}
