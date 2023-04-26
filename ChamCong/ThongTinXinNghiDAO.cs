using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
{
    public class ThongTinXinNghiDAO
    {
        DBConnection dbconn = new DBConnection();
        ChamCongDAO ccd = new ChamCongDAO();
        CheckInOutDAO ciod = new CheckInOutDAO();
        public DataTable LayDanhSach()
        {
            return dbconn.FormLoad("SELECT * FROM NGHIPHEP");
        }

        public void XoaDon(ThongTinXinNghi ttxn)
        {
            string sqlStr = $"DELETE NGHIPHEP WHERE MANV = '{ttxn.Manv}' AND NGAYNGHI = '{ttxn.Ngaynghi}'";
            dbconn.ThucThi(sqlStr);
        }

        public void GiamSoNgNghiPhep(ThongTinXinNghi ttxn)
        {
            //Tạo CHAMCONG ban đầu 
            ccd.InsertChamCong();

            //Xác định nhân viên xin nghỉ -> lấy được thông tin CHAMCONG của nó trong tg này
            string sqlStr = $@"select * from CHAMCONG 
                               where MaNV = '{ttxn.Manv}' and Thang = {ttxn.Ngaynghi.Month} and Nam = {ttxn.Ngaynghi.Year}";
            DataTable dt = dbconn.FormLoad(sqlStr);

            //Giảm SoNgNghiPhep sau khi Gửi đơn VÀ Tăng số ngày đi làm tương ứng vs lý do nghỉ
            int soNgNP, soNgDilam = 0;

            soNgNP = int.Parse(dt.Rows[0]["SoNgNghiPhep"].ToString()) - 1;
            if (soNgNP < 0)
            {
                soNgNP = 0;
            }

            if (ttxn.Lydo.ToLower() == "nghi phep")
            {
                soNgDilam = int.Parse(dt.Rows[0]["NgDilam"].ToString()) + 1;
            }

            //Cập nhật CSDL
            Chamcong cc = new Chamcong(ttxn.Manv, ttxn.Ngaynghi.Month, ttxn.Ngaynghi.Year, soNgDilam, soNgNP);
            ccd.CapNhat(cc);
        }

        public void CapNhatLyDoNghi(ThongTinXinNghi ttxn)
        {
            //Cập nhật lý do nghỉ
            CheckInOut cio = new CheckInOut();
            cio.LyDo = ttxn.Lydo;
            cio.MaNV = ttxn.Manv;
            cio.Ngay = ttxn.Ngaynghi;
            ciod.SubmitChieu(cio);
        }
    }
}
