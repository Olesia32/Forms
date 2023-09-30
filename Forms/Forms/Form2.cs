using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form2 : Form
    {
        Ball ball;
        ManualResetEvent stopper = new ManualResetEvent(true);
        Thread animationThread;

        public class Ball
        {
            public int X, Y; 
            public int R; 
            public int dX, dY;

            public Ball(int radius)
            {
                R = radius;        
                X = 50;
                Y = 50; 
                dX = 4;
                dY = 5;
            }
            public void drawBall(PaintEventArgs e)
            {
                Graphics rg = e.Graphics;
                Color goldColor = Color.FromArgb(255, 255, 215, 0);
                Brush brush = new SolidBrush(goldColor); 
                rg.FillEllipse(brush, X - (R / 2), Y - (R / 2), R, R); 
            }
            public void beginBall(int width, int height, int size)
            {
                if (X <= (size / 2)) dX = -dX;
                if (X >= width - (size / 2)) dX = -dX;
                if (Y <= (size / 2)) dY = -dY; 
                if (Y >= height - (size / 2)) dY = -dY;
                X += dX;
                Y += dY;
            }

        }
        
        public Form2()
        {
            InitializeComponent();
            start_bt.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            animationThread = new Thread(MakeProgress);
            ball = new Ball(15);
            animationThread.Start();
        }

        private void MakeProgress()
        {
            while(true)
            {
                stopper.WaitOne(Timeout.Infinite);
                ball.beginBall(pictureBox1.Width, pictureBox1.Height, 15);
                pictureBox1.Invalidate();
                Thread.Sleep(20);
            }
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

        private void paint(object sender, PaintEventArgs e)
        {
            ball.drawBall(e);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationThread.Abort();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Owner is MainForm mainForm)
            {
                mainForm.button2.Enabled = true;
            }
        }
    }
}
