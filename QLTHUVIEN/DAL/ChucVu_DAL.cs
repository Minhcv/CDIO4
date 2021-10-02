using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class ChucVu_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet getChucVu()
        {
            return clsdb.getDataset("select * from Chucvu");
        }

        public void insert(ChucVu dal)
        {
            clsdb.execNonquery(@"insert into chucvu (tenchucvu) 
                    values (@TEN)",
                    new object[] { "TEN" },
                    new object[] { dal.MaChucVu, dal.TenChucVu });
        }
        public void delete(ChucVu dal)
        {
            clsdb.execNonquery(@"delete from chucvu where machucvu=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaChucVu });
        }
        public void update(ChucVu dal)
        {
            clsdb.execNonquery(@"update chucvu set tenchucvu=@TEN
                    where machucvu=@MA",
                    new object[] { "MA"},
                    new object[] { dal.MaChucVu });
        }
    }
}
