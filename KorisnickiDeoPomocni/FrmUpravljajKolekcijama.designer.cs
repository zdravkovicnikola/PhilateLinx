namespace Forme
{
    partial class FrmUpravljajKolekcijama
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(165, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 75);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Detalji";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.Info;
            this.txtNaziv.Font = new System.Drawing.Font("Bodoni MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNaziv.Location = new System.Drawing.Point(12, 69);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.PasswordChar = '*';
            this.txtNaziv.Size = new System.Drawing.Size(147, 75);
            this.txtNaziv.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Naziv";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.Info;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(12, 436);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 43);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 249);
            this.dataGridView1.TabIndex = 32;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.Info;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIzmeni.Location = new System.Drawing.Point(188, 436);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(106, 43);
            this.btnIzmeni.TabIndex = 33;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.Info;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(372, 436);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(106, 43);
            this.btnObrisi.TabIndex = 34;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // FrmUpravljajKolekcijama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 509);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUpravljajKolekcijama";
            this.Text = "FrmUpravljajKolekcijama";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}