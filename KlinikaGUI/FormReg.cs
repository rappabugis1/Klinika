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
    public partial class FormReg : Form
    {
        internal Klinika klinika;

        public FormReg(Klinika klinika)
        {
            InitializeComponent();
            this.klinika = klinika;
        }

        private void pocisti()
        {
            radioMusk.Checked = false;
            radioZensk.Checked = false;
            textIme.Text = "";
            textPrez.Text = "";
            textUser.Text = "";
            textJMBG.Text = "";
            textPass.Text = "";
            textPassRe.Text = "";
            radioDok.Checked = false;
            radioOsob.Checked = false;
            dateRodj.Value = DateTime.Now;

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

        private void button3_Click(object sender, EventArgs e)
        {
            if ( radioDok.Checked || radioOsob.Checked)
            {
                string spol="Musko";
                if (!radioMusk.Checked)
                    spol="Zensko";

                if (radioDok.Checked)
                {
                    klinika.Osoblje.Add(new OsRadDok(textIme.Text, textPrez.Text, spol, textJMBG.Text, textAdresa.Text, dateRodj.Value, textUser.Text, MD(textPass.Text), "Doktor", 1000));

                }

                if (radioOsob.Checked)
                {
                    klinika.Osoblje.Add(new OsRadMedTeh( textIme.Text, textPrez.Text, spol, textJMBG.Text, textAdresa.Text, dateRodj.Value, textUser.Text, MD(textPass.Text), "tehnicar", 100, false));
                }

                MessageBox.Show("Uspješno unesen korisnik.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                errorLabel.Text="Nije izabrana uloga!";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pocisti();
            MessageBox.Show("Vasi upisi su obrisani!","Informacija", MessageBoxButtons.OK);
        }

        private bool validacijaJMBG(string text, out string error)
        {
            if (text.Length != 13)
            {
                error = "Duzina JMBG-a nije validna!";
                return false;
            }

            error = "";
            return true;
        }

        private void textJMBG_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!validacijaJMBG(this.textJMBG.Text, out errorMsg))
            {
                e.Cancel = true;
                this.textJMBG.Select(0, textJMBG.Text.Length);
                this.labelError.Text = errorMsg;
            }
        }

        private void textPass_Validating(object sender, CancelEventArgs e)
        {
            if(textPass.Text!=textPassRe.Text)
            {
                this.textPass.Select(0, textPass.Text.Length);
                this.textPassRe.Select(0, textPassRe.Text.Length);
                this.labelError.Text = "Lozinke se ne podudaraju!";
            }
        }

        private void errorValidated(object sender, EventArgs e)
        {
            this.labelError.Text = "";
        }

        private bool userValid(string text)
        {
            foreach (dynamic p in klinika.Osoblje)
                if (p.Username == this.textUser.Text)
                {
                    return false;
                }
            foreach (Pacijent osoba in this.klinika.Pacijenti)
                if (text == osoba.Username)
                {
                    return false;
                }
            return true;
        }

        private void textUser_Validating(object sender, CancelEventArgs e)
        {
            if (!userValid(this.textUser.Text))
            {
                e.Cancel = true;
                this.labelError.Text = "Username je u upotrebi!";
            }
        }

    }
}
