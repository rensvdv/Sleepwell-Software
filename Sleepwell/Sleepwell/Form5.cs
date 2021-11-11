using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
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
            string ww = tbxWachtwoord.Text;
            using (SHA256 sha1Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(ww);
                byte[] hashBytes = sha1Hash.ComputeHash(passwordBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                ww = hash;
            }
            MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.68;port=3306;username=USER1;password=LekkerLekker1!;DATABASE=Sleepwell_database");
            sqlconnect.Open();
            MySqlCommand comm = sqlconnect.CreateCommand();
            comm.CommandText = "INSERT INTO users(name, email, password, age) VALUES(@name, @email, @password, @age)";
            comm.Parameters.AddWithValue("@name", naam);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@password", ww);
            comm.Parameters.AddWithValue("@age", leeftijd);
            comm.ExecuteNonQuery();
            sqlconnect.Close();
            MessageBox.Show("Account aangemaakt");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbxBevestigWW.Text != tbxWachtwoord.Text)
            {
                MessageBox.Show("Uw wachtwoorden zijn niet gelijk aan elkaar Wachtwoorden zijn"); 
            }
            else if(tbxBevestigWW.Text == tbxWachtwoord.Text)
            { 
                naam = tbxNaam.Text;
                email = tbxEmail.Text;
                wachtwoord = tbxWachtwoord.Text;
                leeftijd = Convert.ToInt32(tbxLeeftijd.Text);

                VoerQueryUit(naam, email, wachtwoord, leeftijd);
            }

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

        private void tbxWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hide_Show_Register_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide_Show_Register.Checked)
            {
                tbxWachtwoord.UseSystemPasswordChar = false;
            }
            else
            {
                tbxWachtwoord.UseSystemPasswordChar = true;
            }
    }

        private void cbBevestig_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBevestig.Checked)
            {
                tbxBevestigWW.UseSystemPasswordChar = false;
            }
            else
            {
                tbxBevestigWW.UseSystemPasswordChar = true;
            }
        }
    }
}
