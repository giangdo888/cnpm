namespace QLNS
{
    partial class frmLapHoaDonBanSach
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
            this.dataGridViewDSSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewDSHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaKhachHang = new System.Windows.Forms.TextBox();
            this.btnNhapHoaDon = new System.Windows.Forms.Button();
            this.textBoxMaHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMaSach = new System.Windows.Forms.ComboBox();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSSach
            // 
            this.dataGridViewDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach.Location = new System.Drawing.Point(528, 98);
            this.dataGridViewDSSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDSSach.Name = "dataGridViewDSSach";
            this.dataGridViewDSSach.RowTemplate.Height = 24;
            this.dataGridViewDSSach.Size = new System.Drawing.Size(630, 350);
            this.dataGridViewDSSach.TabIndex = 0;
            // 
            // dataGridViewDSHoaDon
            // 
            this.dataGridViewDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHoaDon.Location = new System.Drawing.Point(9, 209);
            this.dataGridViewDSHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDSHoaDon.Name = "dataGridViewDSHoaDon";
            this.dataGridViewDSHoaDon.RowTemplate.Height = 24;
            this.dataGridViewDSHoaDon.Size = new System.Drawing.Size(488, 239);
            this.dataGridViewDSHoaDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "LẬP HÓA ĐƠN BÁN SÁCH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập thông tin hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày lập hóa đơn:";
            // 
            // textBoxMaKhachHang
            // 
            this.textBoxMaKhachHang.Location = new System.Drawing.Point(230, 91);
            this.textBoxMaKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaKhachHang.Name = "textBoxMaKhachHang";
            this.textBoxMaKhachHang.Size = new System.Drawing.Size(128, 20);
            this.textBoxMaKhachHang.TabIndex = 20;
            // 
            // btnNhapHoaDon
            // 
            this.btnNhapHoaDon.Location = new System.Drawing.Point(200, 186);
            this.btnNhapHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhapHoaDon.Name = "btnNhapHoaDon";
            this.btnNhapHoaDon.Size = new System.Drawing.Size(88, 19);
            this.btnNhapHoaDon.TabIndex = 24;
            this.btnNhapHoaDon.Text = "Nhập hóa đơn";
            this.btnNhapHoaDon.UseVisualStyleBackColor = true;
            this.btnNhapHoaDon.Click += new System.EventHandler(this.btnNhapHoaDon_Click);
            // 
            // textBoxMaHoaDon
            // 
            this.textBoxMaHoaDon.Location = new System.Drawing.Point(230, 68);
            this.textBoxMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaHoaDon.Name = "textBoxMaHoaDon";
            this.textBoxMaHoaDon.Size = new System.Drawing.Size(128, 20);
            this.textBoxMaHoaDon.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // dateTimePickerNgayLapHoaDon
            // 
            this.dateTimePickerNgayLapHoaDon.Location = new System.Drawing.Point(230, 138);
            this.dateTimePickerNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerNgayLapHoaDon.Name = "dateTimePickerNgayLapHoaDon";
            this.dateTimePickerNgayLapHoaDon.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerNgayLapHoaDon.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mã sách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số lượng:";
            // 
            // comboBoxMaSach
            // 
            this.comboBoxMaSach.FormattingEnabled = true;
            this.comboBoxMaSach.Location = new System.Drawing.Point(230, 114);
            this.comboBoxMaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMaSach.Name = "comboBoxMaSach";
            this.comboBoxMaSach.Size = new System.Drawing.Size(128, 21);
            this.comboBoxMaSach.TabIndex = 30;
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Location = new System.Drawing.Point(230, 161);
            this.textBoxSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(76, 20);
            this.textBoxSoLuong.TabIndex = 31;
            // 
            // frmLapHoaDonBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 583);
            this.Controls.Add(this.textBoxSoLuong);
            this.Controls.Add(this.comboBoxMaSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerNgayLapHoaDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMaHoaDon);
            this.Controls.Add(this.btnNhapHoaDon);
            this.Controls.Add(this.textBoxMaKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDSHoaDon);
            this.Controls.Add(this.dataGridViewDSSach);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLapHoaDonBanSach";
            this.Text = "frmLapHoaDonBanSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSSach;
        private System.Windows.Forms.DataGridView dataGridViewDSHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaKhachHang;
        private System.Windows.Forms.Button btnNhapHoaDon;
        private System.Windows.Forms.TextBox textBoxMaHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMaSach;
        private System.Windows.Forms.TextBox textBoxSoLuong;
    }
}