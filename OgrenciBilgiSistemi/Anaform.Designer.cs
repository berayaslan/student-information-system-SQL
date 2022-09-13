
namespace OgrenciBilgiSistemi
{
    partial class Anaform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnOgrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnOgretimUyeleri = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBolumler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDersler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHakkimizda = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDersAtama = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBolumAtama = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnOgrenciler,
            this.BtnOgretimUyeleri,
            this.BtnBolumler,
            this.BtnDersler,
            this.BtnNotlar,
            this.BtnHakkimizda,
            this.BtnDersAtama,
            this.BtnBolumAtama});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1184, 150);
            // 
            // BtnOgrenciler
            // 
            this.BtnOgrenciler.Caption = "Öğrenciler";
            this.BtnOgrenciler.Id = 1;
            this.BtnOgrenciler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgrenciler.ImageOptions.Image")));
            this.BtnOgrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOgrenciler.ImageOptions.LargeImage")));
            this.BtnOgrenciler.Name = "BtnOgrenciler";
            this.BtnOgrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOgrenciler_ItemClick);
            // 
            // BtnOgretimUyeleri
            // 
            this.BtnOgretimUyeleri.Caption = "Öğretim Üyeleri";
            this.BtnOgretimUyeleri.Id = 2;
            this.BtnOgretimUyeleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOgretimUyeleri.ImageOptions.Image")));
            this.BtnOgretimUyeleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnOgretimUyeleri.ImageOptions.LargeImage")));
            this.BtnOgretimUyeleri.Name = "BtnOgretimUyeleri";
            this.BtnOgretimUyeleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnOgretimUyeleri_ItemClick);
            // 
            // BtnBolumler
            // 
            this.BtnBolumler.Caption = "Bölümler";
            this.BtnBolumler.Id = 3;
            this.BtnBolumler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBolumler.ImageOptions.Image")));
            this.BtnBolumler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBolumler.ImageOptions.LargeImage")));
            this.BtnBolumler.Name = "BtnBolumler";
            this.BtnBolumler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBolumler_ItemClick);
            // 
            // BtnDersler
            // 
            this.BtnDersler.Caption = "Dersler";
            this.BtnDersler.Id = 4;
            this.BtnDersler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDersler.ImageOptions.Image")));
            this.BtnDersler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDersler.ImageOptions.LargeImage")));
            this.BtnDersler.Name = "BtnDersler";
            this.BtnDersler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDersler_ItemClick);
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "Notlar";
            this.BtnNotlar.Id = 5;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.LargeImage")));
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNotlar_ItemClick);
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.Caption = "Hakkımızda";
            this.BtnHakkimizda.Id = 6;
            this.BtnHakkimizda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHakkimizda.ImageOptions.Image")));
            this.BtnHakkimizda.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHakkimizda.ImageOptions.LargeImage")));
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHakkimizda_ItemClick);
            // 
            // BtnDersAtama
            // 
            this.BtnDersAtama.Caption = "Ders Atama";
            this.BtnDersAtama.Id = 9;
            this.BtnDersAtama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDersAtama.ImageOptions.Image")));
            this.BtnDersAtama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDersAtama.ImageOptions.LargeImage")));
            this.BtnDersAtama.Name = "BtnDersAtama";
            this.BtnDersAtama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDersAtama_ItemClick);
            // 
            // BtnBolumAtama
            // 
            this.BtnBolumAtama.Caption = "Bölüm Atama";
            this.BtnBolumAtama.Id = 10;
            this.BtnBolumAtama.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBolumAtama.ImageOptions.Image")));
            this.BtnBolumAtama.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBolumAtama.ImageOptions.LargeImage")));
            this.BtnBolumAtama.Name = "BtnBolumAtama";
            this.BtnBolumAtama.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnBolumAtama_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menüler";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnOgrenciler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnOgretimUyeleri);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBolumler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDersler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHakkimizda);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDersAtama);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBolumAtama);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Öğrenci Bölüm Listesi";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Öğrenci Ders Listesi";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 646);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnOgrenciler;
        private DevExpress.XtraBars.BarButtonItem BtnOgretimUyeleri;
        private DevExpress.XtraBars.BarButtonItem BtnBolumler;
        private DevExpress.XtraBars.BarButtonItem BtnDersler;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnHakkimizda;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnDersAtama;
        private DevExpress.XtraBars.BarButtonItem BtnBolumAtama;
    }
}

