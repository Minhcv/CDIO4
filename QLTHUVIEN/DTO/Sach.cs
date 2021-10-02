using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaDanhMuc { get; set; }
        public string MaTacGia { get; set; }
        public string MaNXB { get; set; }
        public int SoLuongSach { get; set; }
        public string ViTri { get; set; }
        public double GiaGoc { get; set; }
        public Sach() { }
        public Sach(string ma, string ten, string madanhmuc, string tacgia, string manxb, int sl,string vt , double giagoc)
        {
            MaSach = ma;
            TenSach = ten;
            MaDanhMuc = madanhmuc;
            MaTacGia = tacgia;
            MaNXB = manxb;
            SoLuongSach = sl;
            ViTri = vt;
            GiaGoc = giagoc;
        }
    }
}
