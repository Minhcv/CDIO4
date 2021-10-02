using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class ChucVu
    {
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public ChucVu() { }
        public ChucVu(string ma, string ten)
        {
            MaChucVu = ma;
            TenChucVu = ten;
        }
    }
}
