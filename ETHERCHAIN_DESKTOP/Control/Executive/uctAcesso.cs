using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etherchain.Common;
using caiosb.Util;
using caiosb.Util.Hash;
using caiosb.Util.Data;
using uiCSB.Toastr;

namespace Etherchain.Desktop.Control.Executive
{
    public partial class uctAcesso : UserControl
    {
        public uctAcesso()
        {
            InitializeComponent();
        }

        private Employee employee;

        private void uctAcesso_Load(object sender, EventArgs e)
        {
            uiTxtCPF.ReadOnly = false;

            ObterFuncionarios();

            // Busca os cargos
            List<Position> positions = new Position { }.ObterTodos();
            positions.ForEach(position => { cboPositions.Items.Add(position.Name); });
        }

        private void ObterFuncionarios()
        {
            List<Employee> employee = new Employee { }.ObterDescadastrados();

            for (int i = 0; i < uiFlowPanel.Controls.Count; i++)
            {
                uiFlowPanel.Controls.RemoveAt(i);
            }

            for (int i = 0; i < employee.Count; i++)
            {
                UtilCreatePanel.CreateUserPanel(employee[i], uiFlowPanel, Employee_Click);
            }
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                employee = (new Employee { EmployeeId = UtilConvert.ToInt(panel.Tag) }.ObterPorId());

                uiTxtCPF.ReadOnly = true;
                uiTxtCPF.Text = UtilConvert.ToString(employee.CPF);
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                employee = (new Employee { EmployeeId = UtilConvert.ToInt(label.Tag) }.ObterPorId());

                uiTxtCPF.ReadOnly = true;
                uiTxtCPF.Text = UtilConvert.ToString(employee.CPF);
            }
            else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                employee = (new Employee { EmployeeId = UtilConvert.ToInt(pictureBox.Tag) }.ObterPorId());

                uiTxtCPF.ReadOnly = true;
                uiTxtCPF.Text = UtilConvert.ToString(employee.CPF);
            }
        }

        private void uiBtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                new Access
                {
                    EmployeeId = employee.EmployeeId,
                    PositionId = UtilConvert.ToInt(cboPositions.SelectedIndex) + 1,
                    Cpf = employee.CPF,
                    Hash = Hash.HASH.cyph(uiTxtHash.Text),
                    Active = true
                }.Gravar();

                LimparCampos();
                ObterFuncionarios();
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Warning);
            }
        }

        private void LimparCampos()
        {
            uiTxtCPF.Text = "";
            uiTxtHash.Text = "";
            uiTxtSearch.Text = "";
        }
    }
}
