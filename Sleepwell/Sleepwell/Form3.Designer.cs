
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
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tijd = new System.Windows.Forms.Timer(this.components);
            this.lblHuidigeTijd = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bStartDemo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTimer.Location = new System.Drawing.Point(186, 180);
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
            this.lbInfo.Location = new System.Drawing.Point(222, 79);
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
            this.lblHuidigeTijd.Location = new System.Drawing.Point(702, 15);
            this.lblHuidigeTijd.Name = "lblHuidigeTijd";
            this.lblHuidigeTijd.Size = new System.Drawing.Size(88, 24);
            this.lblHuidigeTijd.TabIndex = 36;
            this.lblHuidigeTijd.Text = "00:00:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(300, 269);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 42);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start slaapsessie";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 36);
            this.button1.TabIndex = 38;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStartDemo
            // 
            this.bStartDemo.Location = new System.Drawing.Point(315, 375);
            this.bStartDemo.Margin = new System.Windows.Forms.Padding(4);
            this.bStartDemo.Name = "bStartDemo";
            this.bStartDemo.Size = new System.Drawing.Size(77, 35);
            this.bStartDemo.TabIndex = 39;
            this.bStartDemo.Text = "DEMO";
            this.bStartDemo.UseVisualStyleBackColor = true;
            this.bStartDemo.Click += new System.EventHandler(this.bStartDemo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(296, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Email demo";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bStartDemo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHuidigeTijd);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Timer tijd;
        private System.Windows.Forms.Label lblHuidigeTijd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bStartDemo;
        private System.Windows.Forms.Label label1;
    }
}