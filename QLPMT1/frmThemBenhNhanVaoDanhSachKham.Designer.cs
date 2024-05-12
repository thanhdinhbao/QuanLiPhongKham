
namespace QLPMT1
{
    partial class frmThemBenhNhanVaoDanhSachKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemBenhNhanVaoDanhSachKham));
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.btnXoaKhoiDS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvDanhSachKham = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemVaoDanhSach = new System.Windows.Forms.Button();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKham)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(345, 147);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(327, 30);
            this.tbxMaBenhNhan.TabIndex = 16;
            // 
            // btnXoaKhoiDS
            // 
            this.btnXoaKhoiDS.BackColor = System.Drawing.Color.White;
            this.btnXoaKhoiDS.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoiDS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoiDS.Image")));
            this.btnXoaKhoiDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKhoiDS.Location = new System.Drawing.Point(345, 260);
            this.btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            this.btnXoaKhoiDS.Size = new System.Drawing.Size(111, 52);
            this.btnXoaKhoiDS.TabIndex = 19;
            this.btnXoaKhoiDS.Text = "  Xóa";
            this.btnXoaKhoiDS.UseVisualStyleBackColor = false;
            this.btnXoaKhoiDS.Click += new System.EventHandler(this.btnXoaKhoiDS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvDanhSachKham);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(203, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 409);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khám";
            // 
            // grvDanhSachKham
            // 
            this.grvDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhSachKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grvDanhSachKham.Location = new System.Drawing.Point(6, 31);
            this.grvDanhSachKham.Name = "grvDanhSachKham";
            this.grvDanhSachKham.ReadOnly = true;
            this.grvDanhSachKham.RowHeadersWidth = 51;
            this.grvDanhSachKham.RowTemplate.Height = 24;
            this.grvDanhSachKham.Size = new System.Drawing.Size(705, 349);
            this.grvDanhSachKham.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // btnThemVaoDanhSach
            // 
            this.btnThemVaoDanhSach.BackColor = System.Drawing.Color.White;
            this.btnThemVaoDanhSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoDanhSach.Image")));
            this.btnThemVaoDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoDanhSach.Location = new System.Drawing.Point(462, 259);
            this.btnThemVaoDanhSach.Name = "btnThemVaoDanhSach";
            this.btnThemVaoDanhSach.Size = new System.Drawing.Size(210, 53);
            this.btnThemVaoDanhSach.TabIndex = 20;
            this.btnThemVaoDanhSach.Text = "Thêm bệnh nhân";
            this.btnThemVaoDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoDanhSach.UseVisualStyleBackColor = false;
            this.btnThemVaoDanhSach.Click += new System.EventHandler(this.btnThemVaoDanhSach_Click);
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(345, 99);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(179, 26);
            this.dtpNgayKham.TabIndex = 17;
            this.dtpNgayKham.Value = new System.DateTime(2024, 5, 8, 0, 0, 0, 0);
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dtpNgayKham_ValueChanged);
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoTen.Location = new System.Drawing.Point(345, 206);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.ReadOnly = true;
            this.tbxHoTen.Size = new System.Drawing.Size(327, 30);
            this.tbxHoTen.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(218, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày khám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(218, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(218, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã BN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ DANH SÁCH KHÁM";
            // 
            // frmThemBenhNhanVaoDanhSachKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 785);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.btnXoaKhoiDS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemVaoDanhSach);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.tbxHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemBenhNhanVaoDanhSachKham";
            this.Text = "frmThemBenhNhanVaoDanhSachKham";
            this.Load += new System.EventHandler(this.frmThemBenhNhanVaoDanhSachKham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.Button btnXoaKhoiDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvDanhSachKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnThemVaoDanhSach;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}