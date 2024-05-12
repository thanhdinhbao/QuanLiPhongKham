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
    public partial class frmQuanLyCachDung : Form
    {

       //CachDungBUS  bus_loaiCachDung = new CachDungBUS();
        DataTable dtLoaiCachDung;

        public frmQuanLyCachDung()
        {
            InitializeComponent();
            ReloadDSLoaiCachDung();
        }

        void ReloadDSLoaiCachDung()
        {
            List<CachDungDTO> lstcd = CachDungBUS.GetThongTinTatCaCachDung();
            //dtLoaiCachDung = CachDungBUS.GetThongTinTatCaCachDung();
           // dtLoaiCachDung.Columns[0].ColumnName = "Mã loại đơn vị";
          // dtLoaiCachDung.Columns[1].ColumnName = "Tên loại đơn vị";

            grvDSCachDung.DataSource = lstcd;
            grvDSCachDung.Columns[0].HeaderText = "Mã loại đơn vị";
            grvDSCachDung.Columns[1].HeaderText = "Tên loại đơn vị";

        }

        bool isThem = false;
        bool isSua = false;

        private void grvDSCachDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isThem || isSua)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDSCachDung.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells[0].Value.ToString() == "")
                    return;

                tbxMaLoaiCachDung.Text = row.Cells[0].Value.ToString();
                tbxTenLoaiCachDung.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)//them
            {
                tbxMaLoaiCachDung.Text = CachDungBUS.GetMaLoaiCachDungNext();
                tbxTenLoaiCachDung.ReadOnly = false;
                btnThem.Text = "   Hoàn tất";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

            }
            else//Luu
            {
                if (tbxTenLoaiCachDung.Text.Length > 30)
                {
                    MessageBox.Show("Tên cách dùng không được quá 30 ký tự!");
                    return;

                }
                if (tbxTenLoaiCachDung.Text.Length == 0)
                {
                    MessageBox.Show("Tên cách dùng không để trống!");
                    return;
                }
                try
                {
                    CachDungDTO loaiCachDung = new CachDungDTO(tbxMaLoaiCachDung.Text, tbxTenLoaiCachDung.Text);
                    if (!CachDungBUS.Add(loaiCachDung))
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!");
                        ReloadDSLoaiCachDung();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                    return;
                }

                btnThem.Text = "Thêm";
                tbxTenLoaiCachDung.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
            isThem = !isThem;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiCachDung.Text == "")
            {
                MessageBox.Show("Vui lòng chọn cách dùng cần sửa!");
                return;
            }
            if (!isSua)//Sua
            {
                tbxTenLoaiCachDung.ReadOnly = false;
                btnSua.Text = "Hoàn tất";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (tbxTenLoaiCachDung.Text.Length > 30)
                {
                    MessageBox.Show("Tên cách dùng không được quá 30 ký tự!");
                    return;

                }
                if (tbxTenLoaiCachDung.Text.Length == 0)
                {
                    MessageBox.Show("Tên cách dùng không để trống!");
                    return;
                }
                try
                {
                    CachDungDTO loaiCachDung = new CachDungDTO(tbxMaLoaiCachDung.Text, tbxTenLoaiCachDung.Text);
                    if (!CachDungBUS.Update(loaiCachDung))
                    {
                        MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!");
                        ReloadDSLoaiCachDung();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                tbxTenLoaiCachDung.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }

            isSua = !isSua;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiCachDung.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã loại đơn vị!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại đơn vị này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = CachDungBUS.Delete(tbxMaLoaiCachDung.Text);
                if (kq)
                {
                    ReloadDSLoaiCachDung();
                    tbxMaLoaiCachDung.Text = "";
                    tbxTenLoaiCachDung.Text = "";
                    MessageBox.Show("Xóa loại đơn vị thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa loại đơn vị thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;

                tbxTenLoaiCachDung.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                tbxMaLoaiCachDung.Text = "";
                tbxTenLoaiCachDung.Text = "";
                ReloadDSLoaiCachDung();
            }
            else if (isThem)
            {
                isThem = false;

                tbxTenLoaiCachDung.ReadOnly = true;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


                tbxMaLoaiCachDung.Text = "";
                tbxTenLoaiCachDung.Text = "";
                ReloadDSLoaiCachDung();
            }

        }
    }
}
