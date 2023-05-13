using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_QLCongTy.ChamCong
{
    public class ThongTinXinNghiDAO
    {
        DBConnection dbconn = new DBConnection();
        ChamCongDAO ccd = new ChamCongDAO();
        CheckInOutDAO ciod = new CheckInOutDAO();
        public DataTable LayDanhSach()
        {
            return dbconn.FormLoad("SELECT * FROM NGHIPHEP WHERE PHANHOI = 'chua duyet'");
        }
        public void ThemBangXinNghi(NGHIPHEP ttxn)
        {
            string sqlStr = $"INSERT INTO NGHIPHEP VALUES ('{ttxn.MANV}', '{ttxn.NGAYNGHI}', '{ttxn.LYDO}', 'chua duyet')";
            dbconn.ThucThi(sqlStr);
            MessageBox.Show("Đã gửi đơn xin nghỉ");
        }
        public void CapNhatBangXinNghi(NGHIPHEP ttxn, string phanhoi)
        {
            string sqlStr = $"UPDATE NGHIPHEP SET PHANHOI = '{phanhoi}' WHERE MANV = '{ttxn.MANV}' AND NGAYNGHI = '{ttxn.NGAYNGHI}'";
            dbconn.ThucThi(sqlStr);
            MessageBox.Show("Đã phản hồi cho nhân viên");
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
            int soNgNP = int.Parse(dt.Rows[0]["SoNgNghiPhep"].ToString());
            int soNgDilam = int.Parse(dt.Rows[0]["NgDilam"].ToString());

            if (ttxn.LYDO.ToLower() == "nghi phep" && soNgNP > 0)
            {
                soNgDilam = int.Parse(dt.Rows[0]["NgDilam"].ToString()) + 1;
            }

            soNgNP -= 1;
            if (soNgNP < 0)
            {
                soNgNP = 0;
            }

            //Cập nhật CSDL
            CHAMCONG cc = new CHAMCONG(ttxn.MANV, ttxn.NGAYNGHI.Month, ttxn.NGAYNGHI.Year, soNgDilam, soNgNP);
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
