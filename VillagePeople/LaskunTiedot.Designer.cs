namespace VillagePeople
{
    partial class LaskunTiedot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaskunTiedot));
            this.txtTiedot = new System.Windows.Forms.TextBox();
            this.dgTiedot = new System.Windows.Forms.DataGridView();
            this.btnTulosta = new System.Windows.Forms.Button();
            this.txtsposti = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTiedot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTiedot
            // 
            this.txtTiedot.Location = new System.Drawing.Point(12, 12);
            this.txtTiedot.Multiline = true;
            this.txtTiedot.Name = "txtTiedot";
            this.txtTiedot.ReadOnly = true;
            this.txtTiedot.Size = new System.Drawing.Size(200, 175);
            this.txtTiedot.TabIndex = 1000;
            // 
            // dgTiedot
            // 
            this.dgTiedot.AllowUserToAddRows = false;
            this.dgTiedot.AllowUserToDeleteRows = false;
            this.dgTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTiedot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTiedot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTiedot.Location = new System.Drawing.Point(12, 193);
            this.dgTiedot.MultiSelect = false;
            this.dgTiedot.Name = "dgTiedot";
            this.dgTiedot.ReadOnly = true;
            this.dgTiedot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTiedot.Size = new System.Drawing.Size(660, 206);
            this.dgTiedot.TabIndex = 1;
            // 
            // btnTulosta
            // 
            this.btnTulosta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTulosta.Location = new System.Drawing.Point(572, 165);
            this.btnTulosta.Name = "btnTulosta";
            this.btnTulosta.Size = new System.Drawing.Size(100, 23);
            this.btnTulosta.TabIndex = 1003;
            this.btnTulosta.Text = "Tulosta";
            this.btnTulosta.UseVisualStyleBackColor = true;
            this.btnTulosta.Click += new System.EventHandler(this.btnTulosta_Click);
            // 
            // txtsposti
            // 
            this.txtsposti.Location = new System.Drawing.Point(218, 167);
            this.txtsposti.Name = "txtsposti";
            this.txtsposti.Size = new System.Drawing.Size(178, 20);
            this.txtsposti.TabIndex = 1001;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(402, 165);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 1002;
            this.btnSend.Text = "Lähetä";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1003;
            this.label1.Text = "Lähetä sähköpostiin";
            // 
            // LaskunTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtsposti);
            this.Controls.Add(this.btnTulosta);
            this.Controls.Add(this.dgTiedot);
            this.Controls.Add(this.txtTiedot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "LaskunTiedot";
            this.Text = "Village People Oy | Laskun tiedot";
            ((System.ComponentModel.ISupportInitialize)(this.dgTiedot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTiedot;
        private System.Windows.Forms.DataGridView dgTiedot;
        private System.Windows.Forms.Button btnTulosta;
        private System.Windows.Forms.TextBox txtsposti;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
    }
}