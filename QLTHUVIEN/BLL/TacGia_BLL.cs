using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class TacGia_BLL
    {
        TacGia_DAL clsDAL = new TacGia_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.gettacgia();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(TacGia dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(TacGia dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(TacGia dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
    }
}
