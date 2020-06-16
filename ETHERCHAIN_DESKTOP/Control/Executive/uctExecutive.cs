using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caiosb.Util.Data;
using caiosb.Util;
using Etherchain.Desktop.Control.Executive;

namespace Etherchain.Control.Executive
{
    public partial class uctExecutive : UserControl
    {
        public uctExecutive()
        {
            InitializeComponent();
        }

        private void uiBtnFuncionario_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(uiPanelConteudo, new uctFuncionario());
        }

        private void uiBtnAcesso_Click(object sender, EventArgs e)
        {
            UtilChangePanel.MudarConteudo(uiPanelConteudo, new uctAcesso());
        }
    }
}
