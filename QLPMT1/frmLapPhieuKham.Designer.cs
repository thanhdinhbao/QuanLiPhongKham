
namespace QLPMT1
{
    partial class frmLapPhieuKham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuKham));
            this.label7 = new System.Windows.Forms.Label();
            this.cbxLoaiBenh = new System.Windows.Forms.ComboBox();
            this.lbStatusTimBenhNhan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrvDSThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTenThuoc = new System.Windows.Forms.ComboBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.tbxTrieuChung = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxTenBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxMaPhieuKham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "LẬP PHIẾU KHÁM BỆNH";
            // 
            // cbxLoaiBenh
            // 
            this.cbxLoaiBenh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLoaiBenh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLoaiBenh.FormattingEnabled = true;
            this.cbxLoaiBenh.Location = new System.Drawing.Point(780, 199);
            this.cbxLoaiBenh.Name = "cbxLoaiBenh";
            this.cbxLoaiBenh.Size = new System.Drawing.Size(170, 24);
            this.cbxLoaiBenh.TabIndex = 25;
            // 
            // lbStatusTimBenhNhan
            // 
            this.lbStatusTimBenhNhan.AutoSize = true;
            this.lbStatusTimBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusTimBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.lbStatusTimBenhNhan.Location = new System.Drawing.Point(206, 166);
            this.lbStatusTimBenhNhan.Name = "lbStatusTimBenhNhan";
            this.lbStatusTimBenhNhan.Size = new System.Drawing.Size(12, 17);
            this.lbStatusTimBenhNhan.TabIndex = 27;
            this.lbStatusTimBenhNhan.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnXoaThuoc);
            this.groupBox1.Controls.Add(this.btnThemThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1231, 367);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kê thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrvDSThuoc);
            this.groupBox3.Location = new System.Drawing.Point(519, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(704, 342);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toa thuốc";
            // 
            // dgrvDSThuoc
            // 
            this.dgrvDSThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvDSThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgrvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDSThuoc.Location = new System.Drawing.Point(25, 26);
            this.dgrvDSThuoc.Name = "dgrvDSThuoc";
            this.dgrvDSThuoc.ReadOnly = true;
            this.dgrvDSThuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgrvDSThuoc.RowTemplate.Height = 24;
            this.dgrvDSThuoc.Size = new System.Drawing.Size(660, 300);
            this.dgrvDSThuoc.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTenThuoc);
            this.groupBox2.Controls.Add(this.tbxSoLuong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 249);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm thuốc vào toa";
            // 
            // cbxTenThuoc
            // 
            this.cbxTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenThuoc.FormattingEnabled = true;
            this.cbxTenThuoc.Location = new System.Drawing.Point(123, 68);
            this.cbxTenThuoc.Name = "cbxTenThuoc";
            this.cbxTenThuoc.Size = new System.Drawing.Size(170, 27);
            this.cbxTenThuoc.TabIndex = 7;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Location = new System.Drawing.Point(123, 119);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(62, 27);
            this.tbxSoLuong.TabIndex = 8;
            this.tbxSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSoLuong_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên thuốc:";
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.Color.White;
            this.btnXoaThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaThuoc.Image")));
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(343, 217);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(169, 44);
            this.btnXoaThuoc.TabIndex = 10;
            this.btnXoaThuoc.Text = "    Xóa thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.White;
            this.btnThemThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemThuoc.Image")));
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(343, 154);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(170, 42);
            this.btnThemThuoc.TabIndex = 9;
            this.btnThemThuoc.Text = "Thêm >>";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // tbxTrieuChung
            // 
            this.tbxTrieuChung.Location = new System.Drawing.Point(209, 196);
            this.tbxTrieuChung.Multiline = true;
            this.tbxTrieuChung.Name = "tbxTrieuChung";
            this.tbxTrieuChung.Size = new System.Drawing.Size(271, 62);
            this.tbxTrieuChung.TabIndex = 24;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1034, 673);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(170, 44);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "     Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(209, 141);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(200, 22);
            this.tbxMaBenhNhan.TabIndex = 22;
            this.tbxMaBenhNhan.Leave += new System.EventHandler(this.tbxMaBenhNhan_Leave);
            // 
            // tbxTenBenhNhan
            // 
            this.tbxTenBenhNhan.Enabled = false;
            this.tbxTenBenhNhan.Location = new System.Drawing.Point(780, 140);
            this.tbxTenBenhNhan.Name = "tbxTenBenhNhan";
            this.tbxTenBenhNhan.ReadOnly = true;
            this.tbxTenBenhNhan.Size = new System.Drawing.Size(271, 22);
            this.tbxTenBenhNhan.TabIndex = 23;
            // 
            // tbxMaPhieuKham
            // 
            this.tbxMaPhieuKham.Enabled = false;
            this.tbxMaPhieuKham.Location = new System.Drawing.Point(780, 82);
            this.tbxMaPhieuKham.Name = "tbxMaPhieuKham";
            this.tbxMaPhieuKham.ReadOnly = true;
            this.tbxMaPhieuKham.Size = new System.Drawing.Size(271, 22);
            this.tbxMaPhieuKham.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày lập phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã BN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại bệnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mã phiếu khám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Triệu chứng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên Bệnh Nhân:";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(209, 82);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayKham.TabIndex = 14;
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dtpNgayKham_ValueChanged);
            // 
            // frmLapPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 736);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxLoaiBenh);
            this.Controls.Add(this.lbStatusTimBenhNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxTrieuChung);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.tbxTenBenhNhan);
            this.Controls.Add(this.tbxMaPhieuKham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayKham);
            this.Name = "frmLapPhieuKham";
            this.Text = "frmLapPhieuKham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLoaiBenh;
        private System.Windows.Forms.Label lbStatusTimBenhNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrvDSThuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxTenThuoc;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.TextBox tbxTrieuChung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.TextBox tbxTenBenhNhan;
        private System.Windows.Forms.TextBox tbxMaPhieuKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
    }
}