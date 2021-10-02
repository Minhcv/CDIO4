using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class Sach_DAL:clsDB
    {
        clsDB clsdb = new clsDB();
        public DataSet getsach()
        {
            return clsdb.getDataset("select * from sach");
        }
        public void insert(Sach dal)
        {
            clsdb.execNonquery(@"insert into sach (tensach, madanhmuc, matacgia, manhaxuatban, soluongsachcon, mavitri, giagoc) 
                    values ( @TEN, @MADANHMUC, @MATG, @MANXB, @SL, @MAVT, @GIA)",
                    new object[] {  "TEN", "MADANHMUC", "MATG", "MANXB", "SL", "MAVT", "GIA" },
                    new object[] { dal.TenSach, dal.MaDanhMuc, dal.MaTacGia, dal.MaNXB, dal.SoLuongSach,dal.ViTri, dal.GiaGoc });
        }
        public void delete(Sach dal)
        {
            clsdb.execNonquery(@"delete from sach where masach=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaSach });
        }
        public void update(Sach dal)
        {
            clsdb.execNonquery(@"update sach set tensach=@TEN, madanhmuc = @MADANHMUC, matacgia = @MATG, manhaxuatban = @MANXB, soluongsachcon = @SL, mavitri = @MAVT, giagoc = @GIA
                    where masach=@MA",
                    new object[] { "MA", "TEN", "MADANHMUC", "MATG", "MANXB", "SL", "MAVT", "GIA" },
                    new object[] { dal.MaSach, dal.TenSach, dal.MaDanhMuc, dal.MaTacGia, dal.MaNXB, dal.SoLuongSach, dal.ViTri, dal.GiaGoc });
        }
        public DataSet getdatasetSach(string tenbang)
        {
            string sql = @"Select * From " + tenbang;
            return get_daset(sql, tenbang);
        }
    }
}
