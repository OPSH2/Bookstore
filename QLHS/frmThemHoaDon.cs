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
    public partial class frmThemHoaDon : Form
    {
        string cs = "Data Source=.;Initial Catalog=Bookstore;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public frmThemHoaDon()
        {
            InitializeComponent();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select sdt from dbo.KhachHang where sdt like '%" +comboBox1.Text+ "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "sdt";
            con.Close();
        }

        

        private void txtTimKiemSPHD_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select *from dbo.SanPham where maSP like '%" + txtTimKiemSPHD.Text + "%' or tenSP like '%" + txtTimKiemSPHD.Text + "%' or hangMuc like '%" + txtTimKiemSPHD.Text + "%' or donGia like '%" + txtTimKiemSPHD.Text + "%' or donVi like'%" + txtTimKiemSPHD.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dtgrdvwSP_HD.DataSource = dt;
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmThemHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if(dtgrdvwSP_HD.SelectedRows.Count != 0)
            {
                CT_HD temp = new CT_HD();
                temp.maHD = txtmaHD.Text;
                temp.maSP = dtgrdvwSP_HD.SelectedRows[0].Cells[0].Value.ToString();
                temp.soLuong = Convert.ToInt32(numericSoLuong.Value);
                temp.donGia = Convert.ToInt32(dtgrdvwSP_HD.SelectedRows[0].Cells[3].Value);
                temp.thanhTien = temp.soLuong * temp.donGia;

                dtgridvwCTHD.Rows.Add(temp.maSP, temp.soLuong, temp.donGia, temp.thanhTien);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Đã có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtmaHD.Text = "";
            txtmaHD.Text = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
        }

        private void btnLoaiBo_Click(object sender, EventArgs e)
        {
            if(dtgridvwCTHD.SelectedRows.Count != 0)
            {
                dtgridvwCTHD.Rows.RemoveAt(dtgridvwCTHD.SelectedRows[0].Index);
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            int total = 0;
            using (var db = new BookstoreEntities1())
            {
                HoaDon temp = new HoaDon();
                temp.maHD = txtmaHD.Text;
                temp.maKH = txtMaKH.Text;
                temp.maNV = frmLogin.interMaNV;
                temp.ngayLapHD = DateTime.Now;
                temp.tongTien = total;
                db.HoaDons.Add(temp);
                db.SaveChanges();
            }           
            foreach(DataGridViewRow row in this.dtgridvwCTHD.Rows)
            {
                if (row.IsNewRow) continue;
                CT_HD temp = new CT_HD();
                temp.maHD = txtmaHD.Text;
                temp.maSP = row.Cells[1].Value?.ToString();
                temp.soLuong = Convert.ToInt32(row.Cells[2].Value);
                temp.donGia = Convert.ToInt32(row.Cells[3].Value);
                temp.thanhTien = temp.soLuong * temp.donGia;
                total += Convert.ToInt32(temp.thanhTien);
                using(var db = new BookstoreEntities1())
                {
                    db.CT_HD.Add(temp);
                    db.SaveChanges();
                }
            }
            using(var db = new BookstoreEntities1())
            {
                HoaDon t =  db.HoaDons.FirstOrDefault(hd => hd.maHD == txtmaHD.Text);
                t.tongTien = total;
                db.SaveChanges();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThemKhachHang temp = new frmThemKhachHang();
            temp.Show();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            using(var db = new BookstoreEntities1())
            {
                KhachHang temp = db.KhachHangs.Where(kh => kh.sdt == comboBox1.Text).Single();
                txtMaKH.Text = temp.maKH;
                txtTenKH.Text = temp.tenKH;
            }
        }
    }
}
