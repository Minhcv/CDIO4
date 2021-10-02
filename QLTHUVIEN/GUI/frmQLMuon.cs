using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    public partial class frmQLMuon : Form
    {
        string manv;
        public frmQLMuon(string ma)
        {
            InitializeComponent();
            manv = ma;
        }
        PhieuYeuCau_BLL dt = new PhieuYeuCau_BLL();
        private void frmQLMuon_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            dataGridView1.DataSource = dt.layDuLieu();

            //đưa dữ liệu lên ComboBox tên độc giả
            cbbmadg.DisplayMember = "tendocgia";
            cbbmadg.ValueMember = "madocgia";
            cbbmadg.DataSource = dt.gettendocgia("docgia").Tables[0];

            //đưa dữ liệu lên ComboBox tên sách
            cbbmasach.DisplayMember = "tensach";
            cbbmasach.ValueMember = "masach";
            cbbmasach.DataSource = dt.gettensach("sach").Tables[0];
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string madg = cbbmadg.SelectedValue.ToString();
            string masach = cbbmasach.SelectedValue.ToString();
            try
            {
                    PhieuYeuCau db = new PhieuYeuCau(txtsophieu.Text,madg, masach, txtsoluong.Text, dtpngaymuon.Value.ToString(), dtpngaytra.Value.ToString(), manv);
                    dt.them(db);
                    MessageBox.Show("Mượn thành công !", "Thông báo ", MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mượn không thành công !", "Lỗi ", MessageBoxButtons.OK);
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
            txtsophieu.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
            cbbmadg.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value + "";
            cbbmasach.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value + "";
            txtsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value + "";
            dtpngaymuon.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value + "";
            dtpngaytra.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value + "";
        }

        private void btntra_Click(object sender, EventArgs e)
        {
            string madg = cbbmadg.SelectedValue.ToString();
            string masach = cbbmasach.SelectedValue.ToString();
            DialogResult traloi = MessageBox.Show("Bạn có chắc chắn trả không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                PhieuYeuCau db = new PhieuYeuCau(txtsophieu.Text, madg, masach, txtsoluong.Text, dtpngaymuon.Value.ToString(), dtpngaytra.Value.ToString(), manv);
                dt.xoa(db);
            }
            loadData();
        }


        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string madg = cbbmadg.SelectedValue.ToString();
            string masach = cbbmasach.SelectedValue.ToString();
            try
            {
                PhieuYeuCau db = new PhieuYeuCau(txtsophieu.Text, madg, masach, txtsoluong.Text, dtpngaymuon.Value.ToString(), dtpngaytra.Value.ToString(), manv);
                dt.sua(db);
                MessageBox.Show("Cập nhật thành công !", "Thông báo ", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công !", "Lỗi ", MessageBoxButtons.OK);
            }
            loadData();
        }
    }
}
