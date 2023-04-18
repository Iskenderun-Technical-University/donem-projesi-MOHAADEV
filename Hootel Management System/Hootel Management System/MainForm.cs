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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void button_dashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void button_guest_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button3.Height;
            panel_slide.Top = button3.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_dashboard_Click_1(object sender, EventArgs e)
        {
            panel_slide.Height = button_dashboard.Height;
            panel_slide.Top = button_dashboard.Top;
            Loadform(new RoomForm());
        }

        private void button_guest_Click_1(object sender, EventArgs e)
        {
            panel_slide.Height = button_guest.Height;
            panel_slide.Top = button_guest.Top;
            Loadform(new GuestForm());
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            panel_slide.Height = button3.Height;
            panel_slide.Top = button3.Top;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelable.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
