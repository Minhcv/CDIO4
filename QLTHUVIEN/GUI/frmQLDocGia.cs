using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQLDocGia : Form
    {
        public frmQLDocGia()
        {
            InitializeComponent();
        }
        DocGia_BLL dt = new DocGia_BLL();
        private void frmQLDocGia_Load(object sender, EventArgs e)
        {
            loadData();
            comboBox1.Text = "false";
        }
        void loadData()
        {
            dataGridView1.DataSource = dt.layDuLieu();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttendg.Text.Length == 0 )
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DocGia db = new DocGia(txtmadg.Text, txttendg.Text, dtpngaysinh.Value.ToString(), txtdiachi.Text, txtnghenghiep.Text, txtCMND.Text, dtpngaycapthe.Value.ToString(), dtpngayhethan.Value.ToString(),txtsl.Text , txttienkigui.Text, comboBox1.Text);
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
                if (txtmadg.Text.Length == 0 || txttendg.Text.Length == 0)
                {
                    MessageBox.Show("Chưa nhập xong !", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DocGia db = new DocGia(txtmadg.Text, txttendg.Text, dtpngaysinh.Value.ToString(), txtdiachi.Text, txtnghenghiep.Text, txtCMND.Text, dtpngaycapthe.Value.ToString(), dtpngayhethan.Value.ToString(),txtsl.Text , txttienkigui.Text, comboBox1.Text);
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

            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                DocGia db = new DocGia(txtmadg.Text, txttendg.Text, dtpngaysinh.Value.ToString(), txtdiachi.Text, txtnghenghiep.Text, txtCMND.Text, dtpngaycapthe.Value.ToString(), dtpngayhethan.Value.ToString(), txtsl.Text, txttienkigui.Text, comboBox1.Text);
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
            txtmadg.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            txttendg.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            dtpngaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
            txtdiachi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
            txtnghenghiep.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
            txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
            dtpngaycapthe.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value + "";
            dtpngayhethan.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value + "";
            txtsl.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value + "";
            txttienkigui.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value + "";
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value + "";
        }

        private void txtsl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttienkigui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
