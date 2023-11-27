namespace VentesOrdinateurs
{
    partial class VentesOrdinateursForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ventesOrdinateursMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoDroitPictureBox = new System.Windows.Forms.PictureBox();
            this.logoGauchePictureBox = new System.Windows.Forms.PictureBox();
            this.ordinateurPictureBox = new System.Windows.Forms.PictureBox();
            this.titreLabel = new System.Windows.Forms.Label();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.modeleOrdinateurComboBox = new System.Windows.Forms.ComboBox();
            this.typesOrdinateursComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.prenomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.modeleOrdinateurLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.typesOrdinateursLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.prixLabel = new System.Windows.Forms.Label();
            this.caracteristiqueComboBox = new System.Windows.Forms.ComboBox();
            this.marqueComboBox = new System.Windows.Forms.ComboBox();
            this.dateLivraisonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.caracteristiqueLabel = new System.Windows.Forms.Label();
            this.marqueLabeal = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.enregistrerButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.ventesOrdinateursMenuStrip.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoDroitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoGauchePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinateurPictureBox)).BeginInit();
            this.clientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventesOrdinateursMenuStrip
            // 
            this.ventesOrdinateursMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.ventesOrdinateursMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ventesOrdinateursMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.ventesOrdinateursMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ventesOrdinateursMenuStrip.Name = "ventesOrdinateursMenuStrip";
            this.ventesOrdinateursMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ventesOrdinateursMenuStrip.Size = new System.Drawing.Size(1243, 36);
            this.ventesOrdinateursMenuStrip.TabIndex = 0;
            this.ventesOrdinateursMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::VentesOrdinateurs.Properties.Resources.saveHS;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(64, 32);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aProposDeToolStripMenuItem.Text = "À &propos de...";
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightGray;
            this.logoPanel.Controls.Add(this.logoDroitPictureBox);
            this.logoPanel.Controls.Add(this.logoGauchePictureBox);
            this.logoPanel.Controls.Add(this.ordinateurPictureBox);
            this.logoPanel.Controls.Add(this.titreLabel);
            this.logoPanel.Location = new System.Drawing.Point(24, 51);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1197, 338);
            this.logoPanel.TabIndex = 1;
            // 
            // logoDroitPictureBox
            // 
            this.logoDroitPictureBox.Image = global::VentesOrdinateurs.Properties.Resources.logoDroite;
            this.logoDroitPictureBox.Location = new System.Drawing.Point(906, 120);
            this.logoDroitPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoDroitPictureBox.Name = "logoDroitPictureBox";
            this.logoDroitPictureBox.Size = new System.Drawing.Size(234, 168);
            this.logoDroitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDroitPictureBox.TabIndex = 3;
            this.logoDroitPictureBox.TabStop = false;
            // 
            // logoGauchePictureBox
            // 
            this.logoGauchePictureBox.Image = global::VentesOrdinateurs.Properties.Resources.logoGauche;
            this.logoGauchePictureBox.Location = new System.Drawing.Point(65, 120);
            this.logoGauchePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoGauchePictureBox.Name = "logoGauchePictureBox";
            this.logoGauchePictureBox.Size = new System.Drawing.Size(237, 168);
            this.logoGauchePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoGauchePictureBox.TabIndex = 2;
            this.logoGauchePictureBox.TabStop = false;
            // 
            // ordinateurPictureBox
            // 
            this.ordinateurPictureBox.Image = global::VentesOrdinateurs.Properties.Resources.ordi_desktop;
            this.ordinateurPictureBox.Location = new System.Drawing.Point(358, 96);
            this.ordinateurPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordinateurPictureBox.Name = "ordinateurPictureBox";
            this.ordinateurPictureBox.Size = new System.Drawing.Size(493, 225);
            this.ordinateurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ordinateurPictureBox.TabIndex = 1;
            this.ordinateurPictureBox.TabStop = false;
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.Location = new System.Drawing.Point(240, 0);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(762, 92);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Ventes d\'ordinateurs";
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.modeleOrdinateurComboBox);
            this.clientGroupBox.Controls.Add(this.typesOrdinateursComboBox);
            this.clientGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.prenomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.nomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.modeleOrdinateurLabel);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.typesOrdinateursLabel);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.prenomLabel);
            this.clientGroupBox.Controls.Add(this.nomLabel);
            this.clientGroupBox.Location = new System.Drawing.Point(24, 409);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientGroupBox.Size = new System.Drawing.Size(619, 441);
            this.clientGroupBox.TabIndex = 2;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client :";
            // 
            // modeleOrdinateurComboBox
            // 
            this.modeleOrdinateurComboBox.FormattingEnabled = true;
            this.modeleOrdinateurComboBox.Location = new System.Drawing.Point(224, 378);
            this.modeleOrdinateurComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modeleOrdinateurComboBox.Name = "modeleOrdinateurComboBox";
            this.modeleOrdinateurComboBox.Size = new System.Drawing.Size(360, 28);
            this.modeleOrdinateurComboBox.TabIndex = 13;
            // 
            // typesOrdinateursComboBox
            // 
            this.typesOrdinateursComboBox.FormattingEnabled = true;
            this.typesOrdinateursComboBox.Location = new System.Drawing.Point(224, 320);
            this.typesOrdinateursComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.typesOrdinateursComboBox.Name = "typesOrdinateursComboBox";
            this.typesOrdinateursComboBox.Size = new System.Drawing.Size(360, 28);
            this.typesOrdinateursComboBox.TabIndex = 11;
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(224, 208);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(360, 26);
            this.codePostalMaskedTextBox.TabIndex = 7;
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(224, 262);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(360, 26);
            this.telephoneMaskedTextBox.TabIndex = 9;
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(224, 154);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(360, 26);
            this.adresseMaskedTextBox.TabIndex = 5;
            // 
            // prenomMaskedTextBox
            // 
            this.prenomMaskedTextBox.Location = new System.Drawing.Point(224, 100);
            this.prenomMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prenomMaskedTextBox.Name = "prenomMaskedTextBox";
            this.prenomMaskedTextBox.Size = new System.Drawing.Size(360, 26);
            this.prenomMaskedTextBox.TabIndex = 3;
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Location = new System.Drawing.Point(224, 49);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(360, 26);
            this.nomMaskedTextBox.TabIndex = 1;
            // 
            // modeleOrdinateurLabel
            // 
            this.modeleOrdinateurLabel.AutoSize = true;
            this.modeleOrdinateurLabel.Location = new System.Drawing.Point(29, 381);
            this.modeleOrdinateurLabel.Name = "modeleOrdinateurLabel";
            this.modeleOrdinateurLabel.Size = new System.Drawing.Size(153, 20);
            this.modeleOrdinateurLabel.TabIndex = 12;
            this.modeleOrdinateurLabel.Text = "Modèle d\'ordinateur:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(29, 270);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(88, 20);
            this.telephoneLabel.TabIndex = 8;
            this.telephoneLabel.Text = "Téléphone:";
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(29, 211);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(99, 20);
            this.codePostalLabel.TabIndex = 6;
            this.codePostalLabel.Text = "Code Postal:";
            // 
            // typesOrdinateursLabel
            // 
            this.typesOrdinateursLabel.AutoSize = true;
            this.typesOrdinateursLabel.Location = new System.Drawing.Point(29, 324);
            this.typesOrdinateursLabel.Name = "typesOrdinateursLabel";
            this.typesOrdinateursLabel.Size = new System.Drawing.Size(135, 20);
            this.typesOrdinateursLabel.TabIndex = 10;
            this.typesOrdinateursLabel.Text = "Type d\'ordinateur:";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(29, 158);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(72, 20);
            this.adresseLabel.TabIndex = 4;
            this.adresseLabel.Text = "Adresse:";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(29, 104);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(68, 20);
            this.prenomLabel.TabIndex = 2;
            this.prenomLabel.Text = "Prénom:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(29, 52);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(46, 20);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom:";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.prixLabel);
            this.transactionGroupBox.Controls.Add(this.caracteristiqueComboBox);
            this.transactionGroupBox.Controls.Add(this.marqueComboBox);
            this.transactionGroupBox.Controls.Add(this.dateLivraisonDateTimePicker);
            this.transactionGroupBox.Controls.Add(this.prixLLabel);
            this.transactionGroupBox.Controls.Add(this.caracteristiqueLabel);
            this.transactionGroupBox.Controls.Add(this.marqueLabeal);
            this.transactionGroupBox.Controls.Add(this.dateLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(682, 409);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transactionGroupBox.Size = new System.Drawing.Size(539, 281);
            this.transactionGroupBox.TabIndex = 3;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction :";
            // 
            // prixLabel
            // 
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prixLabel.Location = new System.Drawing.Point(202, 215);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(305, 37);
            this.prixLabel.TabIndex = 7;
            // 
            // caracteristiqueComboBox
            // 
            this.caracteristiqueComboBox.FormattingEnabled = true;
            this.caracteristiqueComboBox.Location = new System.Drawing.Point(202, 158);
            this.caracteristiqueComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.caracteristiqueComboBox.Name = "caracteristiqueComboBox";
            this.caracteristiqueComboBox.Size = new System.Drawing.Size(304, 28);
            this.caracteristiqueComboBox.TabIndex = 5;
            this.caracteristiqueComboBox.SelectedIndexChanged += new System.EventHandler(this.marquesCaracteristiquesComboBox_SelectedIndexChanged);
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(202, 96);
            this.marqueComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(304, 28);
            this.marqueComboBox.TabIndex = 3;
            this.marqueComboBox.SelectedIndexChanged += new System.EventHandler(this.marquesCaracteristiquesComboBox_SelectedIndexChanged);
            // 
            // dateLivraisonDateTimePicker
            // 
            this.dateLivraisonDateTimePicker.Location = new System.Drawing.Point(202, 49);
            this.dateLivraisonDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateLivraisonDateTimePicker.Name = "dateLivraisonDateTimePicker";
            this.dateLivraisonDateTimePicker.Size = new System.Drawing.Size(304, 26);
            this.dateLivraisonDateTimePicker.TabIndex = 1;
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(45, 226);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(38, 20);
            this.prixLLabel.TabIndex = 6;
            this.prixLLabel.Text = "Prix:";
            // 
            // caracteristiqueLabel
            // 
            this.caracteristiqueLabel.AutoSize = true;
            this.caracteristiqueLabel.Location = new System.Drawing.Point(44, 161);
            this.caracteristiqueLabel.Name = "caracteristiqueLabel";
            this.caracteristiqueLabel.Size = new System.Drawing.Size(120, 20);
            this.caracteristiqueLabel.TabIndex = 4;
            this.caracteristiqueLabel.Text = "Caracteristique:";
            // 
            // marqueLabeal
            // 
            this.marqueLabeal.AutoSize = true;
            this.marqueLabeal.Location = new System.Drawing.Point(44, 100);
            this.marqueLabeal.Name = "marqueLabeal";
            this.marqueLabeal.Size = new System.Drawing.Size(67, 20);
            this.marqueLabeal.TabIndex = 2;
            this.marqueLabeal.Text = "Marque:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(44, 52);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(130, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date de livraison:";
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.Location = new System.Drawing.Point(682, 729);
            this.enregistrerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(235, 121);
            this.enregistrerButton.TabIndex = 4;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(986, 729);
            this.annulerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(235, 121);
            this.annulerButton.TabIndex = 5;
            this.annulerButton.Text = "&Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            // 
            // VentesOrdinateursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 879);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.ventesOrdinateursMenuStrip);
            this.MainMenuStrip = this.ventesOrdinateursMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentesOrdinateursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes d\'ordinateurs";
            this.Load += new System.EventHandler(this.VentesOrdinateursForm_Load);
            this.ventesOrdinateursMenuStrip.ResumeLayout(false);
            this.ventesOrdinateursMenuStrip.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoDroitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoGauchePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinateurPictureBox)).EndInit();
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ventesOrdinateursMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.Label modeleOrdinateurLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label codePostalLabel;
        private System.Windows.Forms.Label typesOrdinateursLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.MaskedTextBox nomMaskedTextBox;
        private System.Windows.Forms.ComboBox modeleOrdinateurComboBox;
        private System.Windows.Forms.ComboBox typesOrdinateursComboBox;
        private System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox adresseMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox prenomMaskedTextBox;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Label prixLLabel;
        private System.Windows.Forms.Label caracteristiqueLabel;
        private System.Windows.Forms.Label marqueLabeal;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox caracteristiqueComboBox;
        private System.Windows.Forms.ComboBox marqueComboBox;
        private System.Windows.Forms.DateTimePicker dateLivraisonDateTimePicker;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button enregistrerButton;
        private System.Windows.Forms.PictureBox ordinateurPictureBox;
        private System.Windows.Forms.PictureBox logoDroitPictureBox;
        private System.Windows.Forms.PictureBox logoGauchePictureBox;
    }
}

