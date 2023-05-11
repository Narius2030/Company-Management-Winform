using QLCongTy.TienLuong;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
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
        public void Them(Chamcong cc)
        {
            string sqlStr = $@"insert into CHAMCONG values('{cc.MaNV}', {cc.Thang}, {cc.Nam}, {cc.NgDilam}, {cc.SoNgNghiPhep})";
            dbconn.ThucThi(sqlStr);
        }
        public void CapNhat(Chamcong cc)
        {
            string sqlStr = $@"update CHAMCONG set SoNgNghiPhep = {cc.SoNgNghiPhep}, NgDilam = {cc.NgDilam}
                               where MaNV = '{cc.MaNV}' and Thang = {cc.Thang} and Nam = {cc.Nam}";
            dbconn.ThucThi(sqlStr);
        }
        public bool InsertChamCong()
        {
            //Tìm tháng, năm mới nhất
            //string sqlStr = $@"select MAX(Ngay) as Ngay from CHECKIN_OUT";
            //DataTable dt = dbconn.FormLoad(sqlStr);
            //int month = DateTime.Parse(dt.Rows[0]["Ngay"].ToString()).Month;
            //int year = DateTime.Parse(dt.Rows[0]["Ngay"].ToString()).Year;

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            //Thêm tháng, năm châm công mới nhất vào
            string sqlStr = $@"select * from CHAMCONG
                        where Thang = {month} and Nam = {year}";
            DataTable dt = dbconn.FormLoad(sqlStr);
            if (dt.Rows.Count == 0)
            {
                sqlStr = $@"select MaNV from NHANSU join CHUCVU on NHANSU.MaCV = CHUCVU.MaCV";
                dt = dbconn.FormLoad(sqlStr);
                Chamcong cc = new Chamcong();

                //Thêm chấm công cho các nhân viên theo tháng và năm mới nhất
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cc.MaNV = dt.Rows[i]["MaNV"].ToString();
                    cc.Thang = month;
                    cc.Nam = year;
                    Them(cc);
                }
                return true;
            }
            return false;
        }
    }
}
