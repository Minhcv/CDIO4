
namespace QLTHUVIEN
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbTenSach = new System.Windows.Forms.ComboBox();
            this.cbbTenTG = new System.Windows.Forms.ComboBox();
            this.cbbTenDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbbTenNXB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbTenSach
            // 
            this.cbbTenSach.FormattingEnabled = true;
            this.cbbTenSach.Location = new System.Drawing.Point(251, 34);
            this.cbbTenSach.Name = "cbbTenSach";
            this.cbbTenSach.Size = new System.Drawing.Size(348, 28);
            this.cbbTenSach.TabIndex = 0;
            this.cbbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbbTenSach_SelectedIndexChanged);
            this.cbbTenSach.TextChanged += new System.EventHandler(this.cbbTenSach_TextChanged);
            // 
            // cbbTenTG
            // 
            this.cbbTenTG.FormattingEnabled = true;
            this.cbbTenTG.Location = new System.Drawing.Point(251, 83);
            this.cbbTenTG.Name = "cbbTenTG";
            this.cbbTenTG.Size = new System.Drawing.Size(348, 28);
            this.cbbTenTG.TabIndex = 0;
            this.cbbTenTG.SelectedIndexChanged += new System.EventHandler(this.cbbTenTG_SelectedIndexChanged);
            this.cbbTenTG.TextChanged += new System.EventHandler(this.cbbTenTG_TextChanged);
            // 
            // cbbTenDanhMuc
            // 
            this.cbbTenDanhMuc.FormattingEnabled = true;
            this.cbbTenDanhMuc.Location = new System.Drawing.Point(251, 136);
            this.cbbTenDanhMuc.Name = "cbbTenDanhMuc";
            this.cbbTenDanhMuc.Size = new System.Drawing.Size(348, 28);
            this.cbbTenDanhMuc.TabIndex = 0;
            this.cbbTenDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbbTenDanhMuc_SelectedIndexChanged);
            this.cbbTenDanhMuc.TextChanged += new System.EventHandler(this.cbbTenDanhMuc_TextChanged);
            // 
            // cbbTenNXB
            // 
            this.cbbTenNXB.FormattingEnabled = true;
            this.cbbTenNXB.Location = new System.Drawing.Point(251, 195);
            this.cbbTenNXB.Name = "cbbTenNXB";
            this.cbbTenNXB.Size = new System.Drawing.Size(348, 28);
            this.cbbTenNXB.TabIndex = 0;
            this.cbbTenNXB.SelectedIndexChanged += new System.EventHandler(this.cbbTenNXB_SelectedIndexChanged);
            this.cbbTenNXB.TextChanged += new System.EventHandler(this.cbbTenNXB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên nhà xuất bản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(65, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(903, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENSACH";
            this.Column1.HeaderText = "Tên sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTACGIA";
            this.Column2.HeaderText = "Tên Tác giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENDANHMUC";
            this.Column3.HeaderText = "Tên danh mục";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENNHAXUATBAN";
            this.Column4.HeaderText = "Tên nhà xuất bản";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENVITRI";
            this.Column5.HeaderText = "Tên vị trí";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SOLUONGSACHCON";
            this.Column6.HeaderText = "Số lượng sách còn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GIAGOC";
            this.Column7.HeaderText = "Giá góc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 623);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTenNXB);
            this.Controls.Add(this.cbbTenDanhMuc);
            this.Controls.Add(this.cbbTenTG);
            this.Controls.Add(this.cbbTenSach);
            this.Name = "frmTimKiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTenSach;
        private System.Windows.Forms.ComboBox cbbTenTG;
        private System.Windows.Forms.ComboBox cbbTenDanhMuc;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbTenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}