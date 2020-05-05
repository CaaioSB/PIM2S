using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain.Util
{
    public static class Util
    {
        public static void MudarConteudo(Panel pnlConteudo, UserControl userControl)
        {
            foreach (UserControl control in pnlConteudo.Controls)
            {
                control.Visible = false;
            }

            userControl.Location = new System.Drawing.Point(0, 0);

            userControl.Visible = true;
        }

        public static void MudarFormulario(Form oldForm, Form newForm)
        {
            var a = oldForm;
            a.Hide();
            var form = newForm;
            form.Closed += (s, args) => form.Close();
            form.Show();
        }
    }
}
