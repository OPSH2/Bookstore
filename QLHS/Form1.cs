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
            // TODO: This line of code loads data into the 'bookstoreDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.bookstoreDataSet2.NhanVien);
            // TODO: This line of code loads data into the 'bookstoreDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.bookstoreDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'bookstoreDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.bookstoreDataSet.SanPham);

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemSach temp = new frmThemSach();
            temp.ShowDialog();
        }

        private void mntbQuanLiSanPham_Click(object sender, EventArgs e)
        {

        }

        

        private void tbchiaca_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lvwMorningShift.Items.Clear();
            lvwAfternoonShift.Items.Clear();
            lvwEveningShift.Items.Clear();
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
                ChiTietSach cts = new ChiTietSach();
                cts.Show();
            }
        }
    }
}
