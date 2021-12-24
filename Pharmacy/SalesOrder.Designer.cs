namespace Pharmacy
{
    partial class SalesOrder
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
            this.ordersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet1 = new Pharmacy.pharmacyDataSet1();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet = new Pharmacy.pharmacyDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ordersTableAdapter = new Pharmacy.pharmacyDataSetTableAdapters.ordersTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new Pharmacy.pharmacyDataSet1TableAdapters.ordersTableAdapter();
            this.pharmacyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orederdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource6
            // 
            this.ordersBindingSource6.DataMember = "orders";
            this.ordersBindingSource6.DataSource = this.pharmacyDataSet1;
            // 
            // pharmacyDataSet1
            // 
            this.pharmacyDataSet1.DataSetName = "pharmacyDataSet1";
            this.pharmacyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "pharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 71;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "clientID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "MedID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 66;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 65;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 64;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(384, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 51);
            this.button4.TabIndex = 63;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(260, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 51);
            this.button3.TabIndex = 62;
            this.button3.Text = "Delet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(136, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 61;
            this.button2.Text = "UpDate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 51);
            this.button1.TabIndex = 60;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 20);
            this.textBox4.TabIndex = 74;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(130, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(183, 20);
            this.textBox6.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.pharmacyDataSet;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "orders";
            this.ordersBindingSource2.DataSource = this.pharmacyDataSet;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "orders";
            this.ordersBindingSource3.DataSource = this.pharmacyDataSet1;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // pharmacyDataSetBindingSource
            // 
            this.pharmacyDataSetBindingSource.DataSource = this.pharmacyDataSet;
            this.pharmacyDataSetBindingSource.Position = 0;
            // 
            // ordersBindingSource4
            // 
            this.ordersBindingSource4.DataMember = "orders";
            this.ordersBindingSource4.DataSource = this.pharmacyDataSetBindingSource;
            // 
            // ordersBindingSource5
            // 
            this.ordersBindingSource5.DataMember = "orders";
            this.ordersBindingSource5.DataSource = this.pharmacyDataSetBindingSource;
            // 
            // pharmacyDataSetBindingSource1
            // 
            this.pharmacyDataSetBindingSource1.DataSource = this.pharmacyDataSet;
            this.pharmacyDataSetBindingSource1.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn1,
            this.medicineidDataGridViewTextBoxColumn1,
            this.clientidDataGridViewTextBoxColumn1,
            this.orederdateDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ordersBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(1, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(549, 172);
            this.dataGridView2.TabIndex = 77;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // orderidDataGridViewTextBoxColumn1
            // 
            this.orderidDataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn1.Name = "orderidDataGridViewTextBoxColumn1";
            // 
            // medicineidDataGridViewTextBoxColumn1
            // 
            this.medicineidDataGridViewTextBoxColumn1.DataPropertyName = "medicine_id";
            this.medicineidDataGridViewTextBoxColumn1.HeaderText = "medicine_id";
            this.medicineidDataGridViewTextBoxColumn1.Name = "medicineidDataGridViewTextBoxColumn1";
            // 
            // clientidDataGridViewTextBoxColumn1
            // 
            this.clientidDataGridViewTextBoxColumn1.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn1.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn1.Name = "clientidDataGridViewTextBoxColumn1";
            // 
            // orederdateDataGridViewTextBoxColumn1
            // 
            this.orederdateDataGridViewTextBoxColumn1.DataPropertyName = "oreder_date";
            this.orederdateDataGridViewTextBoxColumn1.HeaderText = "oreder_date";
            this.orederdateDataGridViewTextBoxColumn1.Name = "orederdateDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pharmacy.Properties.Resources.order;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 419);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "SalesOrder";
            this.Text = "SalesOrder";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private pharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private pharmacyDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private pharmacyDataSet1 pharmacyDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private pharmacyDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private System.Windows.Forms.BindingSource pharmacyDataSetBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource6;
        private System.Windows.Forms.BindingSource ordersBindingSource5;
        private System.Windows.Forms.BindingSource pharmacyDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orederdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}