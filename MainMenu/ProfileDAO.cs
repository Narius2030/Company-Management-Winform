﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_QLCongTy.TienLuong;
using Entity_QLCongTy.ChamCong;
using Entity_QLCongTy.NhanSu;
using System.Windows.Forms;

namespace Entity_QLCongTy
{
    public class ProfileDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetDuAn(NHANSU nv)
        {
            string sqlStr = string.Format("select * from PHANCONGDUAN where MaNV = '{0}'", nv.MaNV);
            return db.FormLoad(sqlStr);
        }

        public string GetMatKhau(NHANSU nv)
        {
            string sqlStr = string.Format("SELECT matkhau FROM TAIKHOAN WHERE taikhoan = '{0}'", nv.MaNV);
            return db.GetItem(sqlStr).ToString();
        }

        public void DoiMatKhau(NHANSU nv, string oldMK, string newMK)
        {
            string sqlStr = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE matkhau = '{1}' AND taikhoan = '{2}'", newMK, oldMK, nv.MaNV);
            db.ThucThi(sqlStr);
        }

        public string GetLuongNam(NHANSU nv, int year)
        {
            string sqlStr = string.Format($@"SELECT SUM(LuongThucTe) as TongLuong 
                                            FROM TIENLUONG 
                                            WHERE MaNV = '{nv.MaNV}' AND Nam = '{year}' 
                                            GROUP BY MaNV");
            var result = db.GetItem(sqlStr);
            if (result == null)
            {
                return "0";
            }
            return result.ToString();
        }

        public List<float> LayHoaDonLuong(string manv, int month, int year)
        {
            //Lấy thông tin lương của tài khoản trên TIENLUONG
            string sqlStr = $@"SELECT TIENLUONG.LuongCB, TIENLUONG.LuongThuong, TIENLUONG.LuongPhat, TIENLUONG.LuongThucTe, CHAMCONG.NgDiLam, (30 - CHAMCONG.NgDiLam - CHAMCONG.SoNgNghiPhep) AS SoNgNghiKhongPhep, CHAMCONG.SoNgNghiPhep
                                FROM TIENLUONG
                                INNER JOIN CHAMCONG ON TIENLUONG.MaNV = CHAMCONG.MaNV AND TIENLUONG.Nam = CHAMCONG.Nam AND TIENLUONG.Thang = CHAMCONG.Thang
                                WHERE TIENLUONG.MaNV = '{manv}' AND TIENLUONG.Nam = '{year}' AND TIENLUONG.Thang = '{month}'";
            var dt = db.FormLoad(sqlStr);

            //Điền thông tin vào List
            List<float> luong = new List<float>();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                luong.Add(float.Parse(dt.Rows[0][i].ToString()));
            }

            //Tìm số lượng da đã làm
            sqlStr = $@"select COUNT(MaDA) as soluong from PHANCONGDUAN
                        where MaNV = '{manv}' and MONTH(NgayKT) = {month} and YEAR(NgayKT) = '{year}' and  TienDo = 100";
            float soluongda = int.Parse(db.GetItem(sqlStr).ToString());
            luong.Add(soluongda);

            return luong;
        }

        public List<KeyValuePair<int, float>> LayLuongTT(string manv, string year)
        {
            string sqlStr = $@"SELECT Thang, LuongThucTe FROM TIENLUONG
                                WHERE TIENLUONG.MaNV = '{manv}' AND TIENLUONG.Nam = '{year}'";
            var dt = db.FormLoad(sqlStr);

            var luongnam = new List<KeyValuePair<int, float>>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var luongthang = new KeyValuePair<int, float>(int.Parse(dt.Rows[i][0].ToString()), float.Parse(dt.Rows[i][1].ToString()));
                luongnam.Add(luongthang);
            }
            return luongnam;
        }

        public List<string> LayThonTinCN()
        {
            NHANSU ns = fMainMenu.currentStaff;
            List<string> info = new List<string>() { ns.NgaySinh.ToString(), ns.SDT, ns.GioiTinh, ns.Email, ns.CCCD, ns.DiaChi };
            return info;
        }

        //Lấy danh sách nghỉ phép của nhân viên chỉ định
        public DataTable LayDSXinNghi(string manv)
        {
            string sqlStr = $"select * from NGHIPHEP where MaNV = '{manv}'";
            return db.FormLoad(sqlStr);
        }
    }
}
