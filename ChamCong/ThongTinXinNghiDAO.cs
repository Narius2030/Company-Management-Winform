using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_QLCongTy.ChamCong
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

        public void XoaDon(NGHIPHEP ttxn)
        {
            string sqlStr = $"DELETE NGHIPHEP WHERE MANV = '{ttxn.MANV}' AND NGAYNGHI = '{ttxn.NGAYNGHI}'";
            dbconn.ThucThi(sqlStr);
        }

        public void GiamSoNgNghiPhep(NGHIPHEP ttxn)
        {
            //Tạo CHAMCONG ban đầu 
            ccd.InsertChamCong();

            //Xác định nhân viên xin nghỉ -> lấy được thông tin CHAMCONG của nó trong tg này
            string sqlStr = $@"select * from CHAMCONG 
                               where MaNV = '{ttxn.MANV}' and Thang = {ttxn.NGAYNGHI.Month} and Nam = {ttxn.NGAYNGHI.Year}";
            DataTable dt = dbconn.FormLoad(sqlStr);

            //Giảm SoNgNghiPhep sau khi Gửi đơn VÀ Tăng số ngày đi làm tương ứng vs lý do nghỉ
            int soNgNP, soNgDilam = 0;

            soNgNP = int.Parse(dt.Rows[0]["SoNgNghiPhep"].ToString()) - 1;
            if (soNgNP < 0)
            {
                soNgNP = 0;
            }

            if (ttxn.LYDO.ToLower() == "nghi phep")
            {
                soNgDilam = int.Parse(dt.Rows[0]["NgDilam"].ToString()) + 1;
            }

            //Cập nhật CSDL
            CHAMCONG cc = new CHAMCONG();
            cc.MaNV = ttxn.MANV;
            cc.Thang = ttxn.NGAYNGHI.Month;
            cc.Nam = ttxn.NGAYNGHI.Year;
            cc.NgDilam = soNgDilam;
            cc.SoNgNghiPhep = soNgNP;
            ccd.CapNhat(cc);
        }

        public void CapNhatLyDoNghi(NGHIPHEP ttxn)
        {
            //Cập nhật lý do nghỉ
            CHECKIN_OUT cio = new CHECKIN_OUT();
            cio.LyDoNghi = ttxn.LYDO;
            cio.MaNV = ttxn.MANV;
            cio.Ngay = ttxn.NGAYNGHI;
            ciod.SubmitChieu(cio);
        }
    }
}
