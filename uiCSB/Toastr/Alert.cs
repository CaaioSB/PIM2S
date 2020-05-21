using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uiCSB.Toastr
{
    public enum Type
    {
        Success,
        Warning,
        Error,
        Info
    }

    public class Alert
    {
        public Alert(string msg, Type type)
        {
            frmToastr frm = new frmToastr();
            frm.showAlert(msg, (frmToastr.enmType)type);
        }
    }
}
