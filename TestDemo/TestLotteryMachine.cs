using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemo
{
    public partial class TestLotteryMachine : Form
    {
        public TestLotteryMachine()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        bool b = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                b = true;
                button1.Text = "停止";
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                b = false;
                button1.Text = "开始";
            }
            
        }
        public void PlayGame()
        {
            Random r = new Random();
            while (b)
            {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }
    }
}
