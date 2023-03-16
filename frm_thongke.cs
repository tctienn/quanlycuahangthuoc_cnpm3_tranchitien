using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

using System.Reflection;

namespace quanlycuahangthuoc
{
    public partial class frm_thongke : Form
    {
        conectdb conn = new conectdb();
        public frm_thongke()
        {
            InitializeComponent();

            cb_lo.Visible = false;

            cb_nam.DataSource = conn.load_nam_hoadon();
            cb_nam.DisplayMember = "nam";

            bt_excel1.Enabled = false;
            bt_excel2.Enabled = false;
            bt_excel3.Enabled = false;


        }

        private void bt_thongke_sp_Click(object sender, EventArgs e)
        {
            string giatri = "";

            bt_excel1.Enabled = true;
            bt_excel2.Enabled = false;
            bt_excel3.Enabled = false;

            if (rb_hon4t.Checked)
            {
                giatri = "  and DATEDIFF(MONTH, GETDATE(), sanpham.ngayhethan ) > 4  ";
            }
            else
            {
                if(rb_han24t.Checked)
                {
                    giatri = " and  DATEDIFF(MONTH, GETDATE(), sanpham.ngayhethan ) >=2 and  DATEDIFF(MONTH, GETDATE(), sanpham.ngayhethan ) <=4 ";
                }
                else
                {
                    if(rb_lo.Checked)
                    {
                        DateTime lo = DateTime.Parse(cb_lo.Text);
                        giatri = String.Format("{0:MM/dd/yyyy}", lo); /// đổi ngượi lại thứ tự vì date trong sql ko nhận chuỗi kiểu dmy,

                        giatri = " and lohang.ngaynhap = '" + giatri + "' ";
                    }
                }
            }

            dgv_load.DataSource = conn.tim_sanpham(giatri);
        }

        private void rb_lo_CheckedChanged(object sender, EventArgs e)
        {

            cb_lo.Visible = true;
            cb_lo.DataSource = conn.Load_lohang();
            cb_lo.DisplayMember = "ngaynhap";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_excel1_Click(object sender, EventArgs e)
        {
            int row = dgv_load.Rows.Count - 1;

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
                oSheet.Cells[1, 1] = "mã thuốc";
                oSheet.Cells[1, 2] = "lô";
                oSheet.Cells[1, 3] = "tên thuốc";
                oSheet.Cells[1, 4] = "loại";
                oSheet.Cells[1, 5] = "ngày nhập";
                oSheet.Cells[1, 6] = "nhân viên nhập";
                oSheet.Cells[1, 7] = "ngày hết hạn";
                oSheet.Cells[1, 8] = "số lượng";

                oSheet.Cells[1, 9] = "giá";


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "I1").Font.Bold = true;
                oSheet.get_Range("A1", "I1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[row, 9];

                //label2.Text = dgv_sanpham.Rows[0].Cells[0].Value.ToString();  // test ?

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if( j==1 || j==4 || j==6)
                        {
                            DateTime dts = DateTime.Parse(dgv_load.Rows[i].Cells[j].Value.ToString());  // bỏ phần giờ bị lỗi trong sql
                            saNames[i, j] = String.Format("{0:d}", dts);
                        }
                        else
                            saNames[i, j] = dgv_load.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // A2 : vị trí bắt đầu in I số dòng và chiều rộng in
                oSheet.get_Range("A2", "I" + (row + 1)).Value2 = saNames;
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

        private void bt_thongkehd_Click(object sender, EventArgs e)
        {

            bt_excel1.Enabled = false;
            bt_excel2.Enabled = true;
            bt_excel3.Enabled = false;

            string giatri = " where year(ngaytao) = " + cb_nam.Text;
            dgv_load.DataSource = conn.tim_hoadon(giatri);
        }

        private void bt_excel2_Click(object sender, EventArgs e)
        {
            int row = dgv_load.Rows.Count - 1;

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
                oSheet.Cells[1, 1] = "mã hóa đơn";
                oSheet.Cells[1, 2] = "id khách hàng";
                oSheet.Cells[1, 3] = "ngày tạo";
                oSheet.Cells[1, 4] = "nhân viên";
                oSheet.Cells[1, 5] = "tổng tiền";

          


                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "E1").Font.Bold = true;
                oSheet.get_Range("A1", "E1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[row, 9];

                //label2.Text = dgv_sanpham.Rows[0].Cells[0].Value.ToString();  // test ?

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 2 )
                        {
                            DateTime dts = DateTime.Parse(dgv_load.Rows[i].Cells[j].Value.ToString());  // bỏ phần giờ bị lỗi trong sql
                            saNames[i, j] = String.Format("{0:d}", dts);
                        }
                        else
                            saNames[i, j] = dgv_load.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // A2 : vị trí bắt đầu in I số dòng và chiều rộng in
                oSheet.get_Range("A2", "E" + (row + 1)).Value2 = saNames;
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

        private void bt_thongkenv_Click(object sender, EventArgs e)
        {
            bt_excel1.Enabled = false;
            bt_excel2.Enabled = false;
            bt_excel3.Enabled = true;
            dgv_load.DataSource = conn.Load_nhanvien_on();
        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            int row = dgv_load.Rows.Count - 1;

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
                oSheet.Cells[1, 1] = "mã nhân viên";
                oSheet.Cells[1, 2] = "tên nhân viên";
                oSheet.Cells[1, 3] = "địa chỉ";
                oSheet.Cells[1, 4] = "giới tính";
                oSheet.Cells[1, 5] = "số điện thoại";
                oSheet.Cells[1, 6] = "năm sinh";
                oSheet.Cells[1, 7] = "trạng thái";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "G1").Font.Bold = true;
                oSheet.get_Range("A1", "G1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[,] saNames = new string[row, 9];

                //label2.Text = dgv_sanpham.Rows[0].Cells[0].Value.ToString();  // test ?

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (j == 6)
                        {

                            saNames[i, j] = "đang làm";
                        }
                        else
                            saNames[i, j] = dgv_load.Rows[i].Cells[j].Value.ToString();
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
    }
}
