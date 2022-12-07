using Nhom777_QuanLyKhachSan.Controller;
using Nhom777_QuanLyKhachSan.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Nhom777_QuanLyKhachSan.View
{
    public partial class FormQLNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        TaoXML taoxml = new TaoXML();
        TaoXML hienthi = new TaoXML();
        string MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV;
        string path = "NhanVien.xml";
        public XDocument doc;
        public int current = 0;
        public int maxRow = 0;
        public string gr = "All";

        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void GetAllNhanVien(TaoXML taoxml, string path)
        {
            string sql = "select * from NhanVien for xml auto";
            taoxml.taoXML(sql, "NhanVien", path);
            DataTable dt = taoxml.loadDataGridView(path);
            string xml = "<?xml version='1.0'?> <?xml-stylesheet type='text/xsl' href='NhanVien.xsl'?> <QuanLyKhachSan>";
            xml += dt.Rows[0].ItemArray[0].ToString() + "</QuanLyKhachSan>";
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.LoadXml(xml);
            XmlDoc.Save(path);
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            GetAllNhanVien(taoxml, path);
            initGrid(gr);
            settext(0);
        }

        public void initGrid(string gr)
        {
            this.dgv_nhanvien.ColumnCount = 10;
            this.dgv_nhanvien.Columns[0].Name = "Mã nhân viên";
            this.dgv_nhanvien.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_nhanvien.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_nhanvien.Columns[0].Width = 120;

            this.dgv_nhanvien.Columns[1].Name = "Họ tên";
            this.dgv_nhanvien.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_nhanvien.Columns[1].Width = 120;

            this.dgv_nhanvien.Columns[2].Name = "Địa chỉ";
            this.dgv_nhanvien.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_nhanvien.Columns[2].Width = 180;

            this.dgv_nhanvien.Columns[3].Name = "Số điện thoại";
            this.dgv_nhanvien.Columns[3].Width = 100;
            this.dgv_nhanvien.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_nhanvien.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[4].Name = "Căn cước";
            this.dgv_nhanvien.Columns[4].Width = 100;
            this.dgv_nhanvien.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[5].Name = "Giới tính";
            this.dgv_nhanvien.Columns[5].Width = 80;
            this.dgv_nhanvien.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[6].Name = "Mật khẩu";
            this.dgv_nhanvien.Columns[6].Width = 80;
            this.dgv_nhanvien.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[7].Name = "Hoạt động";
            this.dgv_nhanvien.Columns[7].Width = 100;
            this.dgv_nhanvien.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[8].Name = "Mức lương";
            this.dgv_nhanvien.Columns[8].Width = 100;
            this.dgv_nhanvien.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgv_nhanvien.Columns[9].Name = "Mã chức vụ";
            this.dgv_nhanvien.Columns[9].Width = 100;
            this.dgv_nhanvien.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            NhanVien lb = new NhanVien();
            doc = lb.open(path);
            var list = doc.Descendants("NhanVien");
            string MaNV, name, address, sdt, cc, gt, mk, hd, ml, macv;
            this.dgv_nhanvien.Rows.Clear();
            foreach (XElement node in list)
            {
                MaNV = node.Attribute("maNV").Value.ToString();
                if (gr == MaNV || gr == "All")
                {
                    name = node.Attribute("hoTen").Value;
                    address = node.Attribute("diaChi").Value;
                    sdt = node.Attribute("SDT").Value;
                    cc = node.Attribute("canCuoc").Value;
                    gt = node.Attribute("gioiTinh").Value;
                    mk = node.Attribute("matKhau").Value;
                    hd = node.Attribute("hoatDong").Value;
                    ml = node.Attribute("mucLuong").Value;
                    macv = node.Attribute("maCV").Value;
                    this.dgv_nhanvien.Rows.Add(MaNV, name, address, sdt, cc, gt, mk, hd, ml, macv);
                }
            }
            maxRow = this.dgv_nhanvien.RowCount - 1;
            initCombo();
        }
        public void LoadData()
        {
            MaNV = tb_manv.Text;
            TenNV = tb_tennv.Text;
            DiaChi = tb_diachi.Text;
            SDT = tb_sdt.Text;
            CanCuoc = tb_cc.Text;
            GioiTinh = cbb_gioitinh.Text;
            MatKhau = tb_matkhau.Text;
            HoatDong = tb_hoatdong.Text;
            MucLuong = tb_mucluong.Text;
            MaCV = tb_macv.Text;
        }
        public void settext(int cur)
        {
            this.tb_manv.Text = this.dgv_nhanvien.Rows[cur].Cells[0].Value.ToString();
            this.tb_tennv.Text = this.dgv_nhanvien.Rows[cur].Cells[1].Value.ToString();
            this.tb_diachi.Text = this.dgv_nhanvien.Rows[cur].Cells[2].Value.ToString();
            this.tb_sdt.Text = this.dgv_nhanvien.Rows[cur].Cells[3].Value.ToString();
            this.tb_cc.Text = this.dgv_nhanvien.Rows[cur].Cells[4].Value.ToString();
            this.cbb_gioitinh.Text = this.dgv_nhanvien.Rows[cur].Cells[5].Value.ToString();
            this.tb_matkhau.Text = this.dgv_nhanvien.Rows[cur].Cells[6].Value.ToString();
            this.tb_hoatdong.Text = this.dgv_nhanvien.Rows[cur].Cells[7].Value.ToString();
            this.tb_mucluong.Text = this.dgv_nhanvien.Rows[cur].Cells[8].Value.ToString();
            this.tb_macv.Text = this.dgv_nhanvien.Rows[cur].Cells[9].Value.ToString();
        }

        void ViewXML(string path)
        {
            var fullpath = Path.GetFullPath(path);
            Process.Start("Explorer.exe", fullpath);
        }

        public void initCombo()
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("NhanVien");
            string tmp = "All";
            this.cbb_locnhanvien.Items.Clear();
            this.cbb_locnhanvien.Items.Add("All");
            string group;
            ArrayList myClass = new ArrayList();
            foreach (XElement node in list)
            {
                group = node.Attribute("maNV").Value.ToString();
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    myClass.Add(group);
                }
            }
            myClass.Sort();
            for (int i = 0; i < myClass.Count; i++)
            {
                this.cbb_locnhanvien.Items.Add(myClass[i]);
            }
        }

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgv_nhanvien.CurrentRow.Index;
            tb_manv.Text = dgv_nhanvien.Rows[d].Cells[0].Value.ToString();
            tb_tennv.Text = dgv_nhanvien.Rows[d].Cells[1].Value.ToString();
            tb_diachi.Text = dgv_nhanvien.Rows[d].Cells[2].Value.ToString();
            tb_sdt.Text = dgv_nhanvien.Rows[d].Cells[3].Value.ToString();
            tb_cc.Text = dgv_nhanvien.Rows[d].Cells[4].Value.ToString();
            cbb_gioitinh.Text = dgv_nhanvien.Rows[d].Cells[5].Value.ToString();
            tb_matkhau.Text = dgv_nhanvien.Rows[d].Cells[6].Value.ToString();
            tb_hoatdong.Text = dgv_nhanvien.Rows[d].Cells[7].Value.ToString();
            tb_mucluong.Text = dgv_nhanvien.Rows[d].Cells[8].Value.ToString();
            tb_macv.Text = dgv_nhanvien.Rows[d].Cells[9].Value.ToString();
            if (cbb_gioitinh.Text == "Nam")
            {
                cbb_gioitinh.Items.Clear();
                cbb_gioitinh.Items.Add("Nữ");
            }
            if (cbb_gioitinh.Text == "Nữ")
            {
                cbb_gioitinh.Items.Clear();
                cbb_gioitinh.Items.Add("Nam");
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewXML(path);
        }

        private void cbb_locnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr = this.cbb_locnhanvien.Text;
            initGrid(gr);
            settext(0);
        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            LoadData();
            if (nv.KiemTraNV(MaNV, SDT, CanCuoc) == true)
            {
                MessageBox.Show("Nhân viên đã tồn tại");
            }
            else
            {
                nv.themNV(MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV);
                MessageBox.Show("Thêm thành công");
                initGrid(gr);
                settext(0);
                tb_manv.Focus();
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            LoadData();
            nv.suaNV(MaNV, TenNV, DiaChi, SDT, CanCuoc, GioiTinh, MatKhau, HoatDong, MucLuong, MaCV, path);
            MessageBox.Show("Sửa thành công");
            initGrid(gr);
            settext(0);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            LoadData();
            nv.xoaNV(MaNV, path);
            MessageBox.Show("Xóa thành công");
            initGrid(gr);
            settext(0);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
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

        private void bt_search_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("NhanVien.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            DataView dv = new DataView(ds.Tables[0]);
            dv.Sort = "hoTen";
            reader.Close();
            int index = dv.Find(tb_search.Text);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy");
                tb_search.Text = "";
                tb_search.Focus();
            }
            else
            {
                this.dgv_nhanvien.Columns.Clear();
                this.dgv_nhanvien.Rows.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã nhân viên");
                dt.Columns.Add("Họ tên");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Căn cước");
                dt.Columns.Add("Giới tính");
                dt.Columns.Add("Mật khẩu");
                dt.Columns.Add("Hoạt động");
                dt.Columns.Add("Mức lương");
                dt.Columns.Add("Mã chức vụ");
                object[] list = { dv[index]["maNV"], dv[index]["hoTen"], dv[index]["diaChi"], dv[index]["SDT"], dv[index]["canCuoc"], dv[index]["gioiTinh"], dv[index]["matKhau"], dv[index]["hoatDong"], dv[index]["mucLuong"], dv[index]["maCV"] };
                dt.Rows.Add(list);
                dgv_nhanvien.DataSource = dt;
                settext(0);
                tb_search.Text = "";
            }
        }

        private void FormQLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
