using QLCongTy;
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
    public partial class fChucVu : Form
    {
        ChucVu cv;
        ChucVuDao cvDao = new ChucVuDao();
        public fChucVu()
        {
            InitializeComponent();
        }

        private void FChucVu_Load(object sender, EventArgs e)
        {
            gvChucVu.DataSource = cvDao.DanhSach();
            DoiTenGV();
        }

        private void DoiTenGV()
        {
            string[] thuoctinh = {"Mã chức vụ", "Tên chức vụ"};
            for (int i = 0; i < thuoctinh.Length; i++)
            {
                gvChucVu.Columns[i].HeaderText = thuoctinh[i];
            }
        }

        private void Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvChucVu.SelectedRows[0];
            txtMaChucVu.Text = r.Cells[0].Value.ToString();
            txtTenChucVu.Text = r.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cv = new ChucVu(txtMaChucVu.Text, txtTenChucVu.Text);
            cvDao.Them(cv);
            gvChucVu.DataSource = cvDao.DanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cv = new ChucVu(txtMaChucVu.Text, txtTenChucVu.Text);
            cvDao.Xoa(cv);
            gvChucVu.DataSource = cvDao.DanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cv = new ChucVu(txtMaChucVu.Text, txtTenChucVu.Text);
            cvDao.Sua(cv);
            gvChucVu.DataSource = cvDao.DanhSach();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            switch (cboLoc.Text)
            {
                case "Mã chức vụ":
                    gvChucVu.DataSource = cvDao.Loc("MaCV", txtThongTinLoc.Text);
                    break;
                case "Tên chức vụ":
                    gvChucVu.DataSource = cvDao.Loc("TenCV", txtThongTinLoc.Text);
                    break;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gvChucVu.DataSource = cvDao.DanhSach();
        }
    }
}
