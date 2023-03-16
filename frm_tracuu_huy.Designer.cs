
namespace quanlycuahangthuoc
{
    partial class frm_tracuu_huy
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
            this.dgv_thongkehuy = new System.Windows.Forms.DataGridView();
            this.txt_sophieu = new System.Windows.Forms.TextBox();
            this.rb_sophieu = new System.Windows.Forms.RadioButton();
            this.bt_tim = new System.Windows.Forms.Button();
            this.bt_xuat_excel = new System.Windows.Forms.Button();
            this.cb_lo = new System.Windows.Forms.ComboBox();
            this.rb_lo = new System.Windows.Forms.RadioButton();
            this.rb_ngayhuy = new System.Windows.Forms.RadioButton();
            this.cb_ngayhuy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkehuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_thongkehuy
            // 
            this.dgv_thongkehuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkehuy.Location = new System.Drawing.Point(181, 286);
            this.dgv_thongkehuy.Name = "dgv_thongkehuy";
            this.dgv_thongkehuy.RowHeadersWidth = 51;
            this.dgv_thongkehuy.RowTemplate.Height = 24;
            this.dgv_thongkehuy.Size = new System.Drawing.Size(1026, 351);
            this.dgv_thongkehuy.TabIndex = 0;
            // 
            // txt_sophieu
            // 
            this.txt_sophieu.Location = new System.Drawing.Point(656, 172);
            this.txt_sophieu.Name = "txt_sophieu";
            this.txt_sophieu.Size = new System.Drawing.Size(121, 22);
            this.txt_sophieu.TabIndex = 1;
            // 
            // rb_sophieu
            // 
            this.rb_sophieu.AutoSize = true;
            this.rb_sophieu.Location = new System.Drawing.Point(182, 171);
            this.rb_sophieu.Name = "rb_sophieu";
            this.rb_sophieu.Size = new System.Drawing.Size(83, 21);
            this.rb_sophieu.TabIndex = 2;
            this.rb_sophieu.TabStop = true;
            this.rb_sophieu.Text = "số phiếu";
            this.rb_sophieu.UseVisualStyleBackColor = true;
            this.rb_sophieu.CheckedChanged += new System.EventHandler(this.rb_sophieu_CheckedChanged);
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(801, 172);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 4;
            this.bt_tim.Text = "tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // bt_xuat_excel
            // 
            this.bt_xuat_excel.Location = new System.Drawing.Point(1030, 257);
            this.bt_xuat_excel.Name = "bt_xuat_excel";
            this.bt_xuat_excel.Size = new System.Drawing.Size(153, 23);
            this.bt_xuat_excel.TabIndex = 4;
            this.bt_xuat_excel.Text = "xuất file excel";
            this.bt_xuat_excel.UseVisualStyleBackColor = true;
            this.bt_xuat_excel.Click += new System.EventHandler(this.bt_xuat_excel_Click);
            // 
            // cb_lo
            // 
            this.cb_lo.FormattingEnabled = true;
            this.cb_lo.Location = new System.Drawing.Point(656, 172);
            this.cb_lo.Name = "cb_lo";
            this.cb_lo.Size = new System.Drawing.Size(121, 24);
            this.cb_lo.TabIndex = 5;
            // 
            // rb_lo
            // 
            this.rb_lo.AutoSize = true;
            this.rb_lo.Location = new System.Drawing.Point(281, 172);
            this.rb_lo.Name = "rb_lo";
            this.rb_lo.Size = new System.Drawing.Size(76, 21);
            this.rb_lo.TabIndex = 2;
            this.rb_lo.TabStop = true;
            this.rb_lo.Text = "lô hàng";
            this.rb_lo.UseVisualStyleBackColor = true;
            this.rb_lo.CheckedChanged += new System.EventHandler(this.rb_lo_CheckedChanged);
            // 
            // rb_ngayhuy
            // 
            this.rb_ngayhuy.AutoSize = true;
            this.rb_ngayhuy.Location = new System.Drawing.Point(382, 172);
            this.rb_ngayhuy.Name = "rb_ngayhuy";
            this.rb_ngayhuy.Size = new System.Drawing.Size(87, 21);
            this.rb_ngayhuy.TabIndex = 2;
            this.rb_ngayhuy.TabStop = true;
            this.rb_ngayhuy.Text = "ngày hủy";
            this.rb_ngayhuy.UseVisualStyleBackColor = true;
            this.rb_ngayhuy.CheckedChanged += new System.EventHandler(this.rb_ngayhuy_CheckedChanged);
            // 
            // cb_ngayhuy
            // 
            this.cb_ngayhuy.FormattingEnabled = true;
            this.cb_ngayhuy.Location = new System.Drawing.Point(656, 172);
            this.cb_ngayhuy.Name = "cb_ngayhuy";
            this.cb_ngayhuy.Size = new System.Drawing.Size(121, 24);
            this.cb_ngayhuy.TabIndex = 5;
            // 
            // frm_tracuu_huy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.cb_ngayhuy);
            this.Controls.Add(this.cb_lo);
            this.Controls.Add(this.bt_xuat_excel);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.rb_ngayhuy);
            this.Controls.Add(this.rb_lo);
            this.Controls.Add(this.rb_sophieu);
            this.Controls.Add(this.txt_sophieu);
            this.Controls.Add(this.dgv_thongkehuy);
            this.DoubleBuffered = true;
            this.Name = "frm_tracuu_huy";
            this.Text = "danh sách thuốc đã hủy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_tracuu_huy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkehuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongkehuy;
        private System.Windows.Forms.TextBox txt_sophieu;
        private System.Windows.Forms.RadioButton rb_sophieu;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.Button bt_xuat_excel;
        private System.Windows.Forms.ComboBox cb_lo;
        private System.Windows.Forms.RadioButton rb_lo;
        private System.Windows.Forms.RadioButton rb_ngayhuy;
        private System.Windows.Forms.ComboBox cb_ngayhuy;
    }
}