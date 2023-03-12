namespace QLCongTy
{
    partial class fQLDAThamGia
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
            this.gvDAThamGia = new System.Windows.Forms.DataGridView();
            this.lblMaDA = new System.Windows.Forms.Label();
            this.lblTenDA = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDAThamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDAThamGia
            // 
            this.gvDAThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDAThamGia.Location = new System.Drawing.Point(12, 218);
            this.gvDAThamGia.Name = "gvDAThamGia";
            this.gvDAThamGia.RowHeadersWidth = 51;
            this.gvDAThamGia.RowTemplate.Height = 24;
            this.gvDAThamGia.Size = new System.Drawing.Size(848, 208);
            this.gvDAThamGia.TabIndex = 3;
            this.gvDAThamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDAThamGia_CellClick);
            this.gvDAThamGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDAThamGia_CellContentClick);
            // 
            // lblMaDA
            // 
            this.lblMaDA.AutoSize = true;
            this.lblMaDA.Location = new System.Drawing.Point(17, 59);
            this.lblMaDA.Name = "lblMaDA";
            this.lblMaDA.Size = new System.Drawing.Size(68, 16);
            this.lblMaDA.TabIndex = 4;
            this.lblMaDA.Text = "Mã Dự Án:";
            // 
            // lblTenDA
            // 
            this.lblTenDA.AutoSize = true;
            this.lblTenDA.Location = new System.Drawing.Point(17, 105);
            this.lblTenDA.Name = "lblTenDA";
            this.lblTenDA.Size = new System.Drawing.Size(73, 16);
            this.lblTenDA.TabIndex = 5;
            this.lblTenDA.Text = "Tên Dự Án:";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(474, 59);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(98, 16);
            this.lblMaPB.TabIndex = 6;
            this.lblMaPB.Text = "Mã Phòng Ban:";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(474, 105);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(103, 16);
            this.lblTenPB.TabIndex = 13;
            this.lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(185, 59);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(192, 22);
            this.txtMaDA.TabIndex = 14;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(185, 105);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(192, 22);
            this.txtTenDA.TabIndex = 15;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(656, 59);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(192, 22);
            this.txtMaPB.TabIndex = 16;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(656, 105);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(192, 22);
            this.txtTenPB.TabIndex = 17;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(285, 173);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // fQLDAThamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 438);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.lblMaPB);
            this.Controls.Add(this.lblTenDA);
            this.Controls.Add(this.lblMaDA);
            this.Controls.Add(this.gvDAThamGia);
            this.Name = "fQLDAThamGia";
            this.Text = "Quản Lý Dự Án Tham Gia";
            this.Load += new System.EventHandler(this.fQLDAThamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDAThamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDAThamGia;
        private System.Windows.Forms.Label lblMaDA;
        private System.Windows.Forms.Label lblTenDA;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
    }
}