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
    public partial class Bolumler : Form
    {
        public Bolumler()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        void Listele()
        {
            gridControl1.DataSource = (from x in db.TBL_BOLUMLER
                                       select new
                                       {
                                           x.ID,
                                           x.BOLUM,
                                           x.BOLUMKODU,
                                           x.DURUM
                                       }).Where(x => x.DURUM == true).ToList();
        }

        private void Bolumler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Temizle()
        {
            TxtID.Text = "";
            TxtBolum.Text = "";
            TxtBolumKodu.Text = "";
            TxtBolum.Focus();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtBolum.Text = gridView1.GetFocusedRowCellValue("BOLUM").ToString();
            TxtBolumKodu.Text = gridView1.GetFocusedRowCellValue("BOLUMKODU").ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_BOLUMLER t = new TBL_BOLUMLER();
            t.BOLUM = TxtBolum.Text;
            t.BOLUMKODU = TxtBolumKodu.Text;
            db.TBL_BOLUMLER.Add(t);
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
                var deger = db.TBL_BOLUMLER.Find(x);
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
            var deger = db.TBL_BOLUMLER.Find(x);
            deger.BOLUM = TxtBolum.Text;
            deger.BOLUMKODU = TxtBolumKodu.Text;
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
    }
}
