namespace GameLauncherReborn
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnticheatLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Panel();
            this.commingSoon1 = new GameLauncherReborn.Panels.CommingSoon();
            this.aModNetSettings1 = new GameLauncherReborn.Panels.AModNetSettings();
            this.startWindow1 = new GameLauncherReborn.Panels.StartWindow();
            this.DownloadBarWindow = new System.Windows.Forms.PictureBox();
            this.VinylManSettingsBtn = new System.Windows.Forms.PictureBox();
            this.AModNetSettingsBtn = new System.Windows.Forms.PictureBox();
            this.SettingsMenuBtn = new System.Windows.Forms.PictureBox();
            this.MainMenuBtn = new System.Windows.Forms.PictureBox();
            this.Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBarWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylManSettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AModNetSettingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsMenuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AnticheatLabel
            // 
            this.AnticheatLabel.BackColor = System.Drawing.Color.Black;
            this.AnticheatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnticheatLabel.ForeColor = System.Drawing.Color.White;
            this.AnticheatLabel.Location = new System.Drawing.Point(0, 470);
            this.AnticheatLabel.Name = "AnticheatLabel";
            this.AnticheatLabel.Size = new System.Drawing.Size(820, 30);
            this.AnticheatLabel.TabIndex = 0;
            this.AnticheatLabel.Text = "    Checking connection with AntiCheat System";
            this.AnticheatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Controls.Add(this.commingSoon1);
            this.Start.Controls.Add(this.aModNetSettings1);
            this.Start.Controls.Add(this.startWindow1);
            this.Start.Location = new System.Drawing.Point(65, 24);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(755, 445);
            this.Start.TabIndex = 1;
            // 
            // commingSoon1
            // 
            this.commingSoon1.BackColor = System.Drawing.Color.Black;
            this.commingSoon1.Location = new System.Drawing.Point(0, 0);
            this.commingSoon1.Name = "commingSoon1";
            this.commingSoon1.Size = new System.Drawing.Size(755, 445);
            this.commingSoon1.TabIndex = 2;
            // 
            // aModNetSettings1
            // 
            this.aModNetSettings1.Location = new System.Drawing.Point(0, 0);
            this.aModNetSettings1.Name = "aModNetSettings1";
            this.aModNetSettings1.Size = new System.Drawing.Size(755, 445);
            this.aModNetSettings1.TabIndex = 1;
            // 
            // startWindow1
            // 
            this.startWindow1.Location = new System.Drawing.Point(0, 0);
            this.startWindow1.Name = "startWindow1";
            this.startWindow1.Size = new System.Drawing.Size(755, 445);
            this.startWindow1.TabIndex = 0;
            // 
            // DownloadBarWindow
            // 
            this.DownloadBarWindow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DownloadBarWindow.Location = new System.Drawing.Point(0, 405);
            this.DownloadBarWindow.Name = "DownloadBarWindow";
            this.DownloadBarWindow.Size = new System.Drawing.Size(64, 64);
            this.DownloadBarWindow.TabIndex = 6;
            this.DownloadBarWindow.TabStop = false;
            // 
            // VinylManSettingsBtn
            // 
            this.VinylManSettingsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.VinylManSettingsBtn.Location = new System.Drawing.Point(0, 195);
            this.VinylManSettingsBtn.Name = "VinylManSettingsBtn";
            this.VinylManSettingsBtn.Size = new System.Drawing.Size(64, 64);
            this.VinylManSettingsBtn.TabIndex = 5;
            this.VinylManSettingsBtn.TabStop = false;
            // 
            // AModNetSettingsBtn
            // 
            this.AModNetSettingsBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AModNetSettingsBtn.Location = new System.Drawing.Point(0, 130);
            this.AModNetSettingsBtn.Name = "AModNetSettingsBtn";
            this.AModNetSettingsBtn.Size = new System.Drawing.Size(64, 64);
            this.AModNetSettingsBtn.TabIndex = 4;
            this.AModNetSettingsBtn.TabStop = false;
            // 
            // SettingsMenuBtn
            // 
            this.SettingsMenuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SettingsMenuBtn.Location = new System.Drawing.Point(0, 65);
            this.SettingsMenuBtn.Name = "SettingsMenuBtn";
            this.SettingsMenuBtn.Size = new System.Drawing.Size(64, 64);
            this.SettingsMenuBtn.TabIndex = 3;
            this.SettingsMenuBtn.TabStop = false;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(64, 64);
            this.MainMenuBtn.TabIndex = 2;
            this.MainMenuBtn.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Controls.Add(this.DownloadBarWindow);
            this.Controls.Add(this.VinylManSettingsBtn);
            this.Controls.Add(this.AModNetSettingsBtn);
            this.Controls.Add(this.SettingsMenuBtn);
            this.Controls.Add(this.MainMenuBtn);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.AnticheatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLauncherReborn";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Start.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBarWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VinylManSettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AModNetSettingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsMenuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AnticheatLabel;
        private System.Windows.Forms.Panel Start;
        private System.Windows.Forms.PictureBox MainMenuBtn;
        private System.Windows.Forms.PictureBox SettingsMenuBtn;
        private System.Windows.Forms.PictureBox AModNetSettingsBtn;
        private System.Windows.Forms.PictureBox VinylManSettingsBtn;
        private System.Windows.Forms.PictureBox DownloadBarWindow;
        private Panels.StartWindow startWindow1;
        private Panels.CommingSoon commingSoon1;
        private Panels.AModNetSettings aModNetSettings1;
    }
}

