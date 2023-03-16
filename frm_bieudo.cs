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

using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;

namespace quanlycuahangthuoc
{
    public partial class frm_bieudo : Form
    {
        conectdb conn = new conectdb();
        public frm_bieudo()
        {
            InitializeComponent();
            cb_nam.DataSource = conn.load_nam_hoadon();
            cb_nam.DisplayMember = "nam";

            c_tongtien.Titles.Add("biểu đồ doanh thu từ hóa đơn bán hàng theo năm");

            c_sanpham_ghh.Titles.Add("biểu đồ danh sách sản phẩm tồn(gần hết hạn), cận hạn ");
            load_char_tron();

            dgv_nhohon2.DataSource = conn.load_thuoc_shh();

            //label1.Text = conn.tong_sp();
        }

        private void load_char_tron() // load biểu đồ tròn
        {
            
            string[] a = { "", " khoản : 2-4 tháng", " dưới 2 tháng", "trên 4 tháng" };
            string giatri = "";
            double soluong = 0;
            c_sanpham_ghh.ChartAreas[0].AxisY.Maximum = (40); // chiều cao tối đa trục y
            c_sanpham_ghh.Series.Clear();

            Series s = new Series();

            for (int i = 1; i <= 3; i++)
            {
                if (i == 1)
                {
                    giatri = " and  DATEDIFF(MONTH, GETDATE(), ngayhethan ) >=2 and  DATEDIFF(MONTH, GETDATE(), ngayhethan ) <=4 ";
                }
                else
                {
                    if (i == 2)
                    {
                        giatri = " and  DATEDIFF(MONTH, GETDATE(), ngayhethan ) < 2  ";
                    }
                    else
                        giatri = "and  DATEDIFF(MONTH, GETDATE(), ngayhethan ) > 4 ";
                }
                foreach (DataRow value in conn.load_thoc_ganhh(giatri).Rows)  // chỉ ra 1 kết quả duy nhất ko phải lo (xem lại phương pháp lấy 1 dòng dữ liệu trong database)
                {
                    double.TryParse(value["soluong"].ToString(), out soluong);
                }
                if (soluong == 0)
                    continue;
                DataPoint p = new DataPoint();
                p.XValue = i;  // số lượng cột , vị trí cột
                p.SetValueY(soluong); /// chiều cao phần tử so với y
                p.AxisLabel = a[i] + ": " + soluong + "sp"; // tên cột theo xvalue
                s.Points.Add(p);


            }
            c_sanpham_ghh.Series.Add(s);
            c_sanpham_ghh.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void frm_bieudo_Load(object sender, EventArgs e)
        {
            //demo
            
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[0].HeaderCell.Value = "Năm 2012";
            //dataGridView1.Rows[0].Cells[0].Value = 4;
            //dataGridView1.Rows[0].Cells[1].Value = 8;
            //dataGridView1.Rows[0].Cells[2].Value = 3;
            //dataGridView1.Rows[0].Cells[3].Value = 4;
            //dataGridView1.Rows[0].Cells[4].Value = 9;
            //dataGridView1.Rows[0].Cells[5].Value = 5;

            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[1].HeaderCell.Value = "Năm 2013";
            //dataGridView1.Rows[1].Cells[0].Value = 8;
            //dataGridView1.Rows[1].Cells[1].Value = 12;
            //dataGridView1.Rows[1].Cells[2].Value = 3;
            //dataGridView1.Rows[1].Cells[3].Value = 9;
            //dataGridView1.Rows[1].Cells[4].Value = 7;
            //dataGridView1.Rows[1].Cells[5].Value = 43;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)// phần demo
        {
            

            ////Tìm và đặt giá trị MAX cho trục Y
            //int max = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //for (int i = 1; i < 6; i++)
            //    if (max < Convert.ToInt32(dataGridView1.CurrentRow.Cells[i].Value))
            //        max = Convert.ToInt32(dataGridView1.CurrentRow.Cells[i].Value);
            //if (chart1.ChartAreas[0].AxisY.Maximum < max) chart1.ChartAreas[0].AxisY.Maximum = max;

            //chart1.Series.Clear();
            //for (int n = 0; n < dataGridView1.Rows.Count; n++) //Duyệt từ dòng đầu tiên đến dòng cuối cùng của dataGridView1
            //{
            //    if (dataGridView1.Rows[n].Selected) //Nếu dòng thứ n được chọn thì thêm series cho dòng đó
            //    {
            //        Series s = new Series();
            //        for (int i = 0; i < 6; i++)
            //        {
            //            DataPoint p = new DataPoint();
            //            p.XValue = i;
            //            p.SetValueY(Convert.ToDouble(dataGridView1.Rows[n].Cells[i].Value));
            //            p.AxisLabel = "Tháng " + (i + 1).ToString();
            //            s.Points.Add(p);
            //        }
            //        chart1.Series.Add(s);
            //    }
            //}

        }

        private void bt_hien_Click(object sender, EventArgs e)
        {
            string giatri = "";
            if(cb_nam.Text != "")
            {
                giatri = " where year(ngaytao) = "+ cb_nam.Text;
               dgv_hoadon.DataSource = conn.tim_hoadon(giatri);

       /////////////////// biểu đồ
                //lấy tổng lớn nhất trong năm
                double max_tong =0;
                foreach (DataRow value in conn.load_tong(giatri).Rows)  // chỉ ra 1 kết quả duy nhất ko phải lo (xem lại phương pháp lấy 1 dòng dữ liệu trong database)
                {
                    double.TryParse(value["tong"].ToString(), out max_tong);
                }
                double tong_thang = 0;

                


                c_tongtien.ChartAreas[0].AxisY.Maximum = (max_tong +1000); // chiều cao tối đa trục y
                c_tongtien.Series.Clear();

                Series s = new Series("doanh thu");
               
                for (int i = 1; i <= 12; i++)
                {
                    // lệnh truy vấn sql theo tháng
                    giatri = " where MONTH(ngaytao) = " + i + " and year(ngaytao) = " + Convert.ToInt32(cb_nam.Text);
                    //lấy tổng tiền cả tháng đó
                    foreach (DataRow value in conn.load_tong(giatri).Rows)  // chỉ ra 1 kết quả duy nhất ko phải lo (xem lại phương pháp lấy 1 dòng dữ liệu trong database)
                    {
                        double.TryParse(value["tong"].ToString(), out tong_thang);
                    }


                    DataPoint p = new DataPoint();
                    p.XValue = i;  // số lượng cột , vị trí cột
                    p.SetValueY(tong_thang); /// chiều cao phần tử so với y
                    p.AxisLabel = "Tháng " + (i ).ToString(); // tên cột theo xvalue
                    s.Points.Add(p);

                   
                }
                c_tongtien.Series.Add(s);

                //c_tongtien.Series[0].ChartType = SeriesChartType.Pie;  // chuyển sang biểu đồ hình tròn
            }
        }

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_xuat_word_Click(object sender, EventArgs e)
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
            oPara1.Range.Text = "danh sách hóa đơn";
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
                oPara2.Range.Text = " danh sách hóa đơn trong năm : " + cb_nam.Text;
                oPara2.Format.SpaceAfter = 6;
                oPara2.Range.InsertParagraphAfter();

                //Insert another paragraph.
                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);


                //oPara3.Range.Text = "người phụ trách hủy : " + cb_nhanvien.SelectedValue.ToString();
                //oPara3.Range.Font.Bold = 0;
                //oPara3.Format.SpaceAfter = 24;
                //oPara3.Range.InsertParagraphAfter();

                //
                //Word.Paragraph oPara4;
                //oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                //oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);

                //cb_nhanvien.ValueMember = "tennv";
                //oPara4.Range.Text = " danh sách sản phẩm hủy : ";
                //oPara4.Range.Font.Bold = 0;
                //oPara4.Format.SpaceAfter = 4;
                //oPara4.Range.InsertParagraphAfter();

                //tạo bảng
                //bold and italic.
                // số dòng
                int row = dgv_hoadon.Rows.Count ;

                Word.Table oTable;
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oTable = oDoc.Tables.Add(wrdRng, row, 5, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                int r, c, i, j;
                string strText;

                string[] ass = {  "","mã hóa đơn ","id khách hàng", "ngày tạo", "nhân viên thanh toán", "tổng tiền" };
                for (i = 1; i <= row; i++)
                {
                    
                    for (j = 1; j <= 5; j++)
                    {
                        if (i == 1)
                        {
                            strText = ass[j];
                        }
                        else
                        {
                            if(j==3)
                            {
                               
                                DateTime ngays= DateTime.Parse(dgv_hoadon.Rows[i - 2].Cells[j - 1].Value.ToString());  // datagriview bị dính giờ
                                strText = String.Format("{0:dd/MM/yyyy}", ngays);
                            }
                            else
                                strText = dgv_hoadon.Rows[i - 2].Cells[j - 1].Value.ToString();
                        }
                        oTable.Cell(i, j).Range.Text = strText;
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
                errorMessage = errorMessage + "có thể gio chưa kích hoạt office (yều cầu thoát thông báo của word thật nhanh";
                MessageBox.Show(errorMessage, "lỗi : ) ");
            }


            //this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void c_sanpham_ghh_Click(object sender, EventArgs e)
        {
          
           
        }

        private void bt_bo_Click(object sender, EventArgs e)
        {
            if(dgv_nhohon2.Rows.Count <=1  )
            {
                MessageBox.Show("không có  gì để xóa ở đây cả");
                return;
            }

            for (int i=0; i< (dgv_nhohon2.Rows.Count-1);i++ )
            {
                if(conn.update_huythuoc(dgv_nhohon2.Rows[i].Cells[0].Value.ToString())==false)
                {
                    MessageBox.Show("hủy thuốc thất bại ");
                    dgv_nhohon2.DataSource = conn.load_thuoc_shh();
                    return;
                }
            }

            MessageBox.Show("hủy thành công nhũng mã thuốc có hạn nhỏ hơn 2 tháng");
            dgv_nhohon2.DataSource = conn.load_thuoc_shh();
            
            load_char_tron();
            
        }
    }
}
