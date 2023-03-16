
namespace quanlycuahangthuoc
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sấToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adawdawdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_nhanvien = new System.Windows.Forms.Button();
            this.bt_huythuoc = new System.Windows.Forms.Button();
            this.bt_dssp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tracuu_huy = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.bt_hoadon = new System.Windows.Forms.Button();
            this.bt_bieudo = new System.Windows.Forms.Button();
            this.ql_tk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_nhap = new System.Windows.Forms.Button();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_tracuu_hd_kh = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sấToolStripMenuItem,
            this.adawdawdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 52);
            // 
            // sấToolStripMenuItem
            // 
            this.sấToolStripMenuItem.Name = "sấToolStripMenuItem";
            this.sấToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.sấToolStripMenuItem.Text = "áds";
            this.sấToolStripMenuItem.Click += new System.EventHandler(this.sấToolStripMenuItem_Click);
            // 
            // adawdawdToolStripMenuItem
            // 
            this.adawdawdToolStripMenuItem.Name = "adawdawdToolStripMenuItem";
            this.adawdawdToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.adawdawdToolStripMenuItem.Text = "item";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChínhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // trangChínhToolStripMenuItem
            // 
            this.trangChínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpSảnPhẩmToolStripMenuItem});
            this.trangChínhToolStripMenuItem.Name = "trangChínhToolStripMenuItem";
            this.trangChínhToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.trangChínhToolStripMenuItem.Text = "trang chính";
            // 
            // nhậpSảnPhẩmToolStripMenuItem
            // 
            this.nhậpSảnPhẩmToolStripMenuItem.Name = "nhậpSảnPhẩmToolStripMenuItem";
            this.nhậpSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.nhậpSảnPhẩmToolStripMenuItem.Text = "nhập sản phẩm";
            this.nhậpSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.nhậpSảnPhẩmToolStripMenuItem_Click);
            // 
            // bt_nhanvien
            // 
            this.bt_nhanvien.Location = new System.Drawing.Point(23, 39);
            this.bt_nhanvien.Name = "bt_nhanvien";
            this.bt_nhanvien.Size = new System.Drawing.Size(265, 36);
            this.bt_nhanvien.TabIndex = 3;
            this.bt_nhanvien.Text = "quản lý nhân viên";
            this.bt_nhanvien.UseVisualStyleBackColor = true;
            this.bt_nhanvien.Click += new System.EventHandler(this.bt_nhanvien_Click);
            // 
            // bt_huythuoc
            // 
            this.bt_huythuoc.Location = new System.Drawing.Point(23, 156);
            this.bt_huythuoc.Name = "bt_huythuoc";
            this.bt_huythuoc.Size = new System.Drawing.Size(265, 36);
            this.bt_huythuoc.TabIndex = 4;
            this.bt_huythuoc.Text = "hủy thuốc";
            this.bt_huythuoc.UseVisualStyleBackColor = true;
            this.bt_huythuoc.Click += new System.EventHandler(this.bt_huythuoc_Click);
            // 
            // bt_dssp
            // 
            this.bt_dssp.Location = new System.Drawing.Point(23, 211);
            this.bt_dssp.Name = "bt_dssp";
            this.bt_dssp.Size = new System.Drawing.Size(265, 39);
            this.bt_dssp.TabIndex = 6;
            this.bt_dssp.Text = "danh sách sản phẩm";
            this.bt_dssp.UseVisualStyleBackColor = true;
            this.bt_dssp.Click += new System.EventHandler(this.bt_dssp_Click);
            // 
            // tracuu_huy
            // 
            this.tracuu_huy.Location = new System.Drawing.Point(23, 262);
            this.tracuu_huy.Name = "tracuu_huy";
            this.tracuu_huy.Size = new System.Drawing.Size(265, 36);
            this.tracuu_huy.TabIndex = 7;
            this.tracuu_huy.Text = "tra cứu danh sách thuốc hủy";
            this.tracuu_huy.UseVisualStyleBackColor = true;
            this.tracuu_huy.Click += new System.EventHandler(this.tracuu_huy_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Turquoise;
            this.lb_name.Location = new System.Drawing.Point(402, 40);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(51, 17);
            this.lb_name.TabIndex = 8;
            this.lb_name.Text = "name :";
            // 
            // bt_hoadon
            // 
            this.bt_hoadon.Location = new System.Drawing.Point(23, 313);
            this.bt_hoadon.Name = "bt_hoadon";
            this.bt_hoadon.Size = new System.Drawing.Size(265, 36);
            this.bt_hoadon.TabIndex = 9;
            this.bt_hoadon.Text = "thanh toán";
            this.bt_hoadon.UseVisualStyleBackColor = true;
            this.bt_hoadon.Click += new System.EventHandler(this.bt_hoadon_Click);
            // 
            // bt_bieudo
            // 
            this.bt_bieudo.Location = new System.Drawing.Point(23, 489);
            this.bt_bieudo.Name = "bt_bieudo";
            this.bt_bieudo.Size = new System.Drawing.Size(265, 36);
            this.bt_bieudo.TabIndex = 10;
            this.bt_bieudo.Text = "biểu đồ";
            this.bt_bieudo.UseVisualStyleBackColor = true;
            this.bt_bieudo.Click += new System.EventHandler(this.bt_bieudo_Click);
            // 
            // ql_tk
            // 
            this.ql_tk.Location = new System.Drawing.Point(23, 541);
            this.ql_tk.Name = "ql_tk";
            this.ql_tk.Size = new System.Drawing.Size(128, 48);
            this.ql_tk.TabIndex = 11;
            this.ql_tk.Text = "QL_ tài khoản";
            this.ql_tk.UseVisualStyleBackColor = true;
            this.ql_tk.Click += new System.EventHandler(this.ql_tk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.bt_nhap);
            this.panel1.Controls.Add(this.bt_thongke);
            this.panel1.Controls.Add(this.bt_tracuu_hd_kh);
            this.panel1.Controls.Add(this.bt_nhanvien);
            this.panel1.Controls.Add(this.bt_huythuoc);
            this.panel1.Controls.Add(this.bt_dssp);
            this.panel1.Controls.Add(this.ql_tk);
            this.panel1.Controls.Add(this.tracuu_huy);
            this.panel1.Controls.Add(this.bt_bieudo);
            this.panel1.Controls.Add(this.bt_hoadon);
            this.panel1.Location = new System.Drawing.Point(24, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 794);
            this.panel1.TabIndex = 12;
            // 
            // bt_nhap
            // 
            this.bt_nhap.Location = new System.Drawing.Point(23, 97);
            this.bt_nhap.Name = "bt_nhap";
            this.bt_nhap.Size = new System.Drawing.Size(265, 32);
            this.bt_nhap.TabIndex = 14;
            this.bt_nhap.Text = "nhập thuốc";
            this.bt_nhap.UseVisualStyleBackColor = true;
            this.bt_nhap.Click += new System.EventHandler(this.bt_nhap_Click);
            // 
            // bt_thongke
            // 
            this.bt_thongke.Location = new System.Drawing.Point(23, 435);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(265, 36);
            this.bt_thongke.TabIndex = 13;
            this.bt_thongke.Text = "thống kê";
            this.bt_thongke.UseVisualStyleBackColor = true;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_tracuu_hd_kh
            // 
            this.bt_tracuu_hd_kh.Location = new System.Drawing.Point(23, 372);
            this.bt_tracuu_hd_kh.Name = "bt_tracuu_hd_kh";
            this.bt_tracuu_hd_kh.Size = new System.Drawing.Size(265, 36);
            this.bt_tracuu_hd_kh.TabIndex = 12;
            this.bt_tracuu_hd_kh.Text = "tra cứu hóa đơn khách hàng";
            this.bt_tracuu_hd_kh.UseVisualStyleBackColor = true;
            this.bt_tracuu_hd_kh.Click += new System.EventHandler(this.bt_tracuu_hd_kh_Click);
            // 
            // menu
            // 
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = global::quanlycuahangthuoc.Properties.Resources.menu__1_;
            this.menu.Location = new System.Drawing.Point(24, 31);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(39, 35);
            this.menu.TabIndex = 13;
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources.round_white_tablets_pills_on_blue_background_tablets_and_caplets_pills_pharmaceutical_dosage_form_pharmacy_and_health_topics_background_pharmaceutical_industry_banner_online_pharmacy_store_banner_photo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sấToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adawdawdToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Button bt_nhanvien;
        private System.Windows.Forms.Button bt_huythuoc;
        private System.Windows.Forms.Button bt_dssp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button tracuu_huy;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bt_hoadon;
        private System.Windows.Forms.Button bt_bieudo;
        private System.Windows.Forms.Button ql_tk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_tracuu_hd_kh;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_nhap;
    }
}