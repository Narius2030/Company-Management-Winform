using QLCongTy.QLDuAn;
using QLCongTy.TienLuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.TienLuong
{
    public partial class fTienLuong : Form
    {
        TienLuongDAO tlDao = new TienLuongDAO();
        DBConnection db = new DBConnection();
        public fTienLuong()
        {
            InitializeComponent();
        }

        private void fTienLuong_Load(object sender, EventArgs e)
        {
            gvTienLuong.DataSource = tlDao.LDS();
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlStr = string.Format("SELECT * FROM TIENLUONG WHERE Nam = '{0}'", cboNam.Text);
            gvTienLuong.DataSource = tlDao.Loc(sqlStr);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.Text != "Năm")
            {
                string sqlStr = string.Format("SELECT * FROM TIENLUONG WHERE Nam = '{0}' AND Thang = '{1}'", cboNam.Text, cboThang.Text);
                gvTienLuong.DataSource = tlDao.Loc(sqlStr);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tlDao.TinhTienLuong();
            fTienLuong_Load(sender, e);
        }
    }
}
