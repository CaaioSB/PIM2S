using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace uiCSB.Component
{
    public class uiPicture : FontAwesome.Sharp.IconPictureBox
    {
        public bool _isHovering;

        private Color _buttonColor = Color.FromArgb(72, 84, 179);
        private Color _onHoverButtonColor = Color.FromArgb(72, 65, 179);
        private bool _roundedBorder = false;
        private int _size = 10;

        public uiPicture()
        {
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

        public int uiSize
        {
            get => _size;
            set
            {
                _size = value;
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
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            }
            else
            {
                IconSize = _size + 0;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
    }
}