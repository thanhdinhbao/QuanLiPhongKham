using BUS;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLPMT1
{
    public partial class frmXemDanhSachTaiKhoan : Form
    {
        TaiKhoanBUS bus_TaiKhoan = new TaiKhoanBUS();
        DataTable dtTaiKhoan;
        public frmXemDanhSachTaiKhoan()
        {
            InitializeComponent();
            ReloadGridViewTaiKhoan();
        }
        void ReloadGridViewTaiKhoan()
        {
            List<TaiKhoanDTO> lsttk = TaiKhoanBUS.GetThongTinTatCaTaiKhoan();

            if (lsttk != null)
            {
                grvDanhSachTK.Visible = true;
                grvDanhSachTK.AutoGenerateColumns = true;
                grvDanhSachTK.DataSource = lsttk;


                grvDanhSachTK.Columns[0].HeaderText = "Tên tài khoản";
                grvDanhSachTK.Columns[1].HeaderText = "Tên hiển thị";
                grvDanhSachTK.Columns[2].HeaderText = "Chức vụ";
                grvDanhSachTK.Columns[3].HeaderText = "Quyền";
                grvDanhSachTK.Columns[4].HeaderText = "Mật khẩu";

                //dtTaiKhoan.AcceptChanges();


                ///dtTaiKhoan.Columns.Remove(dtTaiKhoan.Columns[4]);

                grvDanhSachTK.AutoResizeColumns();
                grvDanhSachTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
