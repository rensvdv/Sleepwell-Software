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
using System.IO.Ports;

namespace Sleepwell
{
    public partial class Form4 : Form
    {
        string naam;
        int leeftijd;
        string slaaptijd;
        bool isConnected = false;

        int pulseInNumbers;
        string pulse;
        SerialPort port;
        public Form4(string naam, int leeftijd, string slaaptijd)
        {
            InitializeComponent();
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.slaaptijd = slaaptijd;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ConnectToArduino();

            if (isConnected)
            {
                dataTimer.Start();
            }
        }

        private void ConnectToArduino()
        {
            isConnected = true;
            string selectedPort = "COM6";
            try
            {
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
            }catch(Exception es)
            {
                MessageBox.Show("Failed to connect");
            }
            

        }

        public string GetData(string data)
        {
            //all commands to the port consist of # command and \n
            // a command has 4 letters
            port.Write("#DATA\n");
            data = port.ReadExisting();
            if(data != "")
            {
               
                if (data.Contains("\n"))
                {
                    string cleanedData = data.Replace("\n", "").Replace("\r", "");
                    pulseInNumbers = int.Parse(data);
                }


                if (pulseInNumbers > 150)
                {

                }
                else
                {
                    data = pulseInNumbers.ToString();
                    listBox1.Items.Add(data);
                }

            }
            else
            {
               
            }




            return data;

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

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            GetData(pulse);
            
            
            
        }
    }
}
