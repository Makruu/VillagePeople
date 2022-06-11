namespace VillagePeople
{
    partial class VarauksenMuokkaus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VarauksenMuokkaus));
            this.tcVaraukset = new System.Windows.Forms.TabControl();
            this.tabMuokkaa = new System.Windows.Forms.TabPage();
            this.btnPoista = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgValitutPalvelut = new System.Windows.Forms.DataGridView();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.dateVarattulop = new System.Windows.Forms.DateTimePicker();
            this.dateVarattualk = new System.Windows.Forms.DateTimePicker();
            this.dateVarattu = new System.Windows.Forms.DateTimePicker();
            this.cbToimipiste = new System.Windows.Forms.ComboBox();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.btnSulje = new System.Windows.Forms.Button();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPalvelut = new System.Windows.Forms.TabPage();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.btnLisaaPalvelut = new System.Windows.Forms.Button();
            this.dgVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.Valittu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tcVaraukset.SuspendLayout();
            this.tabMuokkaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgValitutPalvelut)).BeginInit();
            this.tabPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVarauksenPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // tcVaraukset
            // 
            this.tcVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcVaraukset.Controls.Add(this.tabMuokkaa);
            this.tcVaraukset.Controls.Add(this.tabPalvelut);
            this.tcVaraukset.Location = new System.Drawing.Point(12, 11);
            this.tcVaraukset.Margin = new System.Windows.Forms.Padding(0);
            this.tcVaraukset.Name = "tcVaraukset";
            this.tcVaraukset.SelectedIndex = 0;
            this.tcVaraukset.Size = new System.Drawing.Size(1043, 532);
            this.tcVaraukset.TabIndex = 2;
            // 
            // tabMuokkaa
            // 
            this.tabMuokkaa.Controls.Add(this.btnPoista);
            this.tabMuokkaa.Controls.Add(this.label9);
            this.tabMuokkaa.Controls.Add(this.dgValitutPalvelut);
            this.tabMuokkaa.Controls.Add(this.btnPalvelut);
            this.tabMuokkaa.Controls.Add(this.dateVarattulop);
            this.tabMuokkaa.Controls.Add(this.dateVarattualk);
            this.tabMuokkaa.Controls.Add(this.dateVarattu);
            this.tabMuokkaa.Controls.Add(this.cbToimipiste);
            this.tabMuokkaa.Controls.Add(this.cbAsiakas);
            this.tabMuokkaa.Controls.Add(this.btnSulje);
            this.tabMuokkaa.Controls.Add(this.btnTallenna);
            this.tabMuokkaa.Controls.Add(this.label6);
            this.tabMuokkaa.Controls.Add(this.label5);
            this.tabMuokkaa.Controls.Add(this.label3);
            this.tabMuokkaa.Controls.Add(this.label2);
            this.tabMuokkaa.Controls.Add(this.label1);
            this.tabMuokkaa.Location = new System.Drawing.Point(4, 25);
            this.tabMuokkaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMuokkaa.Name = "tabMuokkaa";
            this.tabMuokkaa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMuokkaa.Size = new System.Drawing.Size(1035, 503);
            this.tabMuokkaa.TabIndex = 1;
            this.tabMuokkaa.Text = "Muokkaa";
            this.tabMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoista.Location = new System.Drawing.Point(659, 288);
            this.btnPoista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(185, 28);
            this.btnPoista.TabIndex = 9;
            this.btnPoista.Text = "Poista palvelu";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Valitut palvelut";
            // 
            // dgValitutPalvelut
            // 
            this.dgValitutPalvelut.AllowUserToAddRows = false;
            this.dgValitutPalvelut.AllowUserToDeleteRows = false;
            this.dgValitutPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgValitutPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgValitutPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgValitutPalvelut.Location = new System.Drawing.Point(465, 37);
            this.dgValitutPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgValitutPalvelut.MultiSelect = false;
            this.dgValitutPalvelut.Name = "dgValitutPalvelut";
            this.dgValitutPalvelut.ReadOnly = true;
            this.dgValitutPalvelut.RowHeadersWidth = 51;
            this.dgValitutPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgValitutPalvelut.Size = new System.Drawing.Size(559, 212);
            this.dgValitutPalvelut.TabIndex = 21;
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPalvelut.Location = new System.Drawing.Point(465, 288);
            this.btnPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(185, 28);
            this.btnPalvelut.TabIndex = 8;
            this.btnPalvelut.Text = "Lisää palveluita";
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnPalvelut_Click);
            // 
            // dateVarattulop
            // 
            this.dateVarattulop.CustomFormat = "dd.MM.yyyy";
            this.dateVarattulop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVarattulop.Location = new System.Drawing.Point(205, 224);
            this.dateVarattulop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateVarattulop.Name = "dateVarattulop";
            this.dateVarattulop.Size = new System.Drawing.Size(219, 22);
            this.dateVarattulop.TabIndex = 5;
            // 
            // dateVarattualk
            // 
            this.dateVarattualk.CustomFormat = "dd.MM.yyyy";
            this.dateVarattualk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVarattualk.Location = new System.Drawing.Point(205, 175);
            this.dateVarattualk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateVarattualk.Name = "dateVarattualk";
            this.dateVarattualk.Size = new System.Drawing.Size(219, 22);
            this.dateVarattualk.TabIndex = 4;
            // 
            // dateVarattu
            // 
            this.dateVarattu.CustomFormat = "dd.MM.yyyy";
            this.dateVarattu.Enabled = false;
            this.dateVarattu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVarattu.Location = new System.Drawing.Point(205, 132);
            this.dateVarattu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateVarattu.Name = "dateVarattu";
            this.dateVarattu.Size = new System.Drawing.Size(219, 22);
            this.dateVarattu.TabIndex = 3;
            // 
            // cbToimipiste
            // 
            this.cbToimipiste.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbToimipiste.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbToimipiste.Enabled = false;
            this.cbToimipiste.FormattingEnabled = true;
            this.cbToimipiste.Location = new System.Drawing.Point(205, 86);
            this.cbToimipiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbToimipiste.Name = "cbToimipiste";
            this.cbToimipiste.Size = new System.Drawing.Size(219, 24);
            this.cbToimipiste.TabIndex = 2;
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAsiakas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAsiakas.Enabled = false;
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(205, 37);
            this.cbAsiakas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(219, 24);
            this.cbAsiakas.TabIndex = 1;
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(292, 288);
            this.btnSulje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(133, 28);
            this.btnSulje.TabIndex = 7;
            this.btnSulje.Text = "Sulje";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(150, 288);
            this.btnTallenna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(133, 28);
            this.btnTallenna.TabIndex = 6;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Varattu päättyen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Varattu alkaen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varauksen päivämäärä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toimipiste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakas";
            // 
            // tabPalvelut
            // 
            this.tabPalvelut.Controls.Add(this.btnPeruuta);
            this.tabPalvelut.Controls.Add(this.btnLisaaPalvelut);
            this.tabPalvelut.Controls.Add(this.dgVarauksenPalvelut);
            this.tabPalvelut.Location = new System.Drawing.Point(4, 25);
            this.tabPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPalvelut.Name = "tabPalvelut";
            this.tabPalvelut.Size = new System.Drawing.Size(1035, 503);
            this.tabPalvelut.TabIndex = 2;
            this.tabPalvelut.Text = "Lisää palveluita";
            this.tabPalvelut.UseVisualStyleBackColor = true;
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPeruuta.Location = new System.Drawing.Point(164, 447);
            this.btnPeruuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(133, 28);
            this.btnPeruuta.TabIndex = 14;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // btnLisaaPalvelut
            // 
            this.btnLisaaPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaaPalvelut.Location = new System.Drawing.Point(23, 447);
            this.btnLisaaPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaaPalvelut.Name = "btnLisaaPalvelut";
            this.btnLisaaPalvelut.Size = new System.Drawing.Size(133, 28);
            this.btnLisaaPalvelut.TabIndex = 5;
            this.btnLisaaPalvelut.Text = "Lisää";
            this.btnLisaaPalvelut.UseVisualStyleBackColor = true;
            this.btnLisaaPalvelut.Click += new System.EventHandler(this.btnLisaaPalvelut_Click);
            // 
            // dgVarauksenPalvelut
            // 
            this.dgVarauksenPalvelut.AllowUserToAddRows = false;
            this.dgVarauksenPalvelut.AllowUserToDeleteRows = false;
            this.dgVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVarauksenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVarauksenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valittu});
            this.dgVarauksenPalvelut.Location = new System.Drawing.Point(4, 4);
            this.dgVarauksenPalvelut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgVarauksenPalvelut.MultiSelect = false;
            this.dgVarauksenPalvelut.Name = "dgVarauksenPalvelut";
            this.dgVarauksenPalvelut.RowHeadersWidth = 51;
            this.dgVarauksenPalvelut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVarauksenPalvelut.Size = new System.Drawing.Size(1024, 417);
            this.dgVarauksenPalvelut.TabIndex = 4;
            // 
            // Valittu
            // 
            this.Valittu.FalseValue = "false";
            this.Valittu.FillWeight = 40F;
            this.Valittu.HeaderText = "Valittu";
            this.Valittu.IndeterminateValue = "false";
            this.Valittu.MinimumWidth = 6;
            this.Valittu.Name = "Valittu";
            this.Valittu.TrueValue = "true";
            // 
            // VarauksenMuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tcVaraukset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "VarauksenMuokkaus";
            this.Text = "Village People Oy | Varauksen muokkaus";
            this.tcVaraukset.ResumeLayout(false);
            this.tabMuokkaa.ResumeLayout(false);
            this.tabMuokkaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgValitutPalvelut)).EndInit();
            this.tabPalvelut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVarauksenPalvelut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVaraukset;
        private System.Windows.Forms.TabPage tabMuokkaa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgValitutPalvelut;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.DateTimePicker dateVarattulop;
        private System.Windows.Forms.DateTimePicker dateVarattualk;
        private System.Windows.Forms.DateTimePicker dateVarattu;
        private System.Windows.Forms.ComboBox cbToimipiste;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPalvelut;
        private System.Windows.Forms.Button btnLisaaPalvelut;
        private System.Windows.Forms.DataGridView dgVarauksenPalvelut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Valittu;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.Button btnPoista;
    }
}