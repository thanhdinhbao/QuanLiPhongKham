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
    public partial class frmThemThuoc : Form
    {

        LoaiThuocBUS bus_loaiThuoc = new LoaiThuocBUS();
        DataTable dtThongTinThuoc;

        public frmThemThuoc()
        {
            InitializeComponent();
            ReloadLoaiDonViVsCachDung();

            //Load du lieu benh nhan
            ReloadGridViewLoaiThuoc();
        }

        void ReloadLoaiDonViVsCachDung()
        {
            List<LoaiDonViDTO> lstdv = LoaiDonViBUS.GetThongTinTatCaLoaiDonVi();
            List<CachDungDTO> lstcd = CachDungBUS.GetThongTinTatCaCachDung();
            // dtThongTinLoaiDonVi = bus_loaiDonVi.GetThongTinTatCaLoaiDonVi();
            // dtThongTinCachDung = CachDungBUS.GetThongTinTatCaCachDung();

            cbxDonVi.DataSource = lstdv;
            cbxDonVi.DisplayMember = "TenLoaiDonVi";
            cbxDonVi.ValueMember = "MaLoaiDonVi";

            cbxCachDung.DataSource = lstcd;
            cbxCachDung.DisplayMember = "STenLoaiCachDung";
            cbxCachDung.ValueMember = "SMaLoaiCachDung";
        }
        #region Support Function
        //Load danh sách loại thuốc vào gridview
        void ReloadGridViewLoaiThuoc()
        {
            //List<LoaiThuocDTO> lstlt = LoaiThuocBUS.GetThongTinCanShowVeThuoc();
            DataTable dt = LoaiThuocBUS.GetThongTinCanShowVeThuoc();
            List<LoaiThuocDTO> lstlt = new List<LoaiThuocDTO>();
            foreach (DataRow dr in dt.Rows)
            {
                LoaiThuocDTO dto = new LoaiThuocDTO();
                dto.MaLoaiThuoc = dr["MaLoaiThuoc"].ToString();
                dto.TenLoaiThuoc = dr["TenLoaiThuoc"].ToString();
                dto.MaLoaiDonVi = dr["TenLoaiDonVi"].ToString();
                dto.MaLoaiCachDung = dr["TenLoaiCachDung"].ToString();
                dto.DonGia = Convert.ToInt32(dr["DonGia"]);

                lstlt.Add(dto);
            }
                           
            //dtThongTinThuoc = LoaiThuocBUS.GetThongTinCanShowVeThuoc();
            if (lstlt != null)
            {
                grvDSThuoc.Visible = true;
                //grvDSThuoc.AutoGenerateColumns = true;
                grvDSThuoc.DataSource = lstlt;

                grvDSThuoc.Columns[0].HeaderText = "Mã thuốc";
                grvDSThuoc.Columns[1].HeaderText = "Tên thuốc";
                grvDSThuoc.Columns[2].HeaderText = "Đơn vị";
                grvDSThuoc.Columns[3].HeaderText = "Cách dùng";
                grvDSThuoc.Columns[4].HeaderText = "Đơn giá";

                grvDSThuoc.AutoResizeColumns();
                grvDSThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        void EnableControl()
        {
            tbxMaThuoc.ReadOnly = false;
            tbxTenThuoc.ReadOnly = false;
            tbxDonGia.ReadOnly = false;
            cbxCachDung.Enabled = true;
            cbxDonVi.Enabled = true;
        }

        void DisableControl()
        {
            tbxMaThuoc.ReadOnly = true;
            tbxTenThuoc.ReadOnly = true;
            tbxDonGia.ReadOnly = true;
            cbxDonVi.Enabled = false;
            cbxCachDung.Enabled = false;
        }

        #endregion

        private void grvDSThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isThem || isSua)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDSThuoc.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells[0].Value.ToString() == "")
                    return;

                tbxMaThuoc.Text = row.Cells[0].Value.ToString();
                tbxTenThuoc.Text = row.Cells[1].Value.ToString();
                tbxDonGia.Text = row.Cells[4].Value.ToString();
                cbxDonVi.SelectedValue = row.Cells[2].Value.ToString();
                cbxCachDung.SelectedValue = row.Cells[3].Value.ToString();
                cbxDonVi.Text = row.Cells[2].Value.ToString();
                cbxCachDung.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (tbxMaThuoc.ReadOnly == true || isSua)
                return;
            tbxMaThuoc.Text = bus_loaiThuoc.GetMaLoaiThuocNext();
        }

        //**********************************THÊM THUỐC**********************************
        bool isThem = false;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)//neu chua them thi gio them
            {
                EnableControl();

                tbxDonGia.Text = "";
                tbxTenThuoc.Text = "";

                tbxMaThuoc.Text = bus_loaiThuoc.GetMaLoaiThuocNext();
                if (tbxMaThuoc.Text == "")
                {
                    MessageBox.Show("Không lấy được mã loại thuốc!");
                    return;
                }

                btnThem.Text = "  Hoàn tất";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTimKiem.Enabled = false;


            }
            else //Neu nhap xong thi them vo
            {
                if (tbxMaThuoc.Text == "")
                {
                    MessageBox.Show("Mã loại thuốc không hợp lệ!");
                    return;
                }
                else if (tbxTenThuoc.Text.Length < 2)
                {
                    MessageBox.Show("Tên thuốc không hợp lệ!");
                    return;
                }
                else if (cbxDonVi.SelectedValue == null)
                {
                    MessageBox.Show("Đơn vị không hợp lệ!");
                    return;
                }
                else if (cbxCachDung.SelectedValue == null)
                {
                    MessageBox.Show("Cách dùng không hợp lệ!");
                    return;
                }
                if (tbxDonGia.Text == "")
                {
                    tbxDonGia.Text = "0";
                    MessageBox.Show("Đơn giá không được để trống!");
                    return;
                }
                if (!CheckThongTinThuocPhuHop())
                {
                    return;
                }

                
                LoaiThuocDTO loaiThuoc = new LoaiThuocDTO(tbxMaThuoc.Text, tbxTenThuoc.Text, cbxDonVi.SelectedValue.ToString(),
                                                        cbxCachDung.SelectedValue.ToString(), Int32.Parse(tbxDonGia.Text));
                if (LoaiThuocBUS.Add(loaiThuoc))
                {
                    ReloadGridViewLoaiThuoc();
                    MessageBox.Show("Thêm loại thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm loại thuốc thất bại!");
                }

                //Done
                DisableControl();
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;
            }

            isThem = !isThem;
        }

        private bool CheckThongTinThuocPhuHop()
        {
            if (tbxMaThuoc.Text.Length > 5)
            {
                MessageBox.Show("Mã thuốc không được quá 5 ký tự!");
                return false;
            }
            if (tbxTenThuoc.Text.Length > 30)
            {
                MessageBox.Show("Tên thuốc không được quá 30 ký tự!");
                return false;
            }
            if (cbxCachDung.SelectedValue == null)
            {
                MessageBox.Show("Cách dùng không tồn tại!");
                return false;
            }
            if (cbxDonVi.SelectedValue == null)
            {
                MessageBox.Show("Đơn vị không tồn tại!");
                return false;
            }



            return true;
        }

        //**********************************SỬA LOẠI THUỐC**********************************
        private bool isSua = false;

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxMaThuoc.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã loại thuốc!");
                return;
            }

            if (isSua)// neu sua xong thi luu va disable
            {

                if (tbxMaThuoc.Text == "")
                {
                    MessageBox.Show("Mã loại thuốc không hợp lệ!");
                    return;
                }
                else if (tbxTenThuoc.Text.Length < 2)
                {
                    MessageBox.Show("Tên thuốc không hợp lệ!");
                    return;
                }
                else if (cbxDonVi.SelectedValue == null)
                {
                    MessageBox.Show("Đơn vị không hợp lệ!");
                    return;
                }
                else if (cbxCachDung.SelectedValue == null)
                {
                    MessageBox.Show("Cách dùng không hợp lệ!");
                    return;
                }
                if (tbxDonGia.Text == "")
                {
                    tbxDonGia.Text = "0";
                }

                if (!CheckThongTinThuocPhuHop())
                {
                    return;
                }

                DisableControl();
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;

                LoaiThuocDTO loaiThuoc = new LoaiThuocDTO (tbxMaThuoc.Text, tbxTenThuoc.Text, cbxDonVi.SelectedValue.ToString(),
                                                        cbxCachDung.SelectedValue.ToString(), Int32.Parse(tbxDonGia.Text));
                if (LoaiThuocBUS.Update(loaiThuoc))
                {
                    ReloadGridViewLoaiThuoc();
                    MessageBox.Show("Sửa loại thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa loại thuốc thất bại!");
                }
            }
            else //Neu chua sua thi enable
            {
                EnableControl();
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnTimKiem.Enabled = false;
                btnSua.Text = "Hoàn tất";
            }

            isSua = !isSua;
        }
        //**********************************XÓA LOAI THUOC**********************************
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaThuoc.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã loại thuốc!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại thuốc này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = LoaiThuocBUS.Delete(tbxMaThuoc.Text);
                if (kq)
                {
                    ReloadGridViewLoaiThuoc();
                    MessageBox.Show("Xóa loại thuốc thành công!");
                    tbxMaThuoc.Text = "";
                    tbxDonGia.Text = "";
                    tbxTenThuoc.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa loại thuốc thất bại!");
                }
            }
        }
        //**********************************HỦY THAO TÁC**********************************
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;
                DisableControl();
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;

                tbxMaThuoc.Text = "";
                tbxTenThuoc.Text = "";
                tbxDonGia.Text = "";


            }
            if (isThem)
            {
                isThem = false;
                DisableControl();
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;

                tbxMaThuoc.Text = "";
                tbxTenThuoc.Text = "";
                tbxDonGia.Text = "";

            }
            if (isTimKiem)
            {
                isTimKiem = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                DisableControl();

                tbxMaThuoc.Text = "";
                tbxTenThuoc.Text = "";
                tbxDonGia.Text = "";

                btnTimKiem.Text = "Tìm kiếm";
            }
            ReloadGridViewLoaiThuoc();
        }


        //**********************************TÌM KIẾM**********************************
        bool isTimKiem = false;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!isTimKiem)//Mo che do tim kiem
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                EnableControl();
                btnTimKiem.Text = "Tìm ngay ->";

            }
            else //Ket thuc tim kiem
            {
                dtThongTinThuoc = bus_loaiThuoc.TimKiemThuoc(tbxMaThuoc.Text, tbxTenThuoc.Text, cbxDonVi.Text, cbxCachDung.Text, tbxDonGia.Text);
                if (dtThongTinThuoc != null)
                {
                    grvDSThuoc.Visible = true;
                    //grvDSThuoc.AutoGenerateColumns = true;
                    grvDSThuoc.DataSource = dtThongTinThuoc;

                    dtThongTinThuoc.Columns[0].ColumnName = "Mã thuốc";
                    dtThongTinThuoc.Columns[1].ColumnName = "Tên thuốc";
                    dtThongTinThuoc.Columns[2].ColumnName = "Đơn vị";
                    dtThongTinThuoc.Columns[3].ColumnName = "Cách dùng";
                    dtThongTinThuoc.Columns[4].ColumnName = "Đơn giá";

                    grvDSThuoc.AutoResizeColumns();
                    grvDSThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                DisableControl();
                btnTimKiem.Text = "Tìm kiếm";
            }
            isTimKiem = !isTimKiem;
        }

        private void cbxDonVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
