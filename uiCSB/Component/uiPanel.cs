using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiCSB.Component
{
    public class uiPanel : Panel
    {
        private Color _panelColor = Color.FromArgb(242, 245, 255);

        private int _panelRadius = 5;

        public uiPanel()
        {
            DoubleBuffered = true;
        }

        public Color PanelColor
        {
            get => _panelColor;
            set
            {
                _panelColor = value;
                Invalidate();
            }
        }

        public int PanelRadius
        {
            get => _panelRadius;
            set
            {
                _panelRadius = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(_panelColor);

            RectangleF myRectangleF = new RectangleF(0F, 0F, Width -1 , Height-1);

            Rectangle roundedRectangle = Rectangle.Round(myRectangleF);

            Pen redPen = new Pen(brush, 1);

            RoundedRectangle.FillRoundedRectangle(e.Graphics, brush, roundedRectangle, _panelRadius);

            brush.Dispose();
        }
    }
}
