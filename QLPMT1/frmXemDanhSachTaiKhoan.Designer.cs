
namespace QLPMT1
{
    partial class frmXemDanhSachTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.grvDanhSachTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // grvDanhSachTK
            // 
            this.grvDanhSachTK.AllowUserToOrderColumns = true;
            this.grvDanhSachTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDanhSachTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhSachTK.Location = new System.Drawing.Point(127, 131);
            this.grvDanhSachTK.Name = "grvDanhSachTK";
            this.grvDanhSachTK.ReadOnly = true;
            this.grvDanhSachTK.RowHeadersWidth = 51;
            this.grvDanhSachTK.RowTemplate.Height = 24;
            this.grvDanhSachTK.Size = new System.Drawing.Size(546, 265);
            this.grvDanhSachTK.TabIndex = 27;
            // 
            // frmXemThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvDanhSachTK);
            this.Name = "frmXemThongTinTaiKhoan";
            this.Text = "frmXemThongTinTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvDanhSachTK;
    }
}