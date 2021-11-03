
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
            this.lblTijdAanraden = new System.Windows.Forms.Label();
            this.rbKorteSlaap = new System.Windows.Forms.RadioButton();
            this.rbNormaleSlaap = new System.Windows.Forms.RadioButton();
            this.rbLangeSlaap = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxOpstaan = new System.Windows.Forms.TextBox();
            this.btnSlaaptijdBerekenen = new System.Windows.Forms.Button();
            this.tbxLeeftijd = new System.Windows.Forms.TextBox();
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTijdAanraden
            // 
            this.lblTijdAanraden.AutoSize = true;
            this.lblTijdAanraden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdAanraden.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTijdAanraden.Location = new System.Drawing.Point(486, 41);
            this.lblTijdAanraden.Name = "lblTijdAanraden";
            this.lblTijdAanraden.Size = new System.Drawing.Size(240, 25);
            this.lblTijdAanraden.TabIndex = 27;
            this.lblTijdAanraden.Text = "(hier komt info te staan)";
            this.lblTijdAanraden.Visible = false;
            // 
            // rbKorteSlaap
            // 
            this.rbKorteSlaap.AutoSize = true;
            this.rbKorteSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbKorteSlaap.Location = new System.Drawing.Point(26, 275);
            this.rbKorteSlaap.Name = "rbKorteSlaap";
            this.rbKorteSlaap.Size = new System.Drawing.Size(177, 21);
            this.rbKorteSlaap.TabIndex = 26;
            this.rbKorteSlaap.TabStop = true;
            this.rbKorteSlaap.Text = "Kort (niet aan te raden)";
            this.rbKorteSlaap.UseVisualStyleBackColor = true;
            // 
            // rbNormaleSlaap
            // 
            this.rbNormaleSlaap.AutoSize = true;
            this.rbNormaleSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbNormaleSlaap.Location = new System.Drawing.Point(26, 248);
            this.rbNormaleSlaap.Name = "rbNormaleSlaap";
            this.rbNormaleSlaap.Size = new System.Drawing.Size(82, 21);
            this.rbNormaleSlaap.TabIndex = 25;
            this.rbNormaleSlaap.TabStop = true;
            this.rbNormaleSlaap.Text = "Normaal";
            this.rbNormaleSlaap.UseVisualStyleBackColor = true;
            // 
            // rbLangeSlaap
            // 
            this.rbLangeSlaap.AutoSize = true;
            this.rbLangeSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLangeSlaap.Location = new System.Drawing.Point(26, 221);
            this.rbLangeSlaap.Name = "rbLangeSlaap";
            this.rbLangeSlaap.Size = new System.Drawing.Size(61, 21);
            this.rbLangeSlaap.TabIndex = 24;
            this.rbLangeSlaap.TabStop = true;
            this.rbLangeSlaap.Text = "Lang";
            this.rbLangeSlaap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(223, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hoelaat wil u opstaan?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hoeveel slaap wilt u?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(21, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Leeftijd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(21, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Naam";
            // 
            // tbxOpstaan
            // 
            this.tbxOpstaan.Location = new System.Drawing.Point(276, 84);
            this.tbxOpstaan.Name = "tbxOpstaan";
            this.tbxOpstaan.Size = new System.Drawing.Size(113, 22);
            this.tbxOpstaan.TabIndex = 19;
            this.tbxOpstaan.Text = "(bijv 8:00)";
            // 
            // btnSlaaptijdBerekenen
            // 
            this.btnSlaaptijdBerekenen.Location = new System.Drawing.Point(287, 116);
            this.btnSlaaptijdBerekenen.Name = "btnSlaaptijdBerekenen";
            this.btnSlaaptijdBerekenen.Size = new System.Drawing.Size(83, 53);
            this.btnSlaaptijdBerekenen.TabIndex = 18;
            this.btnSlaaptijdBerekenen.Text = "Bereken!";
            this.btnSlaaptijdBerekenen.UseVisualStyleBackColor = true;
            this.btnSlaaptijdBerekenen.Click += new System.EventHandler(this.btnSlaaptijdBerekenen_Click);
            // 
            // tbxLeeftijd
            // 
            this.tbxLeeftijd.Location = new System.Drawing.Point(26, 138);
            this.tbxLeeftijd.Name = "tbxLeeftijd";
            this.tbxLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.tbxLeeftijd.TabIndex = 17;
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(26, 60);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(100, 22);
            this.tbxNaam.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(786, 478);
            this.Controls.Add(this.lblTijdAanraden);
            this.Controls.Add(this.rbKorteSlaap);
            this.Controls.Add(this.rbNormaleSlaap);
            this.Controls.Add(this.rbLangeSlaap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxOpstaan);
            this.Controls.Add(this.btnSlaaptijdBerekenen);
            this.Controls.Add(this.tbxLeeftijd);
            this.Controls.Add(this.tbxNaam);
            this.Name = "Form1";
            this.Text = "Sleepwell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTijdAanraden;
        private System.Windows.Forms.RadioButton rbKorteSlaap;
        private System.Windows.Forms.RadioButton rbNormaleSlaap;
        private System.Windows.Forms.RadioButton rbLangeSlaap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxOpstaan;
        private System.Windows.Forms.Button btnSlaaptijdBerekenen;
        private System.Windows.Forms.TextBox tbxLeeftijd;
        private System.Windows.Forms.TextBox tbxNaam;
    }
}

