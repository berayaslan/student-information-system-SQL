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
    public partial class BolumAtama : Form
    {
        public BolumAtama()
        {
            InitializeComponent();
        }

        DbOgrenciBilgiSistemiEntities db = new DbOgrenciBilgiSistemiEntities();
        private void BolumAtama_Load(object sender, EventArgs e)
        {
            lookUpEdit3.Properties.DataSource = (from x in db.TBL_BOLUMLER
                                                 select new
                                                 {
                                                     x.ID,
                                                     BÖLÜM = x.BOLUM
                                                 }).ToList();
            lookUpEdit3.Properties.ValueMember = "ID";
            lookUpEdit3.Properties.DisplayMember = "BÖLÜM";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBL_OGRETMENLER t = new TBL_OGRETMENLER();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.BOLUM = int.Parse(lookUpEdit3.EditValue.ToString());
            t.SICILNO = TxtSicil.Text;
            db.TBL_OGRETMENLER.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
