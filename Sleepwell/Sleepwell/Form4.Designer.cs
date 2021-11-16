
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
            this.gbRating = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).BeginInit();
            this.gbRating.SuspendLayout();
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
            this.listBox1.Location = new System.Drawing.Point(408, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 164);
            this.listBox1.TabIndex = 1;
            // 
            // btnRatingSturenNaarDatabase
            // 
            this.btnRatingSturenNaarDatabase.Location = new System.Drawing.Point(88, 142);
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
            this.tbRatingGeven.Location = new System.Drawing.Point(59, 80);
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
            this.lblRatingWaarde.Location = new System.Drawing.Point(139, 33);
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
            this.label2.Location = new System.Drawing.Point(53, 33);
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
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "/5";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(74, 169);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 44);
            this.btnStop.TabIndex = 39;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // gbRating
            // 
            this.gbRating.Controls.Add(this.label2);
            this.gbRating.Controls.Add(this.btnRatingSturenNaarDatabase);
            this.gbRating.Controls.Add(this.lblRatingWaarde);
            this.gbRating.Controls.Add(this.tbRatingGeven);
            this.gbRating.Controls.Add(this.label1);
            this.gbRating.Location = new System.Drawing.Point(243, 220);
            this.gbRating.Name = "gbRating";
            this.gbRating.Size = new System.Drawing.Size(269, 225);
            this.gbRating.TabIndex = 40;
            this.gbRating.TabStop = false;
            this.gbRating.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 48);
            this.label3.TabIndex = 41;
            this.label3.Text = "Aan het slapen...\r\nWeltruste!\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(404, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Uw hartslag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Slaapsessie stoppen";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbRating);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).EndInit();
            this.gbRating.ResumeLayout(false);
            this.gbRating.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}