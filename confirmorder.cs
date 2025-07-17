using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InteriorDesigns
{
    public partial class confirmorder : Form
    {
        public confirmorder(string pid, string pprice,string pquantity,string total,string cname, string caddress, long ccontactnumber)
        {
            InitializeComponent();
            textBox1.Text = DateTime.Now.ToString("dd-MM-yyyy");
            label12.Text = pid;
            label13.Text = pprice;
            label14.Text = pquantity;
            label15.Text = total;
            label16.Text = cname;
            label17.Text = caddress;
            string ccn = ccontactnumber.ToString();
            label18.Text = ccn;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void confirmorder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = label12.Text;
            string price = label13.Text;
            string quantity = label14.Text;
            string total =label15.Text;
            string cname = label16.Text;
            string caddress = label17.Text;
            string cnum= label18.Text;
            string date = textBox1.Text;
            string pmode = cmbRole.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\InteriorDesigns\InteriorDesigns\dbase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))     ///////////////////////////////////////////////////////////////////
                {
                    conn.Open();
                    string query = "insert into SalesTT(Product_id,Price,Quantity,Total,Customer_Name,Customer_Address,Contact_Number,Date,Payment_Mode) values (@pid,@price,@quantity,@total,@cname,@caddress,@cnum,@date,@pmode)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@price",price);
                        cmd.Parameters.AddWithValue("@quantity",quantity);
                        cmd.Parameters.AddWithValue("@total",total);
                        cmd.Parameters.AddWithValue("@cname",cname);
                        cmd.Parameters.AddWithValue("@caddress", caddress);
                        cmd.Parameters.AddWithValue("@cnum",cnum);
                        cmd.Parameters.AddWithValue("@date",date);
                        cmd.Parameters.AddWithValue("@pmode",pmode);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Order Placed Successfully");
                            this.Hide();
                            orderplaced m = new orderplaced();
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error in Placing Order");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
