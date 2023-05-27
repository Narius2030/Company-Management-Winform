using Entity_QLCongTy.ChamCong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_QLCongTy
{
    public partial class fDuyetDonXinNghi : Form
    {
        ThongTinXinNghiDAO ttxnDao = new ThongTinXinNghiDAO();
        
        public fDuyetDonXinNghi()
        {
            InitializeComponent();
        }

        private void fDuyetDonXinNghi_Load(object sender, EventArgs e)
        {
            gvDSxinghi.DataSource = ttxnDao.LayDanhSach(fMainMenu.currentStaff.MaNV);
        }

        private void gvDSxinghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = gvDSxinghi.SelectedRows[0];
            string phanhoi;
            NGHIPHEP ttxn = new NGHIPHEP(r.Cells[0].Value.ToString(), Convert.ToDateTime(r.Cells[1].Value.ToString()), r.Cells[2].Value.ToString());
            DialogResult result = MessageBox.Show($"{ttxn.MANV} xin nghỉ ngày {ttxn.NGAYNGHI.ToString()}", "Duyệt đơn xin nghỉ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                phanhoi = "da duyet";
                //Cập nhật lý do nghi
                ttxnDao.CapNhatLyDoNghi(ttxn);
                //Giảm số ngày nghỉ phép
                ttxnDao.GiamSoNgNghiPhep(ttxn);
                // Cập nhật phan hồi
                ttxnDao.CapNhatBangXinNghi(ttxn, phanhoi);
                gvDSxinghi.DataSource = ttxnDao.LayDanhSach(fMainMenu.currentStaff.MaNV);
            }
            if (result == DialogResult.No)
            {
                //ttxnDao.XoaDon(ttxn);
                phanhoi = "tu choi";
                // Cập nhật phan hồi
                ttxnDao.CapNhatBangXinNghi(ttxn, phanhoi);
            }
            fDuyetDonXinNghi_Load(sender, e);
        }
    }
}
