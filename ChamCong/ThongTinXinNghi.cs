using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
{
    public class ThongTinXinNghi
    {
        string manv;
        DateTime ngaynghi;
        string lydo;

        public ThongTinXinNghi(string manv, DateTime ngaynghi, string lydo)
        {
            this.Manv = manv;
            this.Ngaynghi = ngaynghi;
            this.Lydo = lydo;
        }

        public string Manv { get => manv; set => manv = value; }
        public DateTime Ngaynghi { get => ngaynghi; set => ngaynghi = value; }
        public string Lydo { get => lydo; set => lydo = value; }
    }
}
