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
        User currentUser;
        sleepSession sleepSession;
        bool isConnected = false;
        DateTime slaaptijd;
        List<int> pulses;
        double AvgBpm;
        int pulseInNumbers;
        string pulse;
        SerialPort port;
        public Form4(User currentuser, sleepSession sleepsession, DateTime slaaptijd)
        {
            InitializeComponent();
           
            this.slaaptijd = slaaptijd;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ConnectToArduino();
            pulses = new List<int>();

            if (isConnected)
            {
                dataTimer.Start();
            }
        }

        private void ConnectToArduino()
        {
            isConnected = true;
            string selectedPort = "COM5";
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
            
            if (data != "")
            {
               // string cleanedData = data.Replace("\n", "").Replace("\r", "");

                pulseInNumbers = int.Parse(data);
                pulses.Add(pulseInNumbers);
                //MessageBox.Show(data);
                listBox1.Items.Add(data);
                if (data.Contains("\n"))
                {
                    
                }


                //if (pulseInNumbers > 150)
                //{

                //}
                //else
                //{
                //    //data = pulseInNumbers.ToString();
                  


                //}
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

        int rating = 1;
        private void tbRatingGeven_Scroll(object sender, EventArgs e)
        {
            //rating moet + 1 omdat value van de trackbar op 0 begint
            rating = tbRatingGeven.Value + 1;
            lblRatingWaarde.Text = rating.ToString();
        }

        private void btnRatingSturenNaarDatabase_Click(object sender, EventArgs e)
        {
           AvgBpm = getBPM(AvgBpm);
            MessageBox.Show(AvgBpm.ToString());
        }

        private double getBPM(double BPM)
        {

            BPM = pulses.Average();
            return BPM;
        }
        private void EndSession()
        {
            dataTimer.Stop();


        }

        private void WakeUpButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
