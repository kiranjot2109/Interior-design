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
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            /////////
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\InteriorDesigns\InteriorDesigns\dbase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text.Trim();   //trim() removes whitespaces
                string role = cmbRole.Text;
                try
                {
                    conn.Open();
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))  //if empty fields
                    {
                        MessageBox.Show("Please enter both username and password.");
                    }
                    else if (role == "Admin")     ///for admin
                    {
                        if (username == "admin" && password == "admin123")
                        {
                            adminform af = new adminform();
                            af.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin");
                            txtUsername.Clear();
                            txtPassword.Clear();
                        }
                    }
                    else                        ///for users
                        {
                            using (SqlCommand cmd = new SqlCommand("select * from ltable where USERNAME = @username AND PASSWORD = @password", conn))
                               //SqlCommand is used to execute queries or commands in DB
                            {
                                cmd.Parameters.AddWithValue("@username", username);
                                cmd.Parameters.AddWithValue("@password", password);
                                //cmd.Connection = conn;
                                using (SqlDataReader reader = cmd.ExecuteReader()) //SqlDataReader is used to read data from db
                                  // ExecuteReader is used to execute query and return results 
                                {
                                    if (reader.Read())
                                    {
                                        //MessageBox.Show("Login successful");
                                        this.Hide();
                                        menu m = new menu();
                                        m.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("User does not Exist", "Error");
                                        //abc = 2;
                                    }
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
            
           
    
         private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup s = new signup();
            s.Show();
        }

         private void login_Load(object sender, EventArgs e)
         {

         }

         private void button2_Click(object sender, EventArgs e)
         {
             Application.Exit();
         }
         
    }
}
