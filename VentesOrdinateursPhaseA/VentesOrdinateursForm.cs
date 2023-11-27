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
using g = VentesOrdinateurs.VentesOrdinateursGeneraleClass;
using ce = VentesOrdinateurs.VentesOrdinateursGeneraleClass.codeErreurs;


namespace VentesOrdinateurs
{
    /// <summary>
    /// Saisie d'une transaction
    /// </summary>
    /// <remarks>Tous droit réservés: AppCreat Inc.2025</remarks>
    public partial class VentesOrdinateursForm : Form
    {
        #region Declaration

        Transaction oTrans;

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
            }
            catch(Exception ex)
            {
                MessageBox.Show(g.tMessagesErreurStr[(int)ce.ceErreurIndeterminee] + Environment.NewLine + Environment.NewLine +
                ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        #endregion

        #region Obtenir le prix

        private void marquesCaracteristiquesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(marqueComboBox.SelectedIndex != 1 && caracteristiqueComboBox.SelectedIndex != -1)
            {
                prixLabel.Text = oTrans.GetPrix(marqueComboBox.SelectedIndex, caracteristiqueComboBox.SelectedIndex).ToString("C2");
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
