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
        DuAnDAO dao= new DuAnDAO();
        public fQLDuAn()
        {
            InitializeComponent();
        }

        private void fQLDuAn_Load(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource= dao.LDS();
            DoiTen(gvQLDuAn);

        }
        void DoiTen(DataGridView dataGridView)
        {
            dataGridView.Columns[0].HeaderText = "Mã Dự Án";
            dataGridView.Columns[1].HeaderText = "Tên Dự Án";
            dataGridView.Columns[2].HeaderText = "Mã Phong Ban";
            dataGridView.Columns[3].HeaderText = "Vốn Điều Hành";
            dataGridView.Columns[4].HeaderText = "Mã Trưỡng Dự Án";
        }

        private void gvQLDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;
            DataGridViewRow row = gvQLDuAn.Rows[e.RowIndex];
            txtMaDA.Text = row.Cells[0].Value.ToString();
            txtTenDA.Text = row.Cells[1].Value.ToString();
            txtMaPB.Text = row.Cells[2].Value.ToString();
            txtMaTruongDA.Text = row.Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text,txtTenDA.Text,txtMaPB.Text,txtMaTruongDA.Text);
            dao.Them(da);
            gvQLDuAn.DataSource = dao.LDS();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text,  txtMaTruongDA.Text);
            dao.Xoa(da);
            gvQLDuAn.DataSource = dao.LDS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text,  txtMaTruongDA.Text);
            dao.Sua(da);
            gvQLDuAn.DataSource = dao.LDS();
        }

       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text,txtMaTruongDA.Text);
            gvQLDuAn.DataSource = dao.TimKiem(da);      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
