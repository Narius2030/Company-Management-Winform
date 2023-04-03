using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLConTy_Entity.ChamCong
{
    internal class CheckInOutDAO
    {
        public CheckInOutDAO() { }
        public DBConnection dbconn = new DBConnection();
        public DataTable LayDanhSach(string lenh)
        {
            return dbconn.FormLoad(lenh);
        }
        public void SubmitSang(CHECKIN_OUT cio)
        {
            string sqlStr = $"insert into CHECKIN_OUT values('{cio.MaNV}', '{cio.MaCV}', '{cio.Ngay}', {cio.CheckInSang}, {cio.CheckOutChieu})";
            dbconn.ThucThi(sqlStr);
        }
        public void SubmitChieu(CHECKIN_OUT cio)
        {
            string sqlStr = $"update CHECKIN_OUT set CheckOutChieu = {cio.CheckOutChieu} where MaNV = '{cio.MaNV}' and Ngay = '{cio.Ngay}'";
            dbconn.ThucThi(sqlStr);
        }
        public void PushToChamCongTB(string manv, string macv, object ngay, int check)
        {
            string sqlStr = $"insert into CHAMCONG values('{manv}', '{macv}', '{ngay}', {check})";
            dbconn.ThucThi(sqlStr);
        }
        public void DanhGiaCV(string phantram, string MaDA, string MaNV)
        {
            string sqlStr = string.Format("UPDATE PHANCONGDUAN SET TienDo = '{0}' WHERE MaDA = '{1}' AND MaNV = '{2}'", phantram, MaDA, MaNV);
            dbconn.ThucThi(sqlStr);
        }
    }
}
