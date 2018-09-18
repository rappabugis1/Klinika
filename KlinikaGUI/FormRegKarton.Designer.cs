namespace KlinikaGUI
{
    partial class FormRegKarton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrAl = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrBol = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TrenAl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrenBol = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PrAl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PrBol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TrenAl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrenBol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registracija";
            // 
            // PrAl
            // 
            this.PrAl.Location = new System.Drawing.Point(234, 142);
            this.PrAl.Name = "PrAl";
            this.PrAl.Size = new System.Drawing.Size(209, 57);
            this.PrAl.TabIndex = 7;
            this.PrAl.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prijasnje alergije (Novi red za svaku):";
            // 
            // PrBol
            // 
            this.PrBol.Location = new System.Drawing.Point(234, 52);
            this.PrBol.Name = "PrBol";
            this.PrBol.Size = new System.Drawing.Size(209, 57);
            this.PrBol.TabIndex = 5;
            this.PrBol.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prijasnje bolesti (Novi red za svaku):";
            // 
            // TrenAl
            // 
            this.TrenAl.Location = new System.Drawing.Point(6, 142);
            this.TrenAl.Name = "TrenAl";
            this.TrenAl.Size = new System.Drawing.Size(209, 57);
            this.TrenAl.TabIndex = 3;
            this.TrenAl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trenutne alergije (Novi red za svaku):";
            // 
            // TrenBol
            // 
            this.TrenBol.Location = new System.Drawing.Point(6, 52);
            this.TrenBol.Name = "TrenBol";
            this.TrenBol.Size = new System.Drawing.Size(209, 57);
            this.TrenBol.TabIndex = 1;
            this.TrenBol.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trenutne bolesti (Novi red za svaku):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegKarton";
            this.Text = "FormRegKarton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox PrAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PrBol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TrenAl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TrenBol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}