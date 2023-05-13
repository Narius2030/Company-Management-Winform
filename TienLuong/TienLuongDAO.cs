using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Entity_QLCongTy.TienLuong
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

        public DataTable LDS()
        {
            string sqlStr = string.Format("SELECT * FROM TIENLUONG");
            return db.FormLoad(sqlStr);
        }

        public void Them(TIENLUONG tl)
        {
            string sqlStr = $@"select * from TIENLUONG where MaNV = '{tl.MaNV}' and Thang = {tl.Thang} and Nam = {tl.Nam}";
            DataTable dt = db.FormLoad(sqlStr);

            if (dt.Rows.Count == 0 )
            {
                //Them Luong mới cho Nhan Vien
                sqlStr = $"insert into TIENLUONG values ('{tl.MaNV}','{tl.MaCV}', {tl.Thang}, {tl.Nam}, {tl.LuongCB}, {tl.LuongThuong},{tl.LuongPhat},{tl.LuongThucTe})";
                
            }
            else
            {
                //Cập nhật Luong cũ cho Nhan Vien
                sqlStr = $@"update TIENLUONG set LuongThuong = {tl.LuongThuong}, LuongPhat = {tl.LuongPhat}, LuongThucTe = {tl.LuongThucTe}
                                             where MaNV = '{tl.MaNV}' and Thang = {tl.Thang} and Nam = {tl.Nam}";
            }
            db.ThucThi(sqlStr);
        }

        public void CapNhat(TIENLUONG tl)
        {
            string sqlStr = string.Format("UPDATE TIENLUONG SET LuongCB = {0}, LuongThuong = {1}, LuongPhat = {2}, LuongThucTe = {3} where MaNV = '{4}'", tl.LuongCB, tl.LuongThuong, tl.LuongPhat,tl.LuongThucTe, tl.MaNV);
            db.ThucThi(sqlStr);
        }
        public DataTable LocThang(string nam, string thang)
        {
            //return db.FormLoad(sqlStr);
            string sqlStr = $"SELECT * FROM TIENLUONG WHERE Nam = '{nam}' AND Thang = '{thang}'";
            return db.FormLoad(sqlStr);
        }
        public DataTable LocNam(string nam)
        {
            //return db.FormLoad(sqlStr);
            string sqlStr = $"SELECT * FROM TIENLUONG WHERE Nam = '{nam}'";
            return db.FormLoad(sqlStr);
        }

        public void TinhTienLuong()
        {
            string sqlStr = $@"select MaNV, CHUCVU.MaCV, HeSoLuong
                               from NHANSU join CHUCVU on NHANSU.MaCV = CHUCVU.MaCV";
            DataTable dtns = db.FormLoad(sqlStr);
            TIENLUONG tl = new TIENLUONG();

            //Thêm lương cho các nhân viên theo tháng và năm mới nhất
            for (int i = 0; i < dtns.Rows.Count; i++)
            {
                TinhTienPhat(tl, dtns.Rows[i]["MaNV"].ToString());
                TinhTienThuong(tl, dtns.Rows[i]["MaNV"].ToString());
                tl.MaNV = dtns.Rows[i]["MaNV"].ToString();
                tl.MaCV = dtns.Rows[i]["MaCV"].ToString();
                //TÍnh lương thực tế
                tl.LuongThucTe = double.Parse((tl.LuongCB * decimal.Parse(dtns.Rows[i]["HeSoLuong"].ToString()) - tl.LuongPhat + tl.LuongThuong).ToString());
                Them(tl);
            }
        }
        public void TinhTienPhat(TIENLUONG tl, string mnv)
        {
            string sqlStr = $@"select * from CHAMCONG
                            where Thang = (select max(Thang) 
		                            from (select * from CHAMCONG 
		                            where Nam = (select max(Nam) from CHAMCONG)) as Q) and MaNV = '{mnv}'";
            DataTable dt = db.FormLoad(sqlStr);

            //Tính tiền phạt (mặc định nghỉ 1 ngày là -100 và tổng ngày đi làm 1 tháng = 30)
            tl.LuongPhat = (30 - int.Parse(dt.Rows[0]["NgDilam"].ToString())) * 100;
            tl.Thang = int.Parse(dt.Rows[0]["Thang"].ToString());
            tl.Nam = int.Parse(dt.Rows[0]["Nam"].ToString());
        }
        public void TinhTienThuong(TIENLUONG tl, string mnv)
        {
            string sqlStr = $@"select count(MaDA) as Cmp_project
                               from PHANCONGDUAN
                               where MaNV = '{mnv}' and TienDo = 100";
            DataTable dt = db.FormLoad(sqlStr);

            //Tính tiền thưởng hoàn thành 1 project (mặc định nghỉ 1 Project là 100)
            tl.LuongThuong = (int.Parse(dt.Rows[0]["Cmp_project"].ToString())) * 100;
        }
    }
}
