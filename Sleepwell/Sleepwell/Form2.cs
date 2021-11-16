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
    public partial class Form2 : Form
    {
        string naam;
        double sleep_duration;
        int leeftijd;
        User CurrentUser;
        sleepSession sleepSession;
        DateTime opstaTijd;
        DateTime slaaptijd;
        DateTime date;
        public Form2(User currentUser)
        {
            InitializeComponent();
            this.CurrentUser = currentUser;
            
        }
        private void btnSlaaptijdBerekenen_Click(object sender, EventArgs e)
        {
            try
            {
                 opstaTijd = DateTime.Parse(tbxOpstaan.Text);
                 slaaptijd = SlaaptijdBerekenen(opstaTijd);
                sleepSession = new sleepSession(CurrentUser.Id, sleep_duration, 0, date ); // als de class word aangeroepen geef je de bepaalde variabelen die nodig zijn.
                Form3 f3 = new Form3(CurrentUser, sleepSession, slaaptijd);
                f3.Show();
                this.Close();
            }
            catch(Exception)
            {
                lblFoutmelding.Text = "Voer een geldige tijd in";
                lblFoutmelding.ForeColor = Color.Red;
                lblFoutmelding.Visible = true;
            }
        }

        private DateTime SlaaptijdBerekenen(DateTime opstaTijd)
        {
            //deze methode werkt met 3 radiobuttons: korte, lange en normale slaap
            DateTime slaaptijd = new DateTime();
            if (rbKorteSlaap.Checked)
            {
                //optimale korte slaap is 6uur, 4 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-6);
                sleep_duration = 6;
            }
            else if (rbLangeSlaap.Checked)
            {
                //optimale lange slaap is 9uur, 6 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-9);
                sleep_duration = 9;
            }
            else
            {
                //optimale normale slaap is 7,5uur, 5 slaap cyclussen
                slaaptijd = opstaTijd.AddHours(-7.5);
                sleep_duration = 7.5;
            }

            return slaaptijd;           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //placeholder textbox tekst inladen
            tbxOpstaan.Text = "bijvoorbeeld 8:00";
            tbxOpstaan.ForeColor = Color.Gray;
        }

        private void tbxOpstaan_Leave(object sender, EventArgs e)
        {
            placeholderTextBox();
        }

        private void tbxOpstaan_Enter(object sender, EventArgs e)
        {
            placeholderTextBox();
            
        }
        private void placeholderTextBox()
        {
            //als de gebruiker niks invoert en weer uit de textbox gaat, komt de tekst terug
            if (tbxOpstaan.Text == "")
            {
                tbxOpstaan.Text = "bijvoorbeeld 8:00";
                tbxOpstaan.ForeColor = Color.Gray;
            }

            //als de gebruiker op de textbox klikt gaat de placeholder tekst weg
            if (tbxOpstaan.Text == "bijvoorbeeld 8:00")
            {
                tbxOpstaan.ForeColor = Color.Black;
                tbxOpstaan.Text = "";
            }
        }
    }
}
