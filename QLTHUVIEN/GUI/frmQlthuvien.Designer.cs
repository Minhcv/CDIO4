
namespace QLTHUVIEN
{
    partial class frmQlthuvien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQlthuvien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmthuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqldocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqlsach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqldanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqlnxb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqlvitri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqltacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtimsach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmtheodoimuon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmadmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmqlnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmthuthu,
            this.tsmadmin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmthuthu
            // 
            this.tsmthuthu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmqldocgia,
            this.tsmqlsach,
            this.tsmqldanhmuc,
            this.tsmqlnxb,
            this.tsmqlvitri,
            this.tsmqltacgia,
            this.tsmtimsach,
            this.tsmtheodoimuon,
            this.tsmthongke});
            this.tsmthuthu.Name = "tsmthuthu";
            this.tsmthuthu.Size = new System.Drawing.Size(79, 24);
            this.tsmthuthu.Text = "Thủ thư";
            // 
            // tsmqldocgia
            // 
            this.tsmqldocgia.Name = "tsmqldocgia";
            this.tsmqldocgia.Size = new System.Drawing.Size(240, 26);
            this.tsmqldocgia.Text = "Quản lý độc giả";
            this.tsmqldocgia.Click += new System.EventHandler(this.tsmqldocgia_Click);
            // 
            // tsmqlsach
            // 
            this.tsmqlsach.Name = "tsmqlsach";
            this.tsmqlsach.Size = new System.Drawing.Size(240, 26);
            this.tsmqlsach.Text = "Quản lý sách";
            this.tsmqlsach.Click += new System.EventHandler(this.tsmqlsach_Click);
            // 
            // tsmqldanhmuc
            // 
            this.tsmqldanhmuc.Name = "tsmqldanhmuc";
            this.tsmqldanhmuc.Size = new System.Drawing.Size(240, 26);
            this.tsmqldanhmuc.Text = "Quản lý danh mục";
            this.tsmqldanhmuc.Click += new System.EventHandler(this.tsmqldanhmuc_Click);
            // 
            // tsmqlnxb
            // 
            this.tsmqlnxb.Name = "tsmqlnxb";
            this.tsmqlnxb.Size = new System.Drawing.Size(240, 26);
            this.tsmqlnxb.Text = "Quản lý nhà xuất bản";
            this.tsmqlnxb.Click += new System.EventHandler(this.tsmqlnxb_Click);
            // 
            // tsmqlvitri
            // 
            this.tsmqlvitri.Name = "tsmqlvitri";
            this.tsmqlvitri.Size = new System.Drawing.Size(240, 26);
            this.tsmqlvitri.Text = "Quản lý vị trí";
            this.tsmqlvitri.Click += new System.EventHandler(this.tsmqlvitri_Click);
            // 
            // tsmqltacgia
            // 
            this.tsmqltacgia.Name = "tsmqltacgia";
            this.tsmqltacgia.Size = new System.Drawing.Size(240, 26);
            this.tsmqltacgia.Text = "Quản lý tác giả";
            this.tsmqltacgia.Click += new System.EventHandler(this.tsmqltacgia_Click);
            // 
            // tsmtimsach
            // 
            this.tsmtimsach.Name = "tsmtimsach";
            this.tsmtimsach.Size = new System.Drawing.Size(240, 26);
            this.tsmtimsach.Text = "Tìm sách";
            this.tsmtimsach.Click += new System.EventHandler(this.tsmtimsach_Click);
            // 
            // tsmtheodoimuon
            // 
            this.tsmtheodoimuon.Name = "tsmtheodoimuon";
            this.tsmtheodoimuon.Size = new System.Drawing.Size(240, 26);
            this.tsmtheodoimuon.Text = "Theo dõi mượn - trả";
            this.tsmtheodoimuon.Click += new System.EventHandler(this.tsmtheodoimuon_Click);
            // 
            // tsmthongke
            // 
            this.tsmthongke.Name = "tsmthongke";
            this.tsmthongke.Size = new System.Drawing.Size(240, 26);
            this.tsmthongke.Text = "Thống kê";
            this.tsmthongke.Click += new System.EventHandler(this.tsmthongke_Click);
            // 
            // tsmadmin
            // 
            this.tsmadmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmqlnhanvien,
            this.tsmThongTin,
            this.tsmDangXuat,
            this.tsmThoat});
            this.tsmadmin.Name = "tsmadmin";
            this.tsmadmin.Size = new System.Drawing.Size(70, 24);
            this.tsmadmin.Text = "Admin";
            this.tsmadmin.Click += new System.EventHandler(this.tsmadmin_Click);
            // 
            // tsmqlnhanvien
            // 
            this.tsmqlnhanvien.Name = "tsmqlnhanvien";
            this.tsmqlnhanvien.Size = new System.Drawing.Size(218, 26);
            this.tsmqlnhanvien.Text = "Quản lý nhân viên";
            this.tsmqlnhanvien.Click += new System.EventHandler(this.tsmqlnhanvien_Click);
            // 
            // tsmThongTin
            // 
            this.tsmThongTin.Name = "tsmThongTin";
            this.tsmThongTin.Size = new System.Drawing.Size(218, 26);
            this.tsmThongTin.Text = "Thông tin cá nhân";
            this.tsmThongTin.Click += new System.EventHandler(this.tsmThongTin_Click);
            // 
            // tsmDangXuat
            // 
            this.tsmDangXuat.Name = "tsmDangXuat";
            this.tsmDangXuat.Size = new System.Drawing.Size(218, 26);
            this.tsmDangXuat.Text = "Đăng xuất";
            this.tsmDangXuat.Click += new System.EventHandler(this.tsmDangXuat_Click_1);
            // 
            // tsmThoat
            // 
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(218, 26);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsmThoat_Click);
            // 
            // tsmThongTinCaNhan
            // 
            this.tsmThongTinCaNhan.Name = "tsmThongTinCaNhan";
            this.tsmThongTinCaNhan.Size = new System.Drawing.Size(210, 26);
            this.tsmThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // frmQlthuvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 500);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQlthuvien";
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.qlthuvien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmthuthu;
        private System.Windows.Forms.ToolStripMenuItem tsmadmin;
        private System.Windows.Forms.ToolStripMenuItem tsmqlnhanvien;
        private System.Windows.Forms.ToolStripMenuItem tsmqldocgia;
        private System.Windows.Forms.ToolStripMenuItem tsmqlsach;
        private System.Windows.Forms.ToolStripMenuItem tsmqldanhmuc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem tsmqlnxb;
        private System.Windows.Forms.ToolStripMenuItem tsmqlvitri;
        private System.Windows.Forms.ToolStripMenuItem tsmqltacgia;
        private System.Windows.Forms.ToolStripMenuItem tsmtimsach;
        private System.Windows.Forms.ToolStripMenuItem tsmtheodoimuon;
        private System.Windows.Forms.ToolStripMenuItem tsmthongke;
        private System.Windows.Forms.ToolStripMenuItem tsmThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem tsmThongTin;
        private System.Windows.Forms.ToolStripMenuItem tsmThoat;
    }
}

