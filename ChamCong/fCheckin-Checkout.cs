using QLCongTy.ChamCong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy
{
    public partial class fCheckin_Checkout : Form
    {
        CheckInOutDAO ciod = new CheckInOutDAO();
        CheckInOut cio = new CheckInOut();
        public fCheckin_Checkout()
        {
            InitializeComponent();
        }
        private void fCheckin_Checkout_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            gvChecksang.DataSource = ciod.LayDanhSach();
            gvCheckchieu.DataSource = ciod.LayDanhSach();
        }

        private void gvChecksang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedrow = gvChecksang.SelectedRows[0];
            txtManvsang.Text = selectedrow.Cells["MaNV"].Value.ToString();
            txtMacvsang.Text = selectedrow.Cells["MaCV"].Value.ToString();
            cbCheckInsang.Text = selectedrow.Cells["CheckInSang"].Value.ToString();
            cbCheckInsang.Enabled = false;
            txtManvchieu.Text = selectedrow.Cells["MaNV"].Value.ToString();
            txtMacvchieu.Text = selectedrow.Cells["MaCV"].Value.ToString();
            cbCheckOutchieu.Text = selectedrow.Cells["CheckOutChieu"].Value.ToString();
            cbCheckOutchieu.Enabled = false;
        }
        private void btnSubmitsang_Click(object sender, EventArgs e)
        {
            ConvertCheck(cio);
            cio.MaNV = txtManvsang.Text;
            cio.Macv = txtMacvsang.Text;
            cio.Ngay = dtpCheckInsang.Value.Date;
            ciod.SubmitSang(cio);
            ReLoad();
        }
        private void btnSubmitchieu_Click(object sender, EventArgs e)
        {
            ConvertCheck(cio);
            ciod.SubmitChieu(cio);
            ReLoad();
            CheckNgayNghi(cio);
        }
        public void ConvertCheck(CheckInOut cio)
        {
            if (cbCheckInsang.Checked == true)
            {
                cio.CheckInSang = 1;
            }
            if (cbCheckOutchieu.Checked == true)
            {
                cio.CheckOutChieu = 1;
            }
        }
        public void CheckNgayNghi(CheckInOut cio)
        {
            if (cio.CheckInSang == 0 || cio.CheckOutChieu == 0)
            {
                ciod.PushToChamCongTB(cio.MaNV, cio.Macv, cio.Ngay, 0);
            }
            else
            {
                ciod.PushToChamCongTB(cio.MaNV, cio.Macv, cio.Ngay, 1);
            }
        }
    }
}
