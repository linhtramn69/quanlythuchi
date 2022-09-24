using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1910468_ChuDe10
{
    public partial class frmDangNhap : Form
    {
        frmMain fMain;
        public frmDangNhap(frmMain fm)
            : this()
        {
            fMain = fm;
        }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string strMatKhau;

            try
            {
                MyPublics.ConnectDatabase();
                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    MyPublics.strMaNV = txtMaNV.Text;
                    strMatKhau = MyPublics.MaHoaPassword(txtMatKhau.Text);

                    string sqlSelect = "select MACV, QUYENSD from NhanVien where MANV=@MANV and MATKHAU=@MATKHAU";
                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);

                    cmdCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                    cmdCommand.Parameters.AddWithValue("@MATKHAU", txtMatKhau.Text);

                    drReader = cmdCommand.ExecuteReader();
                    if (drReader.HasRows)
                    {
                        drReader.Read();
                        MyPublics.strMaCV = drReader.GetString(0);
                        MyPublics.strQuyenSD = drReader.GetString(1);
                        drReader.Close();
                        MessageBox.Show("Đăng nhập thành công!", "Đăng nhập");
                        MyPublics.conMyConnection.Close();
                        fMain.mnuDuLieu.Enabled = true;
                        fMain.mnuThoatDangNhap.Enabled = true;
                        fMain.mnuDoiMK.Enabled = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Kết nối không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MyPublics.conMyConnection != null)
                MyPublics.conMyConnection = null;
            fMain.mnuDuLieu.Enabled = false;
            fMain.mnuThoatDangNhap.Enabled = false;
            fMain.mnuDoiMK.Enabled = false;
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            txtMatKhau.PasswordChar = '*';
            txtMaNV.Text = "001358";
            txtMatKhau.Text = "001358";
        }
    }
}
