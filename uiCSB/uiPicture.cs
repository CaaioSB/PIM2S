using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace uiCSB
{
    public class uiPicture : FontAwesome.Sharp.IconPictureBox
    {
        public bool _isHovering;

        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private bool _roundedBorder = false;

        public uiPicture()
        {

            //FlatStyle = FlatStyle.Flat;
            //FlatAppearance.MouseOverBackColor = Color.Transparent;
            //FlatAppearance.MouseDownBackColor = Color.Transparent;
            //FlatAppearance.BorderSize = 0;

            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };


        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public bool Rounded
        {
            get => _roundedBorder;
            set
            {
                _roundedBorder = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);
            BackColor = (_isHovering ? _onHoverButtonColor : _buttonColor);

            if (Rounded)
            {
                using (var gp = new GraphicsPath())
                {
                    gp.AddEllipse(new Rectangle(0, 0, Width, Height));
                    this.Region = new Region(gp);
                };
            }
            else
            {

            IconSize = 30;
            }
        }
    }
}