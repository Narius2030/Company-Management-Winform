namespace QLCongTy
{
    partial class fQLDuAn
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
            this.tabQLDA = new System.Windows.Forms.TabControl();
            this.tpQLDA = new System.Windows.Forms.TabPage();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaTruongDA = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gvQLDuAn = new System.Windows.Forms.DataGridView();
            this.tpPCDA = new System.Windows.Forms.TabPage();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhanlucDA = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gvPCDuAn = new System.Windows.Forms.DataGridView();
            this.tpNhanlucsanco = new System.Windows.Forms.TabPage();
            this.btnThemNVvaoDA = new System.Windows.Forms.Button();
            this.gvNhanLuc = new System.Windows.Forms.DataGridView();
            this.cboTrinhDo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabQLDA.SuspendLayout();
            this.tpQLDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLDuAn)).BeginInit();
            this.tpPCDA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpNhanlucDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPCDuAn)).BeginInit();
            this.tpNhanlucsanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanLuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabQLDA
            // 
            this.tabQLDA.Controls.Add(this.tpQLDA);
            this.tabQLDA.Controls.Add(this.tpPCDA);
            this.tabQLDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQLDA.Location = new System.Drawing.Point(0, 0);
            this.tabQLDA.Name = "tabQLDA";
            this.tabQLDA.SelectedIndex = 0;
            this.tabQLDA.Size = new System.Drawing.Size(1195, 692);
            this.tabQLDA.TabIndex = 56;
            // 
            // tpQLDA
            // 
            this.tpQLDA.Controls.Add(this.cboTrangThai);
            this.tpQLDA.Controls.Add(this.label12);
            this.tpQLDA.Controls.Add(this.dtpNgayKetThuc);
            this.tpQLDA.Controls.Add(this.dtpNgayBatDau);
            this.tpQLDA.Controls.Add(this.label11);
            this.tpQLDA.Controls.Add(this.label10);
            this.tpQLDA.Controls.Add(this.btnTimKiem);
            this.tpQLDA.Controls.Add(this.btnSua);
            this.tpQLDA.Controls.Add(this.btnXoa);
            this.tpQLDA.Controls.Add(this.btnThem);
            this.tpQLDA.Controls.Add(this.txtMaTruongDA);
            this.tpQLDA.Controls.Add(this.txtMaPB);
            this.tpQLDA.Controls.Add(this.txtTenDA);
            this.tpQLDA.Controls.Add(this.txtMaDA);
            this.tpQLDA.Controls.Add(this.label1);
            this.tpQLDA.Controls.Add(this.label2);
            this.tpQLDA.Controls.Add(this.label3);
            this.tpQLDA.Controls.Add(this.label4);
            this.tpQLDA.Controls.Add(this.gvQLDuAn);
            this.tpQLDA.Location = new System.Drawing.Point(4, 25);
            this.tpQLDA.Name = "tpQLDA";
            this.tpQLDA.Padding = new System.Windows.Forms.Padding(3);
            this.tpQLDA.Size = new System.Drawing.Size(1187, 663);
            this.tpQLDA.TabIndex = 0;
            this.tpQLDA.Text = "Dự Án";
            this.tpQLDA.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Bắt đầu",
            "Kế hoạch",
            "Thực hiện",
            "Kết thúc"});
            this.cboTrangThai.Location = new System.Drawing.Point(855, 51);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(129, 24);
            this.cboTrangThai.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(776, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 73;
            this.label12.Text = "Trạng thái: ";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(557, 112);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(164, 22);
            this.dtpNgayKetThuc.TabIndex = 72;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(103, 107);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(164, 22);
            this.dtpNgayBatDau.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Ngày kết thúc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Ngày bắt đầu";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(490, 183);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 68;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(330, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 67;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(168, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 66;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(42, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 65;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaTruongDA
            // 
            this.txtMaTruongDA.Location = new System.Drawing.Point(557, 48);
            this.txtMaTruongDA.Name = "txtMaTruongDA";
            this.txtMaTruongDA.Size = new System.Drawing.Size(164, 22);
            this.txtMaTruongDA.TabIndex = 64;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(557, 8);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(164, 22);
            this.txtMaPB.TabIndex = 63;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(93, 48);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(150, 22);
            this.txtTenDA.TabIndex = 62;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(93, 2);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(150, 22);
            this.txtMaDA.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Mã Trưởng Dự Án:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã Phòng Ban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tên Dự Án:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Mã Dự Án";
            // 
            // gvQLDuAn
            // 
            this.gvQLDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQLDuAn.Location = new System.Drawing.Point(42, 256);
            this.gvQLDuAn.Name = "gvQLDuAn";
            this.gvQLDuAn.RowHeadersWidth = 51;
            this.gvQLDuAn.RowTemplate.Height = 24;
            this.gvQLDuAn.Size = new System.Drawing.Size(848, 231);
            this.gvQLDuAn.TabIndex = 56;
            this.gvQLDuAn.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DuAn_Row_Click);
            // 
            // tpPCDA
            // 
            this.tpPCDA.Controls.Add(this.txtTenNV);
            this.tpPCDA.Controls.Add(this.label9);
            this.tpPCDA.Controls.Add(this.dtpFinish);
            this.tpPCDA.Controls.Add(this.dtpStart);
            this.tpPCDA.Controls.Add(this.label8);
            this.tpPCDA.Controls.Add(this.label7);
            this.tpPCDA.Controls.Add(this.txtMaNV);
            this.tpPCDA.Controls.Add(this.lblTenDA);
            this.tpPCDA.Controls.Add(this.panel1);
            this.tpPCDA.Controls.Add(this.label5);
            this.tpPCDA.Location = new System.Drawing.Point(4, 25);
            this.tpPCDA.Name = "tpPCDA";
            this.tpPCDA.Padding = new System.Windows.Forms.Padding(3);
            this.tpPCDA.Size = new System.Drawing.Size(1187, 663);
            this.tpPCDA.TabIndex = 1;
            this.tpPCDA.Text = "Phân Công";
            this.tpPCDA.UseVisualStyleBackColor = true;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(491, 122);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(200, 22);
            this.dtpFinish.TabIndex = 66;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(491, 77);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 22);
            this.dtpStart.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Start: ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(128, 116);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(163, 22);
            this.txtMaNV.TabIndex = 59;
            // 
            // lblTenDA
            // 
            this.lblTenDA.BackColor = System.Drawing.Color.LightGray;
            this.lblTenDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDA.Location = new System.Drawing.Point(6, 0);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(1175, 65);
            this.lblTenDA.TabIndex = 58;
            this.lblTenDA.Text = "Tên dự án";
            this.lblTenDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(33, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 372);
            this.panel1.TabIndex = 57;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhanlucDA);
            this.tabControl1.Controls.Add(this.tpNhanlucsanco);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 366);
            this.tabControl1.TabIndex = 58;
            // 
            // tpNhanlucDA
            // 
            this.tpNhanlucDA.Controls.Add(this.btnRemove);
            this.tpNhanlucDA.Controls.Add(this.gvPCDuAn);
            this.tpNhanlucDA.Location = new System.Drawing.Point(4, 25);
            this.tpNhanlucDA.Name = "tpNhanlucDA";
            this.tpNhanlucDA.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanlucDA.Size = new System.Drawing.Size(1104, 337);
            this.tpNhanlucDA.TabIndex = 0;
            this.tpNhanlucDA.Text = "Nhân lực dự án";
            this.tpNhanlucDA.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(19, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 32);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // gvPCDuAn
            // 
            this.gvPCDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPCDuAn.Location = new System.Drawing.Point(6, 57);
            this.gvPCDuAn.Name = "gvPCDuAn";
            this.gvPCDuAn.RowHeadersWidth = 51;
            this.gvPCDuAn.RowTemplate.Height = 24;
            this.gvPCDuAn.Size = new System.Drawing.Size(1092, 262);
            this.gvPCDuAn.TabIndex = 2;
            // 
            // tpNhanlucsanco
            // 
            this.tpNhanlucsanco.Controls.Add(this.btnThemNVvaoDA);
            this.tpNhanlucsanco.Controls.Add(this.gvNhanLuc);
            this.tpNhanlucsanco.Controls.Add(this.cboTrinhDo);
            this.tpNhanlucsanco.Controls.Add(this.label6);
            this.tpNhanlucsanco.Location = new System.Drawing.Point(4, 25);
            this.tpNhanlucsanco.Name = "tpNhanlucsanco";
            this.tpNhanlucsanco.Padding = new System.Windows.Forms.Padding(3);
            this.tpNhanlucsanco.Size = new System.Drawing.Size(1104, 337);
            this.tpNhanlucsanco.TabIndex = 1;
            this.tpNhanlucsanco.Text = "Nhân lực sẵn có";
            this.tpNhanlucsanco.UseVisualStyleBackColor = true;
            // 
            // btnThemNVvaoDA
            // 
            this.btnThemNVvaoDA.Location = new System.Drawing.Point(309, 10);
            this.btnThemNVvaoDA.Name = "btnThemNVvaoDA";
            this.btnThemNVvaoDA.Size = new System.Drawing.Size(85, 30);
            this.btnThemNVvaoDA.TabIndex = 63;
            this.btnThemNVvaoDA.Text = "ADD";
            this.btnThemNVvaoDA.UseVisualStyleBackColor = true;
            this.btnThemNVvaoDA.Click += new System.EventHandler(this.btnThemNVvaoDA_Click);
            // 
            // gvNhanLuc
            // 
            this.gvNhanLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanLuc.Location = new System.Drawing.Point(6, 56);
            this.gvNhanLuc.Name = "gvNhanLuc";
            this.gvNhanLuc.RowHeadersWidth = 51;
            this.gvNhanLuc.RowTemplate.Height = 24;
            this.gvNhanLuc.Size = new System.Drawing.Size(1092, 264);
            this.gvNhanLuc.TabIndex = 0;
            this.gvNhanLuc.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.NhanLuc_Row_Click);
            // 
            // cboTrinhDo
            // 
            this.cboTrinhDo.FormattingEnabled = true;
            this.cboTrinhDo.Items.AddRange(new object[] {
            "Senior",
            "Junior",
            "Fresher",
            "Intership"});
            this.cboTrinhDo.Location = new System.Drawing.Point(85, 14);
            this.cboTrinhDo.Name = "cboTrinhDo";
            this.cboTrinhDo.Size = new System.Drawing.Size(163, 24);
            this.cboTrinhDo.TabIndex = 62;
            this.cboTrinhDo.SelectedIndexChanged += new System.EventHandler(this.cboTrinhDo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Trình độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(128, 168);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(163, 22);
            this.txtTenNV.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Tên nhân viên";
            // 
            // fQLDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 692);
            this.Controls.Add(this.tabQLDA);
            this.Name = "fQLDuAn";
            this.Text = "Quản Lý Dự Án";
            this.Load += new System.EventHandler(this.fQLDuAn_Load);
            this.tabQLDA.ResumeLayout(false);
            this.tpQLDA.ResumeLayout(false);
            this.tpQLDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLDuAn)).EndInit();
            this.tpPCDA.ResumeLayout(false);
            this.tpPCDA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpNhanlucDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPCDuAn)).EndInit();
            this.tpNhanlucsanco.ResumeLayout(false);
            this.tpNhanlucsanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanLuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQLDA;
        private System.Windows.Forms.TabPage tpQLDA;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaTruongDA;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvQLDuAn;
        private System.Windows.Forms.TabPage tpPCDA;
        private System.Windows.Forms.DataGridView gvPCDuAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvNhanLuc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhanlucDA;
        private System.Windows.Forms.TabPage tpNhanlucsanco;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrinhDo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnThemNVvaoDA;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label9;
    }
}