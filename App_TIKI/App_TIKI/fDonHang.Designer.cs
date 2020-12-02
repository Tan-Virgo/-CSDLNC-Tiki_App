namespace App_TIKI
{
    partial class fDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDonHang));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDonHang = new System.Windows.Forms.DataGridView();
            this.dtgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbTrangThai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(329, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 54);
            this.panel2.TabIndex = 2;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đang giao",
            "Đã giao",
            "Đã hủy"});
            this.cbTrangThai.Location = new System.Drawing.Point(104, 14);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(239, 24);
            this.cbTrangThai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng:";
            // 
            // dtgvDonHang
            // 
            this.dtgvDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonHang.Location = new System.Drawing.Point(16, 128);
            this.dtgvDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDonHang.Name = "dtgvDonHang";
            this.dtgvDonHang.RowHeadersWidth = 51;
            this.dtgvDonHang.Size = new System.Drawing.Size(497, 366);
            this.dtgvDonHang.TabIndex = 3;
            // 
            // dtgvChiTietDonHang
            // 
            this.dtgvChiTietDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietDonHang.Location = new System.Drawing.Point(560, 128);
            this.dtgvChiTietDonHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang";
            this.dtgvChiTietDonHang.RowHeadersWidth = 51;
            this.dtgvChiTietDonHang.Size = new System.Drawing.Size(491, 366);
            this.dtgvChiTietDonHang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // fDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvChiTietDonHang);
            this.Controls.Add(this.dtgvDonHang);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvDonHang;
        private System.Windows.Forms.DataGridView dtgvChiTietDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}