using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikaGUI
{
    public partial class UnosSlike : UserControl
    {
        public Image slika;
        public DateTime datum;
        public string tekst;

        public UnosSlike()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku: ";
                dlg.Filter = "jpg files (*.jpg)|*jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = slika = new Bitmap(dlg.FileName);
                }
            }   
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimePicker1.Value<DateTime.Now.AddMonths(-6))
            {
                label1.Text =tekst= "Datum slike ne moze biti stariji od 6 mjeseci!";
                e.Cancel = true ;
            }
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            label1.Text=tekst = "";
        }
    }
}
