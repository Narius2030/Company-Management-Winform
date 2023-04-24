namespace QLCongTy
{
    partial class FProfile
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlEmpty = new System.Windows.Forms.Panel();
            this.btnThongTinCaNhan = new FontAwesome.Sharp.IconButton();
            this.btnDuAn = new FontAwesome.Sharp.IconButton();
            this.btnLuong = new FontAwesome.Sharp.IconButton();
            this.btnXinNghiPhep = new FontAwesome.Sharp.IconButton();
            this.btnBaoMat = new FontAwesome.Sharp.IconButton();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picAvata = new FontAwesome.Sharp.IconPictureBox();
            this.lblMaNV = new QLCongTy.VBLabel();
            this.lblTenNV = new QLCongTy.VBLabel();
            this.pnlTong = new System.Windows.Forms.Panel();
            this.pnlBaoMat = new System.Windows.Forms.Panel();
            this.pnlDoiMatKhau = new System.Windows.Forms.Panel();
            this.btnUpdateMatKhau = new QLCongTy.VBButton();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDoiMatKhau = new QLCongTy.VBButton();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlXinNghiPhep = new System.Windows.Forms.Panel();
            this.btnGui = new QLCongTy.VBButton();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayNghi = new System.Windows.Forms.DateTimePicker();
            this.lblTitleNghiPhep = new QLCongTy.VBLabel();
            this.pnlLuong = new System.Windows.Forms.Panel();
            this.vbLabel12 = new QLCongTy.VBLabel();
            this.vbLabel11 = new QLCongTy.VBLabel();
            this.vbLabel10 = new QLCongTy.VBLabel();
            this.vbLabel9 = new QLCongTy.VBLabel();
            this.pnlDuAn = new System.Windows.Forms.Panel();
            this.gvDuAn = new System.Windows.Forms.DataGridView();
            this.pnlTTCN = new System.Windows.Forms.Panel();
            this.iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblCCCD = new QLCongTy.VBLabel();
            this.lblNgaySinh = new QLCongTy.VBLabel();
            this.lblEmail = new QLCongTy.VBLabel();
            this.lblGioiTinh = new QLCongTy.VBLabel();
            this.lblSDT = new QLCongTy.VBLabel();
            this.lblDiaChi = new QLCongTy.VBLabel();
            this.sidebar.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).BeginInit();
            this.pnlTong.SuspendLayout();
            this.pnlBaoMat.SuspendLayout();
            this.pnlDoiMatKhau.SuspendLayout();
            this.pnlXinNghiPhep.SuspendLayout();
            this.pnlLuong.SuspendLayout();
            this.pnlDuAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDuAn)).BeginInit();
            this.pnlTTCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.pnlHome);
            this.sidebar.Controls.Add(this.pnlEmpty);
            this.sidebar.Controls.Add(this.btnThongTinCaNhan);
            this.sidebar.Controls.Add(this.btnDuAn);
            this.sidebar.Controls.Add(this.btnLuong);
            this.sidebar.Controls.Add(this.btnXinNghiPhep);
            this.sidebar.Controls.Add(this.btnBaoMat);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(254, 819);
            this.sidebar.TabIndex = 5;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(3, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(214, 86);
            this.pnlHome.TabIndex = 69;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 50;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(214, 86);
            this.btnHome.TabIndex = 90;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlEmpty
            // 
            this.pnlEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmpty.Location = new System.Drawing.Point(3, 95);
            this.pnlEmpty.Name = "pnlEmpty";
            this.pnlEmpty.Size = new System.Drawing.Size(240, 28);
            this.pnlEmpty.TabIndex = 87;
            // 
            // btnThongTinCaNhan
            // 
            this.btnThongTinCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinCaNhan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnThongTinCaNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinCaNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongTinCaNhan.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnThongTinCaNhan.IconColor = System.Drawing.Color.White;
            this.btnThongTinCaNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongTinCaNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.Location = new System.Drawing.Point(3, 129);
            this.btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            this.btnThongTinCaNhan.Size = new System.Drawing.Size(240, 67);
            this.btnThongTinCaNhan.TabIndex = 88;
            this.btnThongTinCaNhan.Text = "  Thông tin cá nhân";
            this.btnThongTinCaNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongTinCaNhan.UseVisualStyleBackColor = true;
            this.btnThongTinCaNhan.Click += new System.EventHandler(this.btnThongTinCaNhan_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuAn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuAn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDuAn.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btnDuAn.IconColor = System.Drawing.Color.White;
            this.btnDuAn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuAn.Location = new System.Drawing.Point(3, 202);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(240, 67);
            this.btnDuAn.TabIndex = 89;
            this.btnDuAn.Text = "  Dự án";
            this.btnDuAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuAn.UseVisualStyleBackColor = true;
            this.btnDuAn.Click += new System.EventHandler(this.btnDuAn_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuong.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnLuong.IconColor = System.Drawing.Color.White;
            this.btnLuong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.Location = new System.Drawing.Point(3, 275);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(240, 67);
            this.btnLuong.TabIndex = 92;
            this.btnLuong.Text = "  Lương";
            this.btnLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnXinNghiPhep
            // 
            this.btnXinNghiPhep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXinNghiPhep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnXinNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXinNghiPhep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXinNghiPhep.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.btnXinNghiPhep.IconColor = System.Drawing.Color.White;
            this.btnXinNghiPhep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXinNghiPhep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXinNghiPhep.Location = new System.Drawing.Point(3, 348);
            this.btnXinNghiPhep.Name = "btnXinNghiPhep";
            this.btnXinNghiPhep.Size = new System.Drawing.Size(240, 67);
            this.btnXinNghiPhep.TabIndex = 95;
            this.btnXinNghiPhep.Text = "  Xin nghỉ phép";
            this.btnXinNghiPhep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXinNghiPhep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXinNghiPhep.UseVisualStyleBackColor = true;
            this.btnXinNghiPhep.Click += new System.EventHandler(this.btnXinNghiPhep_Click);
            // 
            // btnBaoMat
            // 
            this.btnBaoMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoMat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnBaoMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoMat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoMat.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnBaoMat.IconColor = System.Drawing.Color.White;
            this.btnBaoMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoMat.Location = new System.Drawing.Point(3, 421);
            this.btnBaoMat.Name = "btnBaoMat";
            this.btnBaoMat.Size = new System.Drawing.Size(240, 67);
            this.btnBaoMat.TabIndex = 96;
            this.btnBaoMat.Text = "  Bảo mật";
            this.btnBaoMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoMat.UseVisualStyleBackColor = true;
            this.btnBaoMat.Click += new System.EventHandler(this.btnBaoMat_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.picAvata);
            this.pnlTitle.Controls.Add(this.lblMaNV);
            this.pnlTitle.Controls.Add(this.lblTenNV);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(254, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1058, 84);
            this.pnlTitle.TabIndex = 6;
            // 
            // picAvata
            // 
            this.picAvata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.picAvata.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAvata.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picAvata.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.picAvata.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picAvata.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picAvata.IconSize = 84;
            this.picAvata.Location = new System.Drawing.Point(0, 0);
            this.picAvata.Name = "picAvata";
            this.picAvata.Size = new System.Drawing.Size(87, 84);
            this.picAvata.TabIndex = 62;
            this.picAvata.TabStop = false;
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMaNV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMaNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblMaNV.BorderRadius = 20;
            this.lblMaNV.BorderSize = 0;
            this.lblMaNV.FlatAppearance.BorderSize = 0;
            this.lblMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaNV.ForeColor = System.Drawing.Color.White;
            this.lblMaNV.Location = new System.Drawing.Point(345, 21);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(150, 40);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã";
            this.lblMaNV.TextColor = System.Drawing.Color.White;
            this.lblMaNV.UseVisualStyleBackColor = false;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTenNV.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTenNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblTenNV.BorderRadius = 20;
            this.lblTenNV.BorderSize = 0;
            this.lblTenNV.FlatAppearance.BorderSize = 0;
            this.lblTenNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenNV.ForeColor = System.Drawing.Color.White;
            this.lblTenNV.Location = new System.Drawing.Point(96, 21);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(228, 40);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Tên";
            this.lblTenNV.TextColor = System.Drawing.Color.White;
            this.lblTenNV.UseVisualStyleBackColor = false;
            // 
            // pnlTong
            // 
            this.pnlTong.AutoScroll = true;
            this.pnlTong.BackColor = System.Drawing.Color.White;
            this.pnlTong.Controls.Add(this.pnlBaoMat);
            this.pnlTong.Controls.Add(this.pnlXinNghiPhep);
            this.pnlTong.Controls.Add(this.pnlLuong);
            this.pnlTong.Controls.Add(this.pnlDuAn);
            this.pnlTong.Controls.Add(this.pnlTTCN);
            this.pnlTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTong.Location = new System.Drawing.Point(254, 84);
            this.pnlTong.Name = "pnlTong";
            this.pnlTong.Size = new System.Drawing.Size(1058, 735);
            this.pnlTong.TabIndex = 7;
            // 
            // pnlBaoMat
            // 
            this.pnlBaoMat.Controls.Add(this.pnlDoiMatKhau);
            this.pnlBaoMat.Controls.Add(this.btnDoiMatKhau);
            this.pnlBaoMat.Controls.Add(this.lblMatKhau);
            this.pnlBaoMat.Controls.Add(this.label6);
            this.pnlBaoMat.Controls.Add(this.lblTaiKhoan);
            this.pnlBaoMat.Controls.Add(this.label4);
            this.pnlBaoMat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaoMat.Location = new System.Drawing.Point(0, 2978);
            this.pnlBaoMat.Name = "pnlBaoMat";
            this.pnlBaoMat.Size = new System.Drawing.Size(1037, 735);
            this.pnlBaoMat.TabIndex = 78;
            // 
            // pnlDoiMatKhau
            // 
            this.pnlDoiMatKhau.Controls.Add(this.btnUpdateMatKhau);
            this.pnlDoiMatKhau.Controls.Add(this.txtXacNhanMK);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.pnlDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.pnlDoiMatKhau.Controls.Add(this.label17);
            this.pnlDoiMatKhau.Controls.Add(this.label18);
            this.pnlDoiMatKhau.Controls.Add(this.label19);
            this.pnlDoiMatKhau.Location = new System.Drawing.Point(140, 119);
            this.pnlDoiMatKhau.Name = "pnlDoiMatKhau";
            this.pnlDoiMatKhau.Size = new System.Drawing.Size(451, 280);
            this.pnlDoiMatKhau.TabIndex = 89;
            // 
            // btnUpdateMatKhau
            // 
            this.btnUpdateMatKhau.BackColor = System.Drawing.Color.Azure;
            this.btnUpdateMatKhau.BackgroundColor = System.Drawing.Color.Azure;
            this.btnUpdateMatKhau.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateMatKhau.BorderRadius = 15;
            this.btnUpdateMatKhau.BorderSize = 1;
            this.btnUpdateMatKhau.FlatAppearance.BorderSize = 0;
            this.btnUpdateMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateMatKhau.Location = new System.Drawing.Point(319, 207);
            this.btnUpdateMatKhau.Name = "btnUpdateMatKhau";
            this.btnUpdateMatKhau.Size = new System.Drawing.Size(116, 58);
            this.btnUpdateMatKhau.TabIndex = 82;
            this.btnUpdateMatKhau.Text = "Update";
            this.btnUpdateMatKhau.TextColor = System.Drawing.Color.Black;
            this.btnUpdateMatKhau.UseVisualStyleBackColor = false;
            this.btnUpdateMatKhau.Click += new System.EventHandler(this.btnUpdateMatKhau_Click);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtXacNhanMK.Location = new System.Drawing.Point(179, 152);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(173, 26);
            this.txtXacNhanMK.TabIndex = 85;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(179, 89);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(173, 26);
            this.txtMatKhauMoi.TabIndex = 84;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMatKhauCu.Location = new System.Drawing.Point(179, 35);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(173, 26);
            this.txtMatKhauCu.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(22, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 50);
            this.label17.TabIndex = 82;
            this.label17.Text = "Xác nhận \r\nmật khẩu mới:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(22, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 25);
            this.label18.TabIndex = 81;
            this.label18.Text = "Mật khẩu mới:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(22, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 25);
            this.label19.TabIndex = 80;
            this.label19.Text = "Mật khẩu cũ:";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Azure;
            this.btnDoiMatKhau.BackgroundColor = System.Drawing.Color.Azure;
            this.btnDoiMatKhau.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoiMatKhau.BorderRadius = 15;
            this.btnDoiMatKhau.BorderSize = 1;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(457, 325);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(116, 58);
            this.btnDoiMatKhau.TabIndex = 89;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextColor = System.Drawing.Color.Black;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMatKhau.Location = new System.Drawing.Point(286, 195);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(93, 25);
            this.lblMatKhau.TabIndex = 95;
            this.lblMatKhau.Text = "Mat khau";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(160, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 90;
            this.label6.Text = "Tài khoản: ";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTaiKhoan.Location = new System.Drawing.Point(286, 142);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(99, 25);
            this.lblTaiKhoan.TabIndex = 94;
            this.lblTaiKhoan.Text = "Tai khoan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(160, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Mật khẩu:";
            // 
            // pnlXinNghiPhep
            // 
            this.pnlXinNghiPhep.Controls.Add(this.btnGui);
            this.pnlXinNghiPhep.Controls.Add(this.txtLyDo);
            this.pnlXinNghiPhep.Controls.Add(this.label3);
            this.pnlXinNghiPhep.Controls.Add(this.label2);
            this.pnlXinNghiPhep.Controls.Add(this.label1);
            this.pnlXinNghiPhep.Controls.Add(this.dtpNgayNghi);
            this.pnlXinNghiPhep.Controls.Add(this.lblTitleNghiPhep);
            this.pnlXinNghiPhep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlXinNghiPhep.Location = new System.Drawing.Point(0, 2243);
            this.pnlXinNghiPhep.Name = "pnlXinNghiPhep";
            this.pnlXinNghiPhep.Size = new System.Drawing.Size(1037, 735);
            this.pnlXinNghiPhep.TabIndex = 28;
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.Azure;
            this.btnGui.BackgroundColor = System.Drawing.Color.Azure;
            this.btnGui.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGui.BorderRadius = 15;
            this.btnGui.BorderSize = 1;
            this.btnGui.FlatAppearance.BorderSize = 0;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.Black;
            this.btnGui.Location = new System.Drawing.Point(488, 418);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(103, 49);
            this.btnGui.TabIndex = 77;
            this.btnGui.Text = "Submit";
            this.btnGui.TextColor = System.Drawing.Color.Black;
            this.btnGui.UseVisualStyleBackColor = false;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(207, 367);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(384, 30);
            this.txtLyDo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(164, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lý do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(164, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gửi\r\n        Ban lãnh đạo công ty ABC...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(164, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày nghỉ";
            // 
            // dtpNgayNghi
            // 
            this.dtpNgayNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNghi.Location = new System.Drawing.Point(207, 271);
            this.dtpNgayNghi.Name = "dtpNgayNghi";
            this.dtpNgayNghi.Size = new System.Drawing.Size(384, 32);
            this.dtpNgayNghi.TabIndex = 1;
            // 
            // lblTitleNghiPhep
            // 
            this.lblTitleNghiPhep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.lblTitleNghiPhep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.lblTitleNghiPhep.BorderColor = System.Drawing.Color.Peru;
            this.lblTitleNghiPhep.BorderRadius = 30;
            this.lblTitleNghiPhep.BorderSize = 0;
            this.lblTitleNghiPhep.FlatAppearance.BorderSize = 0;
            this.lblTitleNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleNghiPhep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNghiPhep.ForeColor = System.Drawing.Color.White;
            this.lblTitleNghiPhep.Location = new System.Drawing.Point(219, 15);
            this.lblTitleNghiPhep.Name = "lblTitleNghiPhep";
            this.lblTitleNghiPhep.Size = new System.Drawing.Size(377, 51);
            this.lblTitleNghiPhep.TabIndex = 0;
            this.lblTitleNghiPhep.Text = "Đơn xin nghỉ phép ";
            this.lblTitleNghiPhep.TextColor = System.Drawing.Color.White;
            this.lblTitleNghiPhep.UseVisualStyleBackColor = false;
            // 
            // pnlLuong
            // 
            this.pnlLuong.Controls.Add(this.vbLabel12);
            this.pnlLuong.Controls.Add(this.vbLabel11);
            this.pnlLuong.Controls.Add(this.vbLabel10);
            this.pnlLuong.Controls.Add(this.vbLabel9);
            this.pnlLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLuong.Location = new System.Drawing.Point(0, 1508);
            this.pnlLuong.Name = "pnlLuong";
            this.pnlLuong.Size = new System.Drawing.Size(1037, 735);
            this.pnlLuong.TabIndex = 27;
            // 
            // vbLabel12
            // 
            this.vbLabel12.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel12.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel12.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbLabel12.BorderRadius = 20;
            this.vbLabel12.BorderSize = 0;
            this.vbLabel12.FlatAppearance.BorderSize = 0;
            this.vbLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbLabel12.ForeColor = System.Drawing.Color.White;
            this.vbLabel12.Location = new System.Drawing.Point(74, 139);
            this.vbLabel12.Name = "vbLabel12";
            this.vbLabel12.Size = new System.Drawing.Size(228, 40);
            this.vbLabel12.TabIndex = 66;
            this.vbLabel12.Text = "Tên";
            this.vbLabel12.TextColor = System.Drawing.Color.White;
            this.vbLabel12.UseVisualStyleBackColor = false;
            // 
            // vbLabel11
            // 
            this.vbLabel11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel11.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbLabel11.BorderRadius = 20;
            this.vbLabel11.BorderSize = 0;
            this.vbLabel11.FlatAppearance.BorderSize = 0;
            this.vbLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbLabel11.ForeColor = System.Drawing.Color.White;
            this.vbLabel11.Location = new System.Drawing.Point(74, 207);
            this.vbLabel11.Name = "vbLabel11";
            this.vbLabel11.Size = new System.Drawing.Size(228, 40);
            this.vbLabel11.TabIndex = 65;
            this.vbLabel11.Text = "Tên";
            this.vbLabel11.TextColor = System.Drawing.Color.White;
            this.vbLabel11.UseVisualStyleBackColor = false;
            // 
            // vbLabel10
            // 
            this.vbLabel10.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel10.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbLabel10.BorderRadius = 20;
            this.vbLabel10.BorderSize = 0;
            this.vbLabel10.FlatAppearance.BorderSize = 0;
            this.vbLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbLabel10.ForeColor = System.Drawing.Color.White;
            this.vbLabel10.Location = new System.Drawing.Point(74, 275);
            this.vbLabel10.Name = "vbLabel10";
            this.vbLabel10.Size = new System.Drawing.Size(228, 40);
            this.vbLabel10.TabIndex = 64;
            this.vbLabel10.Text = "Tên";
            this.vbLabel10.TextColor = System.Drawing.Color.White;
            this.vbLabel10.UseVisualStyleBackColor = false;
            // 
            // vbLabel9
            // 
            this.vbLabel9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel9.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbLabel9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbLabel9.BorderRadius = 20;
            this.vbLabel9.BorderSize = 0;
            this.vbLabel9.FlatAppearance.BorderSize = 0;
            this.vbLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbLabel9.ForeColor = System.Drawing.Color.White;
            this.vbLabel9.Location = new System.Drawing.Point(74, 71);
            this.vbLabel9.Name = "vbLabel9";
            this.vbLabel9.Size = new System.Drawing.Size(228, 40);
            this.vbLabel9.TabIndex = 63;
            this.vbLabel9.Text = "Tên";
            this.vbLabel9.TextColor = System.Drawing.Color.White;
            this.vbLabel9.UseVisualStyleBackColor = false;
            // 
            // pnlDuAn
            // 
            this.pnlDuAn.Controls.Add(this.gvDuAn);
            this.pnlDuAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDuAn.Location = new System.Drawing.Point(0, 773);
            this.pnlDuAn.Name = "pnlDuAn";
            this.pnlDuAn.Size = new System.Drawing.Size(1037, 735);
            this.pnlDuAn.TabIndex = 25;
            // 
            // gvDuAn
            // 
            this.gvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDuAn.Location = new System.Drawing.Point(17, 175);
            this.gvDuAn.Name = "gvDuAn";
            this.gvDuAn.RowHeadersWidth = 51;
            this.gvDuAn.RowTemplate.Height = 24;
            this.gvDuAn.Size = new System.Drawing.Size(699, 206);
            this.gvDuAn.TabIndex = 0;
            // 
            // pnlTTCN
            // 
            this.pnlTTCN.Controls.Add(this.iconPictureBox6);
            this.pnlTTCN.Controls.Add(this.iconPictureBox5);
            this.pnlTTCN.Controls.Add(this.iconPictureBox4);
            this.pnlTTCN.Controls.Add(this.iconPictureBox3);
            this.pnlTTCN.Controls.Add(this.iconPictureBox2);
            this.pnlTTCN.Controls.Add(this.iconPictureBox1);
            this.pnlTTCN.Controls.Add(this.lblCCCD);
            this.pnlTTCN.Controls.Add(this.lblNgaySinh);
            this.pnlTTCN.Controls.Add(this.lblEmail);
            this.pnlTTCN.Controls.Add(this.lblGioiTinh);
            this.pnlTTCN.Controls.Add(this.lblSDT);
            this.pnlTTCN.Controls.Add(this.lblDiaChi);
            this.pnlTTCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTTCN.Location = new System.Drawing.Point(0, 0);
            this.pnlTTCN.Name = "pnlTTCN";
            this.pnlTTCN.Size = new System.Drawing.Size(1037, 773);
            this.pnlTTCN.TabIndex = 23;
            // 
            // iconPictureBox6
            // 
            this.iconPictureBox6.BackColor = System.Drawing.Color.White;
            this.iconPictureBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.LocationDot;
            this.iconPictureBox6.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox6.IconSize = 70;
            this.iconPictureBox6.Location = new System.Drawing.Point(561, 448);
            this.iconPictureBox6.Name = "iconPictureBox6";
            this.iconPictureBox6.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox6.TabIndex = 13;
            this.iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.White;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 70;
            this.iconPictureBox5.Location = new System.Drawing.Point(559, 318);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox5.TabIndex = 12;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.White;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 70;
            this.iconPictureBox4.Location = new System.Drawing.Point(559, 184);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox4.TabIndex = 11;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 70;
            this.iconPictureBox3.Location = new System.Drawing.Point(111, 448);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox3.TabIndex = 10;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VenusMars;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 70;
            this.iconPictureBox2.Location = new System.Drawing.Point(111, 318);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox2.TabIndex = 9;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 70;
            this.iconPictureBox1.Location = new System.Drawing.Point(111, 184);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 74);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblCCCD
            // 
            this.lblCCCD.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCCCD.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCCCD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblCCCD.BorderRadius = 12;
            this.lblCCCD.BorderSize = 0;
            this.lblCCCD.FlatAppearance.BorderSize = 0;
            this.lblCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCCCD.ForeColor = System.Drawing.Color.White;
            this.lblCCCD.Location = new System.Drawing.Point(203, 462);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(269, 40);
            this.lblCCCD.TabIndex = 7;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.TextColor = System.Drawing.Color.White;
            this.lblCCCD.UseVisualStyleBackColor = false;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNgaySinh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblNgaySinh.BorderRadius = 12;
            this.lblNgaySinh.BorderSize = 0;
            this.lblNgaySinh.FlatAppearance.BorderSize = 0;
            this.lblNgaySinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNgaySinh.ForeColor = System.Drawing.Color.White;
            this.lblNgaySinh.Location = new System.Drawing.Point(203, 204);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(269, 40);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TextColor = System.Drawing.Color.White;
            this.lblNgaySinh.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEmail.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblEmail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblEmail.BorderRadius = 12;
            this.lblEmail.BorderSize = 0;
            this.lblEmail.FlatAppearance.BorderSize = 0;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(653, 337);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(269, 40);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextColor = System.Drawing.Color.White;
            this.lblEmail.UseVisualStyleBackColor = false;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGioiTinh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGioiTinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblGioiTinh.BorderRadius = 12;
            this.lblGioiTinh.BorderSize = 0;
            this.lblGioiTinh.FlatAppearance.BorderSize = 0;
            this.lblGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGioiTinh.ForeColor = System.Drawing.Color.White;
            this.lblGioiTinh.Location = new System.Drawing.Point(203, 337);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(269, 40);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            this.lblGioiTinh.TextColor = System.Drawing.Color.White;
            this.lblGioiTinh.UseVisualStyleBackColor = false;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSDT.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSDT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblSDT.BorderRadius = 12;
            this.lblSDT.BorderSize = 0;
            this.lblSDT.FlatAppearance.BorderSize = 0;
            this.lblSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSDT.ForeColor = System.Drawing.Color.White;
            this.lblSDT.Location = new System.Drawing.Point(653, 204);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(269, 40);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "SDT";
            this.lblSDT.TextColor = System.Drawing.Color.White;
            this.lblSDT.UseVisualStyleBackColor = false;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDiaChi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDiaChi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblDiaChi.BorderRadius = 12;
            this.lblDiaChi.BorderSize = 0;
            this.lblDiaChi.FlatAppearance.BorderSize = 0;
            this.lblDiaChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiaChi.ForeColor = System.Drawing.Color.White;
            this.lblDiaChi.Location = new System.Drawing.Point(653, 462);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(269, 40);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            this.lblDiaChi.TextColor = System.Drawing.Color.White;
            this.lblDiaChi.UseVisualStyleBackColor = false;
            // 
            // FProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1312, 819);
            this.Controls.Add(this.pnlTong);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FProfile";
            this.Text = "FProfile";
            this.Load += new System.EventHandler(this.FProfile_Load);
            this.sidebar.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvata)).EndInit();
            this.pnlTong.ResumeLayout(false);
            this.pnlBaoMat.ResumeLayout(false);
            this.pnlBaoMat.PerformLayout();
            this.pnlDoiMatKhau.ResumeLayout(false);
            this.pnlDoiMatKhau.PerformLayout();
            this.pnlXinNghiPhep.ResumeLayout(false);
            this.pnlXinNghiPhep.PerformLayout();
            this.pnlLuong.ResumeLayout(false);
            this.pnlDuAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDuAn)).EndInit();
            this.pnlTTCN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlTitle;
        private VBLabel lblMaNV;
        private VBLabel lblTenNV;
        private System.Windows.Forms.Panel pnlTong;
        private System.Windows.Forms.Panel pnlBaoMat;
        private System.Windows.Forms.Panel pnlXinNghiPhep;
        private VBButton btnGui;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNghi;
        private VBLabel lblTitleNghiPhep;
        private System.Windows.Forms.Panel pnlLuong;
        private System.Windows.Forms.Panel pnlDuAn;
        private System.Windows.Forms.DataGridView gvDuAn;
        private System.Windows.Forms.Panel pnlTTCN;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private VBLabel lblCCCD;
        private VBLabel lblNgaySinh;
        private VBLabel lblEmail;
        private VBLabel lblGioiTinh;
        private VBLabel lblSDT;
        private VBLabel lblDiaChi;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel pnlEmpty;
        private FontAwesome.Sharp.IconButton btnThongTinCaNhan;
        private FontAwesome.Sharp.IconButton btnDuAn;
        private FontAwesome.Sharp.IconButton btnLuong;
        private FontAwesome.Sharp.IconPictureBox picAvata;
        private System.Windows.Forms.Panel pnlDoiMatKhau;
        private VBButton btnUpdateMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private VBButton btnDoiMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnXinNghiPhep;
        private FontAwesome.Sharp.IconButton btnBaoMat;
        private VBLabel vbLabel12;
        private VBLabel vbLabel11;
        private VBLabel vbLabel10;
        private VBLabel vbLabel9;
    }
}