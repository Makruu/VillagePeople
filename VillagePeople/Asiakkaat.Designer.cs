namespace VillagePeople
{
    partial class Asiakkaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asiakkaat));
            this.tcAsiakkaat = new System.Windows.Forms.TabControl();
            this.tabAsiakkaat = new System.Windows.Forms.TabPage();
            this.btnPalauta = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.cbKriteeri = new System.Windows.Forms.ComboBox();
            this.txtHakusana = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.dgAsiakkaat = new System.Windows.Forms.DataGridView();
            this.tabLisaaMuokkaa = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuhelinnro = new System.Windows.Forms.TextBox();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.txtPostitoimipaikka = new System.Windows.Forms.TextBox();
            this.txtLahiosoite = new System.Windows.Forms.TextBox();
            this.txtSukunimi = new System.Windows.Forms.TextBox();
            this.txtEtunimi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcAsiakkaat.SuspendLayout();
            this.tabAsiakkaat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).BeginInit();
            this.tabLisaaMuokkaa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAsiakkaat
            // 
            this.tcAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAsiakkaat.Controls.Add(this.tabAsiakkaat);
            this.tcAsiakkaat.Controls.Add(this.tabLisaaMuokkaa);
            this.tcAsiakkaat.Location = new System.Drawing.Point(3, 5);
            this.tcAsiakkaat.Name = "tcAsiakkaat";
            this.tcAsiakkaat.SelectedIndex = 0;
            this.tcAsiakkaat.Size = new System.Drawing.Size(794, 441);
            this.tcAsiakkaat.TabIndex = 1;
            // 
            // tabAsiakkaat
            // 
            this.tabAsiakkaat.Controls.Add(this.btnPalauta);
            this.tabAsiakkaat.Controls.Add(this.btnHae);
            this.tabAsiakkaat.Controls.Add(this.cbKriteeri);
            this.tabAsiakkaat.Controls.Add(this.txtHakusana);
            this.tabAsiakkaat.Controls.Add(this.label8);
            this.tabAsiakkaat.Controls.Add(this.label9);
            this.tabAsiakkaat.Controls.Add(this.btnPoista);
            this.tabAsiakkaat.Controls.Add(this.btnMuokkaa);
            this.tabAsiakkaat.Controls.Add(this.dgAsiakkaat);
            this.tabAsiakkaat.Location = new System.Drawing.Point(4, 22);
            this.tabAsiakkaat.Name = "tabAsiakkaat";
            this.tabAsiakkaat.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsiakkaat.Size = new System.Drawing.Size(786, 415);
            this.tabAsiakkaat.TabIndex = 0;
            this.tabAsiakkaat.Text = "Asiakkaat";
            this.tabAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // btnPalauta
            // 
            this.btnPalauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPalauta.Location = new System.Drawing.Point(243, 386);
            this.btnPalauta.Name = "btnPalauta";
            this.btnPalauta.Size = new System.Drawing.Size(75, 23);
            this.btnPalauta.TabIndex = 14;
            this.btnPalauta.Text = "Palauta";
            this.btnPalauta.UseVisualStyleBackColor = true;
            this.btnPalauta.Click += new System.EventHandler(this.BtnPalauta_Click);
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(243, 362);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 12;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.BtnHae_Click);
            // 
            // cbKriteeri
            // 
            this.cbKriteeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKriteeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKriteeri.FormattingEnabled = true;
            this.cbKriteeri.Location = new System.Drawing.Point(72, 388);
            this.cbKriteeri.Name = "cbKriteeri";
            this.cbKriteeri.Size = new System.Drawing.Size(165, 21);
            this.cbKriteeri.TabIndex = 13;
            // 
            // txtHakusana
            // 
            this.txtHakusana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHakusana.Location = new System.Drawing.Point(72, 364);
            this.txtHakusana.Name = "txtHakusana";
            this.txtHakusana.Size = new System.Drawing.Size(165, 20);
            this.txtHakusana.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hakukriteeri";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hakusana";
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoista.Location = new System.Drawing.Point(705, 386);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 16;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuokkaa.Location = new System.Drawing.Point(705, 362);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(75, 23);
            this.btnMuokkaa.TabIndex = 15;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.BtnMuokkaa_Click);
            // 
            // dgAsiakkaat
            // 
            this.dgAsiakkaat.AllowUserToAddRows = false;
            this.dgAsiakkaat.AllowUserToDeleteRows = false;
            this.dgAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsiakkaat.Location = new System.Drawing.Point(7, 7);
            this.dgAsiakkaat.MultiSelect = false;
            this.dgAsiakkaat.Name = "dgAsiakkaat";
            this.dgAsiakkaat.ReadOnly = true;
            this.dgAsiakkaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsiakkaat.Size = new System.Drawing.Size(773, 352);
            this.dgAsiakkaat.TabIndex = 0;
            // 
            // tabLisaaMuokkaa
            // 
            this.tabLisaaMuokkaa.Controls.Add(this.label7);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPuhelinnro);
            this.tabLisaaMuokkaa.Controls.Add(this.btnPeruuta);
            this.tabLisaaMuokkaa.Controls.Add(this.btnTallenna);
            this.tabLisaaMuokkaa.Controls.Add(this.txtEmail);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPostinro);
            this.tabLisaaMuokkaa.Controls.Add(this.txtPostitoimipaikka);
            this.tabLisaaMuokkaa.Controls.Add(this.txtLahiosoite);
            this.tabLisaaMuokkaa.Controls.Add(this.txtSukunimi);
            this.tabLisaaMuokkaa.Controls.Add(this.txtEtunimi);
            this.tabLisaaMuokkaa.Controls.Add(this.label6);
            this.tabLisaaMuokkaa.Controls.Add(this.label5);
            this.tabLisaaMuokkaa.Controls.Add(this.label4);
            this.tabLisaaMuokkaa.Controls.Add(this.label3);
            this.tabLisaaMuokkaa.Controls.Add(this.label2);
            this.tabLisaaMuokkaa.Controls.Add(this.label1);
            this.tabLisaaMuokkaa.Location = new System.Drawing.Point(4, 22);
            this.tabLisaaMuokkaa.Name = "tabLisaaMuokkaa";
            this.tabLisaaMuokkaa.Padding = new System.Windows.Forms.Padding(3);
            this.tabLisaaMuokkaa.Size = new System.Drawing.Size(786, 415);
            this.tabLisaaMuokkaa.TabIndex = 1;
            this.tabLisaaMuokkaa.Text = "Lisää/Muokkaa";
            this.tabLisaaMuokkaa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Puhelinnumero";
            // 
            // txtPuhelinnro
            // 
            this.txtPuhelinnro.Location = new System.Drawing.Point(176, 265);
            this.txtPuhelinnro.MaxLength = 10;
            this.txtPuhelinnro.Name = "txtPuhelinnro";
            this.txtPuhelinnro.Size = new System.Drawing.Size(434, 20);
            this.txtPuhelinnro.TabIndex = 12;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(282, 319);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(100, 23);
            this.btnPeruuta.TabIndex = 13;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.BtnPeruuta_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(176, 319);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(100, 23);
            this.btnTallenna.TabIndex = 12;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.BtnTallenna_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(176, 230);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(176, 190);
            this.txtPostinro.MaxLength = 5;
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(434, 20);
            this.txtPostinro.TabIndex = 10;
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
            this.txtLahiosoite.Location = new System.Drawing.Point(176, 110);
            this.txtLahiosoite.MaxLength = 40;
            this.txtLahiosoite.Name = "txtLahiosoite";
            this.txtLahiosoite.Size = new System.Drawing.Size(434, 20);
            this.txtLahiosoite.TabIndex = 8;
            // 
            // txtSukunimi
            // 
            this.txtSukunimi.Location = new System.Drawing.Point(176, 70);
            this.txtSukunimi.MaxLength = 40;
            this.txtSukunimi.Name = "txtSukunimi";
            this.txtSukunimi.Size = new System.Drawing.Size(434, 20);
            this.txtSukunimi.TabIndex = 7;
            // 
            // txtEtunimi
            // 
            this.txtEtunimi.Location = new System.Drawing.Point(176, 30);
            this.txtEtunimi.MaxLength = 20;
            this.txtEtunimi.Name = "txtEtunimi";
            this.txtEtunimi.Size = new System.Drawing.Size(434, 20);
            this.txtEtunimi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postinumero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postitoimipaikka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lähiosoite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi";
            // 
            // Asiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAsiakkaat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Asiakkaat";
            this.Text = "Village People Oy | Asiakkaat";
            this.tcAsiakkaat.ResumeLayout(false);
            this.tabAsiakkaat.ResumeLayout(false);
            this.tabAsiakkaat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsiakkaat)).EndInit();
            this.tabLisaaMuokkaa.ResumeLayout(false);
            this.tabLisaaMuokkaa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAsiakkaat;
        private System.Windows.Forms.TabPage tabAsiakkaat;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.DataGridView dgAsiakkaat;
        private System.Windows.Forms.TabPage tabLisaaMuokkaa;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostinro;
        private System.Windows.Forms.TextBox txtPostitoimipaikka;
        private System.Windows.Forms.TextBox txtLahiosoite;
        private System.Windows.Forms.TextBox txtSukunimi;
        private System.Windows.Forms.TextBox txtEtunimi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuhelinnro;
        private System.Windows.Forms.Button btnPalauta;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ComboBox cbKriteeri;
        private System.Windows.Forms.TextBox txtHakusana;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}