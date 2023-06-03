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

namespace Hootel_Management_System
{
    public partial class Form1 : Form
    {
        dbconnect connect = new dbconnect();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string sequery = "SELECT *FROM userdb where USNAME = @usn AND PWD = @Pass";
            MySqlCommand command = new MySqlCommand(sequery, connect.GetConnection());
            adapter.SelectCommand = command;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = usernamee.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd.Text;
            adapter.Fill(table);
            if (usernamee.Text != "" && pwd.Text != "")
            {
                if (table.Rows.Count > 0)
                {
                    MainForm frm = new MainForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            pwd.UseSystemPasswordChar = true;
        }
        

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pwd.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Şifreyi Gizle";
            }
            else
            {
                pwd.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Şifreyi Göster";
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
