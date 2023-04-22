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
            combobox.DataSource = rez.roomByType();
            combobox.DisplayMember = "ROOMTYPE";

            string room = combobox.Text.ToString();

            comboBox1.DataSource = rez.CoustmerByRoom(room);
            comboBox1.DisplayMember = "TC";
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
