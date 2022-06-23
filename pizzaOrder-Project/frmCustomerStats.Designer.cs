namespace pizzaOrder_Project
{
    partial class frmCustomerStats
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
            this.lblHi = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblHi.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHi.ForeColor = System.Drawing.Color.LightGray;
            this.lblHi.Location = new System.Drawing.Point(176, 28);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(414, 62);
            this.lblHi.TabIndex = 0;
            this.lblHi.Text = "Hi, <Username>!";
            this.lblHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lblStats.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStats.ForeColor = System.Drawing.Color.LightGray;
            this.lblStats.Location = new System.Drawing.Point(34, 107);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(712, 210);
            this.lblStats.TabIndex = 2;
            this.lblStats.Text = "You created this account in <DateTime>!\r\nYou are our <Number>th registered custom" +
    "er!\r\nYou have <OrderNumber> Order!\r\nYour phone is <Phone>!\r\nYour adress is <Adre" +
    "ss>!";
            this.lblStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCustomerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblHi);
            this.Name = "frmCustomerStats";
            this.Text = "frmCustomerStats";
            this.Load += new System.EventHandler(this.frmCustomerStats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.Label lblStats;
    }
}