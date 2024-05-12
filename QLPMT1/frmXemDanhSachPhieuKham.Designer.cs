
namespace QLPMT1
{
    partial class frmXemDanhSachPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDanhSachPhieuKham));
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNgay = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxMaPhieuKham = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.grvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(48, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Click đúp để xem chi tiết";
            // 
            // cbxNgay
            // 
            this.cbxNgay.AutoSize = true;
            this.cbxNgay.Checked = true;
            this.cbxNgay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNgay.Location = new System.Drawing.Point(878, 116);
            this.cbxNgay.Name = "cbxNgay";
            this.cbxNgay.Size = new System.Drawing.Size(18, 17);
            this.cbxNgay.TabIndex = 44;
            this.cbxNgay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "SĐT:";
            // 
            // tbxSDT
            // 
            this.tbxSDT.Location = new System.Drawing.Point(672, 208);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(248, 22);
            this.tbxSDT.TabIndex = 34;
            this.tbxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSDT_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "CMND:";
            // 
            // tbxCMND
            // 
            this.tbxCMND.Location = new System.Drawing.Point(220, 208);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(248, 22);
            this.tbxCMND.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tên bệnh nhân:";
            // 
            // tbxTenBenhNhan
            // 
            this.tbxTenBenhNhan.Location = new System.Drawing.Point(672, 162);
            this.tbxTenBenhNhan.Name = "tbxTenBenhNhan";
            this.tbxTenBenhNhan.Size = new System.Drawing.Size(248, 22);
            this.tbxTenBenhNhan.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mã bệnh nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã phiếu khám:";
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(220, 162);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(248, 22);
            this.tbxMaBenhNhan.TabIndex = 30;
            // 
            // tbxMaPhieuKham
            // 
            this.tbxMaPhieuKham.Location = new System.Drawing.Point(220, 116);
            this.tbxMaPhieuKham.Name = "tbxMaPhieuKham";
            this.tbxMaPhieuKham.Size = new System.Drawing.Size(248, 22);
            this.tbxMaPhieuKham.TabIndex = 29;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(428, 245);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(177, 42);
            this.btnTraCuu.TabIndex = 35;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // grvDSBenhNhan
            // 
            this.grvDSBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSBenhNhan.Location = new System.Drawing.Point(51, 306);
            this.grvDSBenhNhan.Name = "grvDSBenhNhan";
            this.grvDSBenhNhan.ReadOnly = true;
            this.grvDSBenhNhan.RowHeadersWidth = 51;
            this.grvDSBenhNhan.RowTemplate.Height = 24;
            this.grvDSBenhNhan.Size = new System.Drawing.Size(869, 349);
            this.grvDSBenhNhan.TabIndex = 36;
            this.grvDSBenhNhan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvDSBenhNhan_CellMouseDoubleClick);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(672, 109);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 29);
            this.dtpNgay.TabIndex = 32;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ngày: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 32);
            this.label3.TabIndex = 38;
            this.label3.Text = "Danh sách khám bệnh";
            // 
            // frmXemDanhSachPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 667);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxNgay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTenBenhNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.tbxMaPhieuKham);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.grvDSBenhNhan);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmXemDanhSachPhieuKham";
            this.Text = "frmXemDanhSachPhieuKham";
            this.Enter += new System.EventHandler(this.frmXemDanhSachPhieuKham_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTenBenhNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.TextBox tbxMaPhieuKham;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView grvDSBenhNhan;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}