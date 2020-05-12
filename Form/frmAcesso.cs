using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using uiCSB.Util;
using uiCSB.Component;

namespace Etherchain.Formularios
{
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();

            RoundedForm roundedForm = new RoundedForm(this);
        }

        private void uiExit_Click(object sender, EventArgs e)
        {
            // Simples applcation close.
            Application.Exit();

            // Make a secure and complete application close below...
        }

        private void uiLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmBase();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
