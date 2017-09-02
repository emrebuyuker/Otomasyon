using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace otomasyon3.Modul_Stok
{
    public partial class frmStokGrupları : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;

        public frmStokGrupları()
        {
            InitializeComponent();
        }

        private void frmStokGrupları_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {

        }
    }
}