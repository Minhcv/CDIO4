using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQLNhanVien : Form
    {
        NhanVien_BLL dt = new NhanVien_BLL();
        public frmQLNhanVien()
        {
            InitializeComponent();
        }
        
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            cbbTrangThai.Text = "false";
        }
        void loadData()
        {
            dataGridView1.DataSource = dt.layDuLieu();

            //đưa dữ liệu lên ComboBox tên danh mục
            cbbchucvu.DisplayMember = "tenchucvu";
            cbbchucvu.ValueMember = "machucvu";
            cbbchucvu.DataSource = dt.gettenchucvu("chucvu").Tables[0];
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string chucvu = cbbchucvu.SelectedValue.ToString();
            try
            {
                if (txtmatkhau.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhanVien db = new NhanVien(txtmanv.Text, txtmatkhau.Text, txttennv.Text, txtcmnd.Text, dtpns.Value.ToString(), txtsdt.Text, txtdiachi.Text, chucvu, cbbTrangThai.Text);
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
            string chucvu = cbbchucvu.SelectedValue.ToString();
            try
            {
                if (txtmanv.Text.Length == 0 || txtmatkhau.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NhanVien db = new NhanVien(txtmanv.Text, txtmatkhau.Text, txttennv.Text, txtcmnd.Text, dtpns.Value.ToString(), txtsdt.Text, txtdiachi.Text, chucvu, cbbTrangThai.Text);
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
            string chucvu = cbbchucvu.SelectedValue.ToString();
            string ma = txtmanv.Text + "";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                NhanVien db = new NhanVien(txtmanv.Text, txtmatkhau.Text, txttennv.Text, txtcmnd.Text, dtpns.Value.ToString(), txtsdt.Text, txtdiachi.Text, chucvu,cbbTrangThai.Text);
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
            txtmanv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            txtmatkhau.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            txttennv.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
            txtcmnd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
            dtpns.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
            txtsdt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
            cbbchucvu.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[7].Value + "";
            cbbTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value + "";
        }
    }
}
