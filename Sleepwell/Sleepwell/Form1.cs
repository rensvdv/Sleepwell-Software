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
            //CreateChart();
            
        }

        private void btnSlaaptijdBerekenen_Click(object sender, EventArgs e)
        {
            //controleren of de textboxes leeg zijn
            //zoja dan voert de code niet verder uit
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
            lblHuidigeTijd.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
