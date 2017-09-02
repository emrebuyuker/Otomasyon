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
    public partial class frmStokKartı : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKartı()
        {
            InitializeComponent();
        }
        

        private void labelControl11_DoubleClick(object sender, EventArgs e)
        {
            txt1.Visible = true;
            txt1.Focus();
        }

        
        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt1.Visible = false;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                txt5.Visible = false;
                txt6.Visible = false;
                txt7.Visible = false;
                txt8.Visible = false;
                txt9.Visible = false;
                txt10.Visible = false;
            }
        }

        private void textEdit3_Click(object sender, EventArgs e)
        {
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;
            txt8.Visible = false;
            txt9.Visible = false;
            txt10.Visible = false;
        }

        private void txt1_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup1.Text = txt1.Text;
        }

        private void btnGrup2_DoubleClick(object sender, EventArgs e)
        {
            txt2.Visible = true;
            txt2.Focus();
        }
        
        private void txt2_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup2.Text = txt2.Text;
        }

        private void btnGrup3_DoubleClick(object sender, EventArgs e)
        {
            txt3.Visible = true;
            txt3.Focus();
        }

        private void txt3_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup3.Text = txt3.Text;
        }

        private void btnGrup4_DoubleClick(object sender, EventArgs e)
        {
            txt4.Visible = true;
            txt4.Focus();
        }

        private void txt4_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup4.Text = txt4.Text;
        }

        private void btnGrup5_DoubleClick(object sender, EventArgs e)
        {
            txt5.Visible = true;
            txt5.Focus();
        }

        private void txt5_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup5.Text = txt5.Text;
        }

        private void btnGrup6_DoubleClick(object sender, EventArgs e)
        {
            txt6.Visible = true;
            txt6.Focus();
        }

        private void txt6_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup6.Text = txt6.Text;
        }

        private void btnGrup7_DoubleClick(object sender, EventArgs e)
        {
            txt7.Visible = true;
            txt7.Focus();
        }

        private void txt7_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup7.Text = txt7.Text;
        }

        private void btnGrup8_DoubleClick(object sender, EventArgs e)
        {
            txt8.Visible = true;
            txt8.Focus();
        }

        private void txt8_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup8.Text = txt8.Text;
        }

        private void btnGrup9_DoubleClick(object sender, EventArgs e)
        {
            txt9.Visible = true;
            txt9.Focus();
        }

        private void txt9_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup9.Text = txt9.Text;
        }
        
        private void txt10_EditValueChanged(object sender, EventArgs e)
        {
            btnGrup10.Text = txt10.Text;
        }

        private void btnGrup10_DoubleClick_1(object sender, EventArgs e)
        {
            txt10.Visible = true;
            txt10.Focus();
        }
    }
}