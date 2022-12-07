using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom777_QuanLyKhachSan.View
{
    public partial class FormQLTaiKhoan : Form
    {
        public class TaiKhoan
        {
            public TaiKhoan() { }
            public TaiKhoan(string username, string password, string role)
            {
                Username = username;
                Password = password;
                Role = role;
            }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        DataTable dt;
        BindingSource bs;
        public static string path = "./TaiKhoan.xml";
        public readonly string tableName = "TaiKhoan";
        private List<TaiKhoan> list = new List<TaiKhoan>();
        public XDocument doc;
        bool isBiding = false;

        public void AddBinding()
        {
            if (!isBiding)
            {
                lb_trangthai.Text = "Trạng Thái: Xóa, Sửa Tài Khoản";
                tb_taikhoan.Enabled = false;
                bt_taomoi.Enabled = false;
                bt_capnhat.Enabled = true;
                bt_xoa.Enabled = true;
                tb_taikhoan.DataBindings.Add("Text", bs.DataSource, "TenTaiKhoan", true, DataSourceUpdateMode.OnPropertyChanged);
                tb_matkhau.DataBindings.Add("Text", bs.DataSource, "MatKhau", true, DataSourceUpdateMode.OnPropertyChanged);
                cbb_quyen.DataBindings.Add("Text", bs.DataSource, "QuyenHan", true, DataSourceUpdateMode.OnPropertyChanged);
                isBiding = true;
            }
        }

        public void ClearBinding()
        {
            if (isBiding)
            {
                lb_trangthai.Text = "Trạng Thái: Thêm Tài Khoản";
                tb_taikhoan.Enabled = true;
                bt_taomoi.Enabled = true;
                bt_capnhat.Enabled = false;
                bt_xoa.Enabled = false;
                tb_taikhoan.DataBindings.Clear();
                cbb_quyen.DataBindings.Clear();
                tb_matkhau.DataBindings.Clear();
                isBiding = false;
                ResetData();
            }
        }
        public void ResetData()
        {
            cbb_quyen.SelectedIndex = 2;
            tb_taikhoan.Text = "";
            tb_matkhau.Text = "";
        }

        public void LoadGrid()
        {
            dt.Rows.Clear();
            if (list.Count > 0)
            {
                foreach (var tk in list)
                {
                    dt.Rows.Add(tk.Username, tk.Password, tk.Role);
                }
            }
            else
            {
                dt.Rows.Add("", "", "");
            }
            bs.DataSource = dt;
            dgv_taikhoan.DataSource = bs.DataSource;
            foreach (DataGridViewColumn column in dgv_taikhoan.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public FormQLTaiKhoan()
        {
            InitializeComponent();

            dt = new DataTable(tableName);
            bs = new BindingSource();
            dt.Columns.Add("TenTaiKhoan", typeof(object));
            dt.Columns.Add("MatKhau", typeof(object));
            dt.Columns.Add("QuyenHan", typeof(object));
            lb_trangthai.Text = "Trạng Thái: Thêm Tài Khoản";
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
        public bool CheckInput()
        {
            if (tb_taikhoan.Text.Length <= 0)
            {
                MessageBox.Show("Nhập vào ô tài khoản!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tb_matkhau.Text.Length <= 0)
            {
                MessageBox.Show("Nhập vào ô Mật Khẩu!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void TaoXmlFile(string bang)
        {
            dt.WriteXml(Application.StartupPath + "\\" + bang + ".xml", XmlWriteMode.WriteSchema);
        }

        private void FormQLTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path)) TaoXmlFile(tableName);
            doc = XDocument.Load(path);
            var list = doc.Descendants("TaiKhoan");
            if (list.Count() > 0)
            {
                foreach (XElement node in list)
                {
                    TaiKhoan tk = new TaiKhoan()
                    {
                        Username = node.Element("TenTaiKhoan").Value,
                        Password = node.Element("MatKhau").Value,
                        Role = node.Element("QuyenHan").Value,
                    };
                    this.list.Add(tk);
                }
            }
            LoadGrid();
            cbb_quyen.SelectedIndex = 2;
            bt_capnhat.Enabled = false;
            bt_xoa.Enabled = false;
        }
        
        private void bt_ketnoidulieu_CheckedChanged(object sender, EventArgs e)
        {
            if (bt_ketnoidulieu.Checked)
            {
                AddBinding();
            }
            else ClearBinding();
        }

        private void bt_taomoi_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            var username = tb_taikhoan.Text.Trim();
            var password = tb_matkhau.Text.Trim();
            var role = cbb_quyen.Text;
            if (TimTaiKhoan(username) != null || username.ToLower().Equals("admin"))
            {
                MessageBox.Show("Tên Tài Khoản Đã Tồn Tại!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            list.Add(new TaiKhoan(username, password, role));
            LoadGrid();
            TaoXmlFile(tableName);
            ResetData();
        }

        private TaiKhoan TimTaiKhoan(string username)
        {
            if (list.Count > 0)
            {
                foreach (var tk in list)
                {
                    if (tk.Username.ToLower().Equals(username.ToLower())) return tk;
                }
            }
            return null;
        }

        private bool SuaTaiKhoan(TaiKhoan tk)
        {
            TaiKhoan tkInList = TimTaiKhoan(tk.Username);
            if (tkInList != null)
            {
                int index = list.IndexOf(tkInList);
                list.RemoveAt(index);
                list.Insert(index, tk);
                return true;
            }
            else return false;
        }

        private bool XoaTaiKhoan(string username)
        {
            TaiKhoan tkInList = TimTaiKhoan(username);
            if (tkInList != null)
            {
                list.Remove(tkInList);
                return true;
            }
            else return false;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan()
            {
                Username = tb_taikhoan.Text,
                Password = tb_matkhau.Text,
                Role = cbb_quyen.Text,
            };
            if (SuaTaiKhoan(tk))
            {
                MessageBox.Show("Sửa Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                TaoXmlFile(tableName);
            }
            else MessageBox.Show("Không Tìm Thấy Tài Khoản!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (XoaTaiKhoan(tb_taikhoan.Text))
            {
                MessageBox.Show("Xóa Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                if (list.Count <= 0) dt.Rows.Clear();
                TaoXmlFile(tableName);
                LoadGrid();
            }
            else MessageBox.Show("Không Tìm Thấy Tài Khoản!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
