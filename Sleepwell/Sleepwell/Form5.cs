using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sleepwell
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void checkvelden()
        {
            if (string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxLeeftijd.Text) || string.IsNullOrEmpty(tbxEmail.Text) || string.IsNullOrEmpty(tbxWachtwoord.Text))
            {
                MessageBox.Show("Graag alle velden geldig invullen");
            }
            else
            {
                Form1 f1 = new Form1();
                this.Close();
                f1.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int leeftijd = Convert.ToInt32(tbxLeeftijd.Text);
                checkvelden();
            }
            catch(Exception)
            {
                MessageBox.Show("Graag een geldige leeftijd invullen!");
            }


        }
    }
}
