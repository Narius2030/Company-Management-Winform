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
            gvQLDuAn.Columns[0].HeaderText = "Mã Dự Án";
            gvQLDuAn.Columns[1].HeaderText = "Tên Dự Án";
            gvQLDuAn.Columns[2].HeaderText = "Mã Phong Ban";
            gvQLDuAn.Columns[3].HeaderText = "Vốn Điều Hành";
            gvQLDuAn.Columns[4].HeaderText = "Mã Trưỡng Dự Án";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text,txtMaTruongDA.Text);
            gvQLDuAn.DataSource = dao.TimKiem(da);      
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text);
            dao.Xoa(da);
            gvQLDuAn.DataSource = dao.LDS();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text);
            dao.Sua(da);
            gvQLDuAn.DataSource = dao.LDS();
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text);
            dao.Them(da);
            gvQLDuAn.DataSource = dao.LDS();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void gvQLDuAn_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gvQLDuAn.SelectedRows[0];
            txtMaDA.Text = row.Cells[0].Value.ToString();
            txtTenDA.Text = row.Cells[1].Value.ToString();
            txtMaPB.Text = row.Cells[2].Value.ToString();
            txtMaTruongDA.Text = row.Cells[4].Value.ToString();
        }

       
    }
}
