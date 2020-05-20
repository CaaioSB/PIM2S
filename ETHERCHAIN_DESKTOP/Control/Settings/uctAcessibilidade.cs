using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uiCSB.Component;

namespace Etherchain.Control
{
    public partial class uctAcessibilidade : UserControl
    {
        public uctAcessibilidade()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            uiButton uiButton = (uiButton)sender;


            if (uiButton.ButtonColor == Color.Red)
            {
                uiButton.ButtonColor = Color.Lime;
                uiButton.OnHoverButtonColor = Color.ForestGreen;
            }
            else
            {
                uiButton.ButtonColor = Color.Red;
                uiButton.OnHoverButtonColor = Color.DarkRed;
            }
        }
    }
}
