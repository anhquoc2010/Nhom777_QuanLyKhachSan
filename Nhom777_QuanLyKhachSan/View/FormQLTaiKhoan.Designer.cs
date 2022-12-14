namespace Nhom777_QuanLyKhachSan.View
{
    partial class FormQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLTaiKhoan));
            this.lb_quanlytaikhoan = new System.Windows.Forms.Label();
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.bt_ketnoidulieu = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.pb_women = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_phong = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_taikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_trangthai = new System.Windows.Forms.Label();
            this.cbb_quyen = new System.Windows.Forms.ComboBox();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.lb_matkhau = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_taomoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_women)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_quanlytaikhoan
            // 
            this.lb_quanlytaikhoan.AutoSize = true;
            this.lb_quanlytaikhoan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quanlytaikhoan.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_quanlytaikhoan.Location = new System.Drawing.Point(2, 54);
            this.lb_quanlytaikhoan.Name = "lb_quanlytaikhoan";
            this.lb_quanlytaikhoan.Size = new System.Drawing.Size(189, 25);
            this.lb_quanlytaikhoan.TabIndex = 12;
            this.lb_quanlytaikhoan.Text = "Quản lý Tài khoản";
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.AllowUserToAddRows = false;
            this.dgv_taikhoan.AllowUserToDeleteRows = false;
            this.dgv_taikhoan.AllowUserToResizeColumns = false;
            this.dgv_taikhoan.AllowUserToResizeRows = false;
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(2, 96);
            this.dgv_taikhoan.MultiSelect = false;
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.ReadOnly = true;
            this.dgv_taikhoan.RowHeadersWidth = 51;
            this.dgv_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_taikhoan.Size = new System.Drawing.Size(755, 414);
            this.dgv_taikhoan.TabIndex = 10;
            // 
            // bt_ketnoidulieu
            // 
            this.bt_ketnoidulieu.AutoSize = true;
            this.bt_ketnoidulieu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ketnoidulieu.Location = new System.Drawing.Point(572, 54);
            this.bt_ketnoidulieu.Name = "bt_ketnoidulieu";
            this.bt_ketnoidulieu.Size = new System.Drawing.Size(194, 24);
            this.bt_ketnoidulieu.TabIndex = 11;
            this.bt_ketnoidulieu.Text = "Kết nối dữ liệu từ bảng";
            this.bt_ketnoidulieu.UseVisualStyleBackColor = true;
            this.bt_ketnoidulieu.CheckedChanged += new System.EventHandler(this.bt_ketnoidulieu_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pb_logo);
            this.panel3.Controls.Add(this.btDangXuat);
            this.panel3.Controls.Add(this.pb_women);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 31);
            this.panel3.TabIndex = 28;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.logo_hotel;
            this.pb_logo.Location = new System.Drawing.Point(-3, 0);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(38, 31);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.DarkRed;
            this.btDangXuat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.White;
            this.btDangXuat.Location = new System.Drawing.Point(893, 2);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(105, 29);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // pb_women
            // 
            this.pb_women.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.woman;
            this.pb_women.Location = new System.Drawing.Point(862, 2);
            this.pb_women.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_women.Name = "pb_women";
            this.pb_women.Size = new System.Drawing.Size(26, 29);
            this.pb_women.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_women.TabIndex = 1;
            this.pb_women.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_thongke,
            this.mn_phong,
            this.mn_hoadon,
            this.mn_khachhang,
            this.mn_nhanvien,
            this.mn_taikhoan});
            this.menuStrip1.Location = new System.Drawing.Point(32, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(561, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_thongke
            // 
            this.mn_thongke.BackColor = System.Drawing.Color.Transparent;
            this.mn_thongke.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_thongke.ForeColor = System.Drawing.Color.Maroon;
            this.mn_thongke.Name = "mn_thongke";
            this.mn_thongke.Size = new System.Drawing.Size(94, 24);
            this.mn_thongke.Text = "Thống Kê";
            this.mn_thongke.Click += new System.EventHandler(this.mn_thongke_Click);
            // 
            // mn_phong
            // 
            this.mn_phong.BackColor = System.Drawing.Color.Transparent;
            this.mn_phong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_phong.ForeColor = System.Drawing.Color.Maroon;
            this.mn_phong.Name = "mn_phong";
            this.mn_phong.Size = new System.Drawing.Size(67, 24);
            this.mn_phong.Text = "Phòng";
            this.mn_phong.Click += new System.EventHandler(this.mn_phong_Click);
            // 
            // mn_hoadon
            // 
            this.mn_hoadon.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_hoadon.ForeColor = System.Drawing.Color.Maroon;
            this.mn_hoadon.Name = "mn_hoadon";
            this.mn_hoadon.Size = new System.Drawing.Size(88, 24);
            this.mn_hoadon.Text = "Hóa Đơn";
            this.mn_hoadon.Click += new System.EventHandler(this.mn_hoadon_Click);
            // 
            // mn_khachhang
            // 
            this.mn_khachhang.BackColor = System.Drawing.Color.Transparent;
            this.mn_khachhang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_khachhang.ForeColor = System.Drawing.Color.Maroon;
            this.mn_khachhang.Name = "mn_khachhang";
            this.mn_khachhang.Size = new System.Drawing.Size(111, 24);
            this.mn_khachhang.Text = "Khách Hàng";
            this.mn_khachhang.Click += new System.EventHandler(this.mn_khachhang_Click);
            // 
            // mn_nhanvien
            // 
            this.mn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_nhanvien.ForeColor = System.Drawing.Color.Maroon;
            this.mn_nhanvien.Name = "mn_nhanvien";
            this.mn_nhanvien.Size = new System.Drawing.Size(97, 24);
            this.mn_nhanvien.Text = "Nhân Viên";
            this.mn_nhanvien.Click += new System.EventHandler(this.mn_nhanvien_Click);
            // 
            // mn_taikhoan
            // 
            this.mn_taikhoan.BackColor = System.Drawing.Color.RosyBrown;
            this.mn_taikhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_taikhoan.ForeColor = System.Drawing.Color.Maroon;
            this.mn_taikhoan.Name = "mn_taikhoan";
            this.mn_taikhoan.Size = new System.Drawing.Size(98, 24);
            this.mn_taikhoan.Text = "Tài Khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_trangthai);
            this.panel1.Controls.Add(this.cbb_quyen);
            this.panel1.Controls.Add(this.lb_quyen);
            this.panel1.Controls.Add(this.tb_taikhoan);
            this.panel1.Controls.Add(this.lb_taikhoan);
            this.panel1.Controls.Add(this.tb_matkhau);
            this.panel1.Controls.Add(this.lb_matkhau);
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.bt_capnhat);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_taomoi);
            this.panel1.Location = new System.Drawing.Point(763, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 479);
            this.panel1.TabIndex = 29;
            // 
            // lb_trangthai
            // 
            this.lb_trangthai.AutoSize = true;
            this.lb_trangthai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_trangthai.Location = new System.Drawing.Point(3, 454);
            this.lb_trangthai.Name = "lb_trangthai";
            this.lb_trangthai.Size = new System.Drawing.Size(89, 20);
            this.lb_trangthai.TabIndex = 8;
            this.lb_trangthai.Text = "Trạng Thái";
            // 
            // cbb_quyen
            // 
            this.cbb_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_quyen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_quyen.FormattingEnabled = true;
            this.cbb_quyen.Items.AddRange(new object[] {
            "BQT",
            "CCH",
            "NV"});
            this.cbb_quyen.Location = new System.Drawing.Point(98, 154);
            this.cbb_quyen.Name = "cbb_quyen";
            this.cbb_quyen.Size = new System.Drawing.Size(139, 28);
            this.cbb_quyen.TabIndex = 26;
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_quyen.Location = new System.Drawing.Point(2, 157);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(92, 20);
            this.lb_quyen.TabIndex = 25;
            this.lb_quyen.Text = "Quyền Hạn";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_taikhoan.Location = new System.Drawing.Point(98, 60);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(139, 28);
            this.tb_taikhoan.TabIndex = 24;
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_taikhoan.Location = new System.Drawing.Point(2, 64);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(86, 20);
            this.lb_taikhoan.TabIndex = 23;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_matkhau.Location = new System.Drawing.Point(98, 105);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(139, 28);
            this.tb_matkhau.TabIndex = 22;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_matkhau.Location = new System.Drawing.Point(2, 109);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(78, 20);
            this.lb_matkhau.TabIndex = 21;
            this.lb_matkhau.Text = "Mật khẩu";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_thoat.BackgroundImage")));
            this.bt_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_thoat.Location = new System.Drawing.Point(188, 3);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(38, 38);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_capnhat.BackgroundImage")));
            this.bt_capnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_capnhat.Location = new System.Drawing.Point(64, 3);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(38, 38);
            this.bt_capnhat.TabIndex = 2;
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_xoa.BackgroundImage")));
            this.bt_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_xoa.Location = new System.Drawing.Point(125, 3);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(38, 38);
            this.bt_xoa.TabIndex = 1;
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_taomoi
            // 
            this.bt_taomoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_taomoi.BackgroundImage")));
            this.bt_taomoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_taomoi.Location = new System.Drawing.Point(3, 3);
            this.bt_taomoi.Name = "bt_taomoi";
            this.bt_taomoi.Size = new System.Drawing.Size(36, 38);
            this.bt_taomoi.TabIndex = 0;
            this.bt_taomoi.UseVisualStyleBackColor = true;
            this.bt_taomoi.Click += new System.EventHandler(this.bt_taomoi_Click);
            // 
            // FormQLTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lb_quanlytaikhoan);
            this.Controls.Add(this.dgv_taikhoan);
            this.Controls.Add(this.bt_ketnoidulieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormQLTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLTaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.FormQLTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_women)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_quanlytaikhoan;
        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.CheckBox bt_ketnoidulieu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.PictureBox pb_women;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_thongke;
        private System.Windows.Forms.ToolStripMenuItem mn_phong;
        private System.Windows.Forms.ToolStripMenuItem mn_hoadon;
        private System.Windows.Forms.ToolStripMenuItem mn_khachhang;
        private System.Windows.Forms.ToolStripMenuItem mn_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem mn_taikhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_trangthai;
        private System.Windows.Forms.ComboBox cbb_quyen;
        private System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Label lb_matkhau;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_taomoi;
    }
}