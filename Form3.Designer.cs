namespace EntityFrameworkProject
{
    partial class FuelHistoryForm
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
            this.CustomerNameL = new System.Windows.Forms.Label();
            this.FuelHistoryDGV = new System.Windows.Forms.DataGridView();
            this.BackToVehicleListFormB = new System.Windows.Forms.Button();
            this.Customer_idL = new System.Windows.Forms.Label();
            this.VehicleIdL = new System.Windows.Forms.Label();
            this.VehicleTypeL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FuelHistoryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameL
            // 
            this.CustomerNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerNameL.Location = new System.Drawing.Point(164, 18);
            this.CustomerNameL.Name = "CustomerNameL";
            this.CustomerNameL.Size = new System.Drawing.Size(173, 22);
            this.CustomerNameL.TabIndex = 11;
            this.CustomerNameL.Text = "Customer Name";
            // 
            // FuelHistoryDGV
            // 
            this.FuelHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuelHistoryDGV.Location = new System.Drawing.Point(53, 61);
            this.FuelHistoryDGV.Name = "FuelHistoryDGV";
            this.FuelHistoryDGV.Size = new System.Drawing.Size(505, 229);
            this.FuelHistoryDGV.TabIndex = 12;
            // 
            // BackToVehicleListFormB
            // 
            this.BackToVehicleListFormB.BackColor = System.Drawing.Color.Khaki;
            this.BackToVehicleListFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToVehicleListFormB.Location = new System.Drawing.Point(53, 316);
            this.BackToVehicleListFormB.Name = "BackToVehicleListFormB";
            this.BackToVehicleListFormB.Size = new System.Drawing.Size(105, 30);
            this.BackToVehicleListFormB.TabIndex = 18;
            this.BackToVehicleListFormB.Text = "Back";
            this.BackToVehicleListFormB.UseVisualStyleBackColor = false;
            this.BackToVehicleListFormB.Click += new System.EventHandler(this.BackToVehicleListFormB_Click);
            // 
            // Customer_idL
            // 
            this.Customer_idL.AutoSize = true;
            this.Customer_idL.Location = new System.Drawing.Point(184, 326);
            this.Customer_idL.Name = "Customer_idL";
            this.Customer_idL.Size = new System.Drawing.Size(65, 13);
            this.Customer_idL.TabIndex = 19;
            this.Customer_idL.Text = "Customer_id";
            this.Customer_idL.Visible = false;
            // 
            // VehicleIdL
            // 
            this.VehicleIdL.AutoSize = true;
            this.VehicleIdL.Location = new System.Drawing.Point(282, 326);
            this.VehicleIdL.Name = "VehicleIdL";
            this.VehicleIdL.Size = new System.Drawing.Size(55, 13);
            this.VehicleIdL.TabIndex = 20;
            this.VehicleIdL.Text = "vehicle_id";
            this.VehicleIdL.Visible = false;
            // 
            // VehicleTypeL
            // 
            this.VehicleTypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VehicleTypeL.Location = new System.Drawing.Point(303, 18);
            this.VehicleTypeL.Name = "VehicleTypeL";
            this.VehicleTypeL.Size = new System.Drawing.Size(104, 22);
            this.VehicleTypeL.TabIndex = 21;
            this.VehicleTypeL.Text = "Vehicle Type";
            // 
            // FuelHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 368);
            this.Controls.Add(this.VehicleTypeL);
            this.Controls.Add(this.VehicleIdL);
            this.Controls.Add(this.Customer_idL);
            this.Controls.Add(this.BackToVehicleListFormB);
            this.Controls.Add(this.FuelHistoryDGV);
            this.Controls.Add(this.CustomerNameL);
            this.Name = "FuelHistoryForm";
            this.Text = "History Of Fuel Purchase";
            this.Load += new System.EventHandler(this.HistoryOfFuelPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuelHistoryDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameL;
        private System.Windows.Forms.DataGridView FuelHistoryDGV;
        private System.Windows.Forms.Button BackToVehicleListFormB;
        private System.Windows.Forms.Label Customer_idL;
        private System.Windows.Forms.Label VehicleIdL;
        private System.Windows.Forms.Label VehicleTypeL;
    }
}