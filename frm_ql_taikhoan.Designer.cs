
namespace quanlycuahangthuoc
{
    partial class frm_ql_taikhoan
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
            this.dgv_taikhoan = new System.Windows.Forms.DataGridView();
            this.bt_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.txt_newmk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.cb_cap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_mk = new System.Windows.Forms.CheckBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.ckb_cap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_taikhoan
            // 
            this.dgv_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoan.Location = new System.Drawing.Point(134, 214);
            this.dgv_taikhoan.Name = "dgv_taikhoan";
            this.dgv_taikhoan.RowHeadersWidth = 51;
            this.dgv_taikhoan.RowTemplate.Height = 24;
            this.dgv_taikhoan.Size = new System.Drawing.Size(502, 304);
            this.dgv_taikhoan.TabIndex = 0;
            this.dgv_taikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoan_CellContentClick);
            // 
            // bt_tim
            // 
            this.bt_tim.Location = new System.Drawing.Point(368, 163);
            this.bt_tim.Name = "bt_tim";
            this.bt_tim.Size = new System.Drawing.Size(75, 23);
            this.bt_tim.TabIndex = 1;
            this.bt_tim.Text = "tìm";
            this.bt_tim.UseVisualStyleBackColor = true;
            this.bt_tim.Click += new System.EventHandler(this.bt_tim_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(203, 163);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(100, 22);
            this.txt_tim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "tài khoản";
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(903, 189);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 4;
            this.bt_update.Text = "sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // txt_newmk
            // 
            this.txt_newmk.Location = new System.Drawing.Point(903, 279);
            this.txt_newmk.Name = "txt_newmk";
            this.txt_newmk.Size = new System.Drawing.Size(203, 22);
            this.txt_newmk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "mật khẩu";
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(1031, 188);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(143, 23);
            this.bt_xoa.TabIndex = 4;
            this.bt_xoa.Text = "xóa tài khoản";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // cb_cap
            // 
            this.cb_cap.FormattingEnabled = true;
            this.cb_cap.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_cap.Location = new System.Drawing.Point(903, 336);
            this.cb_cap.Name = "cb_cap";
            this.cb_cap.Size = new System.Drawing.Size(203, 24);
            this.cb_cap.TabIndex = 5;
            this.cb_cap.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "cấp";
            // 
            // ckb_mk
            // 
            this.ckb_mk.AutoSize = true;
            this.ckb_mk.Location = new System.Drawing.Point(1137, 279);
            this.ckb_mk.Name = "ckb_mk";
            this.ckb_mk.Size = new System.Drawing.Size(123, 21);
            this.ckb_mk.TabIndex = 6;
            this.ckb_mk.Text = "đổi mật khẩu ?";
            this.ckb_mk.UseVisualStyleBackColor = true;
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(1031, 500);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(134, 44);
            this.bt_create.TabIndex = 4;
            this.bt_create.Text = "thêm tài khoản";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Location = new System.Drawing.Point(900, 233);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(20, 17);
            this.lb_taikhoan.TabIndex = 3;
            this.lb_taikhoan.Text = "...";
            // 
            // ckb_cap
            // 
            this.ckb_cap.AutoSize = true;
            this.ckb_cap.Location = new System.Drawing.Point(1137, 343);
            this.ckb_cap.Name = "ckb_cap";
            this.ckb_cap.Size = new System.Drawing.Size(150, 21);
            this.ckb_cap.TabIndex = 6;
            this.ckb_cap.Text = "đổi cấp tài khoản ?";
            this.ckb_cap.UseVisualStyleBackColor = true;
            // 
            // frm_ql_taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1646, 897);
            this.Controls.Add(this.ckb_cap);
            this.Controls.Add(this.ckb_mk);
            this.Controls.Add(this.cb_cap);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_newmk);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.bt_tim);
            this.Controls.Add(this.dgv_taikhoan);
            this.DoubleBuffered = true;
            this.Name = "frm_ql_taikhoan";
            this.Text = "quản lý tài khoản";
            this.Load += new System.EventHandler(this.frm_ql_taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_taikhoan;
        private System.Windows.Forms.Button bt_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox txt_newmk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.ComboBox cb_cap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_mk;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.CheckBox ckb_cap;
    }
}