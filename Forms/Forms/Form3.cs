using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form3 : Form
    {
        private Thread rotationThread;
        private ManualResetEvent stopper = new ManualResetEvent(true);
        private int rotationAngle = 0;
        private int squareSize = 100;

        public Form3()
        {
            InitializeComponent();
            start_bt.Enabled = false;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            rotationThread = new Thread(RotateSquare);
            rotationThread.Start();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            e.Graphics.RotateTransform(rotationAngle);
            e.Graphics.FillRectangle(Brushes.Red, -squareSize / 2, -squareSize / 2, squareSize, squareSize);
        }

        private void StartRotationButton_Click(object sender, EventArgs e)
        {
            stopper.Set();
            start_bt.Enabled = false;
            stop_bt.Enabled = true;
        }

        private void StopRotationButton_Click(object sender, EventArgs e)
        {
            stopper.Reset();
            start_bt.Enabled = true;
            stop_bt.Enabled = false;
        }

        private void RotateSquare()
        {
            while (true)
            {
                stopper.WaitOne(Timeout.Infinite);
                rotationAngle += 5;
                if (rotationAngle >= 360)
                    rotationAngle = 0;
                pictureBox1.Invalidate();
                Thread.Sleep(20);
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            rotationThread.Abort();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner is MainForm mainForm)
            {
                mainForm.button3.Enabled = true;
            }
        }
    }
}

