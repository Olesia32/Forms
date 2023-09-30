using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainForm : Form
    {
        Form f1;
        Form f2;
        Form f3;
        Form f4;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Owner = this as Form;
            f1.Show();
            start.Enabled = false;
            stop.Enabled = true;
            button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Owner = this as Form;
            f2.Show();
            start.Enabled = false;
            stop.Enabled = true;
            button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            f3 = new Form3();
            f3.Owner = this as Form;
            f3.Show();
            start.Enabled = false;
            stop.Enabled = true;
            button3.Enabled = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            f4 = new Form4();
            f4.Owner = this as Form;
            f4.Show();
            start.Enabled = false;
            stop.Enabled = true;
            button4.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Owner = this as Form;
            f1.Show();
            f2 = new Form2();
            f2.Owner = this as Form;
            f2.Show();
            f3 = new Form3();
            f3.Owner = this as Form;
            f3.Show();
            f4 = new Form4();
            f4.Owner = this as Form;
            f4.Show();
            start.Enabled = false;
            stop.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void stop_Click(object sender, EventArgs e)
        { 
            if( f1 != null ) f1.Close();
            if( f2 != null )  f2.Close();
            if( f3 != null ) f3.Close();
            if( f4 != null ) f4.Close();
            start.Enabled = true;
            stop.Enabled = false;
        }
    }
}
