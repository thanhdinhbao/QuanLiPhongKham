using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using System.Windows.Forms;


namespace QLPMT1
{
    public partial class frmXemDanhSachPhieuKham : Form
    {


        CTDSKBBUS bus_ctdskb = new CTDSKBBUS();
        DataTable dtDanhSachBenhNhan;
        public frmXemDanhSachPhieuKham()
        {
            InitializeComponent();
            ReloadDSBenhNhan();
        }

        public void ReloadDSBenhNhan()
        {
            string day = "";
            if (dtpNgay.Enabled)
            {
                //lấy mã danh sách của ngày được chọn
                day = dtpNgay.Value.Year.ToString();
                if (dtpNgay.Value.Month < 10)
                    day += "0" + dtpNgay.Value.Month.ToString();
                else
                    day += dtpNgay.Value.Month.ToString();
                if (dtpNgay.Value.Day < 10)
                    day += "0" + dtpNgay.Value.Day.ToString();
                else
                    day += dtpNgay.Value.Day.ToString();
            }

            //List<BenhNhanDTO> lstBenhNhan = BenhNhanBUS.LayDSTatCaBenhNhan();

          

      
            dtDanhSachBenhNhan = bus_ctdskb.GetThongTinBenhNhanKhamBenh(tbxMaPhieuKham.Text, tbxMaBenhNhan.Text,
                                    tbxTenBenhNhan.Text, day, tbxCMND.Text, tbxSDT.Text);

            dtDanhSachBenhNhan.Columns[0].ColumnName = "Mã phiếu khám";
            dtDanhSachBenhNhan.Columns[1].ColumnName = "Mã bệnh nhân";
            dtDanhSachBenhNhan.Columns[2].ColumnName = "Họ tên";
            dtDanhSachBenhNhan.Columns[3].ColumnName = "Ngày khám";
            dtDanhSachBenhNhan.Columns[4].ColumnName = "Loại bệnh";
            dtDanhSachBenhNhan.Columns[5].ColumnName = "Triệu chứng";

            grvDSBenhNhan.DataSource = dtDanhSachBenhNhan;

            grvDSBenhNhan.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            ReloadDSBenhNhan();
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = !dtpNgay.Enabled;
            ReloadDSBenhNhan();
        }

        private void grvDSBenhNhan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDSBenhNhan.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells["Mã phiếu khám"].Value.ToString() == "")
                    return;

                string maPK = row.Cells["Mã phiếu khám"].Value.ToString();
                string maBenhNhan = row.Cells["Mã bệnh nhân"].Value.ToString();
                string hoTen = row.Cells["Họ tên"].Value.ToString();
                string ngayKham = row.Cells["Ngày khám"].Value.ToString().Split(' ')[0];
                string loaiBenh = row.Cells["Loại bệnh"].Value.ToString();
                string trieuChung = row.Cells["Triệu chứng"].Value.ToString();
                string[] arrDay = ngayKham.Split('/');
                ngayKham = arrDay[1] + "/" + arrDay[0] + "/" + arrDay[2];

                frmChiTietPhieuKham fctpk = new frmChiTietPhieuKham(maPK, maBenhNhan, hoTen, ngayKham, loaiBenh, trieuChung);
                try
                {
                    fctpk.ShowDialog();
                }
                catch { }


            }
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmXemDanhSachPhieuKham_Enter(object sender, EventArgs e)
        {
            ReloadDSBenhNhan();
        }
    }
}
