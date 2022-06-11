namespace VillagePeople
{
    partial class Laskut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laskut));
            this.tcLaskut = new System.Windows.Forms.TabControl();
            this.tabLaskut = new System.Windows.Forms.TabPage();
            this.cbPvmKriteeri = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateHaku = new System.Windows.Forms.DateTimePicker();
            this.btnAvaa = new System.Windows.Forms.Button();
            this.btnPalauta = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.cbKriteeri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHakusana = new System.Windows.Forms.TextBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgLaskut = new System.Windows.Forms.DataGridView();
            this.tabUusiLasku = new System.Windows.Forms.TabPage();
            this.txtPostitmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPostinro = new System.Windows.Forms.TextBox();
            this.txtLahiosoite = new System.Windows.Forms.TextBox();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.cbVaraus = new System.Windows.Forms.ComboBox();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcLaskut.SuspendLayout();
            this.tabLaskut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskut)).BeginInit();
            this.tabUusiLasku.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLaskut
            // 
            this.tcLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcLaskut.Controls.Add(this.tabLaskut);
            this.tcLaskut.Controls.Add(this.tabUusiLasku);
            this.tcLaskut.Location = new System.Drawing.Point(3, 4);
            this.tcLaskut.Name = "tcLaskut";
            this.tcLaskut.SelectedIndex = 0;
            this.tcLaskut.Size = new System.Drawing.Size(818, 513);
            this.tcLaskut.TabIndex = 2;
            // 
            // tabLaskut
            // 
            this.tabLaskut.Controls.Add(this.cbPvmKriteeri);
            this.tabLaskut.Controls.Add(this.label10);
            this.tabLaskut.Controls.Add(this.label4);
            this.tabLaskut.Controls.Add(this.dateHaku);
            this.tabLaskut.Controls.Add(this.btnAvaa);
            this.tabLaskut.Controls.Add(this.btnPalauta);
            this.tabLaskut.Controls.Add(this.btnHae);
            this.tabLaskut.Controls.Add(this.cbKriteeri);
            this.tabLaskut.Controls.Add(this.label8);
            this.tabLaskut.Controls.Add(this.label7);
            this.tabLaskut.Controls.Add(this.txtHakusana);
            this.tabLaskut.Controls.Add(this.btnPoista);
            this.tabLaskut.Controls.Add(this.dgLaskut);
            this.tabLaskut.Location = new System.Drawing.Point(4, 22);
            this.tabLaskut.Name = "tabLaskut";
            this.tabLaskut.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaskut.Size = new System.Drawing.Size(810, 487);
            this.tabLaskut.TabIndex = 0;
            this.tabLaskut.Text = "Laskut";
            this.tabLaskut.UseVisualStyleBackColor = true;
            // 
            // cbPvmKriteeri
            // 
            this.cbPvmKriteeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPvmKriteeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPvmKriteeri.FormattingEnabled = true;
            this.cbPvmKriteeri.Location = new System.Drawing.Point(308, 434);
            this.cbPvmKriteeri.Name = "cbPvmKriteeri";
            this.cbPvmKriteeri.Size = new System.Drawing.Size(165, 21);
            this.cbPvmKriteeri.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kriteeri 2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Päivämäärä";
            // 
            // dateHaku
            // 
            this.dateHaku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateHaku.CustomFormat = "dd/MM/yyyy";
            this.dateHaku.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHaku.Location = new System.Drawing.Point(308, 461);
            this.dateHaku.Name = "dateHaku";
            this.dateHaku.Size = new System.Drawing.Size(165, 20);
            this.dateHaku.TabIndex = 13;
            // 
            // btnAvaa
            // 
            this.btnAvaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvaa.Location = new System.Drawing.Point(728, 432);
            this.btnAvaa.Name = "btnAvaa";
            this.btnAvaa.Size = new System.Drawing.Size(75, 23);
            this.btnAvaa.TabIndex = 16;
            this.btnAvaa.Text = "Avaa lasku";
            this.btnAvaa.UseVisualStyleBackColor = true;
            this.btnAvaa.Click += new System.EventHandler(this.btnAvaa_Click);
            // 
            // btnPalauta
            // 
            this.btnPalauta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPalauta.Location = new System.Drawing.Point(479, 459);
            this.btnPalauta.Name = "btnPalauta";
            this.btnPalauta.Size = new System.Drawing.Size(75, 23);
            this.btnPalauta.TabIndex = 15;
            this.btnPalauta.Text = "Palauta";
            this.btnPalauta.UseVisualStyleBackColor = true;
            this.btnPalauta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(479, 432);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 14;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // cbKriteeri
            // 
            this.cbKriteeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbKriteeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKriteeri.FormattingEnabled = true;
            this.cbKriteeri.Location = new System.Drawing.Point(68, 434);
            this.cbKriteeri.Name = "cbKriteeri";
            this.cbKriteeri.Size = new System.Drawing.Size(165, 21);
            this.cbKriteeri.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kriteeri";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hakusana";
            // 
            // txtHakusana
            // 
            this.txtHakusana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHakusana.Location = new System.Drawing.Point(68, 461);
            this.txtHakusana.Name = "txtHakusana";
            this.txtHakusana.Size = new System.Drawing.Size(165, 20);
            this.txtHakusana.TabIndex = 11;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoista.Location = new System.Drawing.Point(728, 459);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 17;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgLaskut
            // 
            this.dgLaskut.AllowUserToAddRows = false;
            this.dgLaskut.AllowUserToDeleteRows = false;
            this.dgLaskut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgLaskut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLaskut.Location = new System.Drawing.Point(7, 7);
            this.dgLaskut.MultiSelect = false;
            this.dgLaskut.Name = "dgLaskut";
            this.dgLaskut.ReadOnly = true;
            this.dgLaskut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLaskut.Size = new System.Drawing.Size(797, 419);
            this.dgLaskut.TabIndex = 0;
            // 
            // tabUusiLasku
            // 
            this.tabUusiLasku.Controls.Add(this.txtPostitmp);
            this.tabUusiLasku.Controls.Add(this.label9);
            this.tabUusiLasku.Controls.Add(this.txtPostinro);
            this.tabUusiLasku.Controls.Add(this.txtLahiosoite);
            this.tabUusiLasku.Controls.Add(this.txtNimi);
            this.tabUusiLasku.Controls.Add(this.cbVaraus);
            this.tabUusiLasku.Controls.Add(this.btnPeruuta);
            this.tabUusiLasku.Controls.Add(this.btnLisaa);
            this.tabUusiLasku.Controls.Add(this.label6);
            this.tabUusiLasku.Controls.Add(this.label5);
            this.tabUusiLasku.Controls.Add(this.label3);
            this.tabUusiLasku.Controls.Add(this.label2);
            this.tabUusiLasku.Controls.Add(this.label1);
            this.tabUusiLasku.Location = new System.Drawing.Point(4, 22);
            this.tabUusiLasku.Name = "tabUusiLasku";
            this.tabUusiLasku.Padding = new System.Windows.Forms.Padding(3);
            this.tabUusiLasku.Size = new System.Drawing.Size(810, 487);
            this.tabUusiLasku.TabIndex = 1;
            this.tabUusiLasku.Text = "Uusi lasku";
            this.tabUusiLasku.UseVisualStyleBackColor = true;
            // 
            // txtPostitmp
            // 
            this.txtPostitmp.Location = new System.Drawing.Point(176, 217);
            this.txtPostitmp.MaxLength = 30;
            this.txtPostitmp.Name = "txtPostitmp";
            this.txtPostitmp.Size = new System.Drawing.Size(300, 20);
            this.txtPostitmp.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Postinumero";
            // 
            // txtPostinro
            // 
            this.txtPostinro.Location = new System.Drawing.Point(176, 180);
            this.txtPostinro.MaxLength = 5;
            this.txtPostinro.Name = "txtPostinro";
            this.txtPostinro.Size = new System.Drawing.Size(300, 20);
            this.txtPostinro.TabIndex = 18;
            // 
            // txtLahiosoite
            // 
            this.txtLahiosoite.Location = new System.Drawing.Point(176, 143);
            this.txtLahiosoite.MaxLength = 40;
            this.txtLahiosoite.Name = "txtLahiosoite";
            this.txtLahiosoite.Size = new System.Drawing.Size(300, 20);
            this.txtLahiosoite.TabIndex = 17;
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(176, 108);
            this.txtNimi.MaxLength = 60;
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(300, 20);
            this.txtNimi.TabIndex = 16;
            // 
            // cbVaraus
            // 
            this.cbVaraus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbVaraus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaraus.FormattingEnabled = true;
            this.cbVaraus.Location = new System.Drawing.Point(176, 34);
            this.cbVaraus.Name = "cbVaraus";
            this.cbVaraus.Size = new System.Drawing.Size(300, 21);
            this.cbVaraus.TabIndex = 15;
            this.cbVaraus.SelectionChangeCommitted += new System.EventHandler(this.cbVaraus_SelectionChangeCommitted);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Location = new System.Drawing.Point(282, 261);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(100, 23);
            this.btnPeruuta.TabIndex = 32;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(176, 261);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(100, 23);
            this.btnLisaa.TabIndex = 31;
            this.btnLisaa.Text = "Luo lasku";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Postitoimipaikka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lähiosoite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varaus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laskutustiedot";
            // 
            // Laskut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 519);
            this.Controls.Add(this.tcLaskut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(838, 558);
            this.Name = "Laskut";
            this.Text = "Village People Oy | Laskut";
            this.tcLaskut.ResumeLayout(false);
            this.tabLaskut.ResumeLayout(false);
            this.tabLaskut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLaskut)).EndInit();
            this.tabUusiLasku.ResumeLayout(false);
            this.tabUusiLasku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLaskut;
        private System.Windows.Forms.TabPage tabLaskut;
        private System.Windows.Forms.Button btnPalauta;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ComboBox cbKriteeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHakusana;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgLaskut;
        private System.Windows.Forms.TabPage tabUusiLasku;
        private System.Windows.Forms.ComboBox cbVaraus;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostitmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPostinro;
        private System.Windows.Forms.TextBox txtLahiosoite;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Button btnAvaa;
        private System.Windows.Forms.ComboBox cbPvmKriteeri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateHaku;
    }
}