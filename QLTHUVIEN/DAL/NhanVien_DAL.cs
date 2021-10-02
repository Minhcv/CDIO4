using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class NhanVien_DAL:clsDB
    {
        clsDB clsdb = new clsDB();
        public DataSet getnhanvien()
        {
            return clsdb.getDataset("select * from nhanvien");
        }
        public void insert(NhanVien dal)
        {
            clsdb.execNonquery(@"insert into nhanvien (matkhau, tennhanvien, cmnd, ngaysinh, sodienthoai, diachi, machucvu, trangthai) 
                    values ( @MK, @TEN,@CMND, @NS, @SDT, @DC, @MACHUCVU,@TRANGTHAI)",
                    new object[] { "MK", "TEN" ,"CMND", "NS", "SDT","DC","MACHUCVU","TRANGTHAI" },
                    new object[] { dal.MatKhau, dal.TenNhanVien, dal.CMND, dal.NgaySinh, dal.SoDienThoai, dal.DiaChi, dal.MaChucVu,dal.TrangThai });
        }
        public void delete(NhanVien dal)
        {
            clsdb.execNonquery(@"delete from nhanvien where manhanvien=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaNhanVien });
        }
        public void update(NhanVien dal)
        {
            clsdb.execNonquery(@"update nhanvien set matkhau = @MK, tennhanvien = @TEN, cmnd= @CMND, ngaysinh=@NS, sodienthoai=@SDT, diachi=@DC, machucvu=@MACHUCVU, trangthai=@TRANGTHAI
                    where manhanvien=@MA",
                    new object[] { "MA", "MK", "TEN", "CMND", "NS", "SDT", "DC", "MACHUCVU", "TRANGTHAI" },
                    new object[] { dal.MaNhanVien, dal.MatKhau, dal.TenNhanVien, dal.CMND, dal.NgaySinh, dal.SoDienThoai, dal.DiaChi, dal.MaChucVu, dal.TrangThai });
        }

        public void updatethongtinNV(NhanVien dal)
        {
            clsdb.execNonquery(@"update nhanvien set tennhanvien = @TEN, cmnd= @CMND, ngaysinh=@NS, sodienthoai=@SDT, diachi=@DC
                    where manhanvien=@MA",
                    new object[] { "MA", "TEN", "CMND", "NS", "SDT", "DC"},
                    new object[] { dal.MaNhanVien, dal.TenNhanVien, dal.CMND, dal.NgaySinh, dal.SoDienThoai, dal.DiaChi });
        }

        public void updatepassNV(NhanVien dal)
        {
            clsdb.execNonquery(@"update nhanvien set matkhau = @MK
                    where manhanvien=@MA",
                    new object[] { "MA", "MK" },
                    new object[] { dal.MaNhanVien, dal.MatKhau });
        }

        public DataSet getdatanhanvien(string tenbang)
        {
            string sql = @"Select * From " + tenbang;
            return get_daset(sql, tenbang);
        }
    }
}
