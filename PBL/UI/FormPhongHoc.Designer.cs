namespace PBL3.fe
{
    partial class FormPhongHoc
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
            this.txtMaPhongHoc = new System.Windows.Forms.TextBox();
            this.txtTenPhongHoc = new System.Windows.Forms.TextBox();
            this.txtSoLuongChoNgoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBtnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBtnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaPhongHoc
            // 
            this.txtMaPhongHoc.Location = new System.Drawing.Point(446, 37);
            this.txtMaPhongHoc.Name = "txtMaPhongHoc";
            this.txtMaPhongHoc.Size = new System.Drawing.Size(207, 22);
            this.txtMaPhongHoc.TabIndex = 0;
            // 
            // txtTenPhongHoc
            // 
            this.txtTenPhongHoc.Location = new System.Drawing.Point(446, 84);
            this.txtTenPhongHoc.Name = "txtTenPhongHoc";
            this.txtTenPhongHoc.Size = new System.Drawing.Size(207, 22);
            this.txtTenPhongHoc.TabIndex = 1;
            // 
            // txtSoLuongChoNgoi
            // 
            this.txtSoLuongChoNgoi.Location = new System.Drawing.Point(446, 136);
            this.txtSoLuongChoNgoi.Name = "txtSoLuongChoNgoi";
            this.txtSoLuongChoNgoi.Size = new System.Drawing.Size(207, 22);
            this.txtSoLuongChoNgoi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Phòng Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Phòng Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng Chỗ Ngồi";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(513, 187);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongHoc,
            this.colTenPhongHoc,
            this.colSoLuongChoNgoi,
            this.colTrangThai,
            this.colBtnSua,
            this.colBtnXoa});
            this.dataGridView1.Location = new System.Drawing.Point(68, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 299);
            this.dataGridView1.TabIndex = 7;
            // 
            // colMaPhongHoc
            // 
            this.colMaPhongHoc.HeaderText = "Mã Phòng Học";
            this.colMaPhongHoc.MinimumWidth = 6;
            this.colMaPhongHoc.Name = "colMaPhongHoc";
            // 
            // colTenPhongHoc
            // 
            this.colTenPhongHoc.HeaderText = "Tên Phòng Học";
            this.colTenPhongHoc.MinimumWidth = 6;
            this.colTenPhongHoc.Name = "colTenPhongHoc";
            this.colTenPhongHoc.Width = 150;
            // 
            // colSoLuongChoNgoi
            // 
            this.colSoLuongChoNgoi.HeaderText = "Số Lượng Chỗ Ngồi";
            this.colSoLuongChoNgoi.MinimumWidth = 6;
            this.colSoLuongChoNgoi.Name = "colSoLuongChoNgoi";
            this.colSoLuongChoNgoi.Width = 170;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colBtnSua
            // 
            this.colBtnSua.HeaderText = "Sửa";
            this.colBtnSua.MinimumWidth = 6;
            this.colBtnSua.Name = "colBtnSua";
            this.colBtnSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnSua.Width = 50;
            // 
            // colBtnXoa
            // 
            this.colBtnXoa.HeaderText = "Xóa";
            this.colBtnXoa.MinimumWidth = 6;
            this.colBtnXoa.Name = "colBtnXoa";
            this.colBtnXoa.Width = 50;
            // 
            // FormPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoLuongChoNgoi);
            this.Controls.Add(this.txtTenPhongHoc);
            this.Controls.Add(this.txtMaPhongHoc);
            this.Name = "FormPhongHoc";
            this.Text = "FormPhongHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaPhongHoc;
        private System.Windows.Forms.TextBox txtTenPhongHoc;
        private System.Windows.Forms.TextBox txtSoLuongChoNgoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongChoNgoi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnSua;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnXoa;
    }
}