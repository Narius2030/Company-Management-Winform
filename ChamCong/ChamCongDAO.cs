using Entity_QLCongTy.TienLuong;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_QLCongTy.ChamCong
{
    internal class ChamCongDAO
    {
        public ChamCongDAO() { }
        public DBConnection dbconn = new DBConnection();

        //Đã chuyển LinQ
        public List<CHAMCONG> LayDanhSach()
        {
            using (var dbContext = new QLCTDFContext())
            {
                return dbContext.CHAMCONGs.ToList();
            }
        }

        public DataTable Fill(string manv, int thang)
        {
            string sqlStr = $"select count(CheckNgay) as N'Số ngày đã nghỉ' from CHAMCONG where CheckNgay = 0 and (MaNV = '{manv}' and MONTH(Ngay)={thang})";
            return dbconn.FormLoad(sqlStr);
        }

        //Đã chuyển LinQ
        public void Them(CHAMCONG cc)
        {
            using (var dbContext = new QLCTDFContext())
            {
                dbContext.CHAMCONGs.Add(cc);
                dbContext.SaveChanges();
            }
        }

        //Đã chuyển LinQ
        public void CapNhat(CHAMCONG cc)
        {
            using (var dbContext = new QLCTDFContext())
            {
                var chamcong = dbContext.CHAMCONGs
                    .Where(c => c.MaNV == cc.MaNV && c.Thang == cc.Thang && c.Nam == cc.Nam)
                    .FirstOrDefault();

                if (chamcong != null)
                {
                    chamcong.SoNgNghiPhep = cc.SoNgNghiPhep;
                    chamcong.NgDilam = cc.NgDilam;
                    dbContext.SaveChanges();
                }
            }
        }

        public bool InsertChamCong()
        {
            //Tìm tháng, năm mới nhất trong csdl
            string sqlStr = $@"select MAX(Ngay) as Ngay from CHECKIN_OUT";
            int month, year;
            DataTable dt = dbconn.FormLoad(sqlStr);
            try
            {
                month = DateTime.Parse(dt.Rows[0]["Ngay"].ToString()).Month;
                year = DateTime.Parse(dt.Rows[0]["Ngay"].ToString()).Year;
            }
            catch
            {
                //Tìm tháng, năm hiện tại
                month = DateTime.Now.Month;
                year = DateTime.Now.Year;
            }

            //Thêm tháng, năm châm công mới nhất vào
            sqlStr = $@"select * from CHAMCONG
                        where Thang = {month} and Nam = {year}";
            dt = dbconn.FormLoad(sqlStr);
            if (dt.Rows.Count == 0)
            {
                sqlStr = $@"select MaNV from NHANSU join CHUCVU on NHANSU.MaCV = CHUCVU.MaCV";
                dt = dbconn.FormLoad(sqlStr);
                CHAMCONG cc = new CHAMCONG();

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
