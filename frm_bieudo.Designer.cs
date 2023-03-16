
namespace quanlycuahangthuoc
{
    partial class frm_bieudo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.c_tongtien = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.bt_hien = new System.Windows.Forms.Button();
            this.bt_xuat_word = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_nhohon2 = new System.Windows.Forms.DataGridView();
            this.c_sanpham_ghh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_bo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_tongtien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhohon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_sanpham_ghh)).BeginInit();
            this.SuspendLayout();
            // 
            // c_tongtien
            // 
            chartArea5.Name = "ChartArea1";
            this.c_tongtien.ChartAreas.Add(chartArea5);
            this.c_tongtien.Cursor = System.Windows.Forms.Cursors.Default;
            legend5.Name = "Legend1";
            this.c_tongtien.Legends.Add(legend5);
            this.c_tongtien.Location = new System.Drawing.Point(462, 461);
            this.c_tongtien.Name = "c_tongtien";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "tiền hóa đơn";
            this.c_tongtien.Series.Add(series5);
            this.c_tongtien.Size = new System.Drawing.Size(863, 343);
            this.c_tongtien.TabIndex = 0;
            this.c_tongtien.Text = "chart11";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(462, 161);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(863, 272);
            this.dgv_hoadon.TabIndex = 2;
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(519, 106);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(121, 24);
            this.cb_nam.TabIndex = 3;
            this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
            // 
            // bt_hien
            // 
            this.bt_hien.Location = new System.Drawing.Point(675, 107);
            this.bt_hien.Name = "bt_hien";
            this.bt_hien.Size = new System.Drawing.Size(75, 23);
            this.bt_hien.TabIndex = 4;
            this.bt_hien.Text = "hiển thị";
            this.bt_hien.UseVisualStyleBackColor = true;
            this.bt_hien.Click += new System.EventHandler(this.bt_hien_Click);
            // 
            // bt_xuat_word
            // 
            this.bt_xuat_word.Location = new System.Drawing.Point(1199, 105);
            this.bt_xuat_word.Name = "bt_xuat_word";
            this.bt_xuat_word.Size = new System.Drawing.Size(126, 47);
            this.bt_xuat_word.TabIndex = 5;
            this.bt_xuat_word.Text = "xuất ra file word";
            this.bt_xuat_word.UseVisualStyleBackColor = true;
            this.bt_xuat_word.Click += new System.EventHandler(this.bt_xuat_word_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "năm";
            // 
            // dgv_nhohon2
            // 
            this.dgv_nhohon2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhohon2.Location = new System.Drawing.Point(1377, 161);
            this.dgv_nhohon2.Name = "dgv_nhohon2";
            this.dgv_nhohon2.RowHeadersWidth = 51;
            this.dgv_nhohon2.RowTemplate.Height = 24;
            this.dgv_nhohon2.Size = new System.Drawing.Size(575, 272);
            this.dgv_nhohon2.TabIndex = 8;
            // 
            // c_sanpham_ghh
            // 
            chartArea6.Name = "ChartArea1";
            this.c_sanpham_ghh.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.c_sanpham_ghh.Legends.Add(legend6);
            this.c_sanpham_ghh.Location = new System.Drawing.Point(1377, 461);
            this.c_sanpham_ghh.Name = "c_sanpham_ghh";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.c_sanpham_ghh.Series.Add(series6);
            this.c_sanpham_ghh.Size = new System.Drawing.Size(575, 343);
            this.c_sanpham_ghh.TabIndex = 10;
            this.c_sanpham_ghh.Click += new System.EventHandler(this.c_sanpham_ghh_Click);
            // 
            // bt_bo
            // 
            this.bt_bo.Location = new System.Drawing.Point(1877, 106);
            this.bt_bo.Name = "bt_bo";
            this.bt_bo.Size = new System.Drawing.Size(75, 46);
            this.bt_bo.TabIndex = 11;
            this.bt_bo.Text = "loại bỏ";
            this.bt_bo.UseVisualStyleBackColor = true;
            this.bt_bo.Click += new System.EventHandler(this.bt_bo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "danh sách hóa đơn theo năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1486, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "danh sách sản phẩm có hạn nhỏ hơn 2 tháng";
            // 
            // frm_bieudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_bo);
            this.Controls.Add(this.c_sanpham_ghh);
            this.Controls.Add(this.dgv_nhohon2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_xuat_word);
            this.Controls.Add(this.bt_hien);
            this.Controls.Add(this.cb_nam);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.c_tongtien);
            this.DoubleBuffered = true;
            this.Name = "frm_bieudo";
            this.Text = "thống kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_bieudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c_tongtien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhohon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_sanpham_ghh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart c_tongtien;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Button bt_hien;
        private System.Windows.Forms.Button bt_xuat_word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_nhohon2;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_sanpham_ghh;
        private System.Windows.Forms.Button bt_bo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}