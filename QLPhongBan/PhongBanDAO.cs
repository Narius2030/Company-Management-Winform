using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Entity_QLCongTy.QLPhongBan
{
    internal class PhongBanDAO
    {
        DBConnection db = new DBConnection();

        public DataTable LDS()
        {
            string sqlStr = string.Format("select PHONGBAN.MaPB, TenPB, MaTP, Ten from PHONGBAN left outer join NHANSU on MaTP = MaNV");
            return db.FormLoad(sqlStr);
        }
        public void Them(PHONGBAN pb)
        {
            string sqlStr = string.Format("INSERT INTO PHONGBAN(MaPB,TenPB,MaTP) VALUES ('{0}', '{1}', '{2}')",pb.MaPB,pb.TenPB,pb.MaTP);
            db.ThucThi(sqlStr);
        }

        public void Xoa(PHONGBAN pb)
        {
            string sqlStr = string.Format("DELETE FROM PHONGBAN WHERE MaPB = '" + pb.MaPB + "'");
            db.ThucThi(sqlStr);
        }

        public void Sua(PHONGBAN pb)
        {
            string sqlStr = string.Format("UPDATE PHONGBAN SET  TenPB = '{0}', MaTP = '{1}' WHERE MaPB = '{2}'", pb.TenPB,pb.MaTP,pb.MaPB);
            db.ThucThi(sqlStr);
        }
        public DataTable TimKiem(PHONGBAN pb)
        {
            if (pb.MaPB == string.Empty)
            {
                return LDS();
            }
            string sqlStr = string.Format("select PHONGBAN.MaPB, TenPB, MaTP, Ten from PHONGBAN left outer join NHANSU on MaTP = MaNV WHERE PHONGBAN.MaPB = '{0}'",pb.MaPB);
             return db.FormLoad(sqlStr);       
        }
    }
}
