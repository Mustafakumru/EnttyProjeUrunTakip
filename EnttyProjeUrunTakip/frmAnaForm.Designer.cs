namespace EnttyProjeUrunTakip
{
    partial class frmAnaForm
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
            this.btnkatişlem = new System.Windows.Forms.Button();
            this.btnUrunIslem = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkatişlem
            // 
            this.btnkatişlem.Location = new System.Drawing.Point(1, 5);
            this.btnkatişlem.Name = "btnkatişlem";
            this.btnkatişlem.Size = new System.Drawing.Size(259, 234);
            this.btnkatişlem.TabIndex = 0;
            this.btnkatişlem.Text = "Kategori İşlemleri";
            this.btnkatişlem.UseVisualStyleBackColor = true;
            this.btnkatişlem.Click += new System.EventHandler(this.btnkatişlem_Click);
            // 
            // btnUrunIslem
            // 
            this.btnUrunIslem.Location = new System.Drawing.Point(266, 5);
            this.btnUrunIslem.Name = "btnUrunIslem";
            this.btnUrunIslem.Size = new System.Drawing.Size(259, 234);
            this.btnUrunIslem.TabIndex = 1;
            this.btnUrunIslem.Text = "Ürün İşlem";
            this.btnUrunIslem.UseVisualStyleBackColor = true;
            this.btnUrunIslem.Click += new System.EventHandler(this.btnUrunIslem_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(531, 5);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(259, 234);
            this.btnistatistik.TabIndex = 2;
            this.btnistatistik.Text = "İstatistiklerler";
            this.btnistatistik.UseVisualStyleBackColor = true;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 235);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.btnUrunIslem);
            this.Controls.Add(this.btnkatişlem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkatişlem;
        private System.Windows.Forms.Button btnUrunIslem;
        private System.Windows.Forms.Button btnistatistik;
    }
}