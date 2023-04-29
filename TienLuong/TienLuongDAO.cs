using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QLCongTy.TienLuong
{
    internal class TienLuongDAO
    {
        DBConnection db = new DBConnection();
        public static float ChuyenDoi(string str)
        {
            float result;
            if (float.TryParse(str, out result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }
        public static float TienLuong(Tienluong tl)
        {
            return (tl.Luongcoban * tl.Hesoluong) + tl.Luongthuong - tl.Luongphat;
        }

        public DataTable LDS()
        {
            string sqlStr = string.Format("SELECT * FROM TIENLUONG");
            return db.FormLoad(sqlStr);
        }

        public void Them(Tienluong tl)
        {
            string sqlStr = $@"select * from TIENLUONG where MaNV = '{tl.Manv}' and Thang = {tl.Thang} and Nam = {tl.Nam}";
            DataTable dt = db.FormLoad(sqlStr);

            if (dt.Rows.Count == 0 )
            {
                //Them Luong mới cho Nhan Vien
                sqlStr = $"insert into TIENLUONG values ('{tl.Manv}','{tl.Macv}', {tl.Thang}, {tl.Nam}, {tl.Luongcoban}, {tl.Luongthuong},{tl.Luongphat},{tl.LuongThucTe})";
                
            }
            else
            {
                //Cập nhật Luong cũ cho Nhan Vien
                sqlStr = $@"update TIENLUONG set LuongThuong = {tl.Luongthuong}, LuongPhat = {tl.Luongphat}, LuongThucTe = {tl.LuongThucTe}
                                             where MaNV = '{tl.Manv}' and Thang = {tl.Thang} and Nam = {tl.Nam}";
            }
            db.ThucThi(sqlStr);
        }
        public void CapNhat(Tienluong tl)
        {
            string sqlStr = string.Format("UPDATE TIENLUONG SET HeSoLuong = {0}, LuongCB = {1}, LuongThuong = {2}, LuongPhat = {3} where MaNV = '{4}'", tl.Hesoluong,tl.Luongcoban,tl.Luongthuong,tl.Luongphat,tl.Manv);
            db.ThucThi(sqlStr);
        }
        public DataTable Loc(string sqlStr)
        {
            return db.FormLoad(sqlStr);
        }
        public void TinhTienLuong()
        {
            string sqlStr = $@"select MaNV, CHUCVU.MaCV, HeSoLuong
                               from NHANSU join CHUCVU on NHANSU.MaCV = CHUCVU.MaCV";
            DataTable dtns = db.FormLoad(sqlStr);
            Tienluong tl = new Tienluong();

            //Thêm lương cho các nhân viên theo tháng và năm mới nhất
            for (int i=0; i < dtns.Rows.Count; i++)
            {
                TinhTienPhat(tl, dtns.Rows[i]["MaNV"].ToString());
                TinhTienThuong(tl, dtns.Rows[i]["MaNV"].ToString());
                tl.Manv = dtns.Rows[i]["MaNV"].ToString();
                tl.Macv = dtns.Rows[i]["MaCV"].ToString();
                tl.LuongThucTe = (tl.Luongcoban * float.Parse(dtns.Rows[i]["HeSoLuong"].ToString())) - tl.Luongphat + tl.Luongthuong;
                Them(tl);
            }
        }
        public void TinhTienPhat(Tienluong tl, string mnv)
        {
            string sqlStr = $@"select * from CHAMCONG
                            where Thang = (select max(Thang) 
		                            from (select * from CHAMCONG 
		                            where Nam = (select max(Nam) from CHAMCONG)) as Q) and MaNV = '{mnv}'";
            DataTable dt = db.FormLoad(sqlStr);

            //Tính tiền phạt (mặc định nghỉ 1 ngày là -100 và tổng ngày đi làm 1 tháng = 30)
            tl.Luongphat = (30 - int.Parse(dt.Rows[0]["NgDilam"].ToString())) * 100;
            tl.Thang = int.Parse(dt.Rows[0]["Thang"].ToString());
            tl.Nam = int.Parse(dt.Rows[0]["Nam"].ToString());
        }
        public void TinhTienThuong(Tienluong tl, string mnv)
        {
            string sqlStr = $@"select count(MaDA) as Cmp_project
                               from PHANCONGDUAN
                               where MaNV = '{mnv}' and TienDo = 100";
            DataTable dt = db.FormLoad(sqlStr);

            //Tính tiền thưởng hoàn thành 1 project (mặc định nghỉ 1 Project là 100)
            tl.Luongthuong = (int.Parse(dt.Rows[0]["Cmp_project"].ToString())) * 100;
        }
    }
}
