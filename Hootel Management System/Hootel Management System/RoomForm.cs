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
    public partial class RoomForm : Form
    {
        RoomClass rooms = new RoomClass();
        public RoomForm()
        {
            
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            string ROOMtype = DtextBox_type.Text;
            //   string name = DtextBox2_adi.Text;
            string ROOMstatus = free.Checked ? "free" : "busy";
            Boolean insertRoom = rooms.insertRoom(ROOMtype, ROOMstatus);
            if ( DtextBox_type.Text == "")
            {
                MessageBox.Show("Bilgi GIRIMLISINZ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {


                    if (insertRoom)
                    {
                        MessageBox.Show("Veri başarıyla kaydedildi", "bilgi kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                   //     temiz();
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

        private void gettable()
        {
            dataGridView1.DataSource = rooms.getRoom();
        }
        private void RoomForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
