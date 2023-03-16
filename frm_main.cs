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
    public partial class frm_main : Form
    {
        private string nameuser;
        private string capst;
        // biến dùng trong drawer
        int panelWidth;
        bool Hidden;

        public frm_main()
        {
            InitializeComponent();

            panel1.BringToFront();
            //drawer
            panelWidth = panel1.Width;
            Hidden = false;
            bt_nhanvien.Enabled = false;
            ql_tk.Enabled = false;
        }
        public frm_main(string name,string cap) : this()
        {
            nameuser = name;
            capst = cap;
            
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            

            if(Convert.ToInt32(capst) ==1)
            {
                bt_nhanvien.Enabled = true;
                ql_tk.Enabled = true;
            }

            lb_name.Text = nameuser ;

        }

        private void nhậpSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_themsp themsp = new frm_themsp();
            themsp.ShowDialog();

           
            //ẩn form
            //this.Hide();
        }

        private void sấToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.WindowState = for
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nhanvien = new frm_nhanvien();
            nhanvien.ShowDialog();
            
        }

        private void bt_huythuoc_Click(object sender, EventArgs e)
        {
            frm_huythuoc huythuoc = new frm_huythuoc();
            huythuoc.ShowDialog();
            //this.Hide();
        }

        private void demo_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
        }

        private void bt_dssp_Click(object sender, EventArgs e)
        {
            frm_danhsachsp sp = new frm_danhsachsp();
            sp.ShowDialog();
            //this.Hide();
        }

        private void tracuu_huy_Click(object sender, EventArgs e)
        {
            frm_tracuu_huy tracuu_huy = new frm_tracuu_huy();
            tracuu_huy.ShowDialog();
            
        }

        private void bt_hoadon_Click(object sender, EventArgs e)
        {
            frm_hoadon hoadon = new frm_hoadon();
            hoadon.ShowDialog();
            
        }

        private void bt_bieudo_Click(object sender, EventArgs e)
        {
            frm_bieudo bieudo = new frm_bieudo();
            bieudo.ShowDialog();

        }

        private void ql_tk_Click(object sender, EventArgs e)
        {
            frm_ql_taikhoan taikhoan = new frm_ql_taikhoan();
            taikhoan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel1.Width = panel1.Width + 20;
                if (panel1.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width -= 20;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    //this.Refresh();
                }
            }
        }

        private void bt_tracuu_hd_kh_Click(object sender, EventArgs e)
        {
            frm_tracuu_khachhang trkhach = new frm_tracuu_khachhang();
            trkhach.ShowDialog();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            frm_thongke fthongke = new frm_thongke();
            fthongke.ShowDialog();
        }

        private void bt_nhap_Click(object sender, EventArgs e)
        {
            frm_themsp fthemsp = new frm_themsp();
            fthemsp.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
