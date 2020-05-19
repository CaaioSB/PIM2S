namespace ETHERCHAIN_INSTALLER
{
    partial class frmInstaller
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
            this.components = new System.ComponentModel.Container();
            this.uiPanel1 = new uiCSB.Component.uiPanel();
            this.lblDescControl = new System.Windows.Forms.Label();
            this.uiExit = new uiCSB.Component.uiButton();
            this.lblTextControl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiPanel10 = new uiCSB.Component.uiPanel();
            this.uiTextBox1 = new uiCSB.Component.uiTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uiButton1 = new uiCSB.Component.uiButton();
            this.uiButton2 = new uiCSB.Component.uiButton();
            this.uiButton3 = new uiCSB.Component.uiButton();
            this.progressBar = new uiCSB.Component.uiButton();
            this.timerInstall = new System.Windows.Forms.Timer(this.components);
            this.pnlBackground = new uiCSB.Component.uiPanel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel10.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.lblDescControl);
            this.uiPanel1.Controls.Add(this.uiExit);
            this.uiPanel1.Controls.Add(this.lblTextControl);
            this.uiPanel1.Controls.Add(this.pictureBox1);
            this.uiPanel1.Location = new System.Drawing.Point(7, 8);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.uiPanel1.PanelRadius = 5;
            this.uiPanel1.Size = new System.Drawing.Size(516, 100);
            this.uiPanel1.TabIndex = 0;
            // 
            // lblDescControl
            // 
            this.lblDescControl.AutoSize = true;
            this.lblDescControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblDescControl.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(182)))), ((int)(((byte)(194)))));
            this.lblDescControl.Location = new System.Drawing.Point(128, 41);
            this.lblDescControl.Name = "lblDescControl";
            this.lblDescControl.Size = new System.Drawing.Size(254, 19);
            this.lblDescControl.TabIndex = 11;
            this.lblDescControl.Text = "Instalar a aplicação no computador";
            // 
            // uiExit
            // 
            this.uiExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.uiExit.BorderColor = System.Drawing.Color.White;
            this.uiExit.ButtonColor = System.Drawing.Color.Red;
            this.uiExit.FlatAppearance.BorderSize = 0;
            this.uiExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiExit.Location = new System.Drawing.Point(471, 3);
            this.uiExit.Name = "uiExit";
            this.uiExit.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiExit.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.uiExit.OnHoverTextColor = System.Drawing.Color.White;
            this.uiExit.Size = new System.Drawing.Size(42, 28);
            this.uiExit.TabIndex = 13;
            this.uiExit.Text = "X";
            this.uiExit.TextColor = System.Drawing.Color.White;
            this.uiExit.UseVisualStyleBackColor = false;
            // 
            // lblTextControl
            // 
            this.lblTextControl.AutoSize = true;
            this.lblTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTextControl.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(63)))), ((int)(((byte)(153)))));
            this.lblTextControl.Location = new System.Drawing.Point(124, 6);
            this.lblTextControl.Name = "lblTextControl";
            this.lblTextControl.Size = new System.Drawing.Size(159, 35);
            this.lblTextControl.TabIndex = 10;
            this.lblTextControl.Text = "Etherchain";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ETHERCHAIN_INSTALLER.Properties.Resources.setup;
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uiPanel10
            // 
            this.uiPanel10.BackColor = System.Drawing.Color.Transparent;
            this.uiPanel10.Controls.Add(this.uiTextBox1);
            this.uiPanel10.Controls.Add(this.label14);
            this.uiPanel10.Location = new System.Drawing.Point(7, 123);
            this.uiPanel10.Name = "uiPanel10";
            this.uiPanel10.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.uiPanel10.PanelRadius = 5;
            this.uiPanel10.Size = new System.Drawing.Size(516, 55);
            this.uiPanel10.TabIndex = 14;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(141)))));
            this.uiTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTextBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTextBox1.ForeColor = System.Drawing.Color.White;
            this.uiTextBox1.Location = new System.Drawing.Point(5, 24);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(505, 26);
            this.uiTextBox1.TabIndex = 14;
            this.uiTextBox1.Text = "NKJFK-GPHP7-G8C3J-P6JXR-HQRJR";
            this.uiTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.label14.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(133, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(250, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "INSIRA A CHAVE DE INSTALAÇÃO";
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.White;
            this.uiButton1.BorderColor = System.Drawing.Color.White;
            this.uiButton1.ButtonColor = System.Drawing.Color.Silver;
            this.uiButton1.Enabled = false;
            this.uiButton1.FlatAppearance.BorderSize = 0;
            this.uiButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton1.Location = new System.Drawing.Point(9, 188);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiButton1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.uiButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.uiButton1.Size = new System.Drawing.Size(256, 45);
            this.uiButton1.TabIndex = 15;
            this.uiButton1.Text = "Etherchain";
            this.uiButton1.TextColor = System.Drawing.Color.White;
            this.uiButton1.UseVisualStyleBackColor = false;
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.Color.White;
            this.uiButton2.BorderColor = System.Drawing.Color.White;
            this.uiButton2.ButtonColor = System.Drawing.Color.Silver;
            this.uiButton2.Enabled = false;
            this.uiButton2.FlatAppearance.BorderSize = 0;
            this.uiButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton2.Location = new System.Drawing.Point(271, 186);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiButton2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.uiButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.uiButton2.Size = new System.Drawing.Size(255, 45);
            this.uiButton2.TabIndex = 16;
            this.uiButton2.Text = "Etherchain Executive";
            this.uiButton2.TextColor = System.Drawing.Color.White;
            this.uiButton2.UseVisualStyleBackColor = false;
            // 
            // uiButton3
            // 
            this.uiButton3.BackColor = System.Drawing.Color.White;
            this.uiButton3.BorderColor = System.Drawing.Color.White;
            this.uiButton3.ButtonColor = System.Drawing.Color.Lime;
            this.uiButton3.FlatAppearance.BorderSize = 0;
            this.uiButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton3.Location = new System.Drawing.Point(7, 237);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiButton3.OnHoverButtonColor = System.Drawing.Color.Green;
            this.uiButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.uiButton3.Size = new System.Drawing.Size(519, 45);
            this.uiButton3.TabIndex = 17;
            this.uiButton3.Text = "INSTALAR";
            this.uiButton3.TextColor = System.Drawing.Color.White;
            this.uiButton3.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.BorderColor = System.Drawing.Color.White;
            this.progressBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.progressBar.FlatAppearance.BorderSize = 0;
            this.progressBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.progressBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.progressBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.progressBar.Location = new System.Drawing.Point(7, 283);
            this.progressBar.Name = "progressBar";
            this.progressBar.OnHoverBorderColor = System.Drawing.Color.White;
            this.progressBar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(65)))), ((int)(((byte)(179)))));
            this.progressBar.OnHoverTextColor = System.Drawing.Color.White;
            this.progressBar.Size = new System.Drawing.Size(0, 30);
            this.progressBar.TabIndex = 18;
            this.progressBar.Text = "0%";
            this.progressBar.TextColor = System.Drawing.Color.White;
            this.progressBar.UseVisualStyleBackColor = true;
            // 
            // timerInstall
            // 
            this.timerInstall.Interval = 10;
            this.timerInstall.Tick += new System.EventHandler(this.timerInstall_Tick);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.White;
            this.pnlBackground.Controls.Add(this.uiButton3);
            this.pnlBackground.Controls.Add(this.progressBar);
            this.pnlBackground.Controls.Add(this.uiButton2);
            this.pnlBackground.Controls.Add(this.uiPanel10);
            this.pnlBackground.Controls.Add(this.uiPanel1);
            this.pnlBackground.Location = new System.Drawing.Point(2, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.PanelColor = System.Drawing.Color.White;
            this.pnlBackground.PanelRadius = 15;
            this.pnlBackground.Size = new System.Drawing.Size(536, 319);
            this.pnlBackground.TabIndex = 19;
            // 
            // frmInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(540, 323);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInstaller_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel10.ResumeLayout(false);
            this.uiPanel10.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private uiCSB.Component.uiPanel uiPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uiCSB.Component.uiButton uiExit;
        private System.Windows.Forms.Label lblTextControl;
        private System.Windows.Forms.Label lblDescControl;
        private uiCSB.Component.uiPanel uiPanel10;
        private uiCSB.Component.uiTextBox uiTextBox1;
        private System.Windows.Forms.Label label14;
        private uiCSB.Component.uiButton uiButton1;
        private uiCSB.Component.uiButton uiButton2;
        private uiCSB.Component.uiButton uiButton3;
        private uiCSB.Component.uiButton progressBar;
        private System.Windows.Forms.Timer timerInstall;
        private uiCSB.Component.uiPanel pnlBackground;
    }
}

