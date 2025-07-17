using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InteriorDesigns
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = t1.Text;
            string password = t2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Username and Password");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\InteriorDesigns\InteriorDesigns\dbase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))     ///////////////////////////////////////////////////////////////////
                {
                    conn.Open();
                    string query = "insert into ltable values (@username, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int result = cmd.ExecuteNonQuery();  //ExecuteNonQuery is used to execute sql stament without returing any row.
                                                              //used for insert,update,delete
                        if (result > 0)
                        {
                            MessageBox.Show("Signup Successful,WELCOME");
                            this.Hide();
                            menu m = new menu();
                            m.Show();
                        }
                        else
                        {
                            MessageBox.Show("signup failed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
