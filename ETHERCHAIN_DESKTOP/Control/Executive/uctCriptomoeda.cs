using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etherchain.Common;
using caiosb.Util;
using caiosb.Util.Data;
using uiCSB.Toastr;

namespace Etherchain.Desktop.Control.Executive
{
    public partial class uctCriptomoeda : UserControl
    {
        private bool newImage;

        public uctCriptomoeda()
        {
            InitializeComponent();
            btnAtualizar.Visible = false;
        }

        private void uctCriptomoeda_Load(object sender, EventArgs e)
        {
            ObterCriptomoedas();
        }

        private void ObterCriptomoedas()
        {
            List<Cryptocurency> cryptocurencies = new Cryptocurency { }.ObterTodos();

            for (int i = 0; i < uiFlowPanel.Controls.Count; i++)
            {
                uiFlowPanel.Controls.RemoveAt(i);
            }

            UtilCreatePanel.CreateCryptocurrencyPanel(cryptocurencies, uiFlowPanel, Cryptocurrency_Click);
        }

        private void Cryptocurrency_Click(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = sender as Panel;
                PreencheDadosCryptocurrency(new Cryptocurency { CryptocurrencyId = UtilConvert.ToInt(panel.Tag) }.ObterPorId());
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                PreencheDadosCryptocurrency(new Cryptocurency { CryptocurrencyId = UtilConvert.ToInt(label.Tag) }.ObterPorId());
            }
            else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                PreencheDadosCryptocurrency(new Cryptocurency { CryptocurrencyId = UtilConvert.ToInt(pictureBox.Tag) }.ObterPorId());
            }
        }

        public void PreencheDadosCryptocurrency(Cryptocurency cryptocurency)
        {
            newImage = false;

            picCriptocurrency.Image = UtilImage.ByteToImage(new Archive { ArchiveId = cryptocurency.ArchiveId }.ObterPorCod().Blob);
            lblCryptocurrencyId.Text = UtilConvert.ToString(cryptocurency.CryptocurrencyId);
            lblArchiveId.Text = UtilConvert.ToString(cryptocurency.ArchiveId);
            uiTxtCriptocurrency.Text = UtilConvert.ToString(cryptocurency.Name);
            uiTxtCryptocurrencyBalance.Text = UtilConvert.ToString(cryptocurency.CryptocurrencyBalance);
            uiTxtCryptocurrencyUnit.Text = UtilConvert.ToString(cryptocurency.CryptocurrencyUnit);
            uiTxtDescription.Text = UtilConvert.ToString(cryptocurency.Description);
            uiTxtCryptocurrencyBase.Text = UtilConvert.ToString(cryptocurency.Base);
            uiTxtCryptocurrencyBalance.ReadOnly = true;
            uiTxtCryptocurrencyUnit.ReadOnly = true;

            btnCriar.Visible = false;
            btnAtualizar.Visible = true;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UtilValidar.CamposValidos(uiPanelCryptocurrency))
                {
                    if (newImage)
                    {
                        int archiveId = new Archive
                        {
                            Blob = UtilImage.ImageToByte(picCriptocurrency.Image),
                        }.Gravar();

                        int response = new Cryptocurency
                        {
                            ArchiveId = archiveId,
                            Name = uiTxtCriptocurrency.Text,
                            Base = uiTxtCryptocurrencyBase.Text,
                            Description = uiTxtDescription.Text,
                            CryptocurrencyBalance = UtilConvert.ToInt(uiTxtCryptocurrencyBalance.Text),
                            CryptocurrencyUnit = uiTxtCryptocurrencyUnit.Text
                        }.Gravar();

                        new Alert(String.Format("A criptomoeda {0} foi cadastrada.", uiTxtCriptocurrency.Text), uiCSB.Toastr.Type.Info);
                        newImage = false;
                    }
                    else
                    {
                        int response = new Cryptocurency
                        {
                            ArchiveId = 1,
                            Name = uiTxtCriptocurrency.Text,
                            Base = uiTxtCryptocurrencyBase.Text,
                            Description = uiTxtDescription.Text,
                            CryptocurrencyBalance = UtilConvert.ToInt(uiTxtCryptocurrencyBalance.Text),
                            CryptocurrencyUnit = uiTxtCryptocurrencyUnit.Text
                        }.Gravar();

                        new Alert(String.Format("A criptomoeda {0} foi cadastrada.", uiTxtCriptocurrency.Text), uiCSB.Toastr.Type.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Warning);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Escolha a imagem da criptomoeda";
                dlg.Filter = "(*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picCriptocurrency.Image = new Bitmap(dlg.FileName);
                    newImage = true;
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (UtilValidar.CamposValidos(uiPanelCryptocurrency))
                {
                    if (newImage)
                    {
                        int archiveId = new Archive
                        {
                            Blob = UtilImage.ImageToByte(picCriptocurrency.Image),
                        }.Gravar();

                        bool updated = new Cryptocurency
                        {
                            ArchiveId = archiveId,
                            Name = uiTxtCriptocurrency.Text,
                            Base = uiTxtCryptocurrencyBase.Text,
                            Description = uiTxtDescription.Text,
                            CryptocurrencyBalance = UtilConvert.ToInt(uiTxtCryptocurrencyBalance.Text),
                            CryptocurrencyUnit = uiTxtCryptocurrencyUnit.Text
                        }.AlterarPorId();

                        if (updated)
                        {
                            new Alert(String.Format("A criptomoeda {0} foi cadastrada.", uiTxtCriptocurrency.Text), uiCSB.Toastr.Type.Info);
                            newImage = false;
                        }
                        else
                        {
                            new Alert(String.Format("A criptomoeda {0} não foi cadastrada. Tente novamente mais tarde.", uiTxtCriptocurrency.Text), uiCSB.Toastr.Type.Warning);
                            newImage = true;
                        }
                    }
                    else
                    {
                        bool response = new Cryptocurency
                        {
                            ArchiveId = UtilConvert.ToInt(lblArchiveId.Text),
                            Name = uiTxtCriptocurrency.Text,
                            Base = uiTxtCryptocurrencyBase.Text,
                            Description = uiTxtDescription.Text,
                            CryptocurrencyBalance = UtilConvert.ToInt(uiTxtCryptocurrencyBalance.Text),
                            CryptocurrencyUnit = uiTxtCryptocurrencyUnit.Text
                        }.AlterarPorId();

                        new Alert(String.Format("A criptomoeda {0} foi cadastrada.", uiTxtCriptocurrency.Text), uiCSB.Toastr.Type.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Warning);
            }
            finally
            {
                ObterCriptomoedas();
            }
        }
    }
}
