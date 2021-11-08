
namespace Sleepwell
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPW = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tijd = new System.Windows.Forms.Timer(this.components);
            this.lblHuidigeTijd = new System.Windows.Forms.Label();
            this.btnAttemptConnectSQL = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(280, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(293, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "EMAIL";
            // 
            // tbxPW
            // 
            this.tbxPW.Location = new System.Drawing.Point(233, 201);
            this.tbxPW.Name = "tbxPW";
            this.tbxPW.Size = new System.Drawing.Size(202, 22);
            this.tbxPW.TabIndex = 17;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(233, 148);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(202, 22);
            this.tbxEmail.TabIndex = 16;
            // 
            // tijd
            // 
            this.tijd.Enabled = true;
            this.tijd.Interval = 1000;
            this.tijd.Tick += new System.EventHandler(this.tijd_Tick);
            // 
            // lblHuidigeTijd
            // 
            this.lblHuidigeTijd.AutoSize = true;
            this.lblHuidigeTijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuidigeTijd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHuidigeTijd.Location = new System.Drawing.Point(576, 9);
            this.lblHuidigeTijd.Name = "lblHuidigeTijd";
            this.lblHuidigeTijd.Size = new System.Drawing.Size(88, 24);
            this.lblHuidigeTijd.TabIndex = 28;
            this.lblHuidigeTijd.Text = "00:00:00";
            // 
            // btnAttemptConnectSQL
            // 
            this.btnAttemptConnectSQL.Location = new System.Drawing.Point(233, 439);
            this.btnAttemptConnectSQL.Name = "btnAttemptConnectSQL";
            this.btnAttemptConnectSQL.Size = new System.Drawing.Size(202, 23);
            this.btnAttemptConnectSQL.TabIndex = 29;
            this.btnAttemptConnectSQL.Text = "Attempt Connect";
            this.btnAttemptConnectSQL.UseVisualStyleBackColor = true;
            this.btnAttemptConnectSQL.Click += new System.EventHandler(this.btnAttemptConnectSQL_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(298, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 42);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnDoorNaarForm2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(298, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 42);
            this.btnRegister.TabIndex = 34;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(228, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Welkom bij Sleepwell!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(171, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Geen account? Maak er een aan!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(676, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnAttemptConnectSQL);
            this.Controls.Add(this.lblHuidigeTijd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPW);
            this.Controls.Add(this.tbxEmail);
            this.Name = "Form1";
            this.Text = "Sleepwell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPW;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Timer tijd;
        private System.Windows.Forms.Label lblHuidigeTijd;
        private System.Windows.Forms.Button btnAttemptConnectSQL;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

