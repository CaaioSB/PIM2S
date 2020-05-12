using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace uiCSB.Component
{
    public class uiTextBox : TextBox
    {
        public uiTextBox()
        {
            BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            OnCreateControl();
            Invalidate();}

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            OnCreateControl();
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
