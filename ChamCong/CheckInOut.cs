﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCongTy.ChamCong
{
    public class CheckInOut
    {
        private string maNV;
        private string macv;
        private int checkInSang;
        private int checkOutChieu;
        private DateTime ngay;

        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int CheckInSang { get => checkInSang; set => checkInSang = value; }
        public int CheckOutChieu { get => checkOutChieu; set => checkOutChieu = value; }
        public string Macv { get => macv; set => macv = value; }

        public CheckInOut() { }
        public CheckInOut(string maNV, string maCV, DateTime ngay, int checkInSang, int checkOutChieu)
        {
            this.maNV = maNV;
            this.macv = maCV;
            this.ngay = ngay;
            this.checkInSang = checkInSang;
            this.checkOutChieu = checkOutChieu;
        }
    }
}