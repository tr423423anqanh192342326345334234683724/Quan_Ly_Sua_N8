namespace Quan_Ly_Sua_N8
{
    partial class TimKiemHoaDon
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvhd);
            this.groupBox2.Location = new System.Drawing.Point(117, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 210);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông TIn Hóa Đơn";
            // 
            // dgvhd
            // 
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Location = new System.Drawing.Point(15, 27);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersWidth = 51;
            this.dgvhd.RowTemplate.Height = 24;
            this.dgvhd.Size = new System.Drawing.Size(546, 183);
            this.dgvhd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(117, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(154, 124);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(340, 124);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 28);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(216, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(203, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(327, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "TÌM KIẾM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TimKiemHoaDon";
            this.Text = "TimKiemHoaDon";
            this.Load += new System.EventHandler(this.TimKiemHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}