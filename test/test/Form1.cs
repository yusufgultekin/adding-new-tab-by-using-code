using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button btn1 = new Button();
        int xLokasyonu = 66;

        private void Form1_Load(object sender, EventArgs e)
        {

            btn1.Size = new Size(20,20);
            btn1.Location = new Point(113,27);
            btn1.Text = "+";
            btn1.Click += new EventHandler(btn1_Click);

            this.Controls.Add(btn1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);

            var x = btn1.Location.X;
            btn1.Location = new Point(x + xLokasyonu, 35);

        }

    }
}
