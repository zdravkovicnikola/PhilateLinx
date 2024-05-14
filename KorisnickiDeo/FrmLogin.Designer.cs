namespace KorisnickiDeo
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
            this.pomocniMeni = new System.Windows.Forms.MenuStrip();
            this.nemasNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrujSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pomocniMeni.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pomocniMeni
            // 
            this.pomocniMeni.BackColor = System.Drawing.Color.Transparent;
            this.pomocniMeni.Dock = System.Windows.Forms.DockStyle.None;
            this.pomocniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nemasNalogToolStripMenuItem});
            this.pomocniMeni.Location = new System.Drawing.Point(441, 518);
            this.pomocniMeni.Name = "pomocniMeni";
            this.pomocniMeni.Size = new System.Drawing.Size(151, 32);
            this.pomocniMeni.TabIndex = 1;
            this.pomocniMeni.Text = "menuStrip1";
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
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pomocniMeni);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(582, 550);
            this.pnlLogin.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 550);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLogin";
            this.Text = "Upitna forma";
            this.pomocniMeni.ResumeLayout(false);
            this.pomocniMeni.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip pomocniMeni;
        private System.Windows.Forms.ToolStripMenuItem nemasNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrujSeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLogin;
    }
}

