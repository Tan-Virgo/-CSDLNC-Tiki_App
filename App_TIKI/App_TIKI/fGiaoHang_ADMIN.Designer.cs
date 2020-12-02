namespace App_TIKI
{
    partial class fGiaoHang_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiaoHang_ADMIN));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChiTietPhieuGui = new System.Windows.Forms.DataGridView();
            this.dtgvPhieuGuiHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.btnCapNhanNgayNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuGuiHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "CHI TIẾT PHIẾU GỬI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "DANH SÁCH PHIẾU GỬI HÀNG";
            // 
            // dtgvChiTietPhieuGui
            // 
            this.dtgvChiTietPhieuGui.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvChiTietPhieuGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuGui.Location = new System.Drawing.Point(668, 60);
            this.dtgvChiTietPhieuGui.Name = "dtgvChiTietPhieuGui";
            this.dtgvChiTietPhieuGui.RowHeadersWidth = 51;
            this.dtgvChiTietPhieuGui.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuGui.Size = new System.Drawing.Size(606, 286);
            this.dtgvChiTietPhieuGui.TabIndex = 24;
            // 
            // dtgvPhieuGuiHang
            // 
            this.dtgvPhieuGuiHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvPhieuGuiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuGuiHang.Location = new System.Drawing.Point(12, 60);
            this.dtgvPhieuGuiHang.Name = "dtgvPhieuGuiHang";
            this.dtgvPhieuGuiHang.RowHeadersWidth = 51;
            this.dtgvPhieuGuiHang.RowTemplate.Height = 24;
            this.dtgvPhieuGuiHang.Size = new System.Drawing.Size(606, 286);
            this.dtgvPhieuGuiHang.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgayNhan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(13, 366);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 54);
            this.panel2.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày nhận:";
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Location = new System.Drawing.Point(92, 17);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(253, 22);
            this.dtpNgayNhan.TabIndex = 28;
            // 
            // btnCapNhanNgayNhan
            // 
            this.btnCapNhanNgayNhan.BackColor = System.Drawing.Color.Gold;
            this.btnCapNhanNgayNhan.Location = new System.Drawing.Point(428, 377);
            this.btnCapNhanNgayNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhanNgayNhan.Name = "btnCapNhanNgayNhan";
            this.btnCapNhanNgayNhan.Size = new System.Drawing.Size(190, 39);
            this.btnCapNhanNgayNhan.TabIndex = 28;
            this.btnCapNhanNgayNhan.Text = "Cập nhật ngày nhận hàng";
            this.btnCapNhanNgayNhan.UseVisualStyleBackColor = false;
            // 
            // fGiaoHang_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1288, 442);
            this.Controls.Add(this.btnCapNhanNgayNhan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvChiTietPhieuGui);
            this.Controls.Add(this.dtgvPhieuGuiHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGiaoHang_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu giao hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuGuiHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuGui;
        private System.Windows.Forms.DataGridView dtgvPhieuGuiHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapNhanNgayNhan;
    }
}