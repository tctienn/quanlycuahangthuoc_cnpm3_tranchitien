using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlycuahangthuoc
{
    public partial class demo_mainform : Form
    {
        int panelWidth;
        bool Hidden;

        public demo_mainform()
        {
            InitializeComponent();

            panelWidth = panel1.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            timer1.Start();
        }

        private void demo_mainform_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (Hidden)
            {
                panel1.Width = panel1.Width + 10;
                if (panel1.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    //this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    //this.Refresh();
                }
            }
        }
    }
}
