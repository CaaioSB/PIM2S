using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.IO;

using uiCSB.Util;
using System.Threading;
using System.Web;
using System.Net;
using caiosb.Util;
using Etherchain.Desktop;
using Etherchain.Common;
using caiosb.Util.Data;

namespace Etherchain.Formularios
{
    public partial class frmBase : Form
    {
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

        public frmBase()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            RoundedForm roundedForm = new RoundedForm(this, pnlBackground);

            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 3, Height - 3, 20, 20));
            //pnlBackground.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlBackground.Width, pnlBackground.Height, 20, 20));

            UtilChangePanel.MudarConteudo(pnlConteudo, uctBase);

            lblNome.Text = AppDesktop.ActualEmployee.FirstName + " " + AppDesktop.ActualEmployee.LastName;
            picProfilePhoto.Image = UtilImage.ByteToImage(AppDesktop.ActualArchive.Blob);
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            AccessLevel();
        }

        private void uiMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AccessLevel()
        {
            Access access = new Access
            {
                EmployeeId = AppDesktop.ActualEmployee.EmployeeId
            }.ObterPorId();


            switch (access.PositionId)
            {
                case 1:
                    // Administrador (todas funções ativadas)
                    btnClientes.Visible = true;
                    btnSupport.Visible = true;
                    btnConfig.Visible = true;
                    btnBackup.Visible = true;
                    btnExecutive.Visible = true;
                    break;
                case 2:
                    // Executive (apenas o módulo executivo ativado)
                    btnClientes.Visible = false;
                    btnSupport.Visible = false;
                    btnConfig.Visible = true;
                    btnBackup.Visible = true;
                    btnExecutive.Visible = true;
                    break;
                case 3:
                    // Corretor (apenas módulos relacionado a controle de clientes ativados).
                    btnClientes.Visible = true;
                    btnSupport.Visible = false;
                    btnConfig.Visible = true;
                    btnBackup.Visible = false;
                    btnExecutive.Visible = false;
                    break;
                case 4:
                    // Suporte (apenas o módulo suporte e controle de clientes ativado)
                    btnClientes.Visible = true;
                    btnSupport.Visible = true;
                    btnConfig.Visible = true;
                    btnBackup.Visible = false;
                    btnExecutive.Visible = false;
                    break;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctClientes);
        }

        private void picProfilePhoto_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctBase);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UtilChangeForm.MudarFormulario(this, new frmAcesso());
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctSupport);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctSettings);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctBackup);
        }

        private void btnExecutive_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(pnlConteudo, uctExecutive);
        }
    }
}
