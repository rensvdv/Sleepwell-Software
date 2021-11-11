
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLeeftijd = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxWachtwoord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnTerugNaarInloggen = new System.Windows.Forms.Button();
            this.Hide_Show_Register = new System.Windows.Forms.CheckBox();
            this.tbxBevestigWW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBevestig = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(203, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "WACHTWOORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(658, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "EMAIL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(179, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "NAAM";
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(128, 98);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(179, 22);
            this.tbxNaam.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(411, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "LEEFTIJD";
            // 
            // tbxLeeftijd
            // 
            this.tbxLeeftijd.Location = new System.Drawing.Point(369, 98);
            this.tbxLeeftijd.Name = "tbxLeeftijd";
            this.tbxLeeftijd.Size = new System.Drawing.Size(179, 22);
            this.tbxLeeftijd.TabIndex = 30;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(597, 98);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(179, 22);
            this.tbxEmail.TabIndex = 31;
            // 
            // tbxWachtwoord
            // 
            this.tbxWachtwoord.Location = new System.Drawing.Point(201, 197);
            this.tbxWachtwoord.Name = "tbxWachtwoord";
            this.tbxWachtwoord.Size = new System.Drawing.Size(179, 22);
            this.tbxWachtwoord.TabIndex = 32;
            this.tbxWachtwoord.UseSystemPasswordChar = true;
            this.tbxWachtwoord.TextChanged += new System.EventHandler(this.tbxWachtwoord_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(258, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Maak hier je account aan!";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(402, 265);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 42);
            this.btnRegister.TabIndex = 35;
            this.btnRegister.Text = "Maak account!";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnTerugNaarInloggen
            // 
            this.btnTerugNaarInloggen.Location = new System.Drawing.Point(13, 13);
            this.btnTerugNaarInloggen.Name = "btnTerugNaarInloggen";
            this.btnTerugNaarInloggen.Size = new System.Drawing.Size(75, 31);
            this.btnTerugNaarInloggen.TabIndex = 36;
            this.btnTerugNaarInloggen.Text = "Terug";
            this.btnTerugNaarInloggen.UseVisualStyleBackColor = true;
            this.btnTerugNaarInloggen.Click += new System.EventHandler(this.btnTerugNaarInloggen_Click);
            // 
            // Hide_Show_Register
            // 
            this.Hide_Show_Register.AutoSize = true;
            this.Hide_Show_Register.ForeColor = System.Drawing.Color.White;
            this.Hide_Show_Register.Location = new System.Drawing.Point(201, 225);
            this.Hide_Show_Register.Name = "Hide_Show_Register";
            this.Hide_Show_Register.Size = new System.Drawing.Size(181, 21);
            this.Hide_Show_Register.TabIndex = 37;
            this.Hide_Show_Register.Text = "Wachtwoord weergeven";
            this.Hide_Show_Register.UseVisualStyleBackColor = true;
            this.Hide_Show_Register.CheckedChanged += new System.EventHandler(this.Hide_Show_Register_CheckedChanged);
            // 
            // tbxBevestigWW
            // 
            this.tbxBevestigWW.Location = new System.Drawing.Point(556, 197);
            this.tbxBevestigWW.Name = "tbxBevestigWW";
            this.tbxBevestigWW.Size = new System.Drawing.Size(179, 22);
            this.tbxBevestigWW.TabIndex = 39;
            this.tbxBevestigWW.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(498, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "BEVESTIG WACHTWOORD";
            // 
            // cbBevestig
            // 
            this.cbBevestig.AutoSize = true;
            this.cbBevestig.ForeColor = System.Drawing.Color.White;
            this.cbBevestig.Location = new System.Drawing.Point(556, 225);
            this.cbBevestig.Name = "cbBevestig";
            this.cbBevestig.Size = new System.Drawing.Size(181, 21);
            this.cbBevestig.TabIndex = 40;
            this.cbBevestig.Text = "Wachtwoord weergeven";
            this.cbBevestig.UseVisualStyleBackColor = true;
            this.cbBevestig.CheckedChanged += new System.EventHandler(this.cbBevestig_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(914, 496);
            this.Controls.Add(this.cbBevestig);
            this.Controls.Add(this.tbxBevestigWW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Hide_Show_Register);
            this.Controls.Add(this.btnTerugNaarInloggen);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxWachtwoord);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxLeeftijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLeeftijd;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxWachtwoord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnTerugNaarInloggen;
        private System.Windows.Forms.CheckBox Hide_Show_Register;
        private System.Windows.Forms.TextBox tbxBevestigWW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbBevestig;
    }
}