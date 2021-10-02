using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }
        Sach_BLL dt = new Sach_BLL();
        private void frmQLSach_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = dt.layDuLieu();

            //đưa dữ liệu lên ComboBox tên danh mục
            cbbdanhmuc.DisplayMember = "tendanhmuc";
            cbbdanhmuc.ValueMember = "madanhmuc";
            cbbdanhmuc.DataSource = dt.gettendanhmuc("danhmuc").Tables[0];

            //đưa dữ liệu lên ComboBox tên tác giả
            cbbtacgia.DisplayMember = "tentacgia";
            cbbtacgia.ValueMember = "matacgia";
            cbbtacgia.DataSource = dt.gettentacgia("tacgia").Tables[0];

            //đưa dữ liệu lên ComboBox tên nhà xuất bản
            cbbnxb.DisplayMember = "tennhaxuatban";
            cbbnxb.ValueMember = "manhaxuatban";
            cbbnxb.DataSource = dt.gettennxb("nhaxuatban").Tables[0];

            //đưa dữ liệu lên ComboBox tên vị trí
            cbbvitri.DisplayMember = "tenvitri";
            cbbvitri.ValueMember = "mavitri";
            cbbvitri.DataSource = dt.gettenvitri("vitri").Tables[0];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madanhmuc = cbbdanhmuc.SelectedValue.ToString();
            string matacgia = cbbtacgia.SelectedValue.ToString();
            string manxb = cbbnxb.SelectedValue.ToString();
            string mavitri = cbbvitri.SelectedValue.ToString();
            try
            {
                if (txttensach.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Sach db = new Sach(txtmasach.Text, txttensach.Text, madanhmuc, matacgia, manxb, int.Parse(txtsoluong.Text), mavitri,double.Parse(txtgiagoc.Text));
                    dt.them(db);
                    MessageBox.Show("Thêm thành công !", "Thông báo ", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công !", "Lỗi ", MessageBoxButtons.OK);
            }
            loadData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madanhmuc = cbbdanhmuc.SelectedValue.ToString();
            string matacgia = cbbtacgia.SelectedValue.ToString();
            string manxb = cbbnxb.SelectedValue.ToString();
            string mavitri = cbbvitri.SelectedValue.ToString();
            try
            {
                if (txtmasach.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Sach db = new Sach(txtmasach.Text, txttensach.Text, madanhmuc, matacgia, manxb, int.Parse(txtsoluong.Text), mavitri, double.Parse(txtgiagoc.Text));
                    dt.sua(db);
                    MessageBox.Show("Cập nhật thành công !", "Thông báo ", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !", "Lỗi ", MessageBoxButtons.OK);
            }
            loadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string madanhmuc = cbbdanhmuc.SelectedValue.ToString();
            string matacgia = cbbtacgia.SelectedValue.ToString();
            string manxb = cbbnxb.SelectedValue.ToString();
            string mavitri = cbbvitri.SelectedValue.ToString();
            string ma = txtmasach.Text + "";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Sach db = new Sach(txtmasach.Text, txttensach.Text, madanhmuc, matacgia, manxb, int.Parse(txtsoluong.Text), mavitri, double.Parse(txtgiagoc.Text));
                dt.xoa(db);
            }
            loadData();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtmasach.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            txttensach.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            cbbdanhmuc.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
            cbbtacgia.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
            cbbnxb.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
            txtsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
            cbbvitri.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
            txtgiagoc.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value + "";
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
