namespace Blockchain.Control
{
    partial class uctBlockchain
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPanelControl = new uiCSB.Component.uiPanel();
            this.lblDescControl = new System.Windows.Forms.Label();
            this.lblTextControl = new System.Windows.Forms.Label();
            this.picImageControl = new System.Windows.Forms.PictureBox();
            this.uiPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageControl)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanelControl
            // 
            this.uiPanelControl.Controls.Add(this.lblDescControl);
            this.uiPanelControl.Controls.Add(this.lblTextControl);
            this.uiPanelControl.Controls.Add(this.picImageControl);
            this.uiPanelControl.Location = new System.Drawing.Point(0, 0);
            this.uiPanelControl.Name = "uiPanelControl";
            this.uiPanelControl.Size = new System.Drawing.Size(834, 125);
            this.uiPanelControl.TabIndex = 4;
            // 
            // lblDescControl
            // 
            this.lblDescControl.AutoSize = true;
            this.lblDescControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblDescControl.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.lblDescControl.Location = new System.Drawing.Point(146, 50);
            this.lblDescControl.Name = "lblDescControl";
            this.lblDescControl.Size = new System.Drawing.Size(503, 19);
            this.lblDescControl.TabIndex = 6;
            this.lblDescControl.Text = "Validar se todas as operações realizadas de carteira a carteira são reais.";
            // 
            // lblTextControl
            // 
            this.lblTextControl.AutoSize = true;
            this.lblTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTextControl.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(63)))), ((int)(((byte)(153)))));
            this.lblTextControl.Location = new System.Drawing.Point(140, 11);
            this.lblTextControl.Name = "lblTextControl";
            this.lblTextControl.Size = new System.Drawing.Size(210, 35);
            this.lblTextControl.TabIndex = 5;
            this.lblTextControl.Text = "Validar Blocos";
            // 
            // picImageControl
            // 
            this.picImageControl.BackColor = System.Drawing.Color.Transparent;
            this.picImageControl.Image = global::Blockchain.Properties.Resources.verific;
            this.picImageControl.Location = new System.Drawing.Point(17, 11);
            this.picImageControl.Name = "picImageControl";
            this.picImageControl.Size = new System.Drawing.Size(108, 103);
            this.picImageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageControl.TabIndex = 4;
            this.picImageControl.TabStop = false;
            // 
            // uctBlockchain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiPanelControl);
            this.Name = "uctBlockchain";
            this.Size = new System.Drawing.Size(834, 568);
            this.uiPanelControl.ResumeLayout(false);
            this.uiPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private uiCSB.Component.uiPanel uiPanelControl;
        private System.Windows.Forms.Label lblDescControl;
        private System.Windows.Forms.Label lblTextControl;
        private System.Windows.Forms.PictureBox picImageControl;
    }
}
