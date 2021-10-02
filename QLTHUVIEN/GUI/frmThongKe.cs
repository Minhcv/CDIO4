using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmThongKe : Form
    {
        clsDB kn = new clsDB();
        PhieuYeuCau_BLL dt = new PhieuYeuCau_BLL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            //đưa dữ liệu lên ComboBox tên độc giả
            comboBox2.DisplayMember = "tendocgia";
            comboBox2.ValueMember = "madocgia";
            comboBox2.DataSource = dt.gettendocgia("docgia").Tables[0];

            //đưa dữ liệu lên ComboBox tên sách
            cbbSach.DisplayMember = "tensach";
            cbbSach.ValueMember = "masach";
            cbbSach.DataSource = dt.gettensach("sach").Tables[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from sach_qua_han where tendocgia like N'%" + comboBox2.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from sach_qua_han where tendocgia like N'%" + comboBox2.Text.ToString() + "%'";
            dataGridView1.DataSource = kn.TaoBang(sql1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from sach_dang_muon where tensach like N'%" + cbbSach.Text.ToString() + "%'";
            dataGridView2.DataSource = kn.TaoBang(sql1);
        }

        private void cbbSach_TextChanged(object sender, EventArgs e)
        {
            string sql1 = "Select *from sach_dang_muon where tensach like N'%" + cbbSach.Text.ToString() + "%'";
            dataGridView2.DataSource = kn.TaoBang(sql1);
        }
    }
}
