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
    public partial class fNhanSu : Form
    {
        NhanSu ns;
        NhanSuDAO nsDao = new NhanSuDAO();
        public fNhanSu()
        {
            InitializeComponent();
        }

        private void FNhanSu_Load(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.DanhSach();
            DoiTenGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ns = new NhanSu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Xoa(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ns = new NhanSu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Them(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ns = new NhanSu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Sua(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
        }

        private void Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvNhanSu.SelectedRows[0];
            txtMaNV.Text = r.Cells[0].Value.ToString();
            txtHoDem.Text = r.Cells[1].Value.ToString();
            txtTenNV.Text = r.Cells[2].Value.ToString();
            dtpNgaySinh.Text = r.Cells[3].Value.ToString();
            txtDiaChi.Text = r.Cells[4].Value.ToString();
            txtCCCD.Text = r.Cells[5].Value.ToString();
            txtMaPB.Text = r.Cells[6].Value.ToString();
            txtGioiTinh.Text = r.Cells[7].Value.ToString();
            txtSDT.Text = r.Cells[8].Value.ToString();
            txtEmail.Text = r.Cells[9].Value.ToString();
            txtMaCV.Text = r.Cells[10].Value.ToString();
        }

        private void DoiTenGV()
        {
            string[] thuoctinh = { "Mã Nhân Viên", "Họ Đệm", "Tên", "Ngày Sinh", "Địa Chỉ", "CCCD", "Mã Phòng Ban", "Giới Tính", "SĐT", "Email", "MaCV" };
            for (int i = 0; i < thuoctinh.Length; i++)
            {
                gvNhanSu.Columns[i].HeaderText = thuoctinh[i];
            }
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboPhongBan.Text.ToString().Substring(0, 4);
            gvNhanSu.DataSource = nsDao.Loc("MaPB", value);
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.Loc("MaCV", cboChucVu.Text);
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.Loc("GioiTinh", cboGioiTinh.Text);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            switch (cboLocKhac.Text)
            {
                case "Mã Nhân Viên":
                    gvNhanSu.DataSource = nsDao.Loc("MaNV", txtThongTinLoc.Text);
                    break;
                case "Họ Đệm":
                    gvNhanSu.DataSource = nsDao.Loc("HovaTendem", txtThongTinLoc.Text);
                    break;
                case "Tên":
                    gvNhanSu.DataSource = nsDao.Loc("Ten", txtThongTinLoc.Text);
                    break;
                case "CCCD":
                    gvNhanSu.DataSource = nsDao.Loc("CCCD", txtThongTinLoc.Text);
                    break;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.DanhSach();
        }
    }
}
