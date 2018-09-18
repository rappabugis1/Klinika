namespace KlinikaGUI
{
    partial class FormOsob
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
            this.tabOpcije = new System.Windows.Forms.TabControl();
            this.tabTermini = new System.Windows.Forms.TabPage();
            this.groupter1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupZakazi = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupTermin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPac = new System.Windows.Forms.TabPage();
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxPretraga = new System.Windows.Forms.ListBox();
            this.textBoxImePretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxPodaci = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelpr = new System.Windows.Forms.Label();
            this.labelime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrujPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjenaLoginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabOpcije.SuspendLayout();
            this.tabTermini.SuspendLayout();
            this.groupter1.SuspendLayout();
            this.groupZakazi.SuspendLayout();
            this.groupTermin.SuspendLayout();
            this.tabPac.SuspendLayout();
            this.groupBoxPretraga.SuspendLayout();
            this.groupBoxPodaci.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOpcije
            // 
            this.tabOpcije.Controls.Add(this.tabTermini);
            this.tabOpcije.Controls.Add(this.tabPac);
            this.tabOpcije.Location = new System.Drawing.Point(162, 27);
            this.tabOpcije.Name = "tabOpcije";
            this.tabOpcije.SelectedIndex = 0;
            this.tabOpcije.Size = new System.Drawing.Size(509, 294);
            this.tabOpcije.TabIndex = 9;
            // 
            // tabTermini
            // 
            this.tabTermini.Controls.Add(this.groupter1);
            this.tabTermini.Location = new System.Drawing.Point(4, 22);
            this.tabTermini.Name = "tabTermini";
            this.tabTermini.Padding = new System.Windows.Forms.Padding(3);
            this.tabTermini.Size = new System.Drawing.Size(501, 268);
            this.tabTermini.TabIndex = 0;
            this.tabTermini.Text = "Termin";
            this.tabTermini.UseVisualStyleBackColor = true;
            // 
            // groupter1
            // 
            this.groupter1.Controls.Add(this.listBox2);
            this.groupter1.Controls.Add(this.label19);
            this.groupter1.Controls.Add(this.label3);
            this.groupter1.Controls.Add(this.listBox1);
            this.groupter1.Controls.Add(this.groupZakazi);
            this.groupter1.Controls.Add(this.groupTermin);
            this.groupter1.Location = new System.Drawing.Point(6, 6);
            this.groupter1.Name = "groupter1";
            this.groupter1.Size = new System.Drawing.Size(483, 255);
            this.groupter1.TabIndex = 3;
            this.groupter1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(242, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(227, 95);
            this.listBox2.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(239, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Termini za izabranu salu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Izaberite salu:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 95);
            this.listBox1.TabIndex = 7;
            // 
            // groupZakazi
            // 
            this.groupZakazi.Controls.Add(this.button2);
            this.groupZakazi.Location = new System.Drawing.Point(9, 133);
            this.groupZakazi.Name = "groupZakazi";
            this.groupZakazi.Size = new System.Drawing.Size(227, 108);
            this.groupZakazi.TabIndex = 5;
            this.groupZakazi.TabStop = false;
            this.groupZakazi.Text = "Upravljanje";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Zakazi novi pregled";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupTermin
            // 
            this.groupTermin.Controls.Add(this.label1);
            this.groupTermin.Controls.Add(this.label22);
            this.groupTermin.Controls.Add(this.label21);
            this.groupTermin.Controls.Add(this.label20);
            this.groupTermin.Controls.Add(this.label2);
            this.groupTermin.Controls.Add(this.label12);
            this.groupTermin.Controls.Add(this.label6);
            this.groupTermin.Controls.Add(this.label23);
            this.groupTermin.Location = new System.Drawing.Point(242, 133);
            this.groupTermin.Name = "groupTermin";
            this.groupTermin.Size = new System.Drawing.Size(227, 108);
            this.groupTermin.TabIndex = 4;
            this.groupTermin.TabStop = false;
            this.groupTermin.Text = "Trenutni termin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 78;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 77;
            this.label22.Text = "Sifra:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(71, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 76;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Svrha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Redni broj:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 71;
            this.label23.Text = "Naziv:";
            // 
            // tabPac
            // 
            this.tabPac.Controls.Add(this.groupBoxPretraga);
            this.tabPac.Location = new System.Drawing.Point(4, 22);
            this.tabPac.Name = "tabPac";
            this.tabPac.Padding = new System.Windows.Forms.Padding(3);
            this.tabPac.Size = new System.Drawing.Size(501, 268);
            this.tabPac.TabIndex = 1;
            this.tabPac.Text = "Pacijenti";
            this.tabPac.UseVisualStyleBackColor = true;
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.button1);
            this.groupBoxPretraga.Controls.Add(this.button4);
            this.groupBoxPretraga.Controls.Add(this.button3);
            this.groupBoxPretraga.Controls.Add(this.listBoxPretraga);
            this.groupBoxPretraga.Controls.Add(this.textBoxImePretraga);
            this.groupBoxPretraga.Controls.Add(this.label7);
            this.groupBoxPretraga.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(264, 255);
            this.groupBoxPretraga.TabIndex = 2;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "Pretraga";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Zakazi termin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(136, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 32);
            this.button4.TabIndex = 17;
            this.button4.Text = "Registruj karton";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Prikazi karton";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxPretraga
            // 
            this.listBoxPretraga.FormattingEnabled = true;
            this.listBoxPretraga.Location = new System.Drawing.Point(18, 59);
            this.listBoxPretraga.Name = "listBoxPretraga";
            this.listBoxPretraga.Size = new System.Drawing.Size(225, 108);
            this.listBoxPretraga.TabIndex = 15;
            // 
            // textBoxImePretraga
            // 
            this.textBoxImePretraga.Location = new System.Drawing.Point(72, 26);
            this.textBoxImePretraga.Name = "textBoxImePretraga";
            this.textBoxImePretraga.Size = new System.Drawing.Size(171, 20);
            this.textBoxImePretraga.TabIndex = 14;
            this.textBoxImePretraga.TextChanged += new System.EventHandler(this.textBoxImePretraga_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ime/sifra:";
            // 
            // groupBoxPodaci
            // 
            this.groupBoxPodaci.Controls.Add(this.label18);
            this.groupBoxPodaci.Controls.Add(this.label17);
            this.groupBoxPodaci.Controls.Add(this.label16);
            this.groupBoxPodaci.Controls.Add(this.label15);
            this.groupBoxPodaci.Controls.Add(this.label14);
            this.groupBoxPodaci.Controls.Add(this.label13);
            this.groupBoxPodaci.Controls.Add(this.label5);
            this.groupBoxPodaci.Controls.Add(this.label9);
            this.groupBoxPodaci.Controls.Add(this.label8);
            this.groupBoxPodaci.Controls.Add(this.labelpr);
            this.groupBoxPodaci.Controls.Add(this.labelime);
            this.groupBoxPodaci.Controls.Add(this.label4);
            this.groupBoxPodaci.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPodaci.Name = "groupBoxPodaci";
            this.groupBoxPodaci.Size = new System.Drawing.Size(144, 294);
            this.groupBoxPodaci.TabIndex = 8;
            this.groupBoxPodaci.TabStop = false;
            this.groupBoxPodaci.Text = "Podaci";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 254);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "label18";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 73;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "label13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Spol: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Adresa:  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "JMBG: ";
            // 
            // labelpr
            // 
            this.labelpr.AutoSize = true;
            this.labelpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpr.Location = new System.Drawing.Point(5, 82);
            this.labelpr.Name = "labelpr";
            this.labelpr.Size = new System.Drawing.Size(55, 13);
            this.labelpr.TabIndex = 66;
            this.labelpr.Text = "Prezime:";
            // 
            // labelime
            // 
            this.labelime.AutoSize = true;
            this.labelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelime.Location = new System.Drawing.Point(6, 44);
            this.labelime.Name = "labelime";
            this.labelime.Size = new System.Drawing.Size(31, 13);
            this.labelime.TabIndex = 65;
            this.labelime.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Datum rodj: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrujPacijentaToolStripMenuItem,
            this.opcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrujPacijentaToolStripMenuItem
            // 
            this.registrujPacijentaToolStripMenuItem.Name = "registrujPacijentaToolStripMenuItem";
            this.registrujPacijentaToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.registrujPacijentaToolStripMenuItem.Text = "Registruj pacijenta";
            this.registrujPacijentaToolStripMenuItem.Click += new System.EventHandler(this.registrujPacijentaToolStripMenuItem_Click);
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmjenaLoginaToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.opcijeToolStripMenuItem.Text = "Vise opcija";
            // 
            // izmjenaLoginaToolStripMenuItem
            // 
            this.izmjenaLoginaToolStripMenuItem.Name = "izmjenaLoginaToolStripMenuItem";
            this.izmjenaLoginaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.izmjenaLoginaToolStripMenuItem.Text = "Izmjena Logina";
            this.izmjenaLoginaToolStripMenuItem.Click += new System.EventHandler(this.izmjenaLoginaToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FormOsob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 329);
            this.Controls.Add(this.tabOpcije);
            this.Controls.Add(this.groupBoxPodaci);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormOsob";
            this.Text = "Dobrodosli!";
            this.tabOpcije.ResumeLayout(false);
            this.tabTermini.ResumeLayout(false);
            this.groupter1.ResumeLayout(false);
            this.groupter1.PerformLayout();
            this.groupZakazi.ResumeLayout(false);
            this.groupTermin.ResumeLayout(false);
            this.groupTermin.PerformLayout();
            this.tabPac.ResumeLayout(false);
            this.groupBoxPretraga.ResumeLayout(false);
            this.groupBoxPretraga.PerformLayout();
            this.groupBoxPodaci.ResumeLayout(false);
            this.groupBoxPodaci.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOpcije;
        private System.Windows.Forms.TabPage tabPac;
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxPretraga;
        private System.Windows.Forms.TextBox textBoxImePretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxPodaci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrujPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjenaLoginaToolStripMenuItem;
        private System.Windows.Forms.TabPage tabTermini;
        private System.Windows.Forms.GroupBox groupter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupZakazi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupTermin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelpr;
        private System.Windows.Forms.Label labelime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
    }
}