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
    public partial class lamps : Form
    {
        public lamps()
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
            string id = "l1";
            string price = "1450";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "l2";
            string price = "1680";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "l3";
            string price = "1270";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "l4";
            string price = "2000";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "l5";
            string price = "1380";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "l6";
            string price = "1180";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "l7";
            string price = "1390";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "l8";
            string price = "1150";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }
    }
}
