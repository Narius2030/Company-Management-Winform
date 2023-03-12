using QLCongTy.QLDuAn;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.QLPhongBan
{
    internal class QLDAThamGiaDAO
    {
        DBConnection db = new DBConnection();

        public DataTable LDS()
        {
            string sqlStr = string.Format("select MaDA,TenDA,DUAN.MaPB,TenPB  from PHONGBAN,DUAN where DUAN.MaPB = PHONGBAN.MaPB");
            return db.FormLoad(sqlStr);
        }

        public void Sua(string mda, string tda, string mpb, string tpb)
        {
            string sqlStr = string.Format("UPDATE DUAN SET MaPB = '{0}'  where MaDA = '{1}'",mpb,mda);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(string mda, string tda, string mpb, string tpb)
        {
            if (mda == string.Empty)
            {
                return LDS();
            }
            string sqlStr = string.Format("select MaDA,TenDA,DUAN.MaPB,TenPB  from PHONGBAN,DUAN where DUAN.MaPB = PHONGBAN.MaPB and MaDA = '{0}'", mda);
            return db.FormLoad(sqlStr);
        }
    }
}
