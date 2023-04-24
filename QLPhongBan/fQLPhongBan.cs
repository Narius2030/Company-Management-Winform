using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCongTy.QLPhongBan;

namespace QLCongTy
{
    public partial class FQLPhongBan : Form
    {
        PhongBanDAO dao = new PhongBanDAO();
        public FQLPhongBan()
        {
            InitializeComponent();
        }

        private void fQLPhongBan_Load(object sender, EventArgs e)
        {
            gvPhongBan.DataSource = dao.LDS();
            DoiTen(gvPhongBan);
        }

        private void gvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void DoiTen(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Mã Phong Ban";
            dataGridView.Columns[1].HeaderText = "Tên Phong Ban";
            dataGridView.Columns[2].HeaderText = "Mã Trưởng Phòng";
            dataGridView.Columns[3].HeaderText = "Tên Trưởng Phong";
        }

        private void gvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
              if (e.ColumnIndex == -1 || e.RowIndex == -1 ) return;
              DataGridViewRow row = gvPhongBan.Rows[e.RowIndex];
              txtMaPhongBan.Text = row.Cells[0].Value.ToString();
              txtTenPhongBan.Text = row.Cells[1].Value.ToString();
              txtMaTruongPhong.Text = row.Cells[2].Value.ToString();
              txtTenTruongPhong.Text = row.Cells[3].Value.ToString();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan(txtMaPhongBan.Text,txtTenPhongBan.Text,txtMaTruongPhong.Text);
            dao.Them(pb);
            gvPhongBan.DataSource = dao.LDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaTruongPhong.Text);
            dao.Xoa(pb);
            gvPhongBan.DataSource = dao.LDS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaTruongPhong.Text);
            dao.Sua(pb);
            gvPhongBan.DataSource = dao.LDS();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PhongBan pb = new PhongBan(txtMaPhongBan.Text, txtTenPhongBan.Text, txtMaTruongPhong.Text);
            gvPhongBan.DataSource = dao.TimKiem(pb);
        }
    }
}
