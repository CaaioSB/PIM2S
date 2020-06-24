using System.Windows.Forms;
using System.Net;
using System;
using uiCSB.Util;
using System.Drawing;
using System.Runtime.InteropServices;
using Etherchain.Common;
using Newtonsoft.Json;

namespace Etherchain.Socket
{
    public partial class frmServer : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);
        ChatServidor mainServidor;


        public frmServer()
        {
            InitializeComponent();
            RoundedForm roundedForm = new RoundedForm(this);
        }

        private void uiBtnLigarServidor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uiTxtIP.Text) || string.IsNullOrEmpty(uiTxtPorta.Text))
            {
                MessageBox.Show("Informe o endereço IP.");
                uiTxtIP.Focus();
                return;
            }

            try
            {
                // Analisa o endereço IP do servidor informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(uiTxtIP.Text);

                // Cria uma nova instância do objeto ChatServidor
                mainServidor = new ChatServidor(enderecoIP, uiTxtPorta.Text);

                // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                // Inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                // Mostra que nos iniciamos o atendimento para conexões
                txtDados.AppendText("#O SERVIDOR FOI INICIADO.\r\n");

                uiBtnLigarServidor.ButtonColor = Color.Orange;
                uiBtnLigarServidor.Enabled = false;
                uiBtnLigarServidor.Text = "O SERVIDOR ESTÁ EM EXECUÇÃO";
                btnAdmin.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro na conexão: " + ex.Message);
                uiBtnLigarServidor.ButtonColor = Color.Red;
                uiBtnLigarServidor.Enabled = true;
                uiBtnLigarServidor.Text = "TENTAR NOVAMENTE...";
            }
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string messageJson)
        {
            try
            {
                // Instancia uma nova classe do tipo SupportMessage.
                SupportMessage supportMessage = new SupportMessage();

                // Converte o JSON para Objeto (SupportMessage).
                supportMessage = JsonConvert.DeserializeObject<SupportMessage>(messageJson);

                // Grava a mensagem no banco de dados.
                supportMessage.Gravar();
                
                // Appenda o JSON na lista de transmissão realizadas.
                txtDados.AppendText(messageJson + "\r\n");
            }
            catch
            {
                txtDados.AppendText(messageJson + "\r\n");
            }
        }

        private void frmServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                btnAdmin.Visible = true;
                lblAviso.Visible = true;
                uiTxtPorta.Visible = true;
                uiTxtIP.Visible = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //mainServidor.FinalizarServicos();
                Application.Exit();
            }
        }
    }
}
