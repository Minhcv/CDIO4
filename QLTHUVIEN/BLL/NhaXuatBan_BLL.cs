using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class NhaXuatBan_BLL
    {
        NhaXuatBan_DAL clsDAL = new NhaXuatBan_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getnxb();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(NhaXuatBan dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(NhaXuatBan dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(NhaXuatBan dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
    }
}
