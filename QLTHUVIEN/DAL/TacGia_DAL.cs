using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class TacGia_DAL
    {
        clsDB clsdb = new clsDB();
        public DataSet gettacgia()
        {
            return clsdb.getDataset("select * from tacgia");
        }

        public void insert(TacGia dal)
        {
            clsdb.execNonquery(@"insert into tacgia (tentacgia) 
                    values (@TEN)",
                    new object[] { "MA", "TEN" },
                    new object[] { dal.MaTacGia, dal.TenTacGia });
        }
        public void delete(TacGia dal)
        {
            clsdb.execNonquery(@"delete from tacgia where matacgia=@MA",
                    new object[] { "MA" },
                    new object[] { dal.MaTacGia });
        }
        public void update(TacGia dal)
        {
            clsdb.execNonquery(@"update tacgia set tentacgia=@TEN
                    where matacgia=@MA",
                    new object[] { "MA", "TEN" },
                    new object[] { dal.MaTacGia, dal.TenTacGia });
        }
    }
}
