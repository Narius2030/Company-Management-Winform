using Entity_QLCongTy.ChamCong;
using Entity_QLCongTy.QLDuAn;
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
    public partial class fCheckin_Checkout : Form
    {
        CheckInOutDAO ciod = new CheckInOutDAO();
        CHECKIN_OUT cio = new CHECKIN_OUT();
        ChamCongDAO ccd = new ChamCongDAO();
        DuAnDAO dad = new DuAnDAO();
        PHANCONGDUAN pc = null;
        public fCheckin_Checkout()
        {
            InitializeComponent();
        }

        private void fCheckin_Checkout_Load(object sender, EventArgs e)
        {
            ReLoad();
            txtManvsang.Texts = fMainMenu.MaNV;
            txtManvchieu.Texts = fMainMenu.MaNV;
            txtMacvsang.Texts = fMainMenu.MaCV;
            txtMacvchieu.Texts = fMainMenu.MaCV;
        }

        public void ReLoad()
        {
            gvChecksang.DataSource = ciod.LayDanhSach(fMainMenu.MaNV);
            gvCheckchieu.DataSource = ciod.LayDanhSach(fMainMenu.MaNV);
        }
        private void btnSubmitCheckout_Click(object sender, EventArgs e)
        {
            ccd.InsertChamCong();
            ConvertCheck(cio);
            ciod.SubmitChieu(cio);
            //Tính số ngày đi làm sau khi checkin_out
            CheckNgayNghi(cio);
            //Thông báo
            MessageBox.Show("Đã check out thành công");
        }
        private void btnCapnhatTiendoDA_Click(object sender, EventArgs e)
        {
            //Điền thông tin điểm danh cho cio
            cio.MaNV = txtManvchieu.Texts;
            cio.Ngay = dtpCheckOut.Value.Date;
            //Cập nhật CheckInOut
            if (pc != null)
            {
                ciod.DanhGiaCV(int.Parse(txtPhanTram.Texts), pc.MaNV, pc.NgayBD, pc.NgayKT);
                dad.TienDoDuAn(pc.MaDA);
            }
            ReLoad();
        }
        private void btnSubmitsang_Click(object sender, EventArgs e)
        {
            ConvertCheck(cio);
            cio.MaNV = txtManvsang.Texts;
            cio.Ngay = dtpCheckIn.Value.Date;
            ciod.SubmitSang(cio);
            //Thông báo
            MessageBox.Show("Đã check in thành công");
            ReLoad();
        }
        public void ConvertCheck(CHECKIN_OUT cio)
        {
            if (cbCheckInsang.Checked == true)
            {
                cio.CheckInSang = true;
            }
            if (cbCheckOutchieu.Checked == true)
            {
                cio.CheckOutChieu = true;
            }
        }

        public void CheckNgayNghi(CHECKIN_OUT cio)
        {
            //Kiểm tra nhân viên đã check đủ 2 buổi không
            bool check = ciod.CheckDiLam(txtManvchieu.Texts, dtpCheckOut.Value);
            if (!check)
            {
                ciod.UpdateNgDiLam(cio.MaNV, cio.Ngay, 0);
            }
            else
            {
                ciod.UpdateNgDiLam(cio.MaNV, cio.Ngay, 1);
            }
        } 

        private void gvCheckchieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = gvCheckchieu.SelectedRows[0];
            pc = new PHANCONGDUAN();
            pc.MaNV = rows.Cells["MaNV"].Value.ToString();
            pc.MaDA = rows.Cells["MaDA"].Value.ToString();
            pc.NgayBD = DateTime.Parse(rows.Cells["NgayBD"].Value.ToString());
            pc.NgayKT = DateTime.Parse(rows.Cells["NgayKT"].Value.ToString());
        }
    }
}
