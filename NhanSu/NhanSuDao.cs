﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy
{
    public class NhanSuDAO
    {
        DBConnection dbConnec = new DBConnection();
        public DataTable DanhSach()
        {
            return dbConnec.FormLoad("SELECT *FROM NHANSU");
        }

        public DataTable Loc(string col, string value)
        {
            string lenh = string.Format("SELECT *FROM NHANSU WHERE {0} = '{1}'", col, value);
            return dbConnec.FormLoad(lenh);
        }
        public void Them(NhanSu ns)
        {
            string sqlStr = string.Format("INSERT INTO NHANSU(MaNV, HovaTendem, Ten, NgaySinh, DiaChi, CCCD, MaPB, GioiTinh, SDT, Email, MaCV) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", ns.MaNV, ns.HoDem, ns.Ten, ns.NgaySinh, ns.DiaChi, ns.CCCD, ns.MaPB, ns.GioiTinh, ns.SDT, ns.Email, ns.MaCV);
            dbConnec.ThucThi(sqlStr);
        }

        public void Xoa(NhanSu ns)
        {
            string sqlStr = string.Format("DELETE FROM NHANSU WHERE MaNV = '{0}';", ns.MaNV);
            dbConnec.ThucThi(sqlStr);
        }

        public void Sua(NhanSu ns)
        {
            string sqlStr = string.Format("UPDATE NHANSU SET HovaTendem = '{0}', Ten = '{1}', NgaySinh = '{2}', DiaChi = '{3}', CCCD = '{4}', MaPB = '{5}', GioiTinh = '{6}', SDT = '{7}', Email = '{8}', MaCV = '{9}' WHERE MaNV = '{10}'", ns.HoDem, ns.Ten, ns.NgaySinh, ns.DiaChi, ns.CCCD, ns.MaPB, ns.GioiTinh , ns.SDT, ns.Email, ns.MaCV, ns.MaNV);
            dbConnec.ThucThi(sqlStr);
        }
    }
}