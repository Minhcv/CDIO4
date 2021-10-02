using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class NhaXuatBan
    {
        public string MaNhaXuatBan { get; set; }
        public string TenNhaXuatBan { get; set; }
        public NhaXuatBan() { }
        public NhaXuatBan(string ma, string ten)
        {
            MaNhaXuatBan = ma;
            TenNhaXuatBan = ten;
        }


    }
}
