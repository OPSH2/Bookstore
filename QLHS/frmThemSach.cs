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
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var chitietsach = new DanhMucSach();
            var sanpham = new SanPham();
            chitietsach.maSP = txtMaSP.Text;
            chitietsach.tenSP = txtTenSanPham.Text;
            chitietsach.ngayXuatBan = dateNgayXuatBan.Value;
            chitietsach.nhaXuatBan = txtNhaXuatBan.Text;
            chitietsach.soLuongTon = Convert.ToInt32(txtSoLuong.Text);
            chitietsach.tacGia = txtTacGia.Text;
            sanpham.maSP = chitietsach.maSP;
            sanpham.tenSP = chitietsach.tenSP;
            sanpham.hangMuc = "Sách";
            sanpham.donGia = Convert.ToInt32(txtDonGia.Text);
            sanpham.donVi = txtDonVi.Text;
            using(var db = new BookstoreEntities1())
            {
                db.SanPhams.Add(sanpham);
                db.DanhMucSaches.Add(chitietsach);
                db.SaveChanges();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtDonVi.Text="";
            txtMaSP.Text="";
            txtNhaXuatBan.Text="";
            txtSoLuong.Text="";
            txtTenSanPham.Text="";
            txtTacGia.Text = "";
        }
    }
}
