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
            this.uctClientes = new Etherchain.Control.uctClientes();
            this.uctSupport = new Etherchain.Control.uctSupport();
            this.uctBase = new Etherchain.Control.uctBase();
            this.iconPicture2 = new uiCSB.Component.uiPicture();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picProfilePhoto = new System.Windows.Forms.PictureBox();
            this.btnExit = new uiCSB.Component.uiPicture();
            this.btnClientes = new uiCSB.Component.uiPicture();
            this.btnConfig = new uiCSB.Component.uiPicture();
            this.btnSupport = new uiCSB.Component.uiPicture();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiMinimize)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupport)).BeginInit();
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
            this.pnlConteudo.Controls.Add(this.uctClientes);
            this.pnlConteudo.Controls.Add(this.uctSupport);
            this.pnlConteudo.Controls.Add(this.uctBase);
            this.pnlConteudo.Location = new System.Drawing.Point(16, 61);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(839, 578);
            this.pnlConteudo.TabIndex = 6;
            // 
            // uctClientes
            // 
            this.uctClientes.BackColor = System.Drawing.Color.White;
            this.uctClientes.Location = new System.Drawing.Point(47, 58);
            this.uctClientes.Name = "uctClientes";
            this.uctClientes.Size = new System.Drawing.Size(834, 568);
            this.uctClientes.TabIndex = 8;
            // 
            // uctSupport
            // 
            this.uctSupport.BackColor = System.Drawing.Color.White;
            this.uctSupport.Location = new System.Drawing.Point(14, 34);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caio Silva";
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExit.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 40;
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
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picProfilePhoto);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label label1;
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
    }
}

