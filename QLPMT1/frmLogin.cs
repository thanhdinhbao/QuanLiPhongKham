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
    public partial class frmLogin : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbxTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if (tbxTaiKhoan.Text.Length < 3)
            {
                MessageBox.Show("Tài khoản không hợp lệ");
                return;
            }
            if (tbxMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu");
                return;
            }

            if (bus_TaiKhoan.GetTenFromTenTaiKhoan(tbxTaiKhoan.Text) == "")
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                return;
            }
            else
            {
                string a = Hash256.Hash256Data(tbxTaiKhoan.Text + tbxMatKhau.Text);
                if (bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(tbxTaiKhoan.Text) != tbxMatKhau.Text)
                {
                    MessageBox.Show("Sai mật khẩu vui lòng nhập lại!");
                    tbxMatKhau.Clear();
                    return;
                }
            }

            frmMainfrom frmMainfrom = new frmMainfrom(tbxTaiKhoan.Text);
            //fMainForm.SetTaiKhoan(tbxTaiKhoan.Text);
            this.Hide();
            frmMainfrom.ShowDialog();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                tbxMatKhau.PasswordChar = '*';
            else
                tbxMatKhau.PasswordChar = new char();
        }
    }
}
