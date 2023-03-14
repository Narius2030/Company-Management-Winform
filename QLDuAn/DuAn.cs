using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.QLDuAn
{
    public class DuAn
    {
        private string mada;
        private string tenda;
        private string mapb;
        private string truongda;
        private DateTime ngaybd;
        private DateTime ngaykt;
        private string trangthai;

        public DuAn(string mada, string tenda, string mapb, string truongda, DateTime ngaybd, DateTime ngaykt, string trangthai)
        {
            this.mada = mada;
            this.tenda = tenda;
            this.mapb = mapb;
            this.truongda = truongda;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.trangthai = trangthai;
        }

        public string Mada { get { return mada; } }
        public string Tenda { get { return tenda; } }
        public string Mapb { get { return mapb; } }
        public string Truongda { get { return truongda; } }
        public DateTime Ngaybd { get { return ngaybd; } }
        public DateTime Ngaykt { get { return ngaykt; } }
        public string Trangthai { get { return trangthai; } }
    }
}
