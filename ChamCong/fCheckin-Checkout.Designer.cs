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
            this.tabDiemdanh = new System.Windows.Forms.TabControl();
            this.tpCheckSang = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMacvsang = new System.Windows.Forms.TextBox();
            this.btnSubmitsang = new System.Windows.Forms.Button();
            this.dtpCheckInsang = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gvChecksang = new System.Windows.Forms.DataGridView();
            this.cbCheckInsang = new System.Windows.Forms.CheckBox();
            this.txtManvsang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpCheckchieu = new System.Windows.Forms.TabPage();
            this.txtMacvchieu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmitchieu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvCheckchieu = new System.Windows.Forms.DataGridView();
            this.txtManvchieu = new System.Windows.Forms.TextBox();
            this.dtpCheckOutchieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCheckOutchieu = new System.Windows.Forms.CheckBox();
            this.tabDiemdanh.SuspendLayout();
            this.tpCheckSang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecksang)).BeginInit();
            this.tpCheckchieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckchieu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDiemdanh
            // 
            this.tabDiemdanh.Controls.Add(this.tpCheckSang);
            this.tabDiemdanh.Controls.Add(this.tpCheckchieu);
            this.tabDiemdanh.Location = new System.Drawing.Point(12, 12);
            this.tabDiemdanh.Name = "tabDiemdanh";
            this.tabDiemdanh.SelectedIndex = 0;
            this.tabDiemdanh.Size = new System.Drawing.Size(1035, 433);
            this.tabDiemdanh.TabIndex = 0;
            // 
            // tpCheckSang
            // 
            this.tpCheckSang.Controls.Add(this.label4);
            this.tpCheckSang.Controls.Add(this.txtMacvsang);
            this.tpCheckSang.Controls.Add(this.btnSubmitsang);
            this.tpCheckSang.Controls.Add(this.dtpCheckInsang);
            this.tpCheckSang.Controls.Add(this.label6);
            this.tpCheckSang.Controls.Add(this.gvChecksang);
            this.tpCheckSang.Controls.Add(this.cbCheckInsang);
            this.tpCheckSang.Controls.Add(this.txtManvsang);
            this.tpCheckSang.Controls.Add(this.label8);
            this.tpCheckSang.Controls.Add(this.label10);
            this.tpCheckSang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCheckSang.Location = new System.Drawing.Point(4, 25);
            this.tpCheckSang.Name = "tpCheckSang";
            this.tpCheckSang.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckSang.Size = new System.Drawing.Size(1027, 404);
            this.tpCheckSang.TabIndex = 0;
            this.tpCheckSang.Text = "Buổi Sáng ";
            this.tpCheckSang.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã chức vụ";
            // 
            // txtMacvsang
            // 
            this.txtMacvsang.Location = new System.Drawing.Point(162, 127);
            this.txtMacvsang.Name = "txtMacvsang";
            this.txtMacvsang.Size = new System.Drawing.Size(214, 30);
            this.txtMacvsang.TabIndex = 27;
            // 
            // btnSubmitsang
            // 
            this.btnSubmitsang.Location = new System.Drawing.Point(20, 255);
            this.btnSubmitsang.Name = "btnSubmitsang";
            this.btnSubmitsang.Size = new System.Drawing.Size(86, 34);
            this.btnSubmitsang.TabIndex = 26;
            this.btnSubmitsang.Text = "Submit";
            this.btnSubmitsang.UseVisualStyleBackColor = true;
            this.btnSubmitsang.Click += new System.EventHandler(this.btnSubmitsang_Click);
            // 
            // dtpCheckInsang
            // 
            this.dtpCheckInsang.Location = new System.Drawing.Point(131, 190);
            this.dtpCheckInsang.Name = "dtpCheckInsang";
            this.dtpCheckInsang.Size = new System.Drawing.Size(245, 30);
            this.dtpCheckInsang.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(307, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "Thông Tin Điểm Danh";
            // 
            // gvChecksang
            // 
            this.gvChecksang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChecksang.Location = new System.Drawing.Point(492, 75);
            this.gvChecksang.Name = "gvChecksang";
            this.gvChecksang.RowHeadersWidth = 51;
            this.gvChecksang.RowTemplate.Height = 24;
            this.gvChecksang.Size = new System.Drawing.Size(519, 310);
            this.gvChecksang.TabIndex = 23;
            this.gvChecksang.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvChecksang_RowHeaderMouseClick);
            // 
            // cbCheckInsang
            // 
            this.cbCheckInsang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckInsang.Location = new System.Drawing.Point(396, 183);
            this.cbCheckInsang.Name = "cbCheckInsang";
            this.cbCheckInsang.Size = new System.Drawing.Size(193, 50);
            this.cbCheckInsang.TabIndex = 22;
            this.cbCheckInsang.Text = "Now";
            this.cbCheckInsang.UseVisualStyleBackColor = true;
            // 
            // txtManvsang
            // 
            this.txtManvsang.Location = new System.Drawing.Point(162, 75);
            this.txtManvsang.Name = "txtManvsang";
            this.txtManvsang.Size = new System.Drawing.Size(214, 30);
            this.txtManvsang.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Check In ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 30);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mã Nhân viên ";
            // 
            // tpCheckchieu
            // 
            this.tpCheckchieu.Controls.Add(this.txtMacvchieu);
            this.tpCheckchieu.Controls.Add(this.label9);
            this.tpCheckchieu.Controls.Add(this.btnSubmitchieu);
            this.tpCheckchieu.Controls.Add(this.label1);
            this.tpCheckchieu.Controls.Add(this.gvCheckchieu);
            this.tpCheckchieu.Controls.Add(this.txtManvchieu);
            this.tpCheckchieu.Controls.Add(this.dtpCheckOutchieu);
            this.tpCheckchieu.Controls.Add(this.label2);
            this.tpCheckchieu.Controls.Add(this.cbCheckOutchieu);
            this.tpCheckchieu.Controls.Add(this.label5);
            this.tpCheckchieu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tpCheckchieu.Location = new System.Drawing.Point(4, 25);
            this.tpCheckchieu.Name = "tpCheckchieu";
            this.tpCheckchieu.Padding = new System.Windows.Forms.Padding(3);
            this.tpCheckchieu.Size = new System.Drawing.Size(1027, 404);
            this.tpCheckchieu.TabIndex = 1;
            this.tpCheckchieu.Text = "Buổi Chiều ";
            this.tpCheckchieu.UseVisualStyleBackColor = true;
            // 
            // txtMacvchieu
            // 
            this.txtMacvchieu.Location = new System.Drawing.Point(162, 135);
            this.txtMacvchieu.Name = "txtMacvchieu";
            this.txtMacvchieu.Size = new System.Drawing.Size(214, 22);
            this.txtMacvchieu.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Mã chức vụ";
            // 
            // btnSubmitchieu
            // 
            this.btnSubmitchieu.Location = new System.Drawing.Point(20, 256);
            this.btnSubmitchieu.Name = "btnSubmitchieu";
            this.btnSubmitchieu.Size = new System.Drawing.Size(79, 35);
            this.btnSubmitchieu.TabIndex = 37;
            this.btnSubmitchieu.Text = "Submit";
            this.btnSubmitchieu.UseVisualStyleBackColor = true;
            this.btnSubmitchieu.Click += new System.EventHandler(this.btnSubmitchieu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(307, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thông Tin Điểm Danh";
            // 
            // gvCheckchieu
            // 
            this.gvCheckchieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCheckchieu.Location = new System.Drawing.Point(477, 75);
            this.gvCheckchieu.Name = "gvCheckchieu";
            this.gvCheckchieu.RowHeadersWidth = 51;
            this.gvCheckchieu.RowTemplate.Height = 24;
            this.gvCheckchieu.Size = new System.Drawing.Size(534, 310);
            this.gvCheckchieu.TabIndex = 35;
            // 
            // txtManvchieu
            // 
            this.txtManvchieu.Location = new System.Drawing.Point(162, 75);
            this.txtManvchieu.Name = "txtManvchieu";
            this.txtManvchieu.Size = new System.Drawing.Size(214, 22);
            this.txtManvchieu.TabIndex = 32;
            // 
            // dtpCheckOutchieu
            // 
            this.dtpCheckOutchieu.Location = new System.Drawing.Point(131, 198);
            this.dtpCheckOutchieu.Name = "dtpCheckOutchieu";
            this.dtpCheckOutchieu.Size = new System.Drawing.Size(245, 22);
            this.dtpCheckOutchieu.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Check Out";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã Nhân viên ";
            // 
            // cbCheckOutchieu
            // 
            this.cbCheckOutchieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckOutchieu.Location = new System.Drawing.Point(396, 184);
            this.cbCheckOutchieu.Name = "cbCheckOutchieu";
            this.cbCheckOutchieu.Size = new System.Drawing.Size(193, 50);
            this.cbCheckOutchieu.TabIndex = 27;
            this.cbCheckOutchieu.Text = "Now";
            this.cbCheckOutchieu.UseVisualStyleBackColor = true;
            // 
            // fCheckin_Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 455);
            this.Controls.Add(this.tabDiemdanh);
            this.Name = "fCheckin_Checkout";
            this.Text = "Checkin_Checkout";
            this.Load += new System.EventHandler(this.fCheckin_Checkout_Load);
            this.tabDiemdanh.ResumeLayout(false);
            this.tpCheckSang.ResumeLayout(false);
            this.tpCheckSang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecksang)).EndInit();
            this.tpCheckchieu.ResumeLayout(false);
            this.tpCheckchieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCheckchieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDiemdanh;
        private System.Windows.Forms.TabPage tpCheckSang;
        private System.Windows.Forms.TabPage tpCheckchieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvChecksang;
        private System.Windows.Forms.CheckBox cbCheckInsang;
        private System.Windows.Forms.TextBox txtManvsang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvCheckchieu;
        private System.Windows.Forms.TextBox txtManvchieu;
        private System.Windows.Forms.DateTimePicker dtpCheckOutchieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpCheckInsang;
        private System.Windows.Forms.Button btnSubmitsang;
        private System.Windows.Forms.Button btnSubmitchieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMacvsang;
        private System.Windows.Forms.TextBox txtMacvchieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbCheckOutchieu;
    }
}