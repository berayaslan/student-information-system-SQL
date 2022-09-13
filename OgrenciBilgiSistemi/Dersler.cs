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
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        void Listele()
        {
            gridControl1.DataSource = (from x in db.TBL_DERSLER
                                       select new
                                       {
                                           x.ID,
                                           x.DERS,
                                           x.DERSKODU,
                                           BÖLÜM = x.TBL_BOLUMLER.BOLUM,
                                           ÖĞRETMEN = x.TBL_OGRETMENLER.AD + " " + x.TBL_OGRETMENLER.SOYAD,
                                           x.KREDI,
                                           x.DERSLIK,
                                           x.DURUM
                                       }).Where(x => x.DURUM == true).ToList();
        }

        private void Dersler_Load(object sender, EventArgs e)
        {
            Listele();
            lookUpEdit_Bolum.Properties.DataSource = (from x in db.TBL_BOLUMLER
                                                      select new
                                                      {
                                                          x.ID,
                                                          x.BOLUM
                                                      }).ToList();
            lookUpEdit_Bolum.Properties.ValueMember = "ID";
            lookUpEdit_Bolum.Properties.DisplayMember = "BOLUM";

            lookUpEdit_Ogretmen.Properties.DataSource = (from x in db.TBL_OGRETMENLER
                                                         select new
                                                         {
                                                             x.ID,
                                                             ÖĞRETMEN = x.AD + " " + x.SOYAD
                                                         }).ToList();
            lookUpEdit_Ogretmen.Properties.ValueMember = "ID";
            lookUpEdit_Ogretmen.Properties.DisplayMember = "ÖĞRETMEN";
        }

        void Temizle()
        {
            TxtID.Text = "";
            TxtDers.Text = "";
            TxtDersKodu.Text = "";
            TxtKredi.Text = "";
            TxtDerslik.Text = "";
            TxtDers.Focus();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtDers.Text = gridView1.GetFocusedRowCellValue("DERS").ToString();
            TxtDersKodu.Text = gridView1.GetFocusedRowCellValue("DERSKODU").ToString();
            lookUpEdit_Bolum.Text = gridView1.GetFocusedRowCellValue("BÖLÜM").ToString();
            lookUpEdit_Ogretmen.Text = gridView1.GetFocusedRowCellValue("ÖĞRETMEN").ToString();
            TxtKredi.Text = gridView1.GetFocusedRowCellValue("KREDI").ToString();
            TxtDerslik.Text = gridView1.GetFocusedRowCellValue("DERSLIK").ToString();   
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_DERSLER t = new TBL_DERSLER();
            t.DERS = TxtDers.Text;
            t.DERSKODU = TxtDersKodu.Text;
            t.BOLUM = byte.Parse(lookUpEdit_Bolum.EditValue.ToString());
            t.OGRETMEN = byte.Parse(lookUpEdit_Ogretmen.EditValue.ToString());
            t.KREDI = decimal.Parse(TxtKredi.Text);
            t.DERSLIK = TxtDerslik.Text;
            db.TBL_DERSLER.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TBL_DERSLER.Find(x);
            deger.DERS = TxtDers.Text;
            deger.DERSKODU = TxtDersKodu.Text;
            deger.BOLUM = byte.Parse(lookUpEdit_Bolum.EditValue.ToString());
            deger.OGRETMEN = byte.Parse(lookUpEdit_Ogretmen.EditValue.ToString());
            deger.KREDI = decimal.Parse(TxtKredi.Text);
            deger.DERSLIK = TxtDerslik.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncelleme İşlemi Başarıyla Gerçekleştirildi", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var deger = db.TBL_DERSLER.Find(x);
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

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
