namespace KorisnickiDeo
{
    partial class FrmKorisnik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izlozbaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.udjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlozbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLupa = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUkloniRezervaciju = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.lblPrisustvuju = new System.Windows.Forms.Label();
            this.dgvIzlozbe = new System.Windows.Forms.DataGridView();
            this.dgvMarkice = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzlozbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlozbaToolStripMenuItem1,
            this.izlozbaToolStripMenuItem,
            this.pretraziToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(43, 830);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // izlozbaToolStripMenuItem1
            // 
            this.izlozbaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.udjiToolStripMenuItem,
            this.izadjiToolStripMenuItem});
            this.izlozbaToolStripMenuItem1.Name = "izlozbaToolStripMenuItem1";
            this.izlozbaToolStripMenuItem1.Size = new System.Drawing.Size(36, 99);
            this.izlozbaToolStripMenuItem1.Text = "Kolekcija";
            // 
            // udjiToolStripMenuItem
            // 
            this.udjiToolStripMenuItem.Name = "udjiToolStripMenuItem";
            this.udjiToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.udjiToolStripMenuItem.Text = "Udji";
            this.udjiToolStripMenuItem.Click += new System.EventHandler(this.udjiToolStripMenuItem_Click);
            // 
            // izadjiToolStripMenuItem
            // 
            this.izadjiToolStripMenuItem.Name = "izadjiToolStripMenuItem";
            this.izadjiToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.izadjiToolStripMenuItem.Text = "Izadji";
            this.izadjiToolStripMenuItem.Click += new System.EventHandler(this.izadjiToolStripMenuItem_Click);
            // 
            // izlozbaToolStripMenuItem
            // 
            this.izlozbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem});
            this.izlozbaToolStripMenuItem.Name = "izlozbaToolStripMenuItem";
            this.izlozbaToolStripMenuItem.Size = new System.Drawing.Size(36, 78);
            this.izlozbaToolStripMenuItem.Text = "Izlozba";
            // 
            // kreirajToolStripMenuItem
            // 
            this.kreirajToolStripMenuItem.Name = "kreirajToolStripMenuItem";
            this.kreirajToolStripMenuItem.Size = new System.Drawing.Size(145, 28);
            this.kreirajToolStripMenuItem.Text = "Kreiraj";
            this.kreirajToolStripMenuItem.Click += new System.EventHandler(this.kreirajToolStripMenuItem_Click);
            // 
            // pretraziToolStripMenuItem
            // 
            this.pretraziToolStripMenuItem.Name = "pretraziToolStripMenuItem";
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(36, 86);
            this.pretraziToolStripMenuItem.Text = "Pretrazi";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.pretraziToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(36, 96);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.BackColor = System.Drawing.Color.Transparent;
            this.lblLupa.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLupa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLupa.Location = new System.Drawing.Point(10, 48);
            this.lblLupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 24);
            this.lblLupa.TabIndex = 32;
            this.lblLupa.Text = "🔍";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSearch.Location = new System.Drawing.Point(4, 402);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(113, 26);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = global::KorisnickiDeo.Properties.Resources.Screenshot_2024_02_11_235434;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.btnUkloniRezervaciju);
            this.pnlMain.Controls.Add(this.dgvRezervacije);
            this.pnlMain.Controls.Add(this.btnRezervisi);
            this.pnlMain.Controls.Add(this.lblPrisustvuju);
            this.pnlMain.Controls.Add(this.dgvIzlozbe);
            this.pnlMain.Controls.Add(this.dgvMarkice);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(135, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1633, 830);
            this.pnlMain.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1455, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Dobrodosli,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1314, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Rezevisano prisustvo:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUsername.Location = new System.Drawing.Point(1455, 30);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 24);
            this.lblUsername.TabIndex = 37;
            this.lblUsername.Text = "Username";
            // 
            // btnUkloniRezervaciju
            // 
            this.btnUkloniRezervaciju.BackColor = System.Drawing.SystemColors.Info;
            this.btnUkloniRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloniRezervaciju.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUkloniRezervaciju.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUkloniRezervaciju.Location = new System.Drawing.Point(1315, 741);
            this.btnUkloniRezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnUkloniRezervaciju.Name = "btnUkloniRezervaciju";
            this.btnUkloniRezervaciju.Size = new System.Drawing.Size(287, 59);
            this.btnUkloniRezervaciju.TabIndex = 35;
            this.btnUkloniRezervaciju.Text = "Ukloni rezervaciju";
            this.btnUkloniRezervaciju.UseVisualStyleBackColor = false;
            this.btnUkloniRezervaciju.Click += new System.EventHandler(this.btnUkloniRezervaciju_Click);
            // 
            // dgvRezervacije
            // 
            this.dgvRezervacije.AllowUserToAddRows = false;
            this.dgvRezervacije.AllowUserToDeleteRows = false;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Location = new System.Drawing.Point(1315, 473);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.ReadOnly = true;
            this.dgvRezervacije.Size = new System.Drawing.Size(287, 260);
            this.dgvRezervacije.TabIndex = 34;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.SystemColors.Info;
            this.btnRezervisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervisi.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRezervisi.Location = new System.Drawing.Point(1315, 343);
            this.btnRezervisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(287, 59);
            this.btnRezervisi.TabIndex = 33;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // lblPrisustvuju
            // 
            this.lblPrisustvuju.AutoSize = true;
            this.lblPrisustvuju.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrisustvuju.Location = new System.Drawing.Point(1314, 29);
            this.lblPrisustvuju.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrisustvuju.Name = "lblPrisustvuju";
            this.lblPrisustvuju.Size = new System.Drawing.Size(79, 24);
            this.lblPrisustvuju.TabIndex = 2;
            this.lblPrisustvuju.Text = "Izlozbe:";
            // 
            // dgvIzlozbe
            // 
            this.dgvIzlozbe.AllowUserToAddRows = false;
            this.dgvIzlozbe.AllowUserToDeleteRows = false;
            this.dgvIzlozbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzlozbe.Location = new System.Drawing.Point(1315, 76);
            this.dgvIzlozbe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIzlozbe.Name = "dgvIzlozbe";
            this.dgvIzlozbe.ReadOnly = true;
            this.dgvIzlozbe.Size = new System.Drawing.Size(287, 260);
            this.dgvIzlozbe.TabIndex = 1;
            // 
            // dgvMarkice
            // 
            this.dgvMarkice.AllowUserToAddRows = false;
            this.dgvMarkice.AllowUserToDeleteRows = false;
            this.dgvMarkice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMarkice.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvMarkice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkice.Location = new System.Drawing.Point(23, 30);
            this.dgvMarkice.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarkice.Name = "dgvMarkice";
            this.dgvMarkice.ReadOnly = true;
            this.dgvMarkice.Size = new System.Drawing.Size(1283, 774);
            this.dgvMarkice.TabIndex = 0;
            this.dgvMarkice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkice_CellDoubleClick);
            // 
            // FrmKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 830);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblLupa);
            this.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKorisnik";
            this.Text = "Korisnicka forma";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzlozbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izlozbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMarkice;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Label lblPrisustvuju;
        private System.Windows.Forms.DataGridView dgvIzlozbe;
        private System.Windows.Forms.Button btnUkloniRezervaciju;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem izlozbaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem udjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izadjiToolStripMenuItem;
    }
}