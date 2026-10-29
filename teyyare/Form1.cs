using System.Media;
namespace teyyare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isGas = false;
        bool isR = false;
        bool isSystemOn = false;
        SoundPlayer spEngine = new SoundPlayer("isikacmakapamasesi.wav");
        SoundPlayer spLanding = new SoundPlayer("inishazirliklari.wav");
        SoundPlayer spTurbulence = new SoundPlayer("turbulans.wav");
        SoundPlayer spBelts = new SoundPlayer("kemerler.wav");
        SoundPlayer spThanks = new SoundPlayer("tesekkurler.wav");
        SoundPlayer spBeep = new SoundPlayer("beep.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOnesOff.Text = "ON/OFF";
            pictureBox1.Visible = false;
        }
        private void buttonOnesOff_Click(object sender, EventArgs e)
        {
            isSystemOn = !isSystemOn;
            if (isSystemOn)
            {
                buttonOnesOff.Text = "ON";
                buttonOnesOff.BackColor = Color.Green;
                pictureBox1.Visible = true;
            }
            else
            {
                buttonOnesOff.Text = "OFF";
                buttonOnesOff.BackColor = Color.Blue;
                pictureBox1.Visible = false;
                spEngine.Stop();
                timer1.Stop();
                timer2.Stop();
                isGas = false;
                isR = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spEngine.Play();
                isGas = true;
                isR = false;
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGas == true && plane.Location.Y > 0)
            {
                plane.Location = new Point(plane.Location.X, plane.Location.Y - 2);
                pictureBox1.Location = new Point(plane.Location.X + 20, plane.Location.Y - 25);
            }
            else
            {
                timer1.Stop();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            spEngine.Stop();
            timer1.Stop();
            timer2.Stop();
            isGas = false;
            isR = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isR == true && plane.Location.Y <= 450)
            {
                plane.Location = new Point(plane.Location.X, plane.Location.Y + 2);
                pictureBox1.Location = new Point(plane.Location.X + 20, plane.Location.Y - 25);
            }
            else
            {
                timer2.Stop();
            }
        }
        private void btnEnishHazirligi_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spLanding.Play();
            }
        }
        private void btnTurbulans_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spTurbulence.Play();
            }
        }
        private void btnKemerler_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spBelts.Play();
            }
        }
        private void btnTesekkurler_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spThanks.Play();
            }
        }
        private void btnBeep_Click(object sender, EventArgs e)
        {
            if (isSystemOn)
            {
                spBeep.Play();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}