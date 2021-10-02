using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmThongTinCaNhan : Form
    {
        string manv;
        string pass;
        NhanVien_BLL dt = new NhanVien_BLL();
        clsDB kn = new clsDB();

        public frmThongTinCaNhan(string ma, string mk)
        {
            InitializeComponent();
            manv = ma;
            pass = mk;
        }

        private void frmThongTinCaNha_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            String query1 = ("SELECT * FROM nhanvien WHERE manhanvien='" + manv + "'");
            DataTable data1 = new DataTable();
            data1 = kn.TaoBang(query1);

            txtTen.DataBindings.Add("text", data1, "tennhanvien");
            txtCMND.DataBindings.Add("text", data1, "CMND");
            dateTimePicker1.DataBindings.Add("text", data1, "ngaysinh");
            txtSDT.DataBindings.Add("text", data1, "sodienthoai");
            txtDiaChi.DataBindings.Add("text", data1, "diachi");
        }
        private void btnsuaTT_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtTen.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhanVien db = new NhanVien(manv, txtPassCu.Text, txtTen.Text, txtCMND.Text, dateTimePicker1.Value.ToString(), txtSDT.Text, txtDiaChi.Text, "null", "null");
                    dt.suatt(db);
                    MessageBox.Show("Cập nhật thành công !", "Thông báo ", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !", "Lỗi ", MessageBoxButtons.OK);
            }
        }

        private void btnsuapass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassCu.Text.Length == 0 || txtPassMoi.Text.Length == 0 || txtPassMoi.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong  !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtPassCu.Text != pass )
                {
                    MessageBox.Show("Sai mật khẩu cũ  !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtPassMoi.Text != txtRePass.Text)
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng  !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhanVien db = new NhanVien(manv, txtPassMoi.Text, txtTen.Text, txtCMND.Text, dateTimePicker1.Value.ToString(), txtSDT.Text, txtDiaChi.Text, "null", "null");
                    dt.suapass(db);
                    MessageBox.Show("Cập nhật thành công !", "Thông báo ", MessageBoxButtons.OK);
                    pass = txtPassMoi.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !", "Lỗi ", MessageBoxButtons.OK);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
