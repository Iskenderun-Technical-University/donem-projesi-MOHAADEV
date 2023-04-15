﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hootel_Management_System
{
    public partial class GuestForm : Form
    {
        GuestClass guest = new GuestClass();
        public GuestForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DtextBox2_adi.Clear();
            DtextBox3_telfon.Clear();
            DtextBox_tc.Clear();
            DtextBox4_ode.Clear();
           
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            string tc = DtextBox_tc.Text;
            string name = DtextBox2_adi.Text;
            string tele = DtextBox3_telfon.Text;
            string pay = DtextBox4_ode.Text;
            string date = DdateTimePicker1.Text;
            string room = DcomboBox1.Text;

            Boolean insertGuest = guest.insertGuest(tc, name, tele, pay,date , room);
            if (DtextBox2_adi.Text == "" || DtextBox_tc.Text == "")
            {
                MessageBox.Show("Bilgi YOK", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {


                    if (insertGuest)
                    {
                        MessageBox.Show("Veri başarıyla kaydedildi", "bilgi kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("bilgiler kaydedilmedi", "bilgi Kaydedilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
