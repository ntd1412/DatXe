namespace DatXe
{
    partial class FormQuanLyChuyenDi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyChuyenDi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQuanLyChuyenDi = new System.Windows.Forms.DataGridView();
            this.textBoxGiaVe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDiemDen = new System.Windows.Forms.TextBox();
            this.textBoxGioKhoiHanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNoiXuatPhat = new System.Windows.Forms.TextBox();
            this.textBoxMaChuyenDi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ColumnMaChuyenDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNoiXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGioKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(445, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 49);
            this.panel1.TabIndex = 31;
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
            // 
            // dgvQuanLyChuyenDi
            // 
            this.dgvQuanLyChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaChuyenDi,
            this.ColumnMaXe,
            this.ColumnNgayDi,
            this.ColumnNoiXuatPhat,
            this.ColumnDiemDen,
            this.ColumnGioKhoiHanh,
            this.ColumnGiaVe});
            this.dgvQuanLyChuyenDi.Location = new System.Drawing.Point(32, 134);
            this.dgvQuanLyChuyenDi.Name = "dgvQuanLyChuyenDi";
            this.dgvQuanLyChuyenDi.Size = new System.Drawing.Size(740, 239);
            this.dgvQuanLyChuyenDi.TabIndex = 30;
            // 
            // textBoxGiaVe
            // 
            this.textBoxGiaVe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaVe.Location = new System.Drawing.Point(643, 80);
            this.textBoxGiaVe.Name = "textBoxGiaVe";
            this.textBoxGiaVe.Size = new System.Drawing.Size(139, 23);
            this.textBoxGiaVe.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Giá Vé:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ngày Đi:";
            // 
            // textBoxDiemDen
            // 
            this.textBoxDiemDen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiemDen.Location = new System.Drawing.Point(378, 80);
            this.textBoxDiemDen.Name = "textBoxDiemDen";
            this.textBoxDiemDen.Size = new System.Drawing.Size(139, 23);
            this.textBoxDiemDen.TabIndex = 25;
            // 
            // textBoxGioKhoiHanh
            // 
            this.textBoxGioKhoiHanh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGioKhoiHanh.Location = new System.Drawing.Point(643, 41);
            this.textBoxGioKhoiHanh.Name = "textBoxGioKhoiHanh";
            this.textBoxGioKhoiHanh.Size = new System.Drawing.Size(139, 23);
            this.textBoxGioKhoiHanh.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Điểm Đến:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giờ Khởi Hành:";
            // 
            // textBoxNoiXuatPhat
            // 
            this.textBoxNoiXuatPhat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoiXuatPhat.Location = new System.Drawing.Point(138, 80);
            this.textBoxNoiXuatPhat.Name = "textBoxNoiXuatPhat";
            this.textBoxNoiXuatPhat.Size = new System.Drawing.Size(139, 23);
            this.textBoxNoiXuatPhat.TabIndex = 21;
            // 
            // textBoxMaChuyenDi
            // 
            this.textBoxMaChuyenDi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaChuyenDi.Location = new System.Drawing.Point(138, 41);
            this.textBoxMaChuyenDi.Name = "textBoxMaChuyenDi";
            this.textBoxMaChuyenDi.Size = new System.Drawing.Size(139, 23);
            this.textBoxMaChuyenDi.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nơi Xuất Phát:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Chuyến Đi:";
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(378, 44);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(139, 21);
            this.kryptonDateTimePicker1.TabIndex = 32;
            // 
            // ColumnMaChuyenDi
            // 
            this.ColumnMaChuyenDi.DataPropertyName = "MaChuyenDi";
            this.ColumnMaChuyenDi.HeaderText = "Mã Chuyến Đi";
            this.ColumnMaChuyenDi.Name = "ColumnMaChuyenDi";
            this.ColumnMaChuyenDi.ReadOnly = true;
            // 
            // ColumnMaXe
            // 
            this.ColumnMaXe.DataPropertyName = "MaXe";
            this.ColumnMaXe.HeaderText = "Mã Xe";
            this.ColumnMaXe.Name = "ColumnMaXe";
            this.ColumnMaXe.ReadOnly = true;
            this.ColumnMaXe.Visible = false;
            // 
            // ColumnNgayDi
            // 
            this.ColumnNgayDi.DataPropertyName = "NgayDi";
            this.ColumnNgayDi.HeaderText = "Ngày Đi";
            this.ColumnNgayDi.Name = "ColumnNgayDi";
            this.ColumnNgayDi.ReadOnly = true;
            this.ColumnNgayDi.Width = 150;
            // 
            // ColumnNoiXuatPhat
            // 
            this.ColumnNoiXuatPhat.DataPropertyName = "NoiDi";
            this.ColumnNoiXuatPhat.HeaderText = "Nơi Xuất Phát";
            this.ColumnNoiXuatPhat.Name = "ColumnNoiXuatPhat";
            this.ColumnNoiXuatPhat.ReadOnly = true;
            // 
            // ColumnDiemDen
            // 
            this.ColumnDiemDen.DataPropertyName = "NoiDen";
            this.ColumnDiemDen.HeaderText = "Điểm Đến";
            this.ColumnDiemDen.Name = "ColumnDiemDen";
            this.ColumnDiemDen.ReadOnly = true;
            // 
            // ColumnGioKhoiHanh
            // 
            this.ColumnGioKhoiHanh.DataPropertyName = "GioXuatPhat";
            this.ColumnGioKhoiHanh.HeaderText = "Giờ Khởi Hành";
            this.ColumnGioKhoiHanh.Name = "ColumnGioKhoiHanh";
            this.ColumnGioKhoiHanh.ReadOnly = true;
            // 
            // ColumnGiaVe
            // 
            this.ColumnGiaVe.DataPropertyName = "Gia";
            this.ColumnGiaVe.HeaderText = "Giá Vé";
            this.ColumnGiaVe.Name = "ColumnGiaVe";
            this.ColumnGiaVe.ReadOnly = true;
            this.ColumnGiaVe.Width = 150;
            // 
            // FormQuanLyChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonDateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuanLyChuyenDi);
            this.Controls.Add(this.textBoxGiaVe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDiemDen);
            this.Controls.Add(this.textBoxGioKhoiHanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNoiXuatPhat);
            this.Controls.Add(this.textBoxMaChuyenDi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyChuyenDi";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormQuanLyChuyenDi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQuanLyChuyenDi;
        private System.Windows.Forms.TextBox textBoxGiaVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDiemDen;
        private System.Windows.Forms.TextBox textBoxGioKhoiHanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNoiXuatPhat;
        private System.Windows.Forms.TextBox textBoxMaChuyenDi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNoiXuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGioKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaVe;
    }
}