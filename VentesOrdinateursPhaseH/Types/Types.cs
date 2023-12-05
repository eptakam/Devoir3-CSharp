/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Décembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         Types.csproj
        Classe:         Types.cs

        But:            Couche métier 
                        Créer et documenter les types et modèles d'ordinateurs
                        Lire et enregistrer des données dans un fichier de texte à accès séquentiel : System.IO.StreamReader 
                        Choisir l'encodage des fichiers: UTF-8
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using ct = TypesNS.Types.CodesTypes;
using System.IO;
using System.Xml.Linq;

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
            tTypesStr = new string[40];
            string typeStr;
            StreamReader typeStreamReader = null;
            int i = 0;

            try
            {
                string path = "..\\..\\Data\\Types.data";   // Stocker le chemin d'accès 

                // Spécifier le type d'Encoding désiré
                typeStreamReader = new StreamReader(path, Encoding.UTF8);

                typeStr = typeStreamReader.ReadLine();  // Lire la première ligne de Types.data

                while (typeStr != null) 
                {
                    // Peupler le tableau
                    tTypesStr[i] = typeStr;
                    i++;
                    typeStr = typeStreamReader.ReadLine();
                }

                Array.Resize(ref tTypesStr, i); // Redimensionner le tableau
            }
            catch(FileNotFoundException)
            {
                throw new FileNotFoundException("Le fichier des types n'est pas disponible.");
            }
            catch (Exception)
            {
                throw new Exception("Erreur indéterminée dans la lecture des types d'ordinateurs.");
            }
            finally
            {
                // Libérer les ressources même en cas d'exception
                if (typeStreamReader != null)
                {
                    typeStreamReader.Close();
                }
            }
        }

        public void InitModeles()
        {
            tModelesStr = new string[40];
            string modeleStr;
            StreamReader modeleStreamReader = null;
            int i = 0;

            try
            {
                string path = "..\\..\\Data\\Modeles.data";   // Stocker le chemin d'accès 

                // Spécifier le modele d'Encoding désiré
                modeleStreamReader = new StreamReader(path, Encoding.UTF8);

                modeleStr = modeleStreamReader.ReadLine();  // Lire la première ligne de Modeles.data

                while (modeleStr != null)
                {
                    // Peupler le tableau
                    tModelesStr[i] = modeleStr;
                    i++;
                    modeleStr = modeleStreamReader.ReadLine();
                }

                Array.Resize(ref tModelesStr, i); // Redimensionner le tableau
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Le fichier des modèles n'est pas disponible.");
            }
            catch (Exception)
            {
                throw new Exception("Erreur indéterminée dans la lecture des modèles d'ordinateurs.");
            }
            finally
            {
                // Libérer les ressources même en cas d'exception
                if (modeleStreamReader != null)
                {
                    modeleStreamReader.Close();
                }
            }
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
