using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy
{
    public class ChucVu
    {
        private string maCV;
        private string tenCV;

        public ChucVu(string maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        public string MaCV
        {
            get { return maCV; }
        }

        public string TenCV
        {
            get { return tenCV; }
        }
    }
}
