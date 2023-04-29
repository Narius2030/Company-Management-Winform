namespace QLCongTy
{
    partial class fCheckin_Checkout
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
            this.tabDiemdanh = new System.Windows.Forms.TabControl();
            this.tpCheckSang = new System.Windows.Forms.TabPage();
            this.pnlThongtinCheckIn = new ArtanComponent.ArtanPannel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlgridviewsang = new ArtanComponent.ArtanPannel();
            this.gvChecksang = new System.Windows.Forms.DataGridView();
            this.dtpCheckInsang = new System.Windows.Forms.DateTimePicker();
            this.lblMaDa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCheckInsang = new System.Windows.Forms.CheckBox();
            this.txtMacvsang = new System.Windows.Forms.TextBox();
            this.txtManvsang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubmitsang = new System.Windows.Forms.Button();
            this.artanPannel1 = new ArtanComponent.ArtanPannel();
            this.label3 = new System.Windows.Forms.Label();
            this.tpCheckchieu = new System.Windows.Forms.TabPage();
            this.pnlThongtinCheckout = new ArtanComponent.ArtanPannel();
            this.txtPhanTram = new System.Windows.Forms.TextBox();
            this.artanPannel4 = new ArtanComponent.ArtanPannel();
            this.gvCheckchieu = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpCheckOutchieu = new System.Windows.Forms.DateTimePicker();
            this.txtMacvchieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCheckOutchieu = new System.Windows.Forms.CheckBox();
            this.btnSubmitchieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManvchieu = new System.Windows.Forms.TextBox();
            this.artanPannel2 = new ArtanComponent.ArtanPannel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDiemdanh.SuspendLayout();
            this.tpCheckSang.SuspendLayout();
            this.pnlThongtinCheckIn.SuspendLayout();
            this.pnlgridviewsang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecksang)).BeginInit();
            this.artanPannel1.SuspendLayout();
            this.tpCheckchieu.SuspendLayout();
            this.pnlThongtinCheckout.SuspendLayout();
            this.artanPannel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckchieu)).BeginInit();
            this.artanPannel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDiemdanh
            // 
            this.tabDiemdanh.Controls.Add(this.tpCheckSang);
            this.tabDiemdanh.Controls.Add(this.tpCheckchieu);
            this.tabDiemdanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDiemdanh.Location = new System.Drawing.Point(0, 0);
            this.tabDiemdanh.Name = "tabDiemdanh";
            this.tabDiemdanh.SelectedIndex = 0;
            this.tabDiemdanh.Size = new System.Drawing.Size(1355, 819);
            this.tabDiemdanh.TabIndex = 0;
            // 
            // tpCheckSang
            // 
            this.tpCheckSang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.tpCheckSang.Controls.Add(this.pnlThongtinCheckIn);
            this.tpCheckSang.Controls.Add(this.artanPannel1);
            this.tpCheckSang.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.tpCheckSang.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCheckSang.ForeColor = System.Drawing.Color.Black;
            this.tpCheckSang.Location = new System.Drawing.Point(4, 25);
            this.tpCheckSang.Name = "tpCheckSang";
            this.tpCheckSang.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckSang.Size = new System.Drawing.Size(1347, 790);
            this.tpCheckSang.TabIndex = 0;
            this.tpCheckSang.Text = "Buổi Sáng ";
            this.tpCheckSang.Click += new System.EventHandler(this.tpCheckSang_Click);
            // 
            // pnlThongtinCheckIn
            // 
            this.pnlThongtinCheckIn.BackColor = System.Drawing.Color.White;
            this.pnlThongtinCheckIn.BorderRadius = 50;
            this.pnlThongtinCheckIn.Controls.Add(this.label6);
            this.pnlThongtinCheckIn.Controls.Add(this.pnlgridviewsang);
            this.pnlThongtinCheckIn.Controls.Add(this.dtpCheckInsang);
            this.pnlThongtinCheckIn.Controls.Add(this.lblMaDa);
            this.pnlThongtinCheckIn.Controls.Add(this.label8);
            this.pnlThongtinCheckIn.Controls.Add(this.label4);
            this.pnlThongtinCheckIn.Controls.Add(this.cbCheckInsang);
            this.pnlThongtinCheckIn.Controls.Add(this.txtMacvsang);
            this.pnlThongtinCheckIn.Controls.Add(this.txtManvsang);
            this.pnlThongtinCheckIn.Controls.Add(this.label10);
            this.pnlThongtinCheckIn.Controls.Add(this.btnSubmitsang);
            this.pnlThongtinCheckIn.ForeColor = System.Drawing.Color.Black;
            this.pnlThongtinCheckIn.GradientAngle = 90F;
            this.pnlThongtinCheckIn.GradientBttomColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongtinCheckIn.GradientTopcolor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongtinCheckIn.Location = new System.Drawing.Point(264, 102);
            this.pnlThongtinCheckIn.Name = "pnlThongtinCheckIn";
            this.pnlThongtinCheckIn.Size = new System.Drawing.Size(847, 601);
            this.pnlThongtinCheckIn.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(59, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 30);
            this.label6.TabIndex = 58;
            this.label6.Text = "Dự án";
            // 
            // pnlgridviewsang
            // 
            this.pnlgridviewsang.BackColor = System.Drawing.Color.White;
            this.pnlgridviewsang.BorderRadius = 30;
            this.pnlgridviewsang.Controls.Add(this.gvChecksang);
            this.pnlgridviewsang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(94)))), ((int)(((byte)(231)))));
            this.pnlgridviewsang.GradientAngle = 90F;
            this.pnlgridviewsang.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.pnlgridviewsang.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(95)))), ((int)(((byte)(231)))));
            this.pnlgridviewsang.Location = new System.Drawing.Point(65, 258);
            this.pnlgridviewsang.Name = "pnlgridviewsang";
            this.pnlgridviewsang.Padding = new System.Windows.Forms.Padding(10);
            this.pnlgridviewsang.Size = new System.Drawing.Size(725, 306);
            this.pnlgridviewsang.TabIndex = 50;
            // 
            // gvChecksang
            // 
            this.gvChecksang.AllowUserToAddRows = false;
            this.gvChecksang.AllowUserToDeleteRows = false;
            this.gvChecksang.AllowUserToResizeColumns = false;
            this.gvChecksang.AllowUserToResizeRows = false;
            this.gvChecksang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvChecksang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvChecksang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvChecksang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvChecksang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvChecksang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvChecksang.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(94)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvChecksang.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvChecksang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChecksang.EnableHeadersVisualStyles = false;
            this.gvChecksang.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvChecksang.Location = new System.Drawing.Point(10, 10);
            this.gvChecksang.MultiSelect = false;
            this.gvChecksang.Name = "gvChecksang";
            this.gvChecksang.ReadOnly = true;
            this.gvChecksang.RowHeadersWidth = 51;
            this.gvChecksang.RowTemplate.Height = 24;
            this.gvChecksang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvChecksang.Size = new System.Drawing.Size(705, 286);
            this.gvChecksang.TabIndex = 38;
            this.gvChecksang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChecksang1_CellContentClick);
            this.gvChecksang.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvChecksang_RowHeaderMouseClick);
            // 
            // dtpCheckInsang
            // 
            this.dtpCheckInsang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInsang.Location = new System.Drawing.Point(194, 126);
            this.dtpCheckInsang.Name = "dtpCheckInsang";
            this.dtpCheckInsang.Size = new System.Drawing.Size(362, 34);
            this.dtpCheckInsang.TabIndex = 33;
            // 
            // lblMaDa
            // 
            this.lblMaDa.BackColor = System.Drawing.Color.White;
            this.lblMaDa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDa.Location = new System.Drawing.Point(194, 182);
            this.lblMaDa.Name = "lblMaDa";
            this.lblMaDa.Size = new System.Drawing.Size(103, 30);
            this.lblMaDa.TabIndex = 57;
            this.lblMaDa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(59, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 30;
            this.label8.Text = "Check In ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(428, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mã chức vụ";
            // 
            // cbCheckInsang
            // 
            this.cbCheckInsang.BackColor = System.Drawing.Color.Transparent;
            this.cbCheckInsang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckInsang.ForeColor = System.Drawing.Color.Black;
            this.cbCheckInsang.Location = new System.Drawing.Point(591, 121);
            this.cbCheckInsang.Name = "cbCheckInsang";
            this.cbCheckInsang.Size = new System.Drawing.Size(109, 50);
            this.cbCheckInsang.TabIndex = 32;
            this.cbCheckInsang.Text = "Now";
            this.cbCheckInsang.UseVisualStyleBackColor = false;
            // 
            // txtMacvsang
            // 
            this.txtMacvsang.Enabled = false;
            this.txtMacvsang.Location = new System.Drawing.Point(591, 67);
            this.txtMacvsang.Name = "txtMacvsang";
            this.txtMacvsang.Size = new System.Drawing.Size(151, 35);
            this.txtMacvsang.TabIndex = 35;
            // 
            // txtManvsang
            // 
            this.txtManvsang.Enabled = false;
            this.txtManvsang.Location = new System.Drawing.Point(249, 65);
            this.txtManvsang.Name = "txtManvsang";
            this.txtManvsang.Size = new System.Drawing.Size(151, 35);
            this.txtManvsang.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(59, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 30);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mã Nhân viên ";
            // 
            // btnSubmitsang
            // 
            this.btnSubmitsang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitsang.Location = new System.Drawing.Point(330, 178);
            this.btnSubmitsang.Name = "btnSubmitsang";
            this.btnSubmitsang.Size = new System.Drawing.Size(86, 34);
            this.btnSubmitsang.TabIndex = 34;
            this.btnSubmitsang.Text = "Submit";
            this.btnSubmitsang.UseVisualStyleBackColor = true;
            this.btnSubmitsang.Click += new System.EventHandler(this.btnSubmitsang_Click);
            // 
            // artanPannel1
            // 
            this.artanPannel1.BackColor = System.Drawing.Color.White;
            this.artanPannel1.BorderRadius = 60;
            this.artanPannel1.Controls.Add(this.label3);
            this.artanPannel1.ForeColor = System.Drawing.Color.Black;
            this.artanPannel1.GradientAngle = 90F;
            this.artanPannel1.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel1.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(95)))), ((int)(((byte)(231)))));
            this.artanPannel1.Location = new System.Drawing.Point(458, 16);
            this.artanPannel1.Name = "artanPannel1";
            this.artanPannel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel1.Size = new System.Drawing.Size(444, 64);
            this.artanPannel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 44);
            this.label3.TabIndex = 37;
            this.label3.Text = "Thông Tin Điểm Danh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpCheckchieu
            // 
            this.tpCheckchieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.tpCheckchieu.Controls.Add(this.pnlThongtinCheckout);
            this.tpCheckchieu.Controls.Add(this.artanPannel2);
            this.tpCheckchieu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCheckchieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpCheckchieu.Location = new System.Drawing.Point(4, 25);
            this.tpCheckchieu.Name = "tpCheckchieu";
            this.tpCheckchieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckchieu.Size = new System.Drawing.Size(1347, 790);
            this.tpCheckchieu.TabIndex = 1;
            this.tpCheckchieu.Text = "Buổi Chiều ";
            this.tpCheckchieu.Click += new System.EventHandler(this.tpCheckchieu_Click);
            // 
            // pnlThongtinCheckout
            // 
            this.pnlThongtinCheckout.BackColor = System.Drawing.Color.White;
            this.pnlThongtinCheckout.BorderRadius = 50;
            this.pnlThongtinCheckout.Controls.Add(this.txtPhanTram);
            this.pnlThongtinCheckout.Controls.Add(this.artanPannel4);
            this.pnlThongtinCheckout.Controls.Add(this.label12);
            this.pnlThongtinCheckout.Controls.Add(this.dtpCheckOutchieu);
            this.pnlThongtinCheckout.Controls.Add(this.txtMacvchieu);
            this.pnlThongtinCheckout.Controls.Add(this.label5);
            this.pnlThongtinCheckout.Controls.Add(this.label9);
            this.pnlThongtinCheckout.Controls.Add(this.cbCheckOutchieu);
            this.pnlThongtinCheckout.Controls.Add(this.btnSubmitchieu);
            this.pnlThongtinCheckout.Controls.Add(this.label2);
            this.pnlThongtinCheckout.Controls.Add(this.txtManvchieu);
            this.pnlThongtinCheckout.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.pnlThongtinCheckout.ForeColor = System.Drawing.Color.Transparent;
            this.pnlThongtinCheckout.GradientAngle = 90F;
            this.pnlThongtinCheckout.GradientBttomColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongtinCheckout.GradientTopcolor = System.Drawing.Color.WhiteSmoke;
            this.pnlThongtinCheckout.Location = new System.Drawing.Point(264, 102);
            this.pnlThongtinCheckout.Name = "pnlThongtinCheckout";
            this.pnlThongtinCheckout.Size = new System.Drawing.Size(847, 601);
            this.pnlThongtinCheckout.TabIndex = 57;
            // 
            // txtPhanTram
            // 
            this.txtPhanTram.Location = new System.Drawing.Point(346, 191);
            this.txtPhanTram.Name = "txtPhanTram";
            this.txtPhanTram.Size = new System.Drawing.Size(75, 35);
            this.txtPhanTram.TabIndex = 55;
            // 
            // artanPannel4
            // 
            this.artanPannel4.BackColor = System.Drawing.Color.White;
            this.artanPannel4.BorderRadius = 30;
            this.artanPannel4.Controls.Add(this.gvCheckchieu);
            this.artanPannel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(94)))), ((int)(((byte)(231)))));
            this.artanPannel4.GradientAngle = 90F;
            this.artanPannel4.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel4.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(95)))), ((int)(((byte)(231)))));
            this.artanPannel4.Location = new System.Drawing.Point(65, 258);
            this.artanPannel4.Name = "artanPannel4";
            this.artanPannel4.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel4.Size = new System.Drawing.Size(725, 306);
            this.artanPannel4.TabIndex = 50;
            // 
            // gvCheckchieu
            // 
            this.gvCheckchieu.AllowUserToAddRows = false;
            this.gvCheckchieu.AllowUserToDeleteRows = false;
            this.gvCheckchieu.AllowUserToResizeColumns = false;
            this.gvCheckchieu.AllowUserToResizeRows = false;
            this.gvCheckchieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCheckchieu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvCheckchieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCheckchieu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvCheckchieu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCheckchieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCheckchieu.ColumnHeadersHeight = 35;
            this.gvCheckchieu.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(94)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCheckchieu.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvCheckchieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvCheckchieu.EnableHeadersVisualStyles = false;
            this.gvCheckchieu.Location = new System.Drawing.Point(10, 10);
            this.gvCheckchieu.MultiSelect = false;
            this.gvCheckchieu.Name = "gvCheckchieu";
            this.gvCheckchieu.RowHeadersVisible = false;
            this.gvCheckchieu.RowHeadersWidth = 51;
            this.gvCheckchieu.RowTemplate.Height = 24;
            this.gvCheckchieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCheckchieu.Size = new System.Drawing.Size(705, 286);
            this.gvCheckchieu.TabIndex = 35;
            this.gvCheckchieu.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Row_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(90, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 31);
            this.label12.TabIndex = 54;
            this.label12.Text = "Mức độ hoàn thành";
            // 
            // dtpCheckOutchieu
            // 
            this.dtpCheckOutchieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutchieu.Location = new System.Drawing.Point(206, 126);
            this.dtpCheckOutchieu.Name = "dtpCheckOutchieu";
            this.dtpCheckOutchieu.Size = new System.Drawing.Size(334, 34);
            this.dtpCheckOutchieu.TabIndex = 46;
            // 
            // txtMacvchieu
            // 
            this.txtMacvchieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.txtMacvchieu.Location = new System.Drawing.Point(613, 62);
            this.txtMacvchieu.Name = "txtMacvchieu";
            this.txtMacvchieu.Size = new System.Drawing.Size(166, 35);
            this.txtMacvchieu.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(90, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "Mã Nhân viên ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(459, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 31);
            this.label9.TabIndex = 52;
            this.label9.Text = "Mã chức vụ";
            // 
            // cbCheckOutchieu
            // 
            this.cbCheckOutchieu.BackColor = System.Drawing.Color.Transparent;
            this.cbCheckOutchieu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckOutchieu.ForeColor = System.Drawing.Color.Black;
            this.cbCheckOutchieu.Location = new System.Drawing.Point(574, 120);
            this.cbCheckOutchieu.Name = "cbCheckOutchieu";
            this.cbCheckOutchieu.Size = new System.Drawing.Size(117, 50);
            this.cbCheckOutchieu.TabIndex = 48;
            this.cbCheckOutchieu.Text = "Now";
            this.cbCheckOutchieu.UseVisualStyleBackColor = false;
            // 
            // btnSubmitchieu
            // 
            this.btnSubmitchieu.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmitchieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitchieu.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitchieu.Location = new System.Drawing.Point(455, 192);
            this.btnSubmitchieu.Name = "btnSubmitchieu";
            this.btnSubmitchieu.Size = new System.Drawing.Size(85, 34);
            this.btnSubmitchieu.TabIndex = 51;
            this.btnSubmitchieu.Text = "Submit";
            this.btnSubmitchieu.UseVisualStyleBackColor = false;
            this.btnSubmitchieu.Click += new System.EventHandler(this.btnSubmitchieu_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 49;
            this.label2.Text = "Check Out";
            // 
            // txtManvchieu
            // 
            this.txtManvchieu.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.txtManvchieu.Location = new System.Drawing.Point(271, 64);
            this.txtManvchieu.Name = "txtManvchieu";
            this.txtManvchieu.Size = new System.Drawing.Size(166, 35);
            this.txtManvchieu.TabIndex = 50;
            // 
            // artanPannel2
            // 
            this.artanPannel2.BackColor = System.Drawing.Color.White;
            this.artanPannel2.BorderRadius = 60;
            this.artanPannel2.Controls.Add(this.label1);
            this.artanPannel2.ForeColor = System.Drawing.Color.Black;
            this.artanPannel2.GradientAngle = 90F;
            this.artanPannel2.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel2.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(95)))), ((int)(((byte)(231)))));
            this.artanPannel2.Location = new System.Drawing.Point(458, 16);
            this.artanPannel2.Name = "artanPannel2";
            this.artanPannel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPannel2.Size = new System.Drawing.Size(444, 64);
            this.artanPannel2.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 44);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thông Tin Điểm Danh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fCheckin_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 819);
            this.Controls.Add(this.tabDiemdanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCheckin_Checkout";
            this.Text = "Checkin_Checkout";
            this.Load += new System.EventHandler(this.fCheckin_Checkout_Load);
            this.tabDiemdanh.ResumeLayout(false);
            this.tpCheckSang.ResumeLayout(false);
            this.pnlThongtinCheckIn.ResumeLayout(false);
            this.pnlThongtinCheckIn.PerformLayout();
            this.pnlgridviewsang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChecksang)).EndInit();
            this.artanPannel1.ResumeLayout(false);
            this.tpCheckchieu.ResumeLayout(false);
            this.pnlThongtinCheckout.ResumeLayout(false);
            this.pnlThongtinCheckout.PerformLayout();
            this.artanPannel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckchieu)).EndInit();
            this.artanPannel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDiemdanh;
        private System.Windows.Forms.TabPage tpCheckSang;
        private System.Windows.Forms.TabPage tpCheckchieu;
        private System.Windows.Forms.DataGridView gvCheckchieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvChecksang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMacvsang;
        private System.Windows.Forms.Button btnSubmitsang;
        private System.Windows.Forms.DateTimePicker dtpCheckInsang;
        private System.Windows.Forms.CheckBox cbCheckInsang;
        private System.Windows.Forms.TextBox txtManvsang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhanTram;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMacvchieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmitchieu;
        private System.Windows.Forms.TextBox txtManvchieu;
        private System.Windows.Forms.DateTimePicker dtpCheckOutchieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCheckOutchieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label label6;
        private ArtanComponent.ArtanPannel artanPannel1;
        private ArtanComponent.ArtanPannel pnlgridviewsang;
        private ArtanComponent.ArtanPannel pnlThongtinCheckIn;
        private ArtanComponent.ArtanPannel artanPannel2;
        private System.Windows.Forms.Label label1;
        private ArtanComponent.ArtanPannel pnlThongtinCheckout;
        private ArtanComponent.ArtanPannel artanPannel4;
    }
}