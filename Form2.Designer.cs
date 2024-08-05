namespace EntityFrameworkProject
{
    partial class FuelPurchaseForm
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
            this.TransactionAmountL = new System.Windows.Forms.Label();
            this.DateL = new System.Windows.Forms.Label();
            this.FuelAmountL = new System.Windows.Forms.Label();
            this.FuelAmountTB = new System.Windows.Forms.TextBox();
            this.TransactionAmountTB = new System.Windows.Forms.TextBox();
            this.BackToListCustomerFormB = new System.Windows.Forms.Button();
            this.PurchaseFuelB = new System.Windows.Forms.Button();
            this.DateOfPurchaseDTP = new System.Windows.Forms.DateTimePicker();
            this.VehicleIdL = new System.Windows.Forms.Label();
            this.CustomerIdL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentTypeCB = new System.Windows.Forms.ComboBox();
            this.VehicleTypeL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerNameL
            // 
            this.CustomerNameL.AutoSize = true;
            this.CustomerNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerNameL.Location = new System.Drawing.Point(147, 23);
            this.CustomerNameL.Name = "CustomerNameL";
            this.CustomerNameL.Size = new System.Drawing.Size(216, 22);
            this.CustomerNameL.TabIndex = 10;
            this.CustomerNameL.Text = "Customer Name Surname";
            // 
            // TransactionAmountL
            // 
            this.TransactionAmountL.AutoSize = true;
            this.TransactionAmountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TransactionAmountL.Location = new System.Drawing.Point(35, 197);
            this.TransactionAmountL.Name = "TransactionAmountL";
            this.TransactionAmountL.Size = new System.Drawing.Size(152, 20);
            this.TransactionAmountL.TabIndex = 11;
            this.TransactionAmountL.Text = "Transaction Amount";
            // 
            // DateL
            // 
            this.DateL.AutoSize = true;
            this.DateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateL.Location = new System.Drawing.Point(35, 141);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(136, 20);
            this.DateL.TabIndex = 12;
            this.DateL.Text = "Date Of Purchase";
            // 
            // FuelAmountL
            // 
            this.FuelAmountL.AutoSize = true;
            this.FuelAmountL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FuelAmountL.Location = new System.Drawing.Point(81, 87);
            this.FuelAmountL.Name = "FuelAmountL";
            this.FuelAmountL.Size = new System.Drawing.Size(100, 20);
            this.FuelAmountL.TabIndex = 13;
            this.FuelAmountL.Text = "Fuel Amount";
            // 
            // FuelAmountTB
            // 
            this.FuelAmountTB.Location = new System.Drawing.Point(209, 87);
            this.FuelAmountTB.MinimumSize = new System.Drawing.Size(4, 25);
            this.FuelAmountTB.Name = "FuelAmountTB";
            this.FuelAmountTB.Size = new System.Drawing.Size(154, 20);
            this.FuelAmountTB.TabIndex = 14;
            this.FuelAmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FuelAmountTB_KeyPress);
            // 
            // TransactionAmountTB
            // 
            this.TransactionAmountTB.Location = new System.Drawing.Point(209, 197);
            this.TransactionAmountTB.MinimumSize = new System.Drawing.Size(4, 25);
            this.TransactionAmountTB.Name = "TransactionAmountTB";
            this.TransactionAmountTB.Size = new System.Drawing.Size(154, 20);
            this.TransactionAmountTB.TabIndex = 16;
            this.TransactionAmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransactionAmountTB_KeyPress);
            // 
            // BackToListCustomerFormB
            // 
            this.BackToListCustomerFormB.BackColor = System.Drawing.Color.Khaki;
            this.BackToListCustomerFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToListCustomerFormB.Location = new System.Drawing.Point(10, 352);
            this.BackToListCustomerFormB.Name = "BackToListCustomerFormB";
            this.BackToListCustomerFormB.Size = new System.Drawing.Size(105, 30);
            this.BackToListCustomerFormB.TabIndex = 17;
            this.BackToListCustomerFormB.Text = "Back";
            this.BackToListCustomerFormB.UseVisualStyleBackColor = false;
            this.BackToListCustomerFormB.Click += new System.EventHandler(this.BackToListCustomerFormB_Click);
            // 
            // PurchaseFuelB
            // 
            this.PurchaseFuelB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PurchaseFuelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PurchaseFuelB.Location = new System.Drawing.Point(304, 352);
            this.PurchaseFuelB.Name = "PurchaseFuelB";
            this.PurchaseFuelB.Size = new System.Drawing.Size(130, 30);
            this.PurchaseFuelB.TabIndex = 18;
            this.PurchaseFuelB.Text = "Purchase Fuel";
            this.PurchaseFuelB.UseVisualStyleBackColor = false;
            this.PurchaseFuelB.Click += new System.EventHandler(this.PurchaseFuelB_Click);
            // 
            // DateOfPurchaseDTP
            // 
            this.DateOfPurchaseDTP.Location = new System.Drawing.Point(209, 141);
            this.DateOfPurchaseDTP.MinimumSize = new System.Drawing.Size(4, 25);
            this.DateOfPurchaseDTP.Name = "DateOfPurchaseDTP";
            this.DateOfPurchaseDTP.Size = new System.Drawing.Size(154, 25);
            this.DateOfPurchaseDTP.TabIndex = 19;
            // 
            // VehicleIdL
            // 
            this.VehicleIdL.AutoSize = true;
            this.VehicleIdL.Location = new System.Drawing.Point(128, 361);
            this.VehicleIdL.Name = "VehicleIdL";
            this.VehicleIdL.Size = new System.Drawing.Size(55, 13);
            this.VehicleIdL.TabIndex = 20;
            this.VehicleIdL.Text = "vehicle_id";
            this.VehicleIdL.UseWaitCursor = true;
            this.VehicleIdL.Visible = false;
            // 
            // CustomerIdL
            // 
            this.CustomerIdL.AutoSize = true;
            this.CustomerIdL.Location = new System.Drawing.Point(194, 361);
            this.CustomerIdL.Name = "CustomerIdL";
            this.CustomerIdL.Size = new System.Drawing.Size(64, 13);
            this.CustomerIdL.TabIndex = 21;
            this.CustomerIdL.Text = "customer_id";
            this.CustomerIdL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Payment Type";
            // 
            // PaymentTypeCB
            // 
            this.PaymentTypeCB.FormattingEnabled = true;
            this.PaymentTypeCB.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Gift Card"});
            this.PaymentTypeCB.Location = new System.Drawing.Point(209, 244);
            this.PaymentTypeCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaymentTypeCB.Name = "PaymentTypeCB";
            this.PaymentTypeCB.Size = new System.Drawing.Size(154, 21);
            this.PaymentTypeCB.TabIndex = 23;
            // 
            // VehicleTypeL
            // 
            this.VehicleTypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VehicleTypeL.Location = new System.Drawing.Point(259, 23);
            this.VehicleTypeL.Name = "VehicleTypeL";
            this.VehicleTypeL.Size = new System.Drawing.Size(104, 22);
            this.VehicleTypeL.TabIndex = 24;
            this.VehicleTypeL.Text = "Vehicle Type";
            // 
            // FuelPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 392);
            this.Controls.Add(this.VehicleTypeL);
            this.Controls.Add(this.PaymentTypeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerIdL);
            this.Controls.Add(this.VehicleIdL);
            this.Controls.Add(this.DateOfPurchaseDTP);
            this.Controls.Add(this.PurchaseFuelB);
            this.Controls.Add(this.BackToListCustomerFormB);
            this.Controls.Add(this.TransactionAmountTB);
            this.Controls.Add(this.FuelAmountTB);
            this.Controls.Add(this.FuelAmountL);
            this.Controls.Add(this.DateL);
            this.Controls.Add(this.TransactionAmountL);
            this.Controls.Add(this.CustomerNameL);
            this.Name = "FuelPurchaseForm";
            this.Text = "Fuel Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerNameL;
        private System.Windows.Forms.Label TransactionAmountL;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.Label FuelAmountL;
        private System.Windows.Forms.TextBox FuelAmountTB;
        private System.Windows.Forms.TextBox TransactionAmountTB;
        private System.Windows.Forms.Button BackToListCustomerFormB;
        private System.Windows.Forms.Button PurchaseFuelB;
        private System.Windows.Forms.DateTimePicker DateOfPurchaseDTP;
        private System.Windows.Forms.Label VehicleIdL;
        private System.Windows.Forms.Label CustomerIdL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaymentTypeCB;
        private System.Windows.Forms.Label VehicleTypeL;
    }
}