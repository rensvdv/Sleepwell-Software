
namespace Sleepwell
{
    partial class Form5
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
            this.tbxEmailInvoer = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbxPWInvoer = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbxNaamInvoer = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.tbxAgeInvoer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxEmailInvoer
            // 
            this.tbxEmailInvoer.Location = new System.Drawing.Point(150, 310);
            this.tbxEmailInvoer.Name = "tbxEmailInvoer";
            this.tbxEmailInvoer.Size = new System.Drawing.Size(202, 22);
            this.tbxEmailInvoer.TabIndex = 17;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lbEmail.Location = new System.Drawing.Point(211, 282);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(77, 25);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "EMAIL";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Location = new System.Drawing.Point(416, 282);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(138, 25);
            this.lbPassword.TabIndex = 23;
            this.lbPassword.Text = "PASSWORD";
            // 
            // tbxPWInvoer
            // 
            this.tbxPWInvoer.Location = new System.Drawing.Point(382, 310);
            this.tbxPWInvoer.Name = "tbxPWInvoer";
            this.tbxPWInvoer.Size = new System.Drawing.Size(202, 22);
            this.tbxPWInvoer.TabIndex = 22;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbName.Location = new System.Drawing.Point(211, 215);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 25);
            this.lbName.TabIndex = 25;
            this.lbName.Text = "NAAM";
            // 
            // tbxNaamInvoer
            // 
            this.tbxNaamInvoer.Location = new System.Drawing.Point(149, 243);
            this.tbxNaamInvoer.Name = "tbxNaamInvoer";
            this.tbxNaamInvoer.Size = new System.Drawing.Size(202, 22);
            this.tbxNaamInvoer.TabIndex = 24;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAge.Location = new System.Drawing.Point(431, 215);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(112, 25);
            this.lbAge.TabIndex = 27;
            this.lbAge.Text = "LEEFTIJD";
            // 
            // tbxAgeInvoer
            // 
            this.tbxAgeInvoer.Location = new System.Drawing.Point(384, 243);
            this.tbxAgeInvoer.Name = "tbxAgeInvoer";
            this.tbxAgeInvoer.Size = new System.Drawing.Size(202, 22);
            this.tbxAgeInvoer.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(211, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "MAAK EEN ACCOUNT AAN!";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tbxAgeInvoer);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbxNaamInvoer);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbxPWInvoer);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbxEmailInvoer);
            this.Name = "Form5";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEmailInvoer;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbxPWInvoer;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxNaamInvoer;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbxAgeInvoer;
        private System.Windows.Forms.Label label1;
    }
}