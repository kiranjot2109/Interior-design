namespace InteriorDesigns
{
    partial class adminform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dbaseDataSet = new InteriorDesigns.dbaseDataSet();
            this.salestableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salestableTableAdapter = new InteriorDesigns.dbaseDataSetTableAdapters.salestableTableAdapter();
            this.salestableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salestableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbaseDataSet2 = new InteriorDesigns.dbaseDataSet2();
            this.dbaseDataSet1 = new InteriorDesigns.dbaseDataSet1();
            this.dbaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesTTTableAdapter = new InteriorDesigns.dbaseDataSet2TableAdapters.SalesTTTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 90);
            this.label3.TabIndex = 73;
            this.label3.Text = "Sales Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(955, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 86);
            this.button1.TabIndex = 75;
            this.button1.Text = "View Users";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbaseDataSet
            // 
            this.dbaseDataSet.DataSetName = "dbaseDataSet";
            this.dbaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salestableBindingSource
            // 
            this.salestableBindingSource.DataMember = "salestable";
            this.salestableBindingSource.DataSource = this.dbaseDataSet;
            // 
            // salestableTableAdapter
            // 
            this.salestableTableAdapter.ClearBeforeFill = true;
            // 
            // salestableBindingSource1
            // 
            this.salestableBindingSource1.DataMember = "salestable";
            this.salestableBindingSource1.DataSource = this.dbaseDataSet;
            // 
            // salestableBindingSource2
            // 
            this.salestableBindingSource2.DataMember = "salestable";
            this.salestableBindingSource2.DataSource = this.dbaseDataSet;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleidDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesTTBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(24, 183);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1314, 486);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "Saleid";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "Sale ID";
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "Product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "Customer_Address";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "Customer Address";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Mode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "Payment Mode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            // 
            // salesTTBindingSource
            // 
            this.salesTTBindingSource.DataMember = "SalesTT";
            this.salesTTBindingSource.DataSource = this.dbaseDataSet2;
            // 
            // dbaseDataSet2
            // 
            this.dbaseDataSet2.DataSetName = "dbaseDataSet2";
            this.dbaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbaseDataSet1
            // 
            this.dbaseDataSet1.DataSetName = "dbaseDataSet1";
            this.dbaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbaseDataSet1BindingSource
            // 
            this.dbaseDataSet1BindingSource.DataSource = this.dbaseDataSet1;
            this.dbaseDataSet1BindingSource.Position = 0;
            // 
            // dbaseDataSet1BindingSource1
            // 
            this.dbaseDataSet1BindingSource1.DataSource = this.dbaseDataSet1;
            this.dbaseDataSet1BindingSource1.Position = 0;
            // 
            // salesTTTableAdapter
            // 
            this.salesTTTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::InteriorDesigns.Properties.Resources.cb;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1304, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 45);
            this.button2.TabIndex = 79;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1360, 790);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminform";
            this.Load += new System.EventHandler(this.adminform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salestableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbaseDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private dbaseDataSet dbaseDataSet;
        private System.Windows.Forms.BindingSource salestableBindingSource;
        private dbaseDataSetTableAdapters.salestableTableAdapter salestableTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource salestableBindingSource1;
        private System.Windows.Forms.BindingSource salestableBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbaseDataSet1 dbaseDataSet1;
        private System.Windows.Forms.BindingSource dbaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource dbaseDataSet1BindingSource1;
        private dbaseDataSet2 dbaseDataSet2;
        private System.Windows.Forms.BindingSource salesTTBindingSource;
        private dbaseDataSet2TableAdapters.SalesTTTableAdapter salesTTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
    }
}