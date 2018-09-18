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
    public partial class FormUpisiPregled : Form
    {
        Pacijent pac;
        public FormUpisiPregled(Pacijent pac)
        {
            InitializeComponent();
            this.pac = pac;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(richTextBox1.Text) || String.IsNullOrEmpty(richTextBox2.Text) || String.IsNullOrEmpty(richTextBox2.Text) || (radioButton1.Checked && (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))))) {
                pac.Karton.Pregledi.Add(new Karton.Pregled(richTextBox2.Text, richTextBox1.Text));
                if(radioButton1.Checked)
                    pac.Karton.Pregledi.Last().Terapija = new Karton.Terapija(textBox1.Text, Convert.ToInt32(textBox3.Text), textBox2.Text, richTextBox3.Text);
                labelError.Text = "";               
                MessageBox.Show("Uspješno unesen pregled.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                labelError.Text = "Polja ne mogu biti prazna!";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled =richTextBox3.Enabled= true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = richTextBox3.Enabled = false;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            int n;
            if( int.TryParse("123", out n)==false)
            {
                labelError.Text = "Trajanje mora biti numericko!";
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            labelError.Text = "";
        }
    }
}
