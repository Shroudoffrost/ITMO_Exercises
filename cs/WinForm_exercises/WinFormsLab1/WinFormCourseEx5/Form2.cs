using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormCourseEx5
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GraphicsPath Rekt = new GraphicsPath();
            Rectangle GetRekt = new Rectangle(0, 0, this.Height, this.Width);
            Rekt.AddRectangle(GetRekt);
            Region region = new Region(GetRekt);
            this.Region = region;
        }

        private void button1_click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
