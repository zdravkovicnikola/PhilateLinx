namespace KorisnickiDeo
{
    partial class FrmMarkica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkica));
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrednost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDizajner = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOtpremi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaKategorija = new System.Windows.Forms.ListBox();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnUkloniKategoriju = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.Info;
            this.txtNaziv.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNaziv.Location = new System.Drawing.Point(43, 65);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(376, 26);
            this.txtNaziv.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(45, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Naziv";
            // 
            // txtGodina
            // 
            this.txtGodina.BackColor = System.Drawing.SystemColors.Info;
            this.txtGodina.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGodina.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtGodina.Location = new System.Drawing.Point(44, 159);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(105, 26);
            this.txtGodina.TabIndex = 36;
            this.txtGodina.Leave += new System.EventHandler(this.txtGodina_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(46, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Godina";
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.BackColor = System.Drawing.SystemColors.Info;
            this.cmbDrzava.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrzava.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(178, 156);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(241, 29);
            this.cmbDrzava.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(181, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Drzava";
            // 
            // rtbOpis
            // 
            this.rtbOpis.BackColor = System.Drawing.SystemColors.Info;
            this.rtbOpis.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOpis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbOpis.Location = new System.Drawing.Point(44, 260);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(639, 197);
            this.rtbOpis.TabIndex = 40;
            this.rtbOpis.Text = "Nema opisa.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(45, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Opis";
            // 
            // txtVrednost
            // 
            this.txtVrednost.BackColor = System.Drawing.SystemColors.Info;
            this.txtVrednost.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrednost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtVrednost.Location = new System.Drawing.Point(44, 519);
            this.txtVrednost.Name = "txtVrednost";
            this.txtVrednost.Size = new System.Drawing.Size(232, 26);
            this.txtVrednost.TabIndex = 42;
            this.txtVrednost.Leave += new System.EventHandler(this.txtVrednost_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(46, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Vrednost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(315, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Dizajner";
            // 
            // txtDizajner
            // 
            this.txtDizajner.BackColor = System.Drawing.SystemColors.Info;
            this.txtDizajner.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDizajner.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDizajner.Location = new System.Drawing.Point(320, 519);
            this.txtDizajner.Name = "txtDizajner";
            this.txtDizajner.Size = new System.Drawing.Size(363, 26);
            this.txtDizajner.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(466, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 151);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnOtpremi
            // 
            this.btnOtpremi.BackColor = System.Drawing.SystemColors.Info;
            this.btnOtpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtpremi.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpremi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOtpremi.Location = new System.Drawing.Point(466, 201);
            this.btnOtpremi.Name = "btnOtpremi";
            this.btnOtpremi.Size = new System.Drawing.Size(217, 52);
            this.btnOtpremi.TabIndex = 45;
            this.btnOtpremi.Text = "Otpremi";
            this.btnOtpremi.UseVisualStyleBackColor = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.Info;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnIzmeni.Location = new System.Drawing.Point(44, 560);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(217, 52);
            this.btnIzmeni.TabIndex = 47;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.Info;
            this.btnKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreiraj.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKreiraj.Location = new System.Drawing.Point(466, 560);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(217, 52);
            this.btnKreiraj.TabIndex = 48;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.BackColor = System.Drawing.SystemColors.Info;
            this.cmbKategorija.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(709, 63);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(250, 29);
            this.cmbKategorija.TabIndex = 50;
            this.cmbKategorija.SelectedValueChanged += new System.EventHandler(this.cmbKategorija_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(704, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Kategorija";
            // 
            // listaKategorija
            // 
            this.listaKategorija.BackColor = System.Drawing.SystemColors.Info;
            this.listaKategorija.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaKategorija.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listaKategorija.FormattingEnabled = true;
            this.listaKategorija.ItemHeight = 24;
            this.listaKategorija.Location = new System.Drawing.Point(709, 145);
            this.listaKategorija.Name = "listaKategorija";
            this.listaKategorija.Size = new System.Drawing.Size(250, 244);
            this.listaKategorija.TabIndex = 51;
            this.listaKategorija.Leave += new System.EventHandler(this.listaKategorija_Leave);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.SystemColors.Info;
            this.btnDodajKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(709, 395);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(250, 52);
            this.btnDodajKategoriju.TabIndex = 52;
            this.btnDodajKategoriju.Text = "Dodaj Kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnUkloniKategoriju
            // 
            this.btnUkloniKategoriju.BackColor = System.Drawing.SystemColors.Info;
            this.btnUkloniKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloniKategoriju.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniKategoriju.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUkloniKategoriju.Location = new System.Drawing.Point(709, 453);
            this.btnUkloniKategoriju.Name = "btnUkloniKategoriju";
            this.btnUkloniKategoriju.Size = new System.Drawing.Size(250, 52);
            this.btnUkloniKategoriju.TabIndex = 53;
            this.btnUkloniKategoriju.Text = "Ukloni Kategoriju";
            this.btnUkloniKategoriju.UseVisualStyleBackColor = false;
            this.btnUkloniKategoriju.Click += new System.EventHandler(this.btnUkloniKategoriju_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bodoni MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(282, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "$";
            // 
            // FrmMarkica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KorisnickiDeo.Properties.Resources.PozadinaMarkica;
            this.ClientSize = new System.Drawing.Size(997, 631);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUkloniKategoriju);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.listaKategorija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOtpremi);
            this.Controls.Add(this.txtDizajner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVrednost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Name = "FrmMarkica";
            this.Text = "FrmMarkica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrednost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDizajner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOtpremi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listaKategorija;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnUkloniKategoriju;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
    }
}