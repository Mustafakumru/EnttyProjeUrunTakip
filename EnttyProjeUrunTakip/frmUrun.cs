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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtUrunad.Text = cbmkat.SelectedValue.ToString();
        }
        DbEnttiyUrunEntities db = new DbEnttiyUrunEntities();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun select new { x.Urunİd, x.UrunAd, x.Marka, x.Fıyat, x.Stok, x.Kategori, x.Durum }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.UrunAd = txtUrunad.Text;
            t.Marka = txtmarka.Text;
            t.Stok = short.Parse(txtstok.Text);
            t.Kategori = int.Parse(cbmkat.SelectedValue.ToString());
            t.Fıyat = decimal.Parse(txtfiyat.Text);
            t.Durum = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi ");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi ");

        }

        private void buttBtnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.UrunAd = txtUrunad.Text;
            urun.Stok = short.Parse(txtstok.Text);
            urun.Marka = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");

        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.Id,
                                   x.Ad
                               }
                               ).ToList();
            cbmkat.ValueMember = "ID";
            cbmkat.DisplayMember = "Ad";
            cbmkat.DataSource = kategoriler;
        }
    }
}
