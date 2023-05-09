namespace Entity_QLCongTy
{
    partial class fDuyetDonXinNghi
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
            this.gvDSXinNghi = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSXinNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDSXinNghi
            // 
            this.gvDSXinNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDSXinNghi.Location = new System.Drawing.Point(45, 179);
            this.gvDSXinNghi.Name = "gvDSXinNghi";
            this.gvDSXinNghi.RowHeadersWidth = 51;
            this.gvDSXinNghi.RowTemplate.Height = 24;
            this.gvDSXinNghi.Size = new System.Drawing.Size(424, 518);
            this.gvDSXinNghi.TabIndex = 0;
            this.gvDSXinNghi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDSXinNghi_RowHeaderMouseClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1355, 93);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DANH SÁCH ĐƠN XIN NGHỈ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fDuyetDonXinNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1355, 819);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gvDSXinNghi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDuyetDonXinNghi";
            this.Text = "Duyệt đơn xin nghỉ";
            this.Load += new System.EventHandler(this.fDuyetDonXinNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDSXinNghi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDSXinNghi;
        private System.Windows.Forms.Label lblTitle;
    }
}