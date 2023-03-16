using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
//using System.Windows.Forms;


using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace quanlycuahangthuoc
{
    public partial class frm_danhsachsp : Form
    {
        conectdb conn = new conectdb();
        public frm_danhsachsp()
        {
            InitializeComponent();

            bt_update.Enabled = false;

            string giatri = "";
            dgv_sanpham.DataSource = conn.tim_sanpham(giatri);

            cb_lohang.DataSource = conn.Load_lohang();
            cb_lohang.DisplayMember = "ngaynhap";
            

            cb_loaisp.DataSource = conn.Load_loaisp();
            cb_loaisp.DisplayMember = "loai";

            rb_ten.Checked = true;
            cb_loaisp.Visible = false;
            cb_lohang.Visible = false;

            labelay.Hide();

            //dtp_ngayHH.Value = DateTime.Parse("11/2/2020");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_danhsachsp_Load(object sender, EventArgs e)
        {

        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            string giatri = "";

            if(rb_ten.Checked ==true)
            {
                if (txt_tim.Text == "")
                {
                    giatri = "";
                }
                else
                {

                    //label2.Text = new txt_tim.Tex
                    giatri = txt_tim.Text;
                    giatri = " and sanpham.tenthuoc LIKE '%" + giatri + "%' ";
                }
                dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
            }
            else
            {
                if (rb_ma.Checked == true)
                {

                    if (txt_tim.Text == "")
                    {
                        giatri = "";
                    }
                    else
                    {

                        //label2.Text = new txt_tim.Tex
                        giatri = txt_tim.Text;
                        giatri = " and sanpham.mathuoc LIKE '%" + giatri + "%' ";
                    }
                    dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
                }
                else
                {
                    if (rb_lo.Checked == true)
                    {
                        DateTime ngaynhap = DateTime.Parse(cb_lohang.Text);
                        giatri = String.Format("{0:MM/dd/yyyy}", ngaynhap); /// đổi ngượi lại thứ tự vì date trong sql ko nhận chuỗi kiểu dmy,

                        giatri = " and lohang.ngaynhap = '" + giatri + "' ";
                        dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
                    }
                    else
                    {
                        if (rb_loai.Checked == true)
                        {
                            giatri = cb_loaisp.Text;

                            giatri = " and loaisp.loai = '" + giatri + "' ";
                            dgv_sanpham.DataSource = conn.tim_sanpham(giatri);

                        }
                        else
                        {

                            giatri = "";
                            dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
                        }
                    }


                }
            }
        }

        private void rb_lo_CheckedChanged(object sender, EventArgs e)
        {
            cb_lohang.Visible = true;
            txt_tim.Visible = false;

            cb_loaisp.Visible = false;
        }

        private void rb_loai_CheckedChanged(object sender, EventArgs e)
        {
            cb_loaisp.Visible = true;
            txt_tim.Visible = false;

            cb_lohang.Visible = false;
        }

        private void rb_ten_CheckedChanged(object sender, EventArgs e)
        {
            txt_tim.Visible = true;
            cb_loaisp.Visible = false;

            cb_lohang.Visible = false;
        }

        private void rb_ma_CheckedChanged(object sender, EventArgs e)
        {
            txt_tim.Visible = true;
            cb_loaisp.Visible = false;

            cb_lohang.Visible = false;
        }

        private void bt_h_Click(object sender, EventArgs e)
        {
            string giatri = "";
            dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
        }

        private void bt_xuat_ex_Click(object sender, EventArgs e)
        {
            int row = dgv_sanpham.Rows.Count-1;
          
            if(row <=0 )
            {
                MessageBox.Show( "không có sản phẩm nào để in ra ");
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

                label2.Text = dgv_sanpham.Rows[0].Cells[0].Value.ToString();  // test ?

                for (int i = 0; i < row ; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        saNames[i,j]= dgv_sanpham.Rows[i].Cells[j].Value.ToString();
                    }
                }
                //saNames[0, 0] = "John";
                //saNames[0, 1] = "Smith";
                //saNames[0, 2] = "dsdsef";
                //saNames[1, 0] = "tom";
                //saNames[1, 1] = "Brown";
                //saNames[2, 0] = "Sue";
                //saNames[2, 1] = "Thomas";
                //saNames[3, 0] = "Jane";
                //saNames[3, 1] = "Jones";
                //saNames[4, 0] = "Adam";
                //saNames[4, 1] = "Johnson";
                //saNames[5, 0] = "awafwf";
                //saNames[5, 1] = "adwaddwd";

                // A2 : vị trí bắt đầu in I số dòng và chiều rộng in
                oSheet.get_Range("A2", "I"+(row +1)).Value2 = saNames;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_update.Enabled = true;

            label7.Text = "mã sản phẩm đang chọn : " + dgv_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();
            labelay.Text = dgv_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString();

            txt_tenthuoc.Text = dgv_sanpham.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_soluong.Text = dgv_sanpham.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_gia.Text = dgv_sanpham.Rows[e.RowIndex].Cells[8].Value.ToString();

            dtp_ngayHH.Value = DateTime.Parse(dgv_sanpham.Rows[e.RowIndex].Cells[6].Value.ToString());

            cb_loaisp2.DataSource = conn.Load_loaisp();
            cb_loaisp2.DisplayMember = "loai";
            cb_loaisp2.Text = dgv_sanpham.Rows[e.RowIndex].Cells[3].Value.ToString() ;
            //cb_loaisp2.SelectedIndex = 1;
            cb_loaisp2.ValueMember = "id";

        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if(labelay.Text=="label7")
            {
                MessageBox.Show(" bạn chưa chọn sản phẩm để update ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txt_tenthuoc.BackColor = Color.White;
            txt_soluong.BackColor = Color.White;
            txt_gia.BackColor = Color.White;

            DialogResult dl = MessageBox.Show("bạn muốn cập nhật thuốc " + label7.Text , "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(txt_tenthuoc.Text))
                {
                    MessageBox.Show(" bạn không được để trống ô tên sản phẩm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tenthuoc.BackColor = Color.Red;
                    //txt_tenthuoc.ForeColor = Color.Red; // mầu chữ

                    return;
                }
                int asss;
                if(int.TryParse(txt_soluong.Text ,out asss) ==false || string.IsNullOrEmpty(txt_soluong.Text))
                {
                    MessageBox.Show(" nhập sai kiểu dữ liệu trong ô số lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_soluong.BackColor = Color.Red;
                    //txt_tenthuoc.ForeColor = Color.Red; // mầu chữ

                    return;
                }
                if (int.TryParse(txt_gia.Text, out asss) == false || string.IsNullOrEmpty(txt_gia.Text))
                {
                    MessageBox.Show(" nhập sai kiểu dữ liệu trong ô giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_gia.BackColor = Color.Red;
                    //txt_tenthuoc.ForeColor = Color.Red; // mầu chữ

                    return;
                }

                if (conn.upate_sanpham( labelay.Text, txt_tenthuoc.Text, cb_loaisp2.SelectedValue.ToString(), dtp_ngayHH.Value.ToString("yyyy/MM/dd"), txt_soluong.Text, txt_gia.Text) == true)
                {
                    MessageBox.Show("cập nhật thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string giatri = "";
                    dgv_sanpham.DataSource = conn.tim_sanpham(giatri);
                }
                else
                {
                    MessageBox.Show("cập nhât không thành công " , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            
        }

        private void frm_danhsachsp_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void frm_danhsachsp_FormClosing(object sender, FormClosingEventArgs e)
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
