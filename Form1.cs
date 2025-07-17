using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InteriorDesigns
{
    public partial class Form1 : Form
    {
        //private Timer timer;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Step = 1;

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Increment the progress bar's value by 2
            progressBar1.Increment(2);

            // Update the width of PictureBox1 based on the progress bar's value
            pictureBox1.Width = 0 + progressBar1.Value * 5;

            // Check if the progress bar's value has reached 100
            if (progressBar1.Value == 100)
            {
                // Stop the timer
                timer.Stop();
                login l = new login();
                // Show the 'welcome' form
                l.Show();

                // Hide the current form if 'welcome' is visible
                if (l.Visible)
                {
                    this.Hide();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

    }
}
