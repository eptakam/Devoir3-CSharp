/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Novembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         VentesOrdinateurs.csproj
        Classe:         VentesOrdinateursGeneraleClass.cs

        But:            Couche métier
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using ce = VentesOrdinateurs.VentesOrdinateursGeneraleClass.codeErreurs;

namespace VentesOrdinateurs
{
    /// <summary>
    /// Classe générale dans la couche de presentation
    /// </summary>
    /// <remarks>Projet: VentesOrdinateurs</remarks>
    internal class VentesOrdinateursGeneraleClass
    {
        #region Enumeration

        /// <summary>
        /// Enumeration pour les messages d'erreurs
        /// </summary>
        public enum codeErreurs
        {
            ceErreurMarque, // = 0
            ceErreurCaracteristique, // = 1
            ceErreurPrix,   // = 2
            ceErreurIndeterminee // = 3
        }

        #endregion

        #region Declaration

        public static string[] tMessagesErreurStr = new string[4];  // Tableau des messages d'erreurs

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialiser les messages d'erreurs
        /// </summary>
        public static void InitMessagesErreurs()
        {
            tMessagesErreurStr[(int)ce.ceErreurMarque] = "Erreur reliée à la marque de l'ordinateur.";
            tMessagesErreurStr[(int)ce.ceErreurCaracteristique] = "Erreur reliée à la caractéristique de l'ordinateur.";
            tMessagesErreurStr[(int)ce.ceErreurPrix] = "Erreur reliée au prix de l'ordinateur.";
            tMessagesErreurStr[(int)ce.ceErreurIndeterminee] = "Une erreur indeterminée. Communiquer avec la personne ressource.";
        }
        
        #endregion

    }
}
