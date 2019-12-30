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
    public partial class frmTraCuuSach : Form
    {
        private SachBUS bus;
        public frmTraCuuSach()
        {
            InitializeComponent();
            allComboboxVisible(false);
            comboBoxLoaiSach.SelectedItem = null;
            comboBoxTenSach.SelectedItem = null;
            comboBoxMaSach.SelectedItem = null;
            comboBoxTacGia.SelectedItem = null;

            HienThiDSSach();
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
            comboBoxLoaiSach.DataSource = lsObj;
            comboBoxTacGia.DataSource = lsObj;
            comboBoxTenSach.DataSource = lsObj;
            comboBoxMaSach.DisplayMember = "MaSach";
            comboBoxTenSach.DisplayMember = "TenSach";
            comboBoxTacGia.DisplayMember = "TacGia";
            comboBoxLoaiSach.DisplayMember = "TheLoai";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSSach.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (checkBoxLoaiSach.Checked)
            {
                buildDanhSach(comboBoxLoaiSach.Text);
            }
            else if(checkBoxTenSach.Checked){
                buildDanhSach(comboBoxTenSach.Text);
            }
            else if (checkBoxTacGia.Checked)
            {
                buildDanhSach(comboBoxTacGia.Text);
            }
            else if (checkBoxMaSach.Checked)
            {
                buildDanhSach(comboBoxMaSach.Text);
            }
            
        }

        private void buildDanhSach(string kw)
        {
            List<SachDTO> lsObj = new List<SachDTO>();
            string result = this.bus.search(kw, lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result);
                return;
            }

            dataGridViewDSSearch.Columns.Clear();
            dataGridViewDSSearch.DataSource = null;
            dataGridViewDSSearch.AutoGenerateColumns = false;
            dataGridViewDSSearch.AllowUserToAddRows = false;
            dataGridViewDSSearch.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dataGridViewDSSearch.Columns.Add(clMaSach);

            DataGridViewTextBoxColumn clTenSach = new DataGridViewTextBoxColumn();
            clTenSach.Name = "TenSach";
            clTenSach.HeaderText = "Tên sách";
            clTenSach.DataPropertyName = "TenSach";
            dataGridViewDSSearch.Columns.Add(clTenSach);

            DataGridViewTextBoxColumn clTheLoai = new DataGridViewTextBoxColumn();
            clTheLoai.Name = "TheLoai";
            clTheLoai.HeaderText = "Thể loại";
            clTheLoai.DataPropertyName = "TheLoai";
            dataGridViewDSSearch.Columns.Add(clTheLoai);

            DataGridViewTextBoxColumn clTacGia = new DataGridViewTextBoxColumn();
            clTacGia.Name = "TacGia";
            clTacGia.HeaderText = "Tác giả";
            clTacGia.DataPropertyName = "TacGia";
            dataGridViewDSSearch.Columns.Add(clTacGia);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewDSSearch.DataSource];
            myCurrencyManager.Refresh();
        }


        public void allComboboxVisible(bool a)
        {
            comboBoxTenSach.Visible = a;
            comboBoxTacGia.Visible = a;
            comboBoxMaSach.Visible = a;
            comboBoxLoaiSach.Visible = a;
        }
        public void allCheckBoxVisible(bool a)
        {
            checkBoxLoaiSach.Visible = a;
            checkBoxMaSach.Visible = a;
            checkBoxTacGia.Visible = a;
            checkBoxTenSach.Visible = a;
        }

        private void checkBoxMaSach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaSach.Checked == true)
            {
                comboBoxMaSach.Visible = true;
                checkBoxLoaiSach.Visible=false;
                comboBoxLoaiSach.SelectedItem = null;
                comboBoxLoaiSach.Visible = false;
                checkBoxTacGia.Visible = false;
                comboBoxTacGia.SelectedItem = null;
                comboBoxTacGia.Visible = false;
                checkBoxTenSach.Visible = false;
                comboBoxTenSach.SelectedItem = null;
                comboBoxTenSach.Visible = false;
            }
            else
            {
                allComboboxVisible(false);
                allCheckBoxVisible(true);
            }
        }

        private void checkBoxTenSach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTenSach.Checked == true)
            {
                comboBoxTenSach.Visible = true;
                checkBoxLoaiSach.Visible = false;
                comboBoxLoaiSach.SelectedItem = null;
                comboBoxLoaiSach.Visible = false;
                checkBoxTacGia.Visible = false;
                comboBoxTacGia.SelectedItem = null;
                comboBoxTacGia.Visible = false;
                checkBoxMaSach.Visible = false;
                comboBoxMaSach.SelectedItem = null;
                comboBoxMaSach.Visible = false;
            }
            else
            {
                allComboboxVisible(false);
                allCheckBoxVisible(true);
            }
        }

        private void checkBoxLoaiSach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoaiSach.Checked == true)
            {
                comboBoxLoaiSach.Visible = true;
                checkBoxTenSach.Visible = false;
                comboBoxTenSach.SelectedItem = null;
                comboBoxTenSach.Visible = false;
                checkBoxTacGia.Visible = false;
                comboBoxTacGia.SelectedItem = null;
                comboBoxTacGia.Visible = false;
                checkBoxMaSach.Visible = false;
                comboBoxMaSach.SelectedItem = null;
                comboBoxMaSach.Visible = false;
            }
            else
            {
                allComboboxVisible(false);
                allCheckBoxVisible(true);
            }
        }

        private void checkBoxTacGia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTacGia.Checked == true)
            {
                comboBoxTacGia.Visible = true;
                checkBoxLoaiSach.Visible = false;
                comboBoxLoaiSach.SelectedItem = null;
                comboBoxLoaiSach.Visible = false;
                checkBoxTenSach.Visible = false;
                comboBoxTenSach.SelectedItem = null;
                comboBoxTenSach.Visible = false;
                checkBoxMaSach.Visible = false;
                comboBoxMaSach.SelectedItem = null;
                comboBoxMaSach.Visible = false;
            }
            else
            {
                allComboboxVisible(false);
                allCheckBoxVisible(true);
            }
        }

        private void dataGridViewDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
