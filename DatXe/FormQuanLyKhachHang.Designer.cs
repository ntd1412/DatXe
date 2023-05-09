namespace DatXe
{
    partial class FormQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.ColumnMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Điện Thoại:";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(150, 56);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(115, 23);
            this.textBoxSoDienThoai.TabIndex = 6;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.Location = new System.Drawing.Point(401, 56);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(115, 23);
            this.textBoxCMND.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "CMND:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(652, 56);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(115, 23);
            this.textBoxHoTen.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Họ Tên:";
            // 
            // dgvQuanLyKhachHang
            // 
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaKhachHang,
            this.ColumnSDT,
            this.ColumnCMND,
            this.ColumnHoTen});
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(150, 131);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(495, 239);
            this.dgvQuanLyKhachHang.TabIndex = 16;
            this.dgvQuanLyKhachHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(443, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 49);
            this.panel1.TabIndex = 17;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(216, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(108, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ColumnMaKhachHang
            // 
            this.ColumnMaKhachHang.DataPropertyName = "MaKhachHang";
            this.ColumnMaKhachHang.HeaderText = "Mã Khách Hàng";
            this.ColumnMaKhachHang.Name = "ColumnMaKhachHang";
            this.ColumnMaKhachHang.Visible = false;
            // 
            // ColumnSDT
            // 
            this.ColumnSDT.DataPropertyName = "SDT";
            this.ColumnSDT.HeaderText = "Số Điện Thoại";
            this.ColumnSDT.Name = "ColumnSDT";
            this.ColumnSDT.ReadOnly = true;
            this.ColumnSDT.Width = 150;
            // 
            // ColumnCMND
            // 
            this.ColumnCMND.DataPropertyName = "CMND";
            this.ColumnCMND.HeaderText = "CMND";
            this.ColumnCMND.Name = "ColumnCMND";
            this.ColumnCMND.ReadOnly = true;
            this.ColumnCMND.Width = 150;
            // 
            // ColumnHoTen
            // 
            this.ColumnHoTen.DataPropertyName = "TenKhachHang";
            this.ColumnHoTen.HeaderText = "Họ Tên";
            this.ColumnHoTen.Name = "ColumnHoTen";
            this.ColumnHoTen.ReadOnly = true;
            this.ColumnHoTen.Width = 150;
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyKhachHang";
            this.Text = "FormQuanLyKhachHang";
            this.Load += new System.EventHandler(this.FormQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoTen;
    }
}