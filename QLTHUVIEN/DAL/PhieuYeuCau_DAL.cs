using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class PhieuYeuCau_DAL:clsDB
    {
        clsDB clsdb = new clsDB();
        public DataSet getphieuyeucau()
        {
            return clsdb.getDataset("select * from phieuyeucau");
        }

        public void insert(PhieuYeuCau dal)
        {
            clsdb.execNonquery(@"insert into phieuyeucau (madocgia, masach, soluongmuon, ngaymuon, ngaytra, manhanvien) 
                    values (@MADG, @MASACH, @SL, @NGAYMUON, @NGAYTRA, @MANV)",
                    new object[] {"MADG", "MASACH", "SL", "NGAYMUON", "NGAYTRA","MANV" },
                    new object[] { dal.MaDocGia, dal.MaSach, dal.SoLuong, dal.NgayMuon, dal.NgayTra, dal.MaNV });
        }
        public void delete(PhieuYeuCau dal)
        {
            clsdb.execNonquery(@"delete from phieuyeucau where sophieu=@sophieu",
                    new object[] { "sophieu" },
                    new object[] { dal.SoPhieu });
        }
        public void update(PhieuYeuCau dal)
        {
            clsdb.execNonquery(@"update phieuyeucau set madocgia = @MADG, masach = @MASACH, soluongmuon = @SL, ngaymuon = @NGAYMUON, ngaytra = @NGAYTRA
                    where sophieu=@SOPHIEU",
                    new object[] { "SOPHIEU","MADG", "MASACH", "SL", "NGAYMUON", "NGAYTRA" },
                    new object[] { dal.SoPhieu,dal.MaDocGia, dal.MaSach, dal.SoLuong, dal.NgayMuon, dal.NgayTra });
        }
        public DataSet getdataphieuyeucau(string tenbang)
        {
            string sql = @"Select * From " + tenbang;
            return get_daset(sql, tenbang);
        }
    }
}
