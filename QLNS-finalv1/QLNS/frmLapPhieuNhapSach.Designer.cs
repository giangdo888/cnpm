namespace QLNS
{
    partial class frmLapPhieuNhapSach
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
            this.lbMaPhieuNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaSach = new System.Windows.Forms.ComboBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.dataGridViewPhieuNhapSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewDSSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhapSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaPhieuNhap
            // 
            this.lbMaPhieuNhap.AutoSize = true;
            this.lbMaPhieuNhap.Location = new System.Drawing.Point(43, 34);
            this.lbMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaPhieuNhap.Name = "lbMaPhieuNhap";
            this.lbMaPhieuNhap.Size = new System.Drawing.Size(81, 13);
            this.lbMaPhieuNhap.TabIndex = 0;
            this.lbMaPhieuNhap.Text = "Mã phiếu nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // tbMaPhieuNhap
            // 
            this.tbMaPhieuNhap.Location = new System.Drawing.Point(166, 30);
            this.tbMaPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaPhieuNhap.Name = "tbMaPhieuNhap";
            this.tbMaPhieuNhap.Size = new System.Drawing.Size(76, 20);
            this.tbMaPhieuNhap.TabIndex = 5;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(166, 123);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(56, 20);
            this.tbSoLuong.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBoxMaSach
            // 
            this.comboBoxMaSach.FormattingEnabled = true;
            this.comboBoxMaSach.Location = new System.Drawing.Point(166, 91);
            this.comboBoxMaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMaSach.Name = "comboBoxMaSach";
            this.comboBoxMaSach.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMaSach.TabIndex = 8;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(151, 158);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(104, 21);
            this.btnLapPhieu.TabIndex = 9;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // dataGridViewPhieuNhapSach
            // 
            this.dataGridViewPhieuNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuNhapSach.Location = new System.Drawing.Point(9, 195);
            this.dataGridViewPhieuNhapSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPhieuNhapSach.Name = "dataGridViewPhieuNhapSach";
            this.dataGridViewPhieuNhapSach.RowTemplate.Height = 24;
            this.dataGridViewPhieuNhapSach.Size = new System.Drawing.Size(413, 264);
            this.dataGridViewPhieuNhapSach.TabIndex = 10;
            // 
            // dataGridViewDSSach
            // 
            this.dataGridViewDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach.Location = new System.Drawing.Point(459, 109);
            this.dataGridViewDSSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewDSSach.Name = "dataGridViewDSSach";
            this.dataGridViewDSSach.RowTemplate.Height = 24;
            this.dataGridViewDSSach.Size = new System.Drawing.Size(630, 350);
            this.dataGridViewDSSach.TabIndex = 11;
            this.dataGridViewDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSach_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmLapPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDSSach);
            this.Controls.Add(this.dataGridViewPhieuNhapSach);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.comboBoxMaSach);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbMaPhieuNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMaPhieuNhap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLapPhieuNhapSach";
            this.Text = "frmLapPhieuNhapSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuNhapSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaPhieuNhap;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMaSach;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.DataGridView dataGridViewPhieuNhapSach;
        private System.Windows.Forms.DataGridView dataGridViewDSSach;
        private System.Windows.Forms.Label label1;
    }
}