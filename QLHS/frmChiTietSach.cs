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
    public partial class frmChiTietSach : Form
    {
        public frmChiTietSach()
        {
            InitializeComponent();
        }

        private void ChiTietSach_Load(object sender, EventArgs e)
        {
            using (var db = new BookstoreEntities1())
            {
                SanPham temp = new SanPham();
                DanhMucSach temp1 = new DanhMucSach();
                temp1 = db.DanhMucSaches.Find(Form1.GoesBetweenForms);
                temp = db.SanPhams.Find(Form1.GoesBetweenForms);
                txtMaSP.Text = temp.maSP;
                txtTenSP.Text = temp.tenSP;
                txtHangMuc.Text = temp.hangMuc;
                txtDonGia.Text = temp.donGia.ToString();
                txtDonViBan.Text = temp.donVi;
                dateNgayXuatBan.Value = temp1.ngayXuatBan.Value;
                txtNhaXuatBan.Text = temp1.nhaXuatBan;
                txtSoLuongTon.Text = temp1.soLuongTon.ToString();
                txtTacGia.Text = temp1.tacGia;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Warning!", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes)
            {
                using (var db = new BookstoreEntities1())
                {
                    var delete = (from d in db.SanPhams where d.maSP == Form1.GoesBetweenForms select d).Single();
                    var delct = (from d1 in db.DanhMucSaches where d1.maSP == Form1.GoesBetweenForms select d1).Single();
                    db.SanPhams.Remove(delete);
                    db.DanhMucSaches.Remove(delct);
                    db.SaveChanges();
                }
                MessageBox.Show("Đã xóa thành công!");
                this.Close();
            }
            
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            using (var db = new BookstoreEntities1())
            {
                SanPham temp = db.SanPhams.FirstOrDefault(s => s.maSP == Form1.GoesBetweenForms);
                DanhMucSach tempdanhmucsach = db.DanhMucSaches.FirstOrDefault(dms => dms.maSP == Form1.GoesBetweenForms);
                temp.maSP = txtMaSP.Text;
                temp.tenSP = txtTenSP.Text;
                temp.hangMuc = txtHangMuc.Text;
                temp.donGia = Convert.ToInt32(txtDonGia.Text);
                temp.donVi = txtDonViBan.Text;
                tempdanhmucsach.maSP = txtMaSP.Text;
                tempdanhmucsach.tenSP = txtTenSP.Text;
                tempdanhmucsach.nhaXuatBan = txtNhaXuatBan.Text;
                tempdanhmucsach.ngayXuatBan = dateNgayXuatBan.Value;
                tempdanhmucsach.tacGia = txtTacGia.Text;
                tempdanhmucsach.soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
                db.SaveChanges();
            }
            MessageBox.Show("Đã chỉnh sửa thành công.");
            this.Close();
        }
    }
}
