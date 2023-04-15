using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Hootel_Management_System
{
    class GuestClass
    {
        dbconnect con = new dbconnect();
        
        public bool insertGuest(string tc,string name, string tel, string pay,  string date, string room)
        {
            string insertQuerry = "INSERT INTO GUESTDB (TC , NAME_LAST , TELE ,PAYDB , JOIN_DATE , ROOM ) values(@TC ,@NMLS ,@TELE ,@PAY ,@DATE ,@ROOM);";
            MySqlCommand command = new MySqlCommand(insertQuerry, con.GetConnection());
            command.Parameters.Add("@TC", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@NMLS", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@TELE", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@PAY", MySqlDbType.VarChar).Value = pay;
            command.Parameters.Add("@DATE", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@ROOM", MySqlDbType.VarChar).Value = room;
            con.opencon();
            if(command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }

        }
    }
}
