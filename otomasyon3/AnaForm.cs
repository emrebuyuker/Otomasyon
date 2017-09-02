using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace otomasyon3
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void barBtnStokKartı_ItemClick(object sender, ItemClickEventArgs e)
        {
            Modul_Stok.frmStokKartı frm = new Modul_Stok.frmStokKartı();
            frm.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            frm.Show();
        }
    }
}