using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;

namespace BasicFacebookFeatures
{
    public class CirclePictureBox : PictureBox
    {
        public CirclePictureBox() : base()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);
            try
            {
                using (GraphicsPath obj = new GraphicsPath())
                {
                    obj.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                    Region = new Region(obj);
                    paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    paintEvent.Graphics.DrawEllipse(
                        new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
