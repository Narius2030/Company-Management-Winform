using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy
{
    public class ChucVuDao
    {
        DBConnection dbConnec = new DBConnection();
        public DataTable DanhSach()
        {
            return dbConnec.FormLoad("SELECT *FROM CHUCVU");
        }

        public DataTable Loc(string col, string value)
        {
            string lenh = string.Format("SELECT *FROM CHUCVU WHERE {0} = '{1}'", col, value);
            return dbConnec.FormLoad(lenh);
        }
        public void Them(ChucVu cv)
        {
            string sqlStr = string.Format("INSERT INTO CHUCVU(MaCV, TenCV) VALUES('{0}', '{1}')", cv.MaCV, cv.TenCV);
            dbConnec.ThucThi(sqlStr);
        }

        public void Xoa(ChucVu cv)
        {
            string sqlStr = string.Format("DELETE FROM CHUCVU WHERE MaCV = '{0}';", cv.MaCV);
            dbConnec.ThucThi(sqlStr);
        }

        public void Sua(ChucVu cv)
        {
            string sqlStr = string.Format("UPDATE CHUCVU SET TenCV = '{0}' WHERE MaCV = '{1}'", cv.TenCV, cv.MaCV);
            dbConnec.ThucThi(sqlStr);
        }
    }
}
