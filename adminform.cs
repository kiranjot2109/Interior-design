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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewusers vu = new viewusers();
            vu.Show();
            this.Hide();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbaseDataSet2.SalesTT' table. You can move, or remove it, as needed.
            this.salesTTTableAdapter.Fill(this.dbaseDataSet2.SalesTT);
            // TODO: This line of code loads data into the 'dbaseDataSet.salestable' table. You can move, or remove it, as needed.

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
