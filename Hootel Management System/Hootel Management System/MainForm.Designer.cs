
namespace Hootel_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.datelable = new System.Windows.Forms.Label();
            this.button3 = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_guest = new Guna.UI2.WinForms.Guna2Button();
            this.button_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            this.guna2GradientButton9 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel_slide = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.guna2Panel1.Controls.Add(this.datelable);
            this.guna2Panel1.Controls.Add(this.panel_slide);
            this.guna2Panel1.Controls.Add(this.button3);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.button_guest);
            this.guna2Panel1.Controls.Add(this.button_dashboard);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(213, 656);
            this.guna2Panel1.TabIndex = 0;
            // 
            // datelable
            // 
            this.datelable.BackColor = System.Drawing.Color.White;
            this.datelable.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelable.ForeColor = System.Drawing.Color.RoyalBlue;
            this.datelable.Location = new System.Drawing.Point(3, 548);
            this.datelable.Name = "datelable";
            this.datelable.Size = new System.Drawing.Size(35, 23);
            this.datelable.TabIndex = 3;
            this.datelable.Text = "?";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button3.ImageSize = new System.Drawing.Size(50, 50);
            this.button3.Location = new System.Drawing.Point(0, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "DashBoard";
            this.button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_guest
            // 
            this.button_guest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button_guest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_guest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_guest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_guest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_guest.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guest.ForeColor = System.Drawing.Color.White;
            this.button_guest.Image = ((System.Drawing.Image)(resources.GetObject("button_guest.Image")));
            this.button_guest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_guest.ImageSize = new System.Drawing.Size(50, 50);
            this.button_guest.Location = new System.Drawing.Point(3, 161);
            this.button_guest.Name = "button_guest";
            this.button_guest.Size = new System.Drawing.Size(210, 57);
            this.button_guest.TabIndex = 3;
            this.button_guest.Text = "DashBoard";
            this.button_guest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.button_guest.Click += new System.EventHandler(this.button_guest_Click_1);
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_dashboard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.White;
            this.button_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("button_dashboard.Image")));
            this.button_dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button_dashboard.ImageSize = new System.Drawing.Size(50, 50);
            this.button_dashboard.Location = new System.Drawing.Point(0, 261);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(213, 58);
            this.button_dashboard.TabIndex = 3;
            this.button_dashboard.Text = "DashBoard";
            this.button_dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainpanel.Location = new System.Drawing.Point(216, 12);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(790, 644);
            this.mainpanel.TabIndex = 4;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // guna2GradientButton9
            // 
            this.guna2GradientButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.guna2GradientButton9.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientButton9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton9.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton9.Location = new System.Drawing.Point(213, 3);
            this.guna2GradientButton9.Name = "guna2GradientButton9";
            this.guna2GradientButton9.Size = new System.Drawing.Size(790, 16);
            this.guna2GradientButton9.TabIndex = 6;
            // 
            // panel_slide
            // 
            this.panel_slide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panel_slide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panel_slide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panel_slide.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panel_slide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panel_slide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.panel_slide.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_slide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel_slide.ForeColor = System.Drawing.Color.White;
            this.panel_slide.Location = new System.Drawing.Point(203, 161);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(10, 58);
            this.panel_slide.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1003, 656);
            this.Controls.Add(this.guna2GradientButton9);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button button_dashboard;
        private Guna.UI2.WinForms.Guna2Button button_guest;
        private Guna.UI2.WinForms.Guna2Button button3;
        private System.Windows.Forms.Label datelable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel mainpanel;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton9;
        private Guna.UI2.WinForms.Guna2GradientButton panel_slide;
    }
}