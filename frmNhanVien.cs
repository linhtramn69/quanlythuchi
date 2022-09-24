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
    public partial class frmNhanVien : Form
    {
        DataSet dsNhanVien = new DataSet();
        DataSet dsChucVu = new DataSet();
        DataSet dsQuyenSD = new DataSet();
        bool blnThem = false;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dsNhanVien.Tables["NHANVIEN"].Rows.Count > 0)
            {
                txtMaNV.Text = dgvNhanVien[0, dgvNhanVien.CurrentRow.Index].Value.ToString();
                txtHoTen.Text = dgvNhanVien[1, dgvNhanVien.CurrentRow.Index].Value.ToString();
                cboChucVu.SelectedValue = dgvNhanVien[2, dgvNhanVien.CurrentRow.Index].Value.ToString();
                cboQuyenSD.SelectedValue = dgvNhanVien[4, dgvNhanVien.CurrentRow.Index].Value.ToString();
            }
            else
            {
                txtMaNV.Clear();
                txtHoTen.Clear();
                cboChucVu.SelectedIndex = -1;
                cboQuyenSD.SelectedIndex = -1;
            }
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AllAdmin")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }

            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDong.Enabled = true;

            txtMaNV.ReadOnly = true;
            txtMaNV.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            cboChucVu.Enabled = false;
            cboQuyenSD.Enabled = false;

            dgvNhanVien.Enabled = true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string strSelect = "select * from NHANVIEN";
            MyPublics.GetData(strSelect, dsNhanVien, "NHANVIEN");

            strSelect = "select MACV, DIENGIAI from CHUCVU";
            MyPublics.GetData(strSelect, dsChucVu, "CHUCVU");
            cboChucVu.DataSource = dsChucVu.Tables["CHUCVU"];
            cboChucVu.DisplayMember = "DIENGIAI";
            cboChucVu.ValueMember = "MACV";
            cboChucVu.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboChucVu.AutoCompleteSource = AutoCompleteSource.ListItems;

            dsQuyenSD.Tables.Add("DSQuyenSD");
            dsQuyenSD.Tables["DSQuyenSD"].Columns.Add("QuyenSD");
            dsQuyenSD.Tables["DSQuyenSD"].Rows.Add("User");
            dsQuyenSD.Tables["DSQuyenSD"].Rows.Add("Admin");
            dsQuyenSD.Tables["DSQuyenSD"].Rows.Add("AllAdmin");
            cboQuyenSD.DataSource = dsQuyenSD;
            cboQuyenSD.DisplayMember = "DSQuyenSD.QuyenSD";
            cboQuyenSD.ValueMember = "DSQuyenSD.QuyenSD";

            dgvNhanVien.DataSource = dsNhanVien;
            dgvNhanVien.DataMember = "NHANVIEN";

            GanDuLieu();
            DieuKhienKhiBinhThuong();

            dgvNhanVien.Width = 421;
            dgvNhanVien.Columns[0].Width = 45;
            dgvNhanVien.Columns[0].HeaderText = "Mã số";
            dgvNhanVien.Columns[1].Width = 120;
            dgvNhanVien.Columns[1].HeaderText = "Họ tên";
            dgvNhanVien.Columns[2].Width = 50;
            dgvNhanVien.Columns[2].HeaderText = "Mã chức vụ";
            dgvNhanVien.Columns[3].Width = 70;
            dgvNhanVien.Columns[3].HeaderText = "Mật khẩu";
            dgvNhanVien.Columns[4].Width = 75;
            dgvNhanVien.Columns[4].HeaderText = "Quyền SD";
            dgvNhanVien.Columns[0].DefaultCellStyle.Font = new Font("Time New Roman", 8, FontStyle.Regular);
            dgvNhanVien.Columns[1].DefaultCellStyle.Font = new Font("Time New Roman", 8, FontStyle.Regular);
            dgvNhanVien.Columns[2].DefaultCellStyle.Font = new Font("Time New Roman", 8, FontStyle.Regular);
            dgvNhanVien.Columns[3].DefaultCellStyle.Font = new Font("Time New Roman", 8, FontStyle.Regular);
            dgvNhanVien.Columns[4].DefaultCellStyle.Font = new Font("Time New Roman", 8, FontStyle.Regular);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 9, FontStyle.Bold);
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
                if (e.Value != null)
                    e.Value = new string('*', e.Value.ToString().Length);
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaNV.ReadOnly = false;
            txtMaNV.Clear();
            txtHoTen.ReadOnly = false;
            txtHoTen.Clear();
            txtMaNV.Focus();

            cboChucVu.Enabled = true;
            cboChucVu.SelectedIndex = 0;
            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;

            dgvNhanVien.Enabled = false;
        }

        void DieuKhienKhiSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaNV.ReadOnly = true;
            txtHoTen.ReadOnly = false;
            txtHoTen.Clear();
            txtHoTen.Focus();

            cboChucVu.Enabled = true;
            cboChucVu.SelectedIndex = 0;
            cboQuyenSD.Enabled = true;
            cboQuyenSD.SelectedIndex = 0;

            dgvNhanVien.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            blnThem = true;
            DieuKhienKhiThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiSua();
        }

        void ThucThiLuu()
        {
            string strSql, strChucVu, strQuyenSD, strMatKhau = "";

            if (blnThem)
                strSql = "insert into NHANVIEN values (@MANV, @HOTEN, @MACV, @MATKHAU, @QUYENSD)";
            else
                strSql = "update NHANVIEN set HOTEN=@HOTEN, MACV=@MACV, QUYENSD=@QUYENSD where MANV=@MANV";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            cmdCommand.Parameters.AddWithValue("@HOTEN", txtHoTen.Text);
            strChucVu = cboChucVu.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@MACV", strChucVu);
            if (blnThem)
            {
                strMatKhau = MyPublics.MaHoaPassword(txtMaNV.Text);
                cmdCommand.Parameters.AddWithValue("@MATKHAU", strMatKhau);
            }
            strQuyenSD = cboQuyenSD.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QUYENSD", strQuyenSD);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dsNhanVien.Tables["NHANVIEN"].Rows.Add(txtMaNV.Text, txtHoTen.Text, strChucVu, strMatKhau, strQuyenSD);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvNhanVien.CurrentRow.Index;
                dsNhanVien.Tables["NHANVIEN"].Rows[curRow][1] = txtHoTen.Text;
                dsNhanVien.Tables["NHANVIEN"].Rows[curRow][2] = strChucVu;
                dsNhanVien.Tables["NHANVIEN"].Rows[curRow][4] = strQuyenSD;
            }

            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Lỗi nhập mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Lỗi nhập họ tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (blnThem && MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV", "NHANVIEN"))
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
            }
            else
                ThucThiLuu();
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            blnThem = false;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV_THU", "THU"))
                MessageBox.Show("Phải xóa STT phiếu thu trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV_NOP", "THU"))
                MessageBox.Show("Phải xóa STT phiếu thu trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV_CHI", "CHI"))
                MessageBox.Show("Phải xóa STT phiếu chi trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MyPublics.TonTaiKhoaChinh(txtMaNV.Text, "MANV_NHAN", "CHI"))
                MessageBox.Show("Phải xóa STT phiếu chi trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Có thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "delete NHANVIEN where MANV=@MANV";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();

                    SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MANV", txtMaNV.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    int curRow = dgvNhanVien.CurrentRow.Index;
                    dsNhanVien.Tables["NHANVIEN"].Rows.RemoveAt(curRow);

                    GanDuLieu();
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
