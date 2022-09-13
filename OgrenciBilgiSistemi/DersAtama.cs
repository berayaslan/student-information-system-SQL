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
    public partial class DersAtama : Form
    {
        public DersAtama()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();

        private void DersAtama_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_OGRENCI
                                                 select new
                                                 {
                                                     x.ID,
                                                     ÖĞRENCİ = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "ÖĞRENCİ";

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_OGRETMENLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     ÖĞRETMEN = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.ValueMember = "ID";
            lookUpEdit2.Properties.DisplayMember = "ÖĞRETMEN";

            lookUpEdit3.Properties.DataSource = (from x in db.TBL_BOLUMLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     BÖLÜM=x.BOLUM
                                                 }).ToList();
            lookUpEdit3.Properties.ValueMember = "ID";
            lookUpEdit3.Properties.DisplayMember = "BÖLÜM";

            lookUpEdit4.Properties.DataSource = (from x in db.TBL_DERSLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.DERS
                                                 }).ToList();
            lookUpEdit4.Properties.ValueMember = "ID";
            lookUpEdit4.Properties.DisplayMember = "DERS";


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRENCIDERSLISTESI t = new TBL_OGRENCIDERSLISTESI();
            t.OGRENCI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.OGRETMEN = int.Parse(lookUpEdit2.EditValue.ToString());
            t.BOLUM = int.Parse(lookUpEdit3.EditValue.ToString());
            t.DERS = int.Parse(lookUpEdit4.EditValue.ToString());
            t.KREDİ = decimal.Parse(TxtKredi.Text);
            t.DERSLIK = TxtDerslik.Text;
            db.TBL_OGRENCIDERSLISTESI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
