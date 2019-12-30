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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            frmTrangChu frm = new frmTrangChu();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmTrangChu frm = new frmTrangChu();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

       

        private void btnPhieuNhapSach_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmLapPhieuNhapSach frm = new frmLapPhieuNhapSach();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHoaDonBanSach_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmLapHoaDonBanSach frm = new frmLapHoaDonBanSach();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnTraCuuSach_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmTraCuuSach frm = new frmTraCuuSach();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmLapPhieuThuTien frm = new frmLapPhieuThuTien();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmLapBaoCaoThang frm = new frmLapBaoCaoThang();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            panelParent.Controls.Clear();
            frmThayDoiQuyDinh frm = new frmThayDoiQuyDinh();
            frm.TopLevel = false;
            panelParent.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void panelParent_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
    }
}
