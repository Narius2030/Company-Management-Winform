namespace QLConTy_Entity.PhongBan
{
    partial class FQLNhanVienPB
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
            this.gvTruongPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVienPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTruongPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // gvNhanVienPB
            // 
            this.gvNhanVienPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanVienPB.Location = new System.Drawing.Point(12, 330);
            this.gvNhanVienPB.Name = "gvNhanVienPB";
            this.gvNhanVienPB.RowHeadersWidth = 51;
            this.gvNhanVienPB.RowTemplate.Height = 24;
            this.gvNhanVienPB.Size = new System.Drawing.Size(828, 172);
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
            this.btnSua.Location = new System.Drawing.Point(116, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(271, 153);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gvTruongPhong
            // 
            this.gvTruongPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTruongPhong.Location = new System.Drawing.Point(12, 228);
            this.gvTruongPhong.Name = "gvTruongPhong";
            this.gvTruongPhong.RowHeadersWidth = 51;
            this.gvTruongPhong.RowTemplate.Height = 24;
            this.gvTruongPhong.Size = new System.Drawing.Size(828, 80);
            this.gvTruongPhong.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Trưởng Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nhân Viên";
            // 
            // FQLNhanVienPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvTruongPhong);
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
            this.Name = "FQLNhanVienPB";
            this.Text = "Quản Lý Nhân Viên Phòng Ban";
            this.Load += new System.EventHandler(this.fQLNhanVienPB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVienPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTruongPhong)).EndInit();
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
        private System.Windows.Forms.DataGridView gvTruongPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}