using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQlthuvien : Form
    {
        string manv;
        string pass;
        public frmQlthuvien( string cv, string ma, string mk)
        {
            InitializeComponent();
            manv = ma;
            pass = mk;
            if(cv == "Admin")
            {
                tsmadmin.Text = "Admin";
            }
            else
            {
                tsmadmin.Text = "Thủ thư";
                tsmqlnhanvien.Visible = false;
            }

        }

        private void tsmqldanhmuc_Click(object sender, EventArgs e)
        {
            frmQLDanhMuc frm = new frmQLDanhMuc();
            frm.ShowDialog();
        }

        private void tsmqltacgia_Click(object sender, EventArgs e)
        {
            frmQLTacGia frm = new frmQLTacGia();
            frm.ShowDialog();
        }

        private void tsmqlvitri_Click(object sender, EventArgs e)
        {
            frmQLViTri frm = new frmQLViTri();
            frm.ShowDialog();
        }

        private void tsmqlnxb_Click(object sender, EventArgs e)
        {
            frmQLNXB frm = new frmQLNXB();
            frm.ShowDialog();
        }

        private void tsmqlsach_Click(object sender, EventArgs e)
        {
            frmQLSach frm = new frmQLSach();
            frm.ShowDialog();
        }

        private void tsmqldocgia_Click(object sender, EventArgs e)
        {
            frmQLDocGia frm = new frmQLDocGia();
            frm.ShowDialog();
        }

        private void tsmdangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmtheodoimuon_Click(object sender, EventArgs e)
        {
            frmQLMuon frm = new frmQLMuon(manv);
            frm.ShowDialog();
        }

        private void qlthuvien_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmqlnhanvien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = new frmQLNhanVien();
            frm.ShowDialog();
        }

        private void tsmtimsach_Click(object sender, EventArgs e)
        {
            frmTimKiem frm = new frmTimKiem();
            frm.ShowDialog();
        }

        private void tsmadmin_Click(object sender, EventArgs e)
        {

        }

        private void tsmDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmThongTin_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan frm = new frmThongTinCaNhan(manv, pass);
            frm.ShowDialog();
        }

        private void tsmthongke_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }
    }
}
