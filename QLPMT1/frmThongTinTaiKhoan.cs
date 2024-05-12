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
    public partial class frmThongTinTaiKhoan : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        string TaiKhoan;    
        public frmThongTinTaiKhoan(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
            InitializeComponent();
            tbxTenTK.Text = TaiKhoan;
            tbxTenHienThi.Text = bus_TaiKhoan.GetTenFromTenTaiKhoan(TaiKhoan);
            tbxChucVu.Text = bus_TaiKhoan.GetChucVuFromTenTaiKhoan(TaiKhoan);
            LoadQuyen(Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)));
        }
        void LoadQuyen(int i)
        {
            ck1quantri.Checked = false;
            ck2benhnhan.Checked = false;
            ck3khambenh.Checked = false;
            ck4qlthuoc.Checked = false;
            ck5lhoadon.Checked = false;
            ck6qlngansach.Checked = false;
            int indexCheck = 0;
            while (i > 0)
            {
                indexCheck = i % 10;
                switch (indexCheck)
                {
                    case 1:
                        ck1quantri.Checked = true;
                        break;
                    case 2:
                        ck2benhnhan.Checked = true;
                        break;
                    case 3:
                        ck3khambenh.Checked = true;
                        break;
                    case 4:
                        ck4qlthuoc.Checked = true;
                        break;
                    case 5:
                        ck5lhoadon.Checked = true;
                        break;
                    case 6:
                        ck6qlngansach.Checked = true;
                        break;
                    default: break;
                }
                i /= 10;
            }
        }
        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(TaiKhoan) != Hash256.Hash256Data(tbxTenTK.Text + tbxMKCu.Text))
            {
                MessageBox.Show("Nhập mật khẩu cũ bị sai!");
                tbxMKCu.Clear();
                return;
            }
            if (tbxMKMoi.Text == tbxMKCu.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
                tbxMKMoi.Clear();
                return;
            }
            if (tbxMKMoi.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu mới phải 5 kí tự trở lên!");
                tbxMKMoi.Clear();
                return;
            }
            if (tbxMKMoi.Text != tbxNhapLaiMK.Text)
            {
                MessageBox.Show("Hai mật khẩu mới phải giống nhau!");
                // tbxMKCu.Clear();
                tbxNhapLaiMK.Clear();
                return;
            }

            TaiKhoanDTO pTaiKhoan = new TaiKhoanDTO(TaiKhoan, tbxTenHienThi.Text, tbxChucVu.Text, Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)), Hash256.Hash256Data(tbxTenTK.Text + tbxMKMoi.Text));
            if (bus_TaiKhoan.Update(pTaiKhoan))
                MessageBox.Show("Đổi mật khẩu thành công!");
            else
                MessageBox.Show("Đổi mật khẩu thất bại");
            tbxMKCu.Clear();
            tbxMKMoi.Clear();
            tbxNhapLaiMK.Clear();
            ck7mk.Checked = false;
        }
 

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!ck7mk.Checked)
                grbDoiMK.Enabled = false;
            else
                grbDoiMK.Enabled = true;
        }
    }

}
