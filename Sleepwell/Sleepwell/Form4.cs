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
using EASendMail;
using MySql.Data.MySqlClient;

namespace Sleepwell
{
    public partial class Form4 : Form
    {
        string naam;
        int leeftijd;
        string slaaptijd;
        public Form4(string naam, int leeftijd, string slaaptijd)
        {
            InitializeComponent();
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.slaaptijd = slaaptijd;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void CreateChart()
        {
            //voor deze methode moet er een chart element toegevoegd worden met de naam chrtHeartBeat
            var series = new Series("Heartbeat");
            //chart type veranderen naar lijn
            series.ChartType = SeriesChartType.Line;
            //de lijn zelf toevoegen

            series.Points.DataBindXY(new[] { 1.00, 2.00, 3.400, 4.00 }, new[] { 50, 56, 45, 60 });
            //chrtHeartbeat.Series.Add(series);

        }
    }
}
