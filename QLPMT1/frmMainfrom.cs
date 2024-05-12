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

namespace QLPMT1
{
    public partial class frmMainfrom : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        string TaiKhoan;
        public frmMainfrom(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
            // MessageBox.Show(TaiKhoan);
            InitializeComponent();

            PhanQuyen(Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)));

            btnXemDSPhieuKham.Text = "Xem danh sách\n phiếu khám bệnh";
        }
        public void SetTaiKhoan(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
        }
        public void PhanQuyen(int i)
        {
            grbTiepTan.Enabled = false;
            grbBacSi.Enabled = false;
            grbQuanTriVien.Enabled = false;
            grbKeToan.Enabled = false;
            tabQLThuoc.Enabled = false;
            tabKhamBenh.Enabled = false;
            tabThuTien.Enabled = false;
            //tabThuKho.Enabled = false;
            tabBaoCao.Enabled = false;



            int indexCheck = 0;
            while (i > 0)
            {
                indexCheck = i % 10;
                switch (indexCheck)
                {
                    case 1:
                        grbQuanTriVien.Enabled = true;
                        break;
                    case 2:
                        grbTiepTan.Enabled = true;
                        break;
                    case 3:
                        grbBacSi.Enabled = true;
                        tabKhamBenh.Enabled = true;
                        break;
                    case 4:
                        grbBacSi.Enabled = true;
                        tabQLThuoc.Enabled = true;
                        break;
                    case 5:
                        grbKeToan.Enabled = true;
                        tabThuTien.Enabled = true;
                        break;
                    case 6:
                        grbKeToan.Enabled = true;
                        //tabThuKho.Enabled = true;
                        tabBaoCao.Enabled = true;
                        break;
                    default: break;
                }
                i /= 10;
            }
        }

        private void btnQLBN_Click(object sender, EventArgs e)
        {
            frmThemBenhNhan addBenhNhan = new frmThemBenhNhan();
            addBenhNhan.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frmPhanQuyen f = new frmPhanQuyen();
            f.ShowDialog();
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            frmLapPhieuKham f = new frmLapPhieuKham();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmThemThuoc f = new frmThemThuoc();
            f.ShowDialog();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan f = new frmThemTaiKhoan();
            f.ShowDialog();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            frmXoaTaiKhoan f = new frmXoaTaiKhoan();
            f.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmBaoCaoDanhThu f = new frmBaoCaoDanhThu();
            

            f.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmThongKeSuDungThuoc f = new frmThongKeSuDungThuoc();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan f = new frmThongTinTaiKhoan(TaiKhoan);
            f.ShowDialog();
        }

        private void btnTraCuuHoaDon_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDon f = new frmTraCuuHoaDon();
            f.ShowDialog();
        }

        private void btnQuanLyBenh_Click(object sender, EventArgs e)
        {
            frmQuanLyBenh f = new frmQuanLyBenh();
            f.ShowDialog();
        }

        private void btnDonViThuoc_Click(object sender, EventArgs e)
        {
            frmDonViThuoc f = new frmDonViThuoc();
            f.ShowDialog();
        }

        private void btnCachSuDungThuoc_Click(object sender, EventArgs e)
        {
            frmQuanLyCachDung f = new frmQuanLyCachDung();
            f.ShowDialog();
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NguyenThanhHuy_DTH215927_DH22TH2 \nGVHD:Thầy Nguyễn Hoài Nam \nĐề tài: Phần mềm quản lý phòng mạch tư \nVersoin 1.0");

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fLogin = new frmLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmThemBenhNhanVaoDanhSachKham f = new frmThemBenhNhanVaoDanhSachKham();
            f.ShowDialog();
        }

        private void btnXemDSPhieuKham_Click(object sender, EventArgs e)
        {
            frmXemDanhSachPhieuKham f = new frmXemDanhSachPhieuKham();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyThamSo f = new frmQuanLyThamSo();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHDSD f = new frmHDSD();
            f.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            frmXemDanhSachTaiKhoan f = new frmXemDanhSachTaiKhoan();
            f.ShowDialog();
        }
    }
 }
