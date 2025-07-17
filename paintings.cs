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
    public partial class paintings : Form
    {
        public paintings()
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
            string id = "pp1";
            string price = "1200";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "pp2";
            string price = "1470";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "pp3";
            string price = "870";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "pp4";
            string price = "1320";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "pp5";
            string price = "1890";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "pp6";
            string price = "1500";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "pp7";
            string price = "1980";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "pp8";
            string price = "1150";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }
    }
}
