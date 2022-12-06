namespace Nhom777_QuanLyKhachSan.View
{
    partial class FormDangNhap
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
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.pb_logohotel = new System.Windows.Forms.PictureBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logohotel)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lb_DangNhap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangNhap.ForeColor = System.Drawing.Color.Maroon;
            this.lb_DangNhap.Location = new System.Drawing.Point(314, 43);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(262, 45);
            this.lb_DangNhap.TabIndex = 0;
            this.lb_DangNhap.Text = "ĐĂNG NHẬP";
            this.lb_DangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BackColor = System.Drawing.Color.Transparent;
            this.lb_user.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.Maroon;
            this.lb_user.Location = new System.Drawing.Point(209, 134);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(154, 27);
            this.lb_user.TabIndex = 1;
            this.lb_user.Text = "Tên đăng nhập";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.BackColor = System.Drawing.Color.Transparent;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.Color.Maroon;
            this.lb_password.Location = new System.Drawing.Point(212, 198);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(104, 27);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Mật khẩu";
            this.lb_password.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pb_logohotel
            // 
            this.pb_logohotel.Image = global::Nhom777_QuanLyKhachSan.Properties.Resources.logo_hotel;
            this.pb_logohotel.Location = new System.Drawing.Point(49, 12);
            this.pb_logohotel.Name = "pb_logohotel";
            this.pb_logohotel.Size = new System.Drawing.Size(153, 149);
            this.pb_logohotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logohotel.TabIndex = 2;
            this.pb_logohotel.TabStop = false;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(410, 131);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(287, 34);
            this.tb_user.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(410, 192);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(287, 34);
            this.tb_password.TabIndex = 3;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.BackColor = System.Drawing.Color.Maroon;
            this.bt_dangnhap.Cursor = System.Windows.Forms.Cursors.No;
            this.bt_dangnhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dangnhap.ForeColor = System.Drawing.Color.White;
            this.bt_dangnhap.Location = new System.Drawing.Point(345, 298);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(185, 49);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = false;
            // 
            // bt_show
            // 
            this.bt_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_show.ForeColor = System.Drawing.Color.White;
            this.bt_show.Location = new System.Drawing.Point(707, 199);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(67, 27);
            this.bt_show.TabIndex = 5;
            this.bt_show.Text = "Show";
            this.bt_show.UseVisualStyleBackColor = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nhom777_QuanLyKhachSan.Properties.Resources.bgr_fmDangNhap;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.pb_logohotel);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_DangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logohotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.PictureBox pb_logohotel;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Button bt_show;
    }
}