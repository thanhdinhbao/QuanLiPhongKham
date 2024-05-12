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
    public partial class frmPhanQuyen : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        // lưu thông tin này để update lại 
        string ChucVu;
        string MatKhau;
        int Quyen;
        //
        public frmPhanQuyen()
        {
            InitializeComponent();
            ReloadGridViewTaiKhoan();
        }

        void ReloadGridViewTaiKhoan()
        {
           
            List<TaiKhoanDTO> lsttk = TaiKhoanBUS.GetThongTinTatCaTaiKhoan();
           // dtTaiKhoan = bus_TaiKhoan.GetThongTinTatCaTaiKhoan();
            if (lsttk != null)
            {
                grvDanhSachTK.Visible = true;
                //grcDanhSachTK.AutoGenerateColumns = true;
                grvDanhSachTK.DataSource = lsttk;


                grvDanhSachTK.Columns[0].HeaderText = "Tên tài khoản";
                grvDanhSachTK.Columns[1].HeaderText = "Tên hiển thị";
                grvDanhSachTK.Columns[2].HeaderText = "Chức vụ";
                grvDanhSachTK.Columns[3].HeaderText = "Quyền";
                grvDanhSachTK.Columns[4].HeaderText = "Mật khẩu";
                //dtTaiKhoan.Columns.Remove(dtTaiKhoan.Columns[4]);


                grvDanhSachTK.AutoResizeColumns();
                grvDanhSachTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quyen = 0;
            if (tbxTenTK.Text == "admin")
            {
                MessageBox.Show("Không thể phân quyền cho admin!");
                ReloadGridViewTaiKhoan();
                return;
            }
            if (tbxTenTK.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản phân quyền!!!");
                return;
            }

            if (checkBox1.Checked)
            {
                MessageBox.Show("Hệ thống chỉ cần 1 admin!");
                return;
            }


            if (checkBox2.Checked)
                Quyen = Quyen * 10 + 2;
            if (checkBox3.Checked)
                Quyen = Quyen * 10 + 3;
            if (checkBox4.Checked)
                Quyen = Quyen * 10 + 4;
            if (checkBox5.Checked)
                Quyen = Quyen * 10 + 5;
            if (checkBox6.Checked)
                Quyen = Quyen * 10 + 6;

            TaiKhoanDTO pTaiKhoan = new TaiKhoanDTO(tbxTenTK.Text, tbxTenHienThi.Text, ChucVu, Quyen, bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(tbxTenTK.Text));
            if (bus_TaiKhoan.Update(pTaiKhoan))
                MessageBox.Show("Phân quyền cho " + tbxTenTK.Text + " thành công!");
            else
                MessageBox.Show("Phân quyền cho " + tbxTenTK.Text + " thất bại!");
            ReloadGridViewTaiKhoan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grvDanhSachTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDanhSachTK.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells[0].Value.ToString() == "")
                    return;

                tbxTenTK.Text = row.Cells[0].Value.ToString();
                tbxTenHienThi.Text = row.Cells[1].Value.ToString();
                Quyen = Int32.Parse(row.Cells[3].Value.ToString());
                LoadQuyen(Quyen);
                ChucVu = row.Cells[2].Value.ToString();
                MatKhau= row.Cells[4].Value.ToString();
            }

            void LoadQuyen(int i)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                int indexCheck = 0;
                while (i > 0)
                {
                    indexCheck = i % 10;
                    switch (indexCheck)
                    {
                        case 1:
                            checkBox1.Checked = true;
                            break;
                        case 2:
                            checkBox2.Checked = true;
                            break;
                        case 3:
                            checkBox3.Checked = true;
                            break;
                        case 4:
                            checkBox4.Checked = true;
                            break;
                        case 5:
                            checkBox5.Checked = true;
                            break;
                        case 6:
                            checkBox6.Checked = true;
                            break;
                        default: break;
                    }
                    i /= 10;
                }
            }
        }
    }
}
