using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using caiosb.Util.Data;
using Etherchain.Common;
using uiCSB.Component;

namespace Etherchain.Desktop
{
    class UtilCorreios
    {

        // ---- ENDERECO
        public static void addUFs(ComboBox cbo)
        {
            cbo.Items.AddRange(new String[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
        }

        public static void Disable(System.Windows.Forms.Control control)
        {
            Enabled(control, false);
        }

        public static void Enable(System.Windows.Forms.Control control)
        {
            Enabled(control, true);
        }

        private static void Enabled(System.Windows.Forms.Control control, bool enabled)
        {
            if (control.Controls.Count > 0)
            {
                foreach (System.Windows.Forms.Control ctl in control.Controls)
                {
                    Enabled(ctl, enabled);
                }
            }
            else if (!(control is Label || control is Button))
            {
                control.Enabled = enabled;
            }
        }

        public static void definirCEP(uiTextBox mtbCEP, System.Windows.Forms.Control ctlLogradouro, System.Windows.Forms.Control ctlBairro, System.Windows.Forms.Control ctlCidade, System.Windows.Forms.Control cboUF, System.Windows.Forms.Control ctlNr, System.Windows.Forms.Control ctlComplemento)
        {
            Disable(ctlLogradouro);
            Disable(ctlBairro);
            Disable(ctlCidade);
            Disable(cboUF);

            //addUFs(cboUF);
            mtbCEP.Validated += (object sender, EventArgs e) =>
            {
                if (UtilValidar.validarCEP(mtbCEP.Text))
                {
                    UtilCorreios.definirEndereco(mtbCEP.Text, ctlLogradouro, ctlBairro, ctlCidade, cboUF, ctlNr, ctlComplemento);
                }
            };
        }

        public static void definirEndereco(String cep, System.Windows.Forms.Control ctlLogradouro, System.Windows.Forms.Control ctlBairro, System.Windows.Forms.Control ctlCidade, System.Windows.Forms.Control cboUF, System.Windows.Forms.Control ctlNr, System.Windows.Forms.Control ctlComplemento)
        {
            if (UtilValidar.validarCEP(cep))
            {
                Cursor.Current = Cursors.WaitCursor;
                Endereco objEndereco = Endereco.obterEndereco(cep);
                if (objEndereco != null)
                {
                    Disable(ctlLogradouro);
                    Disable(ctlBairro);
                    Disable(ctlCidade);
                    Disable(cboUF);

                    ctlLogradouro.Text = objEndereco.Logradouro;
                    ctlBairro.Text = objEndereco.Bairro;
                    ctlCidade.Text = objEndereco.Localidade;
                    cboUF.Text = objEndereco.UF;
                    ctlComplemento.Text = objEndereco.Complemento;
                    ctlNr.Focus();
                }
                else
                {
                    Enable(ctlLogradouro);
                    Enable(ctlBairro);
                    Enable(ctlCidade);
                    Enable(cboUF);

                    ctlLogradouro.Focus();
                }
                Cursor.Current = Cursors.Default;
            }
        }

        // ---- ENDERECO

        public static String obterConteudo(System.Windows.Forms.Control control)
        {
            String conteudo = control.Text;
            if (control is MaskedTextBox mtb)
            {
                MaskFormat oldFormat = mtb.TextMaskFormat;
                String oldText = mtb.Text;
                mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                conteudo = mtb.Text;
                mtb.Text = oldText;
                mtb.TextMaskFormat = oldFormat;
            }
            return conteudo;
        }
    }
}
