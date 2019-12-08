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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 500);
            this.Controls.Add(this.AnticheatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameLauncherReborn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AnticheatLabel;
    }
}

