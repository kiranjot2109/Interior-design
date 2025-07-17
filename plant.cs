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
    public partial class plant : Form
    {
        public plant()
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
            string id = "p1";
            string price = "900";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "p2";
            string price = "1220";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "p3";
            string price = "1100";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "p4";
            string price = "980";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "p5";
            string price = "1130";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "p6";
            string price = "890";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "p7";
            string price = "700";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "p8";
            string price = "900";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }
    }
}
