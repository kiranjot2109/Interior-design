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
    public partial class viewusers : Form
    {
        public viewusers()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 26, FontStyle.Bold);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void viewusers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbaseDataSet.ltable' table. You can move, or remove it, as needed.
            this.ltableTableAdapter.Fill(this.dbaseDataSet.ltable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminform a = new adminform();
            a.Show();
            this.Hide();
        }

        
    }
}
