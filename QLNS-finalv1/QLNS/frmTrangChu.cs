using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thongtin.Text = "Trường Đại học Công nghệ Thông tin, Đại học Quốc gia Thành phố Hồ Chí Minh (ĐHQG-HCM)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            thongtin.Text = "Khoa kỹ thuật máy tính - Trường Đại học Công nghệ Thông tin";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thongtin.Text = "Sản phẩm được viết bởi: \n Vũ Hoàng Hy - 16520545 \n Đỗ Trường Giang - 16520317 \n Đỗ Thế Đức - 16520231";
        }

        private void thongtin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
