using QLCongTy.QLDuAn;
using QLCongTy.TienLuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.TienLuong
{
    public partial class fTienLuong : Form
    {
        TienLuongDAO tlDao = new TienLuongDAO();
        DBConnection db = new DBConnection();
        ExportFile exFile = new ExportFile();
        public fTienLuong()
        {
            InitializeComponent();
        }

        private void fTienLuong_Load(object sender, EventArgs e)
        {
            gvTienLuong.DataSource = tlDao.LDS();
        }

        #region Tính năng Form
        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sqlStr = string.Format("SELECT * FROM TIENLUONG WHERE Nam = '{0}'", cboNam.Text);
            //gvTienLuong.DataSource = tlDao.Loc(sqlStr);
            tlDao.LocNam(cboNam.Text);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNam.Text != "Năm")
            {
                //string sqlStr = string.Format("SELECT * FROM TIENLUONG WHERE Nam = '{0}' AND Thang = '{1}'", cboNam.Text, cboThang.Text);
                //gvTienLuong.DataSource = tlDao.Loc(sqlStr);
                tlDao.LocThang(cboNam.Text, cboThang.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tlDao.TinhTienLuong();
            fTienLuong_Load(sender, e);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            tmThongKe.Start();
        }
        #endregion

        #region Hiệu ứng
        bool sidebarExpand;
        private void tmThongKe_Tick(object sender, EventArgs e)
        {;
            if (sidebarExpand)
            {
                pnlThongKe.Height -= 50;
                if (pnlThongKe.Height == pnlThongKe.MinimumSize.Height)
                {
                    sidebarExpand = false;
                    tmThongKe.Stop();
                }
            }
            else
            {
                pnlThongKe.Height += 50;
                if (pnlThongKe.Height == pnlThongKe.MaximumSize.Height)
                {
                    sidebarExpand = true;
                    tmThongKe.Stop();
                }
            }
        }
        #endregion

        #region Xuất File Excel tiền lương
        public DataTable GetDataFromGV()
        {
            // Tạo đối tượng DataTable
            DataTable dt = new DataTable();

            // Lấy số lượng cột từ DataGridView và thêm các cột vào DataTable
            for (int i = 0; i < gvTienLuong.Columns.Count; i++)
            {
                dt.Columns.Add(gvTienLuong.Columns[i].HeaderText);
            }

            // Lưu dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow dgvRow in gvTienLuong.Rows)
            {
                DataRow dtRow = dt.NewRow();
                for (int i = 0; i < gvTienLuong.Columns.Count; i++)
                {
                    dtRow[i] = dgvRow.Cells[i].Value;
                }
                dt.Rows.Add(dtRow);
            }
            return dt;
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataFromGV();
            exFile.SaveExcel(dt);
        }
        #endregion

        private void gvTienLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gvTienLuong.SelectedRows[0];
            txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
            txtMaCV.Text = row.Cells["MaCV"].Value.ToString();
            txtThang.Text = row.Cells["Thang"].Value.ToString();
            txtNam.Text = row.Cells["Nam"].Value.ToString();
            txtLuongCB.Text = row.Cells["LuongCB"].Value.ToString();
            txtThuong.Text = row.Cells["LuongThuong"].Value.ToString();
            txtLuongPhat.Text = row.Cells["LuongPhat"].Value.ToString();
            txtLuongTT.Text = row.Cells["LuongThucTe"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Tienluong tl = new Tienluong(txtMaNV.Text, txtMaCV.Text, int.Parse(txtThang.Text), int.Parse(txtNam.Text), int.Parse(txtThuong.Text), float.Parse(txtLuongPhat.Text), float.Parse(txtLuongTT.Text));
            tlDao.CapNhat(tl);
        }
    }
}
