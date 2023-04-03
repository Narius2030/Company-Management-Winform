using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLConTy_Entity.ChamCong
{
    internal class ChamCongDAO
    {
        public ChamCongDAO() { }
        public DBConnection dbconn = new DBConnection();
        public DataTable LayDanhSach()
        {
            return dbconn.FormLoad("select * from CHAMCONG");
        }
        public DataTable Fill(string manv, int thang)
        {
            string sqlStr = $"select count(CheckNgay) as N'Số ngày đã nghỉ' from CHAMCONG where CheckNgay = 0 and (MaNV = '{manv}' and MONTH(Ngay)={thang})";
            return dbconn.FormLoad(sqlStr);
        }
    }
}
