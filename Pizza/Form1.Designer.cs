namespace Pizza
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKunde = new System.Windows.Forms.Button();
            this.BtnBestellungen = new System.Windows.Forms.Button();
            this.BtnPositionen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.BtnSpeisekarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKunde
            // 
            this.btnKunde.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKunde.Location = new System.Drawing.Point(11, 33);
            this.btnKunde.Name = "btnKunde";
            this.btnKunde.Size = new System.Drawing.Size(327, 94);
            this.btnKunde.TabIndex = 0;
            this.btnKunde.Text = "Kunden verwalten";
            this.btnKunde.UseVisualStyleBackColor = true;
            this.btnKunde.Click += new System.EventHandler(this.btnKunde_Click);
            // 
            // BtnBestellungen
            // 
            this.BtnBestellungen.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBestellungen.Location = new System.Drawing.Point(12, 133);
            this.BtnBestellungen.Name = "BtnBestellungen";
            this.BtnBestellungen.Size = new System.Drawing.Size(327, 94);
            this.BtnBestellungen.TabIndex = 0;
            this.BtnBestellungen.Text = "Bestellungen aufnehmen";
            this.BtnBestellungen.UseVisualStyleBackColor = true;
            this.BtnBestellungen.Click += new System.EventHandler(this.BtnBestellungen_Click);
            // 
            // BtnPositionen
            // 
            this.BtnPositionen.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPositionen.Location = new System.Drawing.Point(12, 233);
            this.BtnPositionen.Name = "BtnPositionen";
            this.BtnPositionen.Size = new System.Drawing.Size(327, 94);
            this.BtnPositionen.TabIndex = 0;
            this.BtnPositionen.Text = "Positionen ansehen";
            this.BtnPositionen.UseVisualStyleBackColor = true;
            this.BtnPositionen.Click += new System.EventHandler(this.BtnPositionen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(216, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schleißen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BtnSpeisekarte
            // 
            this.BtnSpeisekarte.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpeisekarte.Location = new System.Drawing.Point(11, 333);
            this.BtnSpeisekarte.Name = "BtnSpeisekarte";
            this.BtnSpeisekarte.Size = new System.Drawing.Size(327, 94);
            this.BtnSpeisekarte.TabIndex = 0;
            this.BtnSpeisekarte.Text = "Speisekarte verwalten";
            this.BtnSpeisekarte.UseVisualStyleBackColor = true;
            this.BtnSpeisekarte.Click += new System.EventHandler(this.BtnSpeisekarte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 497);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnSpeisekarte);
            this.Controls.Add(this.BtnPositionen);
            this.Controls.Add(this.BtnBestellungen);
            this.Controls.Add(this.btnKunde);
            this.Name = "Form1";
            this.Text = "Pizza Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKunde;
        private System.Windows.Forms.Button BtnBestellungen;
        private System.Windows.Forms.Button BtnPositionen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnSpeisekarte;
    }
}

