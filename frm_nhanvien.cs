using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycuahangthuoc
{
    public partial class frm_nhanvien : Form
    {
        conectdb conn = new conectdb();

        public void load_lis()
        {

            listView1.Items.Clear();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MA3LKHC\SQLEXPRESS;Initial Catalog=do_an_net;Integrated Security=True");
            //Phương thức Fill có tác dụng "chuyển" toàn bộ dữ liệu từ DataAdapter sang dataset
            //SqlDataAdapter trong C# hoạt động như một cầu nối giữa DataSet và nguồn dữ liệu (Cở sở dữ liệu SQL Server) để truy xuất dữ liệu
            SqlCommand cmd = new SqlCommand("select * from nhanvien", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["manv"].ToString();
                listView1.Items.Add(item);
                item.SubItems.Add(dr["tennv"].ToString());
                item.SubItems.Add(dr["diachi"].ToString());
                item.SubItems.Add(dr["gioitinh"].ToString());
                item.SubItems.Add(dr["sdt"].ToString());
                item.SubItems.Add(dr["namsinh"].ToString());

                //listView1.Items.Add(dr["manv"].ToString());
                //listView1.Items[i].SubItems.Add(dr["tennv"].ToString());
                //listView1.Items[i].SubItems.Add(dr["diachi"].ToString());
                //listView1.Items[i].SubItems.Add(dr["gioitinh"].ToString());
                //listView1.Items[i].SubItems.Add(dr["sdt"].ToString());
                //listView1.Items[i].SubItems.Add(dr["tuoi"].ToString());
                int a;
                if (int.TryParse(dr["trangthai"].ToString(), out a) == true)
                {
                    if (a > 0)
                    {
                        item.SubItems.Add("đang hoạt động");
                    }
                    else
                    {
                        item.SubItems.Add("đã nghỉ");
                    }

                }



                i++;
            }

            conn.Close();

        }
        public frm_nhanvien()
        {
            InitializeComponent();
            load_lis();

            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;

            bt_update.Visible = false;
            bt_on_off.Visible = false;
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Text))
            {
                MessageBox.Show("yêu cầu nhập tên nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                MessageBox.Show("yêu cầu nhập địa chỉ nhân viên");
                return;
            }
            int a;
            if (int.TryParse(txt_sdt.Text, out a) == false)
            {
                MessageBox.Show("số điện thoại nhập sai kiểu");
                return;
            }

            if (int.TryParse(txt_tuoi.Text, out a) == false )
            {
                MessageBox.Show("nhập nhập năm sinh sai kiểu sai kiểu");
                return;
            }
            
            string gioitinh = "nam";
            if (radioButton1.Checked == true)
            {
                gioitinh = "nam";
            }
            else
            {
                gioitinh = "nữ";
            }
            if (conn.them_nhanvien(txt_ten.Text, txt_diachi.Text, gioitinh, txt_sdt.Text, txt_tuoi.Text) == true)
            {
                MessageBox.Show("thêm nhân viên thành công");

                load_lis();
                txt_ten.Clear();
                txt_diachi.Clear();
                txt_sdt.Clear();
                txt_tuoi.Clear();

                bt_update.Visible = false;
                bt_on_off.Visible = false;

                load_lis();
            }
            else
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_update.Visible = true;
            bt_on_off.Visible = true;

            //txt_ten.Text = listView1.Items[i].SubItems[0].Text;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    //txt_ten.Text = listView1.SelectedItems[0].Text;
                    txt_ten.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    txt_diachi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                    if (listView1.SelectedItems[0].SubItems[3].Text == "nam")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    txt_sdt.Text = listView1.SelectedItems[0].SubItems[4].Text;
                    txt_tuoi.Text = listView1.SelectedItems[0].SubItems[5].Text;
                    
                    if (String.Compare(listView1.SelectedItems[0].SubItems[6].Text, "đã nghỉ", true) == 1)
                    {
                        bt_on_off.Text = "tắt hoạt động";
                    }
                    else
                    {
                        bt_on_off.Text = "bật hoạt động";
                    }
                    //i--;
                }
            }
            //txt_ten.Text = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void bt_on_off_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    if (listView1.SelectedItems[0].SubItems[6].Text == "đang hoạt động")
                    {
                        
                        DialogResult dl = MessageBox.Show("Bạn muốn cho nghỉ việc nhân viên " + listView1.SelectedItems[0].SubItems[1].Text + " ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dl == DialogResult.OK)
                        {
                            conn.update_trangthai_nv(listView1.SelectedItems[0].SubItems[0].Text,"0");
                        }

                    }
                    else
                    {
                        DialogResult dl = MessageBox.Show("Bạn muốn cho nhân viên " + listView1.SelectedItems[0].SubItems[1].Text + " đi làm lại ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dl == DialogResult.OK)
                        {
                            conn.update_trangthai_nv(listView1.SelectedItems[0].SubItems[0].Text, "1");
                        }
                    }
                }
            }

            bt_update.Visible = false;
            bt_on_off.Visible = false;

            load_lis();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_ten.Text))
            {
                MessageBox.Show("yêu cầu nhập tên nhân viên");
                return;
            }
            if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                MessageBox.Show("yêu cầu nhập địa chỉ nhân viên");
                return;
            }
            int a;
            if (int.TryParse(txt_sdt.Text, out a) == false)
            {
                MessageBox.Show("số điện thoại nhập sai kiểu");
                return;
            }

            if (int.TryParse(txt_tuoi.Text, out a) == false )
            {
                MessageBox.Show("nhập năm sinh sai kiểu");
                return;
            }
            string gioitinh = "nam";
            if (radioButton1.Checked == true)
            {
                gioitinh = "nam";
            }
            else
            {
                gioitinh = "nữ";
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    if (conn.update_nhanvien(listView1.SelectedItems[0].SubItems[0].Text, txt_ten.Text, txt_diachi.Text, gioitinh, txt_sdt.Text, txt_tuoi.Text) == true)
                    {
                                                    
                        MessageBox.Show("sửa nhân viên thành công");
                        load_lis();
                        txt_ten.Clear();
                        txt_diachi.Clear();
                        txt_sdt.Clear();
                        txt_tuoi.Clear();

                        bt_update.Visible = false;
                        bt_on_off.Visible = false;

                        return;
                    }
                    else
                    {
                        MessageBox.Show("sửa không thành công");
                        return;
                    }
                }
            }


            
            
        }

        private void frm_nhanvien_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frm_nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("THÔNG BÁO", "BẠN MUỐN ĐÓNG FORM ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // đóng form
                //MessageBox.Show("ay");
                //frm_main mainf = new frm_main();
                //mainf.Show();// = false;
            }
            else
            {
                //xử lí khác
                e.Cancel = true;

            }
        }
    }
}
