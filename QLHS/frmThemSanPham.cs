using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmThemSanPham : Form
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }

        private void frmThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhaXuatBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTacGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == null || txtTenSanPham.Text == null || txtDonGia.Text == null || txtDonVi.Text == null || txtSoLuong.Text == null)
                MessageBox.Show("Vui lòng nhập mã mặt hàng và đầy đủ các thông tin");
            else
            {
                var chitietsanpham = new DanhMucVanPhongPham();
                var sanpham = new SanPham();
                chitietsanpham.maSP = txtMaSP.Text;
                chitietsanpham.tenSP = txtTenSanPham.Text;
                chitietsanpham.nhaCC = txtNhaCungCap.Text;
                chitietsanpham.soLuongTon = Convert.ToInt32(txtSoLuong.Text);
                sanpham.donGia = Convert.ToInt32(txtDonGia.Text);
                sanpham.donVi = txtDonVi.Text;
                sanpham.maSP = chitietsanpham.maSP;
                sanpham.tenSP = chitietsanpham.tenSP;
                sanpham.hangMuc = txtHangMuc.Text;
                using (var db = new BookstoreEntities1())
                {
                    db.SanPhams.Add(sanpham);
                    db.DanhMucVanPhongPhams.Add(chitietsanpham);
                    db.SaveChanges();
                }
                MessageBox.Show("Đã thêm thành công văn phòng phẩm mới.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtDonVi.Text = "";
            txtHangMuc.Text = "";
            txtMaSP.Text = "";
            txtTenSanPham.Text = "";
            txtNhaCungCap.Text = "";
            txtSoLuong.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "VPP"+DateTime.Now.Year.ToString()+DateTime.Now.Day.ToString()+DateTime.Now.Minute.ToString()+DateTime.Now.Second.ToString();
        }
    }
}
