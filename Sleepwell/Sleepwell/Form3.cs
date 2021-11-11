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
        
        sleepSession sleepSession; // zo roep je de class aan
        User CurrentUser;
        DateTime SlaapTijd;
        bool Mailsent = false;

        public Form3(User currentuser, sleepSession sleepsession, DateTime slaaptijd)
        {
            InitializeComponent();
            this.CurrentUser = currentuser;
            this.sleepSession = sleepsession;
            this.SlaapTijd = slaaptijd;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "Naam: " + CurrentUser.Name + "\n" +
                "Leeftijd: " + CurrentUser.Age + "\n" +
                "Slaaptijd: " + SlaapTijd.ToString("HH:mm:ss");
        }

        private void MailVersturen()
        {
            try
            {
                //email aanmaken
                SmtpMail reminder = new SmtpMail("TryIt");

                //afzender en ontvanger kiezen
                reminder.From = "sleepwellfontys@gmail.com";
                reminder.To = "robboorsma@gmail.com";

                //inhoud van de email toevoegen
                reminder.Subject = "Reminder";
                reminder.TextBody = "Hallo! " + CurrentUser.Name + " Over een uur is het door ons geadviseerde slaaptijd: " + SlaapTijd.ToString("HH:mm:ss") + " Wij raden aan om de blauwlicht filter op uw telefoon in te schakelen! Probeer eventueel ook alvast uw telefoon minder te gebruiken."; 

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
        private TimeSpan Berekentijd()
        {
            DateTime starttijd = DateTime.Now;
            DateTime eindtijd = SlaapTijd;
            TimeSpan interval = eindtijd - starttijd;
            if(Convert.ToInt32(interval.TotalHours) <0)
            {
                interval += TimeSpan.FromDays(+1);
            }
            interval -= TimeSpan.FromHours(1);
            return interval;
        }


        //int om af te tellen voor de reminder
        //int timer = 10;
        private void tijd_Tick(object sender, EventArgs e)
        {
            TimeSpan interval = Berekentijd();
            
            //laat de huidige tijd zien
            lblHuidigeTijd.Text = DateTime.Now.ToString("HH:mm:ss");

            //waarde timer in de reminder label zetten
            lbTimer.Text = "U wordt herrinerd over: " + interval.Hours.ToString() + " Uur " + interval.Minutes.ToString() + " Minuten " + interval.Seconds.ToString() + " Seconden";
            if(Mailsent == false && interval.TotalHours < 0) 
            // Total hours = Hours.MinutesSeconds Displayed als: 0.2580284, dit wordt dus pas geactiveerd als hele timer klaar is
            {
                Mailsent = true;
                lbTimer.Hide();
                MailVersturen();
            }

           
        }

        private void btnNaarForm4_Click(object sender, EventArgs e)
        {
            tijd.Enabled = false;
            this.Hide();
            Form4 f4 = new Form4(CurrentUser, sleepSession, SlaapTijd);
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(CurrentUser);
            f2.Show();
                this.Close();
        }

        private void bStartDemo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Demo Mode started.. Reminder will be send immediately!");
            MailVersturen();

        }
    }
}
