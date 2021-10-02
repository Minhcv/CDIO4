using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class TacGia
    {
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public TacGia() { }
        public TacGia(string ma, string ten)
        {
            MaTacGia = ma;
            TenTacGia = ten;
        }
    }
}
