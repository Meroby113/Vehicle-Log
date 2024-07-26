namespace EntityFrameworkProject
{
    partial class VehicleListForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerNameL = new System.Windows.Forms.Label();
            this.VehiclesListDGV = new System.Windows.Forms.DataGridView();
            this.BackToListCustomerFormB = new System.Windows.Forms.Button();
            this.customer_idL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesListDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntityFrameworkProject.Properties.Resources.download1;
            this.pictureBox1.Location = new System.Drawing.Point(270, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerNameL
            // 
            this.CustomerNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerNameL.Location = new System.Drawing.Point(339, 175);
            this.CustomerNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameL.Name = "CustomerNameL";
            this.CustomerNameL.Size = new System.Drawing.Size(288, 27);
            this.CustomerNameL.TabIndex = 15;
            this.CustomerNameL.Text = "Customer Name Surname";
            this.CustomerNameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CustomerNameL.Click += new System.EventHandler(this.CustomerNameL_Click);
            // 
            // VehiclesListDGV
            // 
            this.VehiclesListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiclesListDGV.Location = new System.Drawing.Point(22, 216);
            this.VehiclesListDGV.Margin = new System.Windows.Forms.Padding(4);
            this.VehiclesListDGV.Name = "VehiclesListDGV";
            this.VehiclesListDGV.Size = new System.Drawing.Size(854, 263);
            this.VehiclesListDGV.TabIndex = 11;
            // 
            // BackToListCustomerFormB
            // 
            this.BackToListCustomerFormB.BackColor = System.Drawing.Color.Khaki;
            this.BackToListCustomerFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToListCustomerFormB.Location = new System.Drawing.Point(44, 506);
            this.BackToListCustomerFormB.Margin = new System.Windows.Forms.Padding(4);
            this.BackToListCustomerFormB.Name = "BackToListCustomerFormB";
            this.BackToListCustomerFormB.Size = new System.Drawing.Size(140, 37);
            this.BackToListCustomerFormB.TabIndex = 12;
            this.BackToListCustomerFormB.Text = "Back";
            this.BackToListCustomerFormB.UseVisualStyleBackColor = false;
            this.BackToListCustomerFormB.Click += new System.EventHandler(this.BackToListCustomerFormB_Click);
            // 
            // customer_idL
            // 
            this.customer_idL.AutoSize = true;
            this.customer_idL.Location = new System.Drawing.Point(192, 542);
            this.customer_idL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_idL.Name = "customer_idL";
            this.customer_idL.Size = new System.Drawing.Size(73, 16);
            this.customer_idL.TabIndex = 13;
            this.customer_idL.Text = "customerId";
            this.customer_idL.Visible = false;
            // 
            // VehicleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 597);
            this.Controls.Add(this.customer_idL);
            this.Controls.Add(this.BackToListCustomerFormB);
            this.Controls.Add(this.VehiclesListDGV);
            this.Controls.Add(this.CustomerNameL);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleListForm";
            this.Text = "Vehicle List";
            this.Load += new System.EventHandler(this.VehicleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiclesListDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CustomerNameL;
        private System.Windows.Forms.DataGridView VehiclesListDGV;
        private System.Windows.Forms.Button BackToListCustomerFormB;
        private System.Windows.Forms.Label customer_idL;
    }
}