﻿
namespace Sleepwell
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.tijd = new System.Windows.Forms.Timer(this.components);
            this.lblHuidigeTijd = new System.Windows.Forms.Label();
            this.btnNaarForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(206, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Reminder:";
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReminder.Location = new System.Drawing.Point(290, 81);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(26, 18);
            this.lblReminder.TabIndex = 34;
            this.lblReminder.Text = "10";
            // 
            // lblInformatie
            // 
            this.lblInformatie.AutoSize = true;
            this.lblInformatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformatie.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInformatie.Location = new System.Drawing.Point(205, 111);
            this.lblInformatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(201, 20);
            this.lblInformatie.TabIndex = 33;
            this.lblInformatie.Text = "(hier komt info te staan)";
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
            this.lblHuidigeTijd.Location = new System.Drawing.Point(525, 7);
            this.lblHuidigeTijd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHuidigeTijd.Name = "lblHuidigeTijd";
            this.lblHuidigeTijd.Size = new System.Drawing.Size(72, 18);
            this.lblHuidigeTijd.TabIndex = 36;
            this.lblHuidigeTijd.Text = "00:00:00";
            // 
            // btnNaarForm4
            // 
            this.btnNaarForm4.Location = new System.Drawing.Point(209, 209);
            this.btnNaarForm4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNaarForm4.Name = "btnNaarForm4";
            this.btnNaarForm4.Size = new System.Drawing.Size(156, 30);
            this.btnNaarForm4.TabIndex = 37;
            this.btnNaarForm4.Text = "Check je hartslag";
            this.btnNaarForm4.UseVisualStyleBackColor = true;
            this.btnNaarForm4.Click += new System.EventHandler(this.btnNaarForm4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnNaarForm4);
            this.Controls.Add(this.lblHuidigeTijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.lblInformatie);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblInformatie;
        private System.Windows.Forms.Timer tijd;
        private System.Windows.Forms.Label lblHuidigeTijd;
        private System.Windows.Forms.Button btnNaarForm4;
    }
}