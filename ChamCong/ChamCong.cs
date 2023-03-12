using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
{
    internal class ChamCong
    {
        private string maDA;
        private string maPB;
        private string tenDA;
        private float vonDH;
        private string truongDA;

        public string MaDA { get => maDA; set => maDA = value;}
        public string MaPB { get => maPB; set => maPB = value; }
        public string TenDA { get => tenDA; set => tenDA = value; }
        public float VonDH { get => vonDH; set => vonDH = value; }
        public string TruongDA { get => truongDA; set => truongDA = value; }
        public ChamCong()
        {

        }
        public ChamCong(string maDA, string maPB, string tenDA, float vonDH, string truongDA)
        {
            this.maDA = maDA;
            this.maPB = maPB;
            this.tenDA = tenDA;
            this.vonDH = vonDH;
            this.truongDA = truongDA;
        }
    }
}
