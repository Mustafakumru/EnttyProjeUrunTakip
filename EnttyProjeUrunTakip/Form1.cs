using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnttyProjeUrunTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEnttiyUrunEntities db=new DbEnttiyUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler=db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t =new Tbl_Kategori();
            t.Ad=txtkatAd.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(txtkatid.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(txtkatid.Text);
            var ktgr = db.Tbl_Kategori.Find(x);
            ktgr.Ad=txtkatAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }
    }
}
