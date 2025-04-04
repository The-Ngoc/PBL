namespace PBL3.fe
{
    partial class FormXepThoiKhoaBieu
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
            cbbChonGiangVien = new ComboBox();
            cbbChonMonHoc = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnXepLich = new Button();
            cbbChonPhongHoc = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            colKhoa = new DataGridViewTextBoxColumn();
            colLopHocPhan = new DataGridViewTextBoxColumn();
            colGiangVien = new DataGridViewTextBoxColumn();
            colPhongHoc = new DataGridViewTextBoxColumn();
            colThuTiet = new DataGridViewTextBoxColumn();
            cbbChonKhoa = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbbLopHocPhan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbbChonGiangVien
            // 
            cbbChonGiangVien.FormattingEnabled = true;
            cbbChonGiangVien.Location = new Point(546, 123);
            cbbChonGiangVien.Margin = new Padding(4, 5, 4, 5);
            cbbChonGiangVien.Name = "cbbChonGiangVien";
            cbbChonGiangVien.Size = new Size(238, 33);
            cbbChonGiangVien.TabIndex = 0;
            cbbChonGiangVien.SelectedIndexChanged += cbbChonGiangVien_SelectedIndexChanged;
            // 
            // cbbChonMonHoc
            // 
            cbbChonMonHoc.FormattingEnabled = true;
            cbbChonMonHoc.Location = new Point(546, 201);
            cbbChonMonHoc.Margin = new Padding(4, 5, 4, 5);
            cbbChonMonHoc.Name = "cbbChonMonHoc";
            cbbChonMonHoc.Size = new Size(238, 33);
            cbbChonMonHoc.TabIndex = 1;
            cbbChonMonHoc.SelectedIndexChanged += cbbChonMonHoc_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "Giảng Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 269);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 3;
            label2.Text = "Lớp Học Phần";
            // 
            // btnXepLich
            // 
            btnXepLich.Location = new Point(587, 385);
            btnXepLich.Margin = new Padding(4, 5, 4, 5);
            btnXepLich.Name = "btnXepLich";
            btnXepLich.Size = new Size(171, 72);
            btnXepLich.TabIndex = 4;
            btnXepLich.Text = "Xếp Lịch";
            btnXepLich.UseVisualStyleBackColor = true;
            btnXepLich.Click += btnXepLich_Click;
            // 
            // cbbChonPhongHoc
            // 
            cbbChonPhongHoc.FormattingEnabled = true;
            cbbChonPhongHoc.Location = new Point(546, 329);
            cbbChonPhongHoc.Margin = new Padding(4, 5, 4, 5);
            cbbChonPhongHoc.Name = "cbbChonPhongHoc";
            cbbChonPhongHoc.Size = new Size(238, 33);
            cbbChonPhongHoc.TabIndex = 5;
            cbbChonPhongHoc.SelectedIndexChanged += cbbChonPhongHoc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(398, 337);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 6;
            label3.Text = "Phòng Học";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colKhoa, colLopHocPhan, colGiangVien, colPhongHoc, colThuTiet });
            dataGridView1.Location = new Point(70, 467);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1185, 316);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colKhoa
            // 
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.Width = 150;
            // 
            // colLopHocPhan
            // 
            colLopHocPhan.HeaderText = "Lớp Học Phần";
            colLopHocPhan.MinimumWidth = 6;
            colLopHocPhan.Name = "colLopHocPhan";
            colLopHocPhan.Width = 200;
            // 
            // colGiangVien
            // 
            colGiangVien.HeaderText = "Giảng Viên";
            colGiangVien.MinimumWidth = 6;
            colGiangVien.Name = "colGiangVien";
            colGiangVien.Width = 200;
            // 
            // colPhongHoc
            // 
            colPhongHoc.HeaderText = "Phòng Học";
            colPhongHoc.MinimumWidth = 6;
            colPhongHoc.Name = "colPhongHoc";
            colPhongHoc.Width = 125;
            // 
            // colThuTiet
            // 
            colThuTiet.HeaderText = "Thứ, Tiết";
            colThuTiet.MinimumWidth = 6;
            colThuTiet.Name = "colThuTiet";
            colThuTiet.Width = 125;
            // 
            // cbbChonKhoa
            // 
            cbbChonKhoa.FormattingEnabled = true;
            cbbChonKhoa.Location = new Point(546, 45);
            cbbChonKhoa.Margin = new Padding(4, 5, 4, 5);
            cbbChonKhoa.Name = "cbbChonKhoa";
            cbbChonKhoa.Size = new Size(238, 33);
            cbbChonKhoa.TabIndex = 8;
            cbbChonKhoa.SelectedIndexChanged += cbbChonKhoa_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(409, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 9;
            label4.Text = "Khoa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 204);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 10;
            label5.Text = "Chon mon hoc";
            // 
            // cbbLopHocPhan
            // 
            cbbLopHocPhan.FormattingEnabled = true;
            cbbLopHocPhan.Location = new Point(547, 267);
            cbbLopHocPhan.Name = "cbbLopHocPhan";
            cbbLopHocPhan.Size = new Size(242, 33);
            cbbLopHocPhan.TabIndex = 11;
            cbbLopHocPhan.SelectedIndexChanged += cbbLopHocPhan_SelectedIndexChanged;
            // 
            // FormXepThoiKhoaBieu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 858);
            Controls.Add(cbbLopHocPhan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbbChonKhoa);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(cbbChonPhongHoc);
            Controls.Add(btnXepLich);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbChonMonHoc);
            Controls.Add(cbbChonGiangVien);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormXepThoiKhoaBieu";
            Text = "FormThoiKhoaBieu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChonGiangVien;
        private System.Windows.Forms.ComboBox cbbChonMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXepLich;
        private System.Windows.Forms.ComboBox cbbChonPhongHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbChonKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopHocPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuTiet;
        private Label label5;
        private ComboBox cbbLopHocPhan;
    }
}