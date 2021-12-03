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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtMaKH.Text = "KH" + DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == null)
                MessageBox.Show("Hãy điền đầy đủ thông tin. Bạn có thể tạo mã khách hàng tự động.");
            else
            {
                using (var db = new BookstoreEntities1())
                {
                    if (db.KhachHangs.Find(txtMaKH.Text) == null)
                    {
                        KhachHang temp = new KhachHang();
                        temp.maKH = txtMaKH.Text;
                        temp.tenKH = txtTenKH.Text;
                        temp.sdt = txtSDT.Text;
                        temp.email = txtEmailKH.Text;
                        temp.ngaySinh = dateNgaySinh.Value;
                        temp.gioiTinh = cbbGioiTinh.SelectedItem.ToString();
                        db.KhachHangs.Add(temp);
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm khách hàng mới thành công.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng nhập mã mới hoặc tạo mã tự động","Warning!");
                    }
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            txtEmailKH.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
