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
                labelMaSP.Text = temp.maSP;
                labelTenSP.Text = temp.tenSP;
                labelHangMuc.Text = temp.hangMuc;
                labelDonGia.Text = temp.donGia.ToString();
                labelDonViBan.Text = temp.donVi;
                labelSoLuong.Text = temp1.soLuongTon.ToString();
                labelnhacungcap.Text = temp1.nhaCC;
            }
        }
    }
}
