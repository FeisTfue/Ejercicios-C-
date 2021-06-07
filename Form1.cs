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

namespace E13
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
            t = new Thread(numerosprimos);
            t.Start();
        }

        public void numerosprimos()
        {
            int c = 0;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    if(i % j == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                {
                    this.listBox1.Items.Add(i);
                    Thread.Sleep(200);
                }
                c = 0;
            }
        }
    }
}
