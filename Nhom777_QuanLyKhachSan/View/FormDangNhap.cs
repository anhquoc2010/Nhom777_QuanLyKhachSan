using Nhom777_QuanLyKhachSan.Controller;
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
    public partial class FormDangNhap : Form
    {
        TaoXML xml = new TaoXML();

        public FormDangNhap()
        {
            InitializeComponent();
            tb_password.UseSystemPasswordChar = true;
        }

        //function checkedDangNhap
        public Boolean kiemTraDN(string taiKhoan, string matKhau)
        {
            TaoXML txml = new TaoXML();
            string sql = "SELECT maNV"
                        + " FROM NhanVien, ChucVu"
                        + " WHERE NhanVien.maCV = ChucVu.maCV AND ChucVu.maCV = 'CV00001'"
                        + " AND maNV = '" + taiKhoan + "' AND matKhau = '" + matKhau + "'";
            return txml.kiemTraDN(sql);
        }
        private void dangnhap()
        {
            string taikhoan = tb_user.Text.Trim();
            string matkhau = tb_password.Text.Trim();
            if (taikhoan.Equals("") || matkhau.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu!");
            }
            else
            {
                if (kiemTraDN(taikhoan, matkhau))
                {
                    FormThongKe tk = new FormThongKe();
                    tk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
                }
            }
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            if (tb_password.UseSystemPasswordChar == true)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            tb_user.TabIndex = 0;
            tb_password.TabIndex = 1;
            bt_dangnhap.TabIndex = 2;
            bt_show.TabIndex = 3;

            tb_user.Text = "NV00000";
            tb_password.Text = "admin";
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
