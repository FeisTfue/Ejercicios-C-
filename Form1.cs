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

namespace E9
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //Hace que los hilos puedan acceder a los controles del hilo principal
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(hilo1);
            t.Start();

            t = new Thread(hilo2);
            t.Start();
        }

        public void hilo1()
        {
            for (int i = 0; i < 20; i++)
            {
                this.listBox1.Items.Add(i);
                Thread.Sleep(200);
            }
        }

        public void hilo2()
        {
            for (int i = 0; i < 20; i++)
            {
                this.listBox2.Items.Add(i);
                Thread.Sleep(50);
            }
        }
    }
}
