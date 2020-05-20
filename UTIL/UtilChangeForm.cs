using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caiosb.Util
{
    public class UtilChangeForm
    {

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
