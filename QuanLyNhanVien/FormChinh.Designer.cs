namespace QuanLyNhanVien
{
    partial class FormChinh
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.btnChiTiet);
            this.groupBox1.Controls.Add(this.btnBangLuong);
            this.groupBox1.Controls.Add(this.btnChamCong);
            this.groupBox1.Controls.Add(this.btnPhongBan);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Image")));
            this.btnDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(805, 9);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(123, 85);
            this.btnDoiMatKhau.TabIndex = 5;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.White;
            this.btnChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.Image")));
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(645, 9);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(117, 85);
            this.btnChiTiet.TabIndex = 4;
            this.btnChiTiet.Text = "Thông tin\r\nchi tiết";
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BackColor = System.Drawing.Color.White;
            this.btnBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBangLuong.Image")));
            this.btnBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangLuong.Location = new System.Drawing.Point(489, 9);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(117, 85);
            this.btnBangLuong.TabIndex = 3;
            this.btnBangLuong.Text = "Bảng Lương";
            this.btnBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(331, 9);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(119, 85);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.Color.White;
            this.btnPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.Image")));
            this.btnPhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongBan.Location = new System.Drawing.Point(174, 9);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(119, 85);
            this.btnPhongBan.TabIndex = 1;
            this.btnPhongBan.Text = "Phòng Ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhongBan.UseVisualStyleBackColor = false;
            this.btnPhongBan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(22, 9);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(116, 85);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(6, 9);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.Size = new System.Drawing.Size(934, 405);
            this.dgvHienThi.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHienThi);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 420);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(15, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Xin Chào";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTK.Location = new System.Drawing.Point(115, 128);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(139, 25);
            this.labelTK.TabIndex = 9;
            this.labelTK.Text = "labelTaiKhoan";
            this.labelTK.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(664, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "labelThongBao";
            this.label3.Visible = false;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChinh";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Label label3;
    }
}

