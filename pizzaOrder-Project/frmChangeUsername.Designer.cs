namespace pizzaOrder_Project
{
    partial class frmChangeUsername
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
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlaceTheOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewUsername.Location = new System.Drawing.Point(31, 34);
            this.txtNewUsername.MaxLength = 15;
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(273, 29);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.Text = "New Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnPlaceTheOrder);
            this.panel1.Location = new System.Drawing.Point(31, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 118);
            this.panel1.TabIndex = 3;
            // 
            // btnPlaceTheOrder
            // 
            this.btnPlaceTheOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceTheOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceTheOrder.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaceTheOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlaceTheOrder.Location = new System.Drawing.Point(0, 0);
            this.btnPlaceTheOrder.Name = "btnPlaceTheOrder";
            this.btnPlaceTheOrder.Size = new System.Drawing.Size(273, 119);
            this.btnPlaceTheOrder.TabIndex = 3;
            this.btnPlaceTheOrder.Text = "Confirm";
            this.btnPlaceTheOrder.UseVisualStyleBackColor = true;
            this.btnPlaceTheOrder.Click += new System.EventHandler(this.btnPlaceTheOrder_Click);
            // 
            // frmChangeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(352, 228);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNewUsername);
            this.Name = "frmChangeUsername";
            this.Text = "frmChangeUsername";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlaceTheOrder;
    }
}