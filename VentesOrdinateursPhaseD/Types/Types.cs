/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Novembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         Types.csproj
        Classe:         Types.cs

        But:            Couche métier 
                        Créer et documenter les types et modèles d'ordinateurs
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using ct = TypesNS.Types.CodesTypes;

namespace TypesNS
{
    /// <summary>
    /// Objet métier : Classe des types et modèles
    /// </summary>
    /// <remarks>Tous droits réservés: App Creat Inc. 2025</remarks>
    public class Types
    {

        #region Declaration des tableaux

        private string[] tTypesStr;
        private string[] tModelesStr;

        #endregion

        #region Enumeration

        /// <summary>
        /// Enumeration pour les types et les modèles
        /// </summary>
        public enum CodesTypes
        {
            CTTypes,    //=0
            CTModeles   //=1
        }

        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Types()
        {
            InitTypes();
            InitModeles();
        }

        #endregion

        #region Initialisation des tableaux

        public void InitTypes()
        {
            tTypesStr = new string[2] { "Portable", "Bureau" };
        }

        public void InitModeles()
        {
            tModelesStr = new string[16] { "Chromebook", "ProArt studiobook", "Vivobook", "Zenbook",
                                          "Alienware", "Inspiron", "G-Series", "XPS",
                                          "IdeaPad", "Legion gaming", "ThinkBook", "ThinkPad",
                                          "Raider GE", "Stealth", "Titan GT", "Vector GP"};
        }

        #endregion

        #region Types et modèles

        /// <summary>
        /// Obtenir les types ou les modèles d'ordinateurs
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public string[] GetTypesModeles(CodesTypes type)
        {
            string[] getType;   // Tableau temporaire pour stocker les types ou les modeles

            switch (type)
            {
                case ct.CTTypes:
                    getType = tTypesStr;
                    break;
                case ct.CTModeles:
                    getType = tModelesStr;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Le type ou le modèle d'ordinateur demandé n'est pas disponible.");
            }

            return getType;
        }

        #endregion
    }
}
