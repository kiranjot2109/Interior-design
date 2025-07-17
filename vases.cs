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
    public partial class vases : Form
    {
        public vases()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
            string id = "v1";
            string price = "900";
          /*  using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\InteriorDesigns\InteriorDesigns\dbase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string query = "insert into [order] values (@id,@price)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@price", price);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                       // MessageBox.Show("product purchased ");*/
                        product p = new product(id, price);
                        p.Show();
                        this.Hide();
                  /*  }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = "v2";
            string price = "1450";
           
                        product p = new product(id, price);
                        p.Show();
                        this.Hide();
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = "v3";
            string price = "1000";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string id = "v4";
            string price = "1230";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = "v5";
            string price = "1560";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string id = "v6";
            string price = "1620";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string id = "v7";
            string price = "950";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = "v8";
            string price = "1280";
            product p = new product(id, price);
            p.Show();
            this.Hide();
        }
    }
}
