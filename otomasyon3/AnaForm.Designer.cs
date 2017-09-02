namespace otomasyon3
{
    partial class AnaForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStokKartı = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokGrupları = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnStokKartı,
            this.barBtnStokListesi,
            this.barBtnStokGrupları,
            this.barBtnStokHareketleri});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(570, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnStokKartı
            // 
            this.barBtnStokKartı.Caption = "Stok Kartı";
            this.barBtnStokKartı.Id = 1;
            this.barBtnStokKartı.ImageOptions.Image = global::otomasyon3.Properties.Resources.Stok_Kartı32x32;
            this.barBtnStokKartı.Name = "barBtnStokKartı";
            this.barBtnStokKartı.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnStokKartı.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKartı_ItemClick);
            // 
            // barBtnStokListesi
            // 
            this.barBtnStokListesi.Caption = "Stok Listesi";
            this.barBtnStokListesi.Id = 2;
            this.barBtnStokListesi.ImageOptions.Image = global::otomasyon3.Properties.Resources.Stok_Liste32x32;
            this.barBtnStokListesi.Name = "barBtnStokListesi";
            this.barBtnStokListesi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokListesi_ItemClick);
            // 
            // barBtnStokGrupları
            // 
            this.barBtnStokGrupları.Caption = "Stok Grupları";
            this.barBtnStokGrupları.Id = 3;
            this.barBtnStokGrupları.ImageOptions.LargeImage = global::otomasyon3.Properties.Resources.Stok_Grup32x32;
            this.barBtnStokGrupları.Name = "barBtnStokGrupları";
            // 
            // barBtnStokHareketleri
            // 
            this.barBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.barBtnStokHareketleri.Id = 4;
            this.barBtnStokHareketleri.ImageOptions.LargeImage = global::otomasyon3.Properties.Resources.Stok_Hareket32x32;
            this.barBtnStokHareketleri.Name = "barBtnStokHareketleri";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Image = global::otomasyon3.Properties.Resources.Stok32x32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "STOK";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokKartı);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokGrupları);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(570, 31);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKartı;
        private DevExpress.XtraBars.BarButtonItem barBtnStokListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnStokGrupları;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareketleri;
    }
}