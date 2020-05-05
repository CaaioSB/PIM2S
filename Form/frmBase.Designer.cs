namespace Blockchain.Formularios
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
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.uctBase = new Blockchain.Control.uctBase();
            this.uctBlockchain = new Blockchain.Control.uctBlockchain();
            this.iconPicture2 = new uiCSB.Component.uiPicture();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picProfilePhoto = new System.Windows.Forms.PictureBox();
            this.btnExit = new uiCSB.Component.uiPicture();
            this.btnBlockchain = new uiCSB.Component.uiPicture();
            this.pnlBackground.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlockchain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.pnlConteudo);
            this.pnlBackground.Controls.Add(this.iconPicture2);
            this.pnlBackground.Controls.Add(this.iconPictureBox2);
            this.pnlBackground.Location = new System.Drawing.Point(83, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(867, 651);
            this.pnlBackground.TabIndex = 0;
            this.pnlBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.uctBase);
            this.pnlConteudo.Controls.Add(this.uctBlockchain);
            this.pnlConteudo.Location = new System.Drawing.Point(16, 61);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(839, 578);
            this.pnlConteudo.TabIndex = 6;
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
            // uctBlockchain
            // 
            this.uctBlockchain.BackColor = System.Drawing.Color.White;
            this.uctBlockchain.Location = new System.Drawing.Point(3, 3);
            this.uctBlockchain.Name = "uctBlockchain";
            this.uctBlockchain.Size = new System.Drawing.Size(834, 568);
            this.uctBlockchain.TabIndex = 5;
            this.uctBlockchain.Visible = false;
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
            this.iconPicture2.Location = new System.Drawing.Point(811, 12);
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
            this.picProfilePhoto.Image = global::Blockchain.Properties.Resources.male;
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
            // btnBlockchain
            // 
            this.btnBlockchain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnBlockchain.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.btnBlockchain.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btnBlockchain.IconColor = System.Drawing.Color.White;
            this.btnBlockchain.IconSize = 40;
            this.btnBlockchain.Location = new System.Drawing.Point(1, 187);
            this.btnBlockchain.Name = "btnBlockchain";
            this.btnBlockchain.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.btnBlockchain.Rounded = false;
            this.btnBlockchain.Size = new System.Drawing.Size(82, 71);
            this.btnBlockchain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBlockchain.TabIndex = 2;
            this.btnBlockchain.TabStop = false;
            this.btnBlockchain.uiSize = 40;
            this.btnBlockchain.Click += new System.EventHandler(this.btnBlockchain_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picProfilePhoto);
            this.Controls.Add(this.btnBlockchain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBackground.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlockchain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picProfilePhoto;

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private uiCSB.Component.uiPicture btnBlockchain;
        private uiCSB.Component.uiPicture iconPicture2;
        private Control.uctBlockchain uctBlockchain;
        private uiCSB.Component.uiPicture btnExit;
        private Control.uctBase uctBase;
        public System.Windows.Forms.Panel pnlConteudo;
    }
}

