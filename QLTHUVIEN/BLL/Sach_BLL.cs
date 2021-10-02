using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLTHUVIEN
{
    class Sach_BLL
    {
        Sach_DAL clsDAL = new Sach_DAL();

        public DataTable layDuLieu()
        {
            DataSet ds = clsDAL.getsach();
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }
        public DataTable layDuLieuTheoTenSach(string tenSach)
        {
            DataSet ds = clsDAL.getdatasetSach(tenSach);
            if (ds.Tables.Count > 0) return ds.Tables[0];
            else return null;
        }
        public void them(Sach dt)
        {
            //ktra
            //
            clsDAL.insert(dt);
        }

        public void sua(Sach dt)
        {
            //ktra
            //
            clsDAL.update(dt);
        }

        public void xoa(Sach dt)
        {
            //ktra
            //
            clsDAL.delete(dt);
        }
        public DataSet gettendanhmuc(string TenBang)
        {
            return clsDAL.getdatasetSach("danhmuc");
        }
        public DataSet gettentacgia(string TenBang)
        {
            return clsDAL.getdatasetSach("tacgia");
        }
        public DataSet gettennxb(string TenBang)
        {
            return clsDAL.getdatasetSach("nhaxuatban");
        }
        public DataSet gettenvitri(string TenBang)
        {
            return clsDAL.getdatasetSach("vitri");
        }
        public DataSet gettensach(string TenBang)
        {
            return clsDAL.getdatasetSach("sach");
        }


    }
}
