using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.QLDuAn
{
    public partial class TaoDuAn : Form
    {
        public TaoDuAn()
        {
            InitializeComponent();
        }

        private void TaoDuAn_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            //switch (lblTitle.Text)
            //{
            //    case "Thêm dự án":
            //        daDao.Them(da);
            //        break;
            //    case "Xóa dự án":
            //        daDao.Xoa(da);
            //        break;
            //    case "Sửa dự án":
            //        daDao.Sua(da);
            //        break;
            //}
            //gvQLDuAn.DataSource = daDao.LayDanhSach("select *from DUAN");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
