using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.BUS
{
    class userBUS
    {
        public static bool checkLogin(string username, string password)
        {

            try
            {
                Connection.username = username;
                Connection.password = password;
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("connection login bi loi !!!");
                return false;
            }
        }
    }
  
}
