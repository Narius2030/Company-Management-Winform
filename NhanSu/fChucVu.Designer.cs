namespace QLCongTy
{
    partial class fChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.txtThongTinLoc = new System.Windows.Forms.TextBox();
            this.grpLocThongTin = new System.Windows.Forms.GroupBox();
            this.artanPannel = new ArtanComponent.ArtanPannel();
            this.gvChucVu = new System.Windows.Forms.DataGridView();
            this.btnReload = new QLCongTy.VBButton();
            this.btnLoc = new QLCongTy.VBButton();
            this.btnSua = new QLCongTy.VBButton();
            this.btnXoa = new QLCongTy.VBButton();
            this.btnThem = new QLCongTy.VBButton();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.grpLocThongTin.SuspendLayout();
            this.artanPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChucVu)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(164, 129);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(198, 27);
            this.txtTenChucVu.TabIndex = 4;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(164, 49);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(198, 27);
            this.txtMaChucVu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Chức Vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chức Vụ";
            // 
            // cboLoc
            // 
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Items.AddRange(new object[] {
            "Mã chức vụ",
            "Tên chức vụ"});
            this.cboLoc.Location = new System.Drawing.Point(31, 33);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(132, 27);
            this.cboLoc.TabIndex = 3;
            // 
            // txtThongTinLoc
            // 
            this.txtThongTinLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinLoc.Location = new System.Drawing.Point(31, 76);
            this.txtThongTinLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongTinLoc.Name = "txtThongTinLoc";
            this.txtThongTinLoc.Size = new System.Drawing.Size(307, 32);
            this.txtThongTinLoc.TabIndex = 1;
            // 
            // grpLocThongTin
            // 
            this.grpLocThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpLocThongTin.Controls.Add(this.btnReload);
            this.grpLocThongTin.Controls.Add(this.cboLoc);
            this.grpLocThongTin.Controls.Add(this.btnLoc);
            this.grpLocThongTin.Controls.Add(this.txtThongTinLoc);
            this.grpLocThongTin.Location = new System.Drawing.Point(23, 281);
            this.grpLocThongTin.Name = "grpLocThongTin";
            this.grpLocThongTin.Size = new System.Drawing.Size(370, 206);
            this.grpLocThongTin.TabIndex = 86;
            this.grpLocThongTin.TabStop = false;
            this.grpLocThongTin.Text = "Lọc thông tin";
            // 
            // artanPannel
            // 
            this.artanPannel.BackColor = System.Drawing.Color.White;
            this.artanPannel.BorderRadius = 30;
            this.artanPannel.Controls.Add(this.gvChucVu);
            this.artanPannel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artanPannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(180)))));
            this.artanPannel.GradientAngle = 90F;
            this.artanPannel.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(95)))), ((int)(((byte)(231)))));
            this.artanPannel.Location = new System.Drawing.Point(538, 21);
            this.artanPannel.Name = "artanPannel";
            this.artanPannel.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel.Size = new System.Drawing.Size(395, 497);
            this.artanPannel.TabIndex = 88;
            // 
            // gvChucVu
            // 
            this.gvChucVu.AllowUserToResizeColumns = false;
            this.gvChucVu.AllowUserToResizeRows = false;
            this.gvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvChucVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvChucVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvChucVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvChucVu.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChucVu.EnableHeadersVisualStyles = false;
            this.gvChucVu.Location = new System.Drawing.Point(10, 10);
            this.gvChucVu.MultiSelect = false;
            this.gvChucVu.Name = "gvChucVu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(149)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvChucVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvChucVu.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.gvChucVu.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvChucVu.RowTemplate.DividerHeight = 2;
            this.gvChucVu.RowTemplate.Height = 24;
            this.gvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvChucVu.Size = new System.Drawing.Size(375, 477);
            this.gvChucVu.TabIndex = 56;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Azure;
            this.btnReload.BackgroundColor = System.Drawing.Color.Azure;
            this.btnReload.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReload.BorderRadius = 10;
            this.btnReload.BorderSize = 1;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(238, 139);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 48);
            this.btnReload.TabIndex = 85;
            this.btnReload.Text = "Reload";
            this.btnReload.TextColor = System.Drawing.Color.Black;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Azure;
            this.btnLoc.BackgroundColor = System.Drawing.Color.Azure;
            this.btnLoc.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoc.BorderRadius = 10;
            this.btnLoc.BorderSize = 1;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Location = new System.Drawing.Point(31, 139);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(100, 48);
            this.btnLoc.TabIndex = 84;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextColor = System.Drawing.Color.Black;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Azure;
            this.btnSua.BackgroundColor = System.Drawing.Color.Azure;
            this.btnSua.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 1;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(262, 194);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 48);
            this.btnSua.TabIndex = 83;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Azure;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Azure;
            this.btnXoa.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(141, 194);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 48);
            this.btnXoa.TabIndex = 82;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Azure;
            this.btnThem.BackgroundColor = System.Drawing.Color.Azure;
            this.btnThem.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 1;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(23, 194);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 48);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Controls.Add(this.label2);
            this.pnlChucNang.Controls.Add(this.txtMaChucVu);
            this.pnlChucNang.Controls.Add(this.grpLocThongTin);
            this.pnlChucNang.Controls.Add(this.label3);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.txtTenChucVu);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Location = new System.Drawing.Point(33, 21);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(464, 506);
            this.pnlChucNang.TabIndex = 89;
            // 
            // fChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(989, 585);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.artanPannel);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fChucVu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.FChucVu_Load);
            this.grpLocThongTin.ResumeLayout(false);
            this.grpLocThongTin.PerformLayout();
            this.artanPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChucVu)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.pnlChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThongTinLoc;
        private System.Windows.Forms.ComboBox cboLoc;
        private VBButton btnThem;
        private VBButton btnXoa;
        private VBButton btnSua;
        private VBButton btnLoc;
        private VBButton btnReload;
        private System.Windows.Forms.GroupBox grpLocThongTin;
        private ArtanComponent.ArtanPannel artanPannel;
        private System.Windows.Forms.DataGridView gvChucVu;
        private System.Windows.Forms.Panel pnlChucNang;
    }
}