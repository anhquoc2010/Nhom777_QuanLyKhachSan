using Nhom777_QuanLyKhachSan.Controller;
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
using System.Xml.Linq;

namespace Nhom777_QuanLyKhachSan.View
{
    public partial class FormQLHoaDon : Form
    {
        TaoXML taoxml = new TaoXML();
        TaoXML hienthi = new TaoXML();
        DataTable dt;
        public string path = "./HoaDon.xml";
        public XDocument doc;
        public int current = 0;
        public int maxRow = 0;

        public FormQLHoaDon()
        {
            InitializeComponent();
            dt = new DataTable();
            FillDataTableColumn(dt);
        }

        private void FormQLHoaDon_Load(object sender, EventArgs e)
        {
            //taoxml.taoXML("HoaDon");
            initGrid();
        }

        public void initGrid()
        {
            dt.Rows.Clear();
            HoaDon lb = new HoaDon();
            dt = lb.LayDuLieu("HoaDon");
            //doc = lb.open(path);
            //string MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang;
            //var list = doc.Descendants("_x0027_HoaDon_x0027_");
            //foreach (XElement node in list)
            //{
            //    MaHD = node.Element("maHD").Value;
            //    MaPhong = node.Element("maPhong").Value;
            //    MaNV = node.Element("maNV").Value;
            //    NgayBatDau = node.Element("ngayBatDau").Value;
            //    NgayThanhToan = node.Element("ngayThanhToan").Value;
            //    GiaPhong = node.Element("giaPhong").Value;
            //    TinhTrang = node.Element("tinhTrang").Value;
            //    dt.Rows.Add(MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang);
            //}
            dgv_hoadon.DataSource = dt;
            foreach (DataGridViewColumn column in dgv_hoadon.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FillDataTableColumn(DataTable dt)
        {
            dt.Columns.Add("Mã Hóa Đơn", typeof(object));
            dt.Columns.Add("Mã Phòng", typeof(object));
            dt.Columns.Add("Mã Nhân Viên", typeof(object));
            dt.Columns.Add("Ngày Bắt Đầu", typeof(object));
            dt.Columns.Add("Ngày Thanh Toán", typeof(object));
            dt.Columns.Add("Giá Phòng", typeof(object));
            dt.Columns.Add("Tình Trạng", typeof(object));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                CheckPathExists = true,
                DefaultExt = ".xml",
                Filter = "XML|.*xml",
                Title = "Lưu File",
                ValidateNames = true,
                AddExtension = true,
            };
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                taoxml.TaoXML3("HoaDon", saveFile.FileName);
                MessageBox.Show("In Hóa Đơn Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string searchValue = tb_search.Text.Trim();
            if (searchValue.Length > 0)
            {
                DataTable searchTable = new DataTable();
                FillDataTableColumn(searchTable);
                //HoaDon lb = new HoaDon();
                //doc = lb.open(path);
                //string MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang;
                //var list = doc.Descendants("_x0027_HoaDon_x0027_");
                //foreach (XElement node in list)
                //{
                //    MaHD = node.Element("maHD").Value;
                //    MaPhong = node.Element("maPhong").Value;
                //    MaNV = node.Element("maNV").Value;
                //    NgayBatDau = node.Element("ngayBatDau").Value;
                //    NgayThanhToan = node.Element("ngayThanhToan").Value;
                //    GiaPhong = node.Element("giaPhong").Value;
                //    TinhTrang = node.Element("tinhTrang").Value;
                //    if (MaHD.Contains(searchValue)) searchTable.Rows.Add(MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang);
                //}
                string MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang;
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        MaHD = row[0] + "";
                        MaPhong = row[1] + "";
                        MaNV = row[2] + "";
                        NgayBatDau = row[3] + "";
                        NgayThanhToan = row[4] + "";
                        GiaPhong = row[5] + "";
                        TinhTrang = row[6] + "";
                        if (MaHD.Contains(searchValue)) searchTable.Rows.Add(MaHD, MaPhong, MaNV, NgayBatDau, NgayThanhToan, GiaPhong, TinhTrang);
                    }
                }
                dgv_hoadon.DataSource = searchTable;
                foreach (DataGridViewColumn column in dgv_hoadon.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgv_hoadon.DataSource = dt;
                foreach (DataGridViewColumn column in dgv_hoadon.Columns)
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void bt_tailai_Click(object sender, EventArgs e)
        {
            dgv_hoadon.DataSource = dt;
            foreach (DataGridViewColumn column in dgv_hoadon.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            tb_search.Text = "";
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

        private void FormQLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mn_thongke_Click(object sender, EventArgs e)
        {
            FormThongKe frm = new FormThongKe();
            frm.Show();
            this.Hide();
        }

        private void mn_phong_Click(object sender, EventArgs e)
        {
            FormQLPhong frm = new FormQLPhong();
            frm.Show();
            this.Hide();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }
    }
}
