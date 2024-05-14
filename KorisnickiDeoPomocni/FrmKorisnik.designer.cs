namespace KorisnickiInterfejs.Forme
{
    partial class FrmMain
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
            this.kolekcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.udjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlozbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLupa = new System.Windows.Forms.Label();
            this.lblPrisustvuju = new System.Windows.Forms.Label();
            this.dgvPrisustvo = new System.Windows.Forms.DataGridView();
            this.dgvMarkice = new System.Windows.Forms.DataGridView();
            this.pbOdabranaSlika = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabranaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolekcijaToolStripMenuItem,
            this.izlozbaToolStripMenuItem,
            this.pretraziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(26, 191);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(236, 103);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // kolekcijaToolStripMenuItem
            // 
            this.kolekcijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.udjiToolStripMenuItem,
            this.izmeniToolStripMenuItem});
            this.kolekcijaToolStripMenuItem.Name = "kolekcijaToolStripMenuItem";
            this.kolekcijaToolStripMenuItem.Size = new System.Drawing.Size(36, 99);
            this.kolekcijaToolStripMenuItem.Text = "Kolekcija";
            // 
            // udjiToolStripMenuItem
            // 
            this.udjiToolStripMenuItem.Name = "udjiToolStripMenuItem";
            this.udjiToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.udjiToolStripMenuItem.Text = "Udji";
            this.udjiToolStripMenuItem.Click += new System.EventHandler(this.udjiToolStripMenuItem_Click);
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.izmeniToolStripMenuItem.Text = "Izadji";
            // 
            // izlozbaToolStripMenuItem
            // 
            this.izlozbaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem});
            this.izlozbaToolStripMenuItem.Name = "izlozbaToolStripMenuItem";
            this.izlozbaToolStripMenuItem.Size = new System.Drawing.Size(36, 99);
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
            this.pretraziToolStripMenuItem.Size = new System.Drawing.Size(36, 99);
            this.pretraziToolStripMenuItem.Text = "Pretrazi";
            this.pretraziToolStripMenuItem.Click += new System.EventHandler(this.pretraziToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.lblLupa);
            this.pnlMain.Controls.Add(this.lblPrisustvuju);
            this.pnlMain.Controls.Add(this.dgvPrisustvo);
            this.pnlMain.Controls.Add(this.dgvMarkice);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(144, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1026, 562);
            this.pnlMain.TabIndex = 1;
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.BackColor = System.Drawing.Color.Transparent;
            this.lblLupa.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLupa.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLupa.Location = new System.Drawing.Point(3, 9);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 24);
            this.lblLupa.TabIndex = 32;
            this.lblLupa.Text = "🔍";
            // 
            // lblPrisustvuju
            // 
            this.lblPrisustvuju.AutoSize = true;
            this.lblPrisustvuju.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrisustvuju.Location = new System.Drawing.Point(767, 28);
            this.lblPrisustvuju.Name = "lblPrisustvuju";
            this.lblPrisustvuju.Size = new System.Drawing.Size(119, 24);
            this.lblPrisustvuju.TabIndex = 2;
            this.lblPrisustvuju.Text = "Prisustvuju:";
            // 
            // dgvPrisustvo
            // 
            this.dgvPrisustvo.AllowUserToAddRows = false;
            this.dgvPrisustvo.AllowUserToDeleteRows = false;
            this.dgvPrisustvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrisustvo.Location = new System.Drawing.Point(768, 66);
            this.dgvPrisustvo.Name = "dgvPrisustvo";
            this.dgvPrisustvo.ReadOnly = true;
            this.dgvPrisustvo.Size = new System.Drawing.Size(246, 484);
            this.dgvPrisustvo.TabIndex = 1;
            // 
            // dgvMarkice
            // 
            this.dgvMarkice.AllowUserToAddRows = false;
            this.dgvMarkice.AllowUserToDeleteRows = false;
            this.dgvMarkice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkice.Location = new System.Drawing.Point(41, 28);
            this.dgvMarkice.Name = "dgvMarkice";
            this.dgvMarkice.ReadOnly = true;
            this.dgvMarkice.Size = new System.Drawing.Size(704, 522);
            this.dgvMarkice.TabIndex = 0;
            // 
            // pbOdabranaSlika
            // 
            this.pbOdabranaSlika.Location = new System.Drawing.Point(26, 319);
            this.pbOdabranaSlika.Name = "pbOdabranaSlika";
            this.pbOdabranaSlika.Size = new System.Drawing.Size(116, 167);
            this.pbOdabranaSlika.TabIndex = 2;
            this.pbOdabranaSlika.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 562);
            this.Controls.Add(this.pbOdabranaSlika);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrisustvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOdabranaSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kolekcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem udjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlozbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvMarkice;
        private System.Windows.Forms.Label lblPrisustvuju;
        private System.Windows.Forms.DataGridView dgvPrisustvo;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.PictureBox pbOdabranaSlika;
    }
}