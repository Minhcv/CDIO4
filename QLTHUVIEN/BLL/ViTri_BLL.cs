using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class ViTri_BLL
    {
        ViTri_DAL clsDAL = new ViTri_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getvitri();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(ViTri dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(ViTri dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(ViTri dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
    }
}
