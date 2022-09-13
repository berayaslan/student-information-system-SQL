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
    public partial class Ogrenciler : Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }

        void Listele()
        {
            gridControl1.DataSource = (from x in db.TBL_OGRENCI
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.TC,
                                           x.TELEFON,
                                           x.OGRENCIDURUM,
                                           x.DURUM
                                       }).Where(x => x.DURUM == true).ToList();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        int ogrid;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtTc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            textEdit_Durum.Text = gridView1.GetFocusedRowCellValue("OGRENCIDURUM").ToString();
            ogrid = int.Parse(TxtID.Text);

            gridControl2.DataSource = (from x in db.TBL_OGRENCIDERSLISTESI
                                       select new
                                       {
                                           x.OGRENCI,
                                           DERS = x.TBL_DERSLER.DERS,
                                           ÖĞRETMEN = x.TBL_OGRETMENLER.AD + " " + x.TBL_OGRETMENLER.SOYAD,
                                           KREDİ = x.KREDİ,
                                           DERSLİK = x.DERSLIK,
                                       }).Where(x => x.OGRENCI == ogrid).ToList();

            gridControl3.DataSource = (from x in db.TBL_OGRENCIBOLUMLISTESI
                                       select new
                                       {
                                           x.OGRENCI,
                                           x.TBL_BOLUMLER.BOLUM,
                                           x.OGRENCINO
                                       }).Where(x => x.OGRENCI == ogrid).ToList();

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTc.Text = "";
            TxtTelefon.Text = "";
            textEdit_Durum.Text = "";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            TBL_OGRENCI t = new TBL_OGRENCI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.TC = TxtTc.Text;
            t.TELEFON = TxtTelefon.Text;
            t.OGRENCIDURUM = textEdit_Durum.Text;
            t.DURUM = true;
            db.TBL_OGRENCI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = XtraMessageBox.Show("Kaydı Silmek İstediğinizden Emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int x = int.Parse(TxtID.Text);
                var deger = db.TBL_OGRENCI.Find(x);
                deger.DURUM = false;
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Silme İşlemi Başarıyla Gerçekleştirildi", "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }

            else
            {

            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TBL_OGRENCI.Find(x);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.TELEFON = TxtTelefon.Text;
            deger.OGRENCIDURUM = textEdit_Durum.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncelleme İşlemi Başarıyla Gerçekleştirildi", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }
    }
}
