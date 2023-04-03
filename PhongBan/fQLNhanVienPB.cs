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

namespace QLConTy_Entity.PhongBan
{
    public partial class FQLNhanVienPB : Form
    {
        QLNhanVienPBDAO dao = new QLNhanVienPBDAO();
        public FQLNhanVienPB()
        {
            InitializeComponent();
        }
        private void fQLNhanVienPB_Load(object sender, EventArgs e)
        {
            
        }
        void DoiTen(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Mã Phong Ban";
            dataGridView.Columns[1].HeaderText = "Tên Phong Ban";
            dataGridView.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGridView.Columns[3].HeaderText = "Tên Nhân Viên";
        }
        private void gvNhanVienPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            DataGridViewRow row = gvNhanVienPB.Rows[e.RowIndex];
            txtMaPhongBan.Text = row.Cells[0].Value.ToString();
            txtTenPhongBan.Text = row.Cells[1].Value.ToString();
            txtMaNhanVien.Text = row.Cells[2].Value.ToString();
            txtTenNhanVien.Text = row.Cells[3].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            dao.Sua(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaNhanVien.Text, txtTenNhanVien.Text);
            gvNhanVienPB.DataSource = dao.TimKiem(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaNhanVien.Text, txtTenNhanVien.Text);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gvNhanVienPB.DataSource = dao.TimKiem(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaNhanVien.Text, txtTenNhanVien.Text);
            gvTruongPhong.DataSource = dao.LDSTP(txtMaPhongBan.Text);
            DoiTen(gvNhanVienPB);
            DoiTen(gvTruongPhong);
        }
    }
}
