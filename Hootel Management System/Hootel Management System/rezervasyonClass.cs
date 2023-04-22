using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hootel_Management_System
{
    class rezervasyonClass
    {
        dbconnect con = new dbconnect();

        public DataTable roomByType()
        {
           string SelectQuery = "SELECT `ROOMTYPE` FROM `dbhotel`.`roomdb` where STATUSROOM = 'free';";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
         //   command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
           
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable CoustmerByRoom(string room)
        {
            DataTable table = new DataTable();
            string SelectQuery = "SELECT `ROOM` FROM `dbhotel`.`guestdb` WHERE ROOM = @room;";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            adapter.SelectCommand = command;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;
            adapter.Fill(table);
            return table;
        }
    }
}
