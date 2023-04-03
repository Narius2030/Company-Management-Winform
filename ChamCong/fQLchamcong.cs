using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLConTy_Entity.ChamCong
{
    public partial class fQLchamcong : Form
    {
        ChamCongDAO ccd = new ChamCongDAO();
        public fQLchamcong()
        {
            InitializeComponent();
        }
        private void frmquanlychamcong_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            gvChamcong.DataSource = ccd.LayDanhSach();
        }
        private void gvChamcong_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedrow = gvChamcong.SelectedRows[0];
            txtManv.Text = selectedrow.Cells["MaNV"].Value.ToString();
            txtMacv.Text = selectedrow.Cells["MaCV"].Value.ToString();
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnfilterThang_Click(object sender, EventArgs e)
        {
            gvChamcong.DataSource = ccd.Fill(txtManv.Text, int.Parse(cboThang.Text));
        }
    }
}
