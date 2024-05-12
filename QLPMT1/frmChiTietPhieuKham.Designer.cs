
namespace QLPMT1
{
    partial class frmChiTietPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuKham));
            this.btnXoaPhieuKham = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.tbxNgayKham = new System.Windows.Forms.TextBox();
            this.tbxLoaiBenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grvDSThuoc = new System.Windows.Forms.DataGridView();
            this.tbxTrieuChung = new System.Windows.Forms.TextBox();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxTenBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxMaPhieuKham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaPhieuKham
            // 
            this.btnXoaPhieuKham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuKham.Location = new System.Drawing.Point(636, 681);
            this.btnXoaPhieuKham.Name = "btnXoaPhieuKham";
            this.btnXoaPhieuKham.Size = new System.Drawing.Size(170, 32);
            this.btnXoaPhieuKham.TabIndex = 46;
            this.btnXoaPhieuKham.Text = "Xóa phiếu khám";
            this.btnXoaPhieuKham.UseVisualStyleBackColor = true;
            this.btnXoaPhieuKham.Click += new System.EventHandler(this.btnXoaPhieuKham_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(871, 694);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(170, 32);
            this.btnIn.TabIndex = 45;
            this.btnIn.Text = "In phiếu";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tbxNgayKham
            // 
            this.tbxNgayKham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxNgayKham.Location = new System.Drawing.Point(291, 68);
            this.tbxNgayKham.Name = "tbxNgayKham";
            this.tbxNgayKham.ReadOnly = true;
            this.tbxNgayKham.Size = new System.Drawing.Size(200, 22);
            this.tbxNgayKham.TabIndex = 44;
            // 
            // tbxLoaiBenh
            // 
            this.tbxLoaiBenh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxLoaiBenh.Location = new System.Drawing.Point(291, 200);
            this.tbxLoaiBenh.Name = "tbxLoaiBenh";
            this.tbxLoaiBenh.ReadOnly = true;
            this.tbxLoaiBenh.Size = new System.Drawing.Size(200, 22);
            this.tbxLoaiBenh.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "CHI TIẾT PHIẾU KHÁM - ĐƠN THUỐC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grvDSThuoc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(89, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(976, 342);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn thuốc";
            // 
            // grvDSThuoc
            // 
            this.grvDSThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvDSThuoc.BackgroundColor = System.Drawing.Color.White;
            this.grvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSThuoc.Location = new System.Drawing.Point(15, 27);
            this.grvDSThuoc.Name = "grvDSThuoc";
            this.grvDSThuoc.ReadOnly = true;
            this.grvDSThuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grvDSThuoc.RowTemplate.Height = 24;
            this.grvDSThuoc.Size = new System.Drawing.Size(937, 300);
            this.grvDSThuoc.TabIndex = 0;
            // 
            // tbxTrieuChung
            // 
            this.tbxTrieuChung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxTrieuChung.Location = new System.Drawing.Point(748, 206);
            this.tbxTrieuChung.Multiline = true;
            this.tbxTrieuChung.Name = "tbxTrieuChung";
            this.tbxTrieuChung.ReadOnly = true;
            this.tbxTrieuChung.Size = new System.Drawing.Size(271, 62);
            this.tbxTrieuChung.TabIndex = 38;
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(291, 133);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.ReadOnly = true;
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(200, 22);
            this.tbxMaBenhNhan.TabIndex = 39;
            // 
            // tbxTenBenhNhan
            // 
            this.tbxTenBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxTenBenhNhan.Location = new System.Drawing.Point(748, 138);
            this.tbxTenBenhNhan.Name = "tbxTenBenhNhan";
            this.tbxTenBenhNhan.ReadOnly = true;
            this.tbxTenBenhNhan.Size = new System.Drawing.Size(271, 22);
            this.tbxTenBenhNhan.TabIndex = 40;
            // 
            // tbxMaPhieuKham
            // 
            this.tbxMaPhieuKham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxMaPhieuKham.Location = new System.Drawing.Point(748, 68);
            this.tbxMaPhieuKham.Name = "tbxMaPhieuKham";
            this.tbxMaPhieuKham.ReadOnly = true;
            this.tbxMaPhieuKham.Size = new System.Drawing.Size(271, 22);
            this.tbxMaPhieuKham.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ngày khám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã BN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Chuẩn đoán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã phiếu khám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Triệu chứng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tên Bệnh Nhân:";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmChiTietPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 762);
            this.Controls.Add(this.btnXoaPhieuKham);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.tbxNgayKham);
            this.Controls.Add(this.tbxLoaiBenh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbxTrieuChung);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.tbxTenBenhNhan);
            this.Controls.Add(this.tbxMaPhieuKham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmChiTietPhieuKham";
            this.Text = "frmChiTietPhieuKham";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaPhieuKham;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox tbxNgayKham;
        private System.Windows.Forms.TextBox tbxLoaiBenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grvDSThuoc;
        private System.Windows.Forms.TextBox tbxTrieuChung;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.TextBox tbxTenBenhNhan;
        private System.Windows.Forms.TextBox tbxMaPhieuKham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}