using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class ViTri_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet getvitri()
        {
            return clsdb.getDataset("select * from vitri");
        }

        public void insert(ViTri dal)
        {
            clsdb.execNonquery(@"insert into vitri (tenvitri) 
                    values (@TEN)",
                    new object[] { "TEN" },
                    new object[] {  dal.TenViTri });
        }
        public void delete(ViTri dal)
        {
            clsdb.execNonquery(@"delete from vitri where mavitri=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaViTri });
        }
        public void update(ViTri dal)
        {
            clsdb.execNonquery(@"update vitri set tenvitri=@TEN
                    where mavitri=@MA",
                    new object[] { "MA", "TEN" },
                    new object[] { dal.MaViTri, dal.TenViTri });
        }
    }
}
