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
    public partial class frm_Create_Account : Form
    {
        conectdb conn = new conectdb();
        public frm_Create_Account()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_tao_Click(object sender, EventArgs e)
        {
            
            if(conn.check_taikoan(txt_tk.Text) == true )
            {
                MessageBox.Show("tài khoản đã tồn tại");
                return;
            }
            else
            {
                if(conn.them_taikhoan(txt_tk.Text, conn.mahoa(txt_mk.Text), cb_cap.Text) == true)
                {
                    MessageBox.Show("thêm tai khoản thành công ");

                }
                else
                {
                    MessageBox.Show("thêm tài khoản thất bại ");

                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            
        }
    }
}
