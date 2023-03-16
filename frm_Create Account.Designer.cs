
namespace quanlycuahangthuoc
{
    partial class frm_Create_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Create_Account));
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cap = new System.Windows.Forms.ComboBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_tao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(258, 86);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(178, 22);
            this.txt_tk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "tài khoản";
            // 
            // cb_cap
            // 
            this.cb_cap.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_cap.FormattingEnabled = true;
            this.cb_cap.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_cap.Location = new System.Drawing.Point(258, 199);
            this.cb_cap.Name = "cb_cap";
            this.cb_cap.Size = new System.Drawing.Size(178, 24);
            this.cb_cap.TabIndex = 3;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(258, 140);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(178, 22);
            this.txt_mk.TabIndex = 2;
            this.txt_mk.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "cấp tài khoản";
            // 
            // bt_tao
            // 
            this.bt_tao.Location = new System.Drawing.Point(471, 236);
            this.bt_tao.Name = "bt_tao";
            this.bt_tao.Size = new System.Drawing.Size(129, 35);
            this.bt_tao.TabIndex = 4;
            this.bt_tao.Text = "tạo tài khoản";
            this.bt_tao.UseVisualStyleBackColor = true;
            this.bt_tao.Click += new System.EventHandler(this.bt_tao_Click);
            // 
            // frm_Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlycuahangthuoc.Properties.Resources._1621385;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 487);
            this.Controls.Add(this.bt_tao);
            this.Controls.Add(this.cb_cap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Create_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tạo tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cap;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_tao;
    }
}