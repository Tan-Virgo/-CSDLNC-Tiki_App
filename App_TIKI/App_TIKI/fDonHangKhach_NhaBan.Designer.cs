﻿namespace App_TIKI
{
    partial class fDonHangKhach_NhaBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDonHangKhach_NhaBan));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.dtgvDonHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // dtgvChiTietDonHang
            // 
            this.dtgvChiTietDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietDonHang.Location = new System.Drawing.Point(418, 104);
            this.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang";
            this.dtgvChiTietDonHang.Size = new System.Drawing.Size(368, 297);
            this.dtgvChiTietDonHang.TabIndex = 9;
            // 
            // dtgvDonHang
            // 
            this.dtgvDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonHang.Location = new System.Drawing.Point(10, 104);
            this.dtgvDonHang.Name = "dtgvDonHang";
            this.dtgvDonHang.Size = new System.Drawing.Size(373, 297);
            this.dtgvDonHang.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbTrangThai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(245, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 44);
            this.panel2.TabIndex = 7;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đang giao",
            "Đã giao",
            "Đã hủy"});
            this.cbTrangThai.Location = new System.Drawing.Point(78, 11);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(180, 21);
            this.cbTrangThai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng:";
            // 
            // fDonHangKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(803, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvChiTietDonHang);
            this.Controls.Add(this.dtgvDonHang);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDonHangKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng của khách";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvChiTietDonHang;
        private System.Windows.Forms.DataGridView dtgvDonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label2;
    }
}