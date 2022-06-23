namespace pizzaOrder_Project
{
    partial class frmChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlaceTheOrder = new System.Windows.Forms.Button();
            this.txtNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnPlaceTheOrder);
            this.panel1.Location = new System.Drawing.Point(46, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 118);
            this.panel1.TabIndex = 5;
            // 
            // btnPlaceTheOrder
            // 
            this.btnPlaceTheOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceTheOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceTheOrder.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaceTheOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlaceTheOrder.Location = new System.Drawing.Point(0, 0);
            this.btnPlaceTheOrder.Name = "btnPlaceTheOrder";
            this.btnPlaceTheOrder.Size = new System.Drawing.Size(465, 119);
            this.btnPlaceTheOrder.TabIndex = 3;
            this.btnPlaceTheOrder.Text = "Confirm";
            this.btnPlaceTheOrder.UseVisualStyleBackColor = true;
            this.btnPlaceTheOrder.Click += new System.EventHandler(this.btnPlaceTheOrder_Click);
            // 
            // txtNewPasswordAgain
            // 
            this.txtNewPasswordAgain.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPasswordAgain.Location = new System.Drawing.Point(238, 104);
            this.txtNewPasswordAgain.MaxLength = 15;
            this.txtNewPasswordAgain.Name = "txtNewPasswordAgain";
            this.txtNewPasswordAgain.Size = new System.Drawing.Size(273, 29);
            this.txtNewPasswordAgain.TabIndex = 4;
            this.txtNewPasswordAgain.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPassword.Location = new System.Drawing.Point(238, 69);
            this.txtNewPassword.MaxLength = 15;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(273, 29);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPassword.Location = new System.Drawing.Point(238, 34);
            this.txtOldPassword.MaxLength = 15;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(273, 29);
            this.txtOldPassword.TabIndex = 7;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(40, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Password";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(541, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNewPasswordAgain);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlaceTheOrder;
        private System.Windows.Forms.TextBox txtNewPasswordAgain;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}