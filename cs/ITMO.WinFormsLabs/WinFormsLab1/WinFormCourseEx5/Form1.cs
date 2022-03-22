using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinFormCourseEx5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath EllipseMaker = new GraphicsPath();
            EllipseMaker.AddEllipse(0,0,this.Width/2,this.Height/2);
            Region region = new Region(EllipseMaker);
            this.Region = region;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
