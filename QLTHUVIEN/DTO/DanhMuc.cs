using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class DanhMuc
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public DanhMuc() { }
        public DanhMuc(string ma, string ten)
        {
            MaDanhMuc = ma;
            TenDanhMuc = ten;
        }
    }
}
