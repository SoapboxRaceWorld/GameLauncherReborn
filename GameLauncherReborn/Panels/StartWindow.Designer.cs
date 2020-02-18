namespace GameLauncherReborn.Panels
{
    partial class StartWindow
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerListOpenBtn = new System.Windows.Forms.Button();
            this.serverNameTest = new System.Windows.Forms.Label();
            this.verticalBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.verticalBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerListOpenBtn
            // 
            this.ServerListOpenBtn.Location = new System.Drawing.Point(3, 3);
            this.ServerListOpenBtn.Name = "ServerListOpenBtn";
            this.ServerListOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerListOpenBtn.TabIndex = 0;
            this.ServerListOpenBtn.Text = "button1";
            this.ServerListOpenBtn.UseVisualStyleBackColor = true;
            // 
            // serverNameTest
            // 
            this.serverNameTest.AutoSize = true;
            this.serverNameTest.Location = new System.Drawing.Point(84, 8);
            this.serverNameTest.Name = "serverNameTest";
            this.serverNameTest.Size = new System.Drawing.Size(0, 13);
            this.serverNameTest.TabIndex = 1;
            // 
            // verticalBanner
            // 
            this.verticalBanner.Location = new System.Drawing.Point(3, 32);
            this.verticalBanner.Name = "verticalBanner";
            this.verticalBanner.Size = new System.Drawing.Size(523, 223);
            this.verticalBanner.TabIndex = 2;
            this.verticalBanner.TabStop = false;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verticalBanner);
            this.Controls.Add(this.serverNameTest);
            this.Controls.Add(this.ServerListOpenBtn);
            this.Name = "StartWindow";
            this.Size = new System.Drawing.Size(755, 445);
            ((System.ComponentModel.ISupportInitialize)(this.verticalBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServerListOpenBtn;
        private System.Windows.Forms.Label serverNameTest;
        private System.Windows.Forms.PictureBox verticalBanner;
    }
}
