namespace Pizza
{
    partial class BestellFrom
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
            this.tbBestellNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBestellDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBestellKunden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewBestellung = new System.Windows.Forms.Button();
            this.btnNeuerKunde = new System.Windows.Forms.Button();
            this.cbSpeisen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMenge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPositionen = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHinzu = new System.Windows.Forms.Button();
            this.btnBestellen = new System.Windows.Forms.Button();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBestellNr
            // 
            this.tbBestellNr.Location = new System.Drawing.Point(12, 31);
            this.tbBestellNr.Name = "tbBestellNr";
            this.tbBestellNr.ReadOnly = true;
            this.tbBestellNr.Size = new System.Drawing.Size(100, 20);
            this.tbBestellNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BestellNr";
            // 
            // tbBestellDatum
            // 
            this.tbBestellDatum.Location = new System.Drawing.Point(207, 31);
            this.tbBestellDatum.Name = "tbBestellDatum";
            this.tbBestellDatum.ReadOnly = true;
            this.tbBestellDatum.Size = new System.Drawing.Size(100, 20);
            this.tbBestellDatum.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum";
            // 
            // cbBestellKunden
            // 
            this.cbBestellKunden.FormattingEnabled = true;
            this.cbBestellKunden.Location = new System.Drawing.Point(12, 75);
            this.cbBestellKunden.Name = "cbBestellKunden";
            this.cbBestellKunden.Size = new System.Drawing.Size(164, 21);
            this.cbBestellKunden.TabIndex = 2;
            this.cbBestellKunden.SelectedIndexChanged += new System.EventHandler(this.cbBestellKunden_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kunden";
            // 
            // btnNewBestellung
            // 
            this.btnNewBestellung.Location = new System.Drawing.Point(12, 102);
            this.btnNewBestellung.Name = "btnNewBestellung";
            this.btnNewBestellung.Size = new System.Drawing.Size(100, 23);
            this.btnNewBestellung.TabIndex = 3;
            this.btnNewBestellung.Text = "Neue Bestellung";
            this.btnNewBestellung.UseVisualStyleBackColor = true;
            this.btnNewBestellung.Click += new System.EventHandler(this.btnNewBestellung_Click);
            // 
            // btnNeuerKunde
            // 
            this.btnNeuerKunde.Location = new System.Drawing.Point(207, 75);
            this.btnNeuerKunde.Name = "btnNeuerKunde";
            this.btnNeuerKunde.Size = new System.Drawing.Size(100, 23);
            this.btnNeuerKunde.TabIndex = 4;
            this.btnNeuerKunde.Text = "Neuer Kunde";
            this.btnNeuerKunde.UseVisualStyleBackColor = true;
            this.btnNeuerKunde.Click += new System.EventHandler(this.btnNeuerKunde_Click);
            // 
            // cbSpeisen
            // 
            this.cbSpeisen.FormattingEnabled = true;
            this.cbSpeisen.Location = new System.Drawing.Point(12, 160);
            this.cbSpeisen.Name = "cbSpeisen";
            this.cbSpeisen.Size = new System.Drawing.Size(164, 21);
            this.cbSpeisen.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Speisen";
            // 
            // tbMenge
            // 
            this.tbMenge.Location = new System.Drawing.Point(275, 160);
            this.tbMenge.Name = "tbMenge";
            this.tbMenge.Size = new System.Drawing.Size(32, 20);
            this.tbMenge.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Menge";
            // 
            // lbPositionen
            // 
            this.lbPositionen.FormattingEnabled = true;
            this.lbPositionen.Location = new System.Drawing.Point(15, 234);
            this.lbPositionen.Name = "lbPositionen";
            this.lbPositionen.Size = new System.Drawing.Size(292, 186);
            this.lbPositionen.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Positionen";
            // 
            // btnHinzu
            // 
            this.btnHinzu.Location = new System.Drawing.Point(12, 187);
            this.btnHinzu.Name = "btnHinzu";
            this.btnHinzu.Size = new System.Drawing.Size(100, 23);
            this.btnHinzu.TabIndex = 8;
            this.btnHinzu.Text = "Hinzufügen";
            this.btnHinzu.UseVisualStyleBackColor = true;
            this.btnHinzu.Click += new System.EventHandler(this.btnHinzu_Click);
            // 
            // btnBestellen
            // 
            this.btnBestellen.Location = new System.Drawing.Point(207, 481);
            this.btnBestellen.Name = "btnBestellen";
            this.btnBestellen.Size = new System.Drawing.Size(100, 23);
            this.btnBestellen.TabIndex = 9;
            this.btnBestellen.Text = "Bestellen";
            this.btnBestellen.UseVisualStyleBackColor = true;
            this.btnBestellen.Click += new System.EventHandler(this.btnBestellen_Click);
            // 
            // tbPreis
            // 
            this.tbPreis.Location = new System.Drawing.Point(11, 441);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(100, 20);
            this.tbPreis.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Summe";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Position Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(11, 532);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(101, 23);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Abbrechen";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // BestellFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 567);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbPreis);
            this.Controls.Add(this.btnBestellen);
            this.Controls.Add(this.btnHinzu);
            this.Controls.Add(this.lbPositionen);
            this.Controls.Add(this.tbMenge);
            this.Controls.Add(this.cbSpeisen);
            this.Controls.Add(this.btnNeuerKunde);
            this.Controls.Add(this.btnNewBestellung);
            this.Controls.Add(this.cbBestellKunden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBestellDatum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBestellNr);
            this.Name = "BestellFrom";
            this.Text = "Bestellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BestellFrom_FormClosing);
            this.Load += new System.EventHandler(this.BestellFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBestellNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBestellDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBestellKunden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewBestellung;
        private System.Windows.Forms.Button btnNeuerKunde;
        private System.Windows.Forms.ComboBox cbSpeisen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMenge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPositionen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHinzu;
        private System.Windows.Forms.Button btnBestellen;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQuit;
    }
}