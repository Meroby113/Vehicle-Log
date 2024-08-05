namespace EntityFrameworkProject
{
    partial class BudgetForm
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
            this.BackToListCustomerFormB = new System.Windows.Forms.Button();
            this.UpdateBudgetB = new System.Windows.Forms.Button();
            this.AddBudgetB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GiftCardL = new System.Windows.Forms.Label();
            this.CredirL = new System.Windows.Forms.Label();
            this.CashL = new System.Windows.Forms.Label();
            this.GiftCardTB = new System.Windows.Forms.TextBox();
            this.CreditTB = new System.Windows.Forms.TextBox();
            this.CashTB = new System.Windows.Forms.TextBox();
            this.NoBudgetL = new System.Windows.Forms.Label();
            this.Customer_idL = new System.Windows.Forms.Label();
            this.CustomerNameL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EntityFrameworkProject.Properties.Resources.budget__3_;
            this.pictureBox1.Location = new System.Drawing.Point(59, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BackToListCustomerFormB
            // 
            this.BackToListCustomerFormB.BackColor = System.Drawing.Color.Khaki;
            this.BackToListCustomerFormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackToListCustomerFormB.Location = new System.Drawing.Point(25, 278);
            this.BackToListCustomerFormB.Name = "BackToListCustomerFormB";
            this.BackToListCustomerFormB.Size = new System.Drawing.Size(82, 33);
            this.BackToListCustomerFormB.TabIndex = 1;
            this.BackToListCustomerFormB.Text = "Back";
            this.BackToListCustomerFormB.UseVisualStyleBackColor = false;
            this.BackToListCustomerFormB.Click += new System.EventHandler(this.BackToListCustomerFormB_Click);
            // 
            // UpdateBudgetB
            // 
            this.UpdateBudgetB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdateBudgetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBudgetB.Location = new System.Drawing.Point(211, 278);
            this.UpdateBudgetB.Name = "UpdateBudgetB";
            this.UpdateBudgetB.Size = new System.Drawing.Size(153, 33);
            this.UpdateBudgetB.TabIndex = 2;
            this.UpdateBudgetB.Text = "Update Budget";
            this.UpdateBudgetB.UseVisualStyleBackColor = false;
            this.UpdateBudgetB.Click += new System.EventHandler(this.UpdateBudgetB_Click);
            // 
            // AddBudgetB
            // 
            this.AddBudgetB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddBudgetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBudgetB.Location = new System.Drawing.Point(217, 278);
            this.AddBudgetB.Name = "AddBudgetB";
            this.AddBudgetB.Size = new System.Drawing.Size(122, 33);
            this.AddBudgetB.TabIndex = 3;
            this.AddBudgetB.Text = "Add Budget";
            this.AddBudgetB.UseVisualStyleBackColor = false;
            this.AddBudgetB.Visible = false;
            this.AddBudgetB.Click += new System.EventHandler(this.AddBudgetB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // GiftCardL
            // 
            this.GiftCardL.AutoSize = true;
            this.GiftCardL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiftCardL.Location = new System.Drawing.Point(105, 176);
            this.GiftCardL.Name = "GiftCardL";
            this.GiftCardL.Size = new System.Drawing.Size(73, 20);
            this.GiftCardL.TabIndex = 5;
            this.GiftCardL.Text = "Gift Card";
            // 
            // CredirL
            // 
            this.CredirL.AutoSize = true;
            this.CredirL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CredirL.Location = new System.Drawing.Point(105, 209);
            this.CredirL.Name = "CredirL";
            this.CredirL.Size = new System.Drawing.Size(51, 20);
            this.CredirL.TabIndex = 6;
            this.CredirL.Text = "Credit";
            // 
            // CashL
            // 
            this.CashL.AutoSize = true;
            this.CashL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CashL.Location = new System.Drawing.Point(105, 244);
            this.CashL.Name = "CashL";
            this.CashL.Size = new System.Drawing.Size(46, 20);
            this.CashL.TabIndex = 7;
            this.CashL.Text = "Cash";
            // 
            // GiftCardTB
            // 
            this.GiftCardTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiftCardTB.Location = new System.Drawing.Point(184, 173);
            this.GiftCardTB.Name = "GiftCardTB";
            this.GiftCardTB.Size = new System.Drawing.Size(100, 26);
            this.GiftCardTB.TabIndex = 8;
            this.GiftCardTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GiftCardTB_KeyPress);
            // 
            // CreditTB
            // 
            this.CreditTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreditTB.Location = new System.Drawing.Point(184, 209);
            this.CreditTB.Name = "CreditTB";
            this.CreditTB.Size = new System.Drawing.Size(100, 26);
            this.CreditTB.TabIndex = 9;
            this.CreditTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditTB_KeyPress);
            // 
            // CashTB
            // 
            this.CashTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CashTB.Location = new System.Drawing.Point(184, 241);
            this.CashTB.Name = "CashTB";
            this.CashTB.Size = new System.Drawing.Size(100, 26);
            this.CashTB.TabIndex = 10;
            this.CashTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTB_KeyPress);
            // 
            // NoBudgetL
            // 
            this.NoBudgetL.AutoSize = true;
            this.NoBudgetL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoBudgetL.Location = new System.Drawing.Point(56, 193);
            this.NoBudgetL.Name = "NoBudgetL";
            this.NoBudgetL.Size = new System.Drawing.Size(353, 36);
            this.NoBudgetL.TabIndex = 11;
            this.NoBudgetL.Text = "This Customer does not have any budget yet !\r\nPlease click \"Add Budget\" button to" +
    " add new budget..\r\n";
            this.NoBudgetL.Visible = false;
            // 
            // Customer_idL
            // 
            this.Customer_idL.AutoSize = true;
            this.Customer_idL.Location = new System.Drawing.Point(3, 320);
            this.Customer_idL.Name = "Customer_idL";
            this.Customer_idL.Size = new System.Drawing.Size(65, 13);
            this.Customer_idL.TabIndex = 12;
            this.Customer_idL.Text = "Customer_id";
            this.Customer_idL.Visible = false;
            // 
            // CustomerNameL
            // 
            this.CustomerNameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CustomerNameL.Location = new System.Drawing.Point(102, 141);
            this.CustomerNameL.Name = "CustomerNameL";
            this.CustomerNameL.Size = new System.Drawing.Size(197, 22);
            this.CustomerNameL.TabIndex = 13;
            this.CustomerNameL.Text = "Custort Name Surname";
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 329);
            this.Controls.Add(this.CustomerNameL);
            this.Controls.Add(this.Customer_idL);
            this.Controls.Add(this.NoBudgetL);
            this.Controls.Add(this.CashTB);
            this.Controls.Add(this.CreditTB);
            this.Controls.Add(this.GiftCardTB);
            this.Controls.Add(this.CashL);
            this.Controls.Add(this.CredirL);
            this.Controls.Add(this.GiftCardL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBudgetB);
            this.Controls.Add(this.UpdateBudgetB);
            this.Controls.Add(this.BackToListCustomerFormB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BudgetForm";
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackToListCustomerFormB;
        private System.Windows.Forms.Button UpdateBudgetB;
        private System.Windows.Forms.Button AddBudgetB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GiftCardL;
        private System.Windows.Forms.Label CredirL;
        private System.Windows.Forms.Label CashL;
        private System.Windows.Forms.TextBox GiftCardTB;
        private System.Windows.Forms.TextBox CreditTB;
        private System.Windows.Forms.TextBox CashTB;
        private System.Windows.Forms.Label NoBudgetL;
        private System.Windows.Forms.Label Customer_idL;
        private System.Windows.Forms.Label CustomerNameL;
    }
}