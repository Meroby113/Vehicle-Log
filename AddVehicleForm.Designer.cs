namespace EntityFrameworkProject
{
    partial class AddVehicleForm
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
            this.PlateNumberL = new System.Windows.Forms.Label();
            this.VehicleTypeTB = new System.Windows.Forms.TextBox();
            this.AddVehicleB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlateNumberTB = new System.Windows.Forms.TextBox();
            this.FuelTypeCB = new System.Windows.Forms.ComboBox();
            this.customer_idL = new System.Windows.Forms.Label();
            this.BackToListCustomerFormB = new System.Windows.Forms.Button();
            this.CustomerNameL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlateNumberL
            // 
            this.PlateNumberL.AutoSize = true;
            this.PlateNumberL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PlateNumberL.Location = new System.Drawing.Point(44, 146);
            this.PlateNumberL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlateNumberL.Name = "PlateNumberL";
            this.PlateNumberL.Size = new System.Drawing.Size(105, 20);
            this.PlateNumberL.TabIndex = 0;
            this.PlateNumberL.Text = "Plate Number";
            // 
            // VehicleTypeTB
            // 
            this.VehicleTypeTB.Location = new System.Drawing.Point(275, 100);
            this.VehicleTypeTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehicleTypeTB.Name = "VehicleTypeTB";
            this.VehicleTypeTB.Size = new System.Drawing.Size(160, 22);
            this.VehicleTypeTB.TabIndex = 1;
            // 
            // AddVehicleB
            // 
            this.AddVehicleB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddVehicleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddVehicleB.Location = new System.Drawing.Point(292, 254);
            this.AddVehicleB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddVehicleB.Name = "AddVehicleB";
            this.AddVehicleB.Size = new System.Drawing.Size(173, 37);
            this.AddVehicleB.TabIndex = 2;
            this.AddVehicleB.Text = "Add Vehicle";
            this.AddVehicleB.UseVisualStyleBackColor = false;
            this.AddVehicleB.Click += new System.EventHandler(this.AddVehicleB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fuel Type";
            // 
            // PlateNumberTB
            // 
            this.PlateNumberTB.Location = new System.Drawing.Point(275, 146);
            this.PlateNumberTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlateNumberTB.Name = "PlateNumberTB";
            this.PlateNumberTB.Size = new System.Drawing.Size(160, 22);
            this.PlateNumberTB.TabIndex = 6;
            // 
            // FuelTypeCB
            // 
            this.FuelTypeCB.FormattingEnabled = true;
            this.FuelTypeCB.Items.AddRange(new object[] {
            "Diesel",
            "Biodiesel",
            "Electric",
            "Gasoline",
            "LPG",
            "Hybrid"});
            this.FuelTypeCB.Location = new System.Drawing.Point(275, 194);
            this.FuelTypeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuelTypeCB.Name = "FuelTypeCB";
            this.FuelTypeCB.Size = new System.Drawing.Size(160, 24);
            this.FuelTypeCB.TabIndex = 7;
            // 
            // customer_idL
            // 
            this.customer_idL.AutoSize = true;
            this.customer_idL.Location = new System.Drawing.Point(-8, 294);
            this.customer_idL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_idL.Name = "customer_idL";
            this.customer_idL.Size = new System.Drawing.Size(73, 16);
            this.customer_idL.TabIndex = 8;
            this.customer_idL.Text = "customerId";
            this.customer_idL.Visible = false;
            // 
            // BackToListCustomerFormB
            // 
            this.BackToListCustomerFormB.BackColor = System.Drawing.Color.Khaki;
            this.BackToListCustomerFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToListCustomerFormB.Location = new System.Drawing.Point(16, 254);
            this.BackToListCustomerFormB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackToListCustomerFormB.Name = "BackToListCustomerFormB";
            this.BackToListCustomerFormB.Size = new System.Drawing.Size(140, 37);
            this.BackToListCustomerFormB.TabIndex = 10;
            this.BackToListCustomerFormB.Text = "Back";
            this.BackToListCustomerFormB.UseVisualStyleBackColor = false;
            this.BackToListCustomerFormB.Click += new System.EventHandler(this.BackToListCustomerFormB_Click);
            // 
            // CustomerNameL
            // 
            this.CustomerNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerNameL.Location = new System.Drawing.Point(115, 32);
            this.CustomerNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameL.Name = "CustomerNameL";
            this.CustomerNameL.Size = new System.Drawing.Size(263, 27);
            this.CustomerNameL.TabIndex = 14;
            this.CustomerNameL.Text = "Custort Name Surname";
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 321);
            this.Controls.Add(this.CustomerNameL);
            this.Controls.Add(this.BackToListCustomerFormB);
            this.Controls.Add(this.customer_idL);
            this.Controls.Add(this.FuelTypeCB);
            this.Controls.Add(this.PlateNumberTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddVehicleB);
            this.Controls.Add(this.VehicleTypeTB);
            this.Controls.Add(this.PlateNumberL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddVehicleForm";
            this.Text = "Add Vehicle ";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlateNumberL;
        private System.Windows.Forms.TextBox VehicleTypeTB;
        private System.Windows.Forms.Button AddVehicleB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlateNumberTB;
        private System.Windows.Forms.ComboBox FuelTypeCB;
        private System.Windows.Forms.Label customer_idL;
        private System.Windows.Forms.Button BackToListCustomerFormB;
        private System.Windows.Forms.Label CustomerNameL;
    }
}