using QLCongTy.QLDuAn;
using QLCongTy.QLPhongBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy
{
    public partial class fQLDuAn : Form
    {        
        DuAnDAO daDao= new DuAnDAO();
        public fQLDuAn()
        {
            InitializeComponent();
        }

        private void fQLDuAn_Load(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource= daDao.LDS("select *from DUAN");
            gvPCDuAn.DataSource = daDao.LDS("select *from PHANCONGDUAN");
            gvNhanLuc.DataSource = daDao.LDS("select *from THONGSONHANVIEN");
            DoiTen();
        }
        void DoiTen()
        {
            gvQLDuAn.Columns[0].HeaderText = "Mã Dự Án";
            gvQLDuAn.Columns[1].HeaderText = "Tên Dự Án";
            gvQLDuAn.Columns[2].HeaderText = "Mã Phong Ban";
            gvQLDuAn.Columns[3].HeaderText = "Vốn Điều Hành";
            gvQLDuAn.Columns[4].HeaderText = "Mã Trưởng Dự Án";
            gvQLDuAn.Columns[5].HeaderText = "Bắt Đầu";
            gvQLDuAn.Columns[6].HeaderText = "Kết Thúc";
            gvQLDuAn.Columns[7].HeaderText = "Trạng Thái";

            gvPCDuAn.Columns[0].HeaderText = "Mã Dự Án";
            gvPCDuAn.Columns[1].HeaderText = "Mã Nhân Viên";
            gvPCDuAn.Columns[2].HeaderText = "Tên Nhân Viên";
            gvPCDuAn.Columns[3].HeaderText = "Bắt Đầu";
            gvPCDuAn.Columns[4].HeaderText = "Kết Thúc";

            gvNhanLuc.Columns[0].HeaderText = "Mã Nhân Viên";
            gvNhanLuc.Columns[1].HeaderText = "Trình Độ";
            gvNhanLuc.Columns[2].HeaderText = "Trạng Thái";
            gvNhanLuc.Columns[3].HeaderText = "Đánh Giá";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            daDao.Them(da);
            gvQLDuAn.DataSource = daDao.LDS("select *from DUAN");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            daDao.Sua(da);
            gvQLDuAn.DataSource = daDao.LDS("select *from DUAN");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            daDao.Xoa(da);
            gvQLDuAn.DataSource = daDao.LDS("select *from DUAN");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            gvQLDuAn.DataSource = daDao.TimKiem(da);
        }

        private void cboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select *from THONGSONHANVIEN where TrinhDo = '{0}'", cboTrinhDo.Text);
            gvNhanLuc.DataSource = daDao.LDS(sqlStr);
        }

        private void btnThemNVvaoDA_Click(object sender, EventArgs e)
        {
            PCNhanLuc pcnl = new PCNhanLuc(txtMaDA.Text, txtMaNV.Text, txtTenNV.Text, dtpStart.Value.Date, dtpFinish.Value.Date);
            daDao.ThemNVvaoDA(pcnl);
            gvPCDuAn.DataSource = daDao.LDS("select *from PHANCONGDUAN");
        }

        private void DuAn_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvQLDuAn.SelectedRows[0];
            txtMaDA.Text = r.Cells[0].Value.ToString();
            txtTenDA.Text = r.Cells[1].Value.ToString();
            txtMaPB.Text = r.Cells[2].Value.ToString();
            txtMaTruongDA.Text = r.Cells[4].Value.ToString();
            dtpNgayBatDau.Text = r.Cells[5].Value.ToString();
            dtpNgayKetThuc.Text = r.Cells[6].Value.ToString();
            cboTrangThai.Text = r.Cells[7].Value.ToString();
        }

        private void NhanLuc_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvNhanLuc.SelectedRows[0];
            txtMaNV.Text = r.Cells[0].Value.ToString();
            txtTenNV.Text = r.Cells[1].Value.ToString();
        }
    }
}
