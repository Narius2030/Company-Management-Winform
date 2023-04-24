using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
{
    internal class Chamcong
    {
        string maNV;
        int thang;
        int nam;
        int ngDilam;
        int soNgNghiPhep;

        public string MaNV { get => maNV; set => maNV = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public int NgDilam { get => ngDilam; set => ngDilam = value; }
        public int SoNgNghiPhep { get => soNgNghiPhep; set => soNgNghiPhep = value; }

        public Chamcong() 
        {
            NgDilam = 0;
            SoNgNghiPhep = 1;
        }
        public Chamcong(string maNV, int thang, int nam)
        {
            MaNV = maNV;
            Thang = thang;
            Nam = nam;
        }
        public Chamcong(string maNV, int thang, int nam, int soNgDilam, int soNgNghi)
        {
            MaNV = maNV;
            Thang = thang;
            Nam = nam;
            SoNgNghiPhep = soNgNghi;
            NgDilam = soNgDilam;
        }
    }
}
