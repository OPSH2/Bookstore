using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHS
{
    public partial class Form1 : Form
    {
        string cs = "Data Source=.;Initial Catalog=Bookstore;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public static string GoesBetweenForms = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (frmLogin.interMaNV == "")
            {
                groupBox3.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel2.Visible = false;
                panel4.Visible = false;
                monthCalendar1.Visible = false;
                lvwAfternoonShift.Visible = false;
                lvwEveningShift.Visible = false;
                lvwMorningShift.Visible = false;
                btnThemLich.Visible = false;
                btnXoaCa.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }
            else
            {
                using(var db = new BookstoreEntities1())
                {
                    if (db.NhanViens.Find(frmLogin.interMaNV).viTri != "QL        ")
                    {
                        btnThemLich.Visible = false;
                        btnXoaCa.Visible = false;
                        panel11.Visible = false;
                        panel12.Visible = false;
                    }
                }
            }
            // TODO: This line of code loads data into the 'bookstoreDataSet2.NhanVien' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'bookstoreDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.bookstoreDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'bookstoreDataSet.SanPham' table. You can move, or remove it, as needed.
            
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemSach temp = new frmThemSach();
            temp.ShowDialog();
        }

        private void mntbQuanLiSanPham_Click(object sender, EventArgs e)
        {

        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }



        private void tbchiaca_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lvwMorningShift.Items.Clear();
            lvwAfternoonShift.Items.Clear();
            lvwEveningShift.Items.Clear();
            var time = monthCalendar1.SelectionStart.Date;
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where caSangChieuToi like '%Sáng%' and ngayLamViec ='"+ time +"' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(dr["tenNV"].ToString());
                listitem.SubItems.Add(dr["gioMoCa"].ToString());
                lvwMorningShift.Items.Add(listitem);
            }
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where caSangChieuToi like '%Chiều%' and ngayLamViec ='" + time + "' ", con);
            dt.Clear();
            adapt.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(dr["tenNV"].ToString());
                listitem.SubItems.Add(dr["gioMoCa"].ToString());
                lvwAfternoonShift.Items.Add(listitem);
            }
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where caSangChieuToi like '%Tối%' and ngayLamViec ='" + time + "' ", con);
            dt.Clear();
            adapt.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(dr["tenNV"].ToString());
                listitem.SubItems.Add(dr["gioMoCa"].ToString());
                lvwEveningShift.Items.Add(listitem);
            }
            con.Close();
            //Đọc dữ liệu SQL vào 1 bảng rồi gán vào những listview trên//
        }

        private void dtgrvwQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label6.Text = dtgrvwQLSP.SelectedRows[0].Cells[0].Value.ToString();
            label7.Text = dtgrvwQLSP.SelectedRows[0].Cells[1].Value.ToString();
            label8.Text = dtgrvwQLSP.SelectedRows[0].Cells[2].Value.ToString();
            label9.Text = dtgrvwQLSP.SelectedRows[0].Cells[3].Value.ToString();
            label10.Text = dtgrvwQLSP.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txttimkiemsp_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select *from dbo.SanPham where maSP like '%"+txttimkiemsp.Text+ "%' or tenSP like '%" + txttimkiemsp.Text + "%' or hangMuc like '%" + txttimkiemsp.Text + "%' or donGia like '%" + txttimkiemsp.Text + "%' or donVi like'%" + txttimkiemsp.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgrvwQLSP.DataSource = dt;
            con.Close();
        }

        private void dtgrvwQLSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgrvwQLSP_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GoesBetweenForms = dtgrvwQLSP.SelectedRows[0].Cells[0].Value.ToString();
            if (String.Equals(dtgrvwQLSP.SelectedRows[0].Cells[2].Value.ToString(), "Sách                "))
            {
                frmChiTietSach cts = new frmChiTietSach();
                cts.Show();
            }
            else
            {
                frmChiTietVanPhongPham ctvpp = new frmChiTietVanPhongPham();
                ctvpp.Show();
            }
        }

        private void btnThemVanPhongPham_Click(object sender, EventArgs e)
        {
            frmThemSanPham frm = new frmThemSanPham();
            frm.Show();
        }

        private void dtgridvwHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgridvwCTHD.Rows.Clear();
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select *from dbo.CT_HD where maHD like '%"+ dtgridvwHD.SelectedRows[0].Cells[0].Value.ToString() +"%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgridvwCTHD.DataSource = dt;
            con.Close();
        }

        private void dtgrvwQLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmThemHoaDon temp = new frmThemHoaDon();
            temp.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult temp = MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm?", "Warning!", MessageBoxButtons.YesNo);
            if(temp == DialogResult.Yes)
            {
                using (var db = new BookstoreEntities1())
                {
                    var delete = (from d in db.SanPhams where d.maSP == dtgrvwQLSP.SelectedRows[0].Cells[0].Value.ToString() select d).Single();
                    db.SanPhams.Remove(delete);
                    db.SaveChanges();
                }
                MessageBox.Show("Đã xóa thành công sản phẩm "+dtgrvwQLSP.SelectedRows[0].Cells[1].Value.ToString() +".");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            GoesBetweenForms = dtgrvwQLSP.SelectedRows[0].Cells[0].Value.ToString();
            if (String.Equals(dtgrvwQLSP.SelectedRows[0].Cells[2].Value.ToString(), "Sách                "))
            {
                frmChiTietSach cts = new frmChiTietSach();
                cts.Show();
            }
            else
            {
                frmChiTietVanPhongPham ctvpp = new frmChiTietVanPhongPham();
                ctvpp.Show();
            }
        }

        private void txtTimKiemHoaDon_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select hd.maHD as [Mã hóa đơn], nv.tenNV as [Tên nhân viên lập], hd.ngayLapHD as [Ngày lập HD], kh.tenKH as [Khách mua hàng], tongTien as [Tổng tiền] from HoaDon hd join CT_HD cthd on hd.maHD = cthd.maHD join NhanVien nv on hd.maNV = nv.maNV join KhachHang kh on kh.maKH = hd.maKH join SanPham sp on sp.maSP = cthd.maSP where hd.maHD like'%" + txtTimKiemHoaDon.Text + "%' or hd.maNV like '%" + txtTimKiemHoaDon.Text + "%' or ngayLapHD like'%" + txtTimKiemHoaDon.Text + "%' or hd.maKH like '%" + txtTimKiemHoaDon.Text + "%' or tenKH like '%" + txtTimKiemHoaDon.Text + "%' or tenSP like '%" + txtTimKiemHoaDon.Text + "%' group by hd.maHD, tenNV, ngayLapHD, tenKH, tongTien", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgridvwHD.DataSource = dt;
            con.Close();
        }

        private void txtTimKiemKhachHang_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from KhachHang where maKH like '%" + txtTimKiemKhachHang.Text + "%' or tenKH like '%" + txtTimKiemKhachHang.Text + "%' or sdt like '%" + txtTimKiemKhachHang.Text + "%' or gioiTinh like '%" + txtTimKiemKhachHang.Text + "%' or email like '%" + txtTimKiemKhachHang.Text + "%' or ngaySinh like '%" + txtTimKiemKhachHang.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgridvwKhachHang.DataSource = dt;
            con.Close();
            //Tiếp tục hoàn thành phần khách hàng, clone qua nhân viên, thêm recommendation mã tự tạo bằng ngày/chức vụ//
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang temp = new frmThemKhachHang();
            temp.Show();
        }

        private void dtgridvwKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //Tiếp tục xử lí chỉnh sửa thông tin khách hàng//
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (dtgridvwKhachHang.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn khách hàng cần đổi thông tin.", "Warning!");
            else
            {
                string idtimkiem = dtgridvwKhachHang.SelectedRows[0].Cells[0].Value.ToString(); //Không làm trực tiếp để ngăn lỗi LINQ to Entities does not recognize the method 'System.Windows.Forms.DataGridViewCell get_Item(Int32)' method//
                if (txtMaKH.Text == null)
                    MessageBox.Show("Vui lòng nhập mã khách hàng.", "Warning!");
                else
                {
                    using(var db = new BookstoreEntities1())
                    {
                        KhachHang temp = db.KhachHangs.FirstOrDefault(kh => kh.maKH == idtimkiem);
                        temp.maKH = txtMaKH.Text;
                        temp.tenKH = txtMaKH.Text;
                        temp.sdt = txtSDT.Text;
                        temp.gioiTinh = txtGioiTinh.Text;
                        temp.ngaySinh = dateNgaySinh.Value;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Đã thay đổi thông tin thành công.", "Notification!");
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (dtgridvwKhachHang.SelectedRows.Count == 0)
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
            else
            {
                DialogResult diag = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng " + txtTenKH.Text + "?", "Warning!", MessageBoxButtons.YesNo);
                if(diag == DialogResult.Yes)
                {
                    using(var db = new BookstoreEntities1())
                    {
                        var delete = (from kh in db.KhachHangs where kh.maKH == txtMaKH.Text select kh).Single();
                        db.KhachHangs.Remove(delete);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Đã xóa thành công khách hàng" + txtTenKH.Text, "Thông báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void dtgridvwKhachHang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaKH.Text = dtgridvwKhachHang.SelectedRows[0].Cells[0].Value.ToString();
            txtTenKH.Text = dtgridvwKhachHang.SelectedRows[0].Cells[1].Value.ToString();
            txtSDT.Text = dtgridvwKhachHang.SelectedRows[0].Cells[2].Value.ToString();
            txtGioiTinh.Text = dtgridvwKhachHang.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dtgridvwKhachHang.SelectedRows[0].Cells[4].Value.ToString();
            dateNgaySinh.Value = Convert.ToDateTime(dtgridvwKhachHang.SelectedRows[0].Cells[5].Value);
        }

        private void txtTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from NhanVien where maNV like '%" + txtTimKiemNhanVien.Text + "%' or tenNV like '%" + txtTimKiemNhanVien.Text + "%' or viTri like '%" + txtTimKiemNhanVien.Text + "%' or sdt like '%" + txtTimKiemNhanVien.Text + "%' or gioiTinh like '%" + txtTimKiemNhanVien.Text + "%' or email like '%" + txtTimKiemNhanVien.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgridviewNhanVien.DataSource = dt;
            con.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemNhanVien temp = new frmThemNhanVien();
            temp.Show();
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            if (dtgridviewNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chỉnh sửa thông tin.");
            }
            else
            {
                string tempid4alter = dtgridviewNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                if (txtMaNV.Text == null || txtViTri.Text == null || txtPassword.Text == null)
                    MessageBox.Show("Vui lòng điền đầy đủ các thông tin.");
                else
                {
                    using (var db = new BookstoreEntities1())
                    {
                        if (db.NhanViens.Find(txtMaNV.Text) == null || txtMaNV.Text == dtgridviewNhanVien.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            var alterNV = db.NhanViens.FirstOrDefault(nv => nv.maNV == tempid4alter);
                            alterNV.maNV = txtMaNV.Text;
                            alterNV.tenNV = txtTenNV.Text;
                            alterNV.gioiTinh = txtGioiTinh.Text;
                            alterNV.email = txtEmail.Text;
                            alterNV.ngaysinh = dateNgaySinhNV.Value;
                            alterNV.matkhau = CreateMD5(txtPassword.Text);
                            db.SaveChanges();
                            MessageBox.Show("Đã chỉnh sửa thành công.");
                        }
                        else
                            MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng điền mã khác!", "Warning!");
                    }
                }
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (dtgridviewNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa thông tin!");
            }
            else
            {
                DialogResult diag = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên " + dtgridviewNhanVien.SelectedRows[0].Cells[1].Value.ToString(), "Thông báo!", MessageBoxButtons.YesNo);
                if(diag == DialogResult.Yes)
                    {
                        using(var db = new BookstoreEntities1())
                        {
                        var delete = (from d in db.NhanViens where d.maNV == dtgridviewNhanVien.SelectedRows[0].Cells[0].Value.ToString() select d).Single();
                        db.NhanViens.Remove(delete);
                        db.SaveChanges();
                        }
                    }
            }    
        }

        public static DateTime shiftdate;

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            string tempmacas = "CAS" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString();
            string tempmacat = "CAT" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString();
            string tempmacac = "CAC" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString();
            CaLamViec casang = new CaLamViec();
            casang.maCaTruc = tempmacas;
            casang.ngayLamViec = monthCalendar1.SelectionStart.Date;
            CaLamViec cachieu = new CaLamViec();
            cachieu.maCaTruc = tempmacac;
            cachieu.ngayLamViec = monthCalendar1.SelectionStart.Date;
            CaLamViec catoi = new CaLamViec();
            catoi.maCaTruc = tempmacat;
            catoi.ngayLamViec = monthCalendar1.SelectionStart.Date;
            using (var db = new BookstoreEntities1())
            {
                if(db.CaLamViecs.Find(tempmacas)==null)
                    db.CaLamViecs.Add(casang);
                if(db.CaLamViecs.Find(tempmacac)==null)
                    db.CaLamViecs.Add(cachieu);
                if(db.CaLamViecs.Find(tempmacat)==null)
                    db.CaLamViecs.Add(catoi);
                db.SaveChanges();
            }
            shiftdate = monthCalendar1.SelectionStart.Date;
            frmThemCa temp = new frmThemCa();
            temp.Show();
            //Tạo ca trước rồi mới tạo chi tiết ca khi qua form mới//
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Bạn chắc chắn muốn xóa ca làm của nhân viên này? ", "Warning", MessageBoxButtons.YesNo);
            if(diag == DialogResult.Yes)
            {
                using (var db = new BookstoreEntities1())
                {
                    if (lvwMorningShift.SelectedItems.Count == 1)
                    {
                        var delete = (from d in db.CT_CaLamViec where d.maCaTruc == "CA" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString() || d.NhanVien.tenNV == lvwMorningShift.SelectedItems[0].SubItems[0].Text select d).Single();
                        db.CT_CaLamViec.Remove(delete);
                    }
                    if (lvwAfternoonShift.SelectedItems.Count == 1)
                    {
                        var delete = (from d in db.CT_CaLamViec where d.maCaTruc == "CA" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString() || d.NhanVien.tenNV == lvwAfternoonShift.SelectedItems[0].SubItems[0].Text select d).Single();
                        db.CT_CaLamViec.Remove(delete);
                    }
                    if (lvwEveningShift.SelectedItems.Count == 1)
                    {
                        var delete = (from d in db.CT_CaLamViec where d.maCaTruc == "CA" + monthCalendar1.SelectionRange.Start.Year.ToString() + monthCalendar1.SelectionRange.Start.Month.ToString() + monthCalendar1.SelectionRange.Start.Day.ToString() || d.NhanVien.tenNV == lvwEveningShift.SelectedItems[0].SubItems[0].Text select d).Single();
                        db.CT_CaLamViec.Remove(delete);
                    }
                    db.SaveChanges();
                }
            }
        }

        private void dtgridviewNhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtViTri.Text = dtgridviewNhanVien.SelectedRows[0].Cells[2].Value.ToString();
            txtSDTNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            txtGioiTinh.Text = dtgridviewNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtEmail.Text = dtgridviewNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            txtPassword.Text = dtgridviewNhanVien.SelectedRows[0].Cells[6].Value.ToString();
            dateNgaySinhNV.Value = Convert.ToDateTime(dtgridviewNhanVien.SelectedRows[0].Cells[7].Value);

        }

        private void dtgridvwHD_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtmaHD.Text = dtgridvwHD.SelectedRows[0].Cells[0].Value.ToString();
            txtNhanVienLap.Text = dtgridvwHD.SelectedRows[0].Cells[1].Value.ToString();
            dateNgayLapHD.Value = Convert.ToDateTime(dtgridvwHD.SelectedRows[0].Cells[2].Value);
            txtKhachHang.Text = dtgridvwHD.SelectedRows[0].Cells[3].Value.ToString();
            txtTongTien.Text = dtgridvwHD.SelectedRows[0].Cells[4].Value.ToString();
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select maHD as [Mã hóa đơn], cthd.maSP as [Mã sản phẩm], tenSP as [Tên sản phẩm], soLuong as [Số Lượng], cthd.donGia as [Đơn giá], thanhTien as [Thành tiền] from CT_HD cthd join SanPham sp on sp.maSP = cthd.maSP where maHD like '" + txtmaHD.Text + "'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgridvwCTHD.DataSource = dt;
            con.Close();
        }
    }
}
