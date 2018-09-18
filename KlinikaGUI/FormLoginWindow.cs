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
using System.Security;

namespace KlinikaGUI
{
    public partial class FormLoginWindow : Form
    {
        internal Klinika klinika;

        public FormLoginWindow()
        {
            InitializeComponent();
            klinika = new Klinika();


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Graphics grafika = this.CreateGraphics();


            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.White);
            SolidBrush mojBrush2 = new SolidBrush(System.Drawing.Color.Black);
            Pen mojPen = new Pen(System.Drawing.Color.Blue, 5);
            mojPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            Rectangle rt = new Rectangle(200, 50, 100, 100);
            Rectangle elipsaPravougaonik = new Rectangle(20, 20, 250, 200);
            grafika.DrawEllipse(mojPen, elipsaPravougaonik);
            grafika.DrawLine(mojPen, 20, 20, 200, 210);
            grafika.FillRectangle(mojBrush, 210, 60, 80, 60);
            grafika.DrawString("RPR klinika", new Font("Arial", 16), mojBrush2,160, 80);
            

        }

        private void prikazi(object sender, EventArgs e)
        {
            this.Show();
        }   

        private void sakrij()
        {
            this.Hide();
            this.toolStripStatusLabel1.Visible = false;
            this.UserBox.Text = "";
            this.PassBox.Text = "";
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

        private void ButtLogin_Click(object sender, EventArgs e)
        {
            bool nadjen = false;
            StringBuilder pass = MD(this.PassBox.Text);

            if(UserBox.Text=="admin" && pass.ToString() == MD("admin").ToString())
            {
                FormReg forma = new FormReg(klinika);
                forma.FormClosed += prikazi;
                sakrij();
                forma.ShowDialog();
                nadjen = true;
            }

            foreach (Pacijent p in klinika.Pacijenti)
                if (p.Username == this.UserBox.Text && p.Password.ToString() == pass.ToString())
                {
                    p.BrPosjeta++;
                    FormPac forma = new FormPac(klinika,p);
                    forma.FormClosed += prikazi;
                    sakrij();
                    forma.ShowDialog();
                    nadjen = true;
                }

            foreach (dynamic p in klinika.Osoblje)
                if (p.Username == this.UserBox.Text && p.Password.ToString() == pass.ToString())
                {
                    if (p is OsRadDok)
                    {
                        FormDok forma = new FormDok(klinika, (OsRadDok)p);
                        forma.FormClosed += prikazi;
                        sakrij();
                        forma.ShowDialog();
                    }
                    else
                    {
                        FormOsob forma = new FormOsob(klinika, (OsRadMedTeh)p);
                        forma.FormClosed += prikazi;
                        sakrij();
                        forma.ShowDialog();
                    }
                    nadjen = true;
                }

            if (!nadjen)
            {
                this.toolStripStatusLabel1.Text = "Nepostojeca kombinacija username-a i password-a";
                this.toolStripStatusLabel1.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            FormRegPac forma = new FormRegPac(klinika);
            forma.Show();
        }
    }
}
