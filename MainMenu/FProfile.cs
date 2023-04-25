using QLCongTy.ChamCong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace QLCongTy
{
    public partial class FProfile : Form
    {
        ProfileDAO pfd = new ProfileDAO();
        bool sidebarExpand;
        Panel currentPanel = new Panel();
        public FProfile()
        {
            InitializeComponent();
            CustomizeDesing();
            LoadProfile();
            lblTenNV.Text = fMainMenu.currentStaff.HoDem + " " + fMainMenu.currentStaff.Ten;
            lblMaNV.Text = fMainMenu.currentStaff.MaNV;
        }
        private void FProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadProfile()
        {
            lblMaNV.Text = fMainMenu.MaNV;
            lblTenNV.Text = "";
        }

        private void CustomizeDesing()
        {
            pnlTTCN.Visible = false;
            pnlDuAn.Visible = false;
            pnlLuong.Visible = false;
            pnlXinNghiPhep.Visible = false;
            pnlBaoMat.Visible = false;
            pnlDoiMatKhau.Visible = false;
        }
        private void HidePanel()
        {
            if (currentPanel.Visible)
            {
                currentPanel.Visible = false;
            }
        }

        private void ShowPanel()
        {
            if (currentPanel.Visible == false)
            {
                currentPanel.Visible = true;
            }
        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            //Set the minimum and maximum size of sidebar panel
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ///set timer interval to lowest to make it smoother
            sidebarTimer.Start();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            HidePanel();

            currentPanel = pnlTTCN;
            ShowTTCN();

            ShowPanel();
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            HidePanel();

            currentPanel = pnlDuAn;
            gvDuAn.DataSource = pfd.GetDuAn(fMainMenu.currentStaff);

            ShowPanel();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            HidePanel();

            currentPanel = pnlLuong;
            ShowLuong();

            ShowPanel();
        }

        private void btnXinNghiPhep_Click(object sender, EventArgs e)
        {
            HidePanel();
            currentPanel = pnlXinNghiPhep;
            ShowPanel();
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            HidePanel();
            currentPanel = pnlBaoMat;
            lblTaiKhoan.Text = fMainMenu.currentStaff.MaNV;
            lblMatKhau.Text = pfd.GetMatKhau(fMainMenu.currentStaff);
            ShowPanel();
        }

        private void btnUpdateMatKhau_Click(object sender, EventArgs e)
        {
            pnlDoiMatKhau.Visible = false;
            pfd.DoiMatKhau(fMainMenu.currentStaff,txtMatKhauCu.Text, txtMatKhauMoi.Text);
            lblMatKhau.Text = pfd.GetMatKhau(fMainMenu.currentStaff);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            pnlDoiMatKhau.Visible = true;
        }

        private void btnGuiDonXinNghi_Click(object sender, EventArgs e)
        {
            ThongTinXinNghi ttxn = new ThongTinXinNghi(fMainMenu.currentStaff.MaNV, dtpNgayNghi.Value, cboLyDoNghi.Text);
            //Cập nhật bảng xin nghỉ.
            pfd.CapNhatBangXinNghi(ttxn);
        }

        private void ShowLuong()
        {
            var luong = pfd.LayThongTinLuong(lblMaNV.Text);
            int i = 0;
            foreach (var control in pnlThongtinluong.Controls.OfType<TextBox>())
            {
                control.Text = luong[i].ToString();
                i++;
            }
        }

        public void ShowTTCN()
        {
            var info = pfd.LayThonTinCN();
            int i = 0;
            foreach (var control in pnlTTCN.Controls.OfType<VBLabel>())
            {
                control.Text = info[i];
                i++;
            }
        }
    }
}
