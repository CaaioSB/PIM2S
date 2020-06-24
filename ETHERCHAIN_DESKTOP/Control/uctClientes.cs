using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caiosb.Util;
using Etherchain.Common;
using caiosb.Util.Data;
using uiCSB.Toastr;
using System.Web.UI;
using uiCSB.Component;

namespace Etherchain.Control
{
    public partial class uctClientes : System.Windows.Forms.UserControl
    {
        CustomerFisico currentCustomerFisico;
        CustomerJuridico currentCustomerJuridico;

        public uctClientes()
        {
            InitializeComponent();
        }

        private string iniciaisNome = string.Empty;

        // Trocar object pelo objeto do Cliente
        public void MostrarCliente(CustomerFisico customerFisico = null, CustomerJuridico customerJuridico = null)
        {
            flowPanelCustomerF.Visible = false;
            flowPanelCustomerJ.Visible = false;

            if (currentCustomerFisico != null)
            {
                lblDado.Text = "REGISTRO GERAL";
                uiPanelSecurity.Visible = true;
                uiPanelSecurity.Location = new Point(109, 113);
            }
            else if (currentCustomerJuridico != null)
            {
                lblDado.Text = "RAZÃO SOCIAL";
                uiPanelSecurity.Visible = true;
                uiPanelSecurity.Location = new Point(109, 113);
            }
        }

        private void uiButtonValidar_Click(object sender, EventArgs e)
        {
            if (currentCustomerFisico != null)
            {
                if (uiTxtValidacao.Text == currentCustomerFisico.RG)
                {
                    uiPanelSecurity.Visible = false;
                    flowPanelCustomerJ.Visible = false;

                    txtNomeF.Text = string.Format("{0} {1}", currentCustomerFisico.FirstName, currentCustomerFisico.LastName);
                    txtDataF.Text = UtilConvert.ToString(UtilConvert.ToDate(currentCustomerFisico.DateBirth).ToShortDateString());
                    txtSexoF.Text = UtilConvert.ToString(currentCustomerFisico.Gender);
                    txtCPFF.Text = UtilConvert.ToString(currentCustomerFisico.CPF);
                    txtRGF.Text = UtilConvert.ToString(currentCustomerFisico.RG);
                    txtEmailF.Text = UtilConvert.ToString(currentCustomerFisico.Email);

                    flowPanelCustomerF.Controls.Add(uiFlowPanelMoedas);
                    flowPanelCustomerF.Controls.Add(panelCryptocurrency);
                    flowPanelCustomerF.Visible = true;
                }
                else
                {
                    new Alert("O RG fornecido não está de acordo com atual cliente.\nTente novamente mais tarde.", uiCSB.Toastr.Type.Warning);
                }
            }
            else if (currentCustomerJuridico != null)
            {
                if (uiTxtValidacao.Text == currentCustomerJuridico.RazaoSocial)
                {
                    uiPanelSecurity.Visible = false;
                    flowPanelCustomerF.Visible = false;

                    txtRazaoSocialJ.Text = UtilConvert.ToString(currentCustomerJuridico.RazaoSocial);
                    txtCNPJJ.Text = UtilConvert.ToString(currentCustomerJuridico.CNPJ);
                    txtEmailJ.Text = UtilConvert.ToString(currentCustomerJuridico.Email);

                    flowPanelCustomerJ.Controls.Add(uiFlowPanelMoedas);
                    flowPanelCustomerJ.Controls.Add(panelCryptocurrencyJ);
                    flowPanelCustomerJ.Visible = true;
                }
                else
                {
                    new Alert("A razão social fornecida não está de acordo com atual cliente.\nTente novamente mais tarde.", uiCSB.Toastr.Type.Warning);
                }
            }
        }

        private void uctClientes_Load(object sender, EventArgs e)
        {
            //List<CustomerFisico> customers = new CustomerFisico().ObterTodos();
            //UtilCreatePanel.CreateCustomerPanel(customers, uiFlowPanel, Customer_Click);
            //uiPanelDados.Visible = false;
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            uiTxtValidacao.Text = string.Empty;
            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                MostrarCliente();
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                MostrarCliente();
            }
            else if (sender is PictureBox)
            {
                PictureBox picture = sender as PictureBox;
                MostrarCliente();
            }
        }

        private void uiTxtSearch_TextChanged(object sender, EventArgs e)
        {
            uiFlowPanel.Controls.Clear();
            currentCustomerJuridico = null;
            currentCustomerFisico = null;

            if (uiTxtSearch.TextLength == 11)
            {
                if (UtilValidar.validarCPF(uiTxtSearch.Text))
                {
                    currentCustomerFisico = new CustomerFisico() { CPF = uiTxtSearch.Text }.ObterPorCPF();

                    if (currentCustomerFisico != null)
                    {
                        UtilCreatePanel.CreateCustomerFPanel(currentCustomerFisico, uiFlowPanel, Customer_Click);
                        flowPanelCustomerF.Visible = false;
                    }
                    else
                    {
                        new Alert("Não possui cliente com o CPF inserido.", uiCSB.Toastr.Type.Warning);
                    }
                }
            }
            else if (uiTxtSearch.TextLength == 14)
            {
                if (UtilValidar.validarCNPJ(uiTxtSearch.Text))
                {
                    currentCustomerJuridico = new CustomerJuridico() { CNPJ = uiTxtSearch.Text }.ObterPorCNPJ();

                    if (currentCustomerJuridico != null)
                    {
                        UtilCreatePanel.CreateCustomerJPanel(currentCustomerJuridico, uiFlowPanel, Customer_Click);
                        flowPanelCustomerJ.Visible = false;
                    }
                    else
                    {
                        new Alert("Não possui cliente com o CNPJ inserido.", uiCSB.Toastr.Type.Warning);
                        uiTxtSearch.Text = string.Empty;
                    }
                }
                else
                {
                    new Alert("O CNPJ inserido é inválido.", uiCSB.Toastr.Type.Warning);
                    uiTxtSearch.Text = string.Empty;
                    uiTxtSearch.Focus();
                }
            }
        }

        private void uiTxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (uiTxtSearch.TextLength == 11)
                {
                    if (UtilValidar.validarCPF(uiTxtSearch.Text))
                    {
                        currentCustomerFisico = new CustomerFisico() { CPF = uiTxtSearch.Text }.ObterPorCPF();

                        if (currentCustomerFisico != null)
                        {
                            UtilCreatePanel.CreateCustomerFPanel(currentCustomerFisico, uiFlowPanel, Customer_Click);
                            flowPanelCustomerF.Visible = false;
                        }
                        else
                        {
                            new Alert("Não possui cliente com o CPF inserido.", uiCSB.Toastr.Type.Warning);
                            uiTxtSearch.Text = string.Empty;
                        }
                    }
                    else
                    {
                        new Alert("O CPF inserido é inválido.", uiCSB.Toastr.Type.Warning);
                        uiTxtSearch.Text = string.Empty;
                    }
                }
                else if (uiTxtSearch.TextLength == 14)
                {
                    if (UtilValidar.validarCNPJ(uiTxtSearch.Text))
                    {
                        currentCustomerJuridico = new CustomerJuridico() { CNPJ = uiTxtSearch.Text }.ObterPorCNPJ();

                        if (currentCustomerJuridico != null)
                        {

                        }
                        else
                        {
                            new Alert("Não possui cliente com o CNPJ inserido.", uiCSB.Toastr.Type.Warning);
                            uiTxtSearch.Text = string.Empty;
                        }
                    }
                    else
                    {
                        new Alert("O CNPJ inserido é inválido.", uiCSB.Toastr.Type.Warning);
                        uiTxtSearch.Text = string.Empty;
                    }
                }
            }
        }

        private void uiFlowPanelMoedas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiFlowPanelMoedas_ParentChanged(object sender, EventArgs e)
        {
            List<Cryptocurency> cryptocurrencys = new Cryptocurency().ObterTodos();

            foreach (Cryptocurency cryptocurrency in cryptocurrencys)
            {
                uiPicture uiPicture = uiPicture1;
                uiPicture.BackgroundImage = UtilImage.ByteToImage(new Archive() { ArchiveId = cryptocurrency.ArchiveId }.ObterPorCod().Blob);
                uiPicture.Tag = UtilConvert.ToString(cryptocurrency.CryptocurrencyId);
                //uiPicture.Click += new EventHandler(UiPicture_Click);
                uiPicture.Visible = true;
                uiFlowPanelMoedas.Controls.Add(uiPicture);
            }
        }

        private void UiPicture_Click(object sender, EventArgs e)
        {
            uiPicture pic = sender as uiPicture;

            if (currentCustomerFisico != null)
            {
                Wallet wallet = new Wallet
                {
                    CustomerId = currentCustomerFisico.CustomerId,
                    CryptoCurrencyId = UtilConvert.ToInt(pic.Tag)
                }.ObterPorId();

                GeneratePanel(wallet);
            }
            else if (currentCustomerJuridico != null)
            {
                Wallet wallet = new Wallet
                {
                    CustomerId = currentCustomerJuridico.CustomerId,
                    CryptoCurrencyId = UtilConvert.ToInt(pic.Tag)
                }.ObterPorId();

                GeneratePanel(wallet);
            }
            else
            {
                new Alert("Ocorreu um erro grave! comunique ao seu gestor.", uiCSB.Toastr.Type.Error);
            }
        }

        private void GeneratePanel(Wallet wallet)
        {

            if (wallet != null)
            {
                if (!(currentCustomerFisico is null))
                {
                    txtAddressF.Text = UtilConvert.ToString(wallet.Address);
                    txtCurencyF.Text = UtilConvert.ToString(wallet.CryptoCurrencyBalance).Replace(',', '.');
                    txtSendedF.Text = UtilConvert.ToString(wallet.CryptoCurrencySent).Replace(',', '.');
                    txtReceivedF.Text = UtilConvert.ToString(wallet.CryptoCurrencyReceived).Replace(',', '.');
                }
                else if (!(currentCustomerJuridico is null))
                {
                    txtAddressJ.Text = UtilConvert.ToString(wallet.Address);
                    txtBalanceJ.Text = UtilConvert.ToString(wallet.CryptoCurrencyBalance).Replace(',', '.');
                    txtSendedJ.Text = UtilConvert.ToString(wallet.CryptoCurrencySent).Replace(',', '.');
                    txtReceivedJ.Text = UtilConvert.ToString(wallet.CryptoCurrencyReceived).Replace(',', '.');
                }
            }
            else
            {
                new Alert("O cliente não possui uma carteira desta criptomoeda.", uiCSB.Toastr.Type.Warning);
            }
        }
    }
}
