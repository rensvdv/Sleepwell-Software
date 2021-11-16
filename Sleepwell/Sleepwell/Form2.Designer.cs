
namespace Sleepwell
{
    partial class Form2
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
            this.rbKorteSlaap = new System.Windows.Forms.RadioButton();
            this.rbNormaleSlaap = new System.Windows.Forms.RadioButton();
            this.rbLangeSlaap = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOpstaan = new System.Windows.Forms.TextBox();
            this.btnSlaaptijdBerekenen = new System.Windows.Forms.Button();
            this.lblFoutmelding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbKorteSlaap
            // 
            this.rbKorteSlaap.AutoSize = true;
            this.rbKorteSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbKorteSlaap.Location = new System.Drawing.Point(148, 161);
            this.rbKorteSlaap.Name = "rbKorteSlaap";
            this.rbKorteSlaap.Size = new System.Drawing.Size(177, 21);
            this.rbKorteSlaap.TabIndex = 33;
            this.rbKorteSlaap.TabStop = true;
            this.rbKorteSlaap.Text = "Kort (niet aan te raden)";
            this.rbKorteSlaap.UseVisualStyleBackColor = true;
            // 
            // rbNormaleSlaap
            // 
            this.rbNormaleSlaap.AutoSize = true;
            this.rbNormaleSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbNormaleSlaap.Location = new System.Drawing.Point(148, 134);
            this.rbNormaleSlaap.Name = "rbNormaleSlaap";
            this.rbNormaleSlaap.Size = new System.Drawing.Size(82, 21);
            this.rbNormaleSlaap.TabIndex = 32;
            this.rbNormaleSlaap.TabStop = true;
            this.rbNormaleSlaap.Text = "Normaal";
            this.rbNormaleSlaap.UseVisualStyleBackColor = true;
            // 
            // rbLangeSlaap
            // 
            this.rbLangeSlaap.AutoSize = true;
            this.rbLangeSlaap.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLangeSlaap.Location = new System.Drawing.Point(148, 107);
            this.rbLangeSlaap.Name = "rbLangeSlaap";
            this.rbLangeSlaap.Size = new System.Drawing.Size(61, 21);
            this.rbLangeSlaap.TabIndex = 31;
            this.rbLangeSlaap.TabStop = true;
            this.rbLangeSlaap.Text = "Lang";
            this.rbLangeSlaap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(379, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hoelaat wil u opstaan?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(139, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Hoeveel slaap wilt u?";
            // 
            // tbxOpstaan
            // 
            this.tbxOpstaan.Location = new System.Drawing.Point(415, 133);
            this.tbxOpstaan.Name = "tbxOpstaan";
            this.tbxOpstaan.Size = new System.Drawing.Size(144, 22);
            this.tbxOpstaan.TabIndex = 28;
            this.tbxOpstaan.Enter += new System.EventHandler(this.tbxOpstaan_Enter);
            this.tbxOpstaan.Leave += new System.EventHandler(this.tbxOpstaan_Leave);
            // 
            // btnSlaaptijdBerekenen
            // 
            this.btnSlaaptijdBerekenen.Location = new System.Drawing.Point(322, 238);
            this.btnSlaaptijdBerekenen.Name = "btnSlaaptijdBerekenen";
            this.btnSlaaptijdBerekenen.Size = new System.Drawing.Size(83, 53);
            this.btnSlaaptijdBerekenen.TabIndex = 27;
            this.btnSlaaptijdBerekenen.Text = "Bereken!";
            this.btnSlaaptijdBerekenen.UseVisualStyleBackColor = true;
            this.btnSlaaptijdBerekenen.Click += new System.EventHandler(this.btnSlaaptijdBerekenen_Click);
            // 
            // lblFoutmelding
            // 
            this.lblFoutmelding.AutoSize = true;
            this.lblFoutmelding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoutmelding.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFoutmelding.Location = new System.Drawing.Point(224, 38);
            this.lblFoutmelding.Name = "lblFoutmelding";
            this.lblFoutmelding.Size = new System.Drawing.Size(123, 25);
            this.lblFoutmelding.TabIndex = 38;
            this.lblFoutmelding.Text = "foutmelding";
            this.lblFoutmelding.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.lblFoutmelding);
            this.Controls.Add(this.rbKorteSlaap);
            this.Controls.Add(this.rbNormaleSlaap);
            this.Controls.Add(this.rbLangeSlaap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOpstaan);
            this.Controls.Add(this.btnSlaaptijdBerekenen);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKorteSlaap;
        private System.Windows.Forms.RadioButton rbNormaleSlaap;
        private System.Windows.Forms.RadioButton rbLangeSlaap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOpstaan;
        private System.Windows.Forms.Button btnSlaaptijdBerekenen;
        private System.Windows.Forms.Label lblFoutmelding;
    }
}