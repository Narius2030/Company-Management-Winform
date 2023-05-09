using QLCongTy.QLPhongBan;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLCongTy.QLDuAn
{
    internal class DuAnDAO
    {
        DBConnection db = new DBConnection();

        public DataTable LayDanhSachDuAn(string manv)
        {
            string sqlStr = $"select * from DUAN where TruongDA = '{manv}'";
            return db.FormLoad(sqlStr);
        }
        public DataTable LayDanhSachNhanLuc()
        {
            string sqlStr = $"select MaNV, TrinhDo from TRANGTHAINHANVIEN";
            return db.FormLoad(sqlStr);
        }
        public DataTable LayDanhSachPhanCong(string col, string value)
        {
            string sqlStr = $"select MaDA, MaNV, CongViec, NgayBD, NgayKT, TienDo from PHANCONGDUAN WHERE {col} = '{value}'";
            return db.FormLoad(sqlStr);
        }
        public DataTable LayDanhSachNVRanh()
        {
            string sqlStr = $"select MaNV, TrinhDo from TRANGTHAINHANVIEN WHERE TrangThai = 'Ranh'";
            return db.FormLoad(sqlStr);
        }
        public DataTable LayDSNVRanhVaDieuKien(string col, string value)
        {
            string sqlStr = $"select  MaNV, TrinhDo from TRANGTHAINHANVIEN where {col} = '{value}' and TrangThai = 'Ranh'";
            return db.FormLoad(sqlStr);
        }
        public void Them(DuAn da)
        {
            string sqlStr = $"INSERT INTO DUAN VALUES ('{da.Mada}', '{da.Tenda}', '{da.Mapb}', 0, '{da.Truongda}', '{da.Ngaybd}', '{da.Ngaykt}', '{da.Trangthai}', 0)";
            db.ThucThi(sqlStr);
        }
        public void Xoa(string mada)
        {
            string sqlStr = $"DELETE FROM DUAN WHERE MaDA = '{mada}'";
            db.ThucThi(sqlStr);
        }
        public void Sua(DuAn da)
        {
            string sqlStr = string.Format("UPDATE DUAN SET TenDA = '{0}', MaPB = '{1}',TruongDA = '{2}', NgayBD = '{3}', NgayKT = '{4}', TrangThai = '{5}' WHERE MaDA = '{6}'", da.Tenda, da.Mapb, da.Truongda, da.Ngaybd, da.Ngaykt, da.Trangthai, da.Mada);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(string MaDA)
        {
            string sqlStr = string.Format("SELECT * FROM DUAN WHERE MaDA = '{0}'",MaDA);
            return db.FormLoad(sqlStr);
        }
        public void ThemNVvaoDA(PCNhanLuc pcnl)
        {
            string sqlStr = string.Format("INSERT INTO PHANCONGDUAN VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '0')", pcnl.Mada, pcnl.Manv, pcnl.Congviec, pcnl.Ngaybd, pcnl.Ngaykt);
            db.ThucThi(sqlStr);
        }
        public void XoaNVkhoiDA(PCNhanLuc pcnl)
        {
            string sqlStr = string.Format("DELETE FROM PHANCONGDUAN WHERE MaDA = '{0}' AND MaNV = '{1}'", pcnl.Mada, pcnl.Manv);
            db.ThucThi(sqlStr);
        }
        public void TienDoDuAn(string MaDA)
        {
            int result = int.Parse(db.GetItem($"SELECT SUM(TienDo/5) FROM PHANCONGDUAN WHERE MaDA = '{MaDA}' GROUP BY MaDA").ToString());
            if (result >= 100)
            {
                result = 100;
            }
            string sqlStr = $"UPDATE DUAN SET TienDo = {result} WHERE MaDA = '{MaDA}'";
            db.ThucThi(sqlStr);
        }
        public void InitStatusTB()
        {
            DataTable dataset = db.FormLoad("select * from TRANGTHAINHANVIEN");
            if (dataset.Rows.Count <= 0)
            {
                dataset = db.FormLoad("select * from NHANSU");
                foreach (DataRow row in dataset.Rows)
                {
                    db.ThucThi($"insert into TRANGTHAINHANVIEN values('{row["MaNV"]}', '{row["TrinhDo"]}', NULL, NULL)");
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
                    if ((start <= DateTime.Parse(dr["NgayKT"].ToString()) && start >= DateTime.Parse(dr["NgayBD"].ToString())) || (end <= DateTime.Parse(dr["NgayKT"].ToString()) && end >= DateTime.Parse(dr["NgayBD"].ToString())))
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

        public DataTable GetNameDept()
        {
            string sqlStr = "SELECT MaPB, TenPB FROM PHONGBAN";
            return db.FormLoad(sqlStr);
        }

        public DataTable GetNameDeptHead()
        {
            string sqlStr = "SELECT CONCAT(MaNV, ' - ', Ten) AS TenNV, MaNV FROM NHANSU WHERE MaCV LIKE 'TP%'";
            return db.FormLoad(sqlStr);
        }
        public DataTable GetNameProd()
        {
            string sqlStr = "SELECT CONCAT(MaDA, ' - ', TenDA) AS TenDA, MaDA FROM DUAN";
            return db.FormLoad(sqlStr);
        }
    }
}
