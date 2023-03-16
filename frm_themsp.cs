using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace quanlycuahangthuoc
{
    public partial class frm_themsp : Form
    {
        conectdb conn = new conectdb();
        private void clien()
        {
            txt_tenthuoc.Text = "";
            txt_soluong.Text = "";
            //dateTimePicker1.Value.ToString("dd-MM-yyyy");
            
            txt_gia.Text = "";

           
            
        }

        public void load_char()
        {
            int kho = 1000;
            int tong = Convert.ToInt32(conn.tong_sp());
            chart1.Series.Clear();
            //chart1.Legends.Clear();

            //thêm chú thích và cài đặt khung chú thích
            //chart1.Legends.Add("MyLegend");
            //chart1.Legends[0].LegendStyle = LegendStyle.Table;
            //chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].Alignment = StringAlignment.Center;
            //chart1.Legends[0].Title = "MyTitle";
            //chart1.Legends[0].BorderColor = Color.Black;


            ////Add a new chart-series
            //string seriesname = "MySeriesName";
            //chart1.Series.Add(seriesname);
            ////set the chart-type to "Pie"
            //chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            string Series1 = "Series1";
            chart1.Series.Add(Series1);
            ////set the chart-type to "Pie"
            chart1.Series[Series1].ChartType = SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            
            chart1.Series[Series1].IsValueShownAsLabel = true;
            chart1.Series[Series1].Points.AddXY("sản phẩm  ", tong);
            chart1.Series[Series1].Points.AddXY("còn trống kho ", (kho - tong));
            //chart1.Series[seriesname].Points.AddXY("", 3);
        }
        public frm_themsp()
        {
            InitializeComponent();
            chart1.Titles.Add("thông tin kho ");
            load_char();

            cb_lohang.DataSource = conn.Load_lohang();
            cb_lohang.DisplayMember = "ngaynhap";
            cb_lohang.ValueMember = "lo";

            cb_nhanvien.DataSource = conn.Load_nhanvien();
            cb_nhanvien.DisplayMember = "tennv";
            cb_nhanvien.ValueMember = "manv";

            cb_loaisp.DataSource = conn.Load_loaisp();
            cb_loaisp.DisplayMember = "loai";
            cb_loaisp.ValueMember = "id";

            
            dgv_sanpham.DataSource = conn.Load_sanpham();

            listView1.FullRowSelect=true;
            listView1.MultiSelect = true;

            // ẩn control tạo lô
            lbo.Visible = false;
            lbo2.Visible = false;
            lbo3.Visible = false;
            dtp_taolo.Visible = false;
            cb_nhanvien2.Visible = false;
            txt_nhacungcap.Visible = false;
            bt_dslo.Visible = false;

            dgv_dslo.Visible = false;

            lbonew.Visible = false;

            dataGridView1.DataSource = conn.Load_loaisp();

            bt_xoaloai.Visible = false;

            label2.Hide();
            label2.Text = "ay";

            bt_sualoai.Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            //lo.Text = cb_lohang.SelectedValue.ToString();

            if(listView1.Items.Count==0)
            {
                MessageBox.Show("bạn chưa có sản phẩm nào để them vào kho ");
            }

            bool checksp = false ;
            string checkstr = "";
            for(int i= 0; i<listView1.Items.Count;i++)
            {
                if(conn.check_sanpham(listView1.Items[i].SubItems[0].Text,listView1.Items[i].SubItems[1].Text))
                {
                    checksp = true;
                    checkstr = "thêm thất bại tại vì tên sản phẩm : " + listView1.Items[i].SubItems[1].Text +" đã tồn tại , đã thêm những sản phẩm trước sản phẩm lỗi ";
                    break;
                }

                if(conn.them_sp(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text, listView1.Items[i].SubItems[3].Text, listView1.Items[i].SubItems[4].Text, listView1.Items[i].SubItems[5].Text, listView1.Items[i].SubItems[6].Text, listView1.Items[i].SubItems[7].Text) == false)
                {
                    checksp = true;
                    checkstr = "thêm thất bại tại sản phẩm : " + listView1.Items[i].SubItems[0].Text ;
                    break ;
                }
                else
                {
                    load_char();
                    
                    checksp = false;
                }
                
            }
            
            if(checksp ==true)
            {
                MessageBox.Show(checkstr);
            }
            else
            {
                listView1.Items.Clear();
            }

            
            dgv_sanpham.DataSource = conn.Load_sanpham();
            //txt_nganhap.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        // check tên sản phẩm trong bảng listview
        public bool check_listview(string tenthuoc,int soluong)
        {
            bool check = false;
           
            for (int i=0;i<soluong;i++)
            {

                
                
                if (tenthuoc == listView1.Items[i].SubItems[1].Text)
                {
                    return check = true;
                }

            }
            return check = false;
        }
        private void them_Click(object sender, EventArgs e)
        {
            int soluong = listView1.Items.Count;
            if(string.IsNullOrEmpty(txt_tenthuoc.Text) || string.IsNullOrEmpty(txt_soluong.Text)  || string.IsNullOrEmpty(txt_gia.Text) )
            {
                MessageBox.Show("yêu cầu nhập đủ các thông tin");
                return;
            }
            if (listView1.Items.Count>0)
            {

                //lo.Text = listView1.Items[1].SubItems[1].Text;
                if (check_listview(txt_tenthuoc.Text, soluong) == true)
                {
                    MessageBox.Show("tên thuốc đã tồn tại");
                    return;
                }
                
                
            }
            
            DateTime ngaynhap = DateTime.Parse(dtp_ngaynhap.Value.ToString("dd/MM/yyyy"));
            DateTime ngayhethan = DateTime.Parse(dtp_ngayhethan.Value.ToString("dd/MM/yyyy"));


            if (ngaynhap > ngayhethan)
            {
                MessageBox.Show("ngày hết hạn phải lớn hơn ngày nhập");
                return;
            }
            int a;
            if(int.TryParse(txt_soluong.Text,out a )==false)
            {
                MessageBox.Show("số lượng nhập sai kiểu");
                return ;
            }
            float ay;
            if (float.TryParse(txt_gia.Text, out ay) == false)
            {
                MessageBox.Show("giá nhập sai kiểu");
                return;
            }

            ListViewItem item = new ListViewItem();
            item.Text =  cb_lohang.SelectedValue.ToString();
            listView1.Items.Add(item);
            item.SubItems.Add(txt_tenthuoc.Text);
            item.SubItems.Add(cb_loaisp.SelectedValue.ToString());
            item.SubItems.Add(dtp_ngaynhap.Value.ToString("yyyy/MM/dd"));
            item.SubItems.Add(cb_nhanvien.SelectedValue.ToString());
            item.SubItems.Add(dtp_ngayhethan.Value.ToString("yyyy/MM/dd"));
            item.SubItems.Add(txt_soluong.Text);
            item.SubItems.Add(txt_gia.Text);
            

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            int a = 0;
            for(int i = 0; i < listView1.Items.Count ; i++)
            {
                if(listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
            }
            
        }

        private void xoa2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void bt_taolo_Click(object sender, EventArgs e)
        {
            if(lbo.Visible == false)
            {
                lbo.Visible = true;
                lbo2.Visible = true;
                lbo3.Visible = true;
                dtp_taolo.Visible = true;
                cb_nhanvien2.Visible = true;
                txt_nhacungcap.Visible = true;
                bt_dslo.Visible = true;

                dgv_dslo.Visible = false;

                cb_nhanvien2.DataSource = conn.Load_nhanvien();
                cb_nhanvien2.DisplayMember = "tennv";
                cb_nhanvien2.ValueMember = "manv";

               
            }
            else
            {
                lbonew.Visible = true;
                if (string.IsNullOrEmpty(txt_nhacungcap.Text))
                {
                    MessageBox.Show("yêu cầu nhập nhà cung cấp");
                    return;
                }
                string ngaynhap = dtp_taolo.Value.ToString("MM/dd/yyyy");
                if (conn.them_lohang(ngaynhap, cb_nhanvien2.SelectedValue.ToString(), txt_nhacungcap.Text) ==true)
                {
                    MessageBox.Show("tạo lô hàng hành công");
                }
                else
                {
                    MessageBox.Show("tạo lô hàng thất bại ");
                    return;


                }
                lbonew.Text = "lô hàng mới " + dtp_taolo.Value.ToString("dd/MM/yyyy");

                lbo.Visible = false;
                lbo2.Visible = false;
                lbo3.Visible = false;
                dtp_taolo.Visible = false;
                cb_nhanvien2.Visible = false;
                txt_nhacungcap.Visible = false;

                // load lại dữ liệu
                cb_lohang.DataSource = conn.Load_lohang();
                cb_lohang.DisplayMember = "ngaynhap";
                cb_lohang.ValueMember = "lo";

            }
        }

        private void bt_dslo_Click(object sender, EventArgs e)
        {
            lbo.Visible = false;
            lbo2.Visible = false;
            lbo3.Visible = false;
            dtp_taolo.Visible = false;
            cb_nhanvien2.Visible = false;
            txt_nhacungcap.Visible = false;

            dgv_dslo.Visible = true;
            dgv_dslo.DataSource = conn.Load_lohang();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            bt_xoaloai.Visible = true;

            bt_sualoai.Visible = true;

            string maKH = dataGridView1.Rows[0].Cells[0].Value.ToString();

            //if (turn.Text.Equals(gameOverString)) { return; }


            MessageBox.Show("bạn vừa chọn " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() );

            txt_tenloai.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();  // click vào cột chỉ định cài SelectionMode = RowHeaderSelect 

            label2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //txt_soluong.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


            //int numrow; 
            //numrow = e.RowIndex;
            //txt_soluong.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();

            //if (e.ColumnIndex == 1) //1 là cột thứ 1 theo bài cuả bạn
            //{
            //    int u = int.Parse(e.RowIndex.ToString()); //lấy chỉ số dòng
            //    int giatri = int.Parse(dataGridView1.Rows[u].Cells[0].Value.ToString()); //cell[1] ô mà bạn cần lấy giá trị
            //    txt_soluong.Text = maKH;
            //}
        }

        private void bt_taoloaisp_Click(object sender, EventArgs e)
        {
            if(conn.check_loaisp(txt_tenloai.Text) == true)
            {
                MessageBox.Show("tên loại đã tồn tại" );
                return;
            }
            else
            {
                conn.them_loaisanpham(txt_tenloai.Text);
                dataGridView1.DataSource = conn.Load_loaisp();
            }
        }

        private void bt_xoaloai_Click(object sender, EventArgs e)
        {
            if(conn.check_key_loai(txt_tenloai.Text) == true)
            {
                MessageBox.Show("bạn không thể xóa tên loại đang được sử dụng ");
                return;
            }
            else
            {
                if(conn.xoa_loai(txt_tenloai.Text) == true)
                {
                    MessageBox.Show("xóa thành công ");
                    dataGridView1.DataSource = conn.Load_loaisp();
                    bt_xoaloai.Visible = false;
                    return;
                }
                else
                {
                    MessageBox.Show("xóa không thành công ");
                    return;
                }
            }
        }

        private void bt_sualoai_Click(object sender, EventArgs e)
        {
            if (conn.check_loaisp(txt_tenloai.Text) == true)
            {
                MessageBox.Show("tên loại đã tồn tại");
                return;
            }
            else
            {
                
                //txt_soluong.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
                if(label2.Text =="ay")
                {
                    MessageBox.Show("bạn chưa chọn thẻ ");
                    return;
                }

                DialogResult dl = MessageBox.Show("bạn muốn sửa loại thuốc có id : " + label2.Text + " ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    conn.update_loaisp(label2.Text, txt_tenloai.Text);
                    bt_sualoai.Visible = false;
                    txt_tenthuoc.Clear();
                    dataGridView1.DataSource = conn.Load_loaisp();
                }
                

            }
        }

        private void frm_themsp_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void gia_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_themsp_FormClosing(object sender, FormClosingEventArgs e)
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
