using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class DanhMuc_BLL
    {
        DanhMuc_DAL clsDAL = new DanhMuc_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getDM();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(DanhMuc dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(DanhMuc dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(DanhMuc dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
    }
}
