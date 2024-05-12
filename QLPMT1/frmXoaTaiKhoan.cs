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
    public partial class frmXoaTaiKhoan : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        public frmXoaTaiKhoan()
        {
            InitializeComponent();
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxTenTK.Text == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản quản trị");
                btnXoa.Enabled = false;
                return;
            }
            if (tbxTenTK.Text.Length < 3)
            {
                MessageBox.Show("Tên tài khoản không hợp lệ");
                btnXoa.Enabled = false;
                return;
            }
            if (bus_TaiKhoan.GetTenFromTenTaiKhoan(tbxTenTK.Text) == "")
            {
                MessageBox.Show("Không tồn tại tài khoản trong CSDL");
                btnXoa.Enabled = false;
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa Tài khoản này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (bus_TaiKhoan.Delete(tbxTenTK.Text))
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbxTenTK.Text.Length < 3)
            {
                MessageBox.Show("Tên tài khoản không hợp lệ");
                btnXoa.Enabled = false;
                return;
            }
            if (bus_TaiKhoan.GetTenFromTenTaiKhoan(tbxTenTK.Text) == "")
            {
                MessageBox.Show("Không tồn tại tài khoản trong CSDL");
                btnXoa.Enabled = false;
                return;
            }
            else
            {
                tbxTenHienThi.Text = bus_TaiKhoan.GetTenFromTenTaiKhoan(tbxTenTK.Text);
                tbxChucVu.Text = bus_TaiKhoan.GetChucVuFromTenTaiKhoan(tbxTenTK.Text);
                btnXoa.Enabled = true;
            }
        }
    }
}
