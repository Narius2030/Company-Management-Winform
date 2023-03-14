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

        public DataTable LDS(string lenh)
        {
            string sqlStr = string.Format(lenh);
            return db.FormLoad(sqlStr);
        }
        public void Them(DuAn da)
        {
            string sqlStr = string.Format("INSERT INTO DUAN VALUES ('{0}', '{1}', '{2}', '0', '{3}', '{4}', '{5}', '{6}')", da.Mada,da.Tenda,da.Mapb,da.Truongda, da.Ngaybd, da.Ngaykt, da.Trangthai);
            db.ThucThi(sqlStr);
        }

        public void Xoa(DuAn da)
        {
            string sqlStr = string.Format("DELETE FROM DUAN WHERE MaDA = '{0}'",da.Mada);
            db.ThucThi(sqlStr);
        }

        public void Sua(DuAn da)
        {
            string sqlStr = string.Format("UPDATE DUAN SET TenDA = '{0}', MaPB = '{1}',TruongDA = '{2}', NgayBD = '{3}', NgayKT = '{4}', TrangThai = '{5}' WHERE MaDA = '{6}'", da.Tenda, da.Mapb, da.Truongda, da.Ngaybd, da.Ngaykt, da.Trangthai, da.Mada);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(DuAn da)
        {
            if (da.Mada == string.Empty)
            {
                return LDS("select *from DUAN");
            }
            string sqlStr = string.Format("select *from DUAN where MaDA = '{0}'",da.Mada);
            return db.FormLoad(sqlStr);
        }

        public void ThemNVvaoDA(PCNhanLuc pcnl)
        {
            string sqlStr = string.Format("INSERT INTO PHANCONGDUAN VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", pcnl.Mada, pcnl.Manv, pcnl.Tennv, pcnl.Ngaybd, pcnl.Ngaykt);
            db.ThucThi(sqlStr);
        }
    }
}
