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
    public partial class Ogretmenler : Form
    {
        public Ogretmenler()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        void Listele()
        {
            gridControl1.DataSource = (from x in db.TBL_OGRETMENLER
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           BÖLÜM = x.TBL_BOLUMLER.BOLUM,
                                           x.SICILNO,
                                           x.DURUM
                                       }).Where(x => x.DURUM == true).ToList();
        }

        private void Ogretmenler_Load(object sender, EventArgs e)
        {
            Listele();
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_BOLUMLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.BOLUM
                                                 }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "BOLUM";
        }

        void Temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSicil.Text = "";
            TxtAd.Focus();

        }

        int ogrtid;

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRETMENLER t = new TBL_OGRETMENLER();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.BOLUM = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.SICILNO = TxtSicil.Text;
            db.TBL_OGRETMENLER.Add(t);
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
                var deger = db.TBL_OGRETMENLER.Find(x);
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
            var deger = db.TBL_OGRETMENLER.Find(x);
            deger.AD = TxtAd.Text;
            deger.SOYAD = TxtSoyad.Text;
            deger.SICILNO = TxtSicil.Text;
            deger.BOLUM = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncelleme İşlemi Başarıyla Gerçekleştirildi", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("BÖLÜM").ToString();
            TxtSicil.Text = gridView1.GetFocusedRowCellValue("SICILNO").ToString();
            ogrtid = int.Parse(TxtID.Text);

            gridControl2.DataSource = (from x in db.TBL_OGRENCIDERSLISTESI
                                       select new
                                       {
                                           x.OGRETMEN,
                                           DERS = x.TBL_DERSLER.DERS,
                                           BÖLÜM = x.TBL_BOLUMLER.BOLUM,
                                           x.DERSLIK
                                       }).Where(x => x.OGRETMEN == ogrtid).ToList();

      
        }
    }
}
