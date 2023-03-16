using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycuahangthuoc
{
    public partial class frm_login : Form
    {
        conectdb conn = new conectdb();
        public frm_login()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("bạn thực sự muốn thoát" ,"thông báo" , MessageBoxButtons.OKCancel )!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string cap = "";
            if (conn.check_taikoan(txt_tendangnhap.Text) == false )
            {
                MessageBox.Show(" tên tài tên tài khoản không tồn tại ");
                return;
            }

            if(conn.check_dangnhap(txt_tendangnhap.Text , conn.mahoa(txt_matkhau.Text )) == true )
            {
                //conn.captaikhoan(txt_tendangnhap.Text, conn.mahoa(txt_matkhau.Text));
                MessageBox.Show("đăng nhập thành công" );

                cap = conn.captaikhoan(txt_tendangnhap.Text, conn.mahoa(txt_matkhau.Text));



                txt_matkhau.Clear();
                frm_main main = new frm_main(txt_tendangnhap.Text,cap);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("nhập sai mật khẩu");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
