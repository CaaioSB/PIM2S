using Blockchain.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiCSB.Component;
using uiCSB.Util;
using Blockchain.Util;

namespace Blockchain.Formularios
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

            Util.Util.MudarConteudo(pnlConteudo, uctBase);


        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void btnBlockchain_Click(object sender, EventArgs e)
        {
            Util.Util.MudarConteudo(pnlConteudo, uctBlockchain);
        }

        private void picProfilePhoto_Click(object sender, EventArgs e)
        {
            Util.Util.MudarConteudo(pnlConteudo, uctBase);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Util.Util.MudarFormulario(this, new frmAcesso());
        }

        private void uiMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
