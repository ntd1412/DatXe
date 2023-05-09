namespace DatXe
{
    partial class FormQuanLyXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyXe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQuanLyXe = new System.Windows.Forms.DataGridView();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTaiXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenXe = new System.Windows.Forms.TextBox();
            this.textBoxBienSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(445, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 49);
            this.panel1.TabIndex = 45;
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
            // dgvQuanLyXe
            // 
            this.dgvQuanLyXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.ColumnTenXe,
            this.ColumnBienSo,
            this.ColumnTaiXe,
            this.ColumnSoDienThoai});
            this.dgvQuanLyXe.Location = new System.Drawing.Point(85, 131);
            this.dgvQuanLyXe.Name = "dgvQuanLyXe";
            this.dgvQuanLyXe.Size = new System.Drawing.Size(644, 239);
            this.dgvQuanLyXe.TabIndex = 44;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(523, 65);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(132, 23);
            this.textBoxSoDienThoai.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // textBoxTaiXe
            // 
            this.textBoxTaiXe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaiXe.Location = new System.Drawing.Point(523, 26);
            this.textBoxTaiXe.Name = "textBoxTaiXe";
            this.textBoxTaiXe.Size = new System.Drawing.Size(132, 23);
            this.textBoxTaiXe.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Tài Xê:";
            // 
            // textBoxTenXe
            // 
            this.textBoxTenXe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenXe.Location = new System.Drawing.Point(234, 65);
            this.textBoxTenXe.Name = "textBoxTenXe";
            this.textBoxTenXe.Size = new System.Drawing.Size(132, 23);
            this.textBoxTenXe.TabIndex = 36;
            // 
            // textBoxBienSo
            // 
            this.textBoxBienSo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBienSo.Location = new System.Drawing.Point(234, 26);
            this.textBoxBienSo.Name = "textBoxBienSo";
            this.textBoxBienSo.Size = new System.Drawing.Size(132, 23);
            this.textBoxBienSo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Biển Số:";
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.Name = "MaXe";
            this.MaXe.Visible = false;
            // 
            // ColumnTenXe
            // 
            this.ColumnTenXe.DataPropertyName = "TenXe";
            this.ColumnTenXe.HeaderText = "Tên Xe";
            this.ColumnTenXe.Name = "ColumnTenXe";
            this.ColumnTenXe.ReadOnly = true;
            this.ColumnTenXe.Width = 150;
            // 
            // ColumnBienSo
            // 
            this.ColumnBienSo.DataPropertyName = "BienSo";
            this.ColumnBienSo.HeaderText = "Biển Số";
            this.ColumnBienSo.Name = "ColumnBienSo";
            this.ColumnBienSo.ReadOnly = true;
            this.ColumnBienSo.Width = 150;
            // 
            // ColumnTaiXe
            // 
            this.ColumnTaiXe.DataPropertyName = "TaiXe";
            this.ColumnTaiXe.HeaderText = "Tài Xế";
            this.ColumnTaiXe.Name = "ColumnTaiXe";
            this.ColumnTaiXe.ReadOnly = true;
            this.ColumnTaiXe.Width = 150;
            // 
            // ColumnSoDienThoai
            // 
            this.ColumnSoDienThoai.DataPropertyName = "SoDienThoai";
            this.ColumnSoDienThoai.HeaderText = "Số Điện Thoại";
            this.ColumnSoDienThoai.Name = "ColumnSoDienThoai";
            this.ColumnSoDienThoai.ReadOnly = true;
            this.ColumnSoDienThoai.Width = 150;
            // 
            // FormQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuanLyXe);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTaiXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTenXe);
            this.Controls.Add(this.textBoxBienSo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLyXe";
            this.Text = "FormQuanLyXe";
            this.Load += new System.EventHandler(this.FormQuanLyXe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQuanLyXe;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenXe;
        private System.Windows.Forms.TextBox textBoxBienSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoDienThoai;
    }
}