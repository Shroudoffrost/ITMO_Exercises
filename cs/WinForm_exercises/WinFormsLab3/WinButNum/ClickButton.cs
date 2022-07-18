using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinButNum
{
    internal class ClickButton : Button
    {
        int mClicks;
        public int Clicks
        {
            get { return mClicks; }    
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
                               }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            SizeF stringSize;
            stringSize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font, SystemBrushes.ControlText,
                                            this.Width - stringSize.Width - 3,
                                            this.Height - stringSize.Height - 3);
                                                                                    }
    }
}
