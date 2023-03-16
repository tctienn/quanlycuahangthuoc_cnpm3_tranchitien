using quanlycuahangthuoc.Properties;
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
    public partial class frm_hoadon : Form
    {
        conectdb conn = new conectdb();
        public frm_hoadon()
        {
            InitializeComponent();
            bt_in.Enabled = false;

            cb_nhanvien.DataSource = conn.Load_nhanvien();
            cb_nhanvien.DisplayMember = "tennv";

            lv_dsmua.FullRowSelect = true;
            lv_dsmua.MultiSelect = true;

            DateTime now = DateTime.Now;
            label1.Text = now.ToString("yyyymmddhhmmss");
            string giatri = " where deleteed =0 ";
            dgv_sanpham.DataSource = conn.tim_sanpham_thanhtoan(giatri);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

           
            Image img = Resources.Ảnh_chụp_màn_hình_2022_11_23_215923;
            //e.Graphics.DrawImage(img , 0 ,0 , img.Width , img.Height);
            e.Graphics.DrawImage(img, 240, 0, 400, 400);

            

            e.Graphics.DrawString("tên người dùng : " + lb_nguoimua.Text ,new Font("Arial",12,FontStyle.Regular), Brushes.Black ,new Point(25 ,340));
            e.Graphics.DrawString("số điện thoại : " + lb_sdt_nguoimua.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString("ngày mua : " + dtp_ngay.Value.ToString("dd/MM/yyyy"), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 360));
            e.Graphics.DrawString("__________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 400));

            e.Graphics.DrawString("stt : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 440));
            e.Graphics.DrawString("tên sản phẩm : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 440));
            e.Graphics.DrawString("số lượng : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 440));
            e.Graphics.DrawString("giá : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 440));
            e.Graphics.DrawString("__________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));

            int dong=480;
            int cach=25;
            int stt=1;
            e.HasMorePages = false;
            for (int i=0; i< lv_dathanhtoan.Items.Count;i++)
            {



                

                e.Graphics.DrawString(stt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, dong));
                e.Graphics.DrawString(lv_dathanhtoan.Items[i].SubItems[1].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, dong));
                e.Graphics.DrawString(lv_dathanhtoan.Items[i].SubItems[2].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, dong));
                e.Graphics.DrawString(lv_dathanhtoan.Items[i].SubItems[3].Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, dong));
                dong += 20;
                stt ++;
                //if (i >= 1 && i <= 2)
                //{
                //    e.HasMorePages = true;
                    
                //}
                //if(i==4)
                //{
                //    e.HasMorePages = false;
                //}

            } 

            e.Graphics.DrawString("__________________________________________________________________________________________________________________", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, dong ));
            dong += 20;
            e.Graphics.DrawString("số loại sản phẩm : " + (stt -1) , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, dong ));
            dong += 20;
            e.Graphics.DrawString("tổng tiền : " + lb_tien_dathanhtoan.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, dong ));
            //////////////////////////////////////////////////////////////////////////////////////
            /////
            ///

            //dong = 1050;
            //e.HasMorePages = (dong > 500); // in 1 văn bản nhiều trang








            ////////////////////////////////////////////////////////////////////////////////////////





        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

            }
            catch
            {
                //throw new NotImplementedException();
            }


            
        }

        private void ay_Load(object sender, EventArgs e)
        {

        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_masanpham.Text = dgv_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
            lb_tsp.Text = dgv_sanpham.Rows[e.RowIndex].Cells[1].Value.ToString();
            int a = 0;  int.TryParse(dgv_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString(), out a);
            lb_kho.Text = a.ToString();
            nb_soluong.Value = 1;
            lb_gia1.Text = dgv_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString() ;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string giatri = " where deleteed =0 ";
            if(string.IsNullOrEmpty(txt_tim.Text) == true )
            {
                dgv_sanpham.DataSource = conn.tim_sanpham_thanhtoan(giatri);
            }
            else
            {
                giatri = " where tenthuoc like '%" + txt_tim.Text + "%'  and deleteed =0";
                dgv_sanpham.DataSource = conn.tim_sanpham_thanhtoan(giatri);
            }
        }

        private void nb_soluong_ValueChanged(object sender, EventArgs e)
        {
            int a; int.TryParse(lb_kho.Text, out a);
            if(nb_soluong.Value >a )
            {
                MessageBox.Show("số lượng thuốc không được nhiều hơn số dư trong kho ");
                nb_soluong.Value = 1;
                return;
            }
        }

        private void tb_them_Click(object sender, EventArgs e)
        {
            int sas; int.TryParse(lb_kho.Text, out sas);
            if (nb_soluong.Value > sas)
            {
                MessageBox.Show("số lượng thuốc không được nhiều hơn số dư trong kho ");
                nb_soluong.Value = 1;
                return;
            }

            if (nb_soluong.Value <=0  )
            {
                MessageBox.Show("số lượng sản phẩm không đạt yêu cầu ");
                return;
            }
            else
            {
                if(lb_tsp.Text == "null")
                {
                    MessageBox.Show("chưa chọn sản phẩm ");
                    return;
                }

                for(int i =0; i < lv_dsmua.Items.Count ; i++)
                {
                    if(lb_tsp.Text == lv_dsmua.Items[i].SubItems[1].Text )
                    {
                        MessageBox.Show("sản phẩm đã nằm trong danh sách thanh toán ");
                        return;
                    }
                }

                ListViewItem item = new ListViewItem();
                item.Text = lb_masanpham.Text;
                lv_dsmua.Items.Add(item);
                item.SubItems.Add(lb_tsp.Text);
                item.SubItems.Add(nb_soluong.Value.ToString());
                item.SubItems.Add(lb_gia1.Text);
                item.SubItems.Add(lb_kho.Text);

                float tong = 0;
                float gia = 0;
                float soluong = 0;
                if(lv_dsmua.Items.Count >0 )
                {
                    for (int i = 0; i < lv_dsmua.Items.Count; i++)
                    {
                        float.TryParse(lv_dsmua.Items[i].SubItems[2].Text, out gia);
                        float.TryParse(lv_dsmua.Items[i].SubItems[3].Text, out soluong);
                        tong = tong + gia * soluong;

                    }
                    lb_tong.Text = tong.ToString();
                }

            }

        }

        private void bt_new_hoadon_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("yyyymmddhhmmss");
            string giatri = "where deleteed =0";

            dgv_sanpham.DataSource = conn.tim_sanpham_thanhtoan(giatri);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < lv_dsmua.Items.Count; i++)
            {
                if (lv_dsmua.Items[i].Selected)
                {
                    lv_dsmua.Items[i].Remove();
                    i--;
                }
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            if(lv_dsmua.Items.Count ==0)
            {
                MessageBox.Show("bạn không thể thanh toán khi chưa có sản phẩm ");
                return;

            }
            if(string.IsNullOrEmpty(txt_tenkhachhang.Text) || string.IsNullOrEmpty(txt_sodienthoai.Text) )
            {
                MessageBox.Show("bạn cần điền đủ thông tin khách hàng");
                return;
            }
            else
            {
                float ayy;
                if( float.TryParse(txt_sodienthoai.Text ,out ayy)==false)
                {
                    MessageBox.Show("nhập số điện thoại khách hàng sai kiểu ");
                    return;
                }
            }

            if(conn.them_khachhang(label1.Text , txt_tenkhachhang.Text , txt_sodienthoai.Text ) == true )
            {
                if(conn.them_hoadon(label1.Text , label1.Text , dtp_ngay.Value.ToString("yyyy/MM/dd") , cb_nhanvien.Text , lb_tong.Text) == true )
                {
                    for (int i = 0; i < lv_dsmua.Items.Count; i++)
                    {
                        if (conn.them_sanpham_hoadon(label1.Text, lv_dsmua.Items[i].SubItems[0].Text, lv_dsmua.Items[i].SubItems[1].Text, lv_dsmua.Items[i].SubItems[3].Text, lv_dsmua.Items[i].SubItems[2].Text) == false)
                        {
                            MessageBox.Show("lỗi thêm sản phẩm vào sách hóa đơn ");
                            return;
                        }

                        int kho=0, lay=0, con=0;
                        int.TryParse(lv_dsmua.Items[i].SubItems[2].Text, out lay); int.TryParse(lv_dsmua.Items[i].SubItems[4].Text, out kho);
                        con = kho - lay;
                        if(conn.upate_sanpham_hoadon(lv_dsmua.Items[i].SubItems[0].Text ,con.ToString() )  ==false )
                        {
                            MessageBox.Show("lỗi cập nhật sản phẩm trong kho ");
                            return;
                        }
                        
                     }

                    //// tạo thành công hóa đơn
                    
                    string giatri = " where deleteed =0 ";
                    dgv_sanpham.DataSource = conn.tim_sanpham_thanhtoan(giatri);
                    MessageBox.Show("tạo xong hóa đơn của khách hàng : " + txt_tenkhachhang.Text );
                    load_lv_dathanhtoan();
                    lb_nguoimua.Text = txt_tenkhachhang.Text;
                    lb_sdt_nguoimua.Text = txt_sodienthoai.Text;
                    lb_tien_dathanhtoan.Text = lb_tong.Text;
                    if(lv_dathanhtoan.Items.Count >0 )
                        bt_in.Enabled = true;

                    // hóa đơn mới
                    txt_tenkhachhang.Clear();
                    txt_sodienthoai.Clear();
                    lv_dsmua.Items.Clear();
                    DateTime now = DateTime.Now;
                    label1.Text = now.ToString("yyyymmddhhmmss");
                    return;
                }
                else
                {
                    MessageBox.Show("lỗi tạo hóa đơn2");
                    return;
                }
            }
            else
            {
                MessageBox.Show("lỗi tạo hóa đơn");
                return;
            }
        }

        public void load_lv_dathanhtoan()
        {
            lv_dathanhtoan.Items.Clear();
            for(int i=0;i< lv_dsmua.Items.Count;i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lv_dsmua.Items[i].SubItems[0].Text;
                lv_dathanhtoan.Items.Add(item);
                item.SubItems.Add(lv_dsmua.Items[i].SubItems[1].Text);
                item.SubItems.Add(lv_dsmua.Items[i].SubItems[2].Text);
                item.SubItems.Add(lv_dsmua.Items[i].SubItems[3].Text);
                //item.SubItems.Add(lv_dsmua.Items[i].SubItems[4].Text);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void printPreviewDialog1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
