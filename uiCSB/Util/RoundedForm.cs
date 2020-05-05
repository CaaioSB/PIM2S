using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiCSB.Util
{
    public class RoundedForm
    {
        public RoundedForm(Form form = null, Panel panel = null)
        {
            if (form != null && panel != null)
            {
                TransformToRounded(form);
                TransformToRounded(panel);
            }
            else if (panel != null)
            {
                TransformToRounded(panel);
            }
            else
            {
                TransformToRounded(form);
            }
        }

        private Region TransformToRounded(Object objeto)
        {
            if (objeto is Form)
            {
                Form form = (Form)objeto;
                form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 20, 20));

                return form.Region;
            }
            else if (objeto is Panel)
            {
                Panel panel = (Panel)objeto;
                panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 20, 20));

                return panel.Region;
            }
            else
            {
                return new Region();
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
