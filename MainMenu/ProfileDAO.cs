using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCongTy.TienLuong;
using QLCongTy.ChamCong;
using QLCongTy.NhanSu;
using System.Windows;

namespace QLCongTy
{
    public class ProfileDAO
    {
        DBConnection db = new DBConnection();
        ChamCongDAO ccd = new ChamCongDAO();
        CheckInOutDAO ciod = new CheckInOutDAO();
        public DataTable GetDuAn(Nhansu nv)
        {
            string sqlStr = string.Format("select * from PHANCONGDUAN where MaDA = '{0}'", nv.MaNV);
            return db.FormLoad(sqlStr);
        }

        public string GetMatKhau(Nhansu nv)
        {
            string sqlStr = string.Format("SELECT matkhau FROM TAIKHOAN WHERE taikhoan = '{0}'", nv.MaNV);
            return db.GetItem(sqlStr).ToString();
        }

        public void DoiMatKhau(Nhansu nv, string oldMK, string newMK)
        {
            string sqlStr = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE matkhau = '{1}' AND taikhoan = '{2}'", newMK, oldMK, nv.MaNV);
            db.ThucThi(sqlStr);
        }
        public void GiamSoNgNghiPhep(string lydo, string maNV, int thang, int nam)
        {
            //Tạo CHAMCONG ban đầu 
            ccd.InsertChamCong();

            //Xác định nhân viên xin nghỉ -> lấy được thông tin CHAMCONG của nó trong tg này
            string sqlStr = $@"select * from CHAMCONG 
                               where MaNV = '{maNV}' and Thang = {thang} and Nam = {nam}";
            DataTable dt = db.FormLoad(sqlStr);

            //Giảm SoNgNghiPhep sau khi Gửi đơn VÀ Tăng số ngày đi làm tương ứng vs lý do nghỉ
            int soNgNP, soNgDilam=0;

            soNgNP = int.Parse(dt.Rows[0]["SoNgNghiPhep"].ToString()) - 1;
            if (soNgNP < 0)
            {
                soNgNP = 0;
            }
            
            if (lydo.ToLower() == "nghi phep")
            {
                soNgDilam = int.Parse(dt.Rows[0]["NgDilam"].ToString()) + 1;
            }

            //Cập nhật CSDL
            Chamcong cc = new Chamcong(maNV, thang, nam, soNgDilam, soNgNP);
            ccd.CapNhat(cc);
        }
        public void CapNhatLyDoNghi(string lydo, string maNV, DateTime ngay)
        {
            //Cập nhật lý do nghỉ
            CheckInOut cio = new CheckInOut();
            cio.LyDo = lydo;
            cio.MaNV = maNV;
            cio.Ngay = ngay;
            ciod.SubmitChieu(cio);
        }
        public List<float> LayThongTinLuong(string manv)
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
        public List<string> LayThonTinCN()
        {
            Nhansu ns = fMainMenu.currentStaff;
            List<string> info = new List<string>() { ns.NgaySinh.ToShortDateString(), ns.SDT, ns.GioiTinh, ns.Email, ns.CCCD, ns.DiaChi };
            return info;
        }
    }
}
