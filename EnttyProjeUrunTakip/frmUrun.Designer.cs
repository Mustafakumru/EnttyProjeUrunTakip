namespace EnttyProjeUrunTakip
{
    partial class frmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtUrunad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.buttBtnGüncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbmkat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(136, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(184, 34);
            this.txtid.TabIndex = 1;
            // 
            // txtUrunad
            // 
            this.txtUrunad.Location = new System.Drawing.Point(136, 120);
            this.txtUrunad.Name = "txtUrunad";
            this.txtUrunad.Size = new System.Drawing.Size(184, 34);
            this.txtUrunad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Adı:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(136, 180);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(184, 34);
            this.txtmarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(136, 234);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(184, 34);
            this.txtstok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(136, 293);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(184, 34);
            this.txtfiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(136, 355);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(184, 34);
            this.txtdurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(353, 55);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(167, 78);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(353, 139);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 78);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(353, 223);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(167, 78);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // buttBtnGüncelle
            // 
            this.buttBtnGüncelle.Location = new System.Drawing.Point(353, 310);
            this.buttBtnGüncelle.Name = "buttBtnGüncelle";
            this.buttBtnGüncelle.Size = new System.Drawing.Size(167, 78);
            this.buttBtnGüncelle.TabIndex = 17;
            this.buttBtnGüncelle.Text = "Güncelle";
            this.buttBtnGüncelle.UseVisualStyleBackColor = true;
            this.buttBtnGüncelle.Click += new System.EventHandler(this.buttBtnGüncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(353, 383);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(167, 78);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 264);
            this.dataGridView1.TabIndex = 19;
            // 
            // cbmkat
            // 
            this.cbmkat.FormattingEnabled = true;
            this.cbmkat.Location = new System.Drawing.Point(137, 405);
            this.cbmkat.Name = "cbmkat";
            this.cbmkat.Size = new System.Drawing.Size(183, 37);
            this.cbmkat.TabIndex = 20;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 734);
            this.Controls.Add(this.cbmkat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.buttBtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrunad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmUrun";
            this.Text = "frmUrun";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtUrunad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button buttBtnGüncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbmkat;
    }
}