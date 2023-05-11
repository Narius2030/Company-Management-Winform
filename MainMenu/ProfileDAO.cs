﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCongTy.TienLuong;
using QLCongTy.ChamCong;
using QLCongTy.NhanSu;
using System.Windows;
//using Microsoft.Office.Interop.Excel;
using System.Windows.Controls.Primitives;

namespace QLCongTy
{
    public class ProfileDAO
    {
        DBConnection db = new DBConnection();
        public DataTable GetDuAn(string manv)
        {
            string sqlStr = $"select * from PHANCONGDUAN where MaNV = '{manv}'";
            return db.FormLoad(sqlStr);
        }

        public string GetMatKhau(Nhansu nv)
        {
            string sqlStr = string.Format("SELECT matkhau FROM TAIKHOAN WHERE taikhoan = '{0}'", nv.MaNV);
            return db.GetItem(sqlStr).ToString();
        }

        public void DoiMatKhau(Nhansu nv, string oldMK, string newMK)
        {
            string sqlStr = string.Format("UPDATE TAIKHOAN SET matkhau = '{0}' WHERE matkhau = '{1}' AND taikhoan = '{2}'", newMK, oldMK, nv.MaNV);
            db.ThucThi(sqlStr);
        }

        public List<float> LayThongTinLuong(string manv, int month, int year)
        {
            //Lấy thông tin lương của tài khoản trên TIENLUONG
            string sqlStr = $@"SELECT LuongCB, LuongThuong, LuongPhat, LuongThucTe, NgDiLam, SoNgNghiPhep
                                FROM TIENLUONG inner join CHAMCONG
                                ON TIENLUONG.MaNV = CHAMCONG.MaNV AND TIENLUONG.Nam = CHAMCONG.Nam AND TIENLUONG.Thang = CHAMCONG.Thang
                                WHERE TIENLUONG.MaNV = '{manv}' AND TIENLUONG.Nam = '{year}' AND TIENLUONG.Thang = '{month}'";
            DataTable dt = db.FormLoad(sqlStr);

            //Điền thông tin vào List
            List<float> luong = new List<float>();
            
            for (int i=0; i< dt.Columns.Count; i++)
            {
                luong.Add(float.Parse(dt.Rows[0][i].ToString()));
            }

            return luong;
        }

        public List<string> LayThonTinCN()
        {
            Nhansu ns = fMainMenu.currentStaff;
            List<string> info = new List<string>() { ns.NgaySinh.ToShortDateString(), ns.SDT, ns.GioiTinh, ns.Email, ns.CCCD, ns.DiaChi };
            return info;
        }

        //Hàm cập nhật bảng XinNghi
     
    }
}
