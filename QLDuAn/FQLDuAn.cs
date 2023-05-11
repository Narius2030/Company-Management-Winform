﻿using Microsoft.Office.Interop.Excel;
using Microsoft.SqlServer.Server;
using QLCongTy.QLDuAn;
using QLCongTy.QLPhongBan;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLCongTy.QLDuAn
{
    public partial class fQLDuAn : Form
    {        
        DuAnDAO daDao= new DuAnDAO();
        DuAn da = new DuAn();
        PCNhanLuc pc = new PCNhanLuc();
        TienDoDAO tdd = new TienDoDAO();
        DBConnection db = new DBConnection();
        public fQLDuAn()
        {
            InitializeComponent();

            //Ẩn dòng cuối cùng của DatagridView
            gvQLDuAn.AllowUserToAddRows = false;
            gvNhanLuc.AllowUserToAddRows = false;
            gvPCDuAn.AllowUserToAddRows = false;
        }

        private void fQLDuAn_Load(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource= daDao.LayDanhSachDuAn(fMainMenu.currentStaff.MaNV);
            if (fMainMenu.currentStaff.MaCV.Contains("GD"))
            {
                gvQLDuAn.DataSource = daDao.DSDuAn();
            }
            daDao.InitStatusTB();
            gvNhanLuc.DataSource = daDao.LayDanhSachNhanLuc();
            tabQLDA.Controls.Remove(tpPCDA);
            DoiTen();
            GettxtFindMaDA();
        }

        public void ReLoadPCDuAn()
        {
            gvPCDuAn.DataSource = daDao.LayDanhSachPhanCong("MaDA", da.Mada);
        }

        #region Hide Show panel
       
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
            gvNhanLuc.Columns[0].HeaderText = "Mã Nhân Viên";
            gvNhanLuc.Columns[1].HeaderText = "Trình Độ";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (fMainMenu.currentStaff.MaCV.Contains("GD"))
            {
                FTaoDuAn tda = new FTaoDuAn(da, btnThem.Text);
                tda.Show();
            }
            else
            {
                MessageBox.Show("Không thuộc thẩm quyền");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (fMainMenu.currentStaff.MaCV.Contains("GD"))
            {
                DataGridViewRow rows = gvQLDuAn.SelectedRows[0];
                // -----v------v-------
                MessageBox.Show(da.Mada);
                daDao.Xoa(da.Mada);
                gvQLDuAn.DataSource = daDao.DSDuAn();
            }
            else
            {
                MessageBox.Show("Không thuộc thẩm quyền");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fMainMenu.currentStaff.MaCV.Contains("GD"))
            {
                FTaoDuAn tda = new FTaoDuAn(da, btnSua.Text);
                tda.Show();
            }
            else
            {
                MessageBox.Show("Không thuộc thẩm quyền");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gvQLDuAn.DataSource = daDao.TimKiem(cboFindMaDA.SelectedValue.ToString());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (CheckQuyen(da.Truongda))
            {
                tabQLDA.Controls.Remove(tpPCDA);
                tabQLDA.Controls.Add(tpPCDA);
                tabQLDA.SelectedIndex = 1;
                ReLoadPCDuAn();
            }
            else
            {
                MessageBox.Show("Khong thuoc tham quyen");
            }
        }

        private bool CheckQuyen(string MaTruongDA)
        {
            if (fMainMenu.MaNV == MaTruongDA)
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
                gvNhanLuc.DataSource = daDao.LayDanhSachNVRanh();
                gvPCDuAn.DataSource = daDao.LayDanhSachPhanCong("MaDA", da.Mada);

            }
            else
            {
                gvPCDuAn.DataSource = daDao.LayDanhSachPhanCong("MaNV", txtMaNV.Text);
                gvNhanLuc.DataSource = daDao.LayDSNVRanhVaDieuKien("MaNV", txtMaNV.Text);
            }
        }

        private void btnXoaNVkhoiDA_Click(object sender, EventArgs e)
        {
            PCNhanLuc pcnl = new PCNhanLuc(da.Mada, pc.Manv, pc.Congviec, pc.Ngaybd, pc.Ngaykt);
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn loại nhân viên khỏi dự án?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                daDao.XoaNVkhoiDA(pcnl);
            }
            ReLoadPCDuAn();
        }

        private void btnThemNVvaoDA_Click(object sender, EventArgs e)
        {
            PCNhanLuc pcnl = new PCNhanLuc(da.Mada, pc.Manv, cboCongViec.Text, dtpStart.Value.Date, dtpFinish.Value.Date);
            daDao.ThemNVvaoDA(pcnl);
            ReLoadPCDuAn();

        }

        private void cboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTrinhDo.Text == "All")
            {
                gvNhanLuc.DataSource = daDao.LayDanhSachNVRanh();
            }
            else
            {
                gvNhanLuc.DataSource = daDao.LayDSNVRanhVaDieuKien("TrinhDo", cboTrinhDo.Text);
            }
        }

        private void gvQLDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Để data ra đối tượng DuAn để lưu trữ
            DataGridViewRow r = gvQLDuAn.SelectedRows[0];

            Type type = da.GetType();
            int i = 0;
            foreach (var propertyInfo in type.GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    propertyInfo.SetValue(da, DateTime.Parse(r.Cells[i].Value.ToString()));
                }
                else if (propertyInfo.PropertyType != typeof(double))
                {
                    propertyInfo.SetValue(da, r.Cells[i].Value.ToString());
                }
                i++;
            }

            //Đổ data ra Datagridview TTPhancong
            gvTTPhancong.DataSource = tdd.LayDanhSach(da.Mada);
        }
        private void gvPCDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Để data ra đối tượng DuAn để lưu trữ
            DataGridViewRow r = gvPCDuAn.SelectedRows[0];

            Type type = pc.GetType();
            int i = 0;
            foreach (var propertyInfo in type.GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    propertyInfo.SetValue(pc, DateTime.Parse(r.Cells[i].Value.ToString()));
                }
                else
                {
                    propertyInfo.SetValue(pc, r.Cells[i].Value.ToString());
                }
                i++;
            }
        }
        private void gvNhanLuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Để data ra đối tượng DuAn để lưu trữ
            DataGridViewRow r = gvNhanLuc.SelectedRows[0];

            Type type = pc.GetType();

            // Lấy đối tượng PropertyInfo cho thuộc tính Name
            PropertyInfo propertyInfo = type.GetProperty("Manv");
            propertyInfo.SetValue(pc, r.Cells[0].Value.ToString());
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tmShowTiendo.Start();
            chartTiendoCN.Series.Clear();
            chartTienDoDA.Series.Clear();
            chartTongTiendo.Series.Clear();
            VeBDTienDoCN();
            VeBDTienDoDA();
            VeBDTongTienDoDA();
        }
        public void GettxtFindMaDA()
        {
            cboFindMaDA.DataSource = daDao.GetNameProd();
            cboFindMaDA.DisplayMember = "TenDA";
            cboFindMaDA.ValueMember = "MaDA";
        }

        #region Timer cho Sidebar 

    bool sidebarExpand = false;
        private void tmShowTiendo_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlTiendo.Height -= 50;
                if (pnlTiendo.Height == pnlTiendo.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    tmShowTiendo.Stop();
                }
            }
            else
            {
                pnlTiendo.Height += 50;
                if (pnlTiendo.Height == pnlTiendo.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    tmShowTiendo.Stop();
                }
            }
        }


        #endregion

        #region Vẽ biểu đồ tiến dộ

        public void VeBDTienDoCN()
        {
            var lstparent = tdd.LayDsNhanvien(da.Mada);
            //Add series
            chartTiendoCN.Series.Add("Task");
            chartTiendoCN.Series[0].ChartType = SeriesChartType.Bar;
            
            //Add columns
            foreach (var ele in lstparent)
            {           
                chartTiendoCN.Series[0].Points.AddXY(ele[0], int.Parse(ele[2]));
            }
        }

        public void VeBDTienDoDA()
        {
            chartTienDoDA.Series.Add("Series1");
            chartTienDoDA.Series[0].ChartType = SeriesChartType.Pie;
            
            #region Trang trí biểu đồ
            chartTienDoDA.Series[0].IsValueShownAsLabel = true;
            chartTienDoDA.Series[0].LabelForeColor = Color.White;
            chartTienDoDA.Series[0].Font = new System.Drawing.Font("Segoe UI", 12.0f, FontStyle.Bold);
            #endregion

            chartTienDoDA.Series[0].Points.AddXY("Đang thực hiện", tdd.LaySlDangThucHien(da.Mada));
            chartTienDoDA.Series[0].Points.AddXY("Chưa thực hiện", tdd.LaySLChuaThucHien(da.Mada));
            chartTienDoDA.Series[0].Points.AddXY("Đã hoàn thành", tdd.LaySLHoanThanh(da.Mada));
            chartTienDoDA.Series[0].Points.AddXY("Quá hạn", tdd.LaySLQuaHan(da.Mada));
        }

        //Vẽ biểu đồ tổng tiến độ dự án
        public void VeBDTongTienDoDA()
        {
            chartTongTiendo.Series.Add("Series1");
            chartTongTiendo.Series[0].ChartType = SeriesChartType.Doughnut;

            #region Trang trí biểu đồ
            chartTongTiendo.Series[0].IsValueShownAsLabel = true;
            chartTongTiendo.Series[0].LabelForeColor = Color.White;
            chartTongTiendo.Series[0].Font = new System.Drawing.Font("Segoe UI", 12.0f, FontStyle.Bold);
            #endregion

            int tiendo = tdd.LayTienDoDA(da.Mada);
            chartTongTiendo.Series[0].Points.AddXY("Đã hoàn thành", tiendo);
            chartTongTiendo.Series[0].Points.AddXY("Chưa hoàn thanh", 100-tiendo);
        }

        #endregion

        private void cboFindMaDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cboFindMaDA.SelectedValue.ToString());
        }

        private void gvQLDuAn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gvQLDuAn.Rows)
            {
                DateTime Deadline = Convert.ToDateTime(row.Cells["NgayKT"].Value);
                bool OutDeadLine = DateTime.Now > Deadline;
                if (OutDeadLine)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    int TienDo = Convert.ToInt32(row.Cells["Tiendo"].Value);
                    if (TienDo == 100) { 
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
