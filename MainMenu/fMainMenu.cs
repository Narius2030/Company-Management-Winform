using QLCongTy.MainMenu;
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
        DangNhapDAO dao = new DangNhapDAO();
        public fMainMenu()
        {
            InitializeComponent();
        }
        private void fMainMenu_Load(object sender, EventArgs e)
        {
            tabQLThumuc.TabPages.Clear();
            tabDangNhap.TabPages.Remove(tpDoiMK);
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string cv;
            cv = dao.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (cv == null) return;
            lblTenTk.Text = txtTaiKhoan.Text;
            tabDangNhap.TabPages.Add(tpDoiMK);
            btnThoat.Visible = true;
            btnDangNhap.Enabled = false;

            if (cv == "QL")
            {
                tabQLThumuc.TabPages.Add(tpQLNhansu);
                tabQLThumuc.TabPages.Add(tpQLPhongban);
                tabQLThumuc.TabPages.Add(tpQLTiendo);
                tabQLThumuc.TabPages.Add(tpQLKpi);
                tabQLThumuc.TabPages.Add(tpQLDuan);
                tabQLThumuc.TabPages.Add(tpQLChamcong);
            }   
                             
                
            if (cv == "NV")
            {
                btnChamcong.Enabled = false;
                btnNgaynghi.Enabled = false;
                tabQLThumuc.TabPages.Add(tpQLChamcong);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fMainMenu_Load(sender, e); 
            btnDangNhap.Enabled=true;
            btnThoat.Visible=false;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            lblTenTk.Text = "";           
        }

        private void btnDoiMk_Click(object sender, EventArgs e)
        {
            dao.DoiMatKhau(lblTenTk.Text, txtMatKhauMoi.Text, txtNhapLaiMK.Text);
        }

        private void picAnHienMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }

        private void picAnHienMkMoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.PasswordChar == '*')
                txtMatKhauMoi.PasswordChar = '\0';
            else
                txtMatKhauMoi.PasswordChar = '*';
        }

        private void picAnHienNhapLaiMk_Click(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.PasswordChar == '*')
                txtNhapLaiMK.PasswordChar = '\0';
            else
                txtNhapLaiMK.PasswordChar = '*';
        }
    }
}
