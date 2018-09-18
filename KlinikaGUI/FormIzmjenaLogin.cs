using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemKlinika;

namespace KlinikaGUI
{
    public partial class FormIzmjenaLogin : Form
    {
        Osoba osoba;
        public FormIzmjenaLogin(Osoba osoba)
        {
            InitializeComponent();
            this.osoba = osoba;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private StringBuilder MD(string password)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder test = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                test.Append(hash[i].ToString("X2"));
            }

            return test;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            osoba.Username =this.textBox4.Text;
            osoba.Password = MD(this.textBox3.Text);
            MessageBox.Show("Uspješno promjenjeno.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
