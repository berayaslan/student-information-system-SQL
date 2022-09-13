using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var verigetir = db.TBL_OGRENCIBOLUMLISTESI.SingleOrDefault(x => x.OGRENCINO == TxtOgrenciNo.Text);

            if (verigetir != null)

            {
                TxtAd.Text = verigetir.TBL_OGRENCI.AD;
                TxtSoyad.Text = verigetir.TBL_OGRENCI.SOYAD;
                TxtTelefon.Text = verigetir.TBL_OGRENCI.TELEFON;
            }

            Listele();

        }

        double vize, final;

        void Listele()
        {
            gridControl1.DataSource = (from x in db.TBL_NOTLAR
                                       select new
                                       {
                                           x.ID,
                                           x.OGRENCINO,
                                           DERS = x.TBL_DERSLER.DERS,
                                           x.VIZE,
                                           x.FINAL,
                                           x.ORTALAMA

                                       }).Where(x => x.OGRENCINO == TxtOgrenciNo.Text).ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtVize.Text = gridView1.GetFocusedRowCellValue("VIZE").ToString();
            TxtFinal.Text = gridView1.GetFocusedRowCellValue("FINAL").ToString();
            label1.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            
            vize = double.Parse(TxtVize.Text);
            final = double.Parse(TxtFinal.Text);
        }

        void temizle()
        {
            TxtVize.Text = "";
            TxtFinal.Text = "";
            TxtOrtalama.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(label1.Text);
            var deger = db.TBL_NOTLAR.Find(x);
            deger.VIZE = decimal.Parse(TxtVize.Text);
            deger.FINAL = decimal.Parse(TxtFinal.Text);
            deger.ORTALAMA = decimal.Parse(TxtOrtalama.Text);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncelleme İşlemi Başarıyla Gerçekleştirildi", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();

        }

        private void Notlar_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            double ortalama = (vize * 0.4) + (final * 0.6);
            TxtOrtalama.Text = ortalama.ToString();
        }
    }
}
