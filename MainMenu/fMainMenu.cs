using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy
{
    public partial class fMainMenu : Form
    {
        public fMainMenu()
        {
            InitializeComponent();
        }
        private void fMainMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            fCheckin_Checkout fcio = new fCheckin_Checkout();
            fcio.Show();
        }
        private void btnNhanvienphong_Click(object sender, EventArgs e)
        {
            fQLNhanVienPB fqlnvpb = new fQLNhanVienPB();
            fqlnvpb.Show();
        }
        private void btnDuan_Click(object sender, EventArgs e)
        {
            fQLDAThamGia fqlda = new fQLDAThamGia();
            fqlda.Show();
        }

        private void btnTienluong_Click(object sender, EventArgs e)
        {
            fQLtienluong fgltl = new fQLtienluong();
            fgltl.Show();
        }
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            fNhanSu fns = new fNhanSu();
            fns.Show();
        }
        private void btnChucvu_Click(object sender, EventArgs e)
        {
            fChucVu fcv = new fChucVu();
            fcv.Show();
        }
        private void btnChamcong_Click(object sender, EventArgs e)
        {
            fQLchamcong fqlcc = new fQLchamcong();
            fqlcc.Show();
        }
        private void btnTruongphong_Click(object sender, EventArgs e)
        {
            fQLPhongBan fqltpb = new fQLPhongBan();
            fqltpb.Show();
        }
        private void btnThongtinDA_Click(object sender, EventArgs e)
        {
            fQLDuAn fqlda = new fQLDuAn(); 
            fqlda.Show();
        }
    }
}
