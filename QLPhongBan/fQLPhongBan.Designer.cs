namespace QLCongTy
{
    partial class FQLPhongBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaTruongPhong = new System.Windows.Forms.TextBox();
            this.txtTenTruongPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.artanPannel1 = new ArtanComponent.ArtanPannel();
            this.gvPhongBan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.artanPannel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(451, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Trưởng Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(451, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Trưởng Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng Ban:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Phòng Ban:";
            // 
            // txtMaTruongPhong
            // 
            this.txtMaTruongPhong.Location = new System.Drawing.Point(665, 37);
            this.txtMaTruongPhong.Name = "txtMaTruongPhong";
            this.txtMaTruongPhong.Size = new System.Drawing.Size(192, 22);
            this.txtMaTruongPhong.TabIndex = 9;
            // 
            // txtTenTruongPhong
            // 
            this.txtTenTruongPhong.Location = new System.Drawing.Point(665, 115);
            this.txtTenTruongPhong.Name = "txtTenTruongPhong";
            this.txtTenTruongPhong.Size = new System.Drawing.Size(192, 22);
            this.txtTenTruongPhong.TabIndex = 9;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(185, 39);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(192, 22);
            this.txtMaPhongBan.TabIndex = 10;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(185, 115);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(192, 22);
            this.txtTenPhongBan.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(169, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(433, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(578, 183);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 40);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // artanPannel1
            // 
            this.artanPannel1.BackColor = System.Drawing.Color.White;
            this.artanPannel1.BorderRadius = 20;
            this.artanPannel1.Controls.Add(this.gvPhongBan);
            this.artanPannel1.ForeColor = System.Drawing.Color.Black;
            this.artanPannel1.GradientAngle = 90F;
            this.artanPannel1.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel1.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.artanPannel1.Location = new System.Drawing.Point(136, 313);
            this.artanPannel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artanPannel1.Name = "artanPannel1";
            this.artanPannel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel1.Size = new System.Drawing.Size(785, 272);
            this.artanPannel1.TabIndex = 27;
            // 
            // gvPhongBan
            // 
            this.gvPhongBan.AllowUserToAddRows = false;
            this.gvPhongBan.AllowUserToDeleteRows = false;
            this.gvPhongBan.AllowUserToResizeColumns = false;
            this.gvPhongBan.AllowUserToResizeRows = false;
            this.gvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvPhongBan.BackgroundColor = System.Drawing.Color.White;
            this.gvPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPhongBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvPhongBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvPhongBan.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhongBan.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPhongBan.EnableHeadersVisualStyles = false;
            this.gvPhongBan.GridColor = System.Drawing.Color.LightGray;
            this.gvPhongBan.Location = new System.Drawing.Point(10, 10);
            this.gvPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvPhongBan.MultiSelect = false;
            this.gvPhongBan.Name = "gvPhongBan";
            this.gvPhongBan.ReadOnly = true;
            this.gvPhongBan.RowHeadersVisible = false;
            this.gvPhongBan.RowHeadersWidth = 50;
            this.gvPhongBan.RowTemplate.Height = 25;
            this.gvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPhongBan.Size = new System.Drawing.Size(765, 252);
            this.gvPhongBan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaPhongBan);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTenPhongBan);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaTruongPhong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenTruongPhong);
            this.panel1.Location = new System.Drawing.Point(76, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 263);
            this.panel1.TabIndex = 28;
            // 
            // FQLPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1337, 772);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.artanPannel1);
            this.Name = "FQLPhongBan";
            this.Text = "Quản Lý Phòng Ban";
            this.Load += new System.EventHandler(this.fQLPhongBan_Load);
            this.artanPannel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaTruongPhong;
        private System.Windows.Forms.TextBox txtTenTruongPhong;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private ArtanComponent.ArtanPannel artanPannel1;
        private System.Windows.Forms.DataGridView gvPhongBan;
        private System.Windows.Forms.Panel panel1;
    }
}