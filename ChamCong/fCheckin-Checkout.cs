using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLConTy_Entity.MainMenu;

namespace QLConTy_Entity.ChamCong
{
    public partial class fCheckin_Checkout : Form
    {
        CheckInOutDAO ciod = new CheckInOutDAO();
        CHECKIN_OUT cio = new CHECKIN_OUT();
        public fCheckin_Checkout()
        {
            InitializeComponent();
        }
        private void fCheckin_Checkout_Load(object sender, EventArgs e)
        {
            ReLoad();
            txtManvsang.Text = fMainMenu.MaNV;
            txtManvchieu.Text = fMainMenu.MaNV;
            txtMacvsang.Text = fMainMenu.MaCV;
            txtMacvsang.Text = fMainMenu.MaCV;
        }
        public void ReLoad()
        {
            gvChecksang.DataSource = ciod.LayDanhSach($"SELECT * FROM PHANCONGDUAN WHERE MaNV = '{fMainMenu.MaNV}'");
            gvCheckchieu.DataSource = ciod.LayDanhSach($"SELECT * FROM PHANCONGDUAN WHERE MaNV = '{fMainMenu.MaNV}'");
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
            cio.MaCV = txtMacvsang.Text;
            cio.Ngay = dtpCheckInsang.Value.Date;
            ciod.SubmitSang(cio);
            ReLoad();
        }
        private void btnSubmitchieu_Click(object sender, EventArgs e)
        {
            ciod.DanhGiaCV(txtPhanTram.Text, lblMaDa.Text, txtManvchieu.Text);
            ConvertCheck(cio);
            ciod.SubmitChieu(cio);
            ReLoad();
            CheckNgay(cio);
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
        public void CheckNgay(CHECKIN_OUT cio)
        {
            if (cio.CheckInSang == false || cio.CheckOutChieu == false)
            {
                ciod.PushToChamCongTB(cio.MaNV, cio.MaCV, cio.Ngay, 0);
            }
            else
            {
                ciod.PushToChamCongTB(cio.MaNV, cio.MaCV, cio.Ngay, 1);
            }
        }
        private void Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvCheckchieu.SelectedRows[0];
            lblMaDa.Text = r.Cells[0].Value.ToString();
        }
    }
}
