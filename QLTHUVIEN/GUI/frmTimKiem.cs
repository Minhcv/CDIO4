using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        Sach_BLL dt = new Sach_BLL();
        clsDB kn = new clsDB();
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {

            //đưa dữ liệu lên ComboBox tên danh mục
            cbbTenDanhMuc.DisplayMember = "tendanhmuc";
            cbbTenDanhMuc.ValueMember = "madanhmuc";
            cbbTenDanhMuc.DataSource = dt.gettendanhmuc("danhmuc").Tables[0];

            //đưa dữ liệu lên ComboBox tên tác giả
            cbbTenTG.DisplayMember = "tentacgia";
            cbbTenTG.ValueMember = "matacgia";
            cbbTenTG.DataSource = dt.gettentacgia("tacgia").Tables[0];

            //đưa dữ liệu lên ComboBox tên nhà xuất bản
            cbbTenNXB.DisplayMember = "tennhaxuatban";
            cbbTenNXB.ValueMember = "manhaxuatban";
            cbbTenNXB.DataSource = dt.gettennxb("nhaxuatban").Tables[0];

            //đưa dữ liệu lên ComboBox tên sach
            cbbTenSach.DisplayMember = "tensach";
            cbbTenSach.ValueMember = "masach";
            cbbTenSach.DataSource = dt.gettensach("sach").Tables[0];
        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where TenSach like N'%" + cbbTenSach.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenSach_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where TenSach like N'%" + cbbTenSach.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenTG_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tentacgia like N'%" + cbbTenTG.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenDanhMuc_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tendanhmuc like N'%" + cbbTenDanhMuc.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenNXB_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tennhaxuatban like N'%" + cbbTenNXB.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tentacgia like N'%" + cbbTenTG.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tendanhmuc like N'%" + cbbTenDanhMuc.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void cbbTenNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from view_sach where tennhaxuatban like N'%" + cbbTenNXB.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }
    }
}
