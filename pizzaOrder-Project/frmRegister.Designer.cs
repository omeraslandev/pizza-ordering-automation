namespace pizzaOrder_Project
{
    partial class frmRegister
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordAgain = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msktxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnPlaceTheOrder);
            this.panel1.Location = new System.Drawing.Point(28, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 118);
            this.panel1.TabIndex = 5;
            // 
            // btnPlaceTheOrder
            // 
            this.btnPlaceTheOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceTheOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceTheOrder.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlaceTheOrder.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlaceTheOrder.Location = new System.Drawing.Point(3, 0);
            this.btnPlaceTheOrder.Name = "btnPlaceTheOrder";
            this.btnPlaceTheOrder.Size = new System.Drawing.Size(457, 119);
            this.btnPlaceTheOrder.TabIndex = 3;
            this.btnPlaceTheOrder.Text = "Confirm";
            this.btnPlaceTheOrder.UseVisualStyleBackColor = true;
            this.btnPlaceTheOrder.Click += new System.EventHandler(this.btnPlaceTheOrder_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(183, 54);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(316, 29);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(183, 89);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(316, 29);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordAgain
            // 
            this.txtPasswordAgain.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPasswordAgain.Location = new System.Drawing.Point(183, 124);
            this.txtPasswordAgain.MaxLength = 15;
            this.txtPasswordAgain.Name = "txtPasswordAgain";
            this.txtPasswordAgain.Size = new System.Drawing.Size(316, 29);
            this.txtPasswordAgain.TabIndex = 7;
            this.txtPasswordAgain.UseSystemPasswordChar = true;
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdress.Location = new System.Drawing.Point(183, 159);
            this.txtAdress.MaxLength = 50;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(316, 107);
            this.txtAdress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "* Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "* Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "* Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "* Phone";
            // 
            // msktxtPhone
            // 
            this.msktxtPhone.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic);
            this.msktxtPhone.Location = new System.Drawing.Point(183, 272);
            this.msktxtPhone.Mask = "(999) 000-0000";
            this.msktxtPhone.Name = "msktxtPhone";
            this.msktxtPhone.Size = new System.Drawing.Size(316, 29);
            this.msktxtPhone.TabIndex = 21;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(527, 488);
            this.Controls.Add(this.msktxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPasswordAgain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlaceTheOrder;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordAgain;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktxtPhone;
    }
}