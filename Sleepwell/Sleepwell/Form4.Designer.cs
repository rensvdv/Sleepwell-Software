﻿
namespace Sleepwell
{
    partial class Form4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRatingSturenNaarDatabase = new System.Windows.Forms.Button();
            this.tbRatingGeven = new System.Windows.Forms.TrackBar();
            this.lblRatingWaarde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTimer
            // 
            this.dataTimer.Interval = 500;
            this.dataTimer.Tick += new System.EventHandler(this.DataTimer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 273);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 164);
            this.listBox1.TabIndex = 1;
            // 
            // btnRatingSturenNaarDatabase
            // 
            this.btnRatingSturenNaarDatabase.Location = new System.Drawing.Point(47, 118);
            this.btnRatingSturenNaarDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRatingSturenNaarDatabase.Name = "btnRatingSturenNaarDatabase";
            this.btnRatingSturenNaarDatabase.Size = new System.Drawing.Size(75, 34);
            this.btnRatingSturenNaarDatabase.TabIndex = 2;
            this.btnRatingSturenNaarDatabase.Text = "Verstuur";
            this.btnRatingSturenNaarDatabase.UseVisualStyleBackColor = true;
            this.btnRatingSturenNaarDatabase.Click += new System.EventHandler(this.btnRatingSturenNaarDatabase_Click);
            // 
            // tbRatingGeven
            // 
            this.tbRatingGeven.Location = new System.Drawing.Point(18, 56);
            this.tbRatingGeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRatingGeven.Maximum = 4;
            this.tbRatingGeven.Name = "tbRatingGeven";
            this.tbRatingGeven.Size = new System.Drawing.Size(155, 56);
            this.tbRatingGeven.TabIndex = 3;
            this.tbRatingGeven.Scroll += new System.EventHandler(this.tbRatingGeven_Scroll);
            // 
            // lblRatingWaarde
            // 
            this.lblRatingWaarde.AutoSize = true;
            this.lblRatingWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingWaarde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRatingWaarde.Location = new System.Drawing.Point(98, 9);
            this.lblRatingWaarde.Name = "lblRatingWaarde";
            this.lblRatingWaarde.Size = new System.Drawing.Size(24, 25);
            this.lblRatingWaarde.TabIndex = 36;
            this.lblRatingWaarde.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "/5";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(135, 198);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop SlaapSessie";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblRatingWaarde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRatingGeven);
            this.Controls.Add(this.btnRatingSturenNaarDatabase);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRatingSturenNaarDatabase;
        private System.Windows.Forms.TrackBar tbRatingGeven;
        private System.Windows.Forms.Label lblRatingWaarde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
    }
}