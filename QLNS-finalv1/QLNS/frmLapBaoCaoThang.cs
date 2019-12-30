using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSDTO;
using QLNSDAL;
using QLNSBUS;
namespace QLNS
{
    public partial class frmLapBaoCaoThang : Form
    {
        private BaoCaoBUS bus;
        public frmLapBaoCaoThang()
        {
            
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                string[] numbers = { i.ToString() };
                comboBoxBCT.Items.AddRange(numbers);
                comboBoxBCCN.Items.AddRange(numbers);
            }
            bus = new BaoCaoBUS();
        }

        private void buttonXuatBCT_Click(object sender, EventArgs e)
        {
            List<BaoCaoDTO> lsObj = new List<BaoCaoDTO>();
            int k = Convert.ToInt32(comboBoxBCT.Text);
            string result = this.bus.selectAllBCT(lsObj,k);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result);
                return;
            }
            dataGridViewBCT.Columns.Clear();
            dataGridViewBCT.DataSource = null;
            dataGridViewBCT.AutoGenerateColumns = false;
            dataGridViewBCT.AllowUserToAddRows = false;
            dataGridViewBCT.DataSource = lsObj;

            DataGridViewTextBoxColumn clMaSach = new DataGridViewTextBoxColumn();
            clMaSach.Name = "MaSach";
            clMaSach.HeaderText = "Mã Sách";
            clMaSach.DataPropertyName = "MaSach";
            dataGridViewBCT.Columns.Add(clMaSach);


            DataGridViewTextBoxColumn clTonDau = new DataGridViewTextBoxColumn();
            clTonDau.Name = "TonDau";
            clTonDau.HeaderText = "Tồn đầu";
            clTonDau.DataPropertyName = "TonDau";
            dataGridViewBCT.Columns.Add(clTonDau);

            DataGridViewTextBoxColumn clPhatSinh = new DataGridViewTextBoxColumn();
            clPhatSinh.Name = "PhatSinh";
            clPhatSinh.HeaderText = "Phát sinh";
            clPhatSinh.DataPropertyName = "PhatSinh";
            dataGridViewBCT.Columns.Add(clPhatSinh);

            DataGridViewTextBoxColumn clTonCuoi = new DataGridViewTextBoxColumn();
            clTonCuoi.Name = "TonCuoi";
            clTonCuoi.HeaderText = "Tồn cuối";
            clTonCuoi.DataPropertyName = "TonCuoi";
            dataGridViewBCT.Columns.Add(clTonCuoi);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewBCT.DataSource];
            myCurrencyManager.Refresh();
        }

        private void buttonXuatBCCN_Click(object sender, EventArgs e)
        {
            List<BaoCaoDTO> lsObj = new List<BaoCaoDTO>();
            int k = Convert.ToInt32(comboBoxBCCN.Text);
            string result = this.bus.selectAllBCCN(lsObj, k);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách sách.\n" + result);
                return;
            }
            dataGridViewBCCN.Columns.Clear();
            dataGridViewBCCN.DataSource = null;
            dataGridViewBCCN.AutoGenerateColumns = false;
            dataGridViewBCCN.AllowUserToAddRows = false;
            dataGridViewBCCN.DataSource = lsObj;

            DataGridViewTextBoxColumn clKhachHang = new DataGridViewTextBoxColumn();
            clKhachHang.Name = "MaKhachHang";
            clKhachHang.HeaderText = "Mã khách hàng";
            clKhachHang.DataPropertyName = "MaKhachHang";
            dataGridViewBCCN.Columns.Add(clKhachHang);


            DataGridViewTextBoxColumn clNoDau = new DataGridViewTextBoxColumn();
            clNoDau.Name = "NoDau";
            clNoDau.HeaderText = "Nợ đầu";
            clNoDau.DataPropertyName = "NoDau";
            dataGridViewBCCN.Columns.Add(clNoDau);

            DataGridViewTextBoxColumn clNoPhatSinh = new DataGridViewTextBoxColumn();
            clNoPhatSinh.Name = "NoPhatSinh";
            clNoPhatSinh.HeaderText = "Nợ phát sinh";
            clNoPhatSinh.DataPropertyName = "NoPhatSinh";
            dataGridViewBCCN.Columns.Add(clNoPhatSinh);

            DataGridViewTextBoxColumn clNoCuoi = new DataGridViewTextBoxColumn();
            clNoCuoi.Name = "NoCuoi";
            clNoCuoi.HeaderText = "Nợ cuối";
            clNoCuoi.DataPropertyName = "NoCuoi";
            dataGridViewBCCN.Columns.Add(clNoCuoi);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridViewBCCN.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
