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
    public partial class clocks : Form
    {
        public clocks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }

        private void clocks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = "c1";
            string price = "750";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "c2";
            string price = "950";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "c3";
            string price = "1250";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "c4";
            string price = "1150";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "c5";
            string price = "1760";
            product p = new product(id, price);
            p.Show();   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "c6";
            string price = "1580";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "c7";
            string price = "850";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "c8";
            string price = "1000";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }
    }
}
