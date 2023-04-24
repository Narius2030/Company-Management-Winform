﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLCongTy.MainMenu;
using QLCongTy.TienLuong;
using QLCongTy.NhanSu;
using QLCongTy.QLDuAn;
using QLCongTy;

namespace QLCongTy
{
    public partial class fMainMenu : Form
    {
        //Fields 
        private IconButton currentBtn;  //Button hien tai
        private Panel leftBorderBtn;    //Bien phia ben trai button
        private Form currentChildForm;  //Form chuc nang hien tai
        //Fields dang nhap
        DangNhapDAO dao = new DangNhapDAO();
        public static Nhansu currentStaff;
        public static string MaNV;
        public static string MaCV;
        public bool Account = false;
        public fMainMenu()
        {
            InitializeComponent();
            CustomizeDesing();
            leftBorderBtn= new Panel();
            leftBorderBtn.Size = new Size(10, 86);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Login
            txtMatKhau.PasswordChar = '*';
        }

        private void fMainMenu_Load(object sender, EventArgs e)
        {
            tmCurrentTime.Start();
        }

        #region Hide panel
        private void CustomizeDesing()
        {
            
            pnlAccount.Visible = false;
            pnlNhanSu.Visible= false;
        }
        #region Xử lý Form con

        //Phương thức HidePanel() và ShowPanel() có khả năng trùng lặp trên nhiều form >>> Chưa được xử lý
        private void HidePanel(Panel pnl)
        {
            if (pnl.Visible)
            {
                pnl.Visible = false;
            }
        }

        private void ShowPanel(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                HidePanel(pnl);
                pnl.Visible= true;
            }
            else
            {
                pnl.Visible = false;
            }
        }

        # region Struct color
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(12, 12, 171);
        }
        #endregion
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(4, 41, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                picCurrentChildForm.IconChar = currentBtn.IconChar;
                picCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(35, 37, 45);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm!= null)
            {
                //Chi 1 form duoc phep hien thi
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = pnlDesktop.Size;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = currentBtn.Text;
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
            HidePanel(pnlLogin);
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            picCurrentChildForm.IconChar = IconChar.Home;
            picCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        #endregion

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Design_Click
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState= FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }
        #endregion

        #region Chức năng Form con
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Dealing with Login
            var infoAcc = dao.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            currentStaff = dao.GetInfo(txtTaiKhoan.Text);
            //Enable feature base on their ChucVu
            if (infoAcc.Item3 == null) 
                return;
            if (infoAcc.Item3.Contains("TP") || infoAcc.Item3.Contains("GD"))
            {

            }
            else
            {
                btnLuong.Visible= false;
                btnDuAn.Visible = false;
                pnlNhanSu.Visible = false;
                btnNhanSu.Visible = false;
            }
            Account = true;

            //Assigning to NhanSu variables
            MaNV = infoAcc.Item1;
            MaCV = infoAcc.Item3;
            lblTenNV.Text = currentStaff.HoDem + " " + currentStaff.Ten;
            HidePanel(pnlLogin);
            ShowPanel(pnlAccount);
        }
        private void btnShowPW_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                txtMatKhau.PasswordChar = '\0';
                btnShowPW.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                btnShowPW.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowPanel(pnlNhanSu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanSu());
            HidePanel(pnlNhanSu);        
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLNhanVienPB());
            HidePanel(pnlNhanSu);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new fQLDuAn());
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new fTienLuong());
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fCheckin_Checkout());        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FProfile());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            lblTitleChildForm.Text = "Đăng nhập";
            Account = false;
            pnlLogin.Visible = true;
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            pnlAccount.Visible = false;
        }
        #endregion

        private void tmCurrentTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}