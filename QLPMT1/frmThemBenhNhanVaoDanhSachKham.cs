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
    public partial class frmThemBenhNhanVaoDanhSachKham : Form
    {
        BenhNhanBUS bus_benhNhan = new BenhNhanBUS();
        DanhSachKhamBenhBUS bus_danhSachKhamBenh = new DanhSachKhamBenhBUS();
        PhieuKhamBUS bus_phieuKham = new PhieuKhamBUS();
        CTDSKBBUS bus_ctdskb = new CTDSKBBUS();
        DataTable dtDSBenhNhan;
        public frmThemBenhNhanVaoDanhSachKham()
        {
            InitializeComponent();
            ReloadGridViewDanhSach();
        }

        void ReloadGridViewDanhSach()
        {
            List<DanhSachKhamBenhDTO> lstdskb = DanhSachKhamBenhBUS.GetThongTinTatCaDanhSach();
           // dtDSBenhNhan = bus_danhSachKhamBenh.LayDanhSachKhamBenh(dtpNgayKham.Value);
            if (lstdskb != null)
            {
                grvDanhSachKham.Visible = true;
                //grvDanhSachBN.AutoGenerateColumns = true;
                grvDanhSachKham.DataSource = lstdskb;
                grvDanhSachKham.Columns[0].HeaderText = "Mã bệnh nhân";
                grvDanhSachKham.Columns[1].HeaderText = "Họ tên";
                grvDanhSachKham.Columns[2].HeaderText = "Giới tính";
                grvDanhSachKham.Columns[3].HeaderText = "Năm sinh";
                grvDanhSachKham.Columns[4].HeaderText = "Địa chỉ";
                grvDanhSachKham.Columns[5].HeaderText = "SĐT";
                grvDanhSachKham.Columns[6].HeaderText = "CMND";
                for (int i = 0; i < grvDanhSachKham.Rows.Count - 1; i++)
                {
                    grvDanhSachKham.Rows[i].Cells[0].Value = i + 1;
                }

                grvDanhSachKham.AutoResizeColumns();
                grvDanhSachKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            try
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

                string maCTDS = bus_ctdskb.GetMaCTDSKB(maDS, tbxMaBenhNhan.Text);
                if (maCTDS == "")
                {
                    MessageBox.Show("Bệnh nhân không tồn tại trong danh sách khám này!");
                    return;
                }
                if (bus_ctdskb.Delete(maCTDS))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                ReloadGridViewDanhSach();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");

            }
        }

        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            if (tbxMaBenhNhan.Text.Length > 10)
            {
                MessageBox.Show("Mã bệnh nhân không hợp lệ!");
                return;
            }
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

            //Nếu ngày đó chưa có danh sách thì tự động tạo
            if (!bus_danhSachKhamBenh.CheckDanhSachTonTai(maDS))
            {
                DateTime dt = DateTime.Parse(dtpNgayKham.Value.ToShortDateString());
                DanhSachKhamBenhDTO dskb = new DanhSachKhamBenhDTO(maDS, dt);
                if (!bus_danhSachKhamBenh.ThemDanhSach(dskb))
                {
                    MessageBox.Show("Thêm danh sách thất bại!");
                    return;
                }
            }
            //Đến bước này thì đã có danh sách được tạo cho ngày đấy rồi
            //Lấy mã ctDS next
            string maCTDSNext = bus_ctdskb.GetNextMaCTDSKB();
            CTDSKBDTO CTDS = new CTDSKBDTO(maCTDSNext, maDS, tbxMaBenhNhan.Text);
            if (bus_ctdskb.ThemBenhNhanVaoDanhSach(CTDS))
            {
                MessageBox.Show("Thêm thành công!");
                ReloadGridViewDanhSach();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
                return;
            }
        }

        private void dtpNgayKham_ValueChanged(object sender, EventArgs e)
        {
            ReloadGridViewDanhSach();
        }

        private void frmThemBenhNhanVaoDanhSachKham_Load(object sender, EventArgs e)
        {
            dtpNgayKham.Format = DateTimePickerFormat.Custom;
            dtpNgayKham.CustomFormat = "yyyy/MM/dd";
        }
    }
}
