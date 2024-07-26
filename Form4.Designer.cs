namespace EntityFrameworkProject
{
    partial class MessageBoxForm
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
            this.MessageL = new System.Windows.Forms.Label();
            this.OkeyB = new System.Windows.Forms.Button();
            this.CancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageL
            // 
            this.MessageL.AutoSize = true;
            this.MessageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MessageL.Location = new System.Drawing.Point(23, 19);
            this.MessageL.Name = "MessageL";
            this.MessageL.Size = new System.Drawing.Size(64, 16);
            this.MessageL.TabIndex = 0;
            this.MessageL.Text = "Message";
            // 
            // OkeyB
            // 
            this.OkeyB.BackColor = System.Drawing.Color.SpringGreen;
            this.OkeyB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OkeyB.Location = new System.Drawing.Point(544, 65);
            this.OkeyB.Name = "OkeyB";
            this.OkeyB.Size = new System.Drawing.Size(109, 35);
            this.OkeyB.TabIndex = 1;
            this.OkeyB.Text = "Okey";
            this.OkeyB.UseVisualStyleBackColor = false;
            this.OkeyB.Click += new System.EventHandler(this.OkeyB_Click);
            // 
            // CancelB
            // 
            this.CancelB.BackColor = System.Drawing.Color.OrangeRed;
            this.CancelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CancelB.Location = new System.Drawing.Point(12, 65);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(118, 35);
            this.CancelB.TabIndex = 2;
            this.CancelB.Text = "Cancel";
            this.CancelB.UseVisualStyleBackColor = false;
            this.CancelB.Click += new System.EventHandler(this.CancelB_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 112);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.OkeyB);
            this.Controls.Add(this.MessageL);
            this.Name = "MessageBoxForm";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageL;
        private System.Windows.Forms.Button OkeyB;
        private System.Windows.Forms.Button CancelB;
    }
}