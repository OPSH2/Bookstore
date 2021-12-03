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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static string interMaNV = "";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using( var db = new BookstoreEntities1())
            {
                NhanVien log = db.NhanViens.Find(txtmaNV.Text);
                if (log == null)
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                else
                {
                    if (log.matkhau != Form1.CreateMD5(txtPassword.Text))
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
                    else
                    {
                        interMaNV = txtmaNV.Text;
                        Form1 temp = new Form1();
                        temp.Show();
                    }
                }
            }

        }

        private void labelGuestLogin_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }
    }
}
