using QLCongTy.QLPhongBan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.QLDuAn
{
    internal class DuAnDAO
    {
        DBConnection db = new DBConnection();

        public DataTable LDS()
        {
            string sqlStr = string.Format("select *from DUAN");
            return db.FormLoad(sqlStr);
        }
        public void Them(DuAn da)
        {
            string sqlStr = string.Format("INSERT INTO DUAN VALUES ('{0}', '{1}', '{2}','{3}')",da.mada,da.tenda,da.mapb,da.truongda);
            db.ThucThi(sqlStr);
        }

        public void Xoa(DuAn da)
        {
            string sqlStr = string.Format("DELETE FROM DUAN WHERE MaDA = '{0}'",da.mada);
            db.ThucThi(sqlStr);
        }

        public void Sua(DuAn da)
        {
            string sqlStr = string.Format("UPDATE DUAN SET TenDA = '{0}', MaPB = '{1}',TruongDA = '{2}' WHERE MaDA = '{3}'",da.tenda,da.mapb,da.truongda, da.mada);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(DuAn da)
        {
            if (da.mada == string.Empty)
            {
                return LDS();
            }
            string sqlStr = string.Format("select *from DUAN where MaDA = '{0}'",da.mada);
            return db.FormLoad(sqlStr);
        }
    }
}
