using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace E10
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(suma);
            t.Start();
        }

        public void suma()
        {
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                s = s + i;
                this.listBox1.Items.Add(s);
            }
        }
    }
}
