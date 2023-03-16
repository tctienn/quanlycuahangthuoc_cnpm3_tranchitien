
namespace quanlycuahangthuoc
{
    partial class frm_hoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hoadon));
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.bt_tim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_dsmua = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.bt_thanhtoan = new System.Windows.Forms.Button();
            this.lb_tong = new System.Windows.Forms.Label();
            this.bt_new_hoadon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tsp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_them = new System.Windows.Forms.Button();
            this.nb_soluong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_gia1 = new System.Windows.Forms.Label();
            this.lb_kho = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_masanpham = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.lv_dathanhtoan = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_nguoimua = new System.Windows.Forms.Label();
            this.lb_sdt_nguoimua = new System.Windows.Forms.Label();
            this.lb_tien_dathanhtoan = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_soluong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(120, 35);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(221, 22);
            this.txt_tenkhachhang.TabIndex = 1;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.printPreviewDialog1_FormClosing);
            this.printPreviewDialog1.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.printPreviewDialog1_FormClosed);
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // bt_in
            // 
            this.bt_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_in.Image = global::quanlycuahangthuoc.Properties.Resources.icons8_printer_64;
            this.bt_in.Location = new System.Drawing.Point(1172, 31);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(121, 51);
            this.bt_in.TabIndex = 0;
            this.bt_in.Text = "in";
            this.bt_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(350, 108);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(127, 31);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(195, 105);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(121, 24);
            this.cb_nhanvien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "tổng tiền : ";
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(203, 171);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.RowTemplate.Height = 24;
            this.dgv_sanpham.Size = new System.Drawing.Size(694, 438);
            this.dgv_sanpham.TabIndex = 2;
            this.dgv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentClick);
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(120, 83);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(221, 22);
            this.txt_sodienthoai.TabIndex = 2;
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(454, 130);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(158, 23);
            this.bt_tim.TabIndex = 3;
            this.bt_tim.Text = "tìm tên sản phẩm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "tên người mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "nhân viên thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "số điện thoại";
            // 
            // lv_dsmua
            // 
            this.lv_dsmua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_dsmua.HideSelection = false;
            this.lv_dsmua.Location = new System.Drawing.Point(46, 156);
            this.lv_dsmua.Name = "lv_dsmua";
            this.lv_dsmua.Size = new System.Drawing.Size(428, 215);
            this.lv_dsmua.TabIndex = 6;
            this.lv_dsmua.UseCompatibleStateImageBehavior = false;
            this.lv_dsmua.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "mã thuốc";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "tên thuốc";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "giá";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "kho";
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(302, 130);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(121, 22);
            this.txt_tim.TabIndex = 1;
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Location = new System.Drawing.Point(154, 428);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(220, 64);
            this.bt_thanhtoan.TabIndex = 3;
            this.bt_thanhtoan.Text = "xác nhận thanh toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.ForeColor = System.Drawing.Color.Red;
            this.lb_tong.Location = new System.Drawing.Point(461, 389);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(16, 17);
            this.lb_tong.TabIndex = 5;
            this.lb_tong.Text = "0";
            // 
            // bt_new_hoadon
            // 
            this.bt_new_hoadon.Location = new System.Drawing.Point(350, 40);
            this.bt_new_hoadon.Name = "bt_new_hoadon";
            this.bt_new_hoadon.Size = new System.Drawing.Size(127, 42);
            this.bt_new_hoadon.TabIndex = 3;
            this.bt_new_hoadon.Text = "tạo mới hóa đơn";
            this.bt_new_hoadon.UseVisualStyleBackColor = true;
            this.bt_new_hoadon.Click += new System.EventHandler(this.bt_new_hoadon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "tên sản phẩm";
            // 
            // lb_tsp
            // 
            this.lb_tsp.AutoSize = true;
            this.lb_tsp.Location = new System.Drawing.Point(121, 48);
            this.lb_tsp.Name = "lb_tsp";
            this.lb_tsp.Size = new System.Drawing.Size(30, 17);
            this.lb_tsp.TabIndex = 5;
            this.lb_tsp.Text = "null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "số lượng";
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(60, 141);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(177, 53);
            this.tb_them.TabIndex = 3;
            this.tb_them.Text = "thêm vào danh sách mua";
            this.tb_them.UseVisualStyleBackColor = true;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // nb_soluong
            // 
            this.nb_soluong.Location = new System.Drawing.Point(124, 78);
            this.nb_soluong.Name = "nb_soluong";
            this.nb_soluong.Size = new System.Drawing.Size(48, 22);
            this.nb_soluong.TabIndex = 7;
            this.nb_soluong.ValueChanged += new System.EventHandler(this.nb_soluong_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "giá";
            // 
            // lb_gia1
            // 
            this.lb_gia1.AutoSize = true;
            this.lb_gia1.Location = new System.Drawing.Point(121, 121);
            this.lb_gia1.Name = "lb_gia1";
            this.lb_gia1.Size = new System.Drawing.Size(16, 17);
            this.lb_gia1.TabIndex = 5;
            this.lb_gia1.Text = "0";
            // 
            // lb_kho
            // 
            this.lb_kho.AutoSize = true;
            this.lb_kho.Location = new System.Drawing.Point(235, 82);
            this.lb_kho.Name = "lb_kho";
            this.lb_kho.Size = new System.Drawing.Size(16, 17);
            this.lb_kho.TabIndex = 5;
            this.lb_kho.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "kho :";
            // 
            // lb_masanpham
            // 
            this.lb_masanpham.AutoSize = true;
            this.lb_masanpham.Location = new System.Drawing.Point(121, 28);
            this.lb_masanpham.Name = "lb_masanpham";
            this.lb_masanpham.Size = new System.Drawing.Size(20, 17);
            this.lb_masanpham.TabIndex = 5;
            this.lb_masanpham.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "mã hóa đơn :";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Location = new System.Drawing.Point(1189, 12);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngay.TabIndex = 8;
            // 
            // lv_dathanhtoan
            // 
            this.lv_dathanhtoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_dathanhtoan.HideSelection = false;
            this.lv_dathanhtoan.Location = new System.Drawing.Point(110, 31);
            this.lv_dathanhtoan.Name = "lv_dathanhtoan";
            this.lv_dathanhtoan.Size = new System.Drawing.Size(1025, 224);
            this.lv_dathanhtoan.TabIndex = 6;
            this.lv_dathanhtoan.UseCompatibleStateImageBehavior = false;
            this.lv_dathanhtoan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "mã thuốc";
            this.columnHeader6.Width = 131;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "tên thuốc";
            this.columnHeader7.Width = 119;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "số lượng";
            this.columnHeader8.Width = 102;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "giá";
            this.columnHeader9.Width = 91;
            // 
            // lb_nguoimua
            // 
            this.lb_nguoimua.AutoSize = true;
            this.lb_nguoimua.Location = new System.Drawing.Point(1269, 130);
            this.lb_nguoimua.Name = "lb_nguoimua";
            this.lb_nguoimua.Size = new System.Drawing.Size(74, 17);
            this.lb_nguoimua.TabIndex = 9;
            this.lb_nguoimua.Text = "người mua";
            // 
            // lb_sdt_nguoimua
            // 
            this.lb_sdt_nguoimua.AutoSize = true;
            this.lb_sdt_nguoimua.Location = new System.Drawing.Point(1269, 173);
            this.lb_sdt_nguoimua.Name = "lb_sdt_nguoimua";
            this.lb_sdt_nguoimua.Size = new System.Drawing.Size(27, 17);
            this.lb_sdt_nguoimua.TabIndex = 9;
            this.lb_sdt_nguoimua.Text = "sdt";
            // 
            // lb_tien_dathanhtoan
            // 
            this.lb_tien_dathanhtoan.AutoSize = true;
            this.lb_tien_dathanhtoan.Location = new System.Drawing.Point(1269, 210);
            this.lb_tien_dathanhtoan.Name = "lb_tien_dathanhtoan";
            this.lb_tien_dathanhtoan.Size = new System.Drawing.Size(16, 17);
            this.lb_tien_dathanhtoan.TabIndex = 9;
            this.lb_tien_dathanhtoan.Text = "0";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "tên sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.lb_masanpham);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_kho);
            this.groupBox1.Controls.Add(this.nb_soluong);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_gia1);
            this.groupBox1.Controls.Add(this.lb_tsp);
            this.groupBox1.Controls.Add(this.tb_them);
            this.groupBox1.Location = new System.Drawing.Point(903, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 216);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sản phẩm thanh toán";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.cb_nhanvien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_tong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lv_dsmua);
            this.groupBox2.Controls.Add(this.bt_thanhtoan);
            this.groupBox2.Controls.Add(this.bt_new_hoadon);
            this.groupBox2.Location = new System.Drawing.Point(1270, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 502);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sản phẩm chờ thanh toán";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.txt_tenkhachhang);
            this.groupBox3.Controls.Add(this.txt_sodienthoai);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(903, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 126);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "thông tin khách hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lv_dathanhtoan);
            this.groupBox4.Controls.Add(this.lb_nguoimua);
            this.groupBox4.Controls.Add(this.lb_tien_dathanhtoan);
            this.groupBox4.Controls.Add(this.lb_sdt_nguoimua);
            this.groupBox4.Controls.Add(this.bt_in);
            this.groupBox4.Location = new System.Drawing.Point(203, 668);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1502, 326);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "hóa đơn vừa được thanh toán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1169, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "người mua : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1169, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "số điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1169, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "tổng tiền";
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_ngay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.txt_tim);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_hoadon";
            this.Text = "thanh toán hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_soluong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_dsmua;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button bt_thanhtoan;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Button bt_new_hoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_tsp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.NumericUpDown nb_soluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_gia1;
        private System.Windows.Forms.Label lb_kho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_masanpham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lv_dathanhtoan;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lb_nguoimua;
        private System.Windows.Forms.Label lb_sdt_nguoimua;
        private System.Windows.Forms.Label lb_tien_dathanhtoan;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}