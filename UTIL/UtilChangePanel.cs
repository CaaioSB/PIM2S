using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caiosb.Util
{
    public class UtilChangePanel
    {
        public static void MudarConteudo(Panel pnlConteudo, UserControl userControl)
        {
            foreach (UserControl control in pnlConteudo.Controls)
            {
                control.Visible = false;
            }

            pnlConteudo.Controls.Add(userControl);

            userControl.Location = new System.Drawing.Point(0, 0);

            userControl.Visible = true;
        }

    }
}
