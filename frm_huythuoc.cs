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

using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;

namespace quanlycuahangthuoc
{
    public partial class frm_huythuoc : Form
    {
        conectdb conn = new conectdb();


        public void load_lis()
        {

            listView1.Items.Clear();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MA3LKHC\SQLEXPRESS;Initial Catalog=do_an_net;Integrated Security=True");
            //Phương thức Fill có tác dụng "chuyển" toàn bộ dữ liệu từ DataAdapter sang dataset
            //SqlDataAdapter trong C# hoạt động như một cầu nối giữa DataSet và nguồn dữ liệu (Cở sở dữ liệu SQL Server) để truy xuất dữ liệu
            SqlCommand cmd = new SqlCommand("SELECT * from sanpham where ngayhethan < CAST(CURRENT_TIMESTAMP AS DATE) and deleteed =0 ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["mathuoc"].ToString();
                listView1.Items.Add(item);
                item.SubItems.Add(dr["lo_lohang"].ToString());
                item.SubItems.Add(dr["tenthuoc"].ToString());
                item.SubItems.Add(dr["id_loaisp"].ToString());

                DateTime dts = DateTime.Parse(dr["ngaynhap"].ToString());
                item.SubItems.Add(String.Format("{0:d}", dts));  // chuyển kiểu từ date sang fomat string (ngày tháng năm gio bị dính thời gian bằng 0 từ sql) 

                DateTime dts2 = DateTime.Parse(dr["ngayhethan"].ToString());
                item.SubItems.Add(String.Format("{0:d}", dts2));
                item.SubItems.Add(dr["soluong"].ToString());

               
               

                //listView1.Items.Add(dr["manv"].ToString());
                //listView1.Items[i].SubItems.Add(dr["tennv"].ToString());
                //listView1.Items[i].SubItems.Add(dr["diachi"].ToString());
                //listView1.Items[i].SubItems.Add(dr["gioitinh"].ToString());
                //listView1.Items[i].SubItems.Add(dr["sdt"].ToString());
                //listView1.Items[i].SubItems.Add(dr["tuoi"].ToString());




                i++;
            }

            conn.Close();

        }
        public void load_list2()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
              
                    //listView11.Items.Add(listView1.Items[i].SubItems[j].Text);

                    ListViewItem item = new ListViewItem();
                    item.Text = listView1.Items[i].SubItems[0].Text; 
                    listView11.Items.Add(item);
                    item.SubItems.Add(listView1.Items[i].SubItems[1].Text);
                    item.SubItems.Add(listView1.Items[i].SubItems[2].Text);
                    item.SubItems.Add(listView1.Items[i].SubItems[3].Text);
                    item.SubItems.Add(listView1.Items[i].SubItems[4].Text);
                    item.SubItems.Add(listView1.Items[i].SubItems[5].Text);
                    item.SubItems.Add(listView1.Items[i].SubItems[6].Text);


                
            }
        }

        public frm_huythuoc()
        {
            InitializeComponent();

            cb_nhanvien.DataSource = conn.Load_nhanvien();
            cb_nhanvien.DisplayMember = "tennv";
            cb_nhanvien.ValueMember = "manv";

            load_lis();

            bt_xuat_word.Visible = false;
            label3.Visible = false;
            listView11.Visible = false;

            
            

            //listView2.Items.AddRange((from ListViewItem item in listView1.Items
            //                          select (ListViewItem)item.Clone()).ToArray());


   

            //listView2.Hide();

        }

        private void frm_huythuoc_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            //Insert a paragraph at the beginning of the document.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "phiếu hủy hàng";
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();

            try
            {
                Thread.Sleep(8000);  //có vấn đề gio word chưa kích hoạt nên phải đợi để tắt form kích hoạt rồi mới chạy
                                     //Insert a paragraph at the end of the document.
                Word.Paragraph oPara2;
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara2.Range.Text = " phiếu hủy ngày : " + dtp_ngayhuy.Value.ToString("dd/MM/yyyy");
                oPara2.Format.SpaceAfter = 6;
                oPara2.Range.InsertParagraphAfter();

                //Insert another paragraph.
                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);

                cb_nhanvien.ValueMember = "tennv";
                oPara3.Range.Text = "người phụ trách hủy : " + cb_nhanvien.SelectedValue.ToString();
                oPara3.Range.Font.Bold = 0;
                oPara3.Format.SpaceAfter = 24;
                oPara3.Range.InsertParagraphAfter();

                //
                Word.Paragraph oPara4;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);

                cb_nhanvien.ValueMember = "tennv";
                oPara4.Range.Text = " danh sách sản phẩm hủy : ";
                oPara4.Range.Font.Bold = 0;
                oPara4.Format.SpaceAfter = 4;
                oPara4.Range.InsertParagraphAfter();

                //Insert a 3 x 5 table, fill it with data, and make the first row //tạo bảng
                //bold and italic.
                // số dòng
                int row = listView11.Items.Count + 1; // thêm 1 dòng vì tính cả tiêu đề

                Word.Table oTable;
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oTable = oDoc.Tables.Add(wrdRng, row, 7, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                int r, c, i, j;
                string strText;

                string[] ass = { "", "mã thuốc", "lô hàng", "tên thuốc", "id_loại sản phẩm", "ngày nhập", "ngày hết hạn", "số lượng" };
                for (i = 1; i <= (listView11.Items.Count + 1); i++) // thêm 1 giá trị cout vì cần lấy i = 1 là vị trí tiêu đề
                {
                    
                    for (j = 1; j <= 7; j++)
                    {
                        if (i == 1)
                        {
                            strText = ass[j];
                            oTable.Cell(i, j).Range.Text = strText;
                        }
                        else
                        {
                            strText = listView11.Items[i - 2].SubItems[j - 1].Text;  // bắt đầu chạy từ 2 ngưng lấy dữ liệu trong listview vân cần lấy trong từ 0
                            oTable.Cell(i, j).Range.Text = strText;
                        }    
                    }
                }
                oTable.Rows[1].Range.Font.Bold = 1;
                oTable.Rows[1].Range.Font.Italic = 1;


                ///////
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                errorMessage= errorMessage+"có thể gio chưa kích hoạt office (yều cầu thoát thông báo của word thật nhanh";
                MessageBox.Show(errorMessage, "lỗi : ) ");
            }


            this.Close();
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {

            bt_xuat_word.Visible = true;
            label3.Visible = true;
            listView11.Visible = true;
            load_list2();

            bool check = true;
            int vt = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                check = conn.update_huythuoc(listView1.Items[i].SubItems[0].Text); // update

                // dảo ngày
                DateTime ngayhh = DateTime.Parse(listView1.Items[i].SubItems[5].Text);
                String ngayhethan =String.Format("{0:yyyy/MM/dd}", ngayhh);

                if (conn.them_thongkehuy(listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[0].Text, ngayhethan, dtp_ngayhuy.Value.ToString("yyyy/MM/dd"), cb_nhanvien.SelectedValue.ToString(), listView1.Items[i].SubItems[6].Text) == false)
                {
                    check = false;
                }

                if (check == false)
                {
                    vt = i;
                }

            }

            if (check==false)
            {
                MessageBox.Show("hủy thuốc thất bại tại hàng " + (vt-1));
            }
            else
            {
                MessageBox.Show(" hủy thuốc hết hạn thành công ");
                load_lis();
            }
        }

        private void frm_huythuoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frm_huythuoc_FormClosing(object sender, FormClosingEventArgs e)
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
