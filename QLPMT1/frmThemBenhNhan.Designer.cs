
namespace QLPMT1
{
    partial class frmThemBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemBenhNhan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNamSinh = new System.Windows.Forms.CheckBox();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvDanhSachBN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaBenhNhan = new System.Windows.Forms.Button();
            this.btnThemBenhNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaBenhNhan = new System.Windows.Forms.Button();
            this.dtpNamSinh = new System.Windows.Forms.DateTimePicker();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachBN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.cbxNamSinh);
            this.groupBox1.Controls.Add(this.tbxCMND);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpNamSinh);
            this.groupBox1.Controls.Add(this.rbtnNu);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.tbxSDT);
            this.groupBox1.Controls.Add(this.tbxDiaChi);
            this.groupBox1.Controls.Add(this.tbxMaBenhNhan);
            this.groupBox1.Controls.Add(this.tbxHoTen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1453, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm mới Bệnh nhân";
            // 
            // cbxNamSinh
            // 
            this.cbxNamSinh.AutoSize = true;
            this.cbxNamSinh.Enabled = false;
            this.cbxNamSinh.Location = new System.Drawing.Point(358, 248);
            this.cbxNamSinh.Name = "cbxNamSinh";
            this.cbxNamSinh.Size = new System.Drawing.Size(18, 17);
            this.cbxNamSinh.TabIndex = 7;
            this.cbxNamSinh.UseVisualStyleBackColor = true;
            this.cbxNamSinh.CheckedChanged += new System.EventHandler(this.cbxNamSinh_CheckedChanged);
            // 
            // tbxCMND
            // 
            this.tbxCMND.Location = new System.Drawing.Point(187, 146);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(226, 30);
            this.tbxCMND.TabIndex = 3;
            this.tbxCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCMND_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "CMND";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvDanhSachBN);
            this.groupBox3.Location = new System.Drawing.Point(674, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 377);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách bệnh nhân";
            // 
            // grvDanhSachBN
            // 
            this.grvDanhSachBN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDanhSachBN.ColumnHeadersHeight = 29;
            this.grvDanhSachBN.Location = new System.Drawing.Point(6, 34);
            this.grvDanhSachBN.Name = "grvDanhSachBN";
            this.grvDanhSachBN.ReadOnly = true;
            this.grvDanhSachBN.RowHeadersWidth = 51;
            this.grvDanhSachBN.RowTemplate.Height = 24;
            this.grvDanhSachBN.Size = new System.Drawing.Size(742, 329);
            this.grvDanhSachBN.TabIndex = 15;
            this.grvDanhSachBN.VirtualMode = true;
            this.grvDanhSachBN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhSachBN_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnXoaBenhNhan);
            this.groupBox2.Controls.Add(this.btnThemBenhNhan);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnSuaBenhNhan);
            this.groupBox2.Location = new System.Drawing.Point(469, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 338);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(30, 224);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 47);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "  Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaBenhNhan
            // 
            this.btnXoaBenhNhan.BackColor = System.Drawing.Color.White;
            this.btnXoaBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBenhNhan.Image")));
            this.btnXoaBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBenhNhan.Location = new System.Drawing.Point(30, 162);
            this.btnXoaBenhNhan.Name = "btnXoaBenhNhan";
            this.btnXoaBenhNhan.Size = new System.Drawing.Size(145, 47);
            this.btnXoaBenhNhan.TabIndex = 12;
            this.btnXoaBenhNhan.Text = "Xóa";
            this.btnXoaBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBenhNhan.UseVisualStyleBackColor = false;
            this.btnXoaBenhNhan.Click += new System.EventHandler(this.btnXoaBenhNhan_Click);
            // 
            // btnThemBenhNhan
            // 
            this.btnThemBenhNhan.BackColor = System.Drawing.Color.White;
            this.btnThemBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBenhNhan.Image")));
            this.btnThemBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBenhNhan.Location = new System.Drawing.Point(30, 36);
            this.btnThemBenhNhan.Name = "btnThemBenhNhan";
            this.btnThemBenhNhan.Size = new System.Drawing.Size(145, 47);
            this.btnThemBenhNhan.TabIndex = 10;
            this.btnThemBenhNhan.Text = "    Thêm +";
            this.btnThemBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBenhNhan.UseVisualStyleBackColor = false;
            this.btnThemBenhNhan.Click += new System.EventHandler(this.btnThemBenhNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(30, 282);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(145, 47);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "   Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaBenhNhan
            // 
            this.btnSuaBenhNhan.BackColor = System.Drawing.Color.White;
            this.btnSuaBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBenhNhan.Image")));
            this.btnSuaBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBenhNhan.Location = new System.Drawing.Point(30, 100);
            this.btnSuaBenhNhan.Name = "btnSuaBenhNhan";
            this.btnSuaBenhNhan.Size = new System.Drawing.Size(145, 47);
            this.btnSuaBenhNhan.TabIndex = 11;
            this.btnSuaBenhNhan.Text = "Sửa";
            this.btnSuaBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBenhNhan.UseVisualStyleBackColor = false;
            this.btnSuaBenhNhan.Click += new System.EventHandler(this.btnSuaBenhNhan_Click);
            // 
            // dtpNamSinh
            // 
            this.dtpNamSinh.CustomFormat = "yyyy";
            this.dtpNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamSinh.Location = new System.Drawing.Point(187, 238);
            this.dtpNamSinh.Name = "dtpNamSinh";
            this.dtpNamSinh.ShowUpDown = true;
            this.dtpNamSinh.Size = new System.Drawing.Size(165, 30);
            this.dtpNamSinh.TabIndex = 6;
            this.dtpNamSinh.Value = new System.DateTime(1970, 1, 1, 12, 23, 0, 0);
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(293, 188);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(59, 28);
            this.rbtnNu.TabIndex = 4;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Checked = true;
            this.rbtnNam.Location = new System.Drawing.Point(205, 190);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(73, 28);
            this.rbtnNam.TabIndex = 4;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // tbxSDT
            // 
            this.tbxSDT.Location = new System.Drawing.Point(187, 301);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(165, 30);
            this.tbxSDT.TabIndex = 6;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(187, 360);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(275, 30);
            this.tbxDiaChi.TabIndex = 6;
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(187, 51);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.ReadOnly = true;
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(226, 30);
            this.tbxMaBenhNhan.TabIndex = 1;
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxHoTen.Location = new System.Drawing.Point(187, 101);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(226, 30);
            this.tbxHoTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm sinh: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Bệnh Nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // frmThemBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThemBenhNhan";
            this.Text = "Quản lý bệnh nhân";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachBN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxNamSinh;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grvDanhSachBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoaBenhNhan;
        private System.Windows.Forms.Button btnThemBenhNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSuaBenhNhan;
        private System.Windows.Forms.DateTimePicker dtpNamSinh;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

