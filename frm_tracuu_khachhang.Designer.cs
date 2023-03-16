
namespace quanlycuahangthuoc
{
    partial class frm_tracuu_khachhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_sdt = new System.Windows.Forms.CheckBox();
            this.ckb_ten = new System.Windows.Forms.CheckBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.bt_tracuu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckb_time = new System.Windows.Forms.CheckBox();
            this.cb_ngay = new System.Windows.Forms.ComboBox();
            this.ckb_mahd = new System.Windows.Forms.CheckBox();
            this.bt_tim2 = new System.Windows.Forms.Button();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_xuatWord = new System.Windows.Forms.Button();
            this.dgv_load_sphoadon = new System.Windows.Forms.DataGridView();
            this.dgv_load_hoadon = new System.Windows.Forms.DataGridView();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.lb_khach = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_sphoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_hoadon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(102, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 223);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_sdt);
            this.groupBox1.Controls.Add(this.ckb_ten);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.bt_tracuu);
            this.groupBox1.Location = new System.Drawing.Point(42, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tra cứu theo thông tin khách ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckb_sdt
            // 
            this.ckb_sdt.AutoSize = true;
            this.ckb_sdt.Location = new System.Drawing.Point(276, 75);
            this.ckb_sdt.Name = "ckb_sdt";
            this.ckb_sdt.Size = new System.Drawing.Size(111, 21);
            this.ckb_sdt.TabIndex = 2;
            this.ckb_sdt.Text = "số điện thoại";
            this.ckb_sdt.UseVisualStyleBackColor = true;
            this.ckb_sdt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckb_ten
            // 
            this.ckb_ten.AutoSize = true;
            this.ckb_ten.Location = new System.Drawing.Point(276, 44);
            this.ckb_ten.Name = "ckb_ten";
            this.ckb_ten.Size = new System.Drawing.Size(50, 21);
            this.ckb_ten.TabIndex = 2;
            this.ckb_ten.Text = "tên";
            this.ckb_ten.UseVisualStyleBackColor = true;
            this.ckb_ten.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(125, 75);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(124, 22);
            this.txt_sdt.TabIndex = 1;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(125, 44);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(124, 22);
            this.txt_ten.TabIndex = 1;
            // 
            // bt_tracuu
            // 
            this.bt_tracuu.Location = new System.Drawing.Point(422, 73);
            this.bt_tracuu.Name = "bt_tracuu";
            this.bt_tracuu.Size = new System.Drawing.Size(75, 23);
            this.bt_tracuu.TabIndex = 0;
            this.bt_tracuu.Text = "tìm";
            this.bt_tracuu.UseVisualStyleBackColor = true;
            this.bt_tracuu.Click += new System.EventHandler(this.bt_tracuu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(1048, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 223);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_time);
            this.groupBox2.Controls.Add(this.cb_ngay);
            this.groupBox2.Controls.Add(this.ckb_mahd);
            this.groupBox2.Controls.Add(this.bt_tim2);
            this.groupBox2.Controls.Add(this.txt_mahd);
            this.groupBox2.Location = new System.Drawing.Point(34, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tra cứu theo hóa đơn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ckb_time
            // 
            this.ckb_time.AutoSize = true;
            this.ckb_time.Location = new System.Drawing.Point(256, 73);
            this.ckb_time.Name = "ckb_time";
            this.ckb_time.Size = new System.Drawing.Size(156, 21);
            this.ckb_time.TabIndex = 2;
            this.ckb_time.Text = "thời gian thanh toán";
            this.ckb_time.UseVisualStyleBackColor = true;
            this.ckb_time.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cb_ngay
            // 
            this.cb_ngay.FormattingEnabled = true;
            this.cb_ngay.Location = new System.Drawing.Point(26, 74);
            this.cb_ngay.Name = "cb_ngay";
            this.cb_ngay.Size = new System.Drawing.Size(167, 24);
            this.cb_ngay.TabIndex = 1;
            // 
            // ckb_mahd
            // 
            this.ckb_mahd.AutoSize = true;
            this.ckb_mahd.Location = new System.Drawing.Point(256, 42);
            this.ckb_mahd.Name = "ckb_mahd";
            this.ckb_mahd.Size = new System.Drawing.Size(105, 21);
            this.ckb_mahd.TabIndex = 2;
            this.ckb_mahd.Text = "mã hóa đơn";
            this.ckb_mahd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckb_mahd.UseVisualStyleBackColor = true;
            this.ckb_mahd.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bt_tim2
            // 
            this.bt_tim2.Location = new System.Drawing.Point(486, 57);
            this.bt_tim2.Name = "bt_tim2";
            this.bt_tim2.Size = new System.Drawing.Size(75, 23);
            this.bt_tim2.TabIndex = 0;
            this.bt_tim2.Text = "tìm";
            this.bt_tim2.UseVisualStyleBackColor = true;
            this.bt_tim2.Click += new System.EventHandler(this.bt_tim2_Click);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(26, 40);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(167, 22);
            this.txt_mahd.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.bt_xuatWord);
            this.panel3.Controls.Add(this.dgv_load_sphoadon);
            this.panel3.Controls.Add(this.dgv_load_hoadon);
            this.panel3.Controls.Add(this.lb_mahd);
            this.panel3.Controls.Add(this.lb_tongtien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(102, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1735, 515);
            this.panel3.TabIndex = 1;
            // 
            // bt_xuatWord
            // 
            this.bt_xuatWord.Location = new System.Drawing.Point(1572, 31);
            this.bt_xuatWord.Name = "bt_xuatWord";
            this.bt_xuatWord.Size = new System.Drawing.Size(120, 23);
            this.bt_xuatWord.TabIndex = 2;
            this.bt_xuatWord.Text = "xuất file word";
            this.bt_xuatWord.UseVisualStyleBackColor = true;
            this.bt_xuatWord.Click += new System.EventHandler(this.bt_xuatWord_Click);
            // 
            // dgv_load_sphoadon
            // 
            this.dgv_load_sphoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_load_sphoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load_sphoadon.Location = new System.Drawing.Point(969, 68);
            this.dgv_load_sphoadon.Name = "dgv_load_sphoadon";
            this.dgv_load_sphoadon.RowHeadersWidth = 51;
            this.dgv_load_sphoadon.RowTemplate.Height = 24;
            this.dgv_load_sphoadon.Size = new System.Drawing.Size(736, 364);
            this.dgv_load_sphoadon.TabIndex = 1;
            // 
            // dgv_load_hoadon
            // 
            this.dgv_load_hoadon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_load_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load_hoadon.Location = new System.Drawing.Point(57, 68);
            this.dgv_load_hoadon.Name = "dgv_load_hoadon";
            this.dgv_load_hoadon.RowHeadersWidth = 51;
            this.dgv_load_hoadon.RowTemplate.Height = 24;
            this.dgv_load_hoadon.Size = new System.Drawing.Size(855, 364);
            this.dgv_load_hoadon.TabIndex = 1;
            this.dgv_load_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_hoadon_CellContentClick);
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Location = new System.Drawing.Point(1163, 37);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(20, 17);
            this.lb_mahd.TabIndex = 0;
            this.lb_mahd.Text = "...";
            this.lb_mahd.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_tongtien.Location = new System.Drawing.Point(1676, 451);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(16, 17);
            this.lb_tongtien.TabIndex = 0;
            this.lb_tongtien.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1603, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "tổng tiền ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1074, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã hóa đơn";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_nhanvien);
            this.panel4.Controls.Add(this.lb_khach);
            this.panel4.Controls.Add(this.lb_sdt);
            this.panel4.Controls.Add(this.lb_ngay);
            this.panel4.Location = new System.Drawing.Point(63, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 61);
            this.panel4.TabIndex = 2;
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Location = new System.Drawing.Point(80, 97);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(46, 17);
            this.lb_nhanvien.TabIndex = 0;
            this.lb_nhanvien.Text = "label3";
            // 
            // lb_khach
            // 
            this.lb_khach.AutoSize = true;
            this.lb_khach.Location = new System.Drawing.Point(173, 75);
            this.lb_khach.Name = "lb_khach";
            this.lb_khach.Size = new System.Drawing.Size(46, 17);
            this.lb_khach.TabIndex = 0;
            this.lb_khach.Text = "label3";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(80, 65);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(46, 17);
            this.lb_sdt.TabIndex = 0;
            this.lb_sdt.Text = "label3";
            // 
            // lb_ngay
            // 
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Location = new System.Drawing.Point(79, 29);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(46, 17);
            this.lb_ngay.TabIndex = 0;
            this.lb_ngay.Text = "label3";
            // 
            // frm_tracuu_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "frm_tracuu_khachhang";
            this.Text = "frm_tracuu_khachhang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tracuu_khachhang_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_sphoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_hoadon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckb_ten;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button bt_tracuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_ngay;
        private System.Windows.Forms.Button bt_tim2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ckb_sdt;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.CheckBox ckb_time;
        private System.Windows.Forms.CheckBox ckb_mahd;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.DataGridView dgv_load_hoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_load_sphoadon;
        private System.Windows.Forms.Label lb_mahd;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xuatWord;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_nhanvien;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label lb_khach;
    }
}