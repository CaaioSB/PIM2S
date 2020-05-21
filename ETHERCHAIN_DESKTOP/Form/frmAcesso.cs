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
using Etherchain.Common;
using Etherchain.Desktop;
using caiosb.Util.Hash;
using uiCSB.Toastr;
using Type = uiCSB.Toastr.Type;

namespace Etherchain.Formularios
{
    public partial class frmAcesso : Form
    {
        public frmAcesso()
        {
            InitializeComponent();

            RoundedForm roundedForm = new RoundedForm(this);

            AppDesktop.startup();
        }

        private void uiExit_Click(object sender, EventArgs e)
        {
            // Simples applcation close.
            Application.Exit();

            // Make a secure and complete application close below...
        }

        private void uiLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Access access = new Access
                {
                    Cpf = uiTxtCPF.Text,
                    Hash = Hash.HASH.cyph(uiTxtHash.Text),
                    Active = true
                };

                int? idEmployee = access.AutenticarPorCPF();

                if (idEmployee != null)
                {
                    Employee employee = new Employee
                    {
                        EmployeeId = (int)idEmployee
                    }.ObterPorId();

                    AppDesktop.ActualEmployee = employee;

                    this.Hide();
                    var form = new frmBase();
                    form.Closed += (s, args) => this.Close();
                    form.Show();

                    new Alert("Login realizado com sucesso.", Type.Info);
                }
                else
                {
                    new Alert("CPF e/ou Senha incorretos.", Type.Warning);
                }
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, Type.Warning);
            }
        }
    }
}
