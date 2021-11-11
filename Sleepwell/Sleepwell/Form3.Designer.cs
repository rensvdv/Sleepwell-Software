
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
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tijd = new System.Windows.Forms.Timer(this.components);
            this.lblHuidigeTijd = new System.Windows.Forms.Label();
            this.btnNaarForm4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bStartDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTime.Location = new System.Drawing.Point(475, 73);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(107, 24);
            this.lbTime.TabIndex = 35;
            this.lbTime.Text = "Reminder:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTimer.Location = new System.Drawing.Point(231, 124);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(45, 24);
            this.lbTimer.TabIndex = 34;
            this.lbTimer.Text = "Tijd";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbInfo.Location = new System.Drawing.Point(379, 171);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(240, 25);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "(hier komt info te staan)";
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
            this.lblHuidigeTijd.Location = new System.Drawing.Point(977, 5);
            this.lblHuidigeTijd.Name = "lblHuidigeTijd";
            this.lblHuidigeTijd.Size = new System.Drawing.Size(88, 24);
            this.lblHuidigeTijd.TabIndex = 36;
            this.lblHuidigeTijd.Text = "00:00:00";
            // 
            // btnNaarForm4
            // 
            this.btnNaarForm4.Location = new System.Drawing.Point(323, 427);
            this.btnNaarForm4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNaarForm4.Name = "btnNaarForm4";
            this.btnNaarForm4.Size = new System.Drawing.Size(449, 46);
            this.btnNaarForm4.TabIndex = 37;
            this.btnNaarForm4.Text = "Start Sleep Session";
            this.btnNaarForm4.UseVisualStyleBackColor = true;
            this.btnNaarForm4.Click += new System.EventHandler(this.btnNaarForm4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(449, 46);
            this.button1.TabIndex = 38;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStartDemo
            // 
            this.bStartDemo.Location = new System.Drawing.Point(454, 481);
            this.bStartDemo.Margin = new System.Windows.Forms.Padding(4);
            this.bStartDemo.Name = "bStartDemo";
            this.bStartDemo.Size = new System.Drawing.Size(165, 61);
            this.bStartDemo.TabIndex = 39;
            this.bStartDemo.Text = "DEMO";
            this.bStartDemo.UseVisualStyleBackColor = true;
            this.bStartDemo.Click += new System.EventHandler(this.bStartDemo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bStartDemo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNaarForm4);
            this.Controls.Add(this.lblHuidigeTijd);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Timer tijd;
        private System.Windows.Forms.Label lblHuidigeTijd;
        private System.Windows.Forms.Button btnNaarForm4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bStartDemo;
    }
}