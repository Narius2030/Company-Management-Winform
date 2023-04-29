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
        private string trinhdo;

        public PCNhanLuc() { }
        public PCNhanLuc(string mada, string manv, string congviec, DateTime ngaybd, DateTime ngaykt)
        {
            this.Mada = mada;
            this.Manv = manv;
            this.Congviec = congviec;
            this.Ngaybd = ngaybd;
            this.Ngaykt = ngaykt;
        }

        public string Mada { get => mada; set => mada = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Congviec { get => congviec; set => congviec = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Trinhdo { get => trinhdo; set => trinhdo = value; }
    }
}
