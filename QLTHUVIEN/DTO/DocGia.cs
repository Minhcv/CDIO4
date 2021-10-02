using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class DocGia
    {
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string NgheNghiep { get; set; }
        public string CMND { get; set; }
        public string NgayCapThe { get; set; }
        public string NgayHetHan { get; set; }
        public string SoLuongSachDuocMuon { get; set; }
        public string TienKiGui { get; set; }
        public string TrangThai { get; set; }

        public DocGia() { }
        public DocGia(string ma, string ten, string ns, string dc, string nghenghiep, string cmnd, string ngaycapthe, string ngayhethan,string soluongsachduocmuon, string tienkigui, string trangthai)
        {
            MaDocGia = ma;
            TenDocGia = ten;
            NgaySinh = ns;
            DiaChi = dc;
            NgheNghiep = nghenghiep;
            CMND = cmnd;
            NgayCapThe = ngaycapthe;
            NgayHetHan = ngayhethan;
            SoLuongSachDuocMuon = soluongsachduocmuon;
            TienKiGui = tienkigui;
            TrangThai = trangthai;
        }
    }
}
