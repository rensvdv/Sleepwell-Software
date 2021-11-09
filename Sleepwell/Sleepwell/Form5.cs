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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string naam;
        string email;
        string wachtwoord;
        int leeftijd;

        private void VoerQueryUit(string naam, string email, string wachtwoord, int leeftijd)
        {
            MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.68;port=3306;username=USER1;password=LekkerLekker1!;DATABASE=Sleepwell_database");
            sqlconnect.Open();
            MySqlCommand comm = sqlconnect.CreateCommand();
            comm.CommandText = "INSERT INTO users(name, email, password, age) VALUES(@name, @email, @password, @age)";
            comm.Parameters.AddWithValue("@name", naam);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@password", wachtwoord);
            comm.Parameters.AddWithValue("@age", leeftijd);
            comm.ExecuteNonQuery();
            sqlconnect.Close();
            MessageBox.Show("Account aangemaakt");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                naam = tbxNaam.Text;
                email = tbxEmail.Text;
                wachtwoord = tbxWachtwoord.Text;
                leeftijd = Convert.ToInt32(tbxLeeftijd.Text);
                
                VoerQueryUit(naam, email, wachtwoord, leeftijd);

        }
        
        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTerugNaarInloggen_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }
    }
}
