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
    public partial class frmThayDoiQuyDinh : Form
    {
        private ThamSoBUS busts;
        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
            busts = new ThamSoBUS();
            Hienthidanhsach();
        }

        public void Hienthidanhsach()
        {
            List<ThamSoDTO> lsObj = new List<ThamSoDTO>();
            string result = this.busts.selectAll(lsObj);
            if (result != "0")
            {
                MessageBox.Show("Lỗi khi lấy danh sách phiếu thu.\n" + result);
                return;
            }
            textBoxSLNSTT.Text = lsObj[0].SoLuongNhapSachToiThieu.ToString();
            textBoxSLTSKB.Text = lsObj[0].SoLuongTonSauKhiBan.ToString();
            textBoxSLTTKN.Text = lsObj[0].SoLuongTonTruocKhiNhap.ToString();
        }

        private void buttonThayDoi_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBoxSLTSKBn.Text);
            string result = busts.updateThamSosoluongtonsaukhiban(k);
            Hienthidanhsach();
        }

        private void buttonThayDoiSLNSTT_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBoxSLNSTTn.Text);
            string result = busts.updateThamSosoluongnhapsachtoithieu(k);
            Hienthidanhsach();
        }

        private void buttonSLTTKN_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBoxSLTTKNn.Text);
            string result = busts.updateThamSosoluongtontruockhinhap(k);
            Hienthidanhsach();
        }
    }
}
