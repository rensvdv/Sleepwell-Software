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
        DateTime StartTime;
        List<int> pulses;
        double AvgBpm;
        int pulseInNumbers;
        int count;
        string pulse;
        SerialPort port;
        public Form4(User currentuser, sleepSession sleepsession, DateTime slaaptijd, DateTime StartTime)
        {
            InitializeComponent();
            this.currentUser = currentuser;
            this.sleepSession = sleepsession;
            this.slaaptijd = slaaptijd;
            this.StartTime = StartTime;
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

            }
            catch (Exception es)
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
            DataVersturen();
            TerugNaarForm2();
            //getRows();
        }

        private double getBPM(double BPM)
        {

            BPM = pulses.Average();
            return BPM;
        }
        private void EndSession()
        {
            DateTime EndTime = DateTime.Now;
            TimeSpan geslapentijd = EndTime - StartTime;
            MessageBox.Show("Geslapen tijd - Uren: " + geslapentijd.Hours.ToString() + " Minuten: " + geslapentijd.Minutes.ToString() + " Seconden: " + geslapentijd.Seconds.ToString());
            dataTimer.Stop();


        }

        private void WakeUpButton_Click(object sender, EventArgs e)
        {

        }

        private void DataVersturen()
        {
            MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.68;port=3306;username=USER1;password=LekkerLekker1!;DATABASE=Sleepwell_database");
            sqlconnect.Open();
            MySqlCommand comm = sqlconnect.CreateCommand();
            comm.CommandText = "INSERT INTO sleepdata(user_id, sleep_duration, average_bpm, rating) VALUES(@user_id, @sleep_duration, @average_bpm, @rating)";
            comm.Parameters.AddWithValue("@user_id", currentUser.Id);
            comm.Parameters.AddWithValue("@sleep_duration", sleepSession.Sleep_duration);
            comm.Parameters.AddWithValue("@average_bpm", sleepSession.Avg_BPM);
            comm.Parameters.AddWithValue("@rating", rating);
            comm.ExecuteNonQuery();
            sqlconnect.Close();
            MessageBox.Show("Account aangemaakt");
        }

        private void getRows()
        {
            MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.68;port=3306;username=USER1;password=LekkerLekker1!;DATABASE=Sleepwell_database");
            sqlconnect.Open();
            MessageBox.Show("Test1");
            MySqlCommand cmd = sqlconnect.CreateCommand();
            MessageBox.Show("Test2");
            cmd.CommandText = "SELECT COUNT(*) FROM sleepdata WHERE user_id = " + sleepSession.User_id + "";
            MessageBox.Show("Test3");
            count = int.Parse(cmd.ExecuteScalar().ToString());
            MessageBox.Show(count.ToString());


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }


        private void TerugNaarForm2()
        {
            Form2 f2 = new Form2(currentUser);
            f2.Show();
            this.Close();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            EndSession();
            gbRating.Visible = true;
        }
    }
}
