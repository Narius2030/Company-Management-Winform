namespace QLCongTy.NhanSu
{
    partial class FNhanSu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpLocThongTin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThongTinLoc = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLocKhac = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new FontAwesome.Sharp.IconButton();
            this.tmSidebar = new System.Windows.Forms.Timer(this.components);
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.tmThongKe = new System.Windows.Forms.Timer(this.components);
            this.tmDangKy = new System.Windows.Forms.Timer(this.components);
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlDangKy = new System.Windows.Forms.Panel();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboGTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chartLayLuongThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSua = new QLCongTy.VBButton();
            this.btnXoa = new QLCongTy.VBButton();
            this.btnThem = new QLCongTy.VBButton();
            this.artanPannel1 = new ArtanComponent.ArtanPannel();
            this.gvNhanSu = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoc = new QLCongTy.VBButton();
            this.btnReload = new QLCongTy.VBButton();
            this.grpLocThongTin.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.pnlDangKy.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLayLuongThang)).BeginInit();
            this.artanPannel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLocThongTin
            // 
            this.grpLocThongTin.BackColor = System.Drawing.Color.Transparent;
            this.grpLocThongTin.Controls.Add(this.btnLoc);
            this.grpLocThongTin.Controls.Add(this.btnReload);
            this.grpLocThongTin.Controls.Add(this.label4);
            this.grpLocThongTin.Controls.Add(this.cboPhongBan);
            this.grpLocThongTin.Controls.Add(this.label13);
            this.grpLocThongTin.Controls.Add(this.txtThongTinLoc);
            this.grpLocThongTin.Controls.Add(this.cboChucVu);
            this.grpLocThongTin.Controls.Add(this.label8);
            this.grpLocThongTin.Controls.Add(this.cboLocKhac);
            this.grpLocThongTin.Controls.Add(this.cboGioiTinh);
            this.grpLocThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLocThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLocThongTin.ForeColor = System.Drawing.Color.White;
            this.grpLocThongTin.Location = new System.Drawing.Point(60, 48);
            this.grpLocThongTin.Name = "grpLocThongTin";
            this.grpLocThongTin.Size = new System.Drawing.Size(1180, 186);
            this.grpLocThongTin.TabIndex = 4;
            this.grpLocThongTin.TabStop = false;
            this.grpLocThongTin.Text = "Lọc Thông Tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phòng Ban";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Items.AddRange(new object[] {
            "P001 - Nhân Sự",
            "P002 - Tài Chính Kế Toán",
            "P003 - Quản Lý",
            "P004 - Hành Chính",
            "P005 - Sản Xuất",
            "P006 - Marketing",
            "P007 - Giám Đốc"});
            this.cboPhongBan.Location = new System.Drawing.Point(148, 46);
            this.cboPhongBan.Margin = new System.Windows.Forms.Padding(2);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(140, 36);
            this.cboPhongBan.TabIndex = 3;
            this.cboPhongBan.SelectedIndexChanged += new System.EventHandler(this.cboPhongBan_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(37, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Giới Tính";
            // 
            // txtThongTinLoc
            // 
            this.txtThongTinLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinLoc.Location = new System.Drawing.Point(379, 88);
            this.txtThongTinLoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongTinLoc.Name = "txtThongTinLoc";
            this.txtThongTinLoc.Size = new System.Drawing.Size(140, 32);
            this.txtThongTinLoc.TabIndex = 1;
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "GDKT",
            "GDMT",
            "TPB",
            "GDTC",
            "LDN",
            "KS",
            "RS"});
            this.cboChucVu.Location = new System.Drawing.Point(148, 84);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(140, 36);
            this.cboChucVu.TabIndex = 4;
            this.cboChucVu.SelectedIndexChanged += new System.EventHandler(this.cboChucVu_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Chức Vụ";
            // 
            // cboLocKhac
            // 
            this.cboLocKhac.FormattingEnabled = true;
            this.cboLocKhac.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Họ Đệm",
            "Tên",
            "CCCD"});
            this.cboLocKhac.Location = new System.Drawing.Point(379, 47);
            this.cboLocKhac.Margin = new System.Windows.Forms.Padding(2);
            this.cboLocKhac.Name = "cboLocKhac";
            this.cboLocKhac.Size = new System.Drawing.Size(140, 36);
            this.cboLocKhac.TabIndex = 5;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cboGioiTinh.Location = new System.Drawing.Point(148, 123);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(140, 36);
            this.cboGioiTinh.TabIndex = 7;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Azure;
            this.btnDangKy.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnDangKy.IconColor = System.Drawing.Color.Azure;
            this.btnDangKy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(3, 107);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(176, 53);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // tmSidebar
            // 
            this.tmSidebar.Interval = 10;
            this.tmSidebar.Tick += new System.EventHandler(this.tmSidebar_Tick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Azure;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnThongKe.IconColor = System.Drawing.Color.Azure;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(3, 181);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(176, 53);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tmThongKe
            // 
            this.tmThongKe.Interval = 10;
            this.tmThongKe.Tick += new System.EventHandler(this.tmThongKe_Tick);
            // 
            // tmDangKy
            // 
            this.tmDangKy.Interval = 10;
            this.tmDangKy.Tick += new System.EventHandler(this.tmDangKy_Tick);
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.btnHome);
            this.pnlTool.Controls.Add(this.btnThongKe);
            this.pnlTool.Controls.Add(this.btnDangKy);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTool.Location = new System.Drawing.Point(1276, 0);
            this.pnlTool.MaximumSize = new System.Drawing.Size(182, 772);
            this.pnlTool.MinimumSize = new System.Drawing.Size(61, 772);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(61, 772);
            this.pnlTool.TabIndex = 92;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnHome.IconColor = System.Drawing.Color.Azure;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(6, 35);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(48, 43);
            this.btnHome.TabIndex = 3;
            this.btnHome.UseCompatibleTextRendering = true;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pnlDangKy
            // 
            this.pnlDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.pnlDangKy.Controls.Add(this.panel1);
            this.pnlDangKy.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDangKy.Location = new System.Drawing.Point(1266, 0);
            this.pnlDangKy.MaximumSize = new System.Drawing.Size(1264, 772);
            this.pnlDangKy.MinimumSize = new System.Drawing.Size(10, 772);
            this.pnlDangKy.Name = "pnlDangKy";
            this.pnlDangKy.Size = new System.Drawing.Size(10, 772);
            this.pnlDangKy.TabIndex = 93;
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongKe.Controls.Add(this.chartLayLuongThang);
            this.pnlThongKe.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlThongKe.Location = new System.Drawing.Point(1256, 0);
            this.pnlThongKe.MaximumSize = new System.Drawing.Size(1267, 772);
            this.pnlThongKe.MinimumSize = new System.Drawing.Size(10, 772);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(10, 772);
            this.pnlThongKe.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cboGTinh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtMaPB);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtMaCV);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtHoDem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(207, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 474);
            this.panel1.TabIndex = 105;
            // 
            // cboGTinh
            // 
            this.cboGTinh.FormattingEnabled = true;
            this.cboGTinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cboGTinh.Location = new System.Drawing.Point(288, 245);
            this.cboGTinh.Name = "cboGTinh";
            this.cboGTinh.Size = new System.Drawing.Size(188, 28);
            this.cboGTinh.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 127;
            this.label1.Text = "Tên nhân viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(627, 247);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(192, 28);
            this.dtpNgaySinh.TabIndex = 126;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPB.Location = new System.Drawing.Point(288, 199);
            this.txtMaPB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(116, 28);
            this.txtMaPB.TabIndex = 119;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(627, 200);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 28);
            this.txtEmail.TabIndex = 123;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(408, 199);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(68, 28);
            this.txtMaCV.TabIndex = 125;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(288, 157);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(188, 28);
            this.txtTenNV.TabIndex = 124;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(627, 151);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(192, 28);
            this.txtSDT.TabIndex = 122;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(627, 108);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(192, 28);
            this.txtDiaChi.TabIndex = 121;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(627, 63);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(192, 28);
            this.txtCCCD.TabIndex = 120;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(510, 198);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 36);
            this.label11.TabIndex = 115;
            this.label11.Text = "Email       ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(510, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 28);
            this.label10.TabIndex = 114;
            this.label10.Text = "Phone";
            // 
            // txtHoDem
            // 
            this.txtHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoDem.Location = new System.Drawing.Point(288, 112);
            this.txtHoDem.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(188, 28);
            this.txtHoDem.TabIndex = 118;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(510, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 31);
            this.label6.TabIndex = 111;
            this.label6.Text = "Địa Chỉ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(288, 63);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(188, 28);
            this.txtMaNV.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(510, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 29);
            this.label7.TabIndex = 112;
            this.label7.Text = "CCCD   ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 108;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(510, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 110;
            this.label5.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 109;
            this.label3.Text = "Họ và Tên đệm";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(109, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 28);
            this.label9.TabIndex = 113;
            this.label9.Text = "Giới Tính";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(110, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 25);
            this.label12.TabIndex = 116;
            this.label12.Text = "Phòng Ban/Chức Vụ";
            // 
            // chartLayLuongThang
            // 
            this.chartLayLuongThang.BorderlineColor = System.Drawing.Color.Black;
            this.chartLayLuongThang.BorderlineWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.chartLayLuongThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLayLuongThang.Legends.Add(legend1);
            this.chartLayLuongThang.Location = new System.Drawing.Point(81, 35);
            this.chartLayLuongThang.Name = "chartLayLuongThang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "P001";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "P002";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "P003";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "P004";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "P005";
            this.chartLayLuongThang.Series.Add(series1);
            this.chartLayLuongThang.Series.Add(series2);
            this.chartLayLuongThang.Series.Add(series3);
            this.chartLayLuongThang.Series.Add(series4);
            this.chartLayLuongThang.Series.Add(series5);
            this.chartLayLuongThang.Size = new System.Drawing.Size(1031, 394);
            this.chartLayLuongThang.TabIndex = 0;
            this.chartLayLuongThang.Text = "Thống kê lương cho các phòng";
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
            this.btnSua.Location = new System.Drawing.Point(399, 332);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.TabIndex = 106;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
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
            this.btnXoa.Location = new System.Drawing.Point(258, 332);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 50);
            this.btnXoa.TabIndex = 107;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
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
            this.btnThem.Location = new System.Drawing.Point(112, 332);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 48);
            this.btnThem.TabIndex = 105;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // artanPannel1
            // 
            this.artanPannel1.BackColor = System.Drawing.Color.White;
            this.artanPannel1.BorderRadius = 30;
            this.artanPannel1.Controls.Add(this.gvNhanSu);
            this.artanPannel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            this.artanPannel1.GradientAngle = 90F;
            this.artanPannel1.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel1.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(228)))));
            this.artanPannel1.Location = new System.Drawing.Point(46, 254);
            this.artanPannel1.Name = "artanPannel1";
            this.artanPannel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel1.Size = new System.Drawing.Size(1194, 460);
            this.artanPannel1.TabIndex = 90;
            // 
            // gvNhanSu
            // 
            this.gvNhanSu.AllowUserToAddRows = false;
            this.gvNhanSu.AllowUserToDeleteRows = false;
            this.gvNhanSu.AllowUserToResizeColumns = false;
            this.gvNhanSu.AllowUserToResizeRows = false;
            this.gvNhanSu.BackgroundColor = System.Drawing.Color.White;
            this.gvNhanSu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvNhanSu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvNhanSu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(115)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNhanSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvNhanSu.ColumnHeadersHeight = 35;
            this.gvNhanSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoDem,
            this.ten,
            this.ngaySinh,
            this.diaChi,
            this.cccd,
            this.maPB,
            this.gioiTinh,
            this.sdt,
            this.email,
            this.maCV,
            this.trinhDo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(97)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvNhanSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvNhanSu.EnableHeadersVisualStyles = false;
            this.gvNhanSu.Location = new System.Drawing.Point(10, 10);
            this.gvNhanSu.MultiSelect = false;
            this.gvNhanSu.Name = "gvNhanSu";
            this.gvNhanSu.ReadOnly = true;
            this.gvNhanSu.RowHeadersVisible = false;
            this.gvNhanSu.RowHeadersWidth = 51;
            this.gvNhanSu.RowTemplate.DividerHeight = 2;
            this.gvNhanSu.RowTemplate.Height = 24;
            this.gvNhanSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvNhanSu.Size = new System.Drawing.Size(1174, 440);
            this.gvNhanSu.TabIndex = 0;
            // 
            // maNV
            // 
            this.maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNV.FillWeight = 180F;
            this.maNV.HeaderText = "Mã Nhân Viên ";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // hoDem
            // 
            this.hoDem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoDem.FillWeight = 130F;
            this.hoDem.HeaderText = "Họ Đệm";
            this.hoDem.MinimumWidth = 6;
            this.hoDem.Name = "hoDem";
            this.hoDem.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên ";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaySinh.FillWeight = 150F;
            this.ngaySinh.HeaderText = "Ngày Sinh ";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cccd.HeaderText = "CCCD";
            this.cccd.MinimumWidth = 6;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            // 
            // maPB
            // 
            this.maPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maPB.FillWeight = 200F;
            this.maPB.HeaderText = "Mã Phòng Ban";
            this.maPB.MinimumWidth = 6;
            this.maPB.Name = "maPB";
            this.maPB.ReadOnly = true;
            // 
            // gioiTinh
            // 
            this.gioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioiTinh.FillWeight = 150F;
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // maCV
            // 
            this.maCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maCV.HeaderText = "MaCV";
            this.maCV.MinimumWidth = 6;
            this.maCV.Name = "maCV";
            this.maCV.ReadOnly = true;
            // 
            // trinhDo
            // 
            this.trinhDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trinhDo.HeaderText = "TrinhDo";
            this.trinhDo.MinimumWidth = 6;
            this.trinhDo.Name = "trinhDo";
            this.trinhDo.ReadOnly = true;
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
            this.btnLoc.Location = new System.Drawing.Point(587, 42);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(98, 41);
            this.btnLoc.TabIndex = 83;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextColor = System.Drawing.Color.Black;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
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
            this.btnReload.Location = new System.Drawing.Point(587, 105);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(98, 46);
            this.btnReload.TabIndex = 84;
            this.btnReload.Text = "Reload";
            this.btnReload.TextColor = System.Drawing.Color.Black;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1337, 772);
            this.Controls.Add(this.pnlThongKe);
            this.Controls.Add(this.pnlDangKy);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.artanPannel1);
            this.Controls.Add(this.grpLocThongTin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FNhanSu";
            this.Text = "Nhân Sự";
            this.Load += new System.EventHandler(this.FNhanSu_Load);
            this.grpLocThongTin.ResumeLayout(false);
            this.grpLocThongTin.PerformLayout();
            this.pnlTool.ResumeLayout(false);
            this.pnlDangKy.ResumeLayout(false);
            this.pnlThongKe.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLayLuongThang)).EndInit();
            this.artanPannel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtThongTinLoc;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.GroupBox grpLocThongTin;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboLocKhac;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private VBButton btnLoc;
        private VBButton btnReload;
        private System.Windows.Forms.Timer tmSidebar;
        private ArtanComponent.ArtanPannel artanPannel1;
        private System.Windows.Forms.DataGridView gvNhanSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhDo;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.Timer tmThongKe;
        private FontAwesome.Sharp.IconButton btnDangKy;
        private System.Windows.Forms.Timer tmDangKy;
        private System.Windows.Forms.Panel pnlTool;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlDangKy;
        private System.Windows.Forms.Panel pnlThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboGTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private VBButton btnSua;
        private VBButton btnXoa;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtEmail;
        private VBButton btnThem;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLayLuongThang;
    }
}