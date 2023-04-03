using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLConTy_Entity.DuAn
{
    internal class DuAnDAO
    {
        DBConnection db = new DBConnection();

        public DataTable LayDanhSach(string lenh)
        {
            string sqlStr = string.Format(lenh);
            return db.FormLoad(sqlStr);
        }
        public void Them(DUAN da)
        {
            string sqlStr = string.Format("INSERT INTO DUAN VALUES ('{0}', '{1}', '{2}', '0', '{3}', '{4}', '{5}', '{6}')", da.MaDA,da.TenDA,da.MaPB,da.TruongDA, da.NgayBD, da.NgayKT, da.TrangThai);
            db.ThucThi(sqlStr);
        }
        public void Xoa(DUAN da)
        {
            string sqlStr = string.Format("DELETE FROM DUAN WHERE MaDA = '{0}'",da.MaDA);
            db.ThucThi(sqlStr);
        }
        public void Sua(DUAN da)
        {
            string sqlStr = string.Format("UPDATE DUAN SET TenDA = '{0}', MaPB = '{1}',TruongDA = '{2}', NgayBD = '{3}', NgayKT = '{4}', TrangThai = '{5}' WHERE MaDA = '{6}'", da.TenDA, da.MaPB, da.TruongDA, da.NgayBD, da.NgayKT, da.TrangThai, da.MaDA);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(string MaDA)
        {
            string sqlStr = string.Format("select *from DUAN where MaDA = '{0}'",MaDA);
            return db.FormLoad(sqlStr);
        }
        public void ThemNVvaoDA(PHANCONGDUAN pcnl)
        {
            string sqlStr = string.Format("INSERT INTO PHANCONGDUAN VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '0')", pcnl.MaDA, pcnl.MaNV, pcnl.CongViec, pcnl.NgayBD, pcnl.NgayKT);
            db.ThucThi(sqlStr);
        }
        public void XoaNVkhoiDA(PHANCONGDUAN pcnl)
        {
            string sqlStr = string.Format("DELETE FROM PHANCONGDUAN WHERE MaDA = '{0}' AND MaNV = '{1}'", pcnl.MaDA, pcnl.MaNV);
            db.ThucThi(sqlStr);
        }
        public void InitStatusTB()
        {
            DataTable dataset = db.FormLoad("select * from TRANGTHAINHANVIEN");
            if (dataset.Rows.Count == 0)
            {
                dataset = db.FormLoad("select * from NHANSU");
                foreach (DataRow row in dataset.Rows)
                {
                    db.ThucThi($"insert into TRANGTHAINHANVIEN values('{row["MaNV"]}', '{row["Ten"]}', '{row["TrinhDo"]}', NULL, NULL)");
                }
            }
        }
        public void CommandUpdateStatus(string status, string manv)
        {
            string sqlStr = $"update TRANGTHAINHANVIEN set TrangThai = '{status}' where MaNV = '{manv}'";
            db.ThucThi(sqlStr);
        }
        public void UpdateStatus(DateTime start, DateTime end)
        {
            string sqlStr = $"select NHANSU.MaNV, NgayBD, NgayKT, MaPB from PHANCONGDUAN right join NHANSU on PHANCONGDUAN.MaNV = NHANSU.MaNV";
            DataTable dataset = db.FormLoad(sqlStr);

            foreach (DataRow dr in dataset.Rows)
            {
                try
                {
                    if ((start <= (DateTime)dr["NgayKT"] && start >= (DateTime)dr["NgayBD"]) || (end <= (DateTime)dr["NgayKT"] && end >= (DateTime)dr["NgayBD"]))
                    {
                        CommandUpdateStatus("Ban", (string)dr["MaNV"]);
                    }
                    else
                    {
                        CommandUpdateStatus("Ranh", (string)dr["MaNV"]);
                    }
                }
                catch
                {
                    CommandUpdateStatus("Ranh", (string)dr["MaNV"]);
                }
            }
        }
        public void DeleteBangTT()
        {
            string sqlStr = $"delete from TRANGTHAINHANVIEN";
            db.ThucThi(sqlStr);
        }
    }
}
