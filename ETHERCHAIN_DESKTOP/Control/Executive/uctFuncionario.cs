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
using uiCSB.Component;
using System.Runtime.InteropServices;
using caiosb.Util.Data;
using System.Drawing.Text;
using System.Windows.Markup;
using uiCSB.Toastr;
using Type = uiCSB.Toastr.Type;

namespace Etherchain.Desktop.Control.Executive
{
    public partial class uctFuncionario : UserControl
    {
        public uctFuncionario()
        {
            InitializeComponent();
        }

        private void uctFuncionario_Load(object sender, EventArgs e)
        {
            List<Employee> employee = new Employee { }.ObterTodos();

            for (int i = 0; i < employee.Count; i++)
            {
                CreateUserPanel(employee[i], uiFlowPanel);

                if (i == 2)
                {
                    break;
                }
            }
        }

        private void CreateUserPanel(Employee employee, FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                uiPanel uiPanel = new uiPanel();
                uiPanel.Size = new Size(241, 86);
                uiPanel.PanelRadius = 5;
                uiPanel.Tag = employee.EmployeeId;
                uiPanel.BackColor = Color.FromArgb(215, 223, 255);
                uiPanel.Click += new EventHandler(Employee_Click);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "picEmployee" + employee.EmployeeId;
                pictureBox.Size = new Size(77, 77);
                pictureBox.Image = Properties.Resources.male;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Tag = employee.EmployeeId;
                pictureBox.BackColor = Color.Transparent;
                uiPanel.Controls.Add(pictureBox);
                pictureBox.Location = new Point(4, 4);
                pictureBox.Click += new EventHandler(Employee_Click);

                Label label = new Label();
                label.Name = "lblEmployee" + employee.EmployeeId;
                label.Font = new Font("Gadugi", 14, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(80, 63, 153);
                label.Tag = employee.EmployeeId;
                label.BackColor = Color.FromArgb(242, 245, 255);
                label.Text = employee.FirstName + " " + employee.LastName;
                label.AutoEllipsis = true;
                label.AutoSize = false;
                label.Size = new Size(153, 21);
                uiPanel.Controls.Add(label);
                label.Location = new Point(85, 6);
                label.Click += new EventHandler(Employee_Click);

                Label labelCPF = new Label();
                labelCPF.Name = "lblEmployeeCPF" + employee.EmployeeId;
                labelCPF.Font = new Font("Gadugi", 8);
                labelCPF.ForeColor = Color.FromArgb(180, 182, 194);
                labelCPF.BackColor = Color.FromArgb(242, 245, 255);
                labelCPF.Text = UtilConvert.ToString(employee.CPF);
                labelCPF.AutoEllipsis = true;
                labelCPF.Tag = employee.EmployeeId;
                labelCPF.AutoSize = false;
                labelCPF.Size = new Size(151, 14);
                uiPanel.Controls.Add(labelCPF);
                labelCPF.Location = new Point(87, 27);
                labelCPF.Click += new EventHandler(Employee_Click);

                for (int i = 1; i < flowLayoutPanel.Controls.Count; i++)
                {
                    flowLayoutPanel.Controls.RemoveAt(i);
                }
                flowLayoutPanel.Controls.Add(uiPanel);
                flowLayoutPanel.Controls.Add(uiPanelEmployee);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Não existe funcionário com este CPF.");
            }
        }

        private void uiTxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (uiTxtSearch.TextLength == 11)
            {
                Employee employee = new Employee { CPF = uiTxtSearch.Text }.ObterPorCPF();

                CreateUserPanel(employee, uiFlowPanel);
            }
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                PreencheDadosEmployee(new Employee { EmployeeId = UtilConvert.ToInt(panel.Tag) }.ObterPorId());
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                PreencheDadosEmployee(new Employee { EmployeeId = UtilConvert.ToInt(label.Tag) }.ObterPorId());
            }
            else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                PreencheDadosEmployee(new Employee { EmployeeId = UtilConvert.ToInt(pictureBox.Tag) }.ObterPorId());
            }
        }

        public void PreencheDadosEmployee(Employee employee)
        {
            lblEmployeeId.Text = UtilConvert.ToString(employee.EmployeeId);
            //lblWords.Text = UtilConvert.ToString(employee.Words);
            //lblWordsLanguage.Text = UtilConvert.ToString(employee.WordsLanguage);
            lblArchiveId.Text = UtilConvert.ToString(employee.ArchiveId);
            uiTxtPNome.Text = UtilConvert.ToString(employee.FirstName);
            uiTxtUNome.Text = UtilConvert.ToString(employee.LastName);
            uiTxtDataNasc.Text = UtilConvert.ToString(employee.DateBirth);
            uiTxtSexo.Text = UtilConvert.ToString(employee.Gender);
            uiTxtCPF.Text = UtilConvert.ToString(employee.CPF);
            uiTxtRG.Text = UtilConvert.ToString(employee.RG);
            uiTxtEmail.Text = UtilConvert.ToString(employee.Email);
            uiTxtLogradouro.Text = UtilConvert.ToString(employee.StreetLine);
            uiTxtNumero.Text = UtilConvert.ToString("0");
            uiTxtBairro.Text = UtilConvert.ToString("");
            uiTxtPais.Text = UtilConvert.ToString(employee.Country);
            uiTxtCidade.Text = UtilConvert.ToString(employee.City);
            uiTxtEstado.Text = UtilConvert.ToString(employee.Region);
            uiTxtCep.Text = UtilConvert.ToString(employee.PostCode);
            uiTxtTelCel.Text = UtilConvert.ToString(employee.MobileNumber);

            btnCriar.Visible = false;
            btnCancelar.Visible = true;
            btnAtualizar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PreencheDadosEmployee(new Employee { CPF = uiTxtCPF.Text }.ObterPorCPF());
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                new Employee
                {
                    EmployeeId = UtilConvert.ToInt(lblEmployeeId.Text),
                    //Words = UtilConvert.ToString(lblWords.Text),
                    //WordsLanguage = UtilConvert.ToString(lblWordsLanguage.Text),
                    FirstName = UtilConvert.ToString(uiTxtPNome.Text),
                    LastName = UtilConvert.ToString(uiTxtUNome.Text),
                    ArchiveId = UtilConvert.ToInt(lblArchiveId.Text),
                    DateBirth = UtilConvert.ToDateTime(uiTxtDataNasc.Text),
                    Gender = UtilConvert.ToChar(uiTxtSexo.Text),
                    CPF = uiTxtCPF.Text,
                    RG = uiTxtRG.Text,
                    Email = uiTxtEmail.Text,
                    StreetLine = uiTxtLogradouro.Text,
                    //uiTxtNumero.Text,
                    //uiTxtBairro.Text,
                    Country = uiTxtPais.Text,
                    City = uiTxtCidade.Text,
                    Region = uiTxtEstado.Text,
                    PostCode = uiTxtCep.Text,
                    MobileNumber = uiTxtTelCel.Text
                }.AlterarPorId();

                new Alert("Funcionário alterado com sucesso!", Type.Success);
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
