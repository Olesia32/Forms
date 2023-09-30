using System;
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form4 : Form
    {
        double x = 0;
        Thread animationThread;
        ManualResetEvent stopper = new ManualResetEvent(true);

        public Form4()
        {
            InitializeComponent();
            start_bt.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            animationThread= new Thread(SetText);
            animationThread.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            stopper.Reset();
            start_bt.Enabled = true;
            stop_bt.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            stopper.Set();
            start_bt.Enabled = false;
            stop_bt.Enabled = true;
        }

        private void SetText()
        {
            while (true)
            {
                stopper.WaitOne(Timeout.Infinite);
                chart1.Invoke(new MethodInvoker(() =>
                {
                    chart1.Series[0].Points.AddXY(x, Math.Sin(x));
                    x += 0.1;
                }));
                Thread.Sleep(200);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationThread.Abort();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is MainForm mainForm)
            {
                mainForm.button4.Enabled = true;
            }
        }
    }
}
