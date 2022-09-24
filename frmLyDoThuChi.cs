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
    public partial class frmLyDoThuChi : Form
    {
        DataSet dsLyDo = new DataSet();
        bool blnThem = false;

        public frmLyDoThuChi()
        {
            InitializeComponent();
        }

        void GanDuLieu()
        {
            if (dsLyDo.Tables["LYDOTHUCHI"].Rows.Count > 0)
            {
                txtMaLyDo.Text = dgvLyDoThuChi[0, dgvLyDoThuChi.CurrentRow.Index].Value.ToString();
                txtDienGiai.Text = dgvLyDoThuChi[1, dgvLyDoThuChi.CurrentRow.Index].Value.ToString();
            }
            else
            {
                txtMaLyDo.Clear();
                txtDienGiai.Clear();
            }
        }

        void DieuKhienKhiBinhThuong()
        {
            if (MyPublics.strQuyenSD == "AllAdmin" || MyPublics.strQuyenSD=="Admin")
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

            txtMaLyDo.ReadOnly = true;
            txtMaLyDo.BackColor = Color.White;
            txtDienGiai.ReadOnly = true;
            txtDienGiai.BackColor = Color.White;

            dgvLyDoThuChi.Enabled = true;
        }

        private void frmLyDoThuChi_Load(object sender, EventArgs e)
        {
            string strSelect = "select * from LYDOTHUCHI";
            MyPublics.GetData(strSelect, dsLyDo, "LYDOTHUCHI");

            dgvLyDoThuChi.DataSource = dsLyDo;
            dgvLyDoThuChi.DataMember = "LYDOTHUCHI";

            GanDuLieu();
            DieuKhienKhiBinhThuong();

            dgvLyDoThuChi.Width = 365;
            dgvLyDoThuChi.Columns[0].Width = 75;
            dgvLyDoThuChi.Columns[0].HeaderText = "Mã số";
            dgvLyDoThuChi.Columns[1].Width = 230;
            dgvLyDoThuChi.Columns[1].HeaderText = "Họ lót";
            dgvLyDoThuChi.Columns[0].DefaultCellStyle.Font = new Font("Time New Roman", 9, FontStyle.Regular);
            dgvLyDoThuChi.Columns[1].DefaultCellStyle.Font = new Font("Time New Roman", 9, FontStyle.Regular);
            dgvLyDoThuChi.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 10, FontStyle.Bold);
            dgvLyDoThuChi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLyDoThuChi.AllowUserToAddRows = false;
            dgvLyDoThuChi.AllowUserToDeleteRows = false;
            dgvLyDoThuChi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvLyDoThuChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaLyDo.ReadOnly = false;
            txtMaLyDo.Clear();
            txtDienGiai.ReadOnly = false;
            txtDienGiai.Clear();
            txtMaLyDo.Focus();

            dgvLyDoThuChi.Enabled = false;
        }

        void DieuKhienKhiSua()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;

            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;

            txtMaLyDo.ReadOnly = true;
            txtDienGiai.ReadOnly = false;
            txtDienGiai.Clear();
            txtDienGiai.Focus();

            dgvLyDoThuChi.Enabled = false;
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
            string strSql;

            if (blnThem)
                strSql = "insert into LYDOTHUCHI values (@MALYDO, @DIENGIAI)";
            else
                strSql = "update LYDOTHUCHI set DIENGIAI=@DIENGIAI where MALYDO=@MALYDO";

            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();

            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MALYDO", txtMaLyDo.Text);
            cmdCommand.Parameters.AddWithValue("@DIENGIAI", txtDienGiai.Text);

            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();

            if (blnThem)
            {
                dsLyDo.Tables["LYDOTHUCHI"].Rows.Add(txtMaLyDo.Text, txtDienGiai.Text);
                GanDuLieu();
                blnThem = false;
            }
            else
            {
                int curRow = dgvLyDoThuChi.CurrentRow.Index;
                dsLyDo.Tables["LYDOTHUCHI"].Rows[curRow][1] = txtDienGiai.Text;
            }

            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaLyDo.Text == "")
            {
                MessageBox.Show("Lỗi nhập mã lý do!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLyDo.Focus();
                return;
            }
            if (txtDienGiai.Text == "")
            {
                MessageBox.Show("Lỗi nhập diễn giải!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienGiai.Focus();
                return;
            }
            if (blnThem && MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "MALYDO", "LYDOTHUCHI"))
            {
                MessageBox.Show("Tồn tại mã lý do!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLyDo.Focus();
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
            if(MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "LYDOTHU", "THU"))
                MessageBox.Show("Phải xóa STT phiếu thu trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MyPublics.TonTaiKhoaChinh(txtMaLyDo.Text, "LYDOCHI", "CHI"))
                MessageBox.Show("Phải xóa STT phiếu chi trước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Có thật sự muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strSql = "delete LYDOTHUCHI where MALYDO=@MALYDO";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();

                    SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MALYDO", txtMaLyDo.Text);

                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();

                    int curRow = dgvLyDoThuChi.CurrentRow.Index;
                    dsLyDo.Tables["LYDOTHUCHI"].Rows.RemoveAt(curRow);

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
