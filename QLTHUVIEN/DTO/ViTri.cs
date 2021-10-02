using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class ViTri
    {
        public string MaViTri { get; set; }
        public string TenViTri { get; set; }
        public ViTri() { }
        public ViTri(string ma, string ten)
        {
            MaViTri = ma;
            TenViTri = ten;
        }
    }
}
