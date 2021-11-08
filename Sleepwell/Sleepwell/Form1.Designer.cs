
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
            this.tbxLeeftijd = new System.Windows.Forms.TextBox();
            this.tbxNaam = new System.Windows.Forms.TextBox();
            this.tijd = new System.Windows.Forms.Timer(this.components);
            this.lblHuidigeTijd = new System.Windows.Forms.Label();
            this.btnAttemptConnectSQL = new System.Windows.Forms.Button();
            this.btnDoorNaarForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(357, 102);
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
            this.label4.Location = new System.Drawing.Point(170, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Naam";
            // 
            // tbxLeeftijd
            // 
            this.tbxLeeftijd.Location = new System.Drawing.Point(362, 130);
            this.tbxLeeftijd.Name = "tbxLeeftijd";
            this.tbxLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.tbxLeeftijd.TabIndex = 17;
            // 
            // tbxNaam
            // 
            this.tbxNaam.Location = new System.Drawing.Point(175, 130);
            this.tbxNaam.Name = "tbxNaam";
            this.tbxNaam.Size = new System.Drawing.Size(100, 22);
            this.tbxNaam.TabIndex = 16;
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
            this.btnAttemptConnectSQL.Location = new System.Drawing.Point(233, 395);
            this.btnAttemptConnectSQL.Name = "btnAttemptConnectSQL";
            this.btnAttemptConnectSQL.Size = new System.Drawing.Size(202, 23);
            this.btnAttemptConnectSQL.TabIndex = 29;
            this.btnAttemptConnectSQL.Text = "Attempt Connect";
            this.btnAttemptConnectSQL.UseVisualStyleBackColor = true;
            this.btnAttemptConnectSQL.Click += new System.EventHandler(this.btnAttemptConnectSQL_Click);
            // 
            // btnDoorNaarForm2
            // 
            this.btnDoorNaarForm2.Location = new System.Drawing.Point(283, 206);
            this.btnDoorNaarForm2.Name = "btnDoorNaarForm2";
            this.btnDoorNaarForm2.Size = new System.Drawing.Size(75, 42);
            this.btnDoorNaarForm2.TabIndex = 33;
            this.btnDoorNaarForm2.Text = "button1";
            this.btnDoorNaarForm2.UseVisualStyleBackColor = true;
            this.btnDoorNaarForm2.Click += new System.EventHandler(this.btnDoorNaarForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(676, 490);
            this.Controls.Add(this.btnDoorNaarForm2);
            this.Controls.Add(this.btnAttemptConnectSQL);
            this.Controls.Add(this.lblHuidigeTijd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxLeeftijd);
            this.Controls.Add(this.tbxNaam);
            this.Name = "Form1";
            this.Text = "Sleepwell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLeeftijd;
        private System.Windows.Forms.TextBox tbxNaam;
        private System.Windows.Forms.Timer tijd;
        private System.Windows.Forms.Label lblHuidigeTijd;
        private System.Windows.Forms.Button btnAttemptConnectSQL;
        private System.Windows.Forms.Button btnDoorNaarForm2;
    }
}

