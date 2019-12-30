namespace QLNS
{
    partial class frmLapBaoCaoThang
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
            this.comboBoxBCT = new System.Windows.Forms.ComboBox();
            this.comboBoxBCCN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewBCT = new System.Windows.Forms.DataGridView();
            this.dataGridViewBCCN = new System.Windows.Forms.DataGridView();
            this.buttonXuatBCT = new System.Windows.Forms.Button();
            this.buttonXuatBCCN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCCN)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBCT
            // 
            this.comboBoxBCT.FormattingEnabled = true;
            this.comboBoxBCT.Location = new System.Drawing.Point(202, 109);
            this.comboBoxBCT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBCT.Name = "comboBoxBCT";
            this.comboBoxBCT.Size = new System.Drawing.Size(60, 21);
            this.comboBoxBCT.TabIndex = 0;
            // 
            // comboBoxBCCN
            // 
            this.comboBoxBCCN.FormattingEnabled = true;
            this.comboBoxBCCN.Location = new System.Drawing.Point(696, 109);
            this.comboBoxBCCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBCCN.Name = "comboBoxBCCN";
            this.comboBoxBCCN.Size = new System.Drawing.Size(61, 21);
            this.comboBoxBCCN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "BÁO CÁO THÁNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tháng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Báo cáo tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Báo cáo công nợ:";
            // 
            // dataGridViewBCT
            // 
            this.dataGridViewBCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBCT.Location = new System.Drawing.Point(14, 180);
            this.dataGridViewBCT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBCT.Name = "dataGridViewBCT";
            this.dataGridViewBCT.RowTemplate.Height = 24;
            this.dataGridViewBCT.Size = new System.Drawing.Size(459, 267);
            this.dataGridViewBCT.TabIndex = 20;
            // 
            // dataGridViewBCCN
            // 
            this.dataGridViewBCCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBCCN.Location = new System.Drawing.Point(518, 179);
            this.dataGridViewBCCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBCCN.Name = "dataGridViewBCCN";
            this.dataGridViewBCCN.RowTemplate.Height = 24;
            this.dataGridViewBCCN.Size = new System.Drawing.Size(459, 268);
            this.dataGridViewBCCN.TabIndex = 21;
            // 
            // buttonXuatBCT
            // 
            this.buttonXuatBCT.Location = new System.Drawing.Point(206, 147);
            this.buttonXuatBCT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXuatBCT.Name = "buttonXuatBCT";
            this.buttonXuatBCT.Size = new System.Drawing.Size(92, 22);
            this.buttonXuatBCT.TabIndex = 22;
            this.buttonXuatBCT.Text = "Xuất";
            this.buttonXuatBCT.UseVisualStyleBackColor = true;
            this.buttonXuatBCT.Click += new System.EventHandler(this.buttonXuatBCT_Click);
            // 
            // buttonXuatBCCN
            // 
            this.buttonXuatBCCN.Location = new System.Drawing.Point(703, 147);
            this.buttonXuatBCCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXuatBCCN.Name = "buttonXuatBCCN";
            this.buttonXuatBCCN.Size = new System.Drawing.Size(92, 22);
            this.buttonXuatBCCN.TabIndex = 23;
            this.buttonXuatBCCN.Text = "Xuất";
            this.buttonXuatBCCN.UseVisualStyleBackColor = true;
            this.buttonXuatBCCN.Click += new System.EventHandler(this.buttonXuatBCCN_Click);
            // 
            // frmLapBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 580);
            this.Controls.Add(this.buttonXuatBCCN);
            this.Controls.Add(this.buttonXuatBCT);
            this.Controls.Add(this.dataGridViewBCCN);
            this.Controls.Add(this.dataGridViewBCT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBCCN);
            this.Controls.Add(this.comboBoxBCT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLapBaoCaoThang";
            this.Text = "frmLapBaoCaoThang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBCCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBCT;
        private System.Windows.Forms.ComboBox comboBoxBCCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewBCT;
        private System.Windows.Forms.DataGridView dataGridViewBCCN;
        private System.Windows.Forms.Button buttonXuatBCT;
        private System.Windows.Forms.Button buttonXuatBCCN;
    }
}