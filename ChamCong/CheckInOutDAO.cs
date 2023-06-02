using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.ChamCong
{
    internal class CheckInOutDAO
    {
        public CheckInOutDAO() { }
        public DBConnection dbconn = new DBConnection();
        public DataTable LayDanhSach(string manv)
        {
            string sqlStr = $"SELECT * FROM PHANCONGDUAN WHERE MaNV = '{manv}'";
            return dbconn.FormLoad(sqlStr);
        }
        public void SubmitSang(CheckInOut cio)
        {   try
            {
                string sqlStr = $"insert into CHECKIN_OUT values('{cio.MaNV}', '{cio.Ngay}', {cio.CheckInSang}, {cio.CheckOutChieu}, '{cio.LyDo}')";
                dbconn.ThucThi(sqlStr);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SubmitChieu(CheckInOut cio)
        {
            string sqlStr = $@"select * from CHECKIN_OUT where MaNV = '{cio.MaNV}' and Ngay = '{cio.Ngay}'";
            DataTable dt = dbconn.FormLoad(sqlStr);

            if (dt.Rows.Count == 0)
            {
                //Nếu buổi sáng KO checkIn -> KO tìm thấy dòng nào trong table CHECKIN_OUT
                sqlStr = $"insert into CHECKIN_OUT values('{cio.MaNV}', '{cio.Ngay}', {cio.CheckInSang}, {cio.CheckOutChieu}, '{cio.LyDo}')";
            }
            else
            {
                //Nếu buổi sáng đã checkIn -> ngược lại
                sqlStr = $"update CHECKIN_OUT set CheckOutChieu = {cio.CheckOutChieu}, LyDoNghi = '{cio.LyDo}' where MaNV = '{cio.MaNV}' and Ngay = '{cio.Ngay}'";
            }
            dbconn.ThucThi(sqlStr);
        }
        public void UpdateNgDiLam(string manv, DateTime ngay, int count)
        {
            //Tăng NgDilam lên 1 nếu điểm danh đủ 2 buổi
            string sqlStr = $@"update CHAMCONG set NgDilam = NgDilam + {count}
                               where MaNV = '{manv}' and Thang = {ngay.Month} and Nam = {ngay.Year}";
            dbconn.ThucThi(sqlStr);
        }
        public void DanhGiaCV(int phantram, string manv, DateTime ngaybd, DateTime ngaykt)
        {
            try
            {
                string sqlStr = $"UPDATE PHANCONGDUAN SET TienDo = {phantram} WHERE MaNV = '{manv}' AND NgayBD = '{ngaybd}' AND NgayKT = '{ngaykt}'";
                dbconn.ThucThi(sqlStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckDiLam(string manv, DateTime ngay)
        {
            string sqlStr = $@"select * from CHECKIN_OUT 
                               where MaNV = '{manv}' and Ngay = '{ngay}'";
            DataTable dt = dbconn.FormLoad(sqlStr);
            bool sang = bool.Parse(dt.Rows[0]["CheckInSang"].ToString());
            bool chieu = bool.Parse(dt.Rows[0]["CheckOutChieu"].ToString());
            if (sang == false || chieu == false)
            {
                return false;
            }
            return true;
        }
    }
}
