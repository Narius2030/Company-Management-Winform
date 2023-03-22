using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCongTy.MainMenu
{
    internal class DangNhapDAO
    {
        DBConnection db = new DBConnection();

        public string DangNhap(string taiKhoan, string matKhau)
        {
            try
            {
                string sqlStr = string.Format("select MaCV,matkhau from TAIKHOAN where taikhoan = '{0}'", taiKhoan);
                DataTable a = new DataTable();
                a = db.FormLoad(sqlStr);
                DataRow b = a.Rows[0];
                string mk = b["matkhau"].ToString();
                if (SoSanh(matKhau, mk))
                {
                    string cv = b["MaCV"].ToString();
                    if (String.Compare(cv, "QL", true) == 1) return "QL";
                    else return "NV";
                }
                else
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau");
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("Tai khoan khong ton tai");
                return null;
            }
        }
        bool SoSanh(string mk, string mk1)
        {
            int count = 0;
            for (int i = 0; i < mk1.Length; i++)
            {
                if (mk1[i] == ' ') break;
                else count++;
            }
            if (count != mk.Length) return false;
            bool check = true;
            for(int i =0; i< mk.Length;i++) 
                if ((int)mk[i] != (int)mk1[i]) { check = false; break; }
            return check;
        }

        public void DoiMatKhau(string taiKhoan,string matKhauMoi,string matKhauNhapLai)
        {
            if (SoSanh(matKhauMoi,matKhauNhapLai))
            {
                string sqlString = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE taikhoan = '{1}'",matKhauMoi, taiKhoan);
                db.ThucThi(sqlString);
                MessageBox.Show("Doi mat khau thanh cong");
            }
            else
            {
                MessageBox.Show("Mat khau nhap lai khong khop");
            }
        }              
    }
}
