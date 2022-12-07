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
    public partial class FormQLKhachHang : Form
    {
        KhachHang kh = new KhachHang();
        TaoXML taoxml = new TaoXML();
        string MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh;
        public string path = "KhachHang.xml";
        public XDocument doc;
        public int current = 0;
        public int maxRow = 0;
        public string gr = "All";

        private void GetAllKhachHang(TaoXML taoxml, string path)
        {
            string sql = "select * from KhachHang for xml auto";
            taoxml.taoXML(sql, "KhachHang", path);
            DataTable dt = taoxml.loadDataGridView(path);
            string xml = "<?xml version='1.0'?> <?xml-stylesheet type='text/xsl' href='KhachHang.xsl'?> <QuanLyKhachSan>";
            xml += dt.Rows[0].ItemArray[0].ToString() + "</QuanLyKhachSan>";
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.LoadXml(xml);
            XmlDoc.Save(path);
        }

        public void initGrid(string gr)
        {
            this.dgv_khachhang.ColumnCount = 6;

            this.dgv_khachhang.Columns[0].Name = "Mã khách hàng";
            this.dgv_khachhang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[0].Width = 120;

            this.dgv_khachhang.Columns[1].Name = "Họ tên";
            this.dgv_khachhang.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[1].Width = 120;

            this.dgv_khachhang.Columns[2].Name = "Địa chỉ";
            this.dgv_khachhang.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[2].Width = 180;

            this.dgv_khachhang.Columns[3].Name = "Số điện thoại";
            this.dgv_khachhang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[3].Width = 100;

            this.dgv_khachhang.Columns[4].Name = "Căn cước";
            this.dgv_khachhang.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[4].Width = 100;

            this.dgv_khachhang.Columns[5].Name = "Giới tính";
            this.dgv_khachhang.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_khachhang.Columns[5].Width = 80;

            KhachHang lb = new KhachHang();
            doc = lb.open(path);
            var list = doc.Descendants("KhachHang");
            string MaKH, name, address, sdt, cc, gt;
            this.dgv_khachhang.Rows.Clear();
            foreach (XElement node in list)
            {
                MaKH = node.Attribute("maKH").Value.ToString();
                if (gr == MaKH || gr == "All")
                {
                    name = node.Attribute("hoTen").Value;
                    address = node.Attribute("diaChi").Value;
                    sdt = node.Attribute("SDT").Value;
                    cc = node.Attribute("canCuoc").Value;
                    gt = node.Attribute("gioiTinh").Value;
                    this.dgv_khachhang.Rows.Add(MaKH, name, address, sdt, cc, gt);
                }
            }
            maxRow = this.dgv_khachhang.RowCount - 1;
            initCombo();
        }
        public void initCombo()
        {
            doc = XDocument.Load(path);
            var list = doc.Descendants("KhachHang");
            string tmp = "All";
            this.cbb_lockhachhang.Items.Clear();
            this.cbb_lockhachhang.Items.Add("All");
            string group;
            ArrayList myClass = new ArrayList();
            foreach (XElement node in list)
            {
                group = node.Attribute("maKH").Value.ToString();
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    myClass.Add(group);
                }
            }
            myClass.Sort();
            for (int i = 0; i < myClass.Count; i++)
            {
                this.cbb_lockhachhang.Items.Add(myClass[i]);
            }
        }

        public void settext(int cur)
        {
            this.tb_makh.Text = this.dgv_khachhang.Rows[cur].Cells[0].Value.ToString();
            this.tb_tenkh.Text = this.dgv_khachhang.Rows[cur].Cells[1].Value.ToString();
            this.tb_diachi.Text = this.dgv_khachhang.Rows[cur].Cells[2].Value.ToString();
            this.tb_sdt.Text = this.dgv_khachhang.Rows[cur].Cells[3].Value.ToString();
            this.tb_cc.Text = this.dgv_khachhang.Rows[cur].Cells[4].Value.ToString();
            this.cbb_gioitinh.Text = this.dgv_khachhang.Rows[cur].Cells[5].Value.ToString();
        }

        void ViewXML(string path)
        {
            var fullpath = Path.GetFullPath(path);
            Process.Start("Explorer.exe", fullpath);
        }

        public void LoadData()
        {
            MaKH = tb_makh.Text;
            TenKH = tb_tenkh.Text;
            DiaChi = tb_diachi.Text;
            SDT = tb_sdt.Text;
            CanCuoc = tb_cc.Text;
            GioiTinh = cbb_gioitinh.Text;
        }

        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        private void mn_hoadon_Click(object sender, EventArgs e)
        {
            FormQLHoaDon frm = new FormQLHoaDon();
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

        private void FormQLKhachHang_Load(object sender, EventArgs e)
        {
            GetAllKhachHang(taoxml, path);
            initGrid(gr);
            settext(0);
        }

        private void dgv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = dgv_khachhang.CurrentRow.Index;
            tb_makh.Text = dgv_khachhang.Rows[d].Cells[0].Value.ToString();
            tb_tenkh.Text = dgv_khachhang.Rows[d].Cells[1].Value.ToString();
            tb_diachi.Text = dgv_khachhang.Rows[d].Cells[2].Value.ToString();
            tb_sdt.Text = dgv_khachhang.Rows[d].Cells[3].Value.ToString();
            tb_cc.Text = dgv_khachhang.Rows[d].Cells[4].Value.ToString();
            cbb_gioitinh.Text = dgv_khachhang.Rows[d].Cells[5].Value.ToString();
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

        private void cbb_lockhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            gr = this.cbb_lockhachhang.Text;
            initGrid(gr);
            settext(0);
        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            LoadData();
            if (kh.KiemTraKH(MaKH, SDT, CanCuoc) == true)
            {
                MessageBox.Show("Khách hàng đã tồn tại");
            }
            else
            {
                kh.themKH(MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh);
                MessageBox.Show("Thêm thành công");
                initGrid(gr);
                settext(0);
                initCombo();
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            LoadData();
            kh.SuaKH(MaKH, TenKH, DiaChi, SDT, CanCuoc, GioiTinh, path);
            MessageBox.Show("Sửa thành công");
            initGrid(gr); settext(0);
            initCombo();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            LoadData();
            kh.XoaKH(MaKH, path);
            MessageBox.Show("Xóa thành công");
            initCombo();
            initGrid(gr); settext(0);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FormQLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader("KhachHang.xml");
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
                this.dgv_khachhang.Columns.Clear();
                this.dgv_khachhang.Rows.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã KH");
                dt.Columns.Add("Họ tên");
                dt.Columns.Add("Địa chỉ");
                dt.Columns.Add("Số điện thoại");
                dt.Columns.Add("Căn cước");
                dt.Columns.Add("Giới tính");
                object[] list = { dv[index]["maKH"], dv[index]["hoTen"], dv[index]["diaChi"], dv[index]["SDT"], dv[index]["canCuoc"], dv[index]["gioiTinh"] };
                dt.Rows.Add(list);
                dgv_khachhang.DataSource = dt;
                tb_search.Text = "";
            }
        }
    }
}
