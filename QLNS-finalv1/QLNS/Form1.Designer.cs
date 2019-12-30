namespace QLNS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhieuNhapSach = new System.Windows.Forms.Button();
            this.btnHoaDonBanSach = new System.Windows.Forms.Button();
            this.btnTraCuuSach = new System.Windows.Forms.Button();
            this.btnLapPhieuThuTien = new System.Windows.Forms.Button();
            this.btnLapBaoCaoThang = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelParent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ NHÀ SÁCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPhieuNhapSach
            // 
            this.btnPhieuNhapSach.Location = new System.Drawing.Point(8, 100);
            this.btnPhieuNhapSach.Name = "btnPhieuNhapSach";
            this.btnPhieuNhapSach.Size = new System.Drawing.Size(176, 58);
            this.btnPhieuNhapSach.TabIndex = 3;
            this.btnPhieuNhapSach.Text = "Lập phiếu nhập sách";
            this.btnPhieuNhapSach.UseVisualStyleBackColor = true;
            this.btnPhieuNhapSach.Click += new System.EventHandler(this.btnPhieuNhapSach_Click);
            // 
            // btnHoaDonBanSach
            // 
            this.btnHoaDonBanSach.Location = new System.Drawing.Point(8, 164);
            this.btnHoaDonBanSach.Name = "btnHoaDonBanSach";
            this.btnHoaDonBanSach.Size = new System.Drawing.Size(176, 62);
            this.btnHoaDonBanSach.TabIndex = 4;
            this.btnHoaDonBanSach.Text = "Lập hóa đơn bán sách";
            this.btnHoaDonBanSach.UseVisualStyleBackColor = true;
            this.btnHoaDonBanSach.Click += new System.EventHandler(this.btnHoaDonBanSach_Click);
            // 
            // btnTraCuuSach
            // 
            this.btnTraCuuSach.Location = new System.Drawing.Point(8, 232);
            this.btnTraCuuSach.Name = "btnTraCuuSach";
            this.btnTraCuuSach.Size = new System.Drawing.Size(176, 62);
            this.btnTraCuuSach.TabIndex = 5;
            this.btnTraCuuSach.Text = "Tra cứu sách";
            this.btnTraCuuSach.UseVisualStyleBackColor = true;
            this.btnTraCuuSach.Click += new System.EventHandler(this.btnTraCuuSach_Click);
            // 
            // btnLapPhieuThuTien
            // 
            this.btnLapPhieuThuTien.Location = new System.Drawing.Point(7, 300);
            this.btnLapPhieuThuTien.Name = "btnLapPhieuThuTien";
            this.btnLapPhieuThuTien.Size = new System.Drawing.Size(177, 67);
            this.btnLapPhieuThuTien.TabIndex = 6;
            this.btnLapPhieuThuTien.Text = "Lập phiếu thu tiền";
            this.btnLapPhieuThuTien.UseVisualStyleBackColor = true;
            this.btnLapPhieuThuTien.Click += new System.EventHandler(this.btnLapPhieuThuTien_Click);
            // 
            // btnLapBaoCaoThang
            // 
            this.btnLapBaoCaoThang.Location = new System.Drawing.Point(8, 373);
            this.btnLapBaoCaoThang.Name = "btnLapBaoCaoThang";
            this.btnLapBaoCaoThang.Size = new System.Drawing.Size(176, 64);
            this.btnLapBaoCaoThang.TabIndex = 7;
            this.btnLapBaoCaoThang.Text = "Lập báo cáo tháng";
            this.btnLapBaoCaoThang.UseVisualStyleBackColor = true;
            this.btnLapBaoCaoThang.Click += new System.EventHandler(this.btnLapBaoCaoThang_Click);
            // 
            // btnThayDoiQuyDinh
            // 
            this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(7, 443);
            this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
            this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(176, 70);
            this.btnThayDoiQuyDinh.TabIndex = 8;
            this.btnThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.btnThayDoiQuyDinh.UseVisualStyleBackColor = true;
            this.btnThayDoiQuyDinh.Click += new System.EventHandler(this.btnThayDoiQuyDinh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.Controls.Add(this.btnThayDoiQuyDinh);
            this.panel1.Controls.Add(this.btnLapBaoCaoThang);
            this.panel1.Controls.Add(this.btnLapPhieuThuTien);
            this.panel1.Controls.Add(this.btnTraCuuSach);
            this.panel1.Controls.Add(this.btnHoaDonBanSach);
            this.panel1.Controls.Add(this.btnPhieuNhapSach);
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 613);
            this.panel1.TabIndex = 9;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(9, 35);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(174, 59);
            this.btnTrangChu.TabIndex = 9;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 100);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelParent
            // 
            this.panelParent.Location = new System.Drawing.Point(192, 100);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(1178, 613);
            this.panelParent.TabIndex = 12;
            this.panelParent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelParent_Paint);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1369, 708);
            this.Controls.Add(this.panelParent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhieuNhapSach;
        private System.Windows.Forms.Button btnHoaDonBanSach;
        private System.Windows.Forms.Button btnTraCuuSach;
        private System.Windows.Forms.Button btnLapPhieuThuTien;
        private System.Windows.Forms.Button btnLapBaoCaoThang;
        private System.Windows.Forms.Button btnThayDoiQuyDinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

