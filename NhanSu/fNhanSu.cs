﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.NhanSu
{
    public partial class FNhanSu : Form
    {
        Nhansu ns;
        NhanSuDAO nsDao = new NhanSuDAO();
        public FNhanSu()
        {
            InitializeComponent();
        }

        private void FNhanSu_Load(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.DanhSach();
            DoiTenGV();
            ThongKeLuong();
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
            cboGTinh.Text = r.Cells[7].Value.ToString();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            ns = new Nhansu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, cboGTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Them(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ns = new Nhansu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, cboGTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Xoa(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            ns = new Nhansu(txtMaNV.Text, txtHoDem.Text, txtTenNV.Text, dtpNgaySinh.Value.Date, txtDiaChi.Text, txtCCCD.Text, txtMaPB.Text, txtMaCV.Text, cboGTinh.Text, txtSDT.Text, txtEmail.Text);
            nsDao.Sua(ns);
            gvNhanSu.DataSource = nsDao.DanhSach();
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
        #region Vẽ biểu đồ

        public void ThongKeLuong()
        {
            //Dùng Series.Points.Add()

            chartLayLuongThang.Series[3].XValueMember = "thang";
            chartLayLuongThang.Series[3].YValueMembers = "luong";

            chartLayLuongThang.DataBind();
        }

        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            gvNhanSu.DataSource = nsDao.DanhSach();
            cboChucVu.Text = "";
            cboGioiTinh.Text = "";
            cboLocKhac.Text = "";
            cboPhongBan.Text = "";
            txtThongTinLoc.Clear();
        }

        #region Sidebar
        bool sidebarExpand;
        private void tmSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlTool.Width -= 10;
                if (pnlTool.Width == pnlTool.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmSidebar.Stop();
                }
            }
            else
            {
                pnlTool.Width += 10;
                if (pnlTool.Width == pnlTool.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmSidebar.Stop();
                }
            }
        }

        private void tmThongKe_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlThongKe.Width -= 200;
                if (pnlThongKe.Width == pnlThongKe.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmThongKe.Stop();
                }
            }
            else
            {
                pnlThongKe.Width += 50;
                if (pnlThongKe.Width == pnlThongKe.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmThongKe.Stop();
                }
            }
        }

        private void tmDangKy_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlDangKy.Width -= 200;
                if (pnlDangKy.Width == pnlDangKy.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    tmDangKy.Stop();
                }
            }
            else
            {
                pnlDangKy.Width += 50;
                if (pnlDangKy.Width == pnlDangKy.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    tmDangKy.Stop();
                }
            }
        }
        #endregion

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tmThongKe.Start();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            tmDangKy.Start();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tmSidebar.Start();
        }
    }
}
