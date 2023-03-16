
namespace quanlycuahangthuoc
{
    partial class frm_themsp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_tenthuoc = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.lo = new System.Windows.Forms.Label();
            this.tenthuoc = new System.Windows.Forms.Label();
            this.ngayhethan = new System.Windows.Forms.Label();
            this.nhanvien = new System.Windows.Forms.Label();
            this.ngaynhap = new System.Windows.Forms.Label();
            this.nhacungcap = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.gia = new System.Windows.Forms.Label();
            this.cb_lohang = new System.Windows.Forms.ComboBox();
            this.cb_loaisp = new System.Windows.Forms.ComboBox();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.bt_them = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.xoa2 = new System.Windows.Forms.Button();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngayhethan = new System.Windows.Forms.DateTimePicker();
            this.txt_nhacungcap = new System.Windows.Forms.TextBox();
            this.cb_nhanvien2 = new System.Windows.Forms.ComboBox();
            this.lbo2 = new System.Windows.Forms.Label();
            this.lbo3 = new System.Windows.Forms.Label();
            this.dtp_taolo = new System.Windows.Forms.DateTimePicker();
            this.bt_taolo = new System.Windows.Forms.Button();
            this.lbonew = new System.Windows.Forms.Label();
            this.bt_dslo = new System.Windows.Forms.Button();
            this.dgv_dslo = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_taoloaisp = new System.Windows.Forms.Button();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xoaloai = new System.Windows.Forms.Button();
            this.bt_sualoai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Location = new System.Drawing.Point(164, 69);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.Size = new System.Drawing.Size(168, 22);
            this.txt_tenthuoc.TabIndex = 0;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(566, 75);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(148, 22);
            this.txt_soluong.TabIndex = 0;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(566, 117);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(148, 22);
            this.txt_gia.TabIndex = 0;
            this.txt_gia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(494, 493);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.RowTemplate.Height = 24;
            this.dgv_sanpham.Size = new System.Drawing.Size(1475, 445);
            this.dgv_sanpham.TabIndex = 1;
            // 
            // lo
            // 
            this.lo.AutoSize = true;
            this.lo.Location = new System.Drawing.Point(12, 30);
            this.lo.Name = "lo";
            this.lo.Size = new System.Drawing.Size(55, 17);
            this.lo.TabIndex = 2;
            this.lo.Text = "lô hàng";
            // 
            // tenthuoc
            // 
            this.tenthuoc.AutoSize = true;
            this.tenthuoc.Location = new System.Drawing.Point(12, 72);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(67, 17);
            this.tenthuoc.TabIndex = 2;
            this.tenthuoc.Text = "tên thuốc";
            // 
            // ngayhethan
            // 
            this.ngayhethan.AutoSize = true;
            this.ngayhethan.Location = new System.Drawing.Point(12, 213);
            this.ngayhethan.Name = "ngayhethan";
            this.ngayhethan.Size = new System.Drawing.Size(91, 17);
            this.ngayhethan.TabIndex = 2;
            this.ngayhethan.Text = "ngày hết hạn";
            // 
            // nhanvien
            // 
            this.nhanvien.AutoSize = true;
            this.nhanvien.Location = new System.Drawing.Point(12, 159);
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Size = new System.Drawing.Size(70, 17);
            this.nhanvien.TabIndex = 2;
            this.nhanvien.Text = "nhân viên";
            // 
            // ngaynhap
            // 
            this.ngaynhap.AutoSize = true;
            this.ngaynhap.Location = new System.Drawing.Point(12, 120);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(75, 17);
            this.ngaynhap.TabIndex = 2;
            this.ngaynhap.Text = "ngày nhập";
            // 
            // nhacungcap
            // 
            this.nhacungcap.AutoSize = true;
            this.nhacungcap.Location = new System.Drawing.Point(453, 28);
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.Size = new System.Drawing.Size(96, 17);
            this.nhacungcap.TabIndex = 2;
            this.nhacungcap.Text = "loại sản phẩm";
            this.nhacungcap.Click += new System.EventHandler(this.label10_Click);
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Location = new System.Drawing.Point(453, 70);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(62, 17);
            this.soluong.TabIndex = 2;
            this.soluong.Text = "số lượng";
            // 
            // gia
            // 
            this.gia.AutoSize = true;
            this.gia.Location = new System.Drawing.Point(453, 115);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(27, 17);
            this.gia.TabIndex = 2;
            this.gia.Text = "giá";
            this.gia.Click += new System.EventHandler(this.gia_Click);
            // 
            // cb_lohang
            // 
            this.cb_lohang.FormattingEnabled = true;
            this.cb_lohang.Location = new System.Drawing.Point(164, 21);
            this.cb_lohang.Name = "cb_lohang";
            this.cb_lohang.Size = new System.Drawing.Size(168, 24);
            this.cb_lohang.TabIndex = 3;
            // 
            // cb_loaisp
            // 
            this.cb_loaisp.FormattingEnabled = true;
            this.cb_loaisp.Location = new System.Drawing.Point(566, 21);
            this.cb_loaisp.Name = "cb_loaisp";
            this.cb_loaisp.Size = new System.Drawing.Size(148, 24);
            this.cb_loaisp.TabIndex = 3;
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(164, 156);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(168, 24);
            this.cb_nhanvien.TabIndex = 3;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(1075, 398);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(148, 46);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "thêm sản phẩm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbo
            // 
            this.lbo.AutoSize = true;
            this.lbo.Location = new System.Drawing.Point(126, 158);
            this.lbo.Name = "lbo";
            this.lbo.Size = new System.Drawing.Size(54, 17);
            this.lbo.TabIndex = 6;
            this.lbo.Text = "lô ngày";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1257, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 368);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "lô hàng";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "tên thuốc";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "loại sản phẩm";
            this.columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ngày nhập";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "mã nhân viên";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ngày hết hạn";
            this.columnHeader6.Width = 166;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "số lượng";
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "giá";
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(566, 187);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(148, 28);
            this.them.TabIndex = 8;
            this.them.Text = "thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(1408, 410);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 9;
            this.xoa.Text = "xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // xoa2
            // 
            this.xoa2.Location = new System.Drawing.Point(1524, 410);
            this.xoa2.Name = "xoa2";
            this.xoa2.Size = new System.Drawing.Size(75, 23);
            this.xoa2.TabIndex = 10;
            this.xoa2.Text = "xóa hết";
            this.xoa2.UseVisualStyleBackColor = true;
            this.xoa2.Click += new System.EventHandler(this.xoa2_Click);
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Location = new System.Drawing.Point(164, 120);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(168, 22);
            this.dtp_ngaynhap.TabIndex = 11;
            // 
            // dtp_ngayhethan
            // 
            this.dtp_ngayhethan.Location = new System.Drawing.Point(164, 207);
            this.dtp_ngayhethan.Name = "dtp_ngayhethan";
            this.dtp_ngayhethan.Size = new System.Drawing.Size(168, 22);
            this.dtp_ngayhethan.TabIndex = 12;
            // 
            // txt_nhacungcap
            // 
            this.txt_nhacungcap.Location = new System.Drawing.Point(226, 254);
            this.txt_nhacungcap.Name = "txt_nhacungcap";
            this.txt_nhacungcap.Size = new System.Drawing.Size(200, 22);
            this.txt_nhacungcap.TabIndex = 13;
            // 
            // cb_nhanvien2
            // 
            this.cb_nhanvien2.FormattingEnabled = true;
            this.cb_nhanvien2.Location = new System.Drawing.Point(226, 203);
            this.cb_nhanvien2.Name = "cb_nhanvien2";
            this.cb_nhanvien2.Size = new System.Drawing.Size(200, 24);
            this.cb_nhanvien2.TabIndex = 14;
            // 
            // lbo2
            // 
            this.lbo2.AutoSize = true;
            this.lbo2.Location = new System.Drawing.Point(126, 208);
            this.lbo2.Name = "lbo2";
            this.lbo2.Size = new System.Drawing.Size(70, 17);
            this.lbo2.TabIndex = 2;
            this.lbo2.Text = "nhân viên";
            // 
            // lbo3
            // 
            this.lbo3.AutoSize = true;
            this.lbo3.Location = new System.Drawing.Point(126, 259);
            this.lbo3.Name = "lbo3";
            this.lbo3.Size = new System.Drawing.Size(94, 17);
            this.lbo3.TabIndex = 2;
            this.lbo3.Text = "nhà cung cấp";
            // 
            // dtp_taolo
            // 
            this.dtp_taolo.Location = new System.Drawing.Point(226, 158);
            this.dtp_taolo.Name = "dtp_taolo";
            this.dtp_taolo.Size = new System.Drawing.Size(200, 22);
            this.dtp_taolo.TabIndex = 15;
            // 
            // bt_taolo
            // 
            this.bt_taolo.Location = new System.Drawing.Point(129, 92);
            this.bt_taolo.Name = "bt_taolo";
            this.bt_taolo.Size = new System.Drawing.Size(93, 23);
            this.bt_taolo.TabIndex = 16;
            this.bt_taolo.Text = "tạo lô mới";
            this.bt_taolo.UseVisualStyleBackColor = true;
            this.bt_taolo.Click += new System.EventHandler(this.bt_taolo_Click);
            // 
            // lbonew
            // 
            this.lbonew.AutoSize = true;
            this.lbonew.Location = new System.Drawing.Point(276, 98);
            this.lbonew.Name = "lbonew";
            this.lbonew.Size = new System.Drawing.Size(46, 17);
            this.lbonew.TabIndex = 17;
            this.lbonew.Text = "label1";
            // 
            // bt_dslo
            // 
            this.bt_dslo.Location = new System.Drawing.Point(129, 121);
            this.bt_dslo.Name = "bt_dslo";
            this.bt_dslo.Size = new System.Drawing.Size(228, 23);
            this.bt_dslo.TabIndex = 18;
            this.bt_dslo.Text = "xem danh sách lô hàng đã tạo";
            this.bt_dslo.UseVisualStyleBackColor = true;
            this.bt_dslo.Click += new System.EventHandler(this.bt_dslo_Click);
            // 
            // dgv_dslo
            // 
            this.dgv_dslo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dslo.Location = new System.Drawing.Point(48, 150);
            this.dgv_dslo.Name = "dgv_dslo";
            this.dgv_dslo.RowHeadersWidth = 51;
            this.dgv_dslo.RowTemplate.Height = 24;
            this.dgv_dslo.Size = new System.Drawing.Size(448, 254);
            this.dgv_dslo.TabIndex = 19;
            this.dgv_dslo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 336);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // bt_taoloaisp
            // 
            this.bt_taoloaisp.Location = new System.Drawing.Point(6, 19);
            this.bt_taoloaisp.Name = "bt_taoloaisp";
            this.bt_taoloaisp.Size = new System.Drawing.Size(131, 23);
            this.bt_taoloaisp.TabIndex = 21;
            this.bt_taoloaisp.Text = "tạo loại sản phẩm";
            this.bt_taoloaisp.UseVisualStyleBackColor = true;
            this.bt_taoloaisp.Click += new System.EventHandler(this.bt_taoloaisp_Click);
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(123, 59);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(134, 22);
            this.txt_tenloai.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "loại sản phẩm";
            // 
            // bt_xoaloai
            // 
            this.bt_xoaloai.Location = new System.Drawing.Point(356, 59);
            this.bt_xoaloai.Name = "bt_xoaloai";
            this.bt_xoaloai.Size = new System.Drawing.Size(75, 23);
            this.bt_xoaloai.TabIndex = 24;
            this.bt_xoaloai.Text = "xóa";
            this.bt_xoaloai.UseVisualStyleBackColor = true;
            this.bt_xoaloai.Click += new System.EventHandler(this.bt_xoaloai_Click);
            // 
            // bt_sualoai
            // 
            this.bt_sualoai.Location = new System.Drawing.Point(275, 59);
            this.bt_sualoai.Name = "bt_sualoai";
            this.bt_sualoai.Size = new System.Drawing.Size(75, 23);
            this.bt_sualoai.TabIndex = 25;
            this.bt_sualoai.Text = "sửa";
            this.bt_sualoai.UseVisualStyleBackColor = true;
            this.bt_sualoai.Click += new System.EventHandler(this.bt_sualoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "loại sản phẩm";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(505, 312);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(447, 153);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.cb_lohang);
            this.groupBox1.Controls.Add(this.txt_tenthuoc);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.lo);
            this.groupBox1.Controls.Add(this.nhacungcap);
            this.groupBox1.Controls.Add(this.tenthuoc);
            this.groupBox1.Controls.Add(this.soluong);
            this.groupBox1.Controls.Add(this.gia);
            this.groupBox1.Controls.Add(this.ngaynhap);
            this.groupBox1.Controls.Add(this.nhanvien);
            this.groupBox1.Controls.Add(this.ngayhethan);
            this.groupBox1.Controls.Add(this.cb_nhanvien);
            this.groupBox1.Controls.Add(this.cb_loaisp);
            this.groupBox1.Controls.Add(this.dtp_ngayhethan);
            this.groupBox1.Controls.Add(this.dtp_ngaynhap);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Location = new System.Drawing.Point(505, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 239);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "nhập thông tin thuốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.bt_taoloaisp);
            this.groupBox2.Controls.Add(this.txt_tenloai);
            this.groupBox2.Controls.Add(this.bt_sualoai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_xoaloai);
            this.groupBox2.Location = new System.Drawing.Point(12, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 445);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "loại sản phẩm";
            // 
            // frm_themsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.Ảnh_chụp_màn_hình_2022_11_28_034042;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_dslo);
            this.Controls.Add(this.bt_dslo);
            this.Controls.Add(this.lbonew);
            this.Controls.Add(this.bt_taolo);
            this.Controls.Add(this.dtp_taolo);
            this.Controls.Add(this.cb_nhanvien2);
            this.Controls.Add(this.txt_nhacungcap);
            this.Controls.Add(this.xoa2);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.lbo3);
            this.Controls.Add(this.lbo2);
            this.Controls.Add(this.dgv_sanpham);
            this.DoubleBuffered = true;
            this.Name = "frm_themsp";
            this.Text = "thêm sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_themsp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_themsp_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dslo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tenthuoc;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.Label lo;
        private System.Windows.Forms.Label tenthuoc;
        private System.Windows.Forms.Label ngayhethan;
        private System.Windows.Forms.Label nhanvien;
        private System.Windows.Forms.Label ngaynhap;
        private System.Windows.Forms.Label nhacungcap;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.Label gia;
        private System.Windows.Forms.ComboBox cb_lohang;
        private System.Windows.Forms.ComboBox cb_loaisp;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button xoa2;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.DateTimePicker dtp_ngayhethan;
        private System.Windows.Forms.TextBox txt_nhacungcap;
        private System.Windows.Forms.ComboBox cb_nhanvien2;
        private System.Windows.Forms.Label lbo2;
        private System.Windows.Forms.Label lbo3;
        private System.Windows.Forms.DateTimePicker dtp_taolo;
        private System.Windows.Forms.Button bt_taolo;
        private System.Windows.Forms.Label lbonew;
        private System.Windows.Forms.Button bt_dslo;
        private System.Windows.Forms.DataGridView dgv_dslo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_taoloaisp;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xoaloai;
        private System.Windows.Forms.Button bt_sualoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

