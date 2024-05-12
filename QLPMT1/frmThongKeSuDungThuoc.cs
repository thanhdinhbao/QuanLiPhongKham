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
    public partial class frmThongKeSuDungThuoc : Form
    {
        DonThuocBUS bus_donThuoc = new DonThuocBUS();
        DataTable dtThongKeSuDungThuoc;
        public frmThongKeSuDungThuoc()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                grvThongKeSuDungThuoc.DataSource = null;


                int thang = dtpThang.Value.Month;
                int nam = dtpThang.Value.Year;
                dtThongKeSuDungThuoc = bus_donThuoc.GetBangThongKeSuDungThuoc(thang, nam);

                dtThongKeSuDungThuoc.Columns[0].ColumnName = "Mã thuốc";
                dtThongKeSuDungThuoc.Columns[1].ColumnName = "Tên thuốc";
                dtThongKeSuDungThuoc.Columns[2].ColumnName = "Đơn vị";
                dtThongKeSuDungThuoc.Columns[3].ColumnName = "Số lượng bán ra";
                dtThongKeSuDungThuoc.Columns[4].ColumnName = "Số lần dùng";
                grvThongKeSuDungThuoc.DataSource = dtThongKeSuDungThuoc;

                if (grvThongKeSuDungThuoc.Rows == null)
                    return;
                int i = 0;
                foreach (DataGridViewRow r in grvThongKeSuDungThuoc.Rows)
                {
                    if (i == grvThongKeSuDungThuoc.RowCount - 1)
                        break;
                    //Them STT
                    r.Cells[0].Value = ++i;

                }

            }
            catch { }
        }
        Bitmap bmp;

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                //float currentDPI = (float)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", 96);
                //float scale = 96 / (float)currentDPI;
                //MessageBox.Show(getScalingFactor().ToString());

                Graphics g = this.CreateGraphics();
                bmp = new Bitmap((int)(this.Size.Width * getScalingFactor()), (int)(this.Size.Height * getScalingFactor()), g);
                Graphics mg = Graphics.FromImage(bmp);

                Size t = new Size((int)((this.Size.Width - 20) * getScalingFactor()), (int)((this.Size.Height - 38) * getScalingFactor()));
                btnIn.Hide();
                btnXuatExcel.Hide();
                btnXem.Hide();
                mg.CopyFromScreen((int)((this.Location.X + 10) * getScalingFactor()), (int)((this.Location.Y + 30) * getScalingFactor()), 0, 0, t);
                printPreviewDialog1.ShowDialog();
                btnXem.Show();
                btnIn.Show();
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

        #region Get Scaling of Screen
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }


        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }

        #endregion

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExportExcel excel = new ExportExcel();
                // Lấy về nguồn dữ liệu cần Export là 1 DataTable
                // DataTable này mỗi bạn lấy mỗi khác. 
                // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
                // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
                // DataGridView nhé 
                DataTable dt = (DataTable)grvThongKeSuDungThuoc.DataSource;
                try
                {
                    if (dt.Rows[0].ItemArray[0] == null)
                    {
                        MessageBox.Show("Lỗi: Bảng báo cáo này rỗng!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi: Bảng báo cáo này rỗng!");
                    return;
                }

                string thangNam = dtpThang.Value.Month.ToString() + @"-" + dtpThang.Value.Year.ToString();
                string sheetName = "SuSungThuoc-" + thangNam;
                string tieuDe = "SỬ DỤNG THUỐC THÁNG " + thangNam;
                //string tongKet = "TỔNG DOANH THU: " + tbxTongDoanhThu.Text;

                excel.Export(dt, sheetName, tieuDe);

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi tronng quá trình liên kết đến MS.Excel trên thiết bị!");
            }
        }
    }
    
}
