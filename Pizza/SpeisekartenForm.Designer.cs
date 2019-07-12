namespace Pizza
{
    partial class SpeisekartenForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbSpeisen = new System.Windows.Forms.ListBox();
            this.labSpeisekarte = new System.Windows.Forms.Label();
            this.cbKategorie = new System.Windows.Forms.ComboBox();
            this.gbHinzu = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.btnSenden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.tbBescheibung = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbKategorie = new System.Windows.Forms.GroupBox();
            this.btnDelKat = new System.Windows.Forms.Button();
            this.btnNeu = new System.Windows.Forms.Button();
            this.gbHinzu.SuspendLayout();
            this.gbKategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(368, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbSpeisen
            // 
            this.lbSpeisen.FormattingEnabled = true;
            this.lbSpeisen.Location = new System.Drawing.Point(13, 41);
            this.lbSpeisen.Name = "lbSpeisen";
            this.lbSpeisen.Size = new System.Drawing.Size(430, 212);
            this.lbSpeisen.TabIndex = 1;
            this.lbSpeisen.SelectedIndexChanged += new System.EventHandler(this.lbSpeisen_SelectedIndexChanged);
            // 
            // labSpeisekarte
            // 
            this.labSpeisekarte.AutoSize = true;
            this.labSpeisekarte.Location = new System.Drawing.Point(13, 22);
            this.labSpeisekarte.Name = "labSpeisekarte";
            this.labSpeisekarte.Size = new System.Drawing.Size(63, 13);
            this.labSpeisekarte.TabIndex = 2;
            this.labSpeisekarte.Text = "Speisekarte";
            // 
            // cbKategorie
            // 
            this.cbKategorie.FormattingEnabled = true;
            this.cbKategorie.Location = new System.Drawing.Point(4, 21);
            this.cbKategorie.Name = "cbKategorie";
            this.cbKategorie.Size = new System.Drawing.Size(120, 21);
            this.cbKategorie.TabIndex = 3;
            this.cbKategorie.SelectedIndexChanged += new System.EventHandler(this.cbKategorie_SelectedIndexChanged);
            // 
            // gbHinzu
            // 
            this.gbHinzu.Controls.Add(this.btnUpdate);
            this.gbHinzu.Controls.Add(this.label4);
            this.gbHinzu.Controls.Add(this.tbNummer);
            this.gbHinzu.Controls.Add(this.btnSenden);
            this.gbHinzu.Controls.Add(this.label3);
            this.gbHinzu.Controls.Add(this.label2);
            this.gbHinzu.Controls.Add(this.tbPreis);
            this.gbHinzu.Controls.Add(this.tbBescheibung);
            this.gbHinzu.Location = new System.Drawing.Point(13, 358);
            this.gbHinzu.Name = "gbHinzu";
            this.gbHinzu.Size = new System.Drawing.Size(313, 142);
            this.gbHinzu.TabIndex = 4;
            this.gbHinzu.TabStop = false;
            this.gbHinzu.Text = "Hinzufügen (Kategorie wählen!)";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(224, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kartennr.";
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(6, 37);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(104, 20);
            this.tbNummer.TabIndex = 5;
            // 
            // btnSenden
            // 
            this.btnSenden.Location = new System.Drawing.Point(224, 73);
            this.btnSenden.Name = "btnSenden";
            this.btnSenden.Size = new System.Drawing.Size(75, 23);
            this.btnSenden.TabIndex = 4;
            this.btnSenden.Text = "Hinzufügen";
            this.btnSenden.UseVisualStyleBackColor = true;
            this.btnSenden.Click += new System.EventHandler(this.btnSenden_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bezeichnung";
            // 
            // tbPreis
            // 
            this.tbPreis.Location = new System.Drawing.Point(6, 76);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(104, 20);
            this.tbPreis.TabIndex = 1;
            // 
            // tbBescheibung
            // 
            this.tbBescheibung.Location = new System.Drawing.Point(131, 37);
            this.tbBescheibung.Name = "tbBescheibung";
            this.tbBescheibung.Size = new System.Drawing.Size(168, 20);
            this.tbBescheibung.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbKategorie
            // 
            this.gbKategorie.Controls.Add(this.btnDelKat);
            this.gbKategorie.Controls.Add(this.btnNeu);
            this.gbKategorie.Controls.Add(this.cbKategorie);
            this.gbKategorie.Location = new System.Drawing.Point(12, 285);
            this.gbKategorie.Name = "gbKategorie";
            this.gbKategorie.Size = new System.Drawing.Size(314, 54);
            this.gbKategorie.TabIndex = 6;
            this.gbKategorie.TabStop = false;
            this.gbKategorie.Text = "Kategorie";
            // 
            // btnDelKat
            // 
            this.btnDelKat.Location = new System.Drawing.Point(225, 19);
            this.btnDelKat.Name = "btnDelKat";
            this.btnDelKat.Size = new System.Drawing.Size(75, 23);
            this.btnDelKat.TabIndex = 4;
            this.btnDelKat.Text = "Löschen";
            this.btnDelKat.UseVisualStyleBackColor = true;
            this.btnDelKat.Click += new System.EventHandler(this.btnDelKat_Click);
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(136, 19);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(75, 23);
            this.btnNeu.TabIndex = 4;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // SpeisekartenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 521);
            this.Controls.Add(this.gbKategorie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbHinzu);
            this.Controls.Add(this.labSpeisekarte);
            this.Controls.Add(this.lbSpeisen);
            this.Controls.Add(this.btnClose);
            this.Name = "SpeisekartenForm";
            this.Text = "Speisekarte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SpeisekartenForm_FormClosing);
            this.Load += new System.EventHandler(this.SpeisekartenForm_Load);
            this.gbHinzu.ResumeLayout(false);
            this.gbHinzu.PerformLayout();
            this.gbKategorie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbSpeisen;
        private System.Windows.Forms.Label labSpeisekarte;
        private System.Windows.Forms.ComboBox cbKategorie;
        private System.Windows.Forms.GroupBox gbHinzu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbBescheibung;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSenden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbKategorie;
        private System.Windows.Forms.Button btnDelKat;
        private System.Windows.Forms.Button btnNeu;
    }
}