
namespace quanlycuahangthuoc
{
    partial class frm_thongke
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_lo = new System.Windows.Forms.ComboBox();
            this.rb_lo = new System.Windows.Forms.RadioButton();
            this.rb_han24t = new System.Windows.Forms.RadioButton();
            this.rb_hon4t = new System.Windows.Forms.RadioButton();
            this.bt_thongke_sp = new System.Windows.Forms.Button();
            this.dgv_load = new System.Windows.Forms.DataGridView();
            this.bt_excel1 = new System.Windows.Forms.Button();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.bt_thongkehd = new System.Windows.Forms.Button();
            this.bt_excel2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_thongkenv = new System.Windows.Forms.Button();
            this.bt_excel3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1900, 222);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bt_excel2);
            this.groupBox3.Controls.Add(this.bt_thongkehd);
            this.groupBox3.Controls.Add(this.cb_nam);
            this.groupBox3.Location = new System.Drawing.Point(612, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bt_excel3);
            this.groupBox2.Controls.Add(this.bt_thongkenv);
            this.groupBox2.Location = new System.Drawing.Point(1402, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_excel1);
            this.groupBox1.Controls.Add(this.cb_lo);
            this.groupBox1.Controls.Add(this.rb_lo);
            this.groupBox1.Controls.Add(this.rb_han24t);
            this.groupBox1.Controls.Add(this.rb_hon4t);
            this.groupBox1.Controls.Add(this.bt_thongke_sp);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sản phẩm";
            // 
            // cb_lo
            // 
            this.cb_lo.FormattingEnabled = true;
            this.cb_lo.Location = new System.Drawing.Point(187, 110);
            this.cb_lo.Name = "cb_lo";
            this.cb_lo.Size = new System.Drawing.Size(121, 24);
            this.cb_lo.TabIndex = 3;
            // 
            // rb_lo
            // 
            this.rb_lo.AutoSize = true;
            this.rb_lo.Location = new System.Drawing.Point(60, 111);
            this.rb_lo.Name = "rb_lo";
            this.rb_lo.Size = new System.Drawing.Size(94, 21);
            this.rb_lo.TabIndex = 2;
            this.rb_lo.TabStop = true;
            this.rb_lo.Text = "lọc theo lô";
            this.rb_lo.UseVisualStyleBackColor = true;
            this.rb_lo.CheckedChanged += new System.EventHandler(this.rb_lo_CheckedChanged);
            // 
            // rb_han24t
            // 
            this.rb_han24t.AutoSize = true;
            this.rb_han24t.Location = new System.Drawing.Point(60, 73);
            this.rb_han24t.Name = "rb_han24t";
            this.rb_han24t.Size = new System.Drawing.Size(214, 21);
            this.rb_han24t.TabIndex = 2;
            this.rb_han24t.TabStop = true;
            this.rb_han24t.Text = "hạn trong khoản từ 2-4 tháng";
            this.rb_han24t.UseVisualStyleBackColor = true;
            // 
            // rb_hon4t
            // 
            this.rb_hon4t.AutoSize = true;
            this.rb_hon4t.Location = new System.Drawing.Point(60, 37);
            this.rb_hon4t.Name = "rb_hon4t";
            this.rb_hon4t.Size = new System.Drawing.Size(156, 21);
            this.rb_hon4t.TabIndex = 2;
            this.rb_hon4t.TabStop = true;
            this.rb_hon4t.Text = "hạn lớn hơn 4 tháng";
            this.rb_hon4t.UseVisualStyleBackColor = true;
            // 
            // bt_thongke_sp
            // 
            this.bt_thongke_sp.Location = new System.Drawing.Point(371, 55);
            this.bt_thongke_sp.Name = "bt_thongke_sp";
            this.bt_thongke_sp.Size = new System.Drawing.Size(85, 57);
            this.bt_thongke_sp.TabIndex = 1;
            this.bt_thongke_sp.Text = "thống kê";
            this.bt_thongke_sp.UseVisualStyleBackColor = true;
            this.bt_thongke_sp.Click += new System.EventHandler(this.bt_thongke_sp_Click);
            // 
            // dgv_load
            // 
            this.dgv_load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_load.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load.Location = new System.Drawing.Point(65, 305);
            this.dgv_load.Name = "dgv_load";
            this.dgv_load.RowHeadersWidth = 51;
            this.dgv_load.RowTemplate.Height = 24;
            this.dgv_load.Size = new System.Drawing.Size(1779, 556);
            this.dgv_load.TabIndex = 1;
            // 
            // bt_excel1
            // 
            this.bt_excel1.Location = new System.Drawing.Point(371, 118);
            this.bt_excel1.Name = "bt_excel1";
            this.bt_excel1.Size = new System.Drawing.Size(85, 23);
            this.bt_excel1.TabIndex = 4;
            this.bt_excel1.Text = "xất excel";
            this.bt_excel1.UseVisualStyleBackColor = true;
            this.bt_excel1.Click += new System.EventHandler(this.bt_excel1_Click);
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(112, 55);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(196, 24);
            this.cb_nam.TabIndex = 0;
            // 
            // bt_thongkehd
            // 
            this.bt_thongkehd.Location = new System.Drawing.Point(504, 48);
            this.bt_thongkehd.Name = "bt_thongkehd";
            this.bt_thongkehd.Size = new System.Drawing.Size(105, 57);
            this.bt_thongkehd.TabIndex = 1;
            this.bt_thongkehd.Text = "thống kê";
            this.bt_thongkehd.UseVisualStyleBackColor = true;
            this.bt_thongkehd.Click += new System.EventHandler(this.bt_thongkehd_Click);
            // 
            // bt_excel2
            // 
            this.bt_excel2.Location = new System.Drawing.Point(504, 111);
            this.bt_excel2.Name = "bt_excel2";
            this.bt_excel2.Size = new System.Drawing.Size(105, 23);
            this.bt_excel2.TabIndex = 1;
            this.bt_excel2.Text = "xuất excel";
            this.bt_excel2.UseVisualStyleBackColor = true;
            this.bt_excel2.Click += new System.EventHandler(this.bt_excel2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "năm";
            // 
            // bt_thongkenv
            // 
            this.bt_thongkenv.Location = new System.Drawing.Point(247, 28);
            this.bt_thongkenv.Name = "bt_thongkenv";
            this.bt_thongkenv.Size = new System.Drawing.Size(105, 38);
            this.bt_thongkenv.TabIndex = 0;
            this.bt_thongkenv.Text = "thống kê";
            this.bt_thongkenv.UseVisualStyleBackColor = true;
            this.bt_thongkenv.Click += new System.EventHandler(this.bt_thongkenv_Click);
            // 
            // bt_excel3
            // 
            this.bt_excel3.Location = new System.Drawing.Point(247, 89);
            this.bt_excel3.Name = "bt_excel3";
            this.bt_excel3.Size = new System.Drawing.Size(105, 23);
            this.bt_excel3.TabIndex = 0;
            this.bt_excel3.Text = "xuất excel";
            this.bt_excel3.UseVisualStyleBackColor = true;
            this.bt_excel3.Click += new System.EventHandler(this.bt_xuat_Click);
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.dgv_load);
            this.Controls.Add(this.panel1);
            this.Name = "frm_thongke";
            this.Text = "frm_thongke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_thongke_sp;
        private System.Windows.Forms.ComboBox cb_lo;
        private System.Windows.Forms.RadioButton rb_lo;
        private System.Windows.Forms.RadioButton rb_han24t;
        private System.Windows.Forms.RadioButton rb_hon4t;
        private System.Windows.Forms.DataGridView dgv_load;
        private System.Windows.Forms.Button bt_excel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_excel2;
        private System.Windows.Forms.Button bt_thongkehd;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Button bt_excel3;
        private System.Windows.Forms.Button bt_thongkenv;
    }
}