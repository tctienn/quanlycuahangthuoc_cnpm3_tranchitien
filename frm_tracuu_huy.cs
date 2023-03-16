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
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace quanlycuahangthuoc
{
    public partial class frm_tracuu_huy : Form
    {
        conectdb conn = new conectdb();
        public frm_tracuu_huy()
        {
            InitializeComponent();

            cb_lo.DataSource = conn.Load_lohang();
            cb_lo.DisplayMember = "ngaynhap";
            //cb_lo.ValueMember = "lo";

            string ay = "";
            cb_ngayhuy.DataSource = conn.tim_thongkehuy(ay);
            cb_ngayhuy.DisplayMember = "ngayhuy";

            string giatri = "";
            dgv_thongkehuy.DataSource = conn.tim_thongkehuy(" ");

            rb_sophieu.Checked = true;
            txt_sophieu.Visible = true;
            cb_lo.Visible = false;
            cb_ngayhuy.Visible = false;
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string giatri = " ";
            if(rb_sophieu.Checked == true)
            {
                
                giatri = " and thongkehuy.sophieu = " + txt_sophieu.Text ;

                if (string.IsNullOrEmpty(txt_sophieu.Text) == true)
                    giatri = "";
                dgv_thongkehuy.DataSource = conn.tim_thongkehuy(giatri);
            }
            else
            {
                if(rb_lo.Checked == true)
                {
                    

                    DateTime ngaynhap = DateTime.Parse(cb_lo.Text);
                    giatri = String.Format("{0:yyyy/MM/dd}", ngaynhap);  // đảo vị trí vì sql ko nhân kiểu d/m/y
                    //giatri = " and lohang.ngaynhap = '" + giatri + " '";
                    giatri = "and lohang.ngaynhap = ' "+ giatri + " ' ";

                    dgv_thongkehuy.DataSource = conn.tim_thongkehuy(giatri);

                }
                else
                {
                    

                    DateTime ngayhuy = DateTime.Parse(cb_ngayhuy.Text);
                    giatri = String.Format("{0:yyyy/MM/dd}", ngayhuy); 
                    rb_lo.Text = giatri;
                    giatri = "and thongkehuy.ngayhuy = ' " + giatri + " ' ";

                    dgv_thongkehuy.DataSource = conn.tim_thongkehuy(giatri);
                }
            }
        }

        private void rb_sophieu_CheckedChanged(object sender, EventArgs e)
        {
            txt_sophieu.Visible = true;
            cb_lo.Visible = false;
            cb_ngayhuy.Visible = false;
        }

        private void rb_lo_CheckedChanged(object sender, EventArgs e)
        {
            cb_lo.Visible = true;
            txt_sophieu.Visible = false;
            cb_ngayhuy.Visible = false;
        }

        private void rb_ngayhuy_CheckedChanged(object sender, EventArgs e)
        {
            cb_ngayhuy.Visible = true;
            txt_sophieu.Visible = false;
            cb_lo.Visible = false;
        }

        private void bt_xuat_excel_Click(object sender, EventArgs e)
        {
            int row = dgv_thongkehuy.Rows.Count - 1; // bỏ tiêu đề 
            if(row==0)
            {
                MessageBox.Show("không có gì để in ra "); return;
            }

            if (row <= 0)
            {
                MessageBox.Show("không có sản phẩm nào để in ra ");
                return;
            }

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                Thread.Sleep(8000);  ///  thoát form thông báo của form exel trước khi lỗi xảy ra ( cái này gio chưa kích hoạt office )
                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "số phiếu hủy";
                oSheet.Cells[1, 2] = "lô hàng";
                oSheet.Cells[1, 3] = "mã sản phẩm";
                oSheet.Cells[1, 4] = "ngày hết hạn";
                oSheet.Cells[1, 5] = "ngày hủy";
                oSheet.Cells[1, 6] = "mã nhân viên hủy";
                oSheet.Cells[1, 7] = "số lượng hủy";

                


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "G1").Font.Bold = true;
                oSheet.get_Range("A1", "G1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[row, 7];

                //label2.Text = dgv_sanpham.Rows[0].Cells[0].Value.ToString();

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if( j==1 || j== 3 || j==4)
                        {
                            DateTime dts = DateTime.Parse(dgv_thongkehuy.Rows[i].Cells[j].Value.ToString());  // bỏ phần giờ bị lỗi trong sql
                            saNames[i, j] = String.Format("{0:d}", dts);
                        }
                        else
                        saNames[i, j] = dgv_thongkehuy.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // A2 : vị trí bắt đầu in I số dòng và chiều rộng in
                oSheet.get_Range("A2", "G" + (row + 1)).Value2 = saNames;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                errorMessage = errorMessage + "có thể gio chưa kích hoạt office (yều cầu thoát thông báo của excel thật nhanh)";
                MessageBox.Show(errorMessage, "lỗi :  ");
            }
        }

        private void frm_tracuu_huy_Load(object sender, EventArgs e)
        {

        }
    }
}
