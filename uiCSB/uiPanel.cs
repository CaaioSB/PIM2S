using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiCSB
{
    public class uiPanel : Panel
    {
        public uiPanel()
        {
            DoubleBuffered = true;
            //MouseEnter += (sender, e) =>
            //{
            //    _isHovering = true;
            //    Invalidate();
            //};
            //MouseLeave += (sender, e) =>
            //{
            //    _isHovering = false;
            //    Invalidate();
            //};
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(Color.FromArgb(242, 245, 255));
            
            //Border
            //g.FillEllipse(brush, 0, 0, Height, Height);
            //g.FillEllipse(brush, Width - Height, 0, Height, Height);
            //g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);

            //brush.Dispose();
            //brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);

            //Inner part. Button itself
            //g.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness,
            //    Height - _borderThickness);
            //g.FillEllipse(brush, (Width - Height) + _borderThicknessByTwo, _borderThicknessByTwo,
            //    Height - _borderThickness, Height - _borderThickness);

            RectangleF myRectangleF = new RectangleF(0F, 0F, Width - 3, Height - 3);

            Rectangle roundedRectangle = Rectangle.Round(myRectangleF);

            // Draw the rounded rectangle in red.
            Pen redPen = new Pen(brush, 1);
            //e.Graphics.DrawRectangle(redPen, roundedRectangle);
            RoundedRectangle.FillRoundedRectangle(e.Graphics, brush, roundedRectangle, 5);
            //e.Graphics.DrawPath(redPen, );

            //g.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo,
            //    Width - Height - _borderThickness, Height - _borderThickness);

            brush.Dispose();
            //brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);

            //FontFamily fontFamily = new FontFamily("Sofia Pro Light");

            //Font font = new Font(
            //    fontFamily,
            //    15,
            //    FontStyle.Regular,
            //    GraphicsUnit.Pixel
            //    );


            //Button Text
            //SizeF stringSize = g.MeasureString(Text, Font);
            //g.DrawString(Text, Font, brush, ((Width) - stringSize.Width) / 2, ((Height) - stringSize.Height) / 2);
        }
    }
}
