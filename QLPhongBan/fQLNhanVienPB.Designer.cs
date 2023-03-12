namespace QLCongTy
{
    partial class fQLNhanVienPB
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
            this.gvNhanVienPB = new System.Windows.Forms.DataGridView();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVienPB)).BeginInit();
            this.SuspendLayout();
            // 
            // gvNhanVienPB
            // 
            this.gvNhanVienPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanVienPB.Location = new System.Drawing.Point(20, 218);
            this.gvNhanVienPB.Name = "gvNhanVienPB";
            this.gvNhanVienPB.RowHeadersWidth = 51;
            this.gvNhanVienPB.RowTemplate.Height = 24;
            this.gvNhanVienPB.Size = new System.Drawing.Size(828, 208);
            this.gvNhanVienPB.TabIndex = 2;
            this.gvNhanVienPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhanVienPB_CellClick);
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(17, 59);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(98, 16);
            this.lblMaPB.TabIndex = 5;
            this.lblMaPB.Text = "Mã Phòng Ban:";
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(185, 59);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(192, 22);
            this.txtMaPhongBan.TabIndex = 11;
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(17, 105);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(103, 16);
            this.lblTenPB.TabIndex = 12;
            this.lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(185, 105);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(192, 22);
            this.txtTenPhongBan.TabIndex = 13;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(474, 59);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(94, 16);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(656, 105);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(192, 22);
            this.txtTenNhanVien.TabIndex = 16;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(656, 59);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(192, 22);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(474, 105);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(99, 16);
            this.lblTenNhanVien.TabIndex = 18;
            this.lblTenNhanVien.Text = "Tên Nhân Viên:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(272, 173);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // fQLNhanVienPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 438);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtTenPhongBan);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.txtMaPhongBan);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.gvNhanVienPB);
            this.Name = "fQLNhanVienPB";
            this.Text = "Quản Lý Nhân Viên Phòng Ban";
            this.Load += new System.EventHandler(this.fQLNhanVienPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVienPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvNhanVienPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
    }
}