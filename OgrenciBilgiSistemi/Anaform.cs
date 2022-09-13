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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        Ogrenciler fr1;
        private void BtnOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new Ogrenciler();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        Ogretmenler fr2;
        private void BtnOgretimUyeleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Ogretmenler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        Bolumler fr3;
        private void BtnBolumler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3==null || fr2.IsDisposed)
            {
                fr3 = new Bolumler();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        Dersler fr4;
        private void BtnDersler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Dersler();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        private void BtnHakkimizda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Hakkimizda fr = new Hakkimizda();
            fr.Show();
        }

        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Notlar fr = new Notlar();
            fr.Show();
        }

        private void BtnDersAtama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DersAtama fr = new DersAtama();
            fr.Show();
        }

        private void BtnBolumAtama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BolumAtama fr = new BolumAtama();
            fr.Show();
        }
    }
}
