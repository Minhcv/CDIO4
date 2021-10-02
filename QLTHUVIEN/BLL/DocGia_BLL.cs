using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class DocGia_BLL
    {
        DocGia_DAL clsDAL = new DocGia_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getdocgia();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(DocGia dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(DocGia dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(DocGia dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
    }
}
