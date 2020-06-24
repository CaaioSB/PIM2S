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
        private bool draggable = false;


        public int mov;
        public int movY;
        public int movX;

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

        public bool Draggable { get => draggable; set => draggable = value; }

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

        protected override void OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);

            if (Draggable)
            {
                mov = 1;
                movX = e.X;
                movY = e.Y;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);

            if (Draggable)
            {
                if (mov == 1)
                {
                    Form form = Application.OpenForms[0];
                    form.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp(e);

            if (Draggable)
            {
                mov = 0;
            }
        }
    }
}
