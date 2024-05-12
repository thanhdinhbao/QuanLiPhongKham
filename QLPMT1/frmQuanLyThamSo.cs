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
    public partial class frmQuanLyThamSo : Form
    {
        ThamSoBUS bus_thamSo = new ThamSoBUS();
       DataTable dtThamSo;
        public frmQuanLyThamSo()
        {
            InitializeComponent();
            ReloadBangThamSo();
        }
        void ReloadBangThamSo()
        {
            List<ThamSoDTO> ltsts = ThamSoBUS.GetThongTinTatCaThamSo();
            //dtThamSo = bus_thamSo.GetThongTinTatCaThamSo();
            grvThamSo.DataSource = ltsts;
            grvThamSo.Columns[0].HeaderText = "Mã tham số";
            grvThamSo.Columns[1].HeaderText = "Tên tham số";
            grvThamSo.Columns[2].HeaderText = "Trị giá";


        }

        bool isThem = false;
        bool isSua = false;
        private void grvThamSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isThem || isSua)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvThamSo.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells[0].Value.ToString() == "")
                    return;

                tbxMaThamSo.Text = row.Cells[0].Value.ToString();
                tbxTenThamSo.Text = row.Cells[1].Value.ToString();
                tbxTriGia.Text = row.Cells[2].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)//them
            {
                tbxMaThamSo.Text = bus_thamSo.GetNextMaThamSo();
                tbxTenThamSo.ReadOnly = false;
                tbxTriGia.ReadOnly = false;
                tbxTenThamSo.BackColor = SystemColors.ButtonHighlight;
                tbxTriGia.BackColor = SystemColors.ButtonHighlight;
                btnThem.Text = "Hoàn tất";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;


            }
            else//Luu
            {
                if (tbxTenThamSo.Text.Length > 30)
                {
                    MessageBox.Show("Tham số không được quá 30 ký tự!");
                    return;
                }
                if (tbxTenThamSo.Text.Length == 0)
                {
                    MessageBox.Show("Tên tham số không được để trống!");
                    return;
                }
                if (tbxTriGia.Text.Length == 0)
                {
                    MessageBox.Show("Trị giá không được để trống!");
                    return;
                }
                try
                {
                    ThamSoDTO thamSo = new ThamSoDTO(tbxMaThamSo.Text, tbxTenThamSo.Text, Int32.Parse(tbxTriGia.Text));
                    if (!bus_thamSo.Add(thamSo))
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!");
                        ReloadBangThamSo();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                tbxTenThamSo.ReadOnly = true;
                tbxTriGia.ReadOnly = true;
                tbxTenThamSo.BackColor = SystemColors.Control;
                tbxTriGia.BackColor = SystemColors.Control;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


            }
            isThem = !isThem;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxMaThamSo.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tham số cần sửa!");
                return;

            }
            if (!isSua)//Sua
            {
                tbxTriGia.ReadOnly = false;
                tbxTriGia.BackColor = SystemColors.ButtonHighlight;
                btnSua.Text = "Hoàn tất";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;

            }
            else
            {
                if (tbxTenThamSo.Text.Length > 30)
                {
                    MessageBox.Show("Tham số không được quá 30 ký tự!");
                    return;
                }
                if (tbxTriGia.Text.Length == 0)
                {
                    MessageBox.Show("Trị giá không được để trống!");
                    return;
                }
                try
                {
                    ThamSoDTO thamSo = new ThamSoDTO(tbxMaThamSo.Text, tbxTenThamSo.Text, Int32.Parse(tbxTriGia.Text));
                    if (!bus_thamSo.Update(thamSo))
                    {
                        MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!");
                        ReloadBangThamSo();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                tbxTriGia.ReadOnly = true;
                tbxTriGia.BackColor = SystemColors.Control;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }



            isSua = !isSua;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaThamSo.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã tham số!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tham số này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = bus_thamSo.Delete(tbxMaThamSo.Text);
                if (kq)
                {
                    ReloadBangThamSo();
                    tbxMaThamSo.Text = "";
                    tbxTriGia.Text = "";
                    tbxTenThamSo.Text = "";
                    MessageBox.Show("Xóa tham số thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa tham số thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;

                tbxTriGia.ReadOnly = true;
                tbxTriGia.BackColor = SystemColors.Control;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                tbxMaThamSo.Text = "";
                tbxTenThamSo.Text = "";
                tbxTriGia.Text = "";
                ReloadBangThamSo();
            }
            else if (isThem)
            {
                isThem = false;

                tbxTenThamSo.ReadOnly = true;
                tbxTriGia.ReadOnly = true;
                tbxTenThamSo.BackColor = SystemColors.Control;
                tbxTriGia.BackColor = SystemColors.Control;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


                tbxMaThamSo.Text = "";
                tbxTenThamSo.Text = "";
                tbxTriGia.Text = "";
                ReloadBangThamSo();
            }

        }

        private void tbxTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
