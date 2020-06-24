using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using Etherchain.Desktop;
using Etherchain.Common;
using caiosb.Util;
using uiCSB.Component;
using caiosb.Util.Data;
using Etherchain.Desktop.Control;
using System.IO;
using System.Threading;
using uiCSB.Toastr;
using Newtonsoft.Json;

namespace Etherchain.Control
{
    public partial class uctSupport : UserControl
    {
        //static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        private Support Support;
        private List<SupportMessage> supportMessages = new List<SupportMessage>();

        // Trata o nome do usuário
        private string NomeUsuario = "Desconhecido";
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        // Necessário para atualizar o formulário com mensagens da outra thread
        private delegate void AtualizaLogCallBack(string strMensagem);
        // Necessário para definir o formulário para o estado "disconnected" de outra thread
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private bool Conectado = false;

        public uctSupport()
        {
            InitializeComponent();
            Disposed += OnDispose;

            if (Conectado == false)
            {
                // Inicializa a conexão
                InicializaConexao();
            }
            else // Se esta conectado entao desconecta
            {
                FechaConexao("Desconectado a pedido do usuário.");
                InicializaConexao();
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            BuscarMensagens(Support);
        }

        private void uctSupport_Load(object sender, EventArgs e)
        {
            List<Support> supports = new Support { }.ObterTodos();
            UtilCreatePanel.CreateSupportPanel(supports, uiFlowPanel, support_Click);
        }

        private void support_Click(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                RemoverMensagens();
                PreencheHeader(new Support { SupportId = UtilConvert.ToInt(panel.Tag) }.ObterPorId());
                BuscarMensagens(new Support { SupportId = UtilConvert.ToInt(panel.Tag) }.ObterPorId());
                uiFlowPanelChat.AutoScroll = true;
                uiFlowPanelChat.HorizontalScroll.Enabled = false;
                uiFlowPanelChat.HorizontalScroll.Visible = false;
                HabilitarChat();

                Support = new Support { SupportId = UtilConvert.ToInt(panel.Tag) }.ObterPorId();
            }
            else if (sender is Label)
            {

                Label label = sender as Label;
                RemoverMensagens();
                PreencheHeader(new Support { SupportId = UtilConvert.ToInt(label.Tag) }.ObterPorId());
                BuscarMensagens(new Support { SupportId = UtilConvert.ToInt(label.Tag) }.ObterPorId());
                uiFlowPanelChat.AutoScroll = true;
                uiFlowPanelChat.HorizontalScroll.Enabled = false;
                uiFlowPanelChat.HorizontalScroll.Visible = false;
                HabilitarChat();

                Support = new Support { SupportId = UtilConvert.ToInt(label.Tag) }.ObterPorId();
            }
        }

        private void InicializaConexao()
        {
            try
            {
                // Trata o endereço IP informado em um objeto IPAdress
                enderecoIP = IPAddress.Parse("127.0.0.1");
                // Inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, Convert.ToInt32("2020"));

                // AJuda a verificar se estamos conectados ou não
                Conectado = true;

                // Prepara o formulário
                NomeUsuario = AppDesktop.ActualEmployee.FirstName + " " + AppDesktop.ActualEmployee.LastName;

                // Envia o nome do usuário ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(String.Format("O suporte {0} {1} dado ID {2}", AppDesktop.ActualEmployee.FirstName, AppDesktop.ActualEmployee.LastName, AppDesktop.ActualEmployee.EmployeeId));
                stwEnviador.Flush();

                //Inicia a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.Start();
            }
            catch (Exception ex)
            {
                new Alert("Erro: Erro na conexão com o servidor de suporte. " + ex.Message, uiCSB.Toastr.Type.Error);
                //MessageBox.Show("Erro : " + ex.Message, "Erro na conexão com servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RecebeMensagens()
        {
            // recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();
            // Se o primeiro caracater da resposta é 1 a conexão foi feita com sucesso
            if (ConResposta[0] == '1')
            {
                // Atualiza o formulário para informar que esta conectado
                new Alert("Você se conectou ao servidor de suporte.", uiCSB.Toastr.Type.Success);
                //this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else // Se o primeiro caractere não for 1 a conexão falhou
            {
                //string Motivo = "Não Conectado: ";
                // Extrai o motivo da mensagem resposta. O motivo começa no 3o caractere
                //Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                // Atualiza o formulário como o motivo da falha na conexão
                //this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { Motivo });
                // Sai do método
                new Alert("Um erro desconhecido impossibilitou-o de se conectar com o servidor.", uiCSB.Toastr.Type.Error);
                return;
            }

            // Enquanto estiver conectado le as linhas que estão chegando do servidor
            while (Conectado)
            {
                // exibe mensagems no Textbox
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }
        }

        private void AtualizaLog(string mensagemJson)
        {
            try
            {
                if (!mensagemJson.StartsWith(Support.CustomerId + " disse") || !mensagemJson.StartsWith("#"))
                {
                    SupportMessage supportMessage = new SupportMessage();

                    supportMessage = JsonConvert.DeserializeObject<SupportMessage>(mensagemJson);


                    if (supportMessage.Method == Method.RECEIVED)
                    {
                        if (supportMessage.SupportId == Support.SupportId)
                        {
                            if (supportMessage.EmployeeId == AppDesktop.ActualEmployee.EmployeeId)
                            {
                                InserirMensagemRecebida(supportMessage);
                            }
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                if (!mensagemJson.StartsWith("#"))
                {
                    new Alert("Houve um problema ao requerer uma informação do servidor.", uiCSB.Toastr.Type.Warning);
                }
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Warning);
            }
            //txtLog.AppendText(strMensagem + "\r\n");
        }

        // Fecha a conexão com o servidor
        private void FechaConexao(string Motivo)
        {
            // Mostra o motivo porque a conexão encerrou
            //txtLog.AppendText(Motivo + "\r\n");
            // Habilita e desabilita os controles apropriados no formulario
            //txtServidorIP.Enabled = true;
            //txtUsuario.Enabled = true;
            //txtMensagem.Enabled = false;
            //btnEnviar.Enabled = false;
            //btnConectar.Text = "Conectado";

            // Fecha os objetos
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();
        }

        private void BuscarMensagens(Support support)
        {
            List<SupportMessage> supportMessage = new SupportMessage { SupportId = support.SupportId }.ObterPorId();

            if (supportMessage.Count != supportMessages.Count)
            {
                RemoverMensagens();
                supportMessages = supportMessage;
                foreach (SupportMessage message in supportMessage)
                {
                    switch (message.Method)
                    {
                        case Method.RECEIVED:
                            InserirMensagemRecebida(message);
                            break;
                        case Method.SENTED:
                            InserirMensagemEnviada(message);
                            break;
                    }
                }
            }

            //myTimer.Enabled = true;
        }

        private void InserirMensagemEnviada(SupportMessage message)
        {
            Label lblSented = new Label();
            lblSented.AllowDrop = true;
            lblSented.AutoSize = true;
            lblSented.BackColor = System.Drawing.Color.SteelBlue;
            lblSented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblSented.ForeColor = System.Drawing.Color.White;
            lblSented.Location = new System.Drawing.Point(99, 100);
            lblSented.Margin = new System.Windows.Forms.Padding(99, 5, 10, 1);
            lblSented.MinimumSize = new System.Drawing.Size(455, 0);
            lblSented.Name = "lblSented";
            lblSented.Padding = new System.Windows.Forms.Padding(5);
            lblSented.Size = new System.Drawing.Size(455, 36);
            lblSented.TabIndex = 1;
            lblSented.Text = message.Message;

            uiFlowPanelChat.Controls.Add(lblSented);


            lblSented.Invalidate();
        }

        private void InserirMensagemRecebida(SupportMessage message)
        {
            Label lblReceived = new Label();
            lblReceived.AllowDrop = true;
            lblReceived.AutoSize = true;
            lblReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(86)))), ((int)(((byte)(120)))));
            lblReceived.ForeColor = System.Drawing.Color.White;
            lblReceived.Location = new System.Drawing.Point(5, 142);
            lblReceived.Margin = new System.Windows.Forms.Padding(5, 5, 5, 1);
            lblReceived.MaximumSize = new System.Drawing.Size(455, 0);
            lblReceived.MinimumSize = new System.Drawing.Size(455, 0);
            lblReceived.Name = "lblReceived";
            lblReceived.Padding = new System.Windows.Forms.Padding(5);
            lblReceived.Size = new System.Drawing.Size(455, 36);
            lblReceived.TabIndex = 5;
            lblReceived.Text = message.Message;

            uiFlowPanelChat.Controls.Add(lblReceived);
        }

        private void HabilitarChat()
        {
            txtMessage.Enabled = true;
            btnSend.Enabled = true;
        }

        private void PreencheHeader(Support support)
        {
            uiHeaderTitle.Text = support.Title;
            uiHeaderDescription.Text = support.Description;
        }
        private void RemoverMensagens()
        {
            uiPanel header = uiHeader;
            uiFlowPanelChat.Controls.Clear();
            uiFlowPanelChat.Controls.Add(header);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessage.Text))
            {
                SupportMessage supportMessage = new SupportMessage
                {
                    SupportId = Support.SupportId,
                    EmployeeId = AppDesktop.ActualEmployee.EmployeeId,
                    CustomerId = Support.CustomerId,
                    Message = txtMessage.Text,
                    SentedAt = DateTime.Now,
                    Method = Method.SENTED
                };


                enviaMessagem(supportMessage);
                txtMessage.Text = null;
            }
        }

        private void enviaMessagem(SupportMessage message)
        {
            Label lblSented = new Label();
            lblSented.AllowDrop = true;
            lblSented.AutoSize = true;
            lblSented.BackColor = System.Drawing.Color.SteelBlue;
            lblSented.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblSented.ForeColor = System.Drawing.Color.White;
            lblSented.Location = new System.Drawing.Point(99, 100);
            lblSented.Margin = new System.Windows.Forms.Padding(99, 5, 10, 1);
            lblSented.MinimumSize = new System.Drawing.Size(455, 0);
            lblSented.Name = "lblSented";
            lblSented.Padding = new System.Windows.Forms.Padding(5);
            lblSented.Size = new System.Drawing.Size(455, 36);
            lblSented.TabIndex = 1;
            lblSented.Text = message.Message;

            uiFlowPanelChat.Controls.Add(lblSented);
            stwEnviador.WriteLine(JsonConvert.SerializeObject(message));
            stwEnviador.Flush();
        }

        private void uiFlowPanelChat_ControlAdded(object sender, ControlEventArgs e)
        {
            uiFlowPanelChat.ScrollControlIntoView(e.Control);
        }

        private void btnFinalizarAtendimento_Click(object sender, EventArgs e)
        {
        }

        private void uctSupport_VisibleChanged(object sender, EventArgs e)
        {
            uiFlowPanel.Controls.Clear();
            List<Support> supports = new Support { }.ObterTodos();
            UtilCreatePanel.CreateSupportPanel(supports, uiFlowPanel, support_Click);
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    SupportMessage supportMessage = new SupportMessage
                    {
                        SupportId = Support.SupportId,
                        EmployeeId = AppDesktop.ActualEmployee.EmployeeId,
                        CustomerId = Support.CustomerId,
                        Message = txtMessage.Text,
                        SentedAt = DateTime.Now,
                        Method = Method.SENTED
                    };


                    enviaMessagem(supportMessage);
                    txtMessage.Text = null;
                }
            }
        }
    }
}
