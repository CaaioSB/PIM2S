namespace Etherchain.Formularios
{
    partial class frmBase
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.uiMinimize = new uiCSB.Component.uiPicture();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.uctExecutive = new Etherchain.Control.Executive.uctExecutive();
            this.uctBackup = new Etherchain.Control.Executive.uctBackup();
            this.uctSettings = new Etherchain.Control.uctSettings();
            this.uctClientes = new Etherchain.Control.uctClientes();
            this.uctSupport = new Etherchain.Control.uctSupport();
            this.uctBase = new Etherchain.Control.uctBase();
            this.iconPicture2 = new uiCSB.Component.uiPicture();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.picProfilePhoto = new System.Windows.Forms.PictureBox();
            this.btnExecutive = new uiCSB.Component.uiPicture();
            this.btnBackup = new uiCSB.Component.uiPicture();
            this.btnSupport = new uiCSB.Component.uiPicture();
            this.btnConfig = new uiCSB.Component.uiPicture();
            this.btnExit = new uiCSB.Component.uiPicture();
            this.btnClientes = new uiCSB.Component.uiPicture();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMinimize)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecutive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.uiMinimize);
            this.pnlBackground.Controls.Add(this.pnlConteudo);
            this.pnlBackground.Controls.Add(this.iconPicture2);
            this.pnlBackground.Controls.Add(this.iconPictureBox2);
            this.pnlBackground.Location = new System.Drawing.Point(83, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(867, 651);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // uiMinimize
            // 
            this.uiMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.uiMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiMinimize.BackColor = System.Drawing.Color.DodgerBlue;
            this.uiMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uiMinimize.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.uiMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.uiMinimize.IconColor = System.Drawing.Color.White;
            this.uiMinimize.IconSize = 27;
            this.uiMinimize.Location = new System.Drawing.Point(825, 12);
            this.uiMinimize.Name = "uiMinimize";
            this.uiMinimize.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.uiMinimize.Rounded = true;
            this.uiMinimize.Size = new System.Drawing.Size(30, 27);
            this.uiMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uiMinimize.TabIndex = 4;
            this.uiMinimize.TabStop = false;
            this.uiMinimize.uiSize = 10;
            this.uiMinimize.UseGdi = true;
            this.uiMinimize.Click += new System.EventHandler(this.uiMinimize_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.uctExecutive);
            this.pnlConteudo.Controls.Add(this.uctBackup);
            this.pnlConteudo.Controls.Add(this.uctSettings);
            this.pnlConteudo.Controls.Add(this.uctClientes);
            this.pnlConteudo.Controls.Add(this.uctSupport);
            this.pnlConteudo.Controls.Add(this.uctBase);
            this.pnlConteudo.Location = new System.Drawing.Point(16, 61);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(839, 578);
            this.pnlConteudo.TabIndex = 6;
            // 
            // uctExecutive
            // 
            this.uctExecutive.BackColor = System.Drawing.Color.White;
            this.uctExecutive.Location = new System.Drawing.Point(0, 247);
            this.uctExecutive.Name = "uctExecutive";
            this.uctExecutive.Size = new System.Drawing.Size(834, 568);
            this.uctExecutive.TabIndex = 11;
            // 
            // uctBackup
            // 
            this.uctBackup.BackColor = System.Drawing.Color.White;
            this.uctBackup.Location = new System.Drawing.Point(444, 123);
            this.uctBackup.Name = "uctBackup";
            this.uctBackup.Size = new System.Drawing.Size(834, 568);
            this.uctBackup.TabIndex = 10;
            // 
            // uctSettings
            // 
            this.uctSettings.BackColor = System.Drawing.Color.White;
            this.uctSettings.Location = new System.Drawing.Point(0, 123);
            this.uctSettings.Name = "uctSettings";
            this.uctSettings.Size = new System.Drawing.Size(834, 568);
            this.uctSettings.TabIndex = 9;
            // 
            // uctClientes
            // 
            this.uctClientes.BackColor = System.Drawing.Color.White;
            this.uctClientes.Location = new System.Drawing.Point(444, 0);
            this.uctClientes.Name = "uctClientes";
            this.uctClientes.Size = new System.Drawing.Size(834, 568);
            this.uctClientes.TabIndex = 8;
            // 
            // uctSupport
            // 
            this.uctSupport.BackColor = System.Drawing.Color.White;
            this.uctSupport.Location = new System.Drawing.Point(0, 0);
            this.uctSupport.Name = "uctSupport";
            this.uctSupport.Size = new System.Drawing.Size(834, 568);
            this.uctSupport.TabIndex = 7;
            // 
            // uctBase
            // 
            this.uctBase.BackColor = System.Drawing.Color.White;
            this.uctBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uctBase.BackgroundImage")));
            this.uctBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uctBase.Location = new System.Drawing.Point(5, 23);
            this.uctBase.Name = "uctBase";
            this.uctBase.Size = new System.Drawing.Size(834, 568);
            this.uctBase.TabIndex = 6;
            // 
            // iconPicture2
            // 
            this.iconPicture2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconPicture2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPicture2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.iconPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPicture2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.iconPicture2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPicture2.IconColor = System.Drawing.Color.White;
            this.iconPicture2.IconSize = 27;
            this.iconPicture2.Location = new System.Drawing.Point(789, 12);
            this.iconPicture2.Name = "iconPicture2";
            this.iconPicture2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.iconPicture2.Rounded = true;
            this.iconPicture2.Size = new System.Drawing.Size(30, 27);
            this.iconPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicture2.TabIndex = 4;
            this.iconPicture2.TabStop = false;
            this.iconPicture2.uiSize = 10;
            this.iconPicture2.UseGdi = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.Location = new System.Drawing.Point(16, 18);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 1;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoEllipsis = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(5, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProfilePhoto
            // 
            this.picProfilePhoto.Image = global::Etherchain.Properties.Resources.male;
            this.picProfilePhoto.Location = new System.Drawing.Point(11, 12);
            this.picProfilePhoto.Name = "picProfilePhoto";
            this.picProfilePhoto.Size = new System.Drawing.Size(60, 60);
            this.picProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePhoto.TabIndex = 3;
            this.picProfilePhoto.TabStop = false;
            this.picProfilePhoto.Click += new System.EventHandler(this.picProfilePhoto_Click);
            // 
            // btnExecutive
            // 
            this.btnExecutive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExecutive.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExecutive.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnExecutive.IconColor = System.Drawing.Color.White;
            this.btnExecutive.IconSize = 40;
            this.btnExecutive.Location = new System.Drawing.Point(0, 452);
            this.btnExecutive.Name = "btnExecutive";
            this.btnExecutive.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnExecutive.Rounded = false;
            this.btnExecutive.Size = new System.Drawing.Size(82, 71);
            this.btnExecutive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExecutive.TabIndex = 8;
            this.btnExecutive.TabStop = false;
            this.btnExecutive.uiSize = 40;
            this.btnExecutive.Click += new System.EventHandler(this.btnExecutive_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnBackup.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnBackup.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.btnBackup.IconColor = System.Drawing.Color.White;
            this.btnBackup.IconSize = 40;
            this.btnBackup.Location = new System.Drawing.Point(0, 376);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnBackup.Rounded = false;
            this.btnBackup.Size = new System.Drawing.Size(82, 71);
            this.btnBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBackup.TabIndex = 7;
            this.btnBackup.TabStop = false;
            this.btnBackup.uiSize = 40;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnSupport.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnSupport.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnSupport.IconColor = System.Drawing.Color.White;
            this.btnSupport.IconSize = 40;
            this.btnSupport.Location = new System.Drawing.Point(0, 222);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnSupport.Rounded = false;
            this.btnSupport.Size = new System.Drawing.Size(82, 71);
            this.btnSupport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSupport.TabIndex = 6;
            this.btnSupport.TabStop = false;
            this.btnSupport.uiSize = 40;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnConfig.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfig.IconColor = System.Drawing.Color.White;
            this.btnConfig.IconSize = 40;
            this.btnConfig.Location = new System.Drawing.Point(0, 299);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnConfig.Rounded = false;
            this.btnConfig.Size = new System.Drawing.Size(82, 71);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnConfig.TabIndex = 5;
            this.btnConfig.TabStop = false;
            this.btnConfig.uiSize = 40;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 82;
            this.btnExit.Location = new System.Drawing.Point(0, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnExit.Rounded = false;
            this.btnExit.Size = new System.Drawing.Size(83, 82);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.uiSize = 40;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnClientes.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconSize = 40;
            this.btnClientes.Location = new System.Drawing.Point(0, 145);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnClientes.Rounded = false;
            this.btnClientes.Size = new System.Drawing.Size(82, 71);
            this.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClientes.TabIndex = 2;
            this.btnClientes.TabStop = false;
            this.btnClientes.uiSize = 40;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnExecutive);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picProfilePhoto);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiMinimize)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExecutive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox picProfilePhoto;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private uiCSB.Component.uiPicture btnClientes;
        private uiCSB.Component.uiPicture iconPicture2;
        private uiCSB.Component.uiPicture btnExit;
        private Control.uctBase uctBase;
        public System.Windows.Forms.Panel pnlConteudo;
        private uiCSB.Component.uiPicture uiMinimize;
        private uiCSB.Component.uiPicture btnConfig;
        private uiCSB.Component.uiPicture btnSupport;
        private Control.uctSupport uctSupport;
        private Control.uctClientes uctClientes;
        private Control.uctSettings uctSettings;
        private uiCSB.Component.uiPicture btnBackup;
        private uiCSB.Component.uiPicture btnExecutive;
        private Control.Executive.uctBackup uctBackup;
        private Control.Executive.uctExecutive uctExecutive;
    }
}

