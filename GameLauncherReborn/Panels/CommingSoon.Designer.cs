namespace GameLauncherReborn.Panels
{
    partial class CommingSoon
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
            this.CommingSoonText = new System.Windows.Forms.Label();
            this.CommingSoonDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommingSoonText
            // 
            this.CommingSoonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommingSoonText.ForeColor = System.Drawing.Color.White;
            this.CommingSoonText.Location = new System.Drawing.Point(3, 106);
            this.CommingSoonText.Name = "CommingSoonText";
            this.CommingSoonText.Size = new System.Drawing.Size(749, 70);
            this.CommingSoonText.TabIndex = 0;
            this.CommingSoonText.Text = "Comming Soon!";
            this.CommingSoonText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CommingSoonDesc
            // 
            this.CommingSoonDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommingSoonDesc.ForeColor = System.Drawing.Color.Silver;
            this.CommingSoonDesc.Location = new System.Drawing.Point(5, 176);
            this.CommingSoonDesc.Name = "CommingSoonDesc";
            this.CommingSoonDesc.Size = new System.Drawing.Size(747, 93);
            this.CommingSoonDesc.TabIndex = 1;
            this.CommingSoonDesc.Text = "The feature you\'ve tried accessing is still in development. Please check next tim" +
    "e.";
            this.CommingSoonDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CommingSoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.CommingSoonDesc);
            this.Controls.Add(this.CommingSoonText);
            this.Name = "CommingSoon";
            this.Size = new System.Drawing.Size(755, 445);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CommingSoonText;
        private System.Windows.Forms.Label CommingSoonDesc;
    }
}
