namespace Etherchain.Socket
{
    partial class frmServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDados = new System.Windows.Forms.TextBox();
            this.uiPanelControl = new uiCSB.Component.uiPanel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.uiTxtPorta = new uiCSB.Component.uiTextBox();
            this.uiTxtIP = new uiCSB.Component.uiTextBox();
            this.btnAdmin = new uiCSB.Component.uiButton();
            this.lblDescControl = new System.Windows.Forms.Label();
            this.lblTextControl = new System.Windows.Forms.Label();
            this.picImageControl = new System.Windows.Forms.PictureBox();
            this.uiBtnLigarServidor = new uiCSB.Component.uiButton();
            this.uiPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageControl)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDados
            // 
            this.txtDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.txtDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDados.Enabled = false;
            this.txtDados.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDados.Location = new System.Drawing.Point(0, 123);
            this.txtDados.Margin = new System.Windows.Forms.Padding(10);
            this.txtDados.Multiline = true;
            this.txtDados.Name = "txtDados";
            this.txtDados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDados.Size = new System.Drawing.Size(569, 323);
            this.txtDados.TabIndex = 0;
            this.txtDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServer_KeyDown);
            // 
            // uiPanelControl
            // 
            this.uiPanelControl.Controls.Add(this.lblAviso);
            this.uiPanelControl.Controls.Add(this.uiTxtPorta);
            this.uiPanelControl.Controls.Add(this.uiTxtIP);
            this.uiPanelControl.Controls.Add(this.btnAdmin);
            this.uiPanelControl.Controls.Add(this.lblDescControl);
            this.uiPanelControl.Controls.Add(this.lblTextControl);
            this.uiPanelControl.Controls.Add(this.picImageControl);
            this.uiPanelControl.Draggable = true;
            this.uiPanelControl.Location = new System.Drawing.Point(-3, -3);
            this.uiPanelControl.Name = "uiPanelControl";
            this.uiPanelControl.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.uiPanelControl.PanelRadius = 5;
            this.uiPanelControl.Size = new System.Drawing.Size(577, 128);
            this.uiPanelControl.TabIndex = 6;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblAviso.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(143, 93);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(432, 14);
            this.lblAviso.TabIndex = 9;
            this.lblAviso.Text = "SOMENTE TROQUE AS INFORMAÇÕES COM CERTEZA DO QUE ESTÁ EXECUTANDO";
            this.lblAviso.Visible = false;
            // 
            // uiTxtPorta
            // 
            this.uiTxtPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiTxtPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxtPorta.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTxtPorta.ForeColor = System.Drawing.Color.White;
            this.uiTxtPorta.Location = new System.Drawing.Point(249, 74);
            this.uiTxtPorta.Name = "uiTxtPorta";
            this.uiTxtPorta.Size = new System.Drawing.Size(49, 20);
            this.uiTxtPorta.TabIndex = 8;
            this.uiTxtPorta.Text = "2020";
            this.uiTxtPorta.ValidadeType = uiCSB.Component.uiTextBox.Validate.None;
            this.uiTxtPorta.Visible = false;
            // 
            // uiTxtIP
            // 
            this.uiTxtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiTxtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxtIP.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTxtIP.ForeColor = System.Drawing.Color.White;
            this.uiTxtIP.Location = new System.Drawing.Point(146, 74);
            this.uiTxtIP.Name = "uiTxtIP";
            this.uiTxtIP.Size = new System.Drawing.Size(98, 20);
            this.uiTxtIP.TabIndex = 7;
            this.uiTxtIP.Text = "127.0.0.1";
            this.uiTxtIP.ValidadeType = uiCSB.Component.uiTextBox.Validate.None;
            this.uiTxtIP.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderColor = System.Drawing.Color.White;
            this.btnAdmin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Location = new System.Drawing.Point(245, 21);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAdmin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.Size = new System.Drawing.Size(115, 23);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "ADMINISTRADOR";
            this.btnAdmin.TextColor = System.Drawing.Color.White;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            // 
            // lblDescControl
            // 
            this.lblDescControl.AutoSize = true;
            this.lblDescControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblDescControl.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.lblDescControl.Location = new System.Drawing.Point(143, 47);
            this.lblDescControl.Name = "lblDescControl";
            this.lblDescControl.Size = new System.Drawing.Size(305, 19);
            this.lblDescControl.TabIndex = 6;
            this.lblDescControl.Text = "Veja informações transmitidas pelo socket";
            // 
            // lblTextControl
            // 
            this.lblTextControl.AutoSize = true;
            this.lblTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTextControl.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(63)))), ((int)(((byte)(153)))));
            this.lblTextControl.Location = new System.Drawing.Point(140, 11);
            this.lblTextControl.Name = "lblTextControl";
            this.lblTextControl.Size = new System.Drawing.Size(103, 35);
            this.lblTextControl.TabIndex = 5;
            this.lblTextControl.Text = "Server";
            // 
            // picImageControl
            // 
            this.picImageControl.BackColor = System.Drawing.Color.Transparent;
            this.picImageControl.Image = global::Etherchain.Socket.Properties.Resources.server;
            this.picImageControl.Location = new System.Drawing.Point(15, 11);
            this.picImageControl.Name = "picImageControl";
            this.picImageControl.Size = new System.Drawing.Size(119, 103);
            this.picImageControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageControl.TabIndex = 4;
            this.picImageControl.TabStop = false;
            // 
            // uiBtnLigarServidor
            // 
            this.uiBtnLigarServidor.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnLigarServidor.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnLigarServidor.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.uiBtnLigarServidor.FlatAppearance.BorderSize = 0;
            this.uiBtnLigarServidor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnLigarServidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnLigarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnLigarServidor.Location = new System.Drawing.Point(-3, 445);
            this.uiBtnLigarServidor.Name = "uiBtnLigarServidor";
            this.uiBtnLigarServidor.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnLigarServidor.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.uiBtnLigarServidor.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnLigarServidor.Size = new System.Drawing.Size(581, 39);
            this.uiBtnLigarServidor.TabIndex = 5;
            this.uiBtnLigarServidor.Text = "LIGAR SERVIDOR";
            this.uiBtnLigarServidor.TextColor = System.Drawing.Color.White;
            this.uiBtnLigarServidor.UseVisualStyleBackColor = false;
            this.uiBtnLigarServidor.Click += new System.EventHandler(this.uiBtnLigarServidor_Click);
            this.uiBtnLigarServidor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServer_KeyDown);
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 481);
            this.Controls.Add(this.uiPanelControl);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.uiBtnLigarServidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Servidor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServer_KeyDown);
            this.uiPanelControl.ResumeLayout(false);
            this.uiPanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDados;
        private uiCSB.Component.uiButton uiBtnLigarServidor;
        private uiCSB.Component.uiPanel uiPanelControl;
        private System.Windows.Forms.Label lblDescControl;
        private System.Windows.Forms.Label lblTextControl;
        private System.Windows.Forms.PictureBox picImageControl;
        private uiCSB.Component.uiButton btnAdmin;
        private uiCSB.Component.uiTextBox uiTxtIP;
        private uiCSB.Component.uiTextBox uiTxtPorta;
        private System.Windows.Forms.Label lblAviso;
    }
}

