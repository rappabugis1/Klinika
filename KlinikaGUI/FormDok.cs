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
    public partial class FormDok : Form
    {
        internal Klinika klinika;
        Pacijent pacPret, pacTermin;
        OsRadDok doktor;
        bool pregled = false;

        public FormDok(Klinika klinika, OsRadDok doktor)
        {
            InitializeComponent();
            this.doktor = doktor;
            this.label13.Text = doktor.Ime;
            this.label14.Text = doktor.Prezime;
            this.label15.Text = doktor.Jmbg;
            this.label16.Text = doktor.Adresa;
            this.label17.Text = Convert.ToString(doktor.DatumRodjenja);
            this.label18.Text = doktor.Spol;
            this.label23.Text = Convert.ToString(doktor.BrPreg);
            this.klinika = klinika;
            this.tabOpcije.SelectedIndexChanged += tabOpcije_SelectedIndexChanged;
            this.listBoxPretraga.SelectedIndexChanged += prikaziIzabrano;
            this.listBox1.SelectedIndexChanged += prikaziIzabranuSalu;

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
                this.Size = new Size(470, 415);
                this.tabOpcije.Size = new Size(288, 338);
            }
            if (this.tabOpcije.SelectedIndex == 0)
            {
                this.Size = new Size(708, 415);
                this.tabOpcije.Size = new Size(522, 338);
            }
            
        }

        private void textBoxImePretraga_TextChanged(object sender, EventArgs e)
        {
            listBoxPretraga.Items.Clear();
            listBoxPretraga.DisplayMember = "ImeiPrezime1";

            foreach (Pacijent k in klinika.Pacijenti)
                if ((k.Ime + " " + k.Prezime).Contains(textBoxImePretraga.Text))
                    listBoxPretraga.Items.Add(k);
        }

        private void registrujPacijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegPac forma = new FormRegPac(klinika);
            forma.Show();
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
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butzakazi_Click(object sender, EventArgs e)
        {
            FormUpisiPregled form = new FormUpisiPregled(pacTermin);
            form.Show();
            pregled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pacTermin != null)
            {
                if (pacTermin.Karton != null)
                {
                    FormKarton forma = new FormKarton(pacTermin.Karton);
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Karton datog pacijenta nije uspostavljen!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Termin je prazan!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butsljedeci_Click(object sender, EventArgs e)
        {
            if (pregled)
            {
                pacTermin.Racun.Usluge.Add(new Racun.Usluga(((Sale)listBox1.SelectedItem).Naziv, ((Sale)listBox1.SelectedItem).CijenaUsluge));
                pacTermin.Racun.Suma += ((Sale)listBox1.SelectedItem).CijenaUsluge;

                ((Sale)listBox1.SelectedItem).Termini.Tabela.RemoveAt(0);
                PrikaziTermin();
                doktor.BrPreg++;
                this.label23.Text = Convert.ToString(doktor.BrPreg);
                pregled = false;
            }
            else
            {
                MessageBox.Show("Nije izvrsen pregled!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormZTermin form = new FormZTermin(klinika,pacTermin);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pacPret != null) {
                if (pacPret.Karton != null)
                {
                    FormZTermin form = new FormZTermin(klinika, pacPret);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Pacijent nema kartona!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nije izabran pacijent!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void izmjenaLoginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzmjenaLogin forma = new FormIzmjenaLogin((Osoba)doktor);
            forma.Show();
        }
    }
}
