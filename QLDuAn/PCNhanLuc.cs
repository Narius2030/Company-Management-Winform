using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.QLDuAn
{
    public class PCNhanLuc
    {
        private string mada;
        private string manv;
        private string congviec;
        private DateTime ngaybd;
        private DateTime ngaykt;

        public PCNhanLuc(string mada, string manv, string congviec, DateTime ngaybd, DateTime ngaykt)
        {
            this.mada = mada;
            this.manv = manv;
            this.congviec = congviec;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
        }
        public string Mada { get { return mada; } }
        public string Manv { get { return manv; } }
        public string Congviec { get { return congviec; } }
        public DateTime Ngaybd { get { return ngaybd; } }
        public DateTime Ngaykt { get { return ngaykt; } }
    }
}
