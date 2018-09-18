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
    public partial class FormRegPac : Form
    {
        internal Klinika klinika;

        public FormRegPac(Klinika klinika)
        {
            InitializeComponent();
            this.klinika = klinika;
            unosSlike1.tekst = labelError.Text;
            unosSlike1.label1.TextChanged += promjena;
        }

        private void promjena(Object sender, EventArgs e)
        {
            labelError.Text = unosSlike1.tekst;
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
            unosSlike1.slika = null;
            dateRodj.Value = DateTime.Now;
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
            if (!validacijaJMBG(this.textJMBG.Text, out errorMsg))
            {
                e.Cancel = true;
                this.textJMBG.Select(0, textJMBG.Text.Length);
                this.labelError.Text = errorMsg;
            }
        }

        private void textPass_Validating(object sender, CancelEventArgs e)
        {
            if (textPass.Text != textPassRe.Text)
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

        private void Unesi_Click(object sender, EventArgs e)
        {
            if (unosSlike1.slika!= null )
            {
                if (textPass.Text == textPassRe.Text)
                {
                    string spol = "Musko";
                    if (!radioMusk.Checked)
                        spol = "Zensko";

                    klinika.Pacijenti.Add(new Pacijent(true, textIme.Text, textPrez.Text, spol, textJMBG.Text, textAdresa.Text, dateRodj.Value, textUser.Text, MD(textPass.Text), unosSlike1.slika));

                    MessageBox.Show("Uspješno unesen korisnik.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    this.labelError.Text = "Passwordi nisu isti!";
                }
            }
            else
            {
                this.labelError.Text = "Potrebno je unijeti sliku!";
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            pocisti();
            MessageBox.Show("Vasi upisi su obrisani!", "Informacija", MessageBoxButtons.OK);
        }

    }
}
