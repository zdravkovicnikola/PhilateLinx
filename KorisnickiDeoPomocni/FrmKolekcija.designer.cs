namespace KorisnickiInterfejs.Forme
{
    partial class FrmPopuniKolekciju
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
            this.dgvZaSearch = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.btnPromadji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaSearch
            // 
            this.dgvZaSearch.AllowUserToAddRows = false;
            this.dgvZaSearch.AllowUserToDeleteRows = false;
            this.dgvZaSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaSearch.Location = new System.Drawing.Point(12, 44);
            this.dgvZaSearch.Name = "dgvZaSearch";
            this.dgvZaSearch.ReadOnly = true;
            this.dgvZaSearch.Size = new System.Drawing.Size(640, 413);
            this.dgvZaSearch.TabIndex = 33;
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.Info;
            this.txtNaziv.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNaziv.Location = new System.Drawing.Point(12, 12);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '*';
            this.txtNaziv.Size = new System.Drawing.Size(297, 26);
            this.txtNaziv.TabIndex = 34;
            // 
            // lblLupa
            // 
            this.lblLupa.AutoSize = true;
            this.lblLupa.BackColor = System.Drawing.Color.Transparent;
            this.lblLupa.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLupa.Location = new System.Drawing.Point(315, 12);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(32, 24);
            this.lblLupa.TabIndex = 35;
            this.lblLupa.Text = "🔍";
            // 
            // btnPromadji
            // 
            this.btnPromadji.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromadji.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPromadji.Location = new System.Drawing.Point(353, 12);
            this.btnPromadji.Name = "btnPromadji";
            this.btnPromadji.Size = new System.Drawing.Size(140, 26);
            this.btnPromadji.TabIndex = 36;
            this.btnPromadji.Text = "Pronadji";
            this.btnPromadji.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.Location = new System.Drawing.Point(511, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(140, 26);
            this.btnDodaj.TabIndex = 37;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // FrmPopuniKolekciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 469);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPromadji);
            this.Controls.Add(this.lblLupa);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvZaSearch);
            this.Name = "FrmPopuniKolekciju";
            this.Text = "FrmPopuniKolekciju";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaSearch;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Button btnPromadji;
        private System.Windows.Forms.Button btnDodaj;
    }
}