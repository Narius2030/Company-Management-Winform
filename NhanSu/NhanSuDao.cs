using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCongTy.TienLuong;
using QLCongTy.QLDuAn;

namespace QLCongTy.NhanSu
{
    internal class NhanSuDAO
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
        public void Them(Nhansu ns)
        {
            string sqlStr = string.Format("INSERT INTO NHANSU(MaNV, HovaTendem, Ten, NgaySinh, DiaChi, CCCD, MaPB, GioiTinh, SDT, Email, MaCV) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", ns.MaNV, ns.HoDem, ns.Ten, ns.NgaySinh, ns.DiaChi, ns.CCCD, ns.MaPB, ns.GioiTinh, ns.SDT, ns.Email, ns.MaCV);
            dbConnec.ThucThi(sqlStr);

            //Tao TAIKHOAN moi mac dinh
            sqlStr = string.Format("INSERT INTO TAIKHOAN VALUES('{0}', '{1}','{2}')", ns.MaNV, ns.MaNV, ns.MaCV);
            dbConnec.ThucThi(sqlStr);

            //Tao TIENLUONG moi
        }

        public void Xoa(Nhansu ns)
        {
            string sqlStr = string.Format("DELETE FROM NHANSU WHERE MaNV = '{0}';", ns.MaNV);
            dbConnec.ThucThi(sqlStr);
            sqlStr = string.Format("DELETE FROM TAIKHOAN WHERE taikhoan = '{0}';", ns.MaNV);
            dbConnec.ThucThi(sqlStr);
        }

        public void Sua(Nhansu ns)
        {
            string sqlStr = string.Format("UPDATE NHANSU SET HovaTendem = '{0}', Ten = '{1}', NgaySinh = '{2}', DiaChi = '{3}', CCCD = '{4}', MaPB = '{5}', GioiTinh = '{6}', SDT = '{7}', Email = '{8}', MaCV = '{9}' WHERE MaNV = '{10}'", ns.HoDem, ns.Ten, ns.NgaySinh, ns.DiaChi, ns.CCCD, ns.MaPB, ns.GioiTinh , ns.SDT, ns.Email, ns.MaCV, ns.MaNV);
            dbConnec.ThucThi(sqlStr);
            sqlStr = string.Format("UPDATE TAIKHOAN SET MaCV = '{0}' WHERE taikhoan ='{1}'",ns.MaCV,ns.MaNV );
            dbConnec.ThucThi(sqlStr);
        }
        public DataTable LuongTheoThang(string mapb, int year)
        {
            string sqlStr = $@"select MaPB, tl.Nam, sum(tl.LuongThucTe) as Luong
                                from NHANSU as ns inner join TIENLUONG as tl
	                                on ns.MaNV = tl.MaNV
                                where MaPB = 'P001' and Nam = 2023
                                group by MaPB, Nam";
            DataTable dt = dbConnec.FormLoad(sqlStr);
            return dt;
        }

        //Lấy số lượng phòng --> List<>


        //Lấy số lượng năm --> List<>


    }
}
