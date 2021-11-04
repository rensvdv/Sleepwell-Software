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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void SQLConnect()
        {
            try
            {
                MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.26;port=3306;username=root2;password=123456");
                sqlconnect.Open();
                if (sqlconnect.State == ConnectionState.Open)
                {
                    MessageBox.Show("I CONNECTED TO DATABASE");
                }
                else
                {
                    MessageBox.Show("I WAS UNABLE TO CONNECT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    private void Form1_Load(object sender, EventArgs e)
        {
            //CreateChart();
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

        private void tijd_Tick(object sender, EventArgs e)
        {
            //laat de huidige tijd zien
            lblHuidigeTijd.Text = DateTime.Now.ToString("HH:mm:ss");
        }

 
        private void btnAttemptConnectSQL_Click(object sender, EventArgs e)
        {
            SQLConnect();
        }

        private void btnDoorNaarForm2_Click(object sender, EventArgs e)
        {
            try
            {
                string naam = tbxNaam.Text;
                int leeftijd = Convert.ToInt32(tbxLeeftijd.Text);

                this.Hide();
                Form2 f2 = new Form2(naam, leeftijd);
                f2.ShowDialog();
            }
            catch (Exception es)
            {
                MessageBox.Show("Voer een naam en/of leeftijd in");
            }
        }
    }
}
