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
    public partial class FormZTermin : Form
    {
        Pacijent pac;
        public FormZTermin(Klinika klinika, Pacijent pac)
        {
            InitializeComponent();
            this.pac = pac;
            foreach (dynamic sala in klinika.Sale)
                if (sala is SaleSpec)
                    listBox1.Items.Add((SaleSpec)sala);
                else
                    listBox1.Items.Add(sala);
            listBox1.DisplayMember = "Naziv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                labelError.Text = "";
                pac.Raspored.ZakaziTermin(new RTermin(((Sale)listBox1.SelectedItem).Naziv, ((Sale)listBox1.SelectedItem).Termini.Tabela.Count + 1, pac.Karton.Sifra, "Pregled"));
                ((Sale)listBox1.SelectedItem).Termini.ZakaziTermin(new RTermin(pac.ImeiPrezime1, ((Sale)listBox1.SelectedItem).Termini.Tabela.Count + 1, pac.Karton.Sifra, "Pregled"));
                MessageBox.Show("Uspješno zakazan pregled.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                labelError.Text = "Izaberite salu!";
            }
        }
    }
}
