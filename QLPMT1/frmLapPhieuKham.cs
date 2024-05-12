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
    public partial class frmLapPhieuKham : Form
    {

        DanhSachKhamBenhBUS bus_danhSachKhamBenh = new DanhSachKhamBenhBUS();
        BenhNhanBUS bus_benhNhan = new BenhNhanBUS();
        PhieuKhamBUS bus_phieuKham = new PhieuKhamBUS();
        CTDSKBBUS bus_ctdskb = new CTDSKBBUS();
        LoaiBenhBUS bus_loaiBenh = new LoaiBenhBUS();
        DonThuocBUS bus_donThuoc = new DonThuocBUS();
        LoaiThuocBUS bus_loaiThuoc = new LoaiThuocBUS();
        HoaDonBUS bus_hoaDon = new HoaDonBUS();
        ThamSoBUS bus_thamSo = new ThamSoBUS();
        DataTable dtDSToaThuoc, dtLoaiBenh, dtLoaiThuoc;
        private string maDSKB = "";
        public frmLapPhieuKham()
        {
            InitializeComponent();
            tbxMaPhieuKham.Text = bus_phieuKham.GetNextMaPK();
            //tbxMaDonThuoc.Text = bus_donThuoc.GetMaDonThuocNext();
            ReloadLoaiBenh();
            ReloadMaThuoc_TenThuoc();

            dtDSToaThuoc = new DataTable();
            dtDSToaThuoc.Columns.Add("STT");
            dtDSToaThuoc.Columns.Add("Tên thuốc");
            dtDSToaThuoc.Columns.Add("Số lượng");
            dtDSToaThuoc.Columns.Add("Đơn vị");
            dtDSToaThuoc.Columns.Add("Cách dùng");


        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            KiemTraDSVaBenhNhan();
        }

        bool KiemTraDSVaBenhNhan()
        {
            //lấy mã danh sách của ngày được chọn
            string maDS = "DS" + dtpNgayKham.Value.Year.ToString();
            if (dtpNgayKham.Value.Month < 10)
                maDS += "0" + dtpNgayKham.Value.Month.ToString();
            else
                maDS += dtpNgayKham.Value.Month.ToString();
            if (dtpNgayKham.Value.Day < 10)
                maDS += "0" + dtpNgayKham.Value.Day.ToString();
            else
                maDS += dtpNgayKham.Value.Day.ToString();

            //Kiểm tra bệnh nhân có trong ds khám bệnh chưa
            if (!bus_danhSachKhamBenh.CheckDanhSachTonTai(maDS)) //Nếu chưa có ds thì cũng chưa có bệnh nhân
            {
                //MessageBox.Show("Bệnh nhân không nằm trong danh sách khám bệnh!");
                lbStatusTimBenhNhan.Text = "Bệnh nhân không nằm trong danh sách khám bệnh!";
                tbxTenBenhNhan.Text = "";
                return false;
            }
            else //Nếu có ds rồi thì dò xem có bệnh nhân trong đấy k
            {
                maDSKB = maDS;
                if (!bus_ctdskb.KiemTraBenhNhanCoTrongDanhSach(maDS, tbxMaBenhNhan.Text))
                {
                    //MessageBox.Show("Bệnh nhân không nằm trong danh sách khám bệnh!");
                    lbStatusTimBenhNhan.Text = "Bệnh nhân không nằm trong danh sách khám bệnh!";
                    tbxTenBenhNhan.Text = "";
                    return false;
                }
            }

            //Neu benh nhan ton tai trong ds
            lbStatusTimBenhNhan.Text = "";
            tbxTenBenhNhan.Text = bus_benhNhan.GetTenFromMaBenhNhan(tbxMaBenhNhan.Text);
            return true;
        }

        private void tbxMaBenhNhan_Leave(object sender, EventArgs e)
        {
            KiemTraDSVaBenhNhan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDSVaBenhNhan())
                return;
            if (tbxTrieuChung.Text.Length > 50)
            {
                MessageBox.Show("Triệu chứng bệnh quá dài! (Tối đa 50 ký tự)");
                return;
            }
            if (cbxLoaiBenh.SelectedValue == null)
            {
                MessageBox.Show("Loại bệnh không tồn tại trong danh sách!");
                return;
            }
            //Luu phieu kham
            try
            {
                //MessageBox.Show( bus_ctdskb.GetMaCTDSKB(maDSKB, tbxMaBenhNhan.Text)); BN0000001
                PhieuKhamDTO phieuKham = new PhieuKhamDTO(tbxMaPhieuKham.Text, bus_ctdskb.GetMaCTDSKB(maDSKB, tbxMaBenhNhan.Text), tbxTrieuChung.Text, cbxLoaiBenh.SelectedValue.ToString());
                bus_phieuKham.ThemPhieuKham(phieuKham);

                //Luu don thuoc
                try
                {
                    for (int i = 0; i < dgrvDSThuoc.Rows.Count - 1; i++)
                    {
                        DataTable table = dgrvDSThuoc.DataSource as DataTable;
                        DataRow r = table.NewRow();
                        r = ((DataRowView)dgrvDSThuoc.Rows[i].DataBoundItem).Row;

                        //MessageBox.Show(bus_donThuoc.GetMaDonThuocNext(i));
                        //MessageBox.Show(tbxMaPhieuKham.Text);
                        //MessageBox.Show(bus_loaiThuoc.GetMaLoaiThuocFromTen(r.ItemArray[1].ToString()));
                        //string tmp = r.ItemArray[2].ToString();
                        //MessageBox.Show(Int32.Parse(tmp).ToString());

                        DonThuocDTO donThuoc = new DonThuocDTO(bus_donThuoc.GetMaDonThuocNext(i),
                                                                 tbxMaPhieuKham.Text,
                                                                 bus_loaiThuoc.GetMaLoaiThuocFromTen(r.ItemArray[1].ToString()),
                                                                 Int32.Parse(r.ItemArray[2].ToString()));


                        if (bus_donThuoc.Add(donThuoc))
                        {
                            //MessageBox.Show("Lưu phiếu khám thành công!");

                        }
                        else
                        {
                            MessageBox.Show("Lưu đơn thuốc thất bại!");
                            bus_phieuKham.Delete(tbxMaPhieuKham.Text);
                            return;
                        }
                    }

                    //add vao hoa don
                    LuuHoaDon();

                    MessageBox.Show("Lưu phiếu khám thành công!");

                }
                catch
                {
                    MessageBox.Show("Lưu đơn thuốc thất bại!");
                    bus_phieuKham.Delete(tbxMaPhieuKham.Text);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lưu phiếu khám thất bại!");
                return;
            }
            ResetGiaoDien();
        }
        void ResetGiaoDien()
        {
            tbxMaPhieuKham.Text = bus_phieuKham.GetNextMaPK();
            tbxMaBenhNhan.Text = "";
            tbxTrieuChung.Text = "";
            tbxTenBenhNhan.Text = "";
            tbxSoLuong.Text = "";
            dgrvDSThuoc.DataSource = "";
            dtDSToaThuoc.Clear();
        }
        void LuuHoaDon()
        {
            string maHD = bus_hoaDon.GetMaHoaDonNext();
            string maPK = tbxMaPhieuKham.Text;
            int tienKham = bus_thamSo.GetGiaTriThamSo("TienKham");
            if (tienKham == -1)
            {
                MessageBox.Show("Lấy thông tin tiền khám thất bại!");
                tienKham = 0;
            }

            int tienThuoc = 0;
            DataTable dtTienThuocTmp = bus_donThuoc.GetThongTinTienThuocFromPhieuKham(tbxMaPhieuKham.Text);
            foreach (DataRow r in dtTienThuocTmp.Rows)
            {
                tienThuoc += Int32.Parse(r.ItemArray[3].ToString());
            }
            //MessageBox.Show(tienThuoc.ToString());

            HoaDonDTO hoaDon = new HoaDonDTO(maHD, maPK, tienKham, tienThuoc);
            bus_hoaDon.Add(hoaDon);

            //LuuNo vao dto

        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (tbxSoLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng thuốc!");
                return;
            }
            try
            {
                DataRow rowLoaiThuoc = dtLoaiThuoc.Rows.Find(cbxTenThuoc.SelectedValue.ToString());
                if (rowLoaiThuoc == null)
                {
                    MessageBox.Show("Không tìm thấy thuốc!");
                    return;
                }
                dtDSToaThuoc.Rows.Add(dtDSToaThuoc.Rows.Count + 1, cbxTenThuoc.Text, tbxSoLuong.Text, rowLoaiThuoc.ItemArray[2].ToString(), rowLoaiThuoc.ItemArray[3].ToString());

                dgrvDSThuoc.DataSource = dtDSToaThuoc;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thuốc!");
                return;
            }

        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgrvDSThuoc.SelectedRows != null)
                {
                    int index = dgrvDSThuoc.SelectedCells[0].RowIndex;
                    if (dgrvDSThuoc.SelectedCells[0].RowIndex >= 0 && dgrvDSThuoc.SelectedCells[0].RowIndex < dgrvDSThuoc.RowCount - 1)
                        dgrvDSThuoc.Rows.RemoveAt(dgrvDSThuoc.SelectedCells[0].RowIndex);
                    for (int i = index; i < dtDSToaThuoc.Rows.Count; i++)
                    {
                        dgrvDSThuoc.Rows[i].Cells[0].Value = (i + 1).ToString();
                    }
                }
            }
            catch { }
        }

        private void tbxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        void ReloadLoaiBenh()
        {
            List<LoaiBenhDTO> lstlb = LoaiBenhBUS.GetThongTinTatCaLoaiBenh();
            //dtLoaiBenh = bus_loaiBenh.GetThongTinTatCaLoaiBenh();

            cbxLoaiBenh.DataSource = lstlb;
            cbxLoaiBenh.DisplayMember = "TenLoaiBenh";
            cbxLoaiBenh.ValueMember = "MaLoaiBenh";
        }

        void ReloadMaThuoc_TenThuoc()
        {
            //List<LoaiThuocDTO> lstlt = LoaiThuocBUS.GetThongTinCanShowVeThuoc();
            dtLoaiThuoc = LoaiThuocBUS.GetThongTinCanShowVeThuoc();

            //Set key column
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dtLoaiThuoc.Columns["MaLoaiThuoc"];
            dtLoaiThuoc.PrimaryKey = keyColumns;

            //cbxMaThuoc.DataSource = cbxTenThuoc.DataSource = dtLoaiThuoc;
            cbxTenThuoc.DataSource = dtLoaiThuoc;
            //cbxMaThuoc.DisplayMember = cbxMaThuoc.ValueMember= cbxTenThuoc.ValueMember= "MaLoaiThuoc";
            cbxTenThuoc.ValueMember = "MaLoaiThuoc";
            cbxTenThuoc.DisplayMember = "TenLoaiThuoc";
            //cbxTenThuoc.SelectedValue = cbxMaThuoc.SelectedValue;
        }
    }
}
