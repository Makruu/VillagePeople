namespace VillagePeople
{
    partial class Raportit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportit));
            this.btnPalauta = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.cbToimipiste = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgRaportti = new System.Windows.Forms.DataGridView();
            this.cbTyyppi = new System.Windows.Forms.ComboBox();
            this.dtpAlkaen = new System.Windows.Forms.DateTimePicker();
            this.dtpPaattyen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgYhteenveto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaportti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYhteenveto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPalauta
            // 
            this.btnPalauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPalauta.Location = new System.Drawing.Point(691, 560);
            this.btnPalauta.Name = "btnPalauta";
            this.btnPalauta.Size = new System.Drawing.Size(75, 23);
            this.btnPalauta.TabIndex = 6;
            this.btnPalauta.Text = "Sulje";
            this.btnPalauta.UseVisualStyleBackColor = true;
            this.btnPalauta.Click += new System.EventHandler(this.btnPalauta_Click);
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHae.Location = new System.Drawing.Point(691, 531);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 5;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // cbToimipiste
            // 
            this.cbToimipiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbToimipiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToimipiste.FormattingEnabled = true;
            this.cbToimipiste.Location = new System.Drawing.Point(119, 558);
            this.cbToimipiste.Name = "cbToimipiste";
            this.cbToimipiste.Size = new System.Drawing.Size(165, 21);
            this.cbToimipiste.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Toimipiste";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Majoitus/lisäpalvelu";
            // 
            // dgRaportti
            // 
            this.dgRaportti.AllowUserToAddRows = false;
            this.dgRaportti.AllowUserToDeleteRows = false;
            this.dgRaportti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRaportti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRaportti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaportti.Location = new System.Drawing.Point(12, 40);
            this.dgRaportti.MultiSelect = false;
            this.dgRaportti.Name = "dgRaportti";
            this.dgRaportti.ReadOnly = true;
            this.dgRaportti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRaportti.Size = new System.Drawing.Size(766, 420);
            this.dgRaportti.TabIndex = 7;
            // 
            // cbTyyppi
            // 
            this.cbTyyppi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTyyppi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTyyppi.FormattingEnabled = true;
            this.cbTyyppi.Location = new System.Drawing.Point(119, 530);
            this.cbTyyppi.Name = "cbTyyppi";
            this.cbTyyppi.Size = new System.Drawing.Size(165, 21);
            this.cbTyyppi.TabIndex = 1;
            // 
            // dtpAlkaen
            // 
            this.dtpAlkaen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlkaen.Location = new System.Drawing.Point(376, 531);
            this.dtpAlkaen.Name = "dtpAlkaen";
            this.dtpAlkaen.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkaen.TabIndex = 3;
            // 
            // dtpPaattyen
            // 
            this.dtpPaattyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpPaattyen.Location = new System.Drawing.Point(376, 558);
            this.dtpPaattyen.Name = "dtpPaattyen";
            this.dtpPaattyen.Size = new System.Drawing.Size(200, 20);
            this.dtpPaattyen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Alkaen";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Päättyen";
            // 
            // dgYhteenveto
            // 
            this.dgYhteenveto.AllowUserToAddRows = false;
            this.dgYhteenveto.AllowUserToDeleteRows = false;
            this.dgYhteenveto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgYhteenveto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYhteenveto.Location = new System.Drawing.Point(12, 479);
            this.dgYhteenveto.Name = "dgYhteenveto";
            this.dgYhteenveto.ReadOnly = true;
            this.dgYhteenveto.Size = new System.Drawing.Size(766, 45);
            this.dgYhteenveto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Yhteenveto";
            // 
            // Raportit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgYhteenveto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPaattyen);
            this.Controls.Add(this.dtpAlkaen);
            this.Controls.Add(this.cbTyyppi);
            this.Controls.Add(this.btnPalauta);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.cbToimipiste);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgRaportti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "Raportit";
            this.Text = "Village People Oy | Raportit";
            ((System.ComponentModel.ISupportInitialize)(this.dgRaportti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgYhteenveto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalauta;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ComboBox cbToimipiste;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgRaportti;
        private System.Windows.Forms.ComboBox cbTyyppi;
        private System.Windows.Forms.DateTimePicker dtpAlkaen;
        private System.Windows.Forms.DateTimePicker dtpPaattyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgYhteenveto;
        private System.Windows.Forms.Label label3;
    }
}