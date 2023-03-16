using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frm_tracuu_khachhang : Form
    {
        conectdb conn = new conectdb();
        public frm_tracuu_khachhang()
        {
            InitializeComponent();

            cb_ngay.DataSource = conn.load_ngaytao_hoadon();
            cb_ngay.DisplayMember = "ngaytao";

            panel4.Hide(); // lưu 1 số biến khi click vào item trong bảng hóa đơn

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_tracuu_Click(object sender, EventArgs e)
        {
            string giatri = "";
            int a;
            if (ckb_ten.Checked && ckb_sdt.Checked)
            {
                giatri = " and khachhang.ten like '%"+txt_ten.Text+"%'  and khachhang.sdt like  '%"+txt_sdt.Text+"%' ";
                
            }
            else
            {
                if(ckb_ten.Checked)
                {
                    giatri = " and khachhang.ten like '%" + txt_ten.Text + "%' ";
                }
                if(ckb_sdt.Checked)
                {
                    giatri = " and  khachhang.sdt like  '%" + txt_sdt.Text + "%'";
                }
            }
            dgv_load_hoadon.DataSource = conn.tim_hoadonbykhach(giatri);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bt_tim2_Click(object sender, EventArgs e)
        {
            string giatri = "",ngay="";

            if(ckb_mahd.Checked && ckb_time.Checked)
            {
                DateTime ngaynhap = DateTime.Parse(cb_ngay.Text);
                ngay = String.Format("{0:yyyy/MM/dd}", ngaynhap); // đảo vị trí vì sql ko nhân kiểu d/m/y

                giatri = " and hoadon.mahd like '%"+txt_mahd.Text+"%'  and hoadon.ngaytao = '"+ngay+"'";
            }
            else
            {
                if(ckb_mahd.Checked)
                {
                    giatri = " and hoadon.mahd like '%"+txt_mahd.Text+"%'";
                }
                if (ckb_time.Checked)
                {
                    DateTime ngaynhap = DateTime.Parse(cb_ngay.Text);
                    giatri = String.Format("{0:yyyy/MM/dd}", ngaynhap);  // đảo vị trí vì sql ko nhân kiểu d/m/y
                    giatri = " and hoadon.ngaytao = '" + giatri + "'";
                }
            }
            
            dgv_load_hoadon.DataSource = conn.tim_hoadonbykhach(giatri);
        }

        private void dgv_load_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_mahd.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[0].Value.ToString();

            txt_ten.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sdt.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[4].Value.ToString();

            lb_tongtien.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[5].Value.ToString();

            string ngay = String.Format("{0:MM/dd/yyyy}", dgv_load_hoadon.Rows[e.RowIndex].Cells[3].Value);// ngày bị dính giờ
            lb_ngay.Text = ngay;
            lb_khach.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[2].Value.ToString();
            lb_sdt.Text = dgv_load_hoadon.Rows[e.RowIndex].Cells[4].Value.ToString();


            string giatri = " where mahd_hoadon = '"+lb_mahd.Text+"'";
            dgv_load_sphoadon.DataSource = conn.load_sanphamhoadon(giatri);

            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_tracuu_khachhang_Load(object sender, EventArgs e)
        {

        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_xuatWord_Click(object sender, EventArgs e)
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
            oPara1.Range.Text = "hóa đơn mua hàng ngày " + lb_ngay.Text;
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
                oPara2.Range.Text = " mã hóa đơn : " + lb_mahd.Text;
                oPara2.Format.SpaceAfter = 6;
                oPara2.Range.InsertParagraphAfter();

                //Insert another paragraph.
                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);


                oPara3.Range.Text = " tổng tiền thanh toán : " + lb_tongtien.Text;
                oPara3.Range.Font.Bold = 0;
                oPara3.Format.SpaceAfter = 24;
                oPara3.Range.InsertParagraphAfter();

                //
                Word.Paragraph oPara4;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);


                oPara4.Range.Text = " khách hàng : " + lb_khach.Text +" , số điện thoại : " + lb_sdt.Text;
                oPara4.Range.Font.Bold = 0;
                oPara4.Format.SpaceAfter = 4;
                oPara4.Range.InsertParagraphAfter();

                //Insert a 3 x 5 table, fill it with data, and make the first row //tạo bảng
                //bold and italic.
                // số dòng
                int row = dgv_load_sphoadon.RowCount  ; // thêm 1 dòng vì tính cả tiêu đề

                Word.Table oTable;
                Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oTable = oDoc.Tables.Add(wrdRng, row, 7, ref oMissing, ref oMissing);
                oTable.Range.ParagraphFormat.SpaceAfter = 6;
                int r, c, i, j;
                string strText;

                string[] ass = { "", "mã hóa đơn", "mã thuốc", "tên thuốc", "giá", "số lượng" };
                for (i = 1; i <= (row); i++) // thêm 1 giá trị cout vì cần lấy i = 1 là vị trí tiêu đề
                {

                    for (j = 1; j <= 5; j++)
                    {
                        if (i == 1)
                        {
                            strText = ass[j];
                            oTable.Cell(i, j).Range.Text = strText;
                        }
                        else
                        {
                            strText = dgv_load_sphoadon.Rows[i-2].Cells[j-1].Value.ToString();  // bắt đầu chạy từ 2 ngưng lấy dữ liệu trong listview vân cần lấy trong từ 0
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
                errorMessage = errorMessage + "có thể gio chưa kích hoạt office (yều cầu thoát thông báo của word thật nhanh";
                MessageBox.Show(errorMessage, "lỗi : ) ");
            }


            //this.Close();
        }
    }
}
