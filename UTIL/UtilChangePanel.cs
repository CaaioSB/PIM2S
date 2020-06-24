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
                if (control.Name != "uctSupport")
                {
                    ((Control)control).Dispose();
                }
                else
                {
                    control.Visible = false;
                }
            }

            if (userControl.Name == "uctSupport")
            {
                userControl.Visible = true;
                userControl.Location = new System.Drawing.Point(0, 0);
            }
            else
            {
                pnlConteudo.Controls.Add(userControl);
                userControl.Location = new System.Drawing.Point(0, 0);
                userControl.Show();
                //userControl.Visible = true;
            }
        }
    }
}
