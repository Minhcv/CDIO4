using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class PhieuYeuCau_BLL
    {
        PhieuYeuCau_DAL clsDAL = new PhieuYeuCau_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getphieuyeucau();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(PhieuYeuCau dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(PhieuYeuCau dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(PhieuYeuCau dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
        public DataSet gettendocgia(string TenBang)
        {
            return clsDAL.getdataphieuyeucau("docgia");
        }
        public DataSet gettensach(string TenBang)
        {
            return clsDAL.getdataphieuyeucau("sach");
        }
    }
}
