using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sleepwell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateChart();   //
            
        }

        /*
        private void CreateChart()
        { 
            //voor deze methode moet er een chart element toegevoegd worden met de naam chrtHeartBeat
            var series = new Series("Heartbeat");
            //chart type veranderen naar lijn
            series.ChartType = SeriesChartType.Line;
            //de lijn zelf toevoegen
            series.Points.DataBindXY(new[] { 1.00, 2.00, 3.400, 4.00 }, new[] { 50, 56, 45, 60 });
            chrtHeartbeat.Series.Add(series);
            
        }
            */
    }
}
