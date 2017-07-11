﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PEP
{
    class TaskInfo
    {
        private SQLHandler sql;
        public TaskInfo()
        {
            this.sql = new SQLHandler();
            this.sql.SQLConnect();
        }
        ~TaskInfo()
        {
            sql.SQLDisconnect();
        }
        public MySqlDataReader getAllTask()
        {
            MySqlDataReader dr = this.sql.SQLGet("*", "tasks", "1=1 order by tid");
            return dr;
        }
    }
}
