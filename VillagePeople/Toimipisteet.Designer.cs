namespace VillagePeople
{
    partial class Toimipisteet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toimipisteet));
            this.tcToimipisteet = new System.Windows.Forms.TabControl();
            this.tabToimipisteet = new System.Windows.Forms.TabPage();
            this.btnPalauta = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.cbKriteeri = new System.Windows.Forms.ComboBox();
            this.txtHakusana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.dgToimipisteet = new System.Windows.Forms.DataGridView();
            this.tabLisaaMuokkaa = new System.Windows.Forms.TabPage();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.txtPuhnro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.txtPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txtLahiosoite = new System.Windows.Forms.TextBox();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcToimipisteet.SuspendLayout();
            this.tabToimipisteet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).BeginInit();
            this.tabLisaaMuokkaa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcToimipisteet
            // 
            this.tcToimipisteet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcToimipisteet.Controls.Add(this.tabToimipisteet);
            this.tcToimipisteet.Controls.Add(this.tabLisaaMuokkaa);
            this.tcToimipisteet.Location = new System.Drawing.Point(4, 3);
            this.tcToimipisteet.Name = "tcToimipisteet";
            this.tcToimipisteet.SelectedIndex = 0;
            this.tcToimipisteet.Size = new System.Drawing.Size(818, 452);
            this.tcToimipisteet.TabIndex = 0;
            // 
            // tabToimipisteet
            // 
            this.tabToimipisteet.Controls.Add(this.btnPalauta);
            this.tabToimipisteet.Controls.Add(this.btnHae);
            this.tabToimipisteet.Controls.Add(this.cbKriteeri);
            this.tabToimipisteet.Controls.Add(this.txtHakusana);
            this.tabToimipisteet.Controls.Add(this.label8);
            this.tabToimipisteet.Controls.Add(this.label7);
            this.tabToimipisteet.Controls.Add(this.btnPoista);
            this.tabToimipisteet.Controls.Add(this.btnMuokkaa);
            this.tabToimipisteet.Controls.Add(this.dgToimipisteet);
            this.tabToimipisteet.Location = new System.Drawing.Point(4, 22);
            this.tabToimipisteet.Name = "tabToimipisteet";
            this.tabToimipisteet.Padding = new System.Windows.Forms.Padding(3);
            this.tabToimipisteet.Size = new System.Drawing.Size(810, 426);
            this.tabToimipisteet.TabIndex = 0;
            this.tabToimipisteet.Text = "Toimipisteet";
            this.tabToimipisteet.UseVisualStyleBackColor = true;
            // 
            // btnPalauta
            // 
            this.btnPalauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPalauta.Location = new System.Drawing.Point(247, 397);
            this.btnPalauta.Name = "btnPalauta";
            this.btnPalauta.Size = new System.Drawing.Size(75, 23);
            this.btnPalauta.TabIndex = 8;
            this.btnPalauta.Text = "Palauta";
            this.btnPalauta.UseVisualStyleBackColor = true;
            this.btnPalauta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(247, 371);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 6;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // cbKriteeri
            // 
            this.cbKriteeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKriteeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKriteeri.FormattingEnabled = true;
            this.cbKriteeri.Location = new System.Drawing.Point(76, 399);
            this.cbKriteeri.Name = "cbKriteeri";
            this.cbKriteeri.Size = new System.Drawing.Size(165, 21);
            this.cbKriteeri.TabIndex = 7;
            // 
            // txtHakusana
            // 
            this.txtHakusana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHakusana.Location = new System.Drawing.Point(76, 373);
            this.txtHakusana.Name = "txtHakusana";
            this.txtHakusana.Size = new System.Drawing.Size(165, 20);
            this.txtHakusana.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hakukriteeri";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hakusana";
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(729, 397);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 10;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuokkaa.Location = new System.Drawing.Point(729, 371);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 9;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // dgToimipisteet
            // 
            this.dgToimipisteet.AllowUserToAddRows = false;
            this.dgToimipisteet.AllowUserToDeleteRows = false;
            this.dgToimipisteet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgToimipisteet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgToimipisteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToimipisteet.Location = new System.Drawing.Point(7, 7);
            this.dgToimipisteet.MultiSelect = false;
            this.dgToimipisteet.Name = "dgToimipisteet";
            this.dgToimipisteet.ReadOnly = true;
            this.dgToimipisteet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgToimipisteet.Size = new System.Drawing.Size(797, 358);
            this.dgToimipisteet.TabIndex = 0;
            // 
            // tabLisaaMuokkaa
            // 
            this.tabLisaaMuokkaa.Controls.Add(this.btnPeruuta);
            this.tabLisaaMuokkaa.Controls.Add(this.btnTallenna);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPuhnro);
            this.tabLisaaMuokkaa.Controls.Add(this.txtEmail);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPostinro);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPostitoimipaikka);
            this.tabLisaaMuokkaa.Controls.Add(this.txtLahiosoite);
            this.tabLisaaMuokkaa.Controls.Add(this.txtNimi);
            this.tabLisaaMuokkaa.Controls.Add(this.label6);
            this.tabLisaaMuokkaa.Controls.Add(this.label5);
            this.tabLisaaMuokkaa.Controls.Add(this.label4);
            this.tabLisaaMuokkaa.Controls.Add(this.label3);
            this.tabLisaaMuokkaa.Controls.Add(this.label2);
            this.tabLisaaMuokkaa.Controls.Add(this.label1);
            this.tabLisaaMuokkaa.Location = new System.Drawing.Point(4, 22);
            this.tabLisaaMuokkaa.Name = "tabLisaaMuokkaa";
            this.tabLisaaMuokkaa.Padding = new System.Windows.Forms.Padding(3);
            this.tabLisaaMuokkaa.Size = new System.Drawing.Size(810, 426);
            this.tabLisaaMuokkaa.TabIndex = 1;
            this.tabLisaaMuokkaa.Text = "Lisää/Muokkaa";
            this.tabLisaaMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(282, 290);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(100, 23);
            this.btnPeruuta.TabIndex = 13;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(176, 290);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(100, 23);
            this.btnTallenna.TabIndex = 12;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // txtPuhnro
            // 
            this.txtPuhnro.Location = new System.Drawing.Point(176, 230);
            this.txtPuhnro.MaxLength = 15;
            this.txtPuhnro.Name = "txtPuhnro";
            this.txtPuhnro.Size = new System.Drawing.Size(434, 20);
            this.txtPuhnro.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 190);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(176, 111);
            this.txtPostinro.MaxLength = 5;
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(434, 20);
            this.txtPostinro.TabIndex = 8;
            // 
            // txtPostitoimipaikka
            // 
            this.txtPostitoimipaikka.Location = new System.Drawing.Point(176, 150);
            this.txtPostitoimipaikka.MaxLength = 30;
            this.txtPostitoimipaikka.Name = "txtPostitoimipaikka";
            this.txtPostitoimipaikka.Size = new System.Drawing.Size(434, 20);
            this.txtPostitoimipaikka.TabIndex = 9;
            // 
            // txtLahiosoite
            // 
            this.txtLahiosoite.Location = new System.Drawing.Point(176, 70);
            this.txtLahiosoite.MaxLength = 40;
            this.txtLahiosoite.Name = "txtLahiosoite";
            this.txtLahiosoite.Size = new System.Drawing.Size(434, 20);
            this.txtLahiosoite.TabIndex = 7;
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(176, 30);
            this.txtNimi.MaxLength = 40;
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(434, 20);
            this.txtNimi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Puhelinnumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postinumero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postitoimipaikka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lähiosoite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toimipisteen nimi";
            // 
            // Toimipisteet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.tcToimipisteet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 500);
            this.Name = "Toimipisteet";
            this.Text = "Village People Oy | Toimipisteet";
            this.tcToimipisteet.ResumeLayout(false);
            this.tabToimipisteet.ResumeLayout(false);
            this.tabToimipisteet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgToimipisteet)).EndInit();
            this.tabLisaaMuokkaa.ResumeLayout(false);
            this.tabLisaaMuokkaa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcToimipisteet;
        private System.Windows.Forms.TabPage tabToimipisteet;
        private System.Windows.Forms.DataGridView dgToimipisteet;
        private System.Windows.Forms.TabPage tabLisaaMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.TextBox txtPuhnro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostinro;
        private System.Windows.Forms.TextBox txtPostitoimipaikka;
        private System.Windows.Forms.TextBox txtLahiosoite;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHakusana;
        private System.Windows.Forms.ComboBox cbKriteeri;
        private System.Windows.Forms.Button btnPalauta;
        private System.Windows.Forms.Button btnHae;
    }
}