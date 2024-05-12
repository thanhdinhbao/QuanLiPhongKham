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
    public partial class frmChiTietPhieuKham : Form
    {
        DonThuocBUS bus_donThuoc = new DonThuocBUS();
        HoaDonBUS bus_hoaDon = new HoaDonBUS();
        PhieuKhamBUS bus_phieuKham = new PhieuKhamBUS();
        //DataTable dtDonThuoc;
        public frmChiTietPhieuKham(string maPK, string maBenhNhan, string hoTen, string ngayKham, string tenBenh, string trieuChung)
        {
            InitializeComponent();
            tbxMaPhieuKham.Text = maPK;
            tbxMaBenhNhan.Text = maBenhNhan;
            tbxTenBenhNhan.Text = hoTen;
            tbxNgayKham.Text = ngayKham;
            tbxLoaiBenh.Text = tenBenh;
            tbxTrieuChung.Text = trieuChung;


            List<DonThuocDTO> lstdt = DonThuocBUS.GetThongTinTatCaDonThuoc();
            // dtDonThuoc = bus_donThuoc.GetThongTinDonThuocFromPhieuKham(maPK);
            grvDSThuoc.Columns[0].HeaderText = "Tên thuốc";
            grvDSThuoc.Columns[1].HeaderText = "Số lượng";
            grvDSThuoc.Columns[2].HeaderText = "Đơn vị";
            grvDSThuoc.Columns[3].HeaderText = "Cách dùng";
            grvDSThuoc.DataSource = lstdt;

        }

     
        Bitmap bmp;

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy máy in nào được kết nối!", "Không tìm thấy thiết bị!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnXoaPhieuKham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu khám này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (!bus_donThuoc.XoaDonThuocCoMaPK(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa đơn thuốc thất bại!");
                }
                else if (!bus_hoaDon.XoaHoaDonCoMaPK(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
                else if (!bus_phieuKham.Delete(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa phiếu khám thất bại!");
                }


                this.Close();
            }
        }

       
    }
}
