using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.fe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void itemGiangVien_Click(object sender, EventArgs e)
        {
            FormGiangVien f = new FormGiangVien();
            f.ShowDialog();
        }

        private void itemLopHocPhan_Click(object sender, EventArgs e)
        {
            FormLopHocPhan f = new FormLopHocPhan();
            f.ShowDialog();
        }

        private void itemPhongHoc_Click(object sender, EventArgs e)
        {
            FormPhongHoc f = new FormPhongHoc();
            f.ShowDialog();
        }

        private void itemXepLichTuDong_Click(object sender, EventArgs e)
        {
            FormXepThoiKhoaBieu f = new FormXepThoiKhoaBieu();
            f.ShowDialog();
        }

        private void itemXem_Click(object sender, EventArgs e)
        {
            FormXemThoiKhoaBieu f = new FormXemThoiKhoaBieu();
            f.ShowDialog();
        }

        private void itemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
