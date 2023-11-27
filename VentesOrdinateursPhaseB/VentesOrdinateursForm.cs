/*
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


namespace VentesOrdinateurs
{
    /// <summary>
    /// Saisie d'une transaction
    /// </summary>
    /// <remarks>Tous droit réservés: AppCreat Inc.2025</remarks>
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
                    prixLabel.Text = oTrans.GetPrix(marqueComboBox.SelectedIndex, caracteristiqueComboBox.SelectedIndex).ToString("C2");
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
    }
}
