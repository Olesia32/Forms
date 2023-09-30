using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        private Thread animationThread;
        private bool isGrowing = true;
        private ManualResetEvent stopper = new ManualResetEvent(true);
        private int triangleSize = 20;
        private int maxSize = 150;

        public Form1()
        {
            InitializeComponent();
            start_bt.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            animationThread = new Thread(AnimateTriangle);
            animationThread.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int halfSize = triangleSize / 2;
            Point[] points = new Point[]
            {
        new Point(pictureBox1.Width / 2, pictureBox1.Height / 2 - halfSize),
        new Point(pictureBox1.Width / 2 - halfSize, pictureBox1.Height / 2 + halfSize),
        new Point(pictureBox1.Width / 2 + halfSize, pictureBox1.Height / 2 + halfSize)
            };
            e.Graphics.FillPolygon(Brushes.Green, points);
        }

        private void StartAnimationButton_Click(object sender, EventArgs e)
        {
            stopper.Set();
            start_bt.Enabled = false;
            stop_bt.Enabled = true;
        }

        private void StopAnimationButton_Click(object sender, EventArgs e)
        {
            stopper.Reset();
            start_bt.Enabled = true;
            stop_bt.Enabled = false;
        }

        private void AnimateTriangle()
        {
            while (true)
            {
                stopper.WaitOne(Timeout.Infinite);
                if (isGrowing)
                {
                    triangleSize += 5; // Збільшуємо розмір трикутника
                    if (triangleSize >= maxSize)
                        isGrowing = false;
                }
                else
                {
                    triangleSize -= 5; // Зменшуємо розмір трикутника
                    if (triangleSize <= 0)
                        isGrowing = true;
                }
                pictureBox1.Invalidate();
                Thread.Sleep(40);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationThread.Abort();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is MainForm mainForm)
            {
                mainForm.button1.Enabled = true;
            }
        }
    }
}

