using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class LoginForm1 : Form
    {
        dbconnect connect = new dbconnect();
        public LoginForm1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name, label5.Font.SizeInPoints, FontStyle.Underline);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font.Name, label5.Font.SizeInPoints, FontStyle.Regular);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sequery = "SELECT *FROM userdb where USNAME = @usn AND PWD = @Pass";
            MySqlCommand command = new MySqlCommand(sequery,connect.GetConnection());
            adapter.SelectCommand = command;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernamee.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd.Text;
            adapter.Fill(table);
            if (usernamee.Text != "" && pwd.Text != "")
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı " , "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    usernamee.Clear();
                    pwd.Clear();
                    usernamee.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("adı ve şifreyi girmelisiniz ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }



        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
