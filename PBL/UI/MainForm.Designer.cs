namespace PBL3.fe
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLopHocPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPhongHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLapLich = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXepLichTuDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXemThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemXem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuLapLich,
            this.menuXemThoiKhoaBieu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(900, 36);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(106, 29);
            this.menuHeThong.Text = "Hệ Thống";
            // 
            // itemThoat
            // 
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.Size = new System.Drawing.Size(270, 34);
            this.itemThoat.Text = "Thoát";
            this.itemThoat.Click += new System.EventHandler(this.itemThoat_Click);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGiangVien,
            this.itemLopHocPhan,
            this.itemPhongHoc});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(92, 29);
            this.menuQuanLy.Text = "Quản Lý";
            // 
            // itemGiangVien
            // 
            this.itemGiangVien.Name = "itemGiangVien";
            this.itemGiangVien.Size = new System.Drawing.Size(270, 34);
            this.itemGiangVien.Text = "Giảng Viên";
            this.itemGiangVien.Click += new System.EventHandler(this.itemGiangVien_Click);
            // 
            // itemLopHocPhan
            // 
            this.itemLopHocPhan.Name = "itemLopHocPhan";
            this.itemLopHocPhan.Size = new System.Drawing.Size(270, 34);
            this.itemLopHocPhan.Text = "Lớp Học Phần";
            this.itemLopHocPhan.Click += new System.EventHandler(this.itemLopHocPhan_Click);
            // 
            // itemPhongHoc
            // 
            this.itemPhongHoc.Name = "itemPhongHoc";
            this.itemPhongHoc.Size = new System.Drawing.Size(270, 34);
            this.itemPhongHoc.Text = "Phòng Học";
            this.itemPhongHoc.Click += new System.EventHandler(this.itemPhongHoc_Click);
            // 
            // menuLapLich
            // 
            this.menuLapLich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemXepLichTuDong});
            this.menuLapLich.Name = "menuLapLich";
            this.menuLapLich.Size = new System.Drawing.Size(91, 29);
            this.menuLapLich.Text = "Lập Lịch";
            // 
            // itemXepLichTuDong
            // 
            this.itemXepLichTuDong.Name = "itemXepLichTuDong";
            this.itemXepLichTuDong.Size = new System.Drawing.Size(270, 34);
            this.itemXepLichTuDong.Text = "Xếp Lịch Tự Động";
            this.itemXepLichTuDong.Click += new System.EventHandler(this.itemXepLichTuDong_Click);
            // 
            // menuXemThoiKhoaBieu
            // 
            this.menuXemThoiKhoaBieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemXem});
            this.menuXemThoiKhoaBieu.Name = "menuXemThoiKhoaBieu";
            this.menuXemThoiKhoaBieu.Size = new System.Drawing.Size(186, 32);
            this.menuXemThoiKhoaBieu.Text = "Xem Thời Khóa Biểu";
            // 
            // itemXem
            // 
            this.itemXem.Name = "itemXem";
            this.itemXem.Size = new System.Drawing.Size(270, 34);
            this.itemXem.Text = "Xem";
            this.itemXem.Click += new System.EventHandler(this.itemXem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem itemThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem itemGiangVien;
        private System.Windows.Forms.ToolStripMenuItem itemLopHocPhan;
        private System.Windows.Forms.ToolStripMenuItem itemPhongHoc;
        private System.Windows.Forms.ToolStripMenuItem menuLapLich;
        private System.Windows.Forms.ToolStripMenuItem itemXepLichTuDong;
        private System.Windows.Forms.ToolStripMenuItem menuXemThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem itemXem;
    }
}

