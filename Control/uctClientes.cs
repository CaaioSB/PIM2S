using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etherchain.Util;

namespace Etherchain.Control
{
    public partial class uctClientes : UserControl
    {
        public uctClientes()
        {
            InitializeComponent();
        }

        private string iniciaisNome = string.Empty;

        // Trocar object pelo objeto do Cliente
        public void MostrarCliente(string inicial)
        {
            uiPanelSecurity.Visible = true;
            uiPanelSecurity.Location = new Point(109, 113);

            string[] label = new string[3] { inicial, "BGS", "BTC" };
            var rng = new Random();

            rng.Shuffle(label);
            rng.Shuffle(label);

            lblOp1.Text = label[0];
            lblOp2.Text = label[1];
            lblOp3.Text = label[2];
        }

        private void uiButtonValidar_Click(object sender, EventArgs e)
        {
            if (iniciaisNome == "CSB" && uiTxtRg.Text == "0")
            {
                uiPanelSecurity.Visible = false;
                uiPanelDados.Visible = true;
            }
        }

        private void uiPanelCliente_Click(object sender, EventArgs e)
        {
            MostrarCliente("CSB");
        }

        private void LabelSecurity_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control label in uiNameBackground.Controls)
            {
                label.ForeColor = Color.White;
            }

            if (sender is Label)
            {
                Label label = (Label)sender;
                label.ForeColor = Color.SteelBlue;
                iniciaisNome = label.Text;
            }
        }

        private void uctClientes_Load(object sender, EventArgs e)
        {
            uiPanelDados.Visible = false;
        }
    }
}
