using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class NhanVien_BLL
    {
        NhanVien_DAL clsDAL = new NhanVien_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getnhanvien();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }

        public void them(NhanVien dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(NhanVien dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(NhanVien dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }

        public void suatt(NhanVien dt)
        {
            //ktra
            //
            clsDAL.updatethongtinNV(dt);
        }

        public void suapass(NhanVien dt)
        {
            //ktra
            //
            clsDAL.updatepassNV(dt);
        }

        public DataSet gettenchucvu(string TenBang)
        {
            return clsDAL.getdatanhanvien("chucvu");
        }
    }
}
