using Nhom777_QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom777_QuanLyKhachSan.View
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            setSoLieu();
            fillChartLuongKhach();
            fillChartDoanhThu();
        }

        private void fillChartLuongKhach()
        {
            ThongKe tk = new ThongKe();
            tk.getDataLK7Day(chart_luongkhach);
        }
        private void fillChartDoanhThu()
        {
            ThongKe tk = new ThongKe();
            tk.getDataDT7Day(chart_doanhthu);
        }
        private void setSoLieu()
        {
            ThongKe tk = new ThongKe();
            double hnay = tk.getDoanhThuHomNay();
            double hqua = tk.getDoanhThuHomQua();
            lb_data_doanhthungay.Text = hnay.ToString() + " VNĐ";
            if (hqua == 0)
                lb_data_sovoihomqua.Text = "0%";
            else
            {
                float tile = (float)(hnay * 100.0 / hqua);
                lb_data_sovoihomqua.Text = tile.ToString() + " %";
            }
            lb_data_doanhthuthang.Text = tk.getDoanhThuThang().ToString() + " VNĐ";
            lb_khachhangthang.Text = tk.getKhachHangThang().ToString();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void mn_phong_Click(object sender, EventArgs e)
        {
            FormQLPhong frm = new FormQLPhong();
            frm.Show();
            this.Hide();
        }

        private void mn_hoadon_Click(object sender, EventArgs e)
        {
            FormQLHoaDon frm = new FormQLHoaDon();
            frm.Show();
            this.Hide();
        }

        private void mn_khachhang_Click(object sender, EventArgs e)
        {
            FormQLKhachHang frm = new FormQLKhachHang();
            frm.Show();
            this.Hide();
        }

        private void mn_nhanvien_Click(object sender, EventArgs e)
        {
            FormQLNhanVien frm = new FormQLNhanVien();
            frm.Show();
            this.Hide();
        }

        private void mn_taikhoan_Click(object sender, EventArgs e)
        {
            FormQLTaiKhoan frm = new FormQLTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void FormThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
