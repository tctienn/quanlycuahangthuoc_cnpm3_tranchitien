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
    public partial class frm_ql_taikhoan : Form
    {
        conectdb conn = new conectdb();
        public frm_ql_taikhoan()
        {
            InitializeComponent();
            dgv_taikhoan.DataSource = conn.load_taikhoan();
            cb_cap.Text = "3";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            frm_Create_Account createa = new frm_Create_Account();
            createa.ShowDialog();

        }

        private void frm_ql_taikhoan_Load(object sender, EventArgs e)
        {

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string giatri = "";

            if (string.IsNullOrEmpty(txt_tim.Text) == false)
                giatri = " where tk like '%"+txt_tim.Text +"%'";
            dgv_taikhoan.DataSource = conn.tim_taikhoan(giatri);
        }

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_newmk.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[0].Value.ToString();

            lb_taikhoan.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[1].Value.ToString();

            cb_cap.Text = dgv_taikhoan.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string tk = lb_taikhoan.Text;
            string up_str = "";
            if(tk == "...")
            {
                MessageBox.Show("bạn chưa chọn tài khoản");
                return;
            }
            if(ckb_mk.Checked== true && ckb_cap.Checked == true)
            {
                up_str = " set mk ='" + conn.mahoa(txt_newmk.Text) + "' , cap = '"+ cb_cap.Text +"'";
            }
            else
            {
                if(ckb_mk.Checked == true)
                {
                    if(string.IsNullOrEmpty(txt_newmk.Text))
                    {
                        MessageBox.Show("yêu cầu nhập mk nếu muốn đổi mật khẩu");
                        return;
                    }
                    up_str = " set mk ='" + conn.mahoa(txt_newmk.Text) + "'";
                }
                else
                {
                    if(ckb_cap.Checked == true) //
                    {
                        up_str = " set cap ='" + cb_cap.Text + "'";
                    }
                    else
                    {
                        MessageBox.Show(" bạn chưa chọn thành phần thực hiện ");
                        return;
                    }
                }
            }

            if(conn.update_taikhoan(tk, up_str) == true)
            {
                MessageBox.Show("cập nhật thành công");
                dgv_taikhoan.DataSource = conn.load_taikhoan();
            }
            else
                MessageBox.Show("cập nhật thất bại" + up_str);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string tk = lb_taikhoan.Text;
            if (tk == "...")
            {
                MessageBox.Show("bạn chưa chọn tài khoản");
                return;
            }
            else
            {

                if (MessageBox.Show("THÔNG BÁO", "BẠN MUỐN xóa tài khoản " + tk + " ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (conn.xoa_tk(tk))
                    {
                        MessageBox.Show("xóa tài khoản : " + tk + " thành công ");
                        dgv_taikhoan.DataSource = conn.load_taikhoan();

                    }
                    else
                    {
                        MessageBox.Show("xóa tài khoản : " + tk + " thất bại");

                    }
                }
                
                
            }
        }
    }
}
