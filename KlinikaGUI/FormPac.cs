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
    public partial class FormPac : Form
    {
        Pacijent pacijent;

        public FormPac(Klinika klinika, Pacijent pacijent)
        {
            InitializeComponent();
            this.pacijent = pacijent;
            this.label13.Text = pacijent.Ime;
            this.label14.Text = pacijent.Prezime;
            this.label15.Text = pacijent.Jmbg;
            this.label16.Text = pacijent.Adresa;
            this.label17.Text = Convert.ToString(pacijent.DatumRodjenja);
            this.label18.Text = pacijent.Spol;
            this.pictureBox1.Image = pacijent.Slika;
            listBox1.SelectedIndexChanged += promjenaTermina;
            listBox2.SelectedIndexChanged += promjenaUsluge;
            listBox3.SelectedIndexChanged += prikaziIzabranuSalu;

            foreach (Sale sala in klinika.Sale)
                    listBox3.Items.Add(sala);
            listBox3.DisplayMember = "Naziv";

            foreach (RTermin termin in pacijent.Raspored.Tabela)
                listBox1.Items.Add(termin);
            listBox1.DisplayMember = "Naziv";
            if (listBox1.Items.Count == 0)
            {
                listBox1.Enabled = false;
                listBox1.Items.Add("Nema termina");
            }

            foreach (Racun.Usluga usluga in pacijent.Racun.Usluge)
                listBox2.Items.Add(usluga);
            listBox2.DisplayMember = "Naziv";
            if (listBox2.Items.Count == 0)
            {
                listBox2.Items.Add("Nema koristenih usluga");
                listBox2.Enabled = false;

            }

            label21.Text = pacijent.Racun.Suma + " KM";

        }

        private void prikaziIzabranuSalu(Object sender, EventArgs e)
        {
            label23.Text = ((Sale)listBox3.SelectedItem).Naziv;
            label22.Text = Convert.ToString(((Sale)listBox3.SelectedItem).CijenaUsluge) + " KM";
            label27.Text = Convert.ToString(((Sale)listBox3.SelectedItem).Termini.Tabela.Count()) + " pacijenata na listi cekanja.";
        }


        private void promjenaUsluge(Object sender, EventArgs e)
        {
            label9.Text = ((Racun.Usluga)listBox2.SelectedItem).Naziv;
            label19.Text = Convert.ToString(((Racun.Usluga)listBox2.SelectedItem).Cijena) + " KM";
        }

        private void promjenaTermina(Object sender, EventArgs e)
        {
            label4.Text = ((RTermin)listBox1.SelectedItem).Svrha;
            label3.Text = ((RTermin)listBox1.SelectedItem).Ime;
            label2.Text = Convert.ToString(((RTermin)listBox1.SelectedItem).Broj);
            label5.Text = ((RTermin)listBox1.SelectedItem).SifraKartona;
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku: ";
                dlg.Filter = "jpg files (*.jpg)|*jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = new Bitmap(dlg.FileName);
            }
        }

        private void kartonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pacijent.Karton != null)
            {
                FormKarton forma = new FormKarton(pacijent.Karton);
                forma.Show();
            }
            else
                MessageBox.Show("Nije vam napravljen karton");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izmjenaLoginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzmjenaLogin forma = new FormIzmjenaLogin((Osoba)pacijent);
            forma.Show();
        }

    }
}
