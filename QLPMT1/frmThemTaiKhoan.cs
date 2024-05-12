using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLPMT1
{
    public partial class frmThemTaiKhoan : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThemTk_Click(object sender, EventArgs e)
        {
            if (tbxTenDangNhap.Text.Length < 3)
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");
                tbxTenDangNhap.Clear();
                return;
            }

            if (tbxMatKhau.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu quá ngắn");
                tbxMatKhau.Clear();
                return;
            }
            if (tbxMatKhau.Text != tbxNhapLaiMK.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu sai");
                tbxNhapLaiMK.Clear();
                return;
            }
            if (tbxTenHienThi.Text.Length < 5)
            {
                MessageBox.Show("Tên hiển thị không hợp lệ");
                tbxTenHienThi.Clear();
                return;
            }

            if (cbxChucVu.Text == " " || cbxChucVu.Text == "")
            {
                MessageBox.Show("Chưa chọn chức vụ");
                //cbxChucVu.SelectedText = " ";
                return;
            }
            string hashmk = Hash256.Hash256Data(tbxTenDangNhap.Text + tbxMatKhau.Text);
            TaiKhoanDTO pTaiKhoan = new TaiKhoanDTO(tbxTenDangNhap.Text, tbxTenHienThi.Text, cbxChucVu.Text, 0, tbxMatKhau.Text);
            if (bus_TaiKhoan.ThemTaiKhoan(pTaiKhoan))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                tbxTenDangNhap.Clear();
                tbxTenHienThi.Clear();
                tbxMatKhau.Clear();
                tbxNhapLaiMK.Clear();
                // cbxChucVu.SelectedText = " ";
                //cbxChucVu.Items.Clear();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại do trùng tên đăng nhập!");
                tbxTenDangNhap.Clear();
                tbxTenHienThi.Clear();
                tbxMatKhau.Clear();
                tbxNhapLaiMK.Clear();
                //cbxChucVu.SelectedText = " ";
                // cbxChucVu.Items.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
