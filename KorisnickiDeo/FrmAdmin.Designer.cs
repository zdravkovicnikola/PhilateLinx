namespace KorisnickiDeo
{
    partial class FrmAdmin
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
            this.lblLupa = new System.Windows.Forms.Label();
            this.dgvZaSearch = new System.Windows.Forms.DataGridView();
            this.kreirajMarkicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlozbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vidiSveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meni = new System.Windows.Forms.MenuStrip();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaSearch)).BeginInit();
            this.meni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.BackColor = System.Drawing.Color.Transparent;
            this.lblLupa.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLupa.ForeColor = System.Drawing.SystemColors.Info;
            this.lblLupa.Location = new System.Drawing.Point(304, 36);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 24);
            this.lblLupa.TabIndex = 38;
            this.lblLupa.Text = "🔍";
            // 
            // dgvZaSearch
            // 
            this.dgvZaSearch.AllowUserToAddRows = false;
            this.dgvZaSearch.AllowUserToDeleteRows = false;
            this.dgvZaSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaSearch.Location = new System.Drawing.Point(47, 68);
            this.dgvZaSearch.Name = "dgvZaSearch";
            this.dgvZaSearch.ReadOnly = true;
            this.dgvZaSearch.Size = new System.Drawing.Size(1202, 424);
            this.dgvZaSearch.TabIndex = 37;
            this.dgvZaSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaSearch_CellDoubleClick);
            // 
            // kreirajMarkicuToolStripMenuItem
            // 
            this.kreirajMarkicuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem,
            this.izmeniToolStripMenuItem});
            this.kreirajMarkicuToolStripMenuItem.Name = "kreirajMarkicuToolStripMenuItem";
            this.kreirajMarkicuToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.kreirajMarkicuToolStripMenuItem.Text = "Markica";
            // 
            // kreirajToolStripMenuItem
            // 
            this.kreirajToolStripMenuItem.Name = "kreirajToolStripMenuItem";
            this.kreirajToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.kreirajToolStripMenuItem.Text = "Kreiraj";
            this.kreirajToolStripMenuItem.Click += new System.EventHandler(this.kreirajToolStripMenuItem_Click);
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.izmeniToolStripMenuItem.Text = "Izmeni";
            this.izmeniToolStripMenuItem.Click += new System.EventHandler(this.izmeniToolStripMenuItem_Click);
            // 
            // izlozbaToolStripMenuItem
            // 
            this.izlozbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem1,
            this.vidiSveToolStripMenuItem});
            this.izlozbaToolStripMenuItem.Name = "izlozbaToolStripMenuItem";
            this.izlozbaToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.izlozbaToolStripMenuItem.Text = "Izlozba";
            // 
            // kreirajToolStripMenuItem1
            // 
            this.kreirajToolStripMenuItem1.Name = "kreirajToolStripMenuItem1";
            this.kreirajToolStripMenuItem1.Size = new System.Drawing.Size(151, 28);
            this.kreirajToolStripMenuItem1.Text = "Kreiraj";
            this.kreirajToolStripMenuItem1.Click += new System.EventHandler(this.kreirajToolStripMenuItem1_Click);
            // 
            // vidiSveToolStripMenuItem
            // 
            this.vidiSveToolStripMenuItem.Name = "vidiSveToolStripMenuItem";
            this.vidiSveToolStripMenuItem.Size = new System.Drawing.Size(151, 28);
            this.vidiSveToolStripMenuItem.Text = "Vidi sve";
            this.vidiSveToolStripMenuItem.Click += new System.EventHandler(this.vidiSveToolStripMenuItem_Click);
            // 
            // meni
            // 
            this.meni.BackColor = System.Drawing.SystemColors.Info;
            this.meni.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajMarkicuToolStripMenuItem,
            this.izlozbaToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.meni.Location = new System.Drawing.Point(0, 0);
            this.meni.Name = "meni";
            this.meni.Size = new System.Drawing.Size(1309, 32);
            this.meni.TabIndex = 32;
            this.meni.Text = "menuStrip1";
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSearch.Location = new System.Drawing.Point(47, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 26);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KorisnickiDeo.Properties.Resources.stamp_philately_vintage_frame_background_collecting_studying_postage_stamps_history_development_postal_communication_141811626;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 549);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblLupa);
            this.Controls.Add(this.meni);
            this.Controls.Add(this.dgvZaSearch);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaSearch)).EndInit();
            this.meni.ResumeLayout(false);
            this.meni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.DataGridView dgvZaSearch;
        private System.Windows.Forms.ToolStripMenuItem kreirajMarkicuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlozbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip meni;
        private System.Windows.Forms.ToolStripMenuItem vidiSveToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
    }
}