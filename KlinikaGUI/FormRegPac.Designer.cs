namespace KlinikaGUI
{
    partial class FormRegPac
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unosSlike1 = new KlinikaGUI.UnosSlike();
            this.label9 = new System.Windows.Forms.Label();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioZensk = new System.Windows.Forms.RadioButton();
            this.radioMusk = new System.Windows.Forms.RadioButton();
            this.textJMBG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassRe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateRodj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrez = new System.Windows.Forms.TextBox();
            this.textIme = new System.Windows.Forms.TextBox();
            this.Unesi = new System.Windows.Forms.Button();
            this.Ponisti = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(450, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unosSlike1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textAdresa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textJMBG);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textPassRe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPass);
            this.groupBox1.Controls.Add(this.textUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateRodj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPrez);
            this.groupBox1.Controls.Add(this.textIme);
            this.groupBox1.Controls.Add(this.Unesi);
            this.groupBox1.Controls.Add(this.Ponisti);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos";
            // 
            // unosSlike1
            // 
            this.unosSlike1.Location = new System.Drawing.Point(286, 62);
            this.unosSlike1.Name = "unosSlike1";
            this.unosSlike1.Size = new System.Drawing.Size(133, 217);
            this.unosSlike1.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Adresa:  ";
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(82, 138);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(198, 20);
            this.textAdresa.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "JMBG: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioZensk);
            this.groupBox4.Controls.Add(this.radioMusk);
            this.groupBox4.Location = new System.Drawing.Point(82, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 47);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spol";
            // 
            // radioZensk
            // 
            this.radioZensk.AutoSize = true;
            this.radioZensk.Location = new System.Drawing.Point(104, 19);
            this.radioZensk.Name = "radioZensk";
            this.radioZensk.Size = new System.Drawing.Size(61, 17);
            this.radioZensk.TabIndex = 2;
            this.radioZensk.TabStop = true;
            this.radioZensk.Text = "Zensko";
            this.radioZensk.UseVisualStyleBackColor = true;
            // 
            // radioMusk
            // 
            this.radioMusk.AutoSize = true;
            this.radioMusk.Checked = true;
            this.radioMusk.Location = new System.Drawing.Point(32, 19);
            this.radioMusk.Name = "radioMusk";
            this.radioMusk.Size = new System.Drawing.Size(57, 17);
            this.radioMusk.TabIndex = 0;
            this.radioMusk.TabStop = true;
            this.radioMusk.Text = "Musko";
            this.radioMusk.UseVisualStyleBackColor = true;
            // 
            // textJMBG
            // 
            this.textJMBG.Location = new System.Drawing.Point(82, 86);
            this.textJMBG.Name = "textJMBG";
            this.textJMBG.Size = new System.Drawing.Size(198, 20);
            this.textJMBG.TabIndex = 28;
            this.textJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.textJMBG_Validating);
            this.textJMBG.Validated += new System.EventHandler(this.errorValidated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "PasswordRe: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textPassRe
            // 
            this.textPassRe.Location = new System.Drawing.Point(82, 278);
            this.textPassRe.Name = "textPassRe";
            this.textPassRe.PasswordChar = '*';
            this.textPassRe.Size = new System.Drawing.Size(198, 20);
            this.textPassRe.TabIndex = 26;
            this.textPassRe.Validating += new System.ComponentModel.CancelEventHandler(this.textPass_Validating);
            this.textPassRe.Validated += new System.EventHandler(this.errorValidated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Username: ";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(82, 252);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(198, 20);
            this.textPass.TabIndex = 19;
            this.textPass.Validating += new System.ComponentModel.CancelEventHandler(this.textPass_Validating);
            this.textPass.Validated += new System.EventHandler(this.errorValidated);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(82, 226);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(198, 20);
            this.textUser.TabIndex = 17;
            this.textUser.Validating += new System.ComponentModel.CancelEventHandler(this.textUser_Validating);
            this.textUser.Validated += new System.EventHandler(this.errorValidated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum rodj: ";
            // 
            // dateRodj
            // 
            this.dateRodj.Location = new System.Drawing.Point(82, 112);
            this.dateRodj.Name = "dateRodj";
            this.dateRodj.Size = new System.Drawing.Size(198, 20);
            this.dateRodj.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prezime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime: ";
            // 
            // textPrez
            // 
            this.textPrez.Location = new System.Drawing.Point(82, 59);
            this.textPrez.Name = "textPrez";
            this.textPrez.Size = new System.Drawing.Size(198, 20);
            this.textPrez.TabIndex = 5;
            // 
            // textIme
            // 
            this.textIme.Location = new System.Drawing.Point(82, 33);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(198, 20);
            this.textIme.TabIndex = 4;
            // 
            // Unesi
            // 
            this.Unesi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Unesi.Location = new System.Drawing.Point(124, 304);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(76, 23);
            this.Unesi.TabIndex = 3;
            this.Unesi.Text = "Unesi";
            this.Unesi.UseVisualStyleBackColor = true;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            this.Unesi.Validated += new System.EventHandler(this.errorValidated);
            // 
            // Ponisti
            // 
            this.Ponisti.Location = new System.Drawing.Point(206, 304);
            this.Ponisti.Name = "Ponisti";
            this.Ponisti.Size = new System.Drawing.Size(74, 23);
            this.Ponisti.TabIndex = 2;
            this.Ponisti.Text = "Ponisti";
            this.Ponisti.UseVisualStyleBackColor = true;
            this.Ponisti.Click += new System.EventHandler(this.Ponisti_Click);
            // 
            // FormRegPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegPac";
            this.Text = "FormRegPac";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioZensk;
        private System.Windows.Forms.RadioButton radioMusk;
        private System.Windows.Forms.TextBox textJMBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateRodj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrez;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.Button Unesi;
        private System.Windows.Forms.Button Ponisti;
        private UnosSlike unosSlike1;
    }
}