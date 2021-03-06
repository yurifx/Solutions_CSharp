﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Builder
{
    public class SqlServerDatabase : Database
    {
        private System.Data.Common.DbConnection _Connection = null;
        private System.Data.Common.DbCommand _Command = null;

        public override System.Data.Common.DbConnection Connection
        {
            get
            {
                return _Connection;
            }
            set
            {
                _Connection = value;
            }
        }

        public override System.Data.Common.DbCommand Command
        {
            get
            {
                return _Command;
            }
            set
            {
                _Command = value;
            }
        }
    }
}
