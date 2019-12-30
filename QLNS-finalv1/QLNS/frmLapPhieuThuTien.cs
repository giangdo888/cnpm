using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSBUS;
using QLNSDAL;
using QLNSDTO;

namespace QLNS
{
    public partial class frmLapPhieuThuTien : Form
    {
        private KhachHangBUS buskh;
        private HoaDonBUS bushd;
        private PhieuThuBUS buspt;
        public frmLapPhieuThuTien()
        {
            InitializeComponent();
            buskh = new KhachHangBUS();
            bushd = new HoaDonBUS();
            buspt = new PhieuThuBUS();
            HienThiDanhSachHoaDon();
            HienThiDanhSachPhieuThu();
        }

        private void frmLapPhieuThuTien_Load(object sender, EventArgs e)
        {

        }

        private void buttonThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangDTO obj = new KhachHangDTO();
            obj.MaKhachHang = this.comboBoxMaKhachHang.Text;
            obj.TenKhachHang = this.textBoxTenKhachHang.Text;
            obj.DiaChiKhachHang = this.textBoxDiaChi.Text;
            obj.SDTKhachHang = this.textBoxSDT.Text;
            obj.EmailKhachHang = this.textBoxEmail.Text;

            string result = this.buskh.insert(obj);
            //HienThiDanhSachHoaDon();
            //HienThiDSSach();
            if (result == "0")
            {
                MessageBox.Show("Thêm thông tin khách hàng thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới thông tin khách hàng thất bại.\n" + result);
                return;
            }
        }

        public void HienThiDanhSachHoaDon()
        {

            List<HoaDonDTO> lsObj = new List<HoaDonDTO>();
            string result = this.bushd.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách hóa đơn.\n" + result);
                return;
            }
            dataGridViewDSHoaDon.Columns.Clear();
            dataGridViewDSHoaDon.DataSource = null;
            dataGridViewDSHoaDon.AutoGenerateColumns = false;
            dataGridViewDSHoaDon.AllowUserToAddRows = false;
            dataGridViewDSHoaDon.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaHoaDon = new DataGridViewTextBoxColumn();
            clMaHoaDon.Name = "MaHoaDon";
            clMaHoaDon.HeaderText = "Mã hóa đơn";
            clMaHoaDon.DataPropertyName = "MaHoaDon";
            dataGridViewDSHoaDon.Columns.Add(clMaHoaDon);

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã khách hàng";
            clMaKH.DataPropertyName = "MaKhachHang";
            dataGridViewDSHoaDon.Columns.Add(clMaKH);

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dataGridViewDSHoaDon.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clNgayLap = new DataGridViewTextBoxColumn();
            clNgayLap.Name = "NgayLap";
            clNgayLap.HeaderText = "Ngày lập";
            clNgayLap.DataPropertyName = "NgayLapHoaDon";
            dataGridViewDSHoaDon.Columns.Add(clNgayLap);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số lượng";
            clSoLuong.DataPropertyName = "SoLuong";
            dataGridViewDSHoaDon.Columns.Add(clSoLuong);

            comboBoxMaKhachHang.DataSource = lsObj;
            comboBoxMaKhachHang.DisplayMember = "MaKhachHang";
            comboBoxMaHoaDon.DataSource = lsObj;
            comboBoxMaHoaDon.DisplayMember = "MaHoaDon";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSHoaDon.DataSource];
            myCurrencyManager.Refresh();
        }

        public void HienThiDanhSachPhieuThu()
        {

            List<PhieuThuDTO> lsObj = new List<PhieuThuDTO>();
            string result = this.buspt.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu thu.\n" + result);
                return;
            }
            dataGridViewDSPhieuThu.Columns.Clear();
            dataGridViewDSPhieuThu.DataSource = null;
            dataGridViewDSPhieuThu.AutoGenerateColumns = false;
            dataGridViewDSPhieuThu.AllowUserToAddRows = false;
            dataGridViewDSPhieuThu.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaPhieuThu = new DataGridViewTextBoxColumn();
            clMaPhieuThu.Name = "MaPhieuThu";
            clMaPhieuThu.HeaderText = "Mã phiếu thu";
            clMaPhieuThu.DataPropertyName = "MaPhieuThu";
            dataGridViewDSPhieuThu.Columns.Add(clMaPhieuThu);

            DataGridViewTextBoxColumn clMaHoaDon = new DataGridViewTextBoxColumn();
            clMaHoaDon.Name = "MaHoaDon";
            clMaHoaDon.HeaderText = "Mã hóa đơn";
            clMaHoaDon.DataPropertyName = "MaHoaDon";
            dataGridViewDSPhieuThu.Columns.Add(clMaHoaDon);

            DataGridViewTextBoxColumn clNgayThuTien = new DataGridViewTextBoxColumn();
            clNgayThuTien.Name = "NgayThuTien";
            clNgayThuTien.HeaderText = "Ngày thu tiền";
            clNgayThuTien.DataPropertyName = "NgayThuTien";
            dataGridViewDSPhieuThu.Columns.Add(clNgayThuTien);

            DataGridViewTextBoxColumn clSoTienThu = new DataGridViewTextBoxColumn();
            clSoTienThu.Name = "SoTienThu";
            clSoTienThu.HeaderText = "Số tiền thu";
            clSoTienThu.DataPropertyName = "SoTienThu";
            dataGridViewDSPhieuThu.Columns.Add(clSoTienThu);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSPhieuThu.DataSource];
            myCurrencyManager.Refresh();
        }

        private void buttonThemPhieuThuTien_Click(object sender, EventArgs e)
        {
            PhieuThuDTO obj = new PhieuThuDTO();
            obj.MaPhieuThu = this.textBoxMaPhieuThu.Text;
            obj.MaHoaDon = this.comboBoxMaHoaDon.Text;
            obj.NgayThuTien = Convert.ToDateTime(this.dateTimePickerNgayThuTien.Text);
            obj.SoTienThu = Convert.ToInt32(this.textBoxSoTienThu.Text);

            string result = this.buspt.insert(obj);
            //HienThiDanhSachHoaDon();
            //HienThiDSSach();
            HienThiDanhSachPhieuThu();
            if (result == "0")
            {
                MessageBox.Show("Thêm phiếu thu thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới phiếu thu thất bại.\n" + result);
                return;
            }
        }
    }
}
