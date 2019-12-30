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
    public partial class frmLapPhieuNhapSach : Form
    {
        private SachBUS bus;
        private PhieuNhapBUS buspn;
        private ThamSoBUS busts;
        public frmLapPhieuNhapSach()
        {
            InitializeComponent();
            busts = new ThamSoBUS();
            HienThiDSSach();
            HienThiDanhSachPhieuNhap();
        }

        public void HienThiDSSach()
        {
            bus = new SachBUS();
            buspn = new PhieuNhapBUS();
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

        private void dataGridViewDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void HienThiDanhSachPhieuNhap()
        {
            
            List<PhieuNhapDTO> lsObj = new List<PhieuNhapDTO>();
            string result = this.buspn.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu nhập.\n" + result);
                return;
            }
            dataGridViewPhieuNhapSach.Columns.Clear();
            dataGridViewPhieuNhapSach.DataSource = null;
            dataGridViewPhieuNhapSach.AutoGenerateColumns = false;
            dataGridViewPhieuNhapSach.AllowUserToAddRows = false;
            dataGridViewPhieuNhapSach.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaPhieuNhap = new DataGridViewTextBoxColumn();
            clMaPhieuNhap.Name = "MaPhieuNhap";
            clMaPhieuNhap.HeaderText = "Mã phiếu nhập";
            clMaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            dataGridViewPhieuNhapSach.Columns.Add(clMaPhieuNhap);

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dataGridViewPhieuNhapSach.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clNgayNhap = new DataGridViewTextBoxColumn();
            clNgayNhap.Name = "NgayNhap";
            clNgayNhap.HeaderText = "Ngày nhập";
            clNgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewPhieuNhapSach.Columns.Add(clNgayNhap);

            DataGridViewTextBoxColumn clSoLuong = new DataGridViewTextBoxColumn();
            clSoLuong.Name = "SoLuong";
            clSoLuong.HeaderText = "Số lượng";
            clSoLuong.DataPropertyName = "SoLuong";
            dataGridViewPhieuNhapSach.Columns.Add(clSoLuong);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewPhieuNhapSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            //doi tham so
            List<ThamSoDTO> lsObj = new List<ThamSoDTO>();
            string results = this.busts.selectAll(lsObj);
            if (results != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu thu.\n" + results);
                return;
            }


            PhieuNhapDTO obj = new PhieuNhapDTO();
            obj.MaPhieuNhap = this.tbMaPhieuNhap.Text;
            obj.MaSach = this.comboBoxMaSach.Text;
            obj.NgayNhap = Convert.ToDateTime(this.dateTimePicker1.Text);
            obj.SoLuong = Convert.ToInt32(this.tbSoLuong.Text);
            int selectedrowindex = dataGridViewDSSach.SelectedCells[0].RowIndex;
            string ma = dataGridViewDSSach.SelectedCells[0].Value.ToString();
            DataGridViewRow selectedRow = dataGridViewDSSach.Rows[selectedrowindex];
            int a = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
            int sachconlai = a + obj.SoLuong;
            if (obj.SoLuong < lsObj[0].SoLuongNhapSachToiThieu || a>lsObj[0].SoLuongTonTruocKhiNhap)
            {
                MessageBox.Show("Sai quy định");
                return;
            }
            string result = this.buspn.insert(obj);
            HienThiDanhSachPhieuNhap();
            HienThiDSSach();
            if (result == "0")
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
                string update = this.buspn.updateSoLuong(ma, sachconlai);
                return;
            }
            else
            {
                MessageBox.Show("Thêm mới phiếu nhập thất bại.\n" + result);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
