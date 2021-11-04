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
        //int om af te tellen voor de reminder
        int timer = 10;

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
            //placeholder textbox tekst inladen
            tbxOpstaan.Text = "bijvoorbeeld 8:00";
            tbxOpstaan.ForeColor = Color.Gray;
            //CreateChart();

        }

        private void btnSlaaptijdBerekenen_Click(object sender, EventArgs e)
        {
            //controleren of de textboxes leeg zijn
            //zoja dan voert de rest van de code in de button click niet uit
            if (String.IsNullOrEmpty(tbxNaam.Text))
            {
                MessageBox.Show("Voer een naam in");
                return;
            }
            else if (String.IsNullOrEmpty(tbxLeeftijd.Text))
            {
                MessageBox.Show("Voer een leeftijd in");
                return;
            }
            else if (String.IsNullOrEmpty(tbxOpstaan.Text))
            {
                MessageBox.Show("Voer een tijd in");
                return;
            }

            string naam = tbxNaam.Text;
            string leeftijd = tbxLeeftijd.Text;
            DateTime opstaTijd = DateTime.Parse(tbxOpstaan.Text);

            //Hiermee laat je alle info zien van de gebruiker in een label
            //.ToShortTimeString haalt de datum uit de DateTime.
            lblTijdAanraden.Text = "Naam: " + naam + "\n" +
                "Leeftijd: " + leeftijd.ToString() + "\n" +
                  "Voor de optimale slaap moet u om " + "\n" +
                  SlaaptijdBerekenen(opstaTijd).ToShortTimeString() + " gaan slapen";
            lblTijdAanraden.Visible = true;
        }

        private DateTime SlaaptijdBerekenen(DateTime opstaTijd)
        {
            //deze methode werkt met 3 radiobuttons: korte, lange en normale slaap
            DateTime slaaptijd = new DateTime();
            if (rbKorteSlaap.Checked)
            {
                //optimale korte slaap is 6uur, 4 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-6);
            }
            else if (rbLangeSlaap.Checked)
            {
                //optimale lange slaap is 9uur, 6 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-9);
            }
            else
            {
                //optimale normale slaap is 7,5uur, 5 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-7.5);
            }

            return slaaptijd;
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

            //waarde timer in de reminder label zetten
            lblReminder.Text = timer.ToString();

            //timer waarde verlagen
            timer -= 1;

            //als timer 0 is mail versturen
            //daarna het label onzichtbaar maken
            if (timer == 0)
            {
                MailVersturen();
            }
            if (timer <= 0)
            {
                lblReminder.Visible = false;
            }
        }

        private void tbxOpstaan_Enter(object sender, EventArgs e)
        {
            //als de gebruiker op de textbox klikt gaat de placeholder tekst weg
            if (tbxOpstaan.Text == "bijvoorbeeld 8:00")
            {
                tbxOpstaan.ForeColor = Color.Black;
                tbxOpstaan.Text = "";
            }
        } 

        private void tbxOpstaan_Leave(object sender, EventArgs e)
        {
            //als de gebruiker niks invoert en weer uit de textbox gaat, komt de tekst terug
            if (tbxOpstaan.Text == "")
            {
                tbxOpstaan.Text = "bijvoorbeeld 8:00";
                tbxOpstaan.ForeColor = Color.Gray;
            }
        }

        private void MailVersturen()
        {
            try
            {
                //email aanmaken
                SmtpMail reminder = new SmtpMail("TryIt");

                //afzender en ontvanger kiezen
                reminder.From = "sleepwellfontys@gmail.com";
                reminder.To = "rensvelden@gmail.com";

                //inhoud van de email toevoegen
                reminder.Subject = "Reminder";
                reminder.TextBody = "Over 1u is uw slaaptijd";

                //gmail smtp server 
                SmtpServer server = new SmtpServer("smtp.gmail.com");

                //gebruiker moet zichzelf verifieren
                server.User = "sleepwellfontys@gmail.com";
                server.Password = "LekkerLekker";

                //port instellen
                server.Port = 465;

                //SSL/TLS detecteren en connecten
                server.ConnectType = SmtpConnectType.ConnectSSLAuto;

                //client aanmaken
                SmtpClient client = new SmtpClient();

                //email verzenden
                client.SendMail(server, reminder);
                MessageBox.Show("Email is verzonden");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnAttemptConnectSQL_Click(object sender, EventArgs e)
        {
            SQLConnect();
        }

        private void btnStuurReminder_Click(object sender, EventArgs e)
        {
            MailVersturen();
        }
    }
}
