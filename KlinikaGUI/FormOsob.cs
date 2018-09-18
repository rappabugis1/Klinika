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
using Raspored;

namespace KlinikaGUI
{
    public partial class FormOsob : Form
    {
        internal Klinika klinika;
        Pacijent pacPret, pacTermin;
        OsRadMedTeh osob;
        public FormOsob(Klinika klinika, OsRadMedTeh osoblje)
        {
            InitializeComponent();
            osob = osoblje;
            this.label13.Text = osoblje.Ime;
            this.label14.Text = osoblje.Prezime;
            this.label15.Text = osoblje.Jmbg;
            this.label16.Text = osoblje.Adresa;
            this.label17.Text = Convert.ToString(osoblje.DatumRodjenja);
            this.label18.Text = osoblje.Spol;
            this.klinika = klinika;
            this.tabOpcije.SelectedIndexChanged += tabOpcije_SelectedIndexChanged;
            this.listBoxPretraga.SelectedIndexChanged += prikaziIzabrano;

            foreach (dynamic sala in klinika.Sale)
                if (sala is SaleSpec)
                    listBox1.Items.Add((SaleSpec)sala);
                else
                    listBox1.Items.Add(sala);
            listBox1.DisplayMember = "Naziv";
        }

        private void prikaziIzabranuSalu(Object sender, EventArgs e)
        {
            PrikaziTermin();
        }

        private void PrikaziTermin()
        {
            listBox2.Items.Clear();
            foreach (RTermin termin in ((Sale)listBox1.SelectedItem).Termini.Tabela)
                listBox2.Items.Add(termin);
            listBox2.DisplayMember = "Ime";
            groupZakazi.Enabled = true;
            if (listBox2.Items.Count == 0)
            {
                groupZakazi.Enabled = false;
                listBox2.Items.Add("Sala je prazna");
            }
            try
            {
                label1.Text = ((Sale)listBox1.SelectedItem).Termini.Tabela.ElementAt(0).SifraKartona;
                label2.Text = ((Sale)listBox1.SelectedItem).Termini.Tabela.ElementAt(0).Ime;
                label20.Text = Convert.ToString(((Sale)listBox1.SelectedItem).Termini.Tabela.ElementAt(0).Broj);
                label21.Text = ((Sale)listBox1.SelectedItem).Termini.Tabela.ElementAt(0).Svrha;

                foreach (Pacijent p in klinika.Pacijenti)
                    if (((Sale)listBox1.SelectedItem).Termini.Tabela.ElementAt(0).SifraKartona == p.Karton.Sifra)
                        pacTermin = p;
            }
            catch (Exception)
            {
                label1.Text = "";
                label2.Text = "";
                label20.Text = "";
                label21.Text = "";
            }
        }

        private void prikaziIzabrano(Object sender, EventArgs e)
        {
            pacPret = (Pacijent)this.listBoxPretraga.SelectedItem;
        }

        private void tabOpcije_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (this.tabOpcije.SelectedIndex == 1)
            {
                this.Size = new Size(470, 368);
                this.tabOpcije.Size = new Size(288, 294);
            }
            if (this.tabOpcije.SelectedIndex == 0)
            {
                this.Size = new Size(694, 368);
                this.tabOpcije.Size = new Size(509, 294);
            }
            
        }

        private void registrujPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegPac forma = new FormRegPac(klinika);
            forma.Show();
        }

        private void textBoxImePretraga_TextChanged(object sender, EventArgs e)
        {
            listBoxPretraga.Items.Clear();
            listBoxPretraga.DisplayMember = "ImeiPrezime1";

            foreach (Pacijent k in klinika.Pacijenti)
                if ((k.Ime + " " + k.Prezime).Contains(textBoxImePretraga.Text))
                    listBoxPretraga.Items.Add(k);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pacPret != null)
            {
                if (pacPret.Karton != null)
                {
                    FormKarton forma = new FormKarton(pacPret.Karton);
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Karton datog pacijenta nije uspostavljen!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pacPret != null)
            {
                if (pacPret.Karton == null)
                {
                    FormRegKarton forma = new FormRegKarton(pacPret);
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Karton datog pacijenta je vec uspostavljen!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izmjenaLoginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzmjenaLogin forma = new FormIzmjenaLogin((Osoba)osob);
            forma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pacPret != null)
            {
                FormZTermin form = new FormZTermin(klinika, pacPret);
                form.Show();
            }
            else
            {
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZTermin form = new FormZTermin(klinika, pacTermin);
            form.Show();
        }
    }
}
