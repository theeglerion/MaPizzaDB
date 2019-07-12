namespace Pizza
{
    partial class PositionenForm
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
            this.lbPos = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSumme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbTele = new System.Windows.Forms.RadioButton();
            this.rbBestell = new System.Windows.Forms.RadioButton();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPos
            // 
            this.lbPos.FormattingEnabled = true;
            this.lbPos.Location = new System.Drawing.Point(230, 12);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(880, 433);
            this.lbPos.TabIndex = 0;
            this.lbPos.SelectedIndexChanged += new System.EventHandler(this.lbPos_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 469);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(22, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(162, 20);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(137, 148);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Anzeigen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSumme
            // 
            this.tbSumme.Location = new System.Drawing.Point(978, 472);
            this.tbSumme.Name = "tbSumme";
            this.tbSumme.ReadOnly = true;
            this.tbSumme.Size = new System.Drawing.Size(132, 20);
            this.tbSumme.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(978, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Summe d. Bestellung:";
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(22, 67);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(56, 17);
            this.rbDate.TabIndex = 2;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Datum";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // rbTele
            // 
            this.rbTele.AutoSize = true;
            this.rbTele.Location = new System.Drawing.Point(22, 44);
            this.rbTele.Name = "rbTele";
            this.rbTele.Size = new System.Drawing.Size(73, 17);
            this.rbTele.TabIndex = 1;
            this.rbTele.Text = "Telefonnr.";
            this.rbTele.UseVisualStyleBackColor = true;
            // 
            // rbBestell
            // 
            this.rbBestell.AutoSize = true;
            this.rbBestell.Checked = true;
            this.rbBestell.Location = new System.Drawing.Point(22, 21);
            this.rbBestell.Name = "rbBestell";
            this.rbBestell.Size = new System.Drawing.Size(68, 17);
            this.rbBestell.TabIndex = 0;
            this.rbBestell.TabStop = true;
            this.rbBestell.Text = "Bestellnr.";
            this.rbBestell.UseVisualStyleBackColor = true;
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rbDate);
            this.gbRadio.Controls.Add(this.rbBestell);
            this.gbRadio.Controls.Add(this.rbTele);
            this.gbRadio.Controls.Add(this.tbSearch);
            this.gbRadio.Location = new System.Drawing.Point(12, 12);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(200, 130);
            this.gbRadio.TabIndex = 9;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Suche: ";
            // 
            // PositionenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 505);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSumme);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbPos);
            this.Name = "PositionenForm";
            this.Text = "Positionen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionenForm_FormClosing);
            this.Load += new System.EventHandler(this.PositionenForm_Load);
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSumme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbTele;
        private System.Windows.Forms.RadioButton rbBestell;
        private System.Windows.Forms.GroupBox gbRadio;
    }
}