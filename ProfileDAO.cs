using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy
{
    public class ProfileDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetDuAn(NhanSu.NhanSu nv)
        {
            string sqlStr = string.Format("select *from PHANCONGDUAN where MaDA = '{0}'", nv.MaNV);
            return db.FormLoad(sqlStr);
        }

        public string GetMatKhau(NhanSu.NhanSu nv)
        {
            string sqlStr = string.Format("SELECT matkhau FROM TAIKHOAN WHERE taikhoan = '{0}'", nv.MaNV);
            return db.GetItem(sqlStr).ToString();
        }

        public void DoiMatKhau(NhanSu.NhanSu nv, string oldMK, string newMK)
        {
            string sqlStr = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE matkhau = '{1}' AND taikhoan = '{2}'", newMK, oldMK, nv.MaNV);
            db.ThucThi(sqlStr);
        }
    }
}
