using System.Drawing;
using System.Windows.Forms;

namespace uiCSB.Component
{
    public class uiFlowPanel : FlowLayoutPanel
    {
        public uiFlowPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.FromArgb(230, 235, 255));

            RectangleF myRectangleF = new RectangleF(0F, 0F, Width - 3, Height - 3);

            Rectangle roundedRectangle = Rectangle.Round(myRectangleF);

            Pen redPen = new Pen(brush, 1);

            RoundedRectangle.FillRoundedRectangle(e.Graphics, brush, roundedRectangle, 5);

            brush.Dispose();
        }
    }
}
