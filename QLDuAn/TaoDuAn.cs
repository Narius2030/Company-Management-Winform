using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.QLDuAn
{
    public partial class TaoDuAn : Form
    {
        DuAnDAO dad = new DuAnDAO();
        private string chedo;
        private DuAn da = new DuAn();
        public TaoDuAn(DuAn da,string chedo)
        {
            InitializeComponent();
            this.chedo = chedo;
            this.da = da;
        }

        private void TaoDuAn_Load(object sender, EventArgs e)
        {
            lblTitle.Text = chedo;
            if (chedo.ToUpper() == "CẬP NHẬT")
            {
                DoDLTextBox();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            try
            {
                if (chedo.ToUpper() == "THÊM")
                {
                    dad.Them(da);
                }
                else
                {
                    dad.Sua(da);
                }
                MessageBox.Show("Thông báo" ,"Thao tác thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach(var control in pnlTTDuAn.Controls.OfType<TextBox>())
            {
                control.Clear();
            }
        }
        public void DoDLTextBox()
        {
            Type type = da.GetType();
            var props = type.GetProperties();
            int i = 0;
            foreach (var control in pnlTTDuAn.Controls.OfType<TextBox>())
            {
                control.Text = props[i].GetValue(da, null).ToString();
            }
        }
    }
}
