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
    public partial class product : Form
    {

        public product(string id,string price)
        {
            InitializeComponent();
            t1.Text = id;
            t2.Text = price;
            for (int i = 1; i <= 5; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;  //set default value 0.
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void product_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotal();   //calling function
        }
        private void UpdateTotal() // function for multiplying quantity with price..... generating grand total
        {
            int q = (int)comboBox1.SelectedItem;
            string pr = t2.Text;
            int p;
            if (int.TryParse(pr, out p)) ///convert string into integer
            {
            }
            int t = q * p;
            t3.Text = t.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = t1.Text;
            string pprice = t2.Text;
            string pquanntity = comboBox1.Text;
            string total = t3.Text;

            string cname = textBox2.Text;
            string caddress = textBox1.Text;

            string ccnum = textBox3.Text;
            long ccontactnumber;   // Variable to hold the parsed integer
       
            if (string.IsNullOrEmpty(cname) || string.IsNullOrEmpty(caddress) || string.IsNullOrEmpty(ccnum))
            {
                MessageBox.Show("Please enter complete details");
                return;
            }
            else 
            {
                if (ccnum.Length == 10 && long.TryParse(ccnum,out ccontactnumber)) //check phno. length must be 10 digit long and convert string into int.
                {
                    confirmorder co = new confirmorder(pid, pprice, pquanntity, total, cname, caddress, ccontactnumber); //take values to next form
                    co.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a 10-digit Phone Number.");
                }
              
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                menu m = new menu();
                m.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
