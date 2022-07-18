using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_display.Text = DateTime.Now.ToLongTimeString();
                                                             }

        public bool TimeEnabled
        {
            get
            {
                return Main_timer.Enabled;
            }
            set
            {
                Main_timer.Enabled = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TimeEnabled == true)
            TimeEnabled = false;
            else
            TimeEnabled = true;
        }
    }
}
