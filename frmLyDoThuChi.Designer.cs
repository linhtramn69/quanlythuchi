namespace B1910468_ChuDe10
{
    partial class frmLyDoThuChi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaLyDo = new System.Windows.Forms.Label();
            this.lblDienGiai = new System.Windows.Forms.Label();
            this.txtMaLyDo = new System.Windows.Forms.TextBox();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.dgvLyDoThuChi = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLyDoThuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lblTieuDe.Location = new System.Drawing.Point(181, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(176, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Lý do thu chi";
            // 
            // lblMaLyDo
            // 
            this.lblMaLyDo.AutoSize = true;
            this.lblMaLyDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLyDo.ForeColor = System.Drawing.Color.Indigo;
            this.lblMaLyDo.Location = new System.Drawing.Point(101, 59);
            this.lblMaLyDo.Name = "lblMaLyDo";
            this.lblMaLyDo.Size = new System.Drawing.Size(111, 26);
            this.lblMaLyDo.TabIndex = 1;
            this.lblMaLyDo.Text = "Mã lý do:";
            // 
            // lblDienGiai
            // 
            this.lblDienGiai.AutoSize = true;
            this.lblDienGiai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienGiai.ForeColor = System.Drawing.Color.Indigo;
            this.lblDienGiai.Location = new System.Drawing.Point(101, 99);
            this.lblDienGiai.Name = "lblDienGiai";
            this.lblDienGiai.Size = new System.Drawing.Size(112, 26);
            this.lblDienGiai.TabIndex = 2;
            this.lblDienGiai.Text = "Diễn giải:";
            // 
            // txtMaLyDo
            // 
            this.txtMaLyDo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLyDo.Location = new System.Drawing.Point(218, 54);
            this.txtMaLyDo.Name = "txtMaLyDo";
            this.txtMaLyDo.Size = new System.Drawing.Size(156, 33);
            this.txtMaLyDo.TabIndex = 0;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienGiai.Location = new System.Drawing.Point(218, 96);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(156, 33);
            this.txtDienGiai.TabIndex = 1;
            // 
            // dgvLyDoThuChi
            // 
            this.dgvLyDoThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLyDoThuChi.Location = new System.Drawing.Point(53, 136);
            this.dgvLyDoThuChi.Name = "dgvLyDoThuChi";
            this.dgvLyDoThuChi.RowTemplate.Height = 28;
            this.dgvLyDoThuChi.Size = new System.Drawing.Size(365, 171);
            this.dgvLyDoThuChi.TabIndex = 3;
            this.dgvLyDoThuChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLyDoThuChi_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Purple;
            this.btnThem.Location = new System.Drawing.Point(61, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.Color.Purple;
            this.btnKhongLuu.Location = new System.Drawing.Point(321, 321);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(93, 30);
            this.btnKhongLuu.TabIndex = 7;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = true;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Purple;
            this.btnLuu.Location = new System.Drawing.Point(232, 322);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Purple;
            this.btnSua.Location = new System.Drawing.Point(145, 322);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Purple;
            this.btnXoa.Location = new System.Drawing.Point(146, 361);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Purple;
            this.btnDong.Location = new System.Drawing.Point(232, 361);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 30);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmLyDoThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(463, 403);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLyDoThuChi);
            this.Controls.Add(this.txtDienGiai);
            this.Controls.Add(this.txtMaLyDo);
            this.Controls.Add(this.lblDienGiai);
            this.Controls.Add(this.lblMaLyDo);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLyDoThuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lý do thu chi";
            this.Load += new System.EventHandler(this.frmLyDoThuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLyDoThuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaLyDo;
        private System.Windows.Forms.Label lblDienGiai;
        private System.Windows.Forms.TextBox txtMaLyDo;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.DataGridView dgvLyDoThuChi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
    }
}