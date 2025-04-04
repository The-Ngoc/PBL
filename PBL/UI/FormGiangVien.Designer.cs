namespace PBL3.fe
{
    partial class FormGiangVien
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
            txtMaGiangVien = new TextBox();
            txtTenGiangVien = new TextBox();
            cbbKhoa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnThemGiangVien = new Button();
            btnLamMoi = new Button();
            dataDanhSachGiangVien = new DataGridView();
            colMaGiangVien = new DataGridViewTextBoxColumn();
            colTenGiangVien = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colBtnSua = new DataGridViewButtonColumn();
            colBtnXoa = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataDanhSachGiangVien).BeginInit();
            SuspendLayout();
            // 
            // txtMaGiangVien
            // 
            txtMaGiangVien.Location = new Point(566, 27);
            txtMaGiangVien.Margin = new Padding(4, 5, 4, 5);
            txtMaGiangVien.Name = "txtMaGiangVien";
            txtMaGiangVien.Size = new Size(279, 31);
            txtMaGiangVien.TabIndex = 0;
            // 
            // txtTenGiangVien
            // 
            txtTenGiangVien.Location = new Point(566, 120);
            txtTenGiangVien.Margin = new Padding(4, 5, 4, 5);
            txtTenGiangVien.Name = "txtTenGiangVien";
            txtTenGiangVien.Size = new Size(279, 31);
            txtTenGiangVien.TabIndex = 1;
            // 
            // cbbKhoa
            // 
            cbbKhoa.FormattingEnabled = true;
            cbbKhoa.Location = new Point(566, 211);
            cbbKhoa.Margin = new Padding(4, 5, 4, 5);
            cbbKhoa.Name = "cbbKhoa";
            cbbKhoa.Size = new Size(279, 33);
            cbbKhoa.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 3;
            label1.Text = "Mã Giảng Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 4;
            label2.Text = "Tên Giảng Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 216);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Khoa";
            // 
            // btnThemGiangVien
            // 
            btnThemGiangVien.Location = new Point(528, 294);
            btnThemGiangVien.Margin = new Padding(4, 5, 4, 5);
            btnThemGiangVien.Name = "btnThemGiangVien";
            btnThemGiangVien.Size = new Size(94, 36);
            btnThemGiangVien.TabIndex = 6;
            btnThemGiangVien.Text = "Thêm";
            btnThemGiangVien.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(775, 294);
            btnLamMoi.Margin = new Padding(4, 5, 4, 5);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 36);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dataDanhSachGiangVien
            // 
            dataDanhSachGiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDanhSachGiangVien.Columns.AddRange(new DataGridViewColumn[] { colMaGiangVien, colTenGiangVien, colKhoa, colBtnSua, colBtnXoa });
            dataDanhSachGiangVien.Location = new Point(190, 358);
            dataDanhSachGiangVien.Margin = new Padding(4, 5, 4, 5);
            dataDanhSachGiangVien.Name = "dataDanhSachGiangVien";
            dataDanhSachGiangVien.RowHeadersWidth = 51;
            dataDanhSachGiangVien.RowTemplate.Height = 24;
            dataDanhSachGiangVien.Size = new Size(974, 406);
            dataDanhSachGiangVien.TabIndex = 10;
            // 
            // colMaGiangVien
            // 
            colMaGiangVien.HeaderText = "Mã Giảng Viên";
            colMaGiangVien.MinimumWidth = 6;
            colMaGiangVien.Name = "colMaGiangVien";
            colMaGiangVien.Width = 125;
            // 
            // colTenGiangVien
            // 
            colTenGiangVien.HeaderText = "Tên Giảng Viên";
            colTenGiangVien.MinimumWidth = 6;
            colTenGiangVien.Name = "colTenGiangVien";
            colTenGiangVien.Width = 300;
            // 
            // colKhoa
            // 
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.Width = 200;
            // 
            // colBtnSua
            // 
            colBtnSua.HeaderText = "Sửa";
            colBtnSua.MinimumWidth = 6;
            colBtnSua.Name = "colBtnSua";
            colBtnSua.Resizable = DataGridViewTriState.True;
            colBtnSua.SortMode = DataGridViewColumnSortMode.Automatic;
            colBtnSua.Width = 50;
            // 
            // colBtnXoa
            // 
            colBtnXoa.HeaderText = "Xóa";
            colBtnXoa.MinimumWidth = 6;
            colBtnXoa.Name = "colBtnXoa";
            colBtnXoa.Resizable = DataGridViewTriState.True;
            colBtnXoa.SortMode = DataGridViewColumnSortMode.Automatic;
            colBtnXoa.Width = 50;
            // 
            // FormGiangVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 833);
            Controls.Add(dataDanhSachGiangVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnThemGiangVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbKhoa);
            Controls.Add(txtTenGiangVien);
            Controls.Add(txtMaGiangVien);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormGiangVien";
            Text = "FormGiangVien";
            Load += FormGiangVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataDanhSachGiangVien).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.TextBox txtTenGiangVien;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemGiangVien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dataDanhSachGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnSua;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnXoa;
    }
}