using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class DocGia_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet getdocgia()
        {
            return clsdb.getDataset("select * from DOCGIA");
        }

        public void insert(DocGia dal)
        {
            clsdb.execNonquery(@"insert into DOCGIA (TENDOCGIA, NGAYSINH, DIACHI, NGHENGHIEP, SOCMND, NGAYCAPTHE, NGAYHETHAN,SOLUONGSACHDUOCMUON , TIENKIGUI, TRANGTHAI) 
                    values ( @TEN, @NS, @DC, @NGHENGHIEP, @CMND, @NGAYCT, @NGAYHH,@SL , @TIENKIGUI, @TT)",
                    new object[] {"TEN", "NS", "DC", "NGHENGHIEP", "CMND", "NGAYCT", "NGAYHH","SL" , "TIENKIGUI", "TT"  },
                    new object[] {dal.TenDocGia, dal.NgaySinh, dal.DiaChi, dal.NgheNghiep, dal.CMND, dal.NgayCapThe, dal.NgayHetHan,dal.SoLuongSachDuocMuon , dal.TienKiGui, dal.TrangThai });
        }
        public void delete(DocGia dal)
        {
            clsdb.execNonquery(@"delete from Docgia where madocgia=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaDocGia });
        }
        public void update(DocGia dal)
        {
            clsdb.execNonquery(@"update docgia set tendocgia=@TEN , NGAYSINH=@NS, DIACHI=@DC, NGHENGHIEP=@NGHENGHIEP, SOCMND=@CMND, NGAYCAPTHE=@NGAYCT, NGAYHETHAN=@NGAYHH,SOLUONGSACHDUOCMUON=@SL , TIENKIGUI=@TIENKIGUI, TRANGTHAI=@TT
                    where madocgia=@MA",
                    new object[] {"MA", "TEN", "NS", "DC", "NGHENGHIEP", "CMND", "NGAYCT", "NGAYHH", "SL", "TIENKIGUI", "TT" },
                    new object[] {dal.MaDocGia ,dal.TenDocGia, dal.NgaySinh, dal.DiaChi, dal.NgheNghiep, dal.CMND, dal.NgayCapThe, dal.NgayHetHan, dal.SoLuongSachDuocMuon, dal.TienKiGui, dal.TrangThai });
        }
    }
}
