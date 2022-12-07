using Nhom777_QuanLyKhachSan.Controller;
using Nhom777_QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom777_QuanLyKhachSan.View
{
    public partial class FormQLPhong : Form
    {
        string sql = "";
        string path = "Phong.xml";
        public XDocument doc;
        public int maxRow = 0;
        private TaoXML txml;
        private Phong phong;
        private LoaiPhong loaiPhong;
        public FormQLPhong()
        {
            InitializeComponent();
            txml = new TaoXML();
            phong = new Phong();
            loaiPhong = new LoaiPhong();
            bt_luu.Visible = false;
            phong.getAllPhong(txml, path);
            InitGrid(dgv_Phong);
            setCBBLoaiPhong();
        }

        private void InitGrid(DataGridView dgv)
        {
            // Định dạng DataGridView
            if (dgv.Name == "dgv_Phong")
            {
                dgv.ColumnCount = 6;
                dgv.Columns[0].Name = "STT";
                dgv.Columns[1].Name = "Mã Phòng";
                dgv.Columns[2].Name = "Tên Phòng";
                dgv.Columns[3].Name = "Mã Loại";
                dgv.Columns[4].Name = "Tình Trạng";
                dgv.Columns[5].Name = "Số Khách Tối Đa";
            }
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 150;
            dgv.Columns[5].Width = 155;
            resetRow();
        }

        private void resetRow()
        {
            Phong phong = new Phong();
            doc = phong.open(path);
            var list = doc.Descendants("Phong");
            string maPhong, tenPhong, maLoai, tinhTrang = "";
            int soKhachToiDa = 1;
            dgv_Phong.Rows.Clear();
            int stt = 1;
            foreach (XElement node in list)
            {
                maPhong = node.Attribute("maPhong").Value;
                tenPhong = node.Attribute("tenPhong").Value;
                maLoai = node.Attribute("maLoai").Value;
                tinhTrang = node.Attribute("tinhTrang").Value;
                soKhachToiDa = int.Parse(node.Attribute("soKhachToiDa").Value);
                dgv_Phong.Rows.Add(stt, maPhong, tenPhong, maLoai, tinhTrang, soKhachToiDa);
                stt++;
            }
            maxRow = dgv_Phong.RowCount - 1; // trừ dòng tiêu đề
        }
        private void locLoaiPhong(string maLoai)
        {
            Phong phong = new Phong();
            doc = phong.open(path);
            var list = doc.Descendants("Phong").Where(x => x.Attribute("maLoai").Value.Equals(maLoai));
            string maPhong, tenPhong, tinhTrang = "";
            int soKhachToiDa = 1;
            dgv_Phong.Rows.Clear();
            int stt = 1;
            foreach (XElement node in list)
            {
                maPhong = node.Attribute("maPhong").Value;
                tenPhong = node.Attribute("tenPhong").Value;
                maLoai = node.Attribute("maLoai").Value;
                tinhTrang = node.Attribute("tinhTrang").Value;
                soKhachToiDa = int.Parse(node.Attribute("soKhachToiDa").Value);
                dgv_Phong.Rows.Add(stt, maPhong, tenPhong, maLoai, tinhTrang, soKhachToiDa);
                stt++;
            }
            maxRow = dgv_Phong.RowCount - 1; // trừ dòng tiêu đề
        }
        private void timKiem(string tukhoa)
        {
            Phong phong = new Phong();
            doc = phong.open(path);
            var list = doc.Descendants("Phong").Where(x => x.Attribute("tenPhong").Value.Contains(tukhoa));
            string maPhong, maLoai, tenPhong, tinhTrang = "";
            int soKhachToiDa = 1;
            dgv_Phong.Rows.Clear();
            int stt = 1;
            foreach (XElement node in list)
            {
                maPhong = node.Attribute("maPhong").Value;
                tenPhong = node.Attribute("tenPhong").Value;
                maLoai = node.Attribute("maLoai").Value;
                tinhTrang = node.Attribute("tinhTrang").Value;
                soKhachToiDa = int.Parse(node.Attribute("soKhachToiDa").Value);
                dgv_Phong.Rows.Add(stt, maPhong, tenPhong, maLoai, tinhTrang, soKhachToiDa);
                stt++;
            }
            maxRow = dgv_Phong.RowCount - 1; // trừ dòng tiêu đề
        }
        private void setCBBLoaiPhong()
        {
            TaoXML txml2 = new TaoXML();
            loaiPhong.getAllLoaiPhong(txml2, "LoaiPhong.xml");
            DataTable dt = txml.loadDataGridView("LoaiPhong.xml");
            doc = loaiPhong.open("LoaiPhong.xml");
            var list = doc.Descendants("LoaiPhong");
            cbb_loaiphong.Items.Add("Tất cả");
            foreach (XElement node in list)
            {
                cbb_loaip.Items.Add(node.Attribute("maLoai").Value + " - " + node.Attribute("tenLoai").Value);
                cbb_loaiphong.Items.Add(node.Attribute("maLoai").Value + " - " + node.Attribute("tenLoai").Value);
            }
            cbb_loaiphong.SelectedIndex = 0;
        }
        private Phong getPhong()
        {
            Phong phong = new Phong(tb_maphong.Text, tb_tenphong.Text, this.cbb_loaip.SelectedItem.ToString().Substring(0, 7),
                int.Parse(tb_toida.Text), cbb_tinhtrangp.SelectedItem.ToString());
            return phong;
        }
        private void emptyTextBox()
        {
            this.tb_maphong.Text = "";
            this.tb_tenphong.Text = "";
            this.cbb_loaip.ResetText();
            this.cbb_loaip.SelectedIndex = -1;
            this.tb_toida.Text = "";
            this.cbb_tinhtrangp.ResetText();
            this.cbb_tinhtrangp.SelectedIndex = -1;
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
            this.Hide();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            doc = phong.open(path);
            txml = new TaoXML();
            emptyTextBox();
            this.tb_maphong.Text = txml.maMoi("PH", doc, "Phong", "maPhong");
            this.bt_luu.Visible = true;
            this.bt_luu.Text = "Thêm";
            this.bt_luu.BackColor = Color.Green;
            this.tb_tenphong.Focus();
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (bt_luu.Text == "Thêm")
            {
                if (tb_tenphong.Text != "" && tb_toida.Text != "" && cbb_loaip.SelectedIndex != -1 && cbb_tinhtrangp.SelectedIndex != -1)
                {
                    this.bt_luu.Visible = false;
                    Phong ph = getPhong();
                    txml.Them(path, ph.insertXML());
                    //initGrid(gr);
                    txml.themDatabase(ph.insertDatabase());
                    emptyTextBox();
                    //phong.getAllPhong(txml, path);
                    resetRow();
                }
                else
                {
                    MessageBox.Show("Không để trống mọi fiels");
                    this.tb_tenphong.Focus();
                }
            }
            else
                if (bt_luu.Text == "Lưu")
            {
                if (tb_tenphong.Text != "" && tb_toida.Text != "" && cbb_loaip.SelectedIndex != -1 && cbb_tinhtrangp.SelectedIndex != -1)
                {
                    this.bt_luu.Visible = false;
                    Phong ph = getPhong();
                    ph.updateXML(path);
                    txml.suaDatabase(ph.updateDatabase());
                    emptyTextBox();
                    //phong.getAllPhong(txml, path);
                    resetRow();
                }
                else
                {
                    MessageBox.Show("Không để trống mọi fiels");
                    this.tb_tenphong.Focus();
                }
            }
        }

        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgv_Phong.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                tb_maphong.Text = row.Cells[1].Value.ToString();
                tb_tenphong.Text = row.Cells[2].Value.ToString();
                cbb_loaip.SelectedIndex = int.Parse(row.Cells[3].Value.ToString().Substring(2, 5)) - 1;
                tb_toida.Text = row.Cells[5].Value.ToString();
                cbb_tinhtrangp.SelectedItem = row.Cells[4].Value.ToString();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            this.bt_luu.Visible = true;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.BackColor = Color.Yellow;
            this.tb_tenphong.Focus();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa phòng " + tb_tenphong.Text + "?",
            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Phong ph = getPhong();
                if (ph.deleteXML(tb_maphong.Text, path))
                    MessageBox.Show("Xóa thành công!");
                txml.xoaDatabase(ph.deleteDatabase());
                emptyTextBox();
                //phong.getAllPhong(txml, path);
                resetRow();
            }
        }

        private void cbb_loaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loaiphong.SelectedItem.ToString().Equals("Tất cả"))
            {
                resetRow();
            }
            else
            {
                string maLoai = cbb_loaiphong.SelectedItem.ToString().Substring(0, 7);
                locLoaiPhong(maLoai);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            timKiem(tb_search.Text);
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timKiem(tb_search.Text);
            }
        }

        private void bt_hienthi_Click(object sender, EventArgs e)
        {
            txml = new TaoXML();
            doc = phong.open(path);
            var list = doc.Descendants("Phong");
            string data = "";
            foreach (XElement node in list)
            {
                data += "<Phong> ";
                data += "<maPhong>" + node.Attribute("maPhong").Value + "</maPhong> ";
                data += "<tenPhong>" + node.Attribute("tenPhong").Value + "</tenPhong> ";
                data += "<maLoai>" + node.Attribute("maLoai").Value + "</maLoai> ";
                data += "<tinhTrang>" + node.Attribute("tinhTrang").Value + "</tinhTrang> ";
                data += "<soKhachToiDa>" + node.Attribute("soKhachToiDa").Value + "</soKhachToiDa> ";
                data += "</Phong> ";
            }
            txml.TimKiemXSLT(data, "Phong", "Phong");
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

        private void FormQLPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mn_thongke_Click(object sender, EventArgs e)
        {
            FormThongKe frm = new FormThongKe();
            frm.Show();
            this.Hide();
        }
    }
}
