
namespace quanlycuahangthuoc
{
    partial class frm_danhsachsp
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
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_ma = new System.Windows.Forms.RadioButton();
            this.rb_lo = new System.Windows.Forms.RadioButton();
            this.rb_loai = new System.Windows.Forms.RadioButton();
            this.cb_lohang = new System.Windows.Forms.ComboBox();
            this.cb_loaisp = new System.Windows.Forms.ComboBox();
            this.rb_ten = new System.Windows.Forms.RadioButton();
            this.bt_h = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_xuat_ex = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.txt_tenthuoc = new System.Windows.Forms.TextBox();
            this.cb_loaisp2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_ngayHH = new System.Windows.Forms.DateTimePicker();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Location = new System.Drawing.Point(316, 567);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.RowTemplate.Height = 24;
            this.dgv_sanpham.Size = new System.Drawing.Size(1255, 363);
            this.dgv_sanpham.TabIndex = 0;
            this.dgv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentClick);
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(1087, 479);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(81, 23);
            this.bt_tim.TabIndex = 1;
            this.bt_tim.Text = "tìm kiếm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(747, 481);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(307, 22);
            this.txt_tim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "mã thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "lô hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "loại sản phẩm";
            // 
            // rb_ma
            // 
            this.rb_ma.Location = new System.Drawing.Point(420, 487);
            this.rb_ma.Name = "rb_ma";
            this.rb_ma.Size = new System.Drawing.Size(28, 21);
            this.rb_ma.TabIndex = 0;
            this.rb_ma.TabStop = true;
            this.rb_ma.UseVisualStyleBackColor = true;
            this.rb_ma.CheckedChanged += new System.EventHandler(this.rb_ma_CheckedChanged);
            // 
            // rb_lo
            // 
            this.rb_lo.Location = new System.Drawing.Point(523, 486);
            this.rb_lo.Name = "rb_lo";
            this.rb_lo.Size = new System.Drawing.Size(28, 21);
            this.rb_lo.TabIndex = 0;
            this.rb_lo.TabStop = true;
            this.rb_lo.UseVisualStyleBackColor = true;
            this.rb_lo.CheckedChanged += new System.EventHandler(this.rb_lo_CheckedChanged);
            // 
            // rb_loai
            // 
            this.rb_loai.Location = new System.Drawing.Point(617, 487);
            this.rb_loai.Name = "rb_loai";
            this.rb_loai.Size = new System.Drawing.Size(28, 21);
            this.rb_loai.TabIndex = 0;
            this.rb_loai.TabStop = true;
            this.rb_loai.UseVisualStyleBackColor = true;
            this.rb_loai.CheckedChanged += new System.EventHandler(this.rb_loai_CheckedChanged);
            // 
            // cb_lohang
            // 
            this.cb_lohang.FormattingEnabled = true;
            this.cb_lohang.Location = new System.Drawing.Point(747, 479);
            this.cb_lohang.Name = "cb_lohang";
            this.cb_lohang.Size = new System.Drawing.Size(213, 24);
            this.cb_lohang.TabIndex = 7;
            // 
            // cb_loaisp
            // 
            this.cb_loaisp.FormattingEnabled = true;
            this.cb_loaisp.Location = new System.Drawing.Point(747, 479);
            this.cb_loaisp.Name = "cb_loaisp";
            this.cb_loaisp.Size = new System.Drawing.Size(213, 24);
            this.cb_loaisp.TabIndex = 8;
            // 
            // rb_ten
            // 
            this.rb_ten.Location = new System.Drawing.Point(323, 485);
            this.rb_ten.Name = "rb_ten";
            this.rb_ten.Size = new System.Drawing.Size(97, 21);
            this.rb_ten.TabIndex = 0;
            this.rb_ten.TabStop = true;
            this.rb_ten.Text = "tên sản phẩm";
            this.rb_ten.UseVisualStyleBackColor = true;
            this.rb_ten.CheckedChanged += new System.EventHandler(this.rb_ten_CheckedChanged);
            // 
            // bt_h
            // 
            this.bt_h.Location = new System.Drawing.Point(1204, 479);
            this.bt_h.Name = "bt_h";
            this.bt_h.Size = new System.Drawing.Size(81, 23);
            this.bt_h.TabIndex = 9;
            this.bt_h.Text = "hiện tất";
            this.bt_h.UseVisualStyleBackColor = true;
            this.bt_h.Click += new System.EventHandler(this.bt_h_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "danh sách sản phẩm";
            // 
            // bt_xuat_ex
            // 
            this.bt_xuat_ex.Location = new System.Drawing.Point(1445, 525);
            this.bt_xuat_ex.Name = "bt_xuat_ex";
            this.bt_xuat_ex.Size = new System.Drawing.Size(126, 23);
            this.bt_xuat_ex.TabIndex = 11;
            this.bt_xuat_ex.Text = "xuất file exel";
            this.bt_xuat_ex.UseVisualStyleBackColor = true;
            this.bt_xuat_ex.Click += new System.EventHandler(this.bt_xuat_ex_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(788, 302);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(150, 56);
            this.bt_update.TabIndex = 12;
            this.bt_update.Text = "cập nhật sản phẩm";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Location = new System.Drawing.Point(485, 82);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.Size = new System.Drawing.Size(200, 22);
            this.txt_tenthuoc.TabIndex = 13;
            // 
            // cb_loaisp2
            // 
            this.cb_loaisp2.FormattingEnabled = true;
            this.cb_loaisp2.Location = new System.Drawing.Point(485, 123);
            this.cb_loaisp2.Name = "cb_loaisp2";
            this.cb_loaisp2.Size = new System.Drawing.Size(200, 24);
            this.cb_loaisp2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "tên thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "loại sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "ngày hết hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "số lượng";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "giá";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtp_ngayHH
            // 
            this.dtp_ngayHH.Location = new System.Drawing.Point(485, 181);
            this.dtp_ngayHH.Name = "dtp_ngayHH";
            this.dtp_ngayHH.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngayHH.TabIndex = 16;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(485, 221);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(200, 22);
            this.txt_soluong.TabIndex = 13;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(485, 261);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(200, 22);
            this.txt_gia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 17;
            // 
            // labelay
            // 
            this.labelay.AutoSize = true;
            this.labelay.Location = new System.Drawing.Point(436, 46);
            this.labelay.Name = "labelay";
            this.labelay.Size = new System.Drawing.Size(46, 17);
            this.labelay.TabIndex = 17;
            this.labelay.Text = "label7";
            // 
            // frm_danhsachsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.labelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_ngayHH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_loaisp2);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tenthuoc);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_xuat_ex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_h);
            this.Controls.Add(this.cb_loaisp);
            this.Controls.Add(this.cb_lohang);
            this.Controls.Add(this.rb_loai);
            this.Controls.Add(this.rb_lo);
            this.Controls.Add(this.rb_ten);
            this.Controls.Add(this.rb_ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.dgv_sanpham);
            this.DoubleBuffered = true;
            this.Name = "frm_danhsachsp";
            this.Text = "danh sách sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_danhsachsp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_danhsachsp_FormClosed);
            this.Load += new System.EventHandler(this.frm_danhsachsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_ma;
        private System.Windows.Forms.RadioButton rb_lo;
        private System.Windows.Forms.RadioButton rb_loai;
        private System.Windows.Forms.ComboBox cb_lohang;
        private System.Windows.Forms.ComboBox cb_loaisp;
        private System.Windows.Forms.RadioButton rb_ten;
        private System.Windows.Forms.Button bt_h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_xuat_ex;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox txt_tenthuoc;
        private System.Windows.Forms.ComboBox cb_loaisp2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_ngayHH;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelay;
    }
}