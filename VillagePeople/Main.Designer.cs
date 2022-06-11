namespace VillagePeople
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnToimipisteet = new System.Windows.Forms.Button();
            this.btnLaskut = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(81, 225);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(150, 40);
            this.btnAsiakkaat.TabIndex = 4;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnToimipisteet
            // 
            this.btnToimipisteet.Location = new System.Drawing.Point(393, 225);
            this.btnToimipisteet.Name = "btnToimipisteet";
            this.btnToimipisteet.Size = new System.Drawing.Size(150, 40);
            this.btnToimipisteet.TabIndex = 6;
            this.btnToimipisteet.Text = "Toimipisteet";
            this.btnToimipisteet.UseVisualStyleBackColor = true;
            this.btnToimipisteet.Click += new System.EventHandler(this.btnToimipisteet_Click);
            // 
            // btnLaskut
            // 
            this.btnLaskut.Location = new System.Drawing.Point(237, 179);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Size = new System.Drawing.Size(150, 40);
            this.btnLaskut.TabIndex = 2;
            this.btnLaskut.Text = "Laskut";
            this.btnLaskut.UseVisualStyleBackColor = true;
            this.btnLaskut.Click += new System.EventHandler(this.btnLaskut_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Location = new System.Drawing.Point(81, 179);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(150, 40);
            this.btnVaraukset.TabIndex = 1;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.UseVisualStyleBackColor = true;
            this.btnVaraukset.Click += new System.EventHandler(this.btnVaraukset_Click);
            // 
            // btnRaportit
            // 
            this.btnRaportit.Location = new System.Drawing.Point(393, 179);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Size = new System.Drawing.Size(150, 40);
            this.btnRaportit.TabIndex = 3;
            this.btnRaportit.Text = "Raportit";
            this.btnRaportit.UseVisualStyleBackColor = true;
            this.btnRaportit.Click += new System.EventHandler(this.btnRaportit_Click);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Location = new System.Drawing.Point(237, 225);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(150, 40);
            this.btnPalvelut.TabIndex = 5;
            this.btnPalvelut.Text = "Palvelut";
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnPalvelut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Village People Oy:n tietojärjestelmä";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPalvelut);
            this.Controls.Add(this.btnRaportit);
            this.Controls.Add(this.btnVaraukset);
            this.Controls.Add(this.btnLaskut);
            this.Controls.Add(this.btnToimipisteet);
            this.Controls.Add(this.btnAsiakkaat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Village People Oy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnToimipisteet;
        private System.Windows.Forms.Button btnLaskut;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Label label1;
    }
}

