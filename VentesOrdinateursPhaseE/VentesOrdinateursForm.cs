﻿/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Novembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         VentesOrdinateurs.csproj
        Classe:         VentesOrdinateursForm.cs

        But:            Couche de présentation
                        Créer un objet métier de la classe Transaction
                        Créer une méthode pour enregistrer une transaction
                        Valider la date de livraison
                        Afficher la date due paiement
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransactionNS;
using TypesNS;
using g = VentesOrdinateurs.VentesOrdinateursGeneraleClass;
using ce = VentesOrdinateurs.VentesOrdinateursGeneraleClass.codeErreurs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ct = TypesNS.Types.CodesTypes;
using t = TransactionNS.Transaction;


namespace VentesOrdinateurs
{
    /// <summary>
    /// Saisie d'une transaction
    /// </summary>
    /// <remarks>Tous droits réservés: AppCreat Inc.2025</remarks>
    public partial class VentesOrdinateursForm : Form
    {
        #region Déclaration

        Transaction oTrans;
        Types oType;

        #endregion

        #region Constructeur

        /// <summary>
        /// 
        /// </summary>
        public VentesOrdinateursForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Initialisation
        
        private void VentesOrdinateursForm_Load(object sender, EventArgs e)
        {
            try
            {
                t.InitMessagesMessagesErreurs();

                g.InitMessagesErreurs();
                oTrans = new Transaction(); // Créer une une instance de Transaction

                marqueComboBox.Items.AddRange(oTrans.GetMarques()); // Remplir les marques
                marqueComboBox.SelectedIndex = 0;

                caracteristiqueComboBox.Items.AddRange(oTrans.GetCaracteristiques());   // Remplir les caracteristiques
                caracteristiqueComboBox.SelectedIndex = 0;

                oType = new Types(); // Créer une une instance de Types

                // Remplir les types
                typeComboBox.Items.AddRange(oType.GetTypesModeles((Types.CodesTypes)0));    // 0 : indice de la première énumération de CodesTypes
                typeComboBox.SelectedIndex = 0;

                // Remplir les modèles
                modeleComboBox.Items.AddRange(oType.GetTypesModeles((Types.CodesTypes)1));   // 1 : indice de la deuxième énumération de CodesTypes
                modeleComboBox.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            { 
                MessageBox.Show(ex.Message,"Obtenir le type, le modèle ou le prix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Obtenir le prix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tMessagesErreurStr[(int)ce.ceErreurIndeterminee] + Environment.NewLine + Environment.NewLine +
                ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Obtenir le prix

        private void MarquesCaracteristiquesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (marqueComboBox.SelectedIndex != -1 && caracteristiqueComboBox.SelectedIndex != -1)
                {
                    prixLabel.Text = oTrans.GetPrix(marqueComboBox.SelectedIndex, caracteristiqueComboBox.SelectedIndex).ToString("C2");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Sélectionner la marque ou le prix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Saisir la marque ou la caractéristique", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tMessagesErreurStr[(int)ce.ceErreurIndeterminee] + Environment.NewLine + Environment.NewLine +
                ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region A propos de...

        private void aProposDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VentesOrdinateursAboutBox oAboutBox = new VentesOrdinateursAboutBox();
                oAboutBox.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tMessagesErreurStr[(int)ce.ceErreurAboutBox] + Environment.NewLine + Environment.NewLine +
                ex.ToString(), "A propos de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Quitter

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Methode Enter

        private void InformationClientMaskedTextBox_Enter(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).SelectAll(); // selectionner le texte a chaque fois que la zone de texte recoit le focus
        }

        #endregion

        #region Enregistrer

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                // Technique 1 : Transmettre données Projet Principal au Projet Transaction en passant par le constructeur

                oTrans = new Transaction(nomMaskedTextBox.Text, prenomMaskedTextBox.Text, adresseMaskedTextBox.Text, codePostalMaskedTextBox.Text,
                        telephoneMaskedTextBox.Text, typeComboBox.Text, modeleComboBox.Text,
                        DateTime.Parse(dateLivraisonDateTimePicker.Text), marqueComboBox.Text, caracteristiqueComboBox.Text,
                        Decimal.Parse(prixLabel.Text, System.Globalization.NumberStyles.Currency));

                oTrans.Enregistrer();

                // Afficher la date de paiement
                paiementLabel.Text = oTrans.DateDuePaiement.ToLongDateString();

                // Technique 2 : Transmettre données Projet Principal au Projet Transaction en passant par les proprietes

                //oTrans = new Transaction();

                //oTrans.Nom = nomMaskedTextBox.Text;
                //oTrans.Prenom = prenomMaskedTextBox.Text;
                //oTrans.Adresse = adresseMaskedTextBox.Text;
                //oTrans.CodePostal = codePostalMaskedTextBox.Text;
                //oTrans.Telephone = telephoneMaskedTextBox.Text;
                //oTrans.Type = typeComboBox.Text;
                //oTrans.Modele = modeleComboBox.Text;
                //oTrans.Marque = marqueComboBox.Text;
                //oTrans.Caracteristique = caracteristiqueComboBox.Text;

                //oTrans.DateLivraison = DateTime.Parse(dateLivraisonDateTimePicker.Text);
                //oTrans.Prix = Decimal.Parse(prixLabel.Text, System.Globalization.NumberStyles.Currency);

                //oTrans.Enregistrer();


                //// Technique 3 : Transmettre données Projet Principal au Projet Transaction en passant par Enregistrement par parametre
                ////Transaction oTrans = new Transaction();

                //oTrans.Enregistrer(nomMaskedTextBox.Text, prenomMaskedTextBox.Text, adresseMaskedTextBox.Text,
                //codePostalMaskedTextBox.Text, telephoneMaskedTextBox.Text, typeComboBox.Text, modeleComboBox.Text,
                //DateTime.Parse(dateLivraisonDateTimePicker.Text), marqueComboBox.Text, caracteristiqueComboBox.Text,
                //Decimal.Parse(prixLabel.Text, System.Globalization.NumberStyles.Currency));
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException ex) { 
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(g.tMessagesErreurStr[(int)ce.ceErreurIndeterminee] + Environment.NewLine + Environment.NewLine +
               ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        #endregion

        #region Validation de la date de livraison
        
        private void dateLivraisonDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateLivraison;

           if (DateTime.TryParse(dateLivraisonDateTimePicker.Text, out dateLivraison))  //  convertir notre dateLivraison DateTimePicker en DateTime
           {
                dateLivraisonDateTimePicker.Text = dateLivraison.ToLongDateString();  // date sous le format long
           }
           else
           {
                dateLivraison = DateTime.Now;
                dateLivraisonDateTimePicker.Text = dateLivraison.ToLongDateString();  // date courante sous le format long
           }
           
        }

        #endregion
    }
}
