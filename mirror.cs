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
    public partial class mirror : Form
    {
        public mirror()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = "m1";
            string price = "1850";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "m2";
            string price = "1540";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "m3";
            string price = "1580";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "m4";
            string price = "1280";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "m5";
            string price = "950";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "m6";
            string price = "1260";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "m7";
            string price = "1120";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "m8";
            string price = "950";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void mirror_Load(object sender, EventArgs e)
        {

        }
    }
}
