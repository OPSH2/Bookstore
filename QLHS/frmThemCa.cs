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
    public partial class frmThemCa : Form
    {
        string cs = "Data Source=.;Initial Catalog=Bookstore;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public frmThemCa()
        {
            InitializeComponent();
        }

        string globmacatruc = "CA" + Form1.shiftdate.Year.ToString() + Form1.shiftdate.Month.ToString() + Form1.shiftdate.Day.ToString();

        private void loadCaSang()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where ct.maCaTruc like '%CAS"+ Form1.shiftdate.Year.ToString() + Form1.shiftdate.Month.ToString() + Form1.shiftdate.Day.ToString() + "%' ", con);
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
            con.Close();
        }

        private void loadCaToi()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where ct.maCaTruc like '%CAT" + Form1.shiftdate.Year.ToString() + Form1.shiftdate.Month.ToString() + Form1.shiftdate.Day.ToString() + "%' ", con);
            dt = new DataTable();
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
        }

        private void loadCaChieu()
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select tenNV, gioMoCa from CaLamViec c join CT_CaLamViec ct on c.maCaTruc =ct.maCaTruc join NhanVien nv on ct.maNV = nv.maNV where ct.maCaTruc like '%CAC" + Form1.shiftdate.Year.ToString() + Form1.shiftdate.Month.ToString() + Form1.shiftdate.Day.ToString() + "%' ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem();
                listitem.SubItems.Add(dr["tenNV"].ToString());
                listitem.SubItems.Add(dr["gioMoCa"].ToString());
                lvwAfternoonShift.Items.Add(listitem);
            }
            con.Close();
        }

        private void frmThemCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookstoreDataSet2.NhanVien' table. You can move, or remove it, as needed.
            loadCaSang();
            loadCaChieu();
            loadCaToi();
            dateLamViecNV.Value = Form1.shiftdate;
        }

        private void dtgridviewNhanVien_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtSDTNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[3].Value.ToString();
            if (dtgridviewNhanVien.SelectedRows[0].Cells[2].Value.ToString() == "QL        ")
                txtViTri.Text = "Quản lí";
            if (dtgridviewNhanVien.SelectedRows[0].Cells[2].Value.ToString() == "NV        ")
                txtViTri.Text = "Thu ngân";
            if (dtgridviewNhanVien.SelectedRows[0].Cells[2].Value.ToString() == "SP        ")
                txtViTri.Text = "Giao hàng";
            txtGioiTinhNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailNV.Text = dtgridviewNhanVien.SelectedRows[0].Cells[5].Value.ToString();
            dateLamViecNV.Value = Form1.shiftdate;
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == null)
                MessageBox.Show("Vui lòng chọn nhân viên để xếp vào ca.", "Warning!");
            else
            {
                if (cbbCa.SelectedItem.ToString() == null)
                    MessageBox.Show("Vui lòng chọn ca để xếp cho nhân viên " + txtTenNV.Text + " tại vị trí " + txtViTri.Text);
                else
                {
                    CT_CaLamViec temp = new CT_CaLamViec();
                    temp.maNV = txtMaNV.Text;
                    if (cbbCa.SelectedItem.ToString() == "Sáng")
                    {
                        temp.maCaTruc = "CAS" + dateLamViecNV.Value.Year.ToString() + dateLamViecNV.Value.Month.ToString() + dateLamViecNV.Value.Day.ToString();
                        temp.caSangChieuToi = "Sáng";
                        temp.gioMoCa = new TimeSpan(7, 0, 0);
                        temp.gioDongCa = new TimeSpan(12, 0, 0);
                    }
                    if(cbbCa.SelectedItem.ToString() == "Chiều")
                    {
                        temp.maCaTruc = "CAC" + dateLamViecNV.Value.Year.ToString() + dateLamViecNV.Value.Month.ToString() + dateLamViecNV.Value.Day.ToString();
                        temp.caSangChieuToi = "Chiều";
                        temp.gioMoCa = new TimeSpan(13, 0, 0);
                        temp.gioDongCa = new TimeSpan(17, 30, 0);
                    }
                    if (cbbCa.SelectedItem.ToString() == "Tối")
                    {
                        temp.maCaTruc = "CAT" + dateLamViecNV.Value.Year.ToString() + dateLamViecNV.Value.Month.ToString() + dateLamViecNV.Value.Day.ToString();
                        temp.caSangChieuToi = "Tối";
                        temp.gioMoCa = new TimeSpan(18, 30, 0);
                        temp.gioDongCa = new TimeSpan(22, 0, 0);
                    }
                    using(var db = new BookstoreEntities1())
                    {
                        db.CT_CaLamViec.Add(temp);
                        db.SaveChanges();
                    }
                }
            }
            //Sửa lại, tay mã bằng chữ cái duplicate key x2 thì không bị trùng.//
            frmThemCa_Load(sender,e);
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
    }
}
