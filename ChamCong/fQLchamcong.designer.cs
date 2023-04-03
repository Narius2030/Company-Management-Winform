namespace QLConTy_Entity.ChamCong
{
    partial class fQLchamcong
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
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lblmacongviec = new System.Windows.Forms.Label();
            this.lblcalamviec = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.gvChamcong = new System.Windows.Forms.DataGridView();
            this.txtMacv = new System.Windows.Forms.TextBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnfilterThang = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvChamcong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanhanvien.Location = new System.Drawing.Point(14, 32);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(104, 18);
            this.lblmanhanvien.TabIndex = 0;
            this.lblmanhanvien.Text = "Mã Nhân Viên ";
            // 
            // lblmacongviec
            // 
            this.lblmacongviec.AutoSize = true;
            this.lblmacongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmacongviec.Location = new System.Drawing.Point(14, 80);
            this.lblmacongviec.Name = "lblmacongviec";
            this.lblmacongviec.Size = new System.Drawing.Size(105, 18);
            this.lblmacongviec.TabIndex = 1;
            this.lblmacongviec.Text = "Mã Công Việc ";
            // 
            // lblcalamviec
            // 
            this.lblcalamviec.AutoSize = true;
            this.lblcalamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalamviec.Location = new System.Drawing.Point(417, 32);
            this.lblcalamviec.Name = "lblcalamviec";
            this.lblcalamviec.Size = new System.Drawing.Size(113, 18);
            this.lblcalamviec.TabIndex = 4;
            this.lblcalamviec.Text = "Số ngày đã nghỉ";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(176, 32);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(174, 22);
            this.txtManv.TabIndex = 10;
            // 
            // gvChamcong
            // 
            this.gvChamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChamcong.Location = new System.Drawing.Point(45, 203);
            this.gvChamcong.Name = "gvChamcong";
            this.gvChamcong.RowHeadersWidth = 51;
            this.gvChamcong.RowTemplate.Height = 24;
            this.gvChamcong.Size = new System.Drawing.Size(877, 298);
            this.gvChamcong.TabIndex = 11;
            this.gvChamcong.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvChamcong_RowHeaderMouseClick);
            // 
            // txtMacv
            // 
            this.txtMacv.Location = new System.Drawing.Point(176, 76);
            this.txtMacv.Name = "txtMacv";
            this.txtMacv.Size = new System.Drawing.Size(174, 22);
            this.txtMacv.TabIndex = 12;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(563, 31);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(155, 24);
            this.cboThang.TabIndex = 16;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnfilterThang);
            this.groupBox1.Controls.Add(this.btnReLoad);
            this.groupBox1.Controls.Add(this.cboThang);
            this.groupBox1.Controls.Add(this.txtMacv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.lblcalamviec);
            this.groupBox1.Controls.Add(this.lblmacongviec);
            this.groupBox1.Controls.Add(this.lblmanhanvien);
            this.groupBox1.Location = new System.Drawing.Point(45, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 162);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin ";
            // 
            // btnfilterThang
            // 
            this.btnfilterThang.Location = new System.Drawing.Point(724, 30);
            this.btnfilterThang.Name = "btnfilterThang";
            this.btnfilterThang.Size = new System.Drawing.Size(40, 25);
            this.btnfilterThang.TabIndex = 18;
            this.btnfilterThang.Text = "Fill";
            this.btnfilterThang.UseVisualStyleBackColor = true;
            this.btnfilterThang.Click += new System.EventHandler(this.btnfilterThang_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(17, 117);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(83, 28);
            this.btnReLoad.TabIndex = 19;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // fQLchamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvChamcong);
            this.Name = "fQLchamcong";
            this.Text = "Quản Lý Chấm Công ";
            this.Load += new System.EventHandler(this.frmquanlychamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvChamcong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lblmacongviec;
        private System.Windows.Forms.Label lblcalamviec;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.DataGridView gvChamcong;
        private System.Windows.Forms.TextBox txtMacv;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnfilterThang;
    }
}