using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hootel_Management_System
{
    class dbconnect
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;database=dbhotel;uid=root;pwd=19751975;");

        public MySqlConnection GetConnection()
        {
            return con;
        }
        //açmak connection
        public void opencon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //kapatmak coonection
        public void closecon()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
