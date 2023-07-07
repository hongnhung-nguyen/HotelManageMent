﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace src
{
    class Connection
    {

        public static string username = "NV041";
        public static string password = "NV041";

        const string host = "localhost";
        const int port = 1521;
        const string sid = "HOTEL";

         Connection()
        {
            username = "NV041";
            password = "NV041";
        }

        public static OracleConnection GetDBConnection()
        {

            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + ";";
            OracleConnection conn = new OracleConnection(connString);
            return conn;
        }

        public static string getConnString()
        {
            return ("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + username + ";");
        }

    }
}
