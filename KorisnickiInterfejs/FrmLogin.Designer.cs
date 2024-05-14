namespace KorisnickiInterfejs.Forme
{
    partial class FrmLogin
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
            this.pnlLoginFrm = new System.Windows.Forms.Panel();
            this.pomocniMeni = new System.Windows.Forms.MenuStrip();
            this.nemasNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrujSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLoginFrm.SuspendLayout();
            this.pomocniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginFrm
            // 
            this.pnlLoginFrm.Controls.Add(this.pomocniMeni);
            this.pnlLoginFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginFrm.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginFrm.Name = "pnlLoginFrm";
            this.pnlLoginFrm.Size = new System.Drawing.Size(615, 472);
            this.pnlLoginFrm.TabIndex = 0;
            // 
            // pomocniMeni
            // 
            this.pomocniMeni.BackColor = System.Drawing.Color.Transparent;
            this.pomocniMeni.Dock = System.Windows.Forms.DockStyle.None;
            this.pomocniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nemasNalogToolStripMenuItem});
            this.pomocniMeni.Location = new System.Drawing.Point(462, 440);
            this.pomocniMeni.Name = "pomocniMeni";
            this.pomocniMeni.Size = new System.Drawing.Size(151, 32);
            this.pomocniMeni.TabIndex = 0;
            this.pomocniMeni.Text = "menuStrip1";
            this.pomocniMeni.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.pomocniMeni_ItemClicked);
            // 
            // nemasNalogToolStripMenuItem
            // 
            this.nemasNalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrujSeToolStripMenuItem});
            this.nemasNalogToolStripMenuItem.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nemasNalogToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.nemasNalogToolStripMenuItem.Name = "nemasNalogToolStripMenuItem";
            this.nemasNalogToolStripMenuItem.Size = new System.Drawing.Size(143, 28);
            this.nemasNalogToolStripMenuItem.Text = "Nemas nalog?";
            // 
            // registrujSeToolStripMenuItem
            // 
            this.registrujSeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registrujSeToolStripMenuItem.Name = "registrujSeToolStripMenuItem";
            this.registrujSeToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.registrujSeToolStripMenuItem.Text = "Registruj se";
            this.registrujSeToolStripMenuItem.Click += new System.EventHandler(this.registrujSeToolStripMenuItem_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 472);
            this.Controls.Add(this.pnlLoginFrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.pomocniMeni;
            this.Name = "FrmLogin";
            this.Text = "Login forma";
            this.pnlLoginFrm.ResumeLayout(false);
            this.pnlLoginFrm.PerformLayout();
            this.pomocniMeni.ResumeLayout(false);
            this.pomocniMeni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginFrm;
        private System.Windows.Forms.MenuStrip pomocniMeni;
        private System.Windows.Forms.ToolStripMenuItem nemasNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrujSeToolStripMenuItem;
    }
}