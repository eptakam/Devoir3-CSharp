/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Novembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         Transaction.csproj
        Classe:         Transaction.cs

        But:            Couche métier 
                        Créer et documenter les membres
                        Surcharger la méthode GetPrix
                        Appliquer diverses techniques pour échanger des données entre un 
                        objet de la couche présentation et un objet métier
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TransactionNS
{
    /// <summary>
    /// Objet métier : Classe de transaction
    /// </summary>
    /// <remarks>Tous droits réservés: App Creat Inc. 2025</remarks>
    public class Transaction
    {
<<<<<<< HEAD
        #region Déclaration des tableaux et variables privées
=======
        #region Declaration des tableaux
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0

        private string[] tMarqueStr;
        private string[] tCaracteristiqueStr;
        private Decimal[,] tPrixDecimal;

<<<<<<< HEAD
=======
        #endregion

        #region Declaration des variables privees

>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        private int idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string codePostalStr;
        private string telephoneStr;
        private string typeStr;
        private string modeleStr;
        private DateTime dateLivraisonDateTime;
        private string marqueStr;
        private string caracteristiqueStr;
        private decimal prixDecimal;

        #endregion

        #region Initialisation des tableaux

        public void InitMarques()
        {
            tMarqueStr = new string[4] { "Asus", "Dell", "Lenovo", "Msi" };
        }

        public void InitCaracteristique()
        {
            tCaracteristiqueStr = new string[3] { "Core i5", "Core i7", "Core i9" };
        }

        public void InitPrix()
        {
            tPrixDecimal = new decimal[4, 3]
            {
                {999.00M,1099.00M,1200.39M },
                {739.49M,2299.00M,3149.50M },
                {759.99M,1272.96M,4139.00M },
                { 769.71M,1299.99M,1899.97M}
            };
        }

        #endregion

<<<<<<< HEAD
        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
=======
        #region Constructeur

>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        public Transaction()
        {
            InitMarques();
            InitCaracteristique();
            InitPrix();
        }

        /// <summary>									
        /// Constructeur avec paramètres : Information concernant les transactions									
        /// </summary>									
<<<<<<< HEAD
        /// <param name="nomPrinc">Nom du client</param>									
        /// <param name="prenomPrinc">Prénom du client</param>									
        /// <param name="adressePrinc">Adresse du client</param>									
        /// <param name="codePostalPrinc">Code postal du client</param>									
        /// <param name="telephonePrinc">Téléphone du client</param>									
        /// <param name="typePrinc">Type d'ordinateur</param>									
        /// <param name="modelePrinc">Modèle d'ordinateur</param>									
        /// <param name="dateLivraisonPrinc">Date de livraison</param>									
        /// <param name="marquePrinc">Marque d'ordinateur</param>									
        /// <param name="caracteristiquePrinc">Caractéristique d'ordinateur</param>									
        /// <param name="prixPrinc">Prix d'ordinateur</param>									
        public Transaction(string nomPrinc, string prenomPrinc, string adressePrinc,
        string codePostalPrinc, string telephonePrinc, string typePrinc,
        string modelePrinc, DateTime dateLivraisonPrinc, string marquePrinc,
        string caracteristiquePrinc, decimal prixPrinc) : this()
        {
            this.Nom = nomPrinc;
            this.Prenom = prenomPrinc;
            this.Adresse = adressePrinc;
            this.CodePostal = codePostalPrinc;
            this.Telephone = telephonePrinc;
            this.Type = typePrinc;
            this.Modele = modelePrinc;
            this.DateLivraison = dateLivraisonPrinc;
            this.Marque = marquePrinc;
            this.Caracteristique = caracteristiquePrinc;
            this.Prix = prixPrinc;
=======
        /// <param name="nomDestinataire">Nom du client</param>									
        /// <param name="prenomDestinataire">Prénom du client</param>									
        /// <param name="adresseDestinataire">Adresse du client</param>									
        /// <param name="codePostalDestinataire">Code postal du client</param>									
        /// <param name="telephoneDestinataire">Téléphone du client</param>									
        /// <param name="typeDestinataire">Type d'ordinateur</param>									
        /// <param name="modeleDestinataire">Modèle d'ordinateur</param>									
        /// <param name="dateLivraisonDestinataire">Date de livraison</param>									
        /// <param name="marqueDestinataire">Marque d'ordinateur</param>									
        /// <param name="caracteristiqueDestinataire">Caracteristique d'ordinateur</param>									
        /// <param name="prixDestinataire">Prix d'ordinateur</param>									
        public Transaction(string nomDestinataire, string prenomDestinataire, string adresseDestinataire,
        string codePostalDestinataire, string telephoneDestinataire, string typeDestinataire,
        string modeleDestinataire, DateTime dateLivraisonDestinataire, string marqueDestinataire,
        string caracteristiqueDestinataire, decimal prixDestinataire) : this()
        {
            this.Nom = nomDestinataire;
            this.Prenom = prenomDestinataire;
            this.Adresse = adresseDestinataire;
            this.CodePostal = codePostalDestinataire;
            this.Telephone = telephoneDestinataire;
            this.Type = typeDestinataire;
            this.Modele = modeleDestinataire;
            this.DateLivraison = dateLivraisonDestinataire;
            this.Marque = marqueDestinataire;
            this.Caracteristique = caracteristiqueDestinataire;
            this.Prix = prixDestinataire;
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        }



        #endregion

<<<<<<< HEAD
        #region Marques d'ordinateurs
=======
        #region Marques de ordinateurs
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0

        public string[] GetMarques()
        {
            return tMarqueStr;
        }

        #endregion

        #region Caracteristique des ordinateurs

        public string[] GetCaracteristiques()
        {
            return tCaracteristiqueStr;
        }

        #endregion

        #region Prix des ordinateurs

        /// <summary>
        /// Liste des prix
        /// </summary>
        /// <param name="indiceMarque">Indice (entier) pour la marque des ordinateurs.</param>
        /// <param name="indiceCaracteristique">Indice (entier) pour la caractéristique des ordinateurs.</param>
        /// <returns>Le prix associé à la marque et à la caractéristique d'un ordinateur.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Erreur survenant si un ou les deux indices donnés sont hors des limites des listes des marques et caractéristiques.</exception>
        public decimal GetPrix(int indiceMarque, int indiceCaracteristique)
        {
            if (indiceMarque >= tMarqueStr.GetLowerBound(0) && indiceMarque <= tMarqueStr.GetUpperBound(0))
            {
                if (indiceCaracteristique >= tCaracteristiqueStr.GetLowerBound(0) && indiceCaracteristique <= tCaracteristiqueStr.GetUpperBound(0))
                    return tPrixDecimal[indiceMarque, indiceCaracteristique];
                else
                    throw new ArgumentOutOfRangeException("Le prix n'est pas disponible selon l'indice de la caractéristique reçu.");
            }
            else
                throw new ArgumentOutOfRangeException("Le prix n'est pas disponible selon l'indice de la marque reçu.");
        }

        /// <summary>
        /// Liste des prix
        /// </summary>
        /// <param name="marque">Marque (string) d'un ordinateur.</param>
        /// <param name="caracteristique">Caractéristique (string) d'un ordinateur.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Erreur survenant si la marque et ou la caractéristique saisies ne sont pas dans les listes des marques et des caractéristiques.</exception>
        public decimal GetPrix(string marque, string caracteristique)
        {
            // Trouver les positions de la marque et de la caractéristique entrées
            int positionMarque = Array.IndexOf(tMarqueStr, marque);
            int positionCaracteristique = Array.IndexOf(tCaracteristiqueStr, caracteristique);

            if (positionMarque >= tMarqueStr.GetLowerBound(0) && positionMarque <= tMarqueStr.GetUpperBound(0))
            {
                if (positionCaracteristique >= tCaracteristiqueStr.GetLowerBound(0) && positionCaracteristique <= tCaracteristiqueStr.GetUpperBound(0))
                    return tPrixDecimal[positionMarque, positionCaracteristique];
                else
                    throw new ArgumentException("Le prix n'est pas disponible selon la caractéristique reçue.");
            }
            else
                throw new ArgumentException("Le prix n'est pas disponible selon la marque reçue.");
        }

        #endregion

<<<<<<< HEAD
        #region Propriétés 

        /// <summary>
        /// Numero unique de la transaction
        /// </summary>
        /// <remarks>Générer automatiquement lors de l'enregistrement de la transaction</remarks>
=======
        #region Proprietes publiques: Get et set

        /// <summary>
        /// Le numero unique de la transaction
        /// </summary>
        /// <remarks>Genere automatiquement lors de l'enregistrement de la transaction</remarks>
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        public int Id
        {
            get
            {
                return idInt;
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Nom du client
=======
        /// Le nom du client
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        /// <remarks>Obligatoire</remarks>
        public string Nom
        {
            get
            {
                return nomStr;
            }
            set
            {
                nomStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Prénom du client
=======
        /// Le prenom du client
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        /// <remarks>Obligatoire</remarks>
        public string Prenom
        {
            get
            {
                return prenomStr;
            }
            set
            {
                prenomStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
        /// Adresse rurale du client
        /// </summary>
        /// <remarks>Obligatoire</remarks>
        public string Adresse
        {
            get
            {
                return adresseStr;
            }
            set
            {
                adresseStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
        /// Code postal du client
        /// </summary>
<<<<<<< HEAD
        /// <value>Code postal canadien ou américain</value>
=======
        /// <value>Code postal canadien ou americain</value>
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// <remarks>Obligatoire</remarks>
        public string CodePostal
        {
            get
            {
                return codePostalStr;
            }
            set
            {
                codePostalStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// numero de telephone du client
=======
        /// Le numero de telephone du client
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public string Telephone
        {
            get
            {
                return telephoneStr;
            }
            set
            {
                telephoneStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Type d'ordinateur
=======
        /// Le type d'ordinateur
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public string Type
        {
            get
            {
                return typeStr;
            }
            set
            {
                typeStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Modèle d'ordinateur
=======
        /// Le modele d'ordinateur
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public string Modele
        {
            get
            {
                return modeleStr;
            }
            set
            {
                modeleStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Date de livraison
        /// </summary>
        /// <remarks>Obligatoire</remarks>
=======
        /// La date de livraison
        /// </summary>
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        public DateTime DateLivraison
        {
            get
            {
                return dateLivraisonDateTime;
            }
            set
            {
                dateLivraisonDateTime = value;
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Marque de l'ordinateur
=======
        /// La marque d'ordinateurs
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public string Marque
        {
            get
            {
                return marqueStr;
            }
            set
            {
                marqueStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// La caractéristique de l'ordinateur
=======
        /// La caracteristique de l'ordinateur
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public string Caracteristique
        {
            get
            {
                return caracteristiqueStr;
            }
            set
            {
                caracteristiqueStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Prix de l'ordinateur 
=======
        /// Le prix de l'ordinateur 
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                prixDecimal = value;
            }
        }
        #endregion

<<<<<<< HEAD
        #region Enregistrer
=======
        #region Methode Enregistrer
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0

        /// <summary>
        /// Enregistrer la transaction
        /// </summary>
<<<<<<< HEAD
        /// <remarks>L'objet métier contient les données de la transaction</remarks>
=======
        /// <remarks>L'objet metier contient les donnees de la transaction</remarks>
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        public void Enregistrer()
        {
            Console.WriteLine("Information du client :" + Environment.NewLine +
                               "Nom: " + Nom + Environment.NewLine +
<<<<<<< HEAD
                               "Prénom: " + Prenom + Environment.NewLine +
                               "Adresse: " + Adresse + Environment.NewLine +
                               "Code Postal: " + CodePostal + Environment.NewLine +
                               "Téléphone: " + Telephone + Environment.NewLine +
                               "Type: " + Type + Environment.NewLine +
                               "Modèle: " + Modele + Environment.NewLine +
                               "Date de livraison: " + DateLivraison + Environment.NewLine +
                               "Marque: " + Marque + Environment.NewLine +
                               "Caractéristique: " + Caracteristique + Environment.NewLine +
                               "Prix: " + Prix.ToString("C2"));

        }


        /// <summary>
        /// Enregistrer la transaction avec les paramètres
        /// </summary>
        /// <param name="nomPrinc"></param>
        /// <param name="prenomPrinc"></param>
        /// <param name="adressePrinc"></param>
        /// <param name="codePostalPrinc"></param>
        /// <param name="telephonePrinc"></param>
        /// <param name="typePrinc"></param>
        /// <param name="modelePrinc"></param>
        /// <param name="dateLivraisonPrinc"></param>
        /// <param name="marquePrinc"></param>
        /// <param name="caracteristiquePrinc"></param>
        /// <param name="prixPrinc"></param>      
        public void Enregistrer(string nomPrinc, string prenomPrinc, string adressePrinc,
        string codePostalPrinc, string telephonePrinc, string typePrinc,
        string modelePrinc, DateTime dateLivraisonPrinc, string marquePrinc,
        string caracteristiquePrinc, decimal prixPrinc)
        {
            // Enregistrer la transaction courante d'expédition dans l'objet métier						

            this.Nom = nomPrinc;
            this.Prenom = prenomPrinc;
            this.Adresse = adressePrinc;
            this.CodePostal = codePostalPrinc;
            this.Telephone = telephonePrinc;
            this.Type = typePrinc;
            this.Modele = modelePrinc;
            this.DateLivraison = dateLivraisonPrinc;
            this.Marque = marquePrinc;
            this.Caracteristique = caracteristiquePrinc;
            this.Prix = prixPrinc;

            Enregistrer();
        }

=======
                               "Prenom: " + Prenom + Environment.NewLine +
                               "Adresse: " + Adresse + Environment.NewLine +
                               "Code Postal: " + CodePostal + Environment.NewLine +
                               "Telephone: " + Telephone + Environment.NewLine +
                               "Type: " + Type + Environment.NewLine +
                               "Modele: " + Modele + Environment.NewLine +
                               "Date Livraison: " + DateLivraison + Environment.NewLine +
                               "Marque: " + Marque + Environment.NewLine +
                               "Caracteristique: " + Caracteristique + Environment.NewLine +
                               "Prix: " + Prix.ToString("C2"));

        }
        #endregion

        #region Methode enregistrer avec parametres

        /// <summary>
        /// Enregistrer la transaction avec les parametres
        /// </summary>
        /// <param name="nomDestinataire"></param>
        /// <param name="prenomDestinataire"></param>
        /// <param name="adresseDestinataire"></param>
        /// <param name="codePostalDestinataire"></param>
        /// <param name="telephoneDestinataire"></param>
        /// <param name="typeDestinataire"></param>
        /// <param name="modeleDestinataire"></param>
        /// <param name="dateLivraisonDestinataire"></param>
        /// <param name="marqueDestinataire"></param>
        /// <param name="caracteristiqueDestinataire"></param>
        /// <param name="prixDestinataire"></param>
        /// <remarks>Le numero de transaction et la date de paiement de la facture sont calcules</remarks>
        public void Enregistrer(string nomDestinataire, string prenomDestinataire, string adresseDestinataire,
        string codePostalDestinataire, string telephoneDestinataire, string typeDestinataire,
        string modeleDestinataire, DateTime dateLivraisonDestinataire, string marqueDestinataire,
        string caracteristiqueDestinataire, decimal prixDestinataire)
        {
            // Enregistrer la transaction courante d'expédition dans l'objet métier						

            this.Nom = nomDestinataire;
            this.Prenom = prenomDestinataire;
            this.Adresse = adresseDestinataire;
            this.CodePostal = codePostalDestinataire;
            this.Telephone = telephoneDestinataire;
            this.Type = typeDestinataire;
            this.Modele = modeleDestinataire;
            this.DateLivraison = dateLivraisonDestinataire;
            this.Marque = marqueDestinataire;
            this.Caracteristique = caracteristiqueDestinataire;
            this.Prix = prixDestinataire;

            Enregistrer();
        }
>>>>>>> b56acb8dcc5abca95d9f3a1f0ec3747b35ce27d0
        #endregion

    }
}
