namespace App_TIKI
{
    partial class fNhapKho_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhapKho_ADMIN));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.dtgvDonHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "CHI TIẾT PHIẾU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH SÁCH PHIẾU NHẬP KHO";
            // 
            // dtgvChiTietDonHang
            // 
            this.dtgvChiTietDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietDonHang.Location = new System.Drawing.Point(563, 47);
            this.dtgvChiTietDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang";
            this.dtgvChiTietDonHang.RowHeadersWidth = 51;
            this.dtgvChiTietDonHang.Size = new System.Drawing.Size(491, 366);
            this.dtgvChiTietDonHang.TabIndex = 14;
            // 
            // dtgvDonHang
            // 
            this.dtgvDonHang.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dtgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonHang.Location = new System.Drawing.Point(19, 47);
            this.dtgvDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDonHang.Name = "dtgvDonHang";
            this.dtgvDonHang.RowHeadersWidth = 51;
            this.dtgvDonHang.Size = new System.Drawing.Size(497, 366);
            this.dtgvDonHang.TabIndex = 13;
            // 
            // fNhapKho_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvChiTietDonHang);
            this.Controls.Add(this.dtgvDonHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fNhapKho_ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập xuất kho";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvChiTietDonHang;
        private System.Windows.Forms.DataGridView dtgvDonHang;
    }
}