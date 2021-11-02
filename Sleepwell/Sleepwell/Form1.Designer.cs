
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtHeartbeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHeartbeat)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtHeartbeat
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtHeartbeat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtHeartbeat.Legends.Add(legend1);
            this.chrtHeartbeat.Location = new System.Drawing.Point(12, 12);
            this.chrtHeartbeat.Name = "chrtHeartbeat";
            this.chrtHeartbeat.Size = new System.Drawing.Size(442, 295);
            this.chrtHeartbeat.TabIndex = 0;
            this.chrtHeartbeat.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chrtHeartbeat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtHeartbeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHeartbeat;
    }
}

