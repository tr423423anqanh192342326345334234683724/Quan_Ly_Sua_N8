namespace Quan_Ly_Sua_N8
{
    partial class ThuNhapCuaHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thangtruoc = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 208);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1269, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thu Nhập Của Cửa Hàng";
            // 
            // btn_thangtruoc
            // 
            this.btn_thangtruoc.Location = new System.Drawing.Point(75, 172);
            this.btn_thangtruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thangtruoc.Name = "btn_thangtruoc";
            this.btn_thangtruoc.Size = new System.Drawing.Size(148, 28);
            this.btn_thangtruoc.TabIndex = 2;
            this.btn_thangtruoc.Text = "Tháng Trước";
            this.btn_thangtruoc.UseVisualStyleBackColor = true;
            this.btn_thangtruoc.Click += new System.EventHandler(this.btn_thangtruoc_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(881, 91);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btn_timkiem.TabIndex = 3;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(444, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 22);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.comboBox1.Location = new System.Drawing.Point(231, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // ThuNhapCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 784);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_thangtruoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThuNhapCuaHang";
            this.Text = "ThuNhapCuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thangtruoc;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}