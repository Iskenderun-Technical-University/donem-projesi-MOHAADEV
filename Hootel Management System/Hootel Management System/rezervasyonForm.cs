using System;
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
    public partial class rezervasyonForm : Form
    {
        rezervasyonClass rez = new rezervasyonClass();
        public rezervasyonForm()
        {
            
            InitializeComponent();
        }

        private void rezervasyonForm_Load(object sender, EventArgs e)
        {
            roomcombobox.DataSource = rez.roomByType();
            roomcombobox.DisplayMember = "ROOMTYPE";
            gettable();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
           
                try
                {
                string tc = tccomboBox1.Text;
                string room = roomcombobox.Text;
                DateTime ddatein = dateinguna2DateTimePicker1.Value;
                DateTime ddateout = dateoutguna2DateTimePicker2.Value;
                if (rez.insertRez(tc, room, ddatein, ddateout) && rez.revUpdate(room, "busy"))
                    {
                        MessageBox.Show("Veri başarıyla kaydedildi", "bilgi kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
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
        private void gettable()
        {
            dataGridView1.DataSource = rez.getRez();
        }

        private void SILMEBUT_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = tccomboBox1.Text;
                string room = roomcombobox.Text;
                if (rez.deleterez(tc) && rez.revUpdate(room, "free"))
                {
                    MessageBox.Show("done ", "bilgi kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gettable();
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


        private void roomcombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tccomboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            roomcombobox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void roomcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room = roomcombobox.Text.ToString();
            tccomboBox1.DataSource = rez.CoustmerByRoom(room);
            tccomboBox1.DisplayMember = "TC";
        }
    }
}
