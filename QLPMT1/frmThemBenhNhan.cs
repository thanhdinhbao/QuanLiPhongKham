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
using DAO;
using DTO;

namespace QLPMT1
{
    public partial class frmThemBenhNhan : Form
    {
        BenhNhanBUS bus_benhNhan = new BenhNhanBUS();

        DataTable dtBenhNhan;
        public frmThemBenhNhan()
        {
            InitializeComponent();

            DisableControl();

            //Load du lieu benh nhan
            ReloadGridViewBenhNhan();
        }


        //Load danh sách bệnh nhân vào gridview
        void ReloadGridViewBenhNhan()
        {
            List<BenhNhanDTO> lstBenhNhan = BenhNhanBUS.LayDSTatCaBenhNhan();

            grvDanhSachBN.DataSource = lstBenhNhan;

            grvDanhSachBN.Columns[0].HeaderText = "Mã bệnh nhân";
            grvDanhSachBN.Columns[1].HeaderText = "Họ tên";
            grvDanhSachBN.Columns[2].HeaderText = "Giới tính";
            grvDanhSachBN.Columns[3].HeaderText = "Năm sinh";
            grvDanhSachBN.Columns[4].HeaderText = "Địa chỉ";
            grvDanhSachBN.Columns[5].HeaderText = "SĐT";
            grvDanhSachBN.Columns[6].HeaderText = "CMND";

                grvDanhSachBN.AutoResizeColumns();
                grvDanhSachBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }


        void EnableControl()
        {
            tbxHoTen.ReadOnly = false;
            tbxSDT.ReadOnly = false;
            tbxDiaChi.ReadOnly = false;
            tbxCMND.ReadOnly = false;

            rbtnNam.Enabled = true;
            rbtnNu.Enabled = true;
            dtpNamSinh.Enabled = true;
        }

        void DisableControl()
        {
            tbxHoTen.ReadOnly = true;
            tbxSDT.ReadOnly = true;
            tbxDiaChi.ReadOnly = true;
            tbxCMND.ReadOnly = true;

            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;
            dtpNamSinh.Enabled = false;
        }

      

        private void grvDanhSachBN_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDanhSachBN.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells[0].Value.ToString() == "")
                    return;

                tbxMaBenhNhan.Text = row.Cells[0].Value.ToString();
                tbxHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                    rbtnNu.Checked = false;
                }
                else
                {
                    rbtnNam.Checked = false;
                    rbtnNu.Checked = true;
                }
                dtpNamSinh.Value = new DateTime(Int32.Parse(row.Cells[3].Value.ToString()), 1, 1);
                tbxSDT.Text = row.Cells[5].Value.ToString();
                tbxDiaChi.Text = row.Cells[4].Value.ToString();
                tbxCMND.Text = row.Cells[6].Value.ToString();
            }
        }


        //**********************************THÊM BỆNH NHÂN**********************************
       bool isThem = false;
        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            if (!isThem)//neu chua them thi gio them
            {
                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxCMND.Text = "";
                tbxSDT.Text = "";
                EnableControl();

                tbxMaBenhNhan.Text = BenhNhanBUS.LayMaBenhNhanNext();
                if (tbxMaBenhNhan.Text == "")
                {
                    MessageBox.Show("Không lấy được mã bệnh nhân!");
                    return;
                }


                btnThemBenhNhan.Text = "Hoàn tất";
                btnSuaBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
                btnTimKiem.Enabled = false;

            }
            else //Neu nhap xong thi them vo
            {
                if (tbxMaBenhNhan.Text == "")
                {
                    MessageBox.Show("Mã bệnh nhân không hợp lệ!");
                    return;
                }
                else if (tbxHoTen.Text.Length < 3)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    return;
                }
                else if (tbxCMND.Text.Length < 5)
                {
                    MessageBox.Show("CMND không hợp lệ!");
                    return;
                }
                if (!CheckThongTinPhuHop())
                {
                    return;
                }
                //THÊM
                string gioiTinh = "Nam";
                if (rbtnNu.Checked)
                {
                    gioiTinh = "Nữ";
                }

                BenhNhanDTO benhNhan = new BenhNhanDTO(tbxMaBenhNhan.Text.ToString(), tbxHoTen.Text.ToString(), gioiTinh,
                                         dtpNamSinh.Value.Year, tbxDiaChi.Text.ToString(), tbxSDT.Text.ToString(), tbxCMND.Text.ToString());



                if (bus_benhNhan.ThemBenhNhan(benhNhan))
                {
                    ReloadGridViewBenhNhan();
                    MessageBox.Show("Thêm bệnh nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại!");
                }

                //Done
                DisableControl();
                btnThemBenhNhan.Text = "Thêm +";
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                btnTimKiem.Enabled = true;
            }
            isThem = !isThem;


        }

        private void tbxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbxNamSinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNamSinh.Checked)
            {
                dtpNamSinh.Enabled = true;
            }
            else
                dtpNamSinh.Enabled = false;
        }


        bool isTimKiem = false;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!isTimKiem)//Mo che do tim kiem
            {

                tbxMaBenhNhan.ReadOnly = false;

                btnThemBenhNhan.Enabled = false;
                btnSuaBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
                EnableControl();
                btnTimKiem.Text = "Tìm ngay";

                cbxNamSinh.Enabled = true;
                dtpNamSinh.Enabled = false;

                tbxMaBenhNhan.Text = "";
                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxSDT.Text = "";
                tbxCMND.Text = "";
                rbtnNam.Checked = false;
                rbtnNu.Checked = false;
            }
            else //Ket thuc tim kiem
            {
                string gioiTinh = "";
                if (rbtnNu.Checked)
                    gioiTinh = "Nữ";
                if (rbtnNam.Checked)
                    gioiTinh = "Nam";
                string namSinh = "";
                if (cbxNamSinh.Checked)
                {
                    namSinh = dtpNamSinh.Text;
                }
                dtBenhNhan = bus_benhNhan.TimBenhNhan(tbxMaBenhNhan.Text, tbxHoTen.Text, tbxCMND.Text, gioiTinh
                              , namSinh, tbxSDT.Text, tbxDiaChi.Text);
                if (dtBenhNhan != null)
                {
                    grvDanhSachBN.Visible = true;
                    //grvDSThuoc.AutoGenerateColumns = true;
                    grvDanhSachBN.DataSource = dtBenhNhan;

                    dtBenhNhan.Columns[0].ColumnName = "Mã bệnh nhân";
                    dtBenhNhan.Columns[1].ColumnName = "Họ tên";
                    dtBenhNhan.Columns[2].ColumnName = "Giới tính";
                    dtBenhNhan.Columns[3].ColumnName = "Năm sinh";
                    dtBenhNhan.Columns[4].ColumnName = "Địa chỉ";
                    dtBenhNhan.Columns[5].ColumnName = "SĐT";
                    dtBenhNhan.Columns[6].ColumnName = "CMND";

                    grvDanhSachBN.AutoResizeColumns();
                    grvDanhSachBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                btnThemBenhNhan.Enabled = true;
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                DisableControl();
                btnTimKiem.Text = "Tìm kiếm";
                tbxMaBenhNhan.ReadOnly = true;
                cbxNamSinh.Enabled = false;
                cbxNamSinh.Checked = false;
                dtpNamSinh.Enabled = true;
            }
            isTimKiem = !isTimKiem;


        }
        
        /// XOA
      
        private void btnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            if (tbxMaBenhNhan.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = bus_benhNhan.XoaBenhNhan(tbxMaBenhNhan.Text);
                if (kq)
                {
                    ReloadGridViewBenhNhan();
                    MessageBox.Show("Xóa bệnh nhân thành công!");
                    tbxMaBenhNhan.Text = "";
                    tbxHoTen.Text = "";
                    tbxDiaChi.Text = "";
                    tbxCMND.Text = "";
                    tbxSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa bệnh nhân thất bại!");
                }
            }
        }

        private bool CheckThongTinPhuHop()
        {
            if (tbxHoTen.Text.Length > 30)
            {
                MessageBox.Show("Tên quá dài! (Tối đa 30 ký tự)");
                return false;
            }
            if (tbxCMND.Text.Length > 13)
            {
                MessageBox.Show("Số CMND quá dài! (Tối đa 13 ký tự)");
                return false;
            }
            if (tbxSDT.Text.Length > 11)
            {
                MessageBox.Show("SĐT quá dài! (Tối đa 11 ký tự)");
                return false;
            }
            if (tbxDiaChi.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ quá dài! (Tối đa 50 ký tự)");
                return false;
            }


            return true;
        }
        bool isSua = false;
        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            if (tbxMaBenhNhan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại đơn vị để sửa!");
                return;
            }

            if (!isSua)//Sua
            {
                tbxMaBenhNhan.ReadOnly = false;
                btnSuaBenhNhan.Text = "Hoàn tất";
                btnThemBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
            }
            else
            {
                try
                {
                    string gt = string.Empty;
                    tbxMaBenhNhan.ReadOnly = true;
                    tbxCMND.ReadOnly = true;
                    tbxDiaChi.ReadOnly = true;
                    tbxHoTen.ReadOnly = true;
                    tbxSDT.ReadOnly = true;
                    rbtnNam.Enabled = true;
                    rbtnNu.Enabled = true;
                    if (rbtnNam.Checked)
                    {
                        gt = "Nam";
                    }
                    else
                    {
                        gt = "Nữ";
                    }
                    BenhNhanDTO bn = new BenhNhanDTO(tbxMaBenhNhan.Text, tbxHoTen.Text,gt,dtpNamSinh.Value.Year,tbxDiaChi.Text,tbxSDT.Text,tbxCMND.Text);
                    if (!BenhNhanDAO.CapNhatBenhNhan(bn))
                    {
                        MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!");
                        ReloadGridViewBenhNhan();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                
            }

            isSua = !isSua;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
