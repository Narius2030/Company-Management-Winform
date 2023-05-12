using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_QLCongTy.TienLuong;
using Entity_QLCongTy.ChamCong;
using Entity_QLCongTy.NhanSu;
using System.Windows.Forms;

namespace Entity_QLCongTy
{
    public class ProfileDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetDuAn(NHANSU nv)
        {
            string sqlStr = string.Format("select * from PHANCONGDUAN where MaNV = '{0}'", nv.MaNV);
            return db.FormLoad(sqlStr);
        }

        public string GetMatKhau(NHANSU nv)
        {
            string sqlStr = string.Format("SELECT matkhau FROM TAIKHOAN WHERE taikhoan = '{0}'", nv.MaNV);
            return db.GetItem(sqlStr).ToString();
        }

        public void DoiMatKhau(NHANSU nv, string oldMK, string newMK)
        {
            string sqlStr = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE matkhau = '{1}' AND taikhoan = '{2}'", newMK, oldMK, nv.MaNV);
            db.ThucThi(sqlStr);
        }

        public List<float> LayHoaDonLuong(string manv)
        {
            //Lấy thông tin lương của tài khoản trên TIENLUONG
            DateTime curtime = DateTime.Now.Date;
            string sqlStr = $@"select * from TIENLUONG
                               where Thang = {curtime.Month} and Nam = {curtime.Year} and MaNV = '{manv}'";
            DataTable dt = db.FormLoad(sqlStr);

            //Điền thông tin vào List
            List<float> luong = new List<float>();
            
            for (int i=4; i< dt.Columns.Count; i++)
            {
                luong.Add(float.Parse(dt.Rows[0][i].ToString()));
            }
            return luong;
        }

        //ns.NgaySinh.ToString() dòng 58 có vấn đề
        public List<string> LayThonTinCN()
        {
            NHANSU ns = fMainMenu.currentStaff;
            List<string> info = new List<string>() { ns.NgaySinh.ToString(), ns.SDT, ns.GioiTinh, ns.Email, ns.CCCD, ns.DiaChi };
            return info;
        }

        //Hàm cập nhật bảng XinNghi
        public void CapNhatBangXinNghi(NGHIPHEP ttxn)
        {
            string sqlStr = $"INSERT INTO NGHIPHEP VALUES ('{ttxn.MANV}', '{ttxn.NGAYNGHI.ToString()}', '{ttxn.LYDO}')";
            db.ThucThi(sqlStr);
            MessageBox.Show("Đã gửi đơn xin nghỉ");
        }
    }
}
