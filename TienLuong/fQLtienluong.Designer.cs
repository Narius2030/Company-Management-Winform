namespace QLCongTy.TienLuong
{
    partial class fTienLuong
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
            this.artanPannel2 = new ArtanComponent.ArtanPannel();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new QLCongTy.VBButton();
            this.artanPannel1 = new ArtanComponent.ArtanPannel();
            this.gvTienLuong = new System.Windows.Forms.DataGridView();
            this.artanPannel2.SuspendLayout();
            this.artanPannel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTienLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPannel2
            // 
            this.artanPannel2.BackColor = System.Drawing.Color.White;
            this.artanPannel2.BorderRadius = 40;
            this.artanPannel2.Controls.Add(this.cboNam);
            this.artanPannel2.Controls.Add(this.cboThang);
            this.artanPannel2.Controls.Add(this.btnLamMoi);
            this.artanPannel2.ForeColor = System.Drawing.Color.Black;
            this.artanPannel2.GradientAngle = 90F;
            this.artanPannel2.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel2.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(228)))));
            this.artanPannel2.Location = new System.Drawing.Point(62, 96);
            this.artanPannel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artanPannel2.Name = "artanPannel2";
            this.artanPannel2.Size = new System.Drawing.Size(349, 80);
            this.artanPannel2.TabIndex = 92;
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cboNam.Location = new System.Drawing.Point(34, 28);
            this.cboNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(72, 27);
            this.cboNam.TabIndex = 89;
            this.cboNam.Text = "Năm";
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // cboThang
            // 
            this.cboThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.cboThang.Location = new System.Drawing.Point(123, 28);
            this.cboThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(79, 27);
            this.cboThang.TabIndex = 90;
            this.cboThang.Text = "Tháng";
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnLamMoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnLamMoi.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLamMoi.Location = new System.Drawing.Point(221, 24);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(79, 31);
            this.btnLamMoi.TabIndex = 87;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.RoyalBlue;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // artanPannel1
            // 
            this.artanPannel1.BackColor = System.Drawing.Color.White;
            this.artanPannel1.BorderRadius = 30;
            this.artanPannel1.Controls.Add(this.gvTienLuong);
            this.artanPannel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.artanPannel1.GradientAngle = 90F;
            this.artanPannel1.GradientBttomColor = System.Drawing.Color.DarkOrchid;
            this.artanPannel1.GradientTopcolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(228)))));
            this.artanPannel1.Location = new System.Drawing.Point(62, 188);
            this.artanPannel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artanPannel1.Name = "artanPannel1";
            this.artanPannel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 15);
            this.artanPannel1.Size = new System.Drawing.Size(844, 382);
            this.artanPannel1.TabIndex = 91;
            // 
            // gvTienLuong
            // 
            this.gvTienLuong.AllowUserToAddRows = false;
            this.gvTienLuong.AllowUserToDeleteRows = false;
            this.gvTienLuong.AllowUserToResizeColumns = false;
            this.gvTienLuong.AllowUserToResizeRows = false;
            this.gvTienLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvTienLuong.BackgroundColor = System.Drawing.Color.White;
            this.gvTienLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvTienLuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvTienLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(231)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvTienLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTienLuong.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(99)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvTienLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvTienLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTienLuong.EnableHeadersVisualStyles = false;
            this.gvTienLuong.GridColor = System.Drawing.Color.DarkGray;
            this.gvTienLuong.Location = new System.Drawing.Point(8, 8);
            this.gvTienLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvTienLuong.MultiSelect = false;
            this.gvTienLuong.Name = "gvTienLuong";
            this.gvTienLuong.RowHeadersVisible = false;
            this.gvTienLuong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gvTienLuong.RowTemplate.DividerHeight = 2;
            this.gvTienLuong.RowTemplate.Height = 25;
            this.gvTienLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTienLuong.Size = new System.Drawing.Size(828, 359);
            this.gvTienLuong.TabIndex = 35;
            // 
            // fTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1016, 665);
            this.Controls.Add(this.artanPannel2);
            this.Controls.Add(this.artanPannel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fTienLuong";
            this.Text = "Quản lý tiền lương ";
            this.Load += new System.EventHandler(this.fTienLuong_Load);
            this.artanPannel2.ResumeLayout(false);
            this.artanPannel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTienLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gvTienLuong;
        private VBButton btnLamMoi;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private ArtanComponent.ArtanPannel artanPannel1;
        private ArtanComponent.ArtanPannel artanPannel2;
    }
}

