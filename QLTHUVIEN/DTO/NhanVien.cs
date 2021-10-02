using System;
using System.Collections.Generic;
using System.Text;

namespace QLTHUVIEN
{
    class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string MatKhau { get; set; }
        public string TenNhanVien { get; set; }
        public string CMND { get; set; }
        public string NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaChucVu { get; set; }
        public string LoaiTaiKhoan { get; set; }
        public string TrangThai { get; set; }

        public NhanVien() { }
        public NhanVien(string ma, string mk, string ten, string cmnd, string ngaysinh, string sdt, string diachi, string machucvu, string trangthai)
        {
            MaNhanVien = ma;
            MatKhau = mk;
            TenNhanVien = ten;
            CMND = cmnd;
            NgaySinh = ngaysinh;
            SoDienThoai = sdt;
            DiaChi = diachi;
            MaChucVu = machucvu;
            TrangThai = trangthai;
        }
    }
}
