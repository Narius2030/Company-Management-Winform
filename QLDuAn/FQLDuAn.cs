using Microsoft.SqlServer.Server;
using QLCongTy.QLDuAn;
using QLCongTy.QLPhongBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.QLDuAn
{
    public partial class fQLDuAn : Form
    {        
        DuAnDAO daDao= new DuAnDAO();
        DBConnection db = new DBConnection();
        public fQLDuAn()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void fQLDuAn_Load(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource= daDao.LayDanhSach("select *from DUAN");
            daDao.InitStatusTB();
            gvNhanLuc.DataSource = daDao.LayDanhSach("select MaNV, TrinhDo from TRANGTHAINHANVIEN");
            tabQLDA.Controls.Remove(tpPCDA);
            DoiTen();
        }

        #region Hide Show panel
        private void CustomizeDesing()
        {
            pnlEdit.Visible = false;
        }

        //Phương thức HidePanel() và ShowPanel() có khả năng trùng lặp trên nhiều form >>> Chưa được xử lý
        private void HidePanel()
        {
            if (pnlEdit.Visible)
            {
                pnlEdit.Visible = false;
            }
        }

        private void ShowPanel(Panel pnl)
        {
            HidePanel();
            pnl.Visible = true;
        }
        #endregion
        void DoiTen()
        {
            gvQLDuAn.Columns[0].HeaderText = "Mã Dự Án";
            gvQLDuAn.Columns[1].HeaderText = "Tên Dự Án";
            gvQLDuAn.Columns[2].HeaderText = "Mã Phong Ban";
            gvQLDuAn.Columns[3].HeaderText = "Vốn Điều Hành";
            gvQLDuAn.Columns[4].HeaderText = "Mã Trưởng Dự Án";
            gvQLDuAn.Columns[5].HeaderText = "Bắt Đầu";
            gvQLDuAn.Columns[6].HeaderText = "Kết Thúc";
            gvQLDuAn.Columns[7].HeaderText = "Trạng Thái";

            //gvPCDuAn.Columns[0].HeaderText = "Mã Dự Án";
            //gvPCDuAn.Columns[1].HeaderText = "Mã Nhân Viên";
            //gvPCDuAn.Columns[2].HeaderText = "Bắt Đầu";
            //gvPCDuAn.Columns[3].HeaderText = "Kết Thúc";

            gvNhanLuc.Columns[0].HeaderText = "Mã Nhân Viên";
            gvNhanLuc.Columns[1].HeaderText = "Trình Độ";
        }
        private void DuAn_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowPanel(pnlEdit);
            lblTitle.Text = "Xem thông tin";
            Bold_Date("Remove");
            DataGridViewRow r = gvQLDuAn.SelectedRows[0];
            txtMaDA.Text = r.Cells[0].Value.ToString();
            txtTenDA.Text = r.Cells[1].Value.ToString();
            txtMaPB.Text = r.Cells[2].Value.ToString();
            txtMaTruongDA.Text = r.Cells[4].Value.ToString();
            dtpNgayBatDau.Text = r.Cells[5].Value.ToString();
            dtpNgayKetThuc.Text = r.Cells[6].Value.ToString();
            cboTrangThai.Text = r.Cells[7].Value.ToString();
            lblTenDA.Text = txtMaDA.Text + ": " + txtTenDA.Text;
            lblPhongban.Text = "MÃ PHÒNG BAN: " + txtMaPB.Text;
            lblTruongDA.Text = "MÃ NGƯỜI QUẢN LÝ: " + txtMaTruongDA.Text;
            if (cboTrangThai.Text == "Implement")
            {
                lblTienDoDA.Text = "TIẾN ĐỘ DỰ ÁN: " + db.TienDoDuAn(txtMaDA.Text).ToString() + "%";
            }
            else if (cboTrangThai.Text == "Finish")
            {
                lblTienDoDA.Text = "TIẾN ĐỘ DỰ ÁN: 100%";
            }
            else
            {
                lblTienDoDA.Text = "TIẾN ĐỘ DỰ ÁN: 00%";
            }
            monLichDuAn.SelectionRange = new SelectionRange(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
            Bold_Date("Add");
        }
        private void fQLDuAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            daDao.DeleteBangTT();
        }

        private void gvPCDuAn_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvPCDuAn.SelectedRows[0];
            txtMaNV.Text = r.Cells[1].Value.ToString();
        }

        private void gvNhanLuc_Row_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = gvNhanLuc.SelectedRows[0];
            txtMaNV.Text = r.Cells[0].Value.ToString();
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrangThai.Text == "All")
            {
                string sqlStr = string.Format("SELECT * FROM DUAN");
                gvQLDuAn.DataSource = daDao.LayDanhSach(sqlStr);
                txtMaDA.Clear();
                txtMaNV.Clear();
                txtMaPB.Clear();
                txtMaTruongDA.Clear();
                txtTenDA.Clear();
            }
            else
            {
                switch (cboTrangThai.Text)
                {
                    case "Begin":
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnPhanCong.Enabled = false;
                        break;
                    case "Plan":
                        btnXoa.Enabled = true;
                        btnSua.Enabled = false;
                        btnPhanCong.Enabled = true;
                        break;
                    case "Implement":
                        btnXoa.Enabled = true;
                        btnSua.Enabled = false;
                        btnPhanCong.Enabled = true;
                        break;
                    case "Finish":
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                        btnPhanCong.Enabled = false;
                        break;
                }
                string sqlStr = string.Format("select *from DUAN where TrangThai = '{0}'", cboTrangThai.Text);
                gvQLDuAn.DataSource = daDao.LayDanhSach(sqlStr);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEdit);
            lblTitle.Text = "Thêm dự án";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEdit);
            lblTitle.Text = "Xóa dự án";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlEdit);
            lblTitle.Text = "Sửa dự án";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource = daDao.TimKiem(txtFindMaDA.Text);
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (CheckQuyen(txtMaTruongDA))
            {
                tabQLDA.Controls.Remove(tpPCDA);
                tabQLDA.Controls.Add(tpPCDA);
                tabQLDA.SelectedIndex = 1;
                gvPCDuAn.DataSource = daDao.LayDanhSach($"select MaDA, MaNV, CongViec, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE MaDA = '{txtMaDA.Text}'");
            }
            else
            {
                MessageBox.Show("Khong thuoc tham quyen");
            }
        }

        private bool CheckQuyen(TextBox txtMaTruongDA)
        {
            if (fMainMenu.MaNV == txtMaTruongDA.Text)
            {
                return true;
            }
            return false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(txtMaNV.Text)))
            {
                daDao.UpdateStatus(dtpStart.Value, dtpFinish.Value);
                gvNhanLuc.DataSource = db.FormLoad("select MaNV, TrinhDo from TRANGTHAINHANVIEN WHERE TrangThai = 'Ranh'");
                gvPCDuAn.DataSource = daDao.LayDanhSach($"select MaDA, MaNV, CongViec, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE MaDA = '{txtMaDA.Text}'");

            }
            else
            {
                gvPCDuAn.DataSource = daDao.LayDanhSach($"select MaDA, MaNV, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE MaNV = '{txtMaNV.Text}'");
                gvNhanLuc.DataSource = db.FormLoad($"select MaNV, TrinhDo from TRANGTHAINHANVIEN WHERE MaNV = '{txtMaNV.Text}'");
            }
        }

        private void btnXoaNVkhoiDA_Click(object sender, EventArgs e)
        {
            PCNhanLuc pcnl = new PCNhanLuc(txtMaDA.Text, txtMaNV.Text, cboCongViec.Text, dtpStart.Value.Date, dtpFinish.Value.Date);
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn loại nhân viên khỏi dự án?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                daDao.XoaNVkhoiDA(pcnl);
            }
            gvPCDuAn.DataSource = daDao.LayDanhSach($"select MaDA, MaNV, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE MaDA = '{txtMaDA.Text}'");
        }

        private void btnThemNVvaoDA_Click(object sender, EventArgs e)
        {
            PCNhanLuc pcnl = new PCNhanLuc(txtMaDA.Text, txtMaNV.Text, cboCongViec.Text, dtpStart.Value.Date, dtpFinish.Value.Date);
            daDao.ThemNVvaoDA(pcnl);
            gvPCDuAn.DataSource = daDao.LayDanhSach($"select MaDA, MaNV, CongViec, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE MaDA = '{txtMaDA.Text}'");
            
        }

        private void cboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrinhDo.Text == "All")
            {
                string sqlStr = string.Format("select * from TRANGTHAINHANVIEN WHERE TrangThai = 'Ranh'");
                gvNhanLuc.DataSource = daDao.LayDanhSach(sqlStr);
            }
            else
            {
                string sqlStr = string.Format("select *from TRANGTHAINHANVIEN where TrinhDo = '{0}'", cboTrinhDo.Text);
                gvNhanLuc.DataSource = daDao.LayDanhSach(sqlStr);
            }
        }

        public void Bold_Date(string request)
        {

            // Lấy ngày đầu tiên và ngày cuối cùng trong SelectedRange
            DateTime start = dtpNgayBatDau.Value;
            DateTime end = dtpNgayKetThuc.Value;

            // Tô đen các ngày trong SelectedRange
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                if (request == "Add")
                {
                    monLichDuAn.AddBoldedDate(date);
                }
                else if (request == "Remove")
                {
                    monLichDuAn.RemoveBoldedDate(date);
                }
                monLichDuAn.UpdateBoldedDates();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DuAn da = new DuAn(txtMaDA.Text, txtTenDA.Text, txtMaPB.Text, txtMaTruongDA.Text, dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date, cboTrangThai.Text);
            switch (lblTitle.Text) {
                case "Thêm dự án":
                    daDao.Them(da);
                    break;
                case "Xóa dự án":
                    daDao.Xoa(da);
                    break;
                case "Sửa dự án":
                    daDao.Sua(da);
                    break;
            }
            gvQLDuAn.DataSource = daDao.LayDanhSach("select *from DUAN");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            HidePanel();
        }
    }
}
