using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public User CurrentUser;
        public Form1()
        {
            InitializeComponent();
            
        }
        
    private void Form1_Load(object sender, EventArgs e)
        {

        }
     



        private void tijd_Tick(object sender, EventArgs e)
        {
            //laat de huidige tijd zien
            lblHuidigeTijd.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void btnDoorNaarForm2_Click(object sender, EventArgs e)
        {
            string password = tbxWW.Text;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256Hash.ComputeHash(passwordBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                password = hash;
            }
                MySqlConnection sqlconnect = new MySqlConnection("SERVER=192.168.52.68;port=3306;username=USER1;password=LekkerLekker1!;DATABASE=Sleepwell_database");
            sqlconnect.Open();
            int id = 0;
            string email = tbxEmail.Text;
            string name = "";
            int leeftijd = 0;
            string query = "SELECT * FROM users WHERE email ='" + email + "' AND password ='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(query, sqlconnect);
            MySqlDataReader usersRow = cmd.ExecuteReader();
            if(usersRow.HasRows)
            {
                CurrentUser = new User(id, name, email, leeftijd);
                while (usersRow.Read())
                {
                    id = int.Parse(usersRow["id"].ToString());
                    CurrentUser.Id = id;
                    CurrentUser.Email = usersRow["email"].ToString();
                    password = usersRow["password"].ToString();
                    CurrentUser.Age = Convert.ToInt32(usersRow["age"]);
                    CurrentUser.Name = usersRow["name"].ToString();

                }
                MessageBox.Show("Welkom terug " + CurrentUser.Name);
                Form2 f2 = new Form2(CurrentUser);
                f2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Uw email en/of wachtwoord zijn onjuist!");
            }
            sqlconnect.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void Hide_Show_Login_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide_Show_Login.Checked)
            {
                tbxWW.UseSystemPasswordChar = false;
            }
            else
            {
                tbxWW.UseSystemPasswordChar = true;
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxEmail.Text = "ROB";
            tbxWW.Text = "ROB";
            btnDoorNaarForm2_Click(sender, e);
        }
    }

}





