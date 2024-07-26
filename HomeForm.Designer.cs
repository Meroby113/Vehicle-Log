namespace EntityFrameworkProject
{
    partial class HomeF
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
            this.label1 = new System.Windows.Forms.Label();
            this.HomePageL = new System.Windows.Forms.Label();
            this.AddCustomerB = new System.Windows.Forms.Button();
            this.ListCustomerB = new System.Windows.Forms.Button();
            this.HomePagePB = new System.Windows.Forms.PictureBox();
            this.HomePageL2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(192, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meroby113 Vehicle System";
            // 
            // HomePageL
            // 
            this.HomePageL.AutoSize = true;
            this.HomePageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomePageL.Location = new System.Drawing.Point(217, 558);
            this.HomePageL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomePageL.MaximumSize = new System.Drawing.Size(667, 0);
            this.HomePageL.MinimumSize = new System.Drawing.Size(67, 98);
            this.HomePageL.Name = "HomePageL";
            this.HomePageL.Size = new System.Drawing.Size(610, 98);
            this.HomePageL.TabIndex = 2;
            this.HomePageL.Text = "Welcome to Meroby113 Vehicle System,\nWith this application, you can track your cu" +
    "stomers, their vehicles, fuel purchases and customer budget.";
            // 
            // AddCustomerB
            // 
            this.AddCustomerB.BackColor = System.Drawing.Color.Khaki;
            this.AddCustomerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddCustomerB.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AddCustomerB.Location = new System.Drawing.Point(141, 859);
            this.AddCustomerB.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomerB.Name = "AddCustomerB";
            this.AddCustomerB.Size = new System.Drawing.Size(263, 44);
            this.AddCustomerB.TabIndex = 3;
            this.AddCustomerB.Text = "Add Customer";
            this.AddCustomerB.UseVisualStyleBackColor = false;
            this.AddCustomerB.Click += new System.EventHandler(this.AddCustomerB_Click);
            // 
            // ListCustomerB
            // 
            this.ListCustomerB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ListCustomerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListCustomerB.Location = new System.Drawing.Point(671, 859);
            this.ListCustomerB.Margin = new System.Windows.Forms.Padding(4);
            this.ListCustomerB.Name = "ListCustomerB";
            this.ListCustomerB.Size = new System.Drawing.Size(263, 44);
            this.ListCustomerB.TabIndex = 4;
            this.ListCustomerB.Text = "List Customers";
            this.ListCustomerB.UseVisualStyleBackColor = false;
            this.ListCustomerB.Click += new System.EventHandler(this.ListCustomerB_Click);
            // 
            // HomePagePB
            // 
            this.HomePagePB.Image = global::EntityFrameworkProject.Properties.Resources.download__1_;
            this.HomePagePB.Location = new System.Drawing.Point(268, 174);
            this.HomePagePB.Margin = new System.Windows.Forms.Padding(4);
            this.HomePagePB.Name = "HomePagePB";
            this.HomePagePB.Size = new System.Drawing.Size(533, 297);
            this.HomePagePB.TabIndex = 0;
            this.HomePagePB.TabStop = false;
            this.HomePagePB.Click += new System.EventHandler(this.HomePagePB_Click);
            // 
            // HomePageL2
            // 
            this.HomePageL2.AutoSize = true;
            this.HomePageL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomePageL2.Location = new System.Drawing.Point(217, 671);
            this.HomePageL2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomePageL2.MaximumSize = new System.Drawing.Size(667, 0);
            this.HomePageL2.MinimumSize = new System.Drawing.Size(67, 98);
            this.HomePageL2.Name = "HomePageL2";
            this.HomePageL2.Size = new System.Drawing.Size(469, 120);
            this.HomePageL2.TabIndex = 5;
            this.HomePageL2.Text = "Customers can be listed, added, updated and deleted.\r\nEvery user have their budge" +
    "t, vehicles and history of fuel purhase.\r\nAnd some additional futures are avalib" +
    "le in this app.\r\nJust go on..\r\n\r\n\r\n";
            // 
            // HomeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 1050);
            this.Controls.Add(this.HomePageL2);
            this.Controls.Add(this.ListCustomerB);
            this.Controls.Add(this.AddCustomerB);
            this.Controls.Add(this.HomePageL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomePagePB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeF";
            this.Text = "Meroby Vehicle System";
            this.Load += new System.EventHandler(this.HomeF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePagePB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HomePageL;
        private System.Windows.Forms.Button AddCustomerB;
        private System.Windows.Forms.Button ListCustomerB;
        private System.Windows.Forms.Label HomePageL2;
    }
}