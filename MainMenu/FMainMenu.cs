using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLConTy_Entity.ChamCong;
using QLConTy_Entity.NhanSu;
using QLConTy_Entity.PhongBan;
using QLConTy_Entity.DuAn;

namespace QLConTy_Entity.MainMenu
{
    public partial class fMainMenu : Form
    {
        //Fields 
        private IconButton currentBtn;  //Button hien tai
        private Panel leftBorderBtn;    //Bien phia ben trai button
        private Form currentChildForm;  //Form chuc nang hien tai
        //Fields dang nhap
        DangNhapDAO dao = new DangNhapDAO();
        static public string MaNV;
        static public string MaCV;
        public fMainMenu()
        {
            InitializeComponent();
            CustomizeDesing();
            leftBorderBtn= new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Login
            txtMatKhau.PasswordChar = '*';
        }

        #region Hide panel
        private void CustomizeDesing()
        {
            pnlNhanSu.Visible = false;
            btnNhanSu.Visible = false;
            btnDuAn.Visible = false;
        }

        //Phương thức HidePanel() và ShowPanel() có khả năng trùng lặp trên nhiều form >>> Chưa được xử lý
        private void HidePanel()
        {
            if (pnlNhanSu.Visible)
            {
                pnlNhanSu.Visible = false;
            }
            if (pnlLogin.Visible)
            {
                pnlLogin.Visible = false;
            }
        }

        private void ShowMenuPanel(Panel Menupnl)
        {
            if (Menupnl.Visible == false)
            {
                HidePanel();
                Menupnl.Visible= true;
            }
            else
            {
                Menupnl.Visible = false;
            }
        }
        #endregion

        # region Struct color
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
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
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
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
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
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
            currentChildForm = new Form();
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

        #region Nhân sự 
        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ShowMenuPanel(pnlNhanSu);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FNhanSu());
            HidePanel();
        }
        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLNhanVienPB());
            HidePanel();
        }

        #endregion

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new fQLDuAn());
        }

        //private void btnLuong_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(sender, RGBColors.color3);
        //    OpenChildForm(new fTienLuong());
        //}
        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new fCheckin_Checkout());
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            Reset();
            //pnlDesktop.Refresh();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            picCurrentChildForm.IconChar = IconChar.Home;
            picCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

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

        private void fMainMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cv;
            cv = dao.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
            if (cv == null) return;
            if (cv == "QL")
            {
                btnNhanSu.Visible = true;
                btnDuAn.Visible = true;
            }
            MaNV = txtTaiKhoan.Text;
            MaCV = cv;
            lblTenNV.Text = MaNV;
            HidePanel();
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

        
    }
}
