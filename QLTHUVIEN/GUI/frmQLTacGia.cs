using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQLTacGia : Form
    {
        public frmQLTacGia()
        {
            InitializeComponent();
        }
        TacGia_BLL dt = new TacGia_BLL();
        private void frmQLTacGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = dt.layDuLieu();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttendm.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TacGia db = new TacGia(txtmatg.Text, txttendm.Text);
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
            try
            {
                if (txtmatg.Text.Length == 0 || txttendm.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TacGia db = new TacGia(txtmatg.Text, txttendm.Text);
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
            string ma = txtmatg.Text + "";
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                TacGia db = new TacGia(txtmatg.Text, txttendm.Text);
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
            txtmatg.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            txttendm.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
        }

    }
}
