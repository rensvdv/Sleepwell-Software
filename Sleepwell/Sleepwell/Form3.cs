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
    public partial class Form3 : Form
    {
        string naam;
        int leeftijd;
        string slaaptijd;
        public Form3(string naam, int leeftijd, string slaaptijd)
        {
            InitializeComponent();
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.slaaptijd = slaaptijd;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblInformatie.Text = "Naam: " + naam + "\n" +
                "Leeftijd: " + leeftijd + "\n" +
                "Slaaptijd: " + slaaptijd;
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


        //int om af te tellen voor de reminder
        int timer = 10;
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

        private void btnNaarForm4_Click(object sender, EventArgs e)
        {
            tijd.Enabled = false;
        }
    }
}
