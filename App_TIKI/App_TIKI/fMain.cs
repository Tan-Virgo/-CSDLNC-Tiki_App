using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_TIKI
{
    public partial class fMain : Form
    {
        int VaiTro = 0;  // 0: Chưa đăng nhập, 1: Khách hàng, 2: Nhà bán, 3: ADMIN
        public fMain()
        {
            InitializeComponent();
            fLogin f = new fLogin();
            f.ShowDialog();

            if (VaiTro != 0)
                f.Close();
        }

        private void txbFind_Leave(object sender, EventArgs e)
        {
            if (txbFind.Text == "")
            {
                txbFind.Text = "Nhập nội dung tìm kiếm";
                txbFind.ForeColor = Color.Gray;
            }
        }

        private void txbFind_Enter(object sender, EventArgs e)
        {
            if (txbFind.Text == "Nhập nội dung tìm kiếm")
            {
                txbFind.Text = "";
                txbFind.ForeColor = Color.Black;
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinCaNhan f = new fThongTinCaNhan();
            f.ShowDialog();
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaiKhoan f = new fTaiKhoan();
            f.ShowDialog();
        }

        private void khuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhuyenMai f = new fKhuyenMai();
            f.ShowDialog();
        }

        private void giỏHàngChưaMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGioHangChuaMua f = new fGioHangChuaMua();
            f.ShowDialog();
        }

        private void xemCácĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonHang f = new fDonHang();
            f.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSanPham f = new fSanPham();
            f.ShowDialog();
        }

        private void đơnHàngĐangGiaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fDonHangKhach f = new fDonHangKhach();
            f.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fTaiKhoanADMIN f = new fTaiKhoanADMIN();
            f.ShowDialog();
        }

        private void nhânViênGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVienGiao f = new fNhanVienGiao();
            f.ShowDialog();
        }

        private void nhậpXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapXuatKho f = new fNhapXuatKho();
            f.ShowDialog();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapKho f = new fNhapKho();
            f.ShowDialog();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXuatKho f = new fXuatKho();
            f.ShowDialog();
        }

        private void phiếuGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuGuiHang f = new fPhieuGuiHang();
            f.ShowDialog();
        }

        private void phiếuGửiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGiaoHang_ADMIN f = new fGiaoHang_ADMIN();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongKe f = new fThongKe();
            f.ShowDialog();
        }
    }
}
