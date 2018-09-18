namespace KlinikaGUI
{
    partial class FormKarton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabPod = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.podaci1 = new KlinikaGUI.Podaci();
            this.labelBrPos = new System.Windows.Forms.Label();
            this.tabBolesti = new System.Windows.Forms.TabPage();
            this.labelTrBol = new System.Windows.Forms.Label();
            this.listTrBol = new System.Windows.Forms.ListBox();
            this.labelPrBol = new System.Windows.Forms.Label();
            this.listPrBol = new System.Windows.Forms.ListBox();
            this.tabAlergije = new System.Windows.Forms.TabPage();
            this.labelTrAler = new System.Windows.Forms.Label();
            this.listTrAler = new System.Windows.Forms.ListBox();
            this.labelPrAler = new System.Windows.Forms.Label();
            this.listPrAler = new System.Windows.Forms.ListBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPagePregled = new System.Windows.Forms.TabPage();
            this.datumvar = new System.Windows.Forms.Label();
            this.labeldatum = new System.Windows.Forms.Label();
            this.labelrez = new System.Windows.Forms.Label();
            this.labelmis = new System.Windows.Forms.Label();
            this.richTextRe = new System.Windows.Forms.RichTextBox();
            this.richTextMis = new System.Windows.Forms.RichTextBox();
            this.tabPageTerapija = new System.Windows.Forms.TabPage();
            this.InfoTrajanje = new System.Windows.Forms.Label();
            this.InfoDavaoc = new System.Windows.Forms.Label();
            this.InfoDatumprop = new System.Windows.Forms.Label();
            this.InforNazivter = new System.Windows.Forms.Label();
            this.labelkomenta = new System.Windows.Forms.Label();
            this.richTextBoxkomentar = new System.Windows.Forms.RichTextBox();
            this.labelnazivter = new System.Windows.Forms.Label();
            this.labeltrajanje = new System.Windows.Forms.Label();
            this.labeldavaocter = new System.Windows.Forms.Label();
            this.labeldatumprop = new System.Windows.Forms.Label();
            this.groupboxPregledi = new System.Windows.Forms.GroupBox();
            this.listBoxPregledi = new System.Windows.Forms.ListBox();
            this.tabInfo.SuspendLayout();
            this.tabPod.SuspendLayout();
            this.tabBolesti.SuspendLayout();
            this.tabAlergije.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPagePregled.SuspendLayout();
            this.tabPageTerapija.SuspendLayout();
            this.groupboxPregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabPod);
            this.tabInfo.Controls.Add(this.tabBolesti);
            this.tabInfo.Controls.Add(this.tabAlergije);
            this.tabInfo.Location = new System.Drawing.Point(12, 12);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(223, 219);
            this.tabInfo.TabIndex = 13;
            // 
            // tabPod
            // 
            this.tabPod.Controls.Add(this.label1);
            this.tabPod.Controls.Add(this.label18);
            this.tabPod.Controls.Add(this.label17);
            this.tabPod.Controls.Add(this.label16);
            this.tabPod.Controls.Add(this.label15);
            this.tabPod.Controls.Add(this.label14);
            this.tabPod.Controls.Add(this.label13);
            this.tabPod.Controls.Add(this.podaci1);
            this.tabPod.Controls.Add(this.labelBrPos);
            this.tabPod.Location = new System.Drawing.Point(4, 22);
            this.tabPod.Name = "tabPod";
            this.tabPod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPod.Size = new System.Drawing.Size(215, 193);
            this.tabPod.TabIndex = 0;
            this.tabPod.Text = "Podaci";
            this.tabPod.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "label1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(75, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 63;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(77, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "label13";
            // 
            // podaci1
            // 
            this.podaci1.Location = new System.Drawing.Point(6, 16);
            this.podaci1.Name = "podaci1";
            this.podaci1.Size = new System.Drawing.Size(65, 150);
            this.podaci1.TabIndex = 27;
            // 
            // labelBrPos
            // 
            this.labelBrPos.AutoSize = true;
            this.labelBrPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrPos.Location = new System.Drawing.Point(9, 165);
            this.labelBrPos.Name = "labelBrPos";
            this.labelBrPos.Size = new System.Drawing.Size(79, 13);
            this.labelBrPos.TabIndex = 26;
            this.labelBrPos.Text = "Broj Posjeta:";
            // 
            // tabBolesti
            // 
            this.tabBolesti.Controls.Add(this.labelTrBol);
            this.tabBolesti.Controls.Add(this.listTrBol);
            this.tabBolesti.Controls.Add(this.labelPrBol);
            this.tabBolesti.Controls.Add(this.listPrBol);
            this.tabBolesti.Location = new System.Drawing.Point(4, 22);
            this.tabBolesti.Name = "tabBolesti";
            this.tabBolesti.Padding = new System.Windows.Forms.Padding(3);
            this.tabBolesti.Size = new System.Drawing.Size(215, 193);
            this.tabBolesti.TabIndex = 1;
            this.tabBolesti.Text = "Bolesti";
            this.tabBolesti.UseVisualStyleBackColor = true;
            // 
            // labelTrBol
            // 
            this.labelTrBol.AutoSize = true;
            this.labelTrBol.Location = new System.Drawing.Point(3, 13);
            this.labelTrBol.Name = "labelTrBol";
            this.labelTrBol.Size = new System.Drawing.Size(86, 13);
            this.labelTrBol.TabIndex = 8;
            this.labelTrBol.Text = "Trenutne bolesti:";
            // 
            // listTrBol
            // 
            this.listTrBol.Enabled = false;
            this.listTrBol.FormattingEnabled = true;
            this.listTrBol.Location = new System.Drawing.Point(6, 29);
            this.listTrBol.Name = "listTrBol";
            this.listTrBol.Size = new System.Drawing.Size(203, 56);
            this.listTrBol.TabIndex = 7;
            // 
            // labelPrBol
            // 
            this.labelPrBol.AutoSize = true;
            this.labelPrBol.Location = new System.Drawing.Point(3, 103);
            this.labelPrBol.Name = "labelPrBol";
            this.labelPrBol.Size = new System.Drawing.Size(72, 13);
            this.labelPrBol.TabIndex = 6;
            this.labelPrBol.Text = "Prosle bolesti:";
            // 
            // listPrBol
            // 
            this.listPrBol.Enabled = false;
            this.listPrBol.FormattingEnabled = true;
            this.listPrBol.Location = new System.Drawing.Point(6, 119);
            this.listPrBol.Name = "listPrBol";
            this.listPrBol.Size = new System.Drawing.Size(203, 56);
            this.listPrBol.TabIndex = 0;
            // 
            // tabAlergije
            // 
            this.tabAlergije.Controls.Add(this.labelTrAler);
            this.tabAlergije.Controls.Add(this.listTrAler);
            this.tabAlergije.Controls.Add(this.labelPrAler);
            this.tabAlergije.Controls.Add(this.listPrAler);
            this.tabAlergije.Location = new System.Drawing.Point(4, 22);
            this.tabAlergije.Name = "tabAlergije";
            this.tabAlergije.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlergije.Size = new System.Drawing.Size(215, 193);
            this.tabAlergije.TabIndex = 2;
            this.tabAlergije.Text = "Alergije";
            this.tabAlergije.UseVisualStyleBackColor = true;
            // 
            // labelTrAler
            // 
            this.labelTrAler.AutoSize = true;
            this.labelTrAler.Location = new System.Drawing.Point(3, 14);
            this.labelTrAler.Name = "labelTrAler";
            this.labelTrAler.Size = new System.Drawing.Size(89, 13);
            this.labelTrAler.TabIndex = 12;
            this.labelTrAler.Text = "Trenutne alergije:";
            // 
            // listTrAler
            // 
            this.listTrAler.Enabled = false;
            this.listTrAler.FormattingEnabled = true;
            this.listTrAler.Location = new System.Drawing.Point(6, 30);
            this.listTrAler.Name = "listTrAler";
            this.listTrAler.Size = new System.Drawing.Size(203, 56);
            this.listTrAler.TabIndex = 11;
            // 
            // labelPrAler
            // 
            this.labelPrAler.AutoSize = true;
            this.labelPrAler.Location = new System.Drawing.Point(3, 102);
            this.labelPrAler.Name = "labelPrAler";
            this.labelPrAler.Size = new System.Drawing.Size(72, 13);
            this.labelPrAler.TabIndex = 10;
            this.labelPrAler.Text = "Prosle bolesti:";
            // 
            // listPrAler
            // 
            this.listPrAler.Enabled = false;
            this.listPrAler.FormattingEnabled = true;
            this.listPrAler.Location = new System.Drawing.Point(6, 118);
            this.listPrAler.Name = "listPrAler";
            this.listPrAler.Size = new System.Drawing.Size(203, 56);
            this.listPrAler.TabIndex = 9;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPagePregled);
            this.tabControl2.Controls.Add(this.tabPageTerapija);
            this.tabControl2.Location = new System.Drawing.Point(242, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(409, 336);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPagePregled
            // 
            this.tabPagePregled.Controls.Add(this.datumvar);
            this.tabPagePregled.Controls.Add(this.labeldatum);
            this.tabPagePregled.Controls.Add(this.labelrez);
            this.tabPagePregled.Controls.Add(this.labelmis);
            this.tabPagePregled.Controls.Add(this.richTextRe);
            this.tabPagePregled.Controls.Add(this.richTextMis);
            this.tabPagePregled.Location = new System.Drawing.Point(4, 22);
            this.tabPagePregled.Name = "tabPagePregled";
            this.tabPagePregled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePregled.Size = new System.Drawing.Size(401, 310);
            this.tabPagePregled.TabIndex = 0;
            this.tabPagePregled.Text = "Pregled";
            this.tabPagePregled.UseVisualStyleBackColor = true;
            // 
            // datumvar
            // 
            this.datumvar.AutoSize = true;
            this.datumvar.Location = new System.Drawing.Point(104, 19);
            this.datumvar.Name = "datumvar";
            this.datumvar.Size = new System.Drawing.Size(0, 13);
            this.datumvar.TabIndex = 6;
            // 
            // labeldatum
            // 
            this.labeldatum.AutoSize = true;
            this.labeldatum.Location = new System.Drawing.Point(13, 19);
            this.labeldatum.Name = "labeldatum";
            this.labeldatum.Size = new System.Drawing.Size(85, 13);
            this.labeldatum.TabIndex = 5;
            this.labeldatum.Text = "Datum pregleda:";
            // 
            // labelrez
            // 
            this.labelrez.AutoSize = true;
            this.labelrez.Location = new System.Drawing.Point(13, 50);
            this.labelrez.Name = "labelrez";
            this.labelrez.Size = new System.Drawing.Size(93, 13);
            this.labelrez.TabIndex = 4;
            this.labelrez.Text = "Rezultat pregleda:";
            // 
            // labelmis
            // 
            this.labelmis.AutoSize = true;
            this.labelmis.Location = new System.Drawing.Point(13, 174);
            this.labelmis.Name = "labelmis";
            this.labelmis.Size = new System.Drawing.Size(89, 13);
            this.labelmis.TabIndex = 3;
            this.labelmis.Text = "Misljenje doktora:";
            // 
            // richTextRe
            // 
            this.richTextRe.Enabled = false;
            this.richTextRe.Location = new System.Drawing.Point(16, 66);
            this.richTextRe.Name = "richTextRe";
            this.richTextRe.Size = new System.Drawing.Size(369, 105);
            this.richTextRe.TabIndex = 2;
            this.richTextRe.Text = "";
            // 
            // richTextMis
            // 
            this.richTextMis.Enabled = false;
            this.richTextMis.Location = new System.Drawing.Point(16, 190);
            this.richTextMis.Name = "richTextMis";
            this.richTextMis.Size = new System.Drawing.Size(369, 105);
            this.richTextMis.TabIndex = 1;
            this.richTextMis.Text = "";
            // 
            // tabPageTerapija
            // 
            this.tabPageTerapija.Controls.Add(this.InfoTrajanje);
            this.tabPageTerapija.Controls.Add(this.InfoDavaoc);
            this.tabPageTerapija.Controls.Add(this.InfoDatumprop);
            this.tabPageTerapija.Controls.Add(this.InforNazivter);
            this.tabPageTerapija.Controls.Add(this.labelkomenta);
            this.tabPageTerapija.Controls.Add(this.richTextBoxkomentar);
            this.tabPageTerapija.Controls.Add(this.labelnazivter);
            this.tabPageTerapija.Controls.Add(this.labeltrajanje);
            this.tabPageTerapija.Controls.Add(this.labeldavaocter);
            this.tabPageTerapija.Controls.Add(this.labeldatumprop);
            this.tabPageTerapija.Location = new System.Drawing.Point(4, 22);
            this.tabPageTerapija.Name = "tabPageTerapija";
            this.tabPageTerapija.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTerapija.Size = new System.Drawing.Size(401, 310);
            this.tabPageTerapija.TabIndex = 1;
            this.tabPageTerapija.Text = "Terapija";
            this.tabPageTerapija.UseVisualStyleBackColor = true;
            // 
            // InfoTrajanje
            // 
            this.InfoTrajanje.AutoSize = true;
            this.InfoTrajanje.Location = new System.Drawing.Point(109, 88);
            this.InfoTrajanje.Name = "InfoTrajanje";
            this.InfoTrajanje.Size = new System.Drawing.Size(0, 13);
            this.InfoTrajanje.TabIndex = 15;
            // 
            // InfoDavaoc
            // 
            this.InfoDavaoc.AutoSize = true;
            this.InfoDavaoc.Location = new System.Drawing.Point(109, 64);
            this.InfoDavaoc.Name = "InfoDavaoc";
            this.InfoDavaoc.Size = new System.Drawing.Size(0, 13);
            this.InfoDavaoc.TabIndex = 14;
            // 
            // InfoDatumprop
            // 
            this.InfoDatumprop.AutoSize = true;
            this.InfoDatumprop.Location = new System.Drawing.Point(109, 42);
            this.InfoDatumprop.Name = "InfoDatumprop";
            this.InfoDatumprop.Size = new System.Drawing.Size(0, 13);
            this.InfoDatumprop.TabIndex = 13;
            // 
            // InforNazivter
            // 
            this.InforNazivter.AutoSize = true;
            this.InforNazivter.Location = new System.Drawing.Point(109, 19);
            this.InforNazivter.Name = "InforNazivter";
            this.InforNazivter.Size = new System.Drawing.Size(0, 13);
            this.InforNazivter.TabIndex = 12;
            // 
            // labelkomenta
            // 
            this.labelkomenta.AutoSize = true;
            this.labelkomenta.Location = new System.Drawing.Point(15, 128);
            this.labelkomenta.Name = "labelkomenta";
            this.labelkomenta.Size = new System.Drawing.Size(94, 13);
            this.labelkomenta.TabIndex = 9;
            this.labelkomenta.Text = "Komentar doktora:";
            // 
            // richTextBoxkomentar
            // 
            this.richTextBoxkomentar.Enabled = false;
            this.richTextBoxkomentar.Location = new System.Drawing.Point(18, 144);
            this.richTextBoxkomentar.Name = "richTextBoxkomentar";
            this.richTextBoxkomentar.Size = new System.Drawing.Size(366, 150);
            this.richTextBoxkomentar.TabIndex = 8;
            this.richTextBoxkomentar.Text = "";
            // 
            // labelnazivter
            // 
            this.labelnazivter.AutoSize = true;
            this.labelnazivter.Location = new System.Drawing.Point(15, 19);
            this.labelnazivter.Name = "labelnazivter";
            this.labelnazivter.Size = new System.Drawing.Size(74, 13);
            this.labelnazivter.TabIndex = 7;
            this.labelnazivter.Text = "Naziv terapije:";
            // 
            // labeltrajanje
            // 
            this.labeltrajanje.AutoSize = true;
            this.labeltrajanje.Location = new System.Drawing.Point(15, 89);
            this.labeltrajanje.Name = "labeltrajanje";
            this.labeltrajanje.Size = new System.Drawing.Size(48, 13);
            this.labeltrajanje.TabIndex = 6;
            this.labeltrajanje.Text = "Trajanje:";
            // 
            // labeldavaocter
            // 
            this.labeldavaocter.AutoSize = true;
            this.labeldavaocter.Location = new System.Drawing.Point(15, 65);
            this.labeldavaocter.Name = "labeldavaocter";
            this.labeldavaocter.Size = new System.Drawing.Size(85, 13);
            this.labeldavaocter.TabIndex = 5;
            this.labeldavaocter.Text = "Davaoc terapije:";
            // 
            // labeldatumprop
            // 
            this.labeldatumprop.AutoSize = true;
            this.labeldatumprop.Location = new System.Drawing.Point(15, 41);
            this.labeldatumprop.Name = "labeldatumprop";
            this.labeldatumprop.Size = new System.Drawing.Size(78, 13);
            this.labeldatumprop.TabIndex = 4;
            this.labeldatumprop.Text = "Datum propisa:";
            // 
            // groupboxPregledi
            // 
            this.groupboxPregledi.Controls.Add(this.listBoxPregledi);
            this.groupboxPregledi.Location = new System.Drawing.Point(9, 237);
            this.groupboxPregledi.Name = "groupboxPregledi";
            this.groupboxPregledi.Size = new System.Drawing.Size(226, 111);
            this.groupboxPregledi.TabIndex = 11;
            this.groupboxPregledi.TabStop = false;
            this.groupboxPregledi.Text = "Pregledi";
            // 
            // listBoxPregledi
            // 
            this.listBoxPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPregledi.FormattingEnabled = true;
            this.listBoxPregledi.Location = new System.Drawing.Point(3, 16);
            this.listBoxPregledi.Name = "listBoxPregledi";
            this.listBoxPregledi.Size = new System.Drawing.Size(220, 92);
            this.listBoxPregledi.TabIndex = 2;
            // 
            // FormKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 354);
            this.Controls.Add(this.tabInfo);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupboxPregledi);
            this.Name = "FormKarton";
            this.Text = "FormKarton";
            this.tabInfo.ResumeLayout(false);
            this.tabPod.ResumeLayout(false);
            this.tabPod.PerformLayout();
            this.tabBolesti.ResumeLayout(false);
            this.tabBolesti.PerformLayout();
            this.tabAlergije.ResumeLayout(false);
            this.tabAlergije.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPagePregled.ResumeLayout(false);
            this.tabPagePregled.PerformLayout();
            this.tabPageTerapija.ResumeLayout(false);
            this.tabPageTerapija.PerformLayout();
            this.groupboxPregledi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabPod;
        private System.Windows.Forms.Label labelBrPos;
        private System.Windows.Forms.TabPage tabBolesti;
        private System.Windows.Forms.Label labelTrBol;
        private System.Windows.Forms.ListBox listTrBol;
        private System.Windows.Forms.Label labelPrBol;
        private System.Windows.Forms.ListBox listPrBol;
        private System.Windows.Forms.TabPage tabAlergije;
        private System.Windows.Forms.Label labelTrAler;
        private System.Windows.Forms.ListBox listTrAler;
        private System.Windows.Forms.Label labelPrAler;
        private System.Windows.Forms.ListBox listPrAler;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPagePregled;
        private System.Windows.Forms.Label datumvar;
        private System.Windows.Forms.Label labeldatum;
        private System.Windows.Forms.Label labelrez;
        private System.Windows.Forms.Label labelmis;
        private System.Windows.Forms.RichTextBox richTextRe;
        private System.Windows.Forms.RichTextBox richTextMis;
        private System.Windows.Forms.TabPage tabPageTerapija;
        private System.Windows.Forms.Label InfoTrajanje;
        private System.Windows.Forms.Label InfoDavaoc;
        private System.Windows.Forms.Label InfoDatumprop;
        private System.Windows.Forms.Label InforNazivter;
        private System.Windows.Forms.Label labelkomenta;
        private System.Windows.Forms.RichTextBox richTextBoxkomentar;
        private System.Windows.Forms.Label labelnazivter;
        private System.Windows.Forms.Label labeltrajanje;
        private System.Windows.Forms.Label labeldavaocter;
        private System.Windows.Forms.Label labeldatumprop;
        private System.Windows.Forms.GroupBox groupboxPregledi;
        private System.Windows.Forms.ListBox listBoxPregledi;
        private Podaci podaci1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
    }
}