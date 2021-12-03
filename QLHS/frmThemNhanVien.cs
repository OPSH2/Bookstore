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
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaNV.Text = "NV"+ DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + DateTime.Now.Hour.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == null)
                MessageBox.Show("Vui lòng nhập mã nhân viên và các thông tin cần thiết");
            else
            {
                using (var db = new BookstoreEntities1())
                {
                    if (db.NhanViens.Find(txtMaNV.Text) == null)
                    {
                        NhanVien newnv = new NhanVien();
                        newnv.maNV = txtMaNV.Text;
                        newnv.tenNV = txtTenNV.Text;
                        newnv.sdt = txtSDT.Text;
                        newnv.ngaysinh = dateNgaySinhNhanVien.Value;
                        newnv.viTri = cbbViTri.Text;
                        newnv.email = txtEmailNV.Text;
                        newnv.matkhau = Form1.CreateMD5(txtMatKhau.Text);
                        db.NhanViens.Add(newnv);
                        db.SaveChanges();
                        MessageBox.Show("Đá thêm thành công nhân viên " + txtTenNV.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập mã mới hoặc tạo tự động mã nhân viên mới.", "Warning!");
                }
            }
            //Tiếp tục phẩn chỉnh sửa và thêm ca, Note: Validacation là lỗi khi datatype bị sai và cập nhật trên SQL sẽ không tự động cập nhật trên framework//
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            txtEmailNV.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
        }
    }
}
