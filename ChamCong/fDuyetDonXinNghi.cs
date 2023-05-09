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
            gvDSXinNghi.DataSource = ttxnDao.LayDanhSach();
        }

        private void gvDSXinNghi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvDSXinNghi.SelectedRows[0];
            NGHIPHEP ttxn = new NGHIPHEP();
            ttxn.MANV = r.Cells[0].Value.ToString();
            ttxn.NGAYNGHI = Convert.ToDateTime(r.Cells[1].Value.ToString());
            ttxn.LYDO = r.Cells[2].Value.ToString();
            //MessageBox.Show($"{ttxn.Ngaynghi.ToString()}");
            DialogResult result = MessageBox.Show($"{ttxn.MANV} xin nghỉ ngày {ttxn.NGAYNGHI.ToString()}", "Duyệt đơn xin nghỉ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ttxnDao.XoaDon(ttxn);
                //Cập nhật lý do nghi
                ttxnDao.CapNhatLyDoNghi(ttxn);
                //Giảm số ngày nghỉ phép
                ttxnDao.GiamSoNgNghiPhep(ttxn);
                gvDSXinNghi.DataSource = ttxnDao.LayDanhSach();
            }
            if (result == DialogResult.No)
            {
                ttxnDao.XoaDon(ttxn);
            }
        }
    }
}
