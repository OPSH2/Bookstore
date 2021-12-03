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
    public partial class frmChiTietVanPhongPham : Form
    {
        public frmChiTietVanPhongPham()
        {
            InitializeComponent();
        }

        private void frmChiTietVanPhongPham_Load(object sender, EventArgs e)
        {
            using(var db = new BookstoreEntities1())
            {
                SanPham temp = new SanPham();
                DanhMucVanPhongPham temp1 = new DanhMucVanPhongPham();
                temp = db.SanPhams.Find(Form1.GoesBetweenForms);
                temp1 = db.DanhMucVanPhongPhams.Find(Form1.GoesBetweenForms);
                txtMaSP.Text = temp.maSP;
                txtTenSP.Text = temp.tenSP;
                txtHangMuc.Text = temp.hangMuc;
                txtDonGia.Text = temp.donGia.ToString();
                txtDonViBan.Text = temp.donVi;
                txtSoLuongTon.Text = temp1.soLuongTon.ToString();
                txtNhaCungCap.Text = temp1.nhaCC;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult diag = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Warning!", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
            {
                using (var db = new BookstoreEntities1())
                {
                    var delete = (from d in db.SanPhams where d.maSP == Form1.GoesBetweenForms select d).Single();
                    var deletect = (from d1 in db.DanhMucVanPhongPhams where d1.maSP == Form1.GoesBetweenForms select d1).Single();
                    db.SanPhams.Remove(delete);
                    db.DanhMucVanPhongPhams.Remove(deletect);
                    db.SaveChanges();
                }
                MessageBox.Show("Đã xóa thành công!");
                this.Close();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using(var db = new BookstoreEntities1())
            {
                SanPham temp = db.SanPhams.FirstOrDefault(sp => sp.maSP == Form1.GoesBetweenForms);
                DanhMucVanPhongPham temp1 = db.DanhMucVanPhongPhams.FirstOrDefault(dmvpp => dmvpp.maSP == Form1.GoesBetweenForms);
                temp.maSP = txtMaSP.Text;
                temp.tenSP = txtTenSP.Text;
                temp.hangMuc = txtHangMuc.Text;
                temp.donGia = Convert.ToInt32(txtDonGia.Text);
                temp.donVi = txtDonViBan.Text;
                temp1.maSP = txtMaSP.Text;
                temp1.tenSP = txtTenSP.Text;
                temp1.nhaCC = txtNhaCungCap.Text;
                temp1.soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
                db.SaveChanges();
            }
            MessageBox.Show("Đã chỉnh sửa thành công.");
            this.Close();
        }
    }
}
