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
            this.modeleComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.prenomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.modeleLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
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
            this.ventesOrdinateursMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ventesOrdinateursMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.ventesOrdinateursMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ventesOrdinateursMenuStrip.Name = "ventesOrdinateursMenuStrip";
            this.ventesOrdinateursMenuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.ventesOrdinateursMenuStrip.Size = new System.Drawing.Size(829, 24);
            this.ventesOrdinateursMenuStrip.TabIndex = 0;
            this.ventesOrdinateursMenuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::VentesOrdinateurs.Properties.Resources.saveHS;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aProposDeToolStripMenuItem.Text = "À &propos de...";
            this.aProposDeToolStripMenuItem.Click += new System.EventHandler(this.aProposDeToolStripMenuItem_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.LightGray;
            this.logoPanel.Controls.Add(this.logoDroitPictureBox);
            this.logoPanel.Controls.Add(this.logoGauchePictureBox);
            this.logoPanel.Controls.Add(this.ordinateurPictureBox);
            this.logoPanel.Controls.Add(this.titreLabel);
            this.logoPanel.Location = new System.Drawing.Point(16, 33);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(798, 220);
            this.logoPanel.TabIndex = 1;
            // 
            // logoDroitPictureBox
            // 
            this.logoDroitPictureBox.Image = global::VentesOrdinateurs.Properties.Resources.logoDroite;
            this.logoDroitPictureBox.Location = new System.Drawing.Point(604, 78);
            this.logoDroitPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoDroitPictureBox.Name = "logoDroitPictureBox";
            this.logoDroitPictureBox.Size = new System.Drawing.Size(156, 109);
            this.logoDroitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDroitPictureBox.TabIndex = 3;
            this.logoDroitPictureBox.TabStop = false;
            // 
            // logoGauchePictureBox
            // 
            this.logoGauchePictureBox.Image = global::VentesOrdinateurs.Properties.Resources.logoGauche;
            this.logoGauchePictureBox.Location = new System.Drawing.Point(43, 78);
            this.logoGauchePictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoGauchePictureBox.Name = "logoGauchePictureBox";
            this.logoGauchePictureBox.Size = new System.Drawing.Size(158, 109);
            this.logoGauchePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoGauchePictureBox.TabIndex = 2;
            this.logoGauchePictureBox.TabStop = false;
            // 
            // ordinateurPictureBox
            // 
            this.ordinateurPictureBox.Image = global::VentesOrdinateurs.Properties.Resources.ordi_desktop;
            this.ordinateurPictureBox.Location = new System.Drawing.Point(239, 62);
            this.ordinateurPictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ordinateurPictureBox.Name = "ordinateurPictureBox";
            this.ordinateurPictureBox.Size = new System.Drawing.Size(329, 146);
            this.ordinateurPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ordinateurPictureBox.TabIndex = 1;
            this.ordinateurPictureBox.TabStop = false;
            // 
            // titreLabel
            // 
            this.titreLabel.AutoSize = true;
            this.titreLabel.Font = new System.Drawing.Font("Times New Roman", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreLabel.Location = new System.Drawing.Point(160, 0);
            this.titreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(501, 62);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Ventes d\'ordinateurs";
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.modeleComboBox);
            this.clientGroupBox.Controls.Add(this.typeComboBox);
            this.clientGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.prenomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.nomMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.modeleLabel);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.typeLabel);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.prenomLabel);
            this.clientGroupBox.Controls.Add(this.nomLabel);
            this.clientGroupBox.Location = new System.Drawing.Point(16, 266);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clientGroupBox.Size = new System.Drawing.Size(413, 287);
            this.clientGroupBox.TabIndex = 2;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client :";
            // 
            // modeleComboBox
            // 
            this.modeleComboBox.FormattingEnabled = true;
            this.modeleComboBox.Location = new System.Drawing.Point(149, 246);
            this.modeleComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modeleComboBox.Name = "modeleComboBox";
            this.modeleComboBox.Size = new System.Drawing.Size(241, 21);
            this.modeleComboBox.TabIndex = 13;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(149, 208);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(241, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(149, 135);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(241, 20);
            this.codePostalMaskedTextBox.TabIndex = 7;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.InformationClientMaskedTextBox_Enter);
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(149, 170);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(241, 20);
            this.telephoneMaskedTextBox.TabIndex = 9;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.InformationClientMaskedTextBox_Enter);
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(149, 100);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(241, 20);
            this.adresseMaskedTextBox.TabIndex = 5;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.InformationClientMaskedTextBox_Enter);
            // 
            // prenomMaskedTextBox
            // 
            this.prenomMaskedTextBox.Location = new System.Drawing.Point(149, 65);
            this.prenomMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prenomMaskedTextBox.Name = "prenomMaskedTextBox";
            this.prenomMaskedTextBox.Size = new System.Drawing.Size(241, 20);
            this.prenomMaskedTextBox.TabIndex = 3;
            this.prenomMaskedTextBox.Enter += new System.EventHandler(this.InformationClientMaskedTextBox_Enter);
            // 
            // nomMaskedTextBox
            // 
            this.nomMaskedTextBox.Location = new System.Drawing.Point(149, 32);
            this.nomMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nomMaskedTextBox.Name = "nomMaskedTextBox";
            this.nomMaskedTextBox.Size = new System.Drawing.Size(241, 20);
            this.nomMaskedTextBox.TabIndex = 1;
            this.nomMaskedTextBox.Enter += new System.EventHandler(this.InformationClientMaskedTextBox_Enter);
            // 
            // modeleLabel
            // 
            this.modeleLabel.AutoSize = true;
            this.modeleLabel.Location = new System.Drawing.Point(19, 248);
            this.modeleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.modeleLabel.Name = "modeleLabel";
            this.modeleLabel.Size = new System.Drawing.Size(103, 13);
            this.modeleLabel.TabIndex = 12;
            this.modeleLabel.Text = "Modèle d\'ordinateur:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(19, 176);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(61, 13);
            this.telephoneLabel.TabIndex = 8;
            this.telephoneLabel.Text = "Téléphone:";
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(19, 137);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(67, 13);
            this.codePostalLabel.TabIndex = 6;
            this.codePostalLabel.Text = "Code Postal:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(19, 211);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(92, 13);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Type d\'ordinateur:";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(19, 103);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(48, 13);
            this.adresseLabel.TabIndex = 4;
            this.adresseLabel.Text = "Adresse:";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(19, 68);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(46, 13);
            this.prenomLabel.TabIndex = 2;
            this.prenomLabel.Text = "Prénom:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(19, 34);
            this.nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(32, 13);
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
            this.transactionGroupBox.Location = new System.Drawing.Point(455, 266);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transactionGroupBox.Size = new System.Drawing.Size(359, 183);
            this.transactionGroupBox.TabIndex = 3;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction :";
            // 
            // prixLabel
            // 
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prixLabel.Location = new System.Drawing.Point(135, 140);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(204, 25);
            this.prixLabel.TabIndex = 7;
            // 
            // caracteristiqueComboBox
            // 
            this.caracteristiqueComboBox.FormattingEnabled = true;
            this.caracteristiqueComboBox.Location = new System.Drawing.Point(135, 103);
            this.caracteristiqueComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.caracteristiqueComboBox.Name = "caracteristiqueComboBox";
            this.caracteristiqueComboBox.Size = new System.Drawing.Size(204, 21);
            this.caracteristiqueComboBox.TabIndex = 5;
            this.caracteristiqueComboBox.SelectedIndexChanged += new System.EventHandler(this.MarquesCaracteristiquesComboBox_SelectedIndexChanged);
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(135, 62);
            this.marqueComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(204, 21);
            this.marqueComboBox.TabIndex = 3;
            this.marqueComboBox.SelectedIndexChanged += new System.EventHandler(this.MarquesCaracteristiquesComboBox_SelectedIndexChanged);
            // 
            // dateLivraisonDateTimePicker
            // 
            this.dateLivraisonDateTimePicker.Location = new System.Drawing.Point(135, 32);
            this.dateLivraisonDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateLivraisonDateTimePicker.Name = "dateLivraisonDateTimePicker";
            this.dateLivraisonDateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.dateLivraisonDateTimePicker.TabIndex = 1;
            this.dateLivraisonDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateLivraisonDateTimePicker_Validating);
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(30, 147);
            this.prixLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(27, 13);
            this.prixLLabel.TabIndex = 6;
            this.prixLLabel.Text = "Prix:";
            // 
            // caracteristiqueLabel
            // 
            this.caracteristiqueLabel.AutoSize = true;
            this.caracteristiqueLabel.Location = new System.Drawing.Point(29, 105);
            this.caracteristiqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.caracteristiqueLabel.Name = "caracteristiqueLabel";
            this.caracteristiqueLabel.Size = new System.Drawing.Size(80, 13);
            this.caracteristiqueLabel.TabIndex = 4;
            this.caracteristiqueLabel.Text = "Caracteristique:";
            // 
            // marqueLabeal
            // 
            this.marqueLabeal.AutoSize = true;
            this.marqueLabeal.Location = new System.Drawing.Point(29, 65);
            this.marqueLabeal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.marqueLabeal.Name = "marqueLabeal";
            this.marqueLabeal.Size = new System.Drawing.Size(46, 13);
            this.marqueLabeal.TabIndex = 2;
            this.marqueLabeal.Text = "Marque:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(29, 34);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(89, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date de livraison:";
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.Location = new System.Drawing.Point(455, 474);
            this.enregistrerButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(157, 79);
            this.enregistrerButton.TabIndex = 4;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(657, 474);
            this.annulerButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(157, 79);
            this.annulerButton.TabIndex = 5;
            this.annulerButton.Text = "&Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            // 
            // VentesOrdinateursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 571);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.ventesOrdinateursMenuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.ventesOrdinateursMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Label modeleLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label codePostalLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.MaskedTextBox nomMaskedTextBox;
        private System.Windows.Forms.ComboBox modeleComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
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

