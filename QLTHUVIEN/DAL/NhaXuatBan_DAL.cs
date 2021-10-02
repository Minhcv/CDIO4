using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class NhaXuatBan_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet getnxb()
        {
            return clsdb.getDataset("select * from nhaxuatban");
        }

        public void insert(NhaXuatBan dal)
        {
            clsdb.execNonquery(@"insert into nhaxuatban (tennhaxuatban) 
                    values (@TEN)",
                    new object[] { "TEN" },
                    new object[] { dal.TenNhaXuatBan });
        }
        public void delete(NhaXuatBan dal)
        {
            clsdb.execNonquery(@"delete from nhaxuatban where manhaxuatban=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaNhaXuatBan });
        }
        public void update(NhaXuatBan dal)
        {
            clsdb.execNonquery(@"update nhaxuatban set tennhaxuatban=@TEN
                    where manhaxuatban=@MA",
                    new object[] { "MA","TEN" },
                    new object[] { dal.MaNhaXuatBan,dal.TenNhaXuatBan });
        }
    }
}
