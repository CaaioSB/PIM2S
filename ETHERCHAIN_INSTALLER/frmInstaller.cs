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

namespace ETHERCHAIN_INSTALLER
{
    public partial class frmInstaller : Form
    {
        public frmInstaller()
        {
            InitializeComponent();
            RoundedForm roundedForm = new RoundedForm(this, pnlBackground);
        }

        private void frmInstaller_Load(object sender, EventArgs e)
        {
            timerInstall.Enabled = true;
        }

        private void timerInstall_Tick(object sender, EventArgs e)
        {
            progressBar.Size = new Size(progressBar.Width + 1, progressBar.Height);
            if (progressBar.Width / 5.16 < 10)
            {
                progressBar.Text = (progressBar.Width / 5.16).ToString().Substring(0, 1) + "%";
            }
            else if (progressBar.Width / 5.16 >= 10 && progressBar.Width / 5.16 <= 99)
            {
                progressBar.Text = (progressBar.Width / 5.16).ToString().Substring(0, 2) + "%";
            }
            else if (progressBar.Width / 5.16 == 100)
            {
                progressBar.Text = "100%";
                timerInstall.Enabled = false;
            }
        }
    }
}
