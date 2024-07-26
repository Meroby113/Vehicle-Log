namespace EntityFrameworkProject
{
    partial class ListCustomerForm
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
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.ListOfCustomerDGV = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbVehicleLogsDataSet11 = new EntityFrameworkProject.dbVehicleLogsDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVehicleLogsDataSet = new EntityFrameworkProject.dbVehicleLogsDataSet();
            this.customerTableAdapter = new EntityFrameworkProject.dbVehicleLogsDataSetTableAdapters.CustomerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbVehicleLogsDataSet1 = new EntityFrameworkProject.dbVehicleLogsDataSet1();
            this.dbVehicleLogsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.latestDataSet = new EntityFrameworkProject.LatestDataSet();
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceTableAdapter = new EntityFrameworkProject.dbVehicleLogsDataSet1TableAdapters.BalanceTableAdapter();
            this.latestDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbVehicleLogsDataSet2 = new EntityFrameworkProject.dbVehicleLogsDataSet2();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new EntityFrameworkProject.dbVehicleLogsDataSet2TableAdapters.CustomerTableAdapter();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter2 = new EntityFrameworkProject.dbVehicleLogsDataSet1TableAdapters.CustomerTableAdapter();
            this.BackToHomeB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTB
            // 
            this.SearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchTB.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchTB.Location = new System.Drawing.Point(557, 399);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTB.MaximumSize = new System.Drawing.Size(4, 50);
            this.SearchTB.MinimumSize = new System.Drawing.Size(532, 25);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(532, 26);
            this.SearchTB.TabIndex = 4;
            this.SearchTB.Text = "Search For Customer";
            this.SearchTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchTB_MouseClick);
            this.SearchTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTB_KeyPress);
            this.SearchTB.MouseLeave += new System.EventHandler(this.SearchTB_MouseLeave);
            // 
            // ListOfCustomerDGV
            // 
            this.ListOfCustomerDGV.AllowUserToOrderColumns = true;
            this.ListOfCustomerDGV.AutoGenerateColumns = false;
            this.ListOfCustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfCustomerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.name,
            this.surname,
            this.approvalstatusDataGridViewCheckBoxColumn});
            this.ListOfCustomerDGV.DataSource = this.customerBindingSource3;
            this.ListOfCustomerDGV.Location = new System.Drawing.Point(49, 469);
            this.ListOfCustomerDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ListOfCustomerDGV.Name = "ListOfCustomerDGV";
            this.ListOfCustomerDGV.Size = new System.Drawing.Size(1031, 438);
            this.ListOfCustomerDGV.TabIndex = 3;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "customer_id";
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // approvalstatusDataGridViewCheckBoxColumn
            // 
            this.approvalstatusDataGridViewCheckBoxColumn.DataPropertyName = "approval_status";
            this.approvalstatusDataGridViewCheckBoxColumn.HeaderText = "approval_status";
            this.approvalstatusDataGridViewCheckBoxColumn.Name = "approvalstatusDataGridViewCheckBoxColumn";
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "Customer";
            this.customerBindingSource3.DataSource = this.dbVehicleLogsDataSet11;
            // 
            // dbVehicleLogsDataSet11
            // 
            this.dbVehicleLogsDataSet11.DataSetName = "dbVehicleLogsDataSet1";
            this.dbVehicleLogsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dbVehicleLogsDataSet;
            // 
            // dbVehicleLogsDataSet
            // 
            this.dbVehicleLogsDataSet.DataSetName = "dbVehicleLogsDataSet";
            this.dbVehicleLogsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(384, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Customers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::EntityFrameworkProject.Properties.Resources.customers__2_;
            this.pictureBox1.Location = new System.Drawing.Point(233, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 271);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dbVehicleLogsDataSet1
            // 
            this.dbVehicleLogsDataSet1.DataSetName = "dbVehicleLogsDataSet1";
            this.dbVehicleLogsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbVehicleLogsDataSet1BindingSource
            // 
            this.dbVehicleLogsDataSet1BindingSource.DataSource = this.dbVehicleLogsDataSet1;
            this.dbVehicleLogsDataSet1BindingSource.Position = 0;
            // 
            // latestDataSet
            // 
            this.latestDataSet.DataSetName = "LatestDataSet";
            this.latestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // balanceBindingSource
            // 
            this.balanceBindingSource.DataMember = "Balance";
            this.balanceBindingSource.DataSource = this.dbVehicleLogsDataSet1BindingSource;
            // 
            // balanceTableAdapter
            // 
            this.balanceTableAdapter.ClearBeforeFill = true;
            // 
            // latestDataSetBindingSource
            // 
            this.latestDataSetBindingSource.DataSource = this.latestDataSet;
            this.latestDataSetBindingSource.Position = 0;
            // 
            // dbVehicleLogsDataSet2
            // 
            this.dbVehicleLogsDataSet2.DataSetName = "dbVehicleLogsDataSet2";
            this.dbVehicleLogsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.dbVehicleLogsDataSet2;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.dbVehicleLogsDataSet2;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // BackToHomeB
            // 
            this.BackToHomeB.BackColor = System.Drawing.Color.Khaki;
            this.BackToHomeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToHomeB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackToHomeB.Location = new System.Drawing.Point(49, 949);
            this.BackToHomeB.Margin = new System.Windows.Forms.Padding(4);
            this.BackToHomeB.Name = "BackToHomeB";
            this.BackToHomeB.Size = new System.Drawing.Size(203, 54);
            this.BackToHomeB.TabIndex = 19;
            this.BackToHomeB.Text = "Back";
            this.BackToHomeB.UseVisualStyleBackColor = false;
            this.BackToHomeB.Click += new System.EventHandler(this.BackToHomeB_Click_1);
            // 
            // ListCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 1050);
            this.Controls.Add(this.BackToHomeB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfCustomerDGV);
            this.Controls.Add(this.SearchTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListCustomerForm";
            this.Text = "FindCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latestDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbVehicleLogsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.DataGridView ListOfCustomerDGV;
        private dbVehicleLogsDataSet dbVehicleLogsDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dbVehicleLogsDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private LatestDataSet latestDataSet;
        private dbVehicleLogsDataSet1 dbVehicleLogsDataSet1;
        private System.Windows.Forms.BindingSource dbVehicleLogsDataSet1BindingSource;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        private dbVehicleLogsDataSet1TableAdapters.BalanceTableAdapter balanceTableAdapter;
        private System.Windows.Forms.BindingSource latestDataSetBindingSource;
        private dbVehicleLogsDataSet2 dbVehicleLogsDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private dbVehicleLogsDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private dbVehicleLogsDataSet1 dbVehicleLogsDataSet11;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private dbVehicleLogsDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approvalstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button BackToHomeB;
    }
}