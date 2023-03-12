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
    public partial class fQLDAThamGia : Form
    {
        QLDAThamGiaDAO dao = new QLDAThamGiaDAO();  
        public fQLDAThamGia()
        {
            InitializeComponent();
        }

        private void fQLDAThamGia_Load(object sender, EventArgs e)
        {
            
            gvDAThamGia.DataSource = dao.LDS();
            DoiTen(gvDAThamGia);
        }
        void DoiTen(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Mã Dự Án";
            dataGridView.Columns[1].HeaderText = "Tên Dự Án";
            dataGridView.Columns[2].HeaderText = "Mã Phong Ban";
            dataGridView.Columns[3].HeaderText = "Tên Phong Ban";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dao.Sua(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtTenPB.Text);
            gvDAThamGia.DataSource = dao.LDS();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {          
            gvDAThamGia.DataSource = dao.TimKiem(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtTenPB.Text);
        }

        private void gvDAThamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            DataGridViewRow row = gvDAThamGia.Rows[e.RowIndex];
            txtMaDA.Text = row.Cells[0].Value.ToString();
            txtTenDA.Text = row.Cells[1].Value.ToString();
            txtMaPB.Text = row.Cells[2].Value.ToString();
            txtTenPB.Text = row.Cells[3].Value.ToString();
        }

        private void gvDAThamGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
