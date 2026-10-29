using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace teyyare
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonOnesOff = new Button();
            btnEnishHazirligi = new Button();
            btnTurbulans = new Button();
            btnKemerler = new Button();
            btnTesekkurler = new Button();
            btnBeep = new Button();
            plane = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)plane).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Location = new Point(412, 338);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 62);
            button1.TabIndex = 0;
            button1.Text = "GAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Location = new Point(579, 338);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(118, 62);
            button2.TabIndex = 1;
            button2.Text = "Break";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Click += button3_Click;
            // 
            // buttonOnesOff
            // 
            buttonOnesOff.BackColor = Color.Navy;
            buttonOnesOff.ForeColor = Color.White;
            buttonOnesOff.Location = new Point(447, 421);
            buttonOnesOff.Margin = new Padding(3, 4, 3, 4);
            buttonOnesOff.Name = "buttonOnesOff";
            buttonOnesOff.Size = new Size(220, 50);
            buttonOnesOff.TabIndex = 2;
            buttonOnesOff.Text = "ON/OFF";
            buttonOnesOff.UseVisualStyleBackColor = false;
            buttonOnesOff.Click += buttonOnesOff_Click;
            // 
            // btnEnishHazirligi
            // 
            btnEnishHazirligi.BackColor = Color.Orange;
            btnEnishHazirligi.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEnishHazirligi.Location = new Point(412, 24);
            btnEnishHazirligi.Margin = new Padding(3, 4, 3, 4);
            btnEnishHazirligi.Name = "btnEnishHazirligi";
            btnEnishHazirligi.Size = new Size(285, 50);
            btnEnishHazirligi.TabIndex = 4;
            btnEnishHazirligi.Text = "Eniş hazırlığı";
            btnEnishHazirligi.UseVisualStyleBackColor = false;
            btnEnishHazirligi.Click += btnEnishHazirligi_Click;
            // 
            // btnTurbulans
            // 
            btnTurbulans.BackColor = Color.Orange;
            btnTurbulans.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTurbulans.Location = new Point(412, 82);
            btnTurbulans.Margin = new Padding(3, 4, 3, 4);
            btnTurbulans.Name = "btnTurbulans";
            btnTurbulans.Size = new Size(285, 50);
            btnTurbulans.TabIndex = 3;
            btnTurbulans.Text = "Turbulans";
            btnTurbulans.UseVisualStyleBackColor = false;
            btnTurbulans.Click += btnTurbulans_Click;
            // 
            // btnKemerler
            // 
            btnKemerler.BackColor = Color.Orange;
            btnKemerler.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKemerler.Location = new Point(412, 140);
            btnKemerler.Margin = new Padding(3, 4, 3, 4);
            btnKemerler.Name = "btnKemerler";
            btnKemerler.Size = new Size(285, 50);
            btnKemerler.TabIndex = 2;
            btnKemerler.Text = "Kəmərlər";
            btnKemerler.UseVisualStyleBackColor = false;
            btnKemerler.Click += btnKemerler_Click;
            // 
            // btnTesekkurler
            // 
            btnTesekkurler.BackColor = Color.Orange;
            btnTesekkurler.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTesekkurler.Location = new Point(412, 198);
            btnTesekkurler.Margin = new Padding(3, 4, 3, 4);
            btnTesekkurler.Name = "btnTesekkurler";
            btnTesekkurler.Size = new Size(285, 50);
            btnTesekkurler.TabIndex = 1;
            btnTesekkurler.Text = "Təşəkkürlər";
            btnTesekkurler.UseVisualStyleBackColor = false;
            btnTesekkurler.Click += btnTesekkurler_Click;
            // 
            // btnBeep
            // 
            btnBeep.BackColor = Color.Orange;
            btnBeep.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBeep.Location = new Point(412, 256);
            btnBeep.Margin = new Padding(3, 4, 3, 4);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(285, 50);
            btnBeep.TabIndex = 0;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = false;
            btnBeep.Click += btnBeep_Click;
            // 
            // plane
            // 
            plane.Image = (System.Drawing.Image)resources.GetObject("plane.Image");
            plane.Location = new Point(130, 378);
            plane.Margin = new Padding(3, 4, 3, 4);
            plane.Name = "plane";
            plane.Size = new Size(87, 93);
            plane.SizeMode = PictureBoxSizeMode.StretchImage;
            plane.TabIndex = 10;
            plane.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 20;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(plane);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 1037);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 338);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 478);
            Controls.Add(panel1);
            Controls.Add(btnBeep);
            Controls.Add(btnTesekkurler);
            Controls.Add(btnKemerler);
            Controls.Add(btnTurbulans);
            Controls.Add(btnEnishHazirligi);
            Controls.Add(buttonOnesOff);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Plane";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)plane).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonOnesOff;
        private System.Windows.Forms.Button btnEnishHazirligi;
        private System.Windows.Forms.Button btnTurbulans;
        private System.Windows.Forms.Button btnKemerler;
        private System.Windows.Forms.Button btnTesekkurler;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}