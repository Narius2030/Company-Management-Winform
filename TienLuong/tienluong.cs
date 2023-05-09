using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.TienLuong
{
    public class Tienluong
    {
        string manv;
        string macv;
        float hesoluong;
        int thang;
        int nam;
        int luongcoban;
        int luongthuong;
        float luongphat;
        float luongthucte;

        public Tienluong() 
        {
            luongcoban = 1000000;
            luongthuong = 0;
            luongphat = 0;
            luongthucte = 0;
        }
        public Tienluong(string MaNV, string MaCV, int Thang, int Nam, int Luongthuong, float Luongphat, float Luongthucte)
        {
            manv = MaNV;
            macv = MaCV;
            thang = Thang;
            nam = Nam;
            luongcoban = 1000000;
            luongthuong = Luongthuong;
            luongphat = Luongphat;
            luongthucte = Luongthucte;
        }
        public string Manv { get => manv; set => manv = value; }
        public string Macv { get => macv; set => macv = value; }
        public float Hesoluong { get => hesoluong; set => hesoluong = value; }
        public int Luongcoban { get => luongcoban; set => luongcoban = value; }
        public int Luongthuong { get => luongthuong; set => luongthuong = value; }
        public float Luongphat { get => luongphat; set => luongphat = value; }
        public float LuongThucTe { get => luongthucte; set => luongthucte = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
    }
}
