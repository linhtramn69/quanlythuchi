using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1910468_ChuDe10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống quản lý thu chi!", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap fDangNhap = new frmDangNhap(this);
            fDangNhap.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap fDangNhap = new frmDangNhap(this);
            fDangNhap.ShowDialog();
        }

        private void mnuLyDoThuChi_Click(object sender, EventArgs e)
        {
            frmLyDoThuChi fLyDoThuChi = new frmLyDoThuChi();
            fLyDoThuChi.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien fNhanVien = new frmNhanVien();
            fNhanVien.ShowDialog();
        }

        private void mnuNhanVienTheoChucVu_Click(object sender, EventArgs e)
        {
            frmNhanVienTheoChucVu fNhanVien = new frmNhanVienTheoChucVu();
            fNhanVien.ShowDialog();
        }
    }
}
