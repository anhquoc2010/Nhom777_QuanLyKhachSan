namespace Nhom777_QuanLyKhachSan.View
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_luongkhach = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart_luongkhach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.lb_data_sovoihomqua = new System.Windows.Forms.Label();
            this.lb_sovoihomqua = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_data_doanhthuthang = new System.Windows.Forms.Label();
            this.lb_doanhthuthang = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_data_khachhangthang = new System.Windows.Forms.Label();
            this.lb_khachhangthang = new System.Windows.Forms.Label();
            this.lb_data_doanhthungay = new System.Windows.Forms.Label();
            this.lb_doanhthungay = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart_doanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_phong = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_taikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_women = new System.Windows.Forms.PictureBox();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_luongkhach)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_women)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_luongkhach
            // 
            this.lb_luongkhach.AutoSize = true;
            this.lb_luongkhach.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luongkhach.Location = new System.Drawing.Point(99, 10);
            this.lb_luongkhach.Name = "lb_luongkhach";
            this.lb_luongkhach.Size = new System.Drawing.Size(313, 25);
            this.lb_luongkhach.TabIndex = 1;
            this.lb_luongkhach.Text = "Lượng khách 7 ngày gần nhất";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.chart_luongkhach);
            this.panel7.Controls.Add(this.lb_luongkhach);
            this.panel7.Location = new System.Drawing.Point(9, 247);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 317);
            this.panel7.TabIndex = 16;
            // 
            // chart_luongkhach
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_luongkhach.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_luongkhach.Legends.Add(legend1);
            this.chart_luongkhach.Location = new System.Drawing.Point(6, 48);
            this.chart_luongkhach.Name = "chart_luongkhach";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_luongkhach.Series.Add(series1);
            this.chart_luongkhach.Size = new System.Drawing.Size(474, 261);
            this.chart_luongkhach.TabIndex = 2;
            this.chart_luongkhach.Text = "chart_luongkhach";
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthu.Location = new System.Drawing.Point(118, 15);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(286, 25);
            this.lb_doanhthu.TabIndex = 0;
            this.lb_doanhthu.Text = "Doanh thu 7 ngày gần nhất";
            // 
            // lb_data_sovoihomqua
            // 
            this.lb_data_sovoihomqua.AutoSize = true;
            this.lb_data_sovoihomqua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_sovoihomqua.ForeColor = System.Drawing.Color.Maroon;
            this.lb_data_sovoihomqua.Location = new System.Drawing.Point(19, 42);
            this.lb_data_sovoihomqua.Name = "lb_data_sovoihomqua";
            this.lb_data_sovoihomqua.Size = new System.Drawing.Size(48, 25);
            this.lb_data_sovoihomqua.TabIndex = 1;
            this.lb_data_sovoihomqua.Text = "1%";
            // 
            // lb_sovoihomqua
            // 
            this.lb_sovoihomqua.AutoSize = true;
            this.lb_sovoihomqua.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sovoihomqua.Location = new System.Drawing.Point(5, 9);
            this.lb_sovoihomqua.Name = "lb_sovoihomqua";
            this.lb_sovoihomqua.Size = new System.Drawing.Size(161, 26);
            this.lb_sovoihomqua.TabIndex = 0;
            this.lb_sovoihomqua.Text = "So với hôm qua";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.lb_data_sovoihomqua);
            this.panel5.Controls.Add(this.lb_sovoihomqua);
            this.panel5.Location = new System.Drawing.Point(244, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 80);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.lb_data_doanhthuthang);
            this.panel4.Controls.Add(this.lb_doanhthuthang);
            this.panel4.Location = new System.Drawing.Point(6, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 80);
            this.panel4.TabIndex = 13;
            // 
            // lb_data_doanhthuthang
            // 
            this.lb_data_doanhthuthang.AutoSize = true;
            this.lb_data_doanhthuthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_doanhthuthang.ForeColor = System.Drawing.Color.Maroon;
            this.lb_data_doanhthuthang.Location = new System.Drawing.Point(11, 42);
            this.lb_data_doanhthuthang.Name = "lb_data_doanhthuthang";
            this.lb_data_doanhthuthang.Size = new System.Drawing.Size(88, 29);
            this.lb_data_doanhthuthang.TabIndex = 1;
            this.lb_data_doanhthuthang.Text = "100 Tr";
            // 
            // lb_doanhthuthang
            // 
            this.lb_doanhthuthang.AutoSize = true;
            this.lb_doanhthuthang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthuthang.Location = new System.Drawing.Point(5, 6);
            this.lb_doanhthuthang.Name = "lb_doanhthuthang";
            this.lb_doanhthuthang.Size = new System.Drawing.Size(222, 26);
            this.lb_doanhthuthang.TabIndex = 0;
            this.lb_doanhthuthang.Text = "Doanh thu trong tháng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.lb_data_khachhangthang);
            this.panel3.Controls.Add(this.lb_khachhangthang);
            this.panel3.Location = new System.Drawing.Point(243, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 80);
            this.panel3.TabIndex = 12;
            // 
            // lb_data_khachhangthang
            // 
            this.lb_data_khachhangthang.AutoSize = true;
            this.lb_data_khachhangthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_khachhangthang.ForeColor = System.Drawing.Color.Maroon;
            this.lb_data_khachhangthang.Location = new System.Drawing.Point(19, 42);
            this.lb_data_khachhangthang.Name = "lb_data_khachhangthang";
            this.lb_data_khachhangthang.Size = new System.Drawing.Size(69, 29);
            this.lb_data_khachhangthang.TabIndex = 1;
            this.lb_data_khachhangthang.Text = "1000";
            // 
            // lb_khachhangthang
            // 
            this.lb_khachhangthang.AutoSize = true;
            this.lb_khachhangthang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khachhangthang.Location = new System.Drawing.Point(3, 4);
            this.lb_khachhangthang.Name = "lb_khachhangthang";
            this.lb_khachhangthang.Size = new System.Drawing.Size(235, 26);
            this.lb_khachhangthang.TabIndex = 0;
            this.lb_khachhangthang.Text = "Khách hàng trong tháng";
            // 
            // lb_data_doanhthungay
            // 
            this.lb_data_doanhthungay.AutoSize = true;
            this.lb_data_doanhthungay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data_doanhthungay.ForeColor = System.Drawing.Color.Maroon;
            this.lb_data_doanhthungay.Location = new System.Drawing.Point(11, 42);
            this.lb_data_doanhthungay.Name = "lb_data_doanhthungay";
            this.lb_data_doanhthungay.Size = new System.Drawing.Size(66, 26);
            this.lb_data_doanhthungay.TabIndex = 1;
            this.lb_data_doanhthungay.Text = "10 Tr";
            // 
            // lb_doanhthungay
            // 
            this.lb_doanhthungay.AutoSize = true;
            this.lb_doanhthungay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthungay.Location = new System.Drawing.Point(5, 5);
            this.lb_doanhthungay.Name = "lb_doanhthungay";
            this.lb_doanhthungay.Size = new System.Drawing.Size(215, 26);
            this.lb_doanhthungay.TabIndex = 0;
            this.lb_doanhthungay.Text = "Doanh thu trong ngày";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel6.Controls.Add(this.chart_doanhthu);
            this.panel6.Controls.Add(this.lb_doanhthu);
            this.panel6.Location = new System.Drawing.Point(499, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 488);
            this.panel6.TabIndex = 15;
            // 
            // chart_doanhthu
            // 
            this.chart_doanhthu.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_doanhthu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_doanhthu.Legends.Add(legend2);
            this.chart_doanhthu.Location = new System.Drawing.Point(3, 42);
            this.chart_doanhthu.Name = "chart_doanhthu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_doanhthu.Series.Add(series2);
            this.chart_doanhthu.Size = new System.Drawing.Size(469, 446);
            this.chart_doanhthu.TabIndex = 1;
            this.chart_doanhthu.Text = "chart_doanhthu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lb_data_doanhthungay);
            this.panel2.Controls.Add(this.lb_doanhthungay);
            this.panel2.Location = new System.Drawing.Point(6, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 80);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thống kê";
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
            this.menuStrip1.Location = new System.Drawing.Point(42, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mn_thongke
            // 
            this.mn_thongke.BackColor = System.Drawing.Color.Transparent;
            this.mn_thongke.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_thongke.ForeColor = System.Drawing.Color.Maroon;
            this.mn_thongke.Name = "mn_thongke";
            this.mn_thongke.Size = new System.Drawing.Size(119, 30);
            this.mn_thongke.Text = "Thống Kê";
            // 
            // mn_phong
            // 
            this.mn_phong.BackColor = System.Drawing.Color.Transparent;
            this.mn_phong.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_phong.ForeColor = System.Drawing.Color.Maroon;
            this.mn_phong.Name = "mn_phong";
            this.mn_phong.Size = new System.Drawing.Size(86, 30);
            this.mn_phong.Text = "Phòng";
            // 
            // mn_hoadon
            // 
            this.mn_hoadon.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_hoadon.ForeColor = System.Drawing.Color.Maroon;
            this.mn_hoadon.Name = "mn_hoadon";
            this.mn_hoadon.Size = new System.Drawing.Size(110, 30);
            this.mn_hoadon.Text = "Hóa Đơn";
            // 
            // mn_khachhang
            // 
            this.mn_khachhang.BackColor = System.Drawing.Color.Transparent;
            this.mn_khachhang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_khachhang.ForeColor = System.Drawing.Color.Maroon;
            this.mn_khachhang.Name = "mn_khachhang";
            this.mn_khachhang.Size = new System.Drawing.Size(140, 30);
            this.mn_khachhang.Text = "Khách Hàng";
            // 
            // mn_nhanvien
            // 
            this.mn_nhanvien.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_nhanvien.ForeColor = System.Drawing.Color.Maroon;
            this.mn_nhanvien.Name = "mn_nhanvien";
            this.mn_nhanvien.Size = new System.Drawing.Size(125, 30);
            this.mn_nhanvien.Text = "Nhân Viên";
            // 
            // mn_taikhoan
            // 
            this.mn_taikhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn_taikhoan.ForeColor = System.Drawing.Color.Maroon;
            this.mn_taikhoan.Name = "mn_taikhoan";
            this.mn_taikhoan.Size = new System.Drawing.Size(124, 30);
            this.mn_taikhoan.Text = "Tài Khoản";
            // 
            // pb_women
            // 
            this.pb_women.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.woman;
            this.pb_women.Location = new System.Drawing.Point(802, 2);
            this.pb_women.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_women.Name = "pb_women";
            this.pb_women.Size = new System.Drawing.Size(35, 36);
            this.pb_women.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_women.TabIndex = 1;
            this.pb_women.TabStop = false;
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.DarkRed;
            this.btDangXuat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.ForeColor = System.Drawing.Color.White;
            this.btDangXuat.Location = new System.Drawing.Point(843, 2);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(140, 36);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.logo_hotel;
            this.pb_logo.Location = new System.Drawing.Point(-4, 0);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(51, 38);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pb_logo);
            this.panel1.Controls.Add(this.btDangXuat);
            this.panel1.Controls.Add(this.pb_women);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 38);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom777_QuanLyKhachSan.Properties.Resources.bgr_fmThongKe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 575);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_luongkhach)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhthu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_women)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_luongkhach;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Label lb_data_sovoihomqua;
        private System.Windows.Forms.Label lb_sovoihomqua;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_data_doanhthuthang;
        private System.Windows.Forms.Label lb_doanhthuthang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_data_khachhangthang;
        private System.Windows.Forms.Label lb_khachhangthang;
        private System.Windows.Forms.Label lb_data_doanhthungay;
        private System.Windows.Forms.Label lb_doanhthungay;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_luongkhach;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_doanhthu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mn_thongke;
        private System.Windows.Forms.ToolStripMenuItem mn_phong;
        private System.Windows.Forms.ToolStripMenuItem mn_hoadon;
        private System.Windows.Forms.ToolStripMenuItem mn_khachhang;
        private System.Windows.Forms.ToolStripMenuItem mn_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem mn_taikhoan;
        private System.Windows.Forms.PictureBox pb_women;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel1;
    }
}