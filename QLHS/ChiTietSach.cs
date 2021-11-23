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
    public partial class ChiTietSach : Form
    {
        public ChiTietSach()
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
                labelMaSP.Text = temp.maSP;
                labelTenSP.Text = temp.tenSP;
                labelHangMuc.Text = temp.hangMuc;
                labelDonGia.Text = temp.donGia.ToString();
                labelDonViBan.Text = temp.donVi;
                labelngayxuatban.Text = temp1.ngayXuatBan.ToString();
                labelnhaxuatban.Text = temp1.nhaXuatBan;
                labelSoLuong.Text = temp1.soLuongTon.ToString();
                labeltacgia.Text = temp1.tacGia;
            }
        }
    }
}
