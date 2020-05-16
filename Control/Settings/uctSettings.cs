using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etherchain.Control
{
    public partial class uctSettings : UserControl
    {
        public uctSettings()
        {
            InitializeComponent();
        }

        private void uiBtnAcessibilidade_Click(object sender, EventArgs e)
        {
            Util.Util.MudarConteudo(uiPnlConteudo, uctAcessibilidade);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Util.Util.MudarConteudo(uiPnlConteudo, uctChangeKey);
        }
    }
}
