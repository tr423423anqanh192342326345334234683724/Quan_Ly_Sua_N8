namespace Quan_Ly_Sua_N8
{
    partial class QL_HoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_mhd = new System.Windows.Forms.TextBox();
            this.tb_mnv = new System.Windows.Forms.TextBox();
            this.tb_mkh = new System.Windows.Forms.TextBox();
            this.tb_msp = new System.Windows.Forms.TextBox();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_hd = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_ngayban);
            this.groupBox1.Controls.Add(this.tb_dongia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_sl);
            this.groupBox1.Controls.Add(this.tb_msp);
            this.groupBox1.Controls.Add(this.tb_mkh);
            this.groupBox1.Controls.Add(this.tb_mnv);
            this.groupBox1.Controls.Add(this.tb_mhd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 251);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng";
            // 
            // tb_mhd
            // 
            this.tb_mhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mhd.Location = new System.Drawing.Point(158, 30);
            this.tb_mhd.Name = "tb_mhd";
            this.tb_mhd.Size = new System.Drawing.Size(355, 24);
            this.tb_mhd.TabIndex = 6;
            // 
            // tb_mnv
            // 
            this.tb_mnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mnv.Location = new System.Drawing.Point(158, 137);
            this.tb_mnv.Name = "tb_mnv";
            this.tb_mnv.Size = new System.Drawing.Size(355, 24);
            this.tb_mnv.TabIndex = 7;
            // 
            // tb_mkh
            // 
            this.tb_mkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mkh.Location = new System.Drawing.Point(158, 193);
            this.tb_mkh.Name = "tb_mkh";
            this.tb_mkh.Size = new System.Drawing.Size(355, 24);
            this.tb_mkh.TabIndex = 8;
            // 
            // tb_msp
            // 
            this.tb_msp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_msp.Location = new System.Drawing.Point(672, 30);
            this.tb_msp.Name = "tb_msp";
            this.tb_msp.Size = new System.Drawing.Size(366, 24);
            this.tb_msp.TabIndex = 9;
            // 
            // tb_sl
            // 
            this.tb_sl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sl.Location = new System.Drawing.Point(672, 85);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(366, 24);
            this.tb_sl.TabIndex = 10;
            // 
            // tb_dongia
            // 
            this.tb_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dongia.Location = new System.Drawing.Point(672, 140);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(366, 24);
            this.tb_dongia.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đơn giá";
            // 
            // dt_ngayban
            // 
            this.dt_ngayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngayban.Location = new System.Drawing.Point(158, 88);
            this.dt_ngayban.Name = "dt_ngayban";
            this.dt_ngayban.Size = new System.Drawing.Size(142, 24);
            this.dt_ngayban.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_hd);
            this.groupBox2.Location = new System.Drawing.Point(42, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgv_hd
            // 
            this.dgv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.TongTien});
            this.dgv_hd.Location = new System.Drawing.Point(7, 22);
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.RowHeadersWidth = 51;
            this.dgv_hd.RowTemplate.Height = 24;
            this.dgv_hd.Size = new System.Drawing.Size(1044, 243);
            this.dgv_hd.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(146, 347);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(81, 32);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(401, 347);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(81, 32);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(664, 347);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(81, 32);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(920, 347);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(81, 32);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHoaDon";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBan";
            this.Column2.HeaderText = "Ngày bán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNhanVien";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKhachHang";
            this.Column4.HeaderText = "Mã KH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSanPham";
            this.Column5.HeaderText = "Mã SP";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoLuong";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DonGia";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // QL_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 691);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QL_HoaDon";
            this.Text = "QL_HoaDon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngayban;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.TextBox tb_msp;
        private System.Windows.Forms.TextBox tb_mkh;
        private System.Windows.Forms.TextBox tb_mnv;
        private System.Windows.Forms.TextBox tb_mhd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_hd;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}