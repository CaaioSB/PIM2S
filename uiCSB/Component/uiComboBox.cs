using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace uiCSB.Component
{
    public class uiComboBox : ComboBox
    {
        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    base.OnPaintBackground(e);
        //    using (var brush = new SolidBrush(BackColor))
        //    {
        //        e.Graphics.FillRectangle(brush, ClientRectangle);
        //        e.Graphics.DrawRectangle(Pens.Red, 5, 5, ClientSize.Width + 5, ClientSize.Height + 5);
        //    }
        //}

        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.FromArgb(65, 50, 122);
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                        var d = FlatStyle == FlatStyle.Popup ? 1 : 0;
                        g.DrawLine(p, Width - buttonWidth - d,
                            0, Width - buttonWidth - d, Height);
                    }
                }
            }
        }
    }
}
