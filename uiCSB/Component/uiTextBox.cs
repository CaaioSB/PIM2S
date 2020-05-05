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

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            OnCreateControl();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height -3, 5, 5));
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
