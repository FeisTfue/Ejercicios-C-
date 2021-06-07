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

namespace E12
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
            t = new Thread(numerosimpares);
            t.Start();
        }

        public void numerosimpares()
        {
            for (int i = 1; i < 25; i=i+2)
            {
                this.listBox1.Items.Add(i);
                Thread.Sleep(100);
            }
        }
    }
}
