using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        clsDB kn = new clsDB();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tendn = txtTenDN.Text;
            String mk = txtMK.Text;
            String query1 = ("SELECT * FROM nhanvien WHERE manhanvien='" + tendn + "' and matkhau='" + mk + "' and machucvu='1'");
            String query2 = ("SELECT * FROM nhanvien WHERE manhanvien='" + tendn + "' and matkhau='" + mk + "' and machucvu='2'");
            DataTable data1 = new DataTable();
            DataTable data2 = new DataTable();
            data1 = kn.TaoBang(query1);
            data2 = kn.TaoBang(query2);
            if (data1.Rows.Count != 0)
            {
                frmQlthuvien frm = new frmQlthuvien("Admin", tendn,mk);
                frm.ShowDialog();
            }
            else if (data2.Rows.Count != 0)
            {
                frmQlthuvien frm = new frmQlthuvien("Thủ thư", tendn,mk);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !", "Lỗi ", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
