namespace Nhom777_QuanLyKhachSan.View
{
    partial class FormQLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKhachHang));
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_timkiemkhachhang = new System.Windows.Forms.Label();
            this.cbb_lockhachhang = new System.Windows.Forms.ComboBox();
            this.dgv_khachhang = new System.Windows.Forms.DataGridView();
            this.bt_search = new System.Windows.Forms.Button();
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
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_cc = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_tekh = new System.Windows.Forms.Label();
            this.lb_makh = new System.Windows.Forms.Label();
            this.tb_cc = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.tb_tenkh = new System.Windows.Forms.TextBox();
            this.tb_makh = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_taomoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_women)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(538, 46);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(45, 13);
            this.linkLabel.TabIndex = 13;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Browser";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_search.Location = new System.Drawing.Point(226, 38);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(270, 26);
            this.tb_search.TabIndex = 12;
            // 
            // lb_timkiemkhachhang
            // 
            this.lb_timkiemkhachhang.AutoSize = true;
            this.lb_timkiemkhachhang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_timkiemkhachhang.ForeColor = System.Drawing.Color.Maroon;
            this.lb_timkiemkhachhang.Location = new System.Drawing.Point(2, 37);
            this.lb_timkiemkhachhang.Name = "lb_timkiemkhachhang";
            this.lb_timkiemkhachhang.Size = new System.Drawing.Size(218, 25);
            this.lb_timkiemkhachhang.TabIndex = 11;
            this.lb_timkiemkhachhang.Text = "Tìm kiếm khách hàng";
            // 
            // cbb_lockhachhang
            // 
            this.cbb_lockhachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_lockhachhang.FormattingEnabled = true;
            this.cbb_lockhachhang.Location = new System.Drawing.Point(596, 40);
            this.cbb_lockhachhang.Name = "cbb_lockhachhang";
            this.cbb_lockhachhang.Size = new System.Drawing.Size(161, 27);
            this.cbb_lockhachhang.TabIndex = 10;
            this.cbb_lockhachhang.SelectedIndexChanged += new System.EventHandler(this.cbb_lockhachhang_SelectedIndexChanged);
            // 
            // dgv_khachhang
            // 
            this.dgv_khachhang.AllowUserToAddRows = false;
            this.dgv_khachhang.AllowUserToDeleteRows = false;
            this.dgv_khachhang.AllowUserToResizeColumns = false;
            this.dgv_khachhang.AllowUserToResizeRows = false;
            this.dgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachhang.Location = new System.Drawing.Point(2, 75);
            this.dgv_khachhang.Name = "dgv_khachhang";
            this.dgv_khachhang.ReadOnly = true;
            this.dgv_khachhang.RowHeadersWidth = 51;
            this.dgv_khachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_khachhang.Size = new System.Drawing.Size(755, 414);
            this.dgv_khachhang.TabIndex = 8;
            this.dgv_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachhang_CellContentClick);
            // 
            // bt_search
            // 
            this.bt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_search.BackgroundImage")));
            this.bt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_search.Location = new System.Drawing.Point(501, 40);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(24, 25);
            this.bt_search.TabIndex = 9;
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pb_logo);
            this.panel3.Controls.Add(this.btDangXuat);
            this.panel3.Controls.Add(this.pb_women);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(993, 31);
            this.panel3.TabIndex = 19;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.logo_hotel;
            this.pb_logo.Location = new System.Drawing.Point(-3, 0);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2);
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
            this.btDangXuat.Location = new System.Drawing.Point(884, 1);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(2);
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
            this.pb_women.Location = new System.Drawing.Point(854, 1);
            this.pb_women.Margin = new System.Windows.Forms.Padding(2);
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
            this.mn_khachhang.BackColor = System.Drawing.Color.RosyBrown;
            this.mn_khachhang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_khachhang.ForeColor = System.Drawing.Color.Maroon;
            this.mn_khachhang.Name = "mn_khachhang";
            this.mn_khachhang.Size = new System.Drawing.Size(111, 24);
            this.mn_khachhang.Text = "Khách Hàng";
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
            this.mn_taikhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_taikhoan.ForeColor = System.Drawing.Color.Maroon;
            this.mn_taikhoan.Name = "mn_taikhoan";
            this.mn_taikhoan.Size = new System.Drawing.Size(98, 24);
            this.mn_taikhoan.Text = "Tài Khoản";
            this.mn_taikhoan.Click += new System.EventHandler(this.mn_taikhoan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbb_gioitinh);
            this.panel1.Controls.Add(this.lb_gioitinh);
            this.panel1.Controls.Add(this.lb_cc);
            this.panel1.Controls.Add(this.lb_sdt);
            this.panel1.Controls.Add(this.lb_diachi);
            this.panel1.Controls.Add(this.lb_tekh);
            this.panel1.Controls.Add(this.lb_makh);
            this.panel1.Controls.Add(this.tb_cc);
            this.panel1.Controls.Add(this.tb_sdt);
            this.panel1.Controls.Add(this.tb_diachi);
            this.panel1.Controls.Add(this.tb_tenkh);
            this.panel1.Controls.Add(this.tb_makh);
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.bt_capnhat);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_taomoi);
            this.panel1.Location = new System.Drawing.Point(763, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 462);
            this.panel1.TabIndex = 20;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(89, 268);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(137, 27);
            this.cbb_gioitinh.TabIndex = 15;
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_gioitinh.Location = new System.Drawing.Point(3, 274);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(73, 20);
            this.lb_gioitinh.TabIndex = 14;
            this.lb_gioitinh.Text = "Giới tính";
            // 
            // lb_cc
            // 
            this.lb_cc.AutoSize = true;
            this.lb_cc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_cc.Location = new System.Drawing.Point(3, 228);
            this.lb_cc.Name = "lb_cc";
            this.lb_cc.Size = new System.Drawing.Size(79, 20);
            this.lb_cc.TabIndex = 13;
            this.lb_cc.Text = "Căn cước";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sdt.Location = new System.Drawing.Point(3, 185);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(44, 20);
            this.lb_sdt.TabIndex = 12;
            this.lb_sdt.Text = "SĐT";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_diachi.Location = new System.Drawing.Point(3, 143);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(60, 20);
            this.lb_diachi.TabIndex = 11;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_tekh
            // 
            this.lb_tekh.AutoSize = true;
            this.lb_tekh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tekh.Location = new System.Drawing.Point(3, 102);
            this.lb_tekh.Name = "lb_tekh";
            this.lb_tekh.Size = new System.Drawing.Size(69, 20);
            this.lb_tekh.TabIndex = 10;
            this.lb_tekh.Text = "Tên KH";
            // 
            // lb_makh
            // 
            this.lb_makh.AutoSize = true;
            this.lb_makh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_makh.Location = new System.Drawing.Point(3, 59);
            this.lb_makh.Name = "lb_makh";
            this.lb_makh.Size = new System.Drawing.Size(64, 20);
            this.lb_makh.TabIndex = 9;
            this.lb_makh.Text = "Mã KH";
            // 
            // tb_cc
            // 
            this.tb_cc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_cc.Location = new System.Drawing.Point(89, 225);
            this.tb_cc.Name = "tb_cc";
            this.tb_cc.Size = new System.Drawing.Size(137, 26);
            this.tb_cc.TabIndex = 8;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_sdt.Location = new System.Drawing.Point(89, 182);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(137, 26);
            this.tb_sdt.TabIndex = 7;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_diachi.Location = new System.Drawing.Point(89, 140);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(137, 26);
            this.tb_diachi.TabIndex = 6;
            // 
            // tb_tenkh
            // 
            this.tb_tenkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tenkh.Location = new System.Drawing.Point(89, 99);
            this.tb_tenkh.Name = "tb_tenkh";
            this.tb_tenkh.Size = new System.Drawing.Size(137, 26);
            this.tb_tenkh.TabIndex = 5;
            // 
            // tb_makh
            // 
            this.tb_makh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_makh.Location = new System.Drawing.Point(89, 56);
            this.tb_makh.Name = "tb_makh";
            this.tb_makh.Size = new System.Drawing.Size(137, 26);
            this.tb_makh.TabIndex = 4;
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
            this.bt_taomoi.Size = new System.Drawing.Size(38, 38);
            this.bt_taomoi.TabIndex = 0;
            this.bt_taomoi.UseVisualStyleBackColor = true;
            this.bt_taomoi.Click += new System.EventHandler(this.bt_taomoi_Click);
            // 
            // FormQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lb_timkiemkhachhang);
            this.Controls.Add(this.cbb_lockhachhang);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.dgv_khachhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormQLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.FormQLKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachhang)).EndInit();
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

        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_timkiemkhachhang;
        private System.Windows.Forms.ComboBox cbb_lockhachhang;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridView dgv_khachhang;
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
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_cc;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_tekh;
        private System.Windows.Forms.Label lb_makh;
        private System.Windows.Forms.TextBox tb_cc;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.TextBox tb_tenkh;
        private System.Windows.Forms.TextBox tb_makh;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_taomoi;
    }
}