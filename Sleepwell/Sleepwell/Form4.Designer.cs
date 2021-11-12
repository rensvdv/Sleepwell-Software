
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRatingSturenNaarDatabase = new System.Windows.Forms.Button();
            this.tbRatingGeven = new System.Windows.Forms.TrackBar();
            this.lblRatingWaarde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 8);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(217, 141);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataTimer
            // 
            this.dataTimer.Interval = 500;
            this.dataTimer.Tick += new System.EventHandler(this.DataTimer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 134);
            this.listBox1.TabIndex = 1;
            // 
            // btnRatingSturenNaarDatabase
            // 
            this.btnRatingSturenNaarDatabase.Location = new System.Drawing.Point(360, 98);
            this.btnRatingSturenNaarDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRatingSturenNaarDatabase.Name = "btnRatingSturenNaarDatabase";
            this.btnRatingSturenNaarDatabase.Size = new System.Drawing.Size(56, 28);
            this.btnRatingSturenNaarDatabase.TabIndex = 2;
            this.btnRatingSturenNaarDatabase.Text = "Verstuur";
            this.btnRatingSturenNaarDatabase.UseVisualStyleBackColor = true;
            this.btnRatingSturenNaarDatabase.Click += new System.EventHandler(this.btnRatingSturenNaarDatabase_Click);
            // 
            // tbRatingGeven
            // 
            this.tbRatingGeven.Location = new System.Drawing.Point(338, 48);
            this.tbRatingGeven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRatingGeven.Maximum = 4;
            this.tbRatingGeven.Name = "tbRatingGeven";
            this.tbRatingGeven.Size = new System.Drawing.Size(116, 45);
            this.tbRatingGeven.TabIndex = 3;
            this.tbRatingGeven.Scroll += new System.EventHandler(this.tbRatingGeven_Scroll);
            // 
            // lblRatingWaarde
            // 
            this.lblRatingWaarde.AutoSize = true;
            this.lblRatingWaarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingWaarde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRatingWaarde.Location = new System.Drawing.Point(398, 10);
            this.lblRatingWaarde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRatingWaarde.Name = "lblRatingWaarde";
            this.lblRatingWaarde.Size = new System.Drawing.Size(19, 20);
            this.lblRatingWaarde.TabIndex = 36;
            this.lblRatingWaarde.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(334, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(414, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "/5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRatingWaarde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRatingGeven);
            this.Controls.Add(this.btnRatingSturenNaarDatabase);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRatingGeven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRatingSturenNaarDatabase;
        private System.Windows.Forms.TrackBar tbRatingGeven;
        private System.Windows.Forms.Label lblRatingWaarde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}