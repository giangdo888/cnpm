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
    public partial class frmLapHoaDonBanSach : Form
    {

        private HoaDonBUS bushd;
        private SachBUS bus;
        private ThamSoBUS busts;

        public frmLapHoaDonBanSach()
        {
            InitializeComponent();
            bushd = new HoaDonBUS();
            busts = new ThamSoBUS();
            HienThiDSSach();
            HienThiDanhSachHoaDon();
        }

        public void HienThiDSSach()
        {
            bus = new SachBUS();
            List<SachDTO> lsObj = new List<SachDTO>();
            string result = this.bus.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result);
                return;
            }
            dataGridViewDSSach.Columns.Clear();
            dataGridViewDSSach.DataSource = null;
            dataGridViewDSSach.AutoGenerateColumns = false;
            dataGridViewDSSach.AllowUserToAddRows = false;
            dataGridViewDSSach.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dataGridViewDSSach.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clTenSach = new DataGridViewTextBoxColumn();
            clTenSach.Name = "TenSach";
            clTenSach.HeaderText = "Tên sách";
            clTenSach.DataPropertyName = "TenSach";
            dataGridViewDSSach.Columns.Add(clTenSach);

            DataGridViewTextBoxColumn clTheLoai = new DataGridViewTextBoxColumn();
            clTheLoai.Name = "TheLoai";
            clTheLoai.HeaderText = "Thể loại";
            clTheLoai.DataPropertyName = "TheLoai";
            dataGridViewDSSach.Columns.Add(clTheLoai);

            DataGridViewTextBoxColumn clTacGia = new DataGridViewTextBoxColumn();
            clTacGia.Name = "TacGia";
            clTacGia.HeaderText = "Tác giả";
            clTacGia.DataPropertyName = "TacGia";
            dataGridViewDSSach.Columns.Add(clTacGia);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số lượng";
            clSoLuong.DataPropertyName = "SoLuong";
            dataGridViewDSSach.Columns.Add(clSoLuong);

            DataGridViewTextBoxColumn clDonGia = new DataGridViewTextBoxColumn();
            clDonGia.Name = "DonGia";
            clDonGia.HeaderText = "Đơn giá";
            clDonGia.DataPropertyName = "DonGia";
            dataGridViewDSSach.Columns.Add(clDonGia);

            //Combobox
            comboBoxMaSach.DataSource = lsObj;
            comboBoxMaSach.DisplayMember = "MaSach";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapHoaDon_Click(object sender, EventArgs e)
        {
            //doi tham so
            List<ThamSoDTO> lsObj = new List<ThamSoDTO>();
            string results = this.busts.selectAll(lsObj);
            if (results != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách tham so.\n" + results);
                return;
            }


            HoaDonDTO obj = new HoaDonDTO();
            obj.MaHoaDon = this.textBoxMaHoaDon.Text;
            obj.MaSach = this.comboBoxMaSach.Text;
            obj.MaKhachHang = this.textBoxMaKhachHang.Text;
            obj.NgayLapHoaDon = Convert.ToDateTime(this.dateTimePickerNgayLapHoaDon.Text);
            obj.SoLuong = Convert.ToInt32(this.textBoxSoLuong.Text);

            int selectedrowindex = dataGridViewDSSach.SelectedCells[0].RowIndex;
            string ma = dataGridViewDSSach.SelectedCells[0].Value.ToString();
            DataGridViewRow selectedRow = dataGridViewDSSach.Rows[selectedrowindex];
            int a = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
            if (obj.SoLuong >a || a<lsObj[0].SoLuongTonSauKhiBan)
            {
                MessageBox.Show("Sai quy định");
                return;
            }
            int sachconlai = a - obj.SoLuong;
            
            string result = this.bushd.insert(obj);
            if (result == "0")
            {
                MessageBox.Show("Thêm hóa đơn thành công");
                string update = this.bushd.updateSoLuong(ma, sachconlai);
                HienThiDanhSachHoaDon();
                HienThiDSSach();
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới hóa đơn thất bại.\n" + result);
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

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSHoaDon.DataSource];
            myCurrencyManager.Refresh();
        }


    }
}
