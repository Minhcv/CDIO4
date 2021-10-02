using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class DanhMuc_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet getDM()
        {
            return clsdb.getDataset("select * from DanhMuc");
        }

        public void insert(DanhMuc dal)
        {
            clsdb.execNonquery(@"insert into DanhMuc (tendanhmuc) 
                    values (@TEN)",
                    new object[] {"TEN" },
                    new object[] {dal.TenDanhMuc });
        }
        public void delete(DanhMuc dal)
        {
            clsdb.execNonquery(@"delete from DanhMuc where madanhmuc=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaDanhMuc });
        }
        public void update(DanhMuc dal)
        {
            clsdb.execNonquery(@"update danhmuc set tendanhmuc=@TEN
                    where madanhmuc=@MA",
                    new object[] { "MA","TEN"},
                    new object[] { dal.MaDanhMuc,dal.TenDanhMuc});
        }
    }
}
