using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class PhieuYeuCau
    {
        public string SoPhieu { get; set; }
        public string MaDocGia { get; set; }
        public string MaSach { get; set; }
        public string SoLuong { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }
        public string MaNV { get; set; }
        public PhieuYeuCau() { }
        public PhieuYeuCau(string sopieu, string madocgia, string masach , string soluong, string ngaymuon, string ngaytra, string manv)
        {
            SoPhieu = sopieu;
            MaDocGia = madocgia;
            MaSach = masach;
            SoLuong = soluong;
            NgayMuon = ngaymuon;
            NgayTra = ngaytra;
            MaNV = manv;
        }
    }
}
