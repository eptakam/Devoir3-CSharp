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

using ce = TransactionNS.Transaction.codeErreurs;

namespace TransactionNS
{
    /// <summary>
    /// Objet métier : Classe de transaction
    /// </summary>
    /// <remarks>Tous droits réservés: App Creat Inc. 2025</remarks>
    public class Transaction
    {

        #region Declaration des enumerations, tableaux d'erreurs

        public enum codeErreurs
        {
            ceNomObligatoire,
            cePrenomObligatoire,
            ceAdresseObligatoire,
            ceCodePostalObligatoire,
            ceCodePostalInvalide,
            ceTelephoneObligatoire,
            ceDateLivraisonInvalide,
            ceMarqueInvalide,
            ceCaracteristiqueInvalide,
            cePrixOrdinateurEgale,
            ceErreurIndeterminee
        }

        private static string[] tMessagesErreursString = new string[6];


        #endregion

        #region Initialisation des tableaux d'erreurs

        private static void InitMessagesMessagesErreurs()
        {
            tMessagesErreursString[(int)ce.ceNomObligatoire] = "Le nom est obligatoire.";
            tMessagesErreursString[(int)ce.cePrenomObligatoire] = "Le prenom est obligatoire.";
            tMessagesErreursString[(int)ce.ceAdresseObligatoire] = "L'adresse est obligatoire. ";
            tMessagesErreursString[(int)ce.ceCodePostalObligatoire] = "Le code postal est obligatoire.";
            tMessagesErreursString[(int)ce.ceCodePostalInvalide] = "Le code postal est invalide.";
            tMessagesErreursString[(int)ce.ceTelephoneObligatoire] = "Le numero de telephone est obligatoire";
            tMessagesErreursString[(int)ce.ceDateLivraisonInvalide] = "La date de livraison est invalide.";
            tMessagesErreursString[(int)ce.ceMarqueInvalide] = "La marque des ordinateurs est invalide. Veuillez choisir une marque acceptable.";
            tMessagesErreursString[(int)ce.ceCaracteristiqueInvalide] = "Les caracterstiques des ordinateurs sont invalides. Veuillez choisir une caracteristique acceptable.";
            tMessagesErreursString[(int)ce.cePrixOrdinateurEgale] = "Le prix doit correspondre a la marque et aux caracteristiques precises.";
            tMessagesErreursString[(int)ce.ceErreurIndeterminee] = "Une erreur indeterminée. Communiquer avec la personne ressource.";

        }


        #endregion


        #region Declaration des tableaux

        private string[] tMarqueStr;
        private string[] tCaracteristiqueStr;
        private Decimal[,] tPrixDecimal;

        #endregion

        #region Declaration des variables(champs) privees

        private int idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string codePostalStr;
        private string telephoneStr;
        private string typeStr;
        private string modeleStr;
        private DateTime dateLivraisonDateTime;
        private DateTime datePaiementDateTime;
        private string marqueStr;
        private string caracteristiqueStr;
        private decimal prixDecimal;

        private int indiceMarqueInt;
        private int indiceCaracteristiqueInt;

        DateTime today = DateTime.Now;

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

        #region Constructeur

        public Transaction()
        {
            InitMarques();
            InitCaracteristique();
            InitPrix();
        }

        /// <summary>									
        /// Constructeur avec paramètres : Information concernant les transactions									
        /// </summary>									
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
        }



        #endregion

        #region Marques de ordinateurs

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

        #region Proprietes publiques: Get et set

        /// <summary>
        /// Le numero unique de la transaction
        /// </summary>
        /// <remarks>Genere automatiquement lors de l'enregistrement de la transaction</remarks>
        public int Id
        {
            get
            {
                return idInt;
            }
        }

        /// <summary>
        /// Le nom du client
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
                if (value != null)  // verification de la valeur  nulle
                {
                    nomStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)    // verrifie si c'est vide 
                        nomStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceNomObligatoire]);

                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceNomObligatoire]);
               
            }
        }

        /// <summary>
        /// Le prenom du client
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
                if (value != null)
                {
                    prenomStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)
                        prenomStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.cePrenomObligatoire]);

                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.cePrenomObligatoire]);
                   
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
               if (value != null)
               {
                    adresseStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)
                        adresseStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceAdresseObligatoire]);
               }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceAdresseObligatoire]);
            }
        }

        /// <summary>
        /// Code postal du client
        /// </summary>
        /// <value>Code postal canadien ou americain</value>
        /// <remarks>Obligatoire</remarks>
        public string CodePostal
        {
            get
            {
                return codePostalStr;
            }
            set
            {
                if (value != null)
                {
                    codePostalStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)
                        codePostalStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceCodePostalObligatoire]);

                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceCodePostalObligatoire]);
            }
        }

        /// <summary>
        /// Le numero de telephone du client
        /// </summary>
        public string Telephone
        {
            get
            {
                return telephoneStr;
            }
            set
            {
                if (value != null)
                {
                    telephoneStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)
                        telephoneStr = value;
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceTelephoneObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceTelephoneObligatoire]);

            }
        }

        /// <summary>
        /// Le type d'ordinateur
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
        /// Le modele d'ordinateur
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
        /// La date de livraison
        /// </summary>
        /// <remarks>Obligatoire</remarks>
        public DateTime DateLivraison
        {
           
            get
            {
                return dateLivraisonDateTime;
            }
            set
            {
                if (today.AddDays(-15) <= value && value <= today.AddDays(15))  // on verifie si la valeur est dans l'intervalle de +15jours ou - 15jours de la date d'aujourd'hui
                {
                    dateLivraisonDateTime = value; // la date etant valide on la stocke dans l'objet metier 
                    datePaiementDateTime = dateLivraisonDateTime.AddDays(30); // date du paiement de la facture pour se faire on ajoute 30jrs
                }
                else
                    throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceDateLivraisonInvalide]);

            }
        }

        /// <summary>
        /// La marque d'ordinateurs
        /// </summary>
        public string Marque
        {
            get
            {
                return marqueStr;
            }
            set
            {
                if (value != null)
                {
                    marqueStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (Array.IndexOf(tMarqueStr, value) != -1) // verifie si la valeur est dans le tableau des marques 
                        marqueStr = value;
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceMarqueInvalide]);
                }
                else
                    throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// La caracteristique de l'ordinateur
        /// </summary>
        public string Caracteristique
        {
            get
            {
                return caracteristiqueStr;
            }
            set
            {
                if (value != null)
                {
                    caracteristiqueStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if(Array.IndexOf(tCaracteristiqueStr, value) != -1)
                        caracteristiqueStr = value;
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceCaracteristiqueInvalide]);
                }
                else
                    throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Le prix de l'ordinateur 
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                if (prixDecimal > 0)     // si le prix est positif et jamais 0
                {
                    if (marqueStr != String.Empty && caracteristiqueStr != String.Empty)  // si notre marque et que caracterstique ne sont pas vides
                    {
                        indiceMarqueInt = Array.IndexOf(tMarqueStr, marqueStr);  // obtient la position de notre marque
                        indiceCaracteristiqueInt = Array.IndexOf(tCaracteristiqueStr, caracteristiqueStr);  // obtient la position de notre caracterisque

                        if (tPrixDecimal[indiceMarqueInt, indiceCaracteristiqueInt] != value)  // on verifie si la valeur recu est = au prix dans notre array
                        {
                            prixDecimal = value;
                        }
                        else
                            throw new ArgumentException(tMessagesErreursString[(int)ce.cePrixOrdinateurEgale]);

                    }
                    else
                        throw new ArgumentNullException();
                }
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region Methode Enregistrer

        /// <summary>
        /// Enregistrer la transaction
        /// </summary>
        /// <remarks>L'objet metier contient les donnees de la transaction</remarks>
        public void Enregistrer()
        {
            Console.WriteLine("Information du client :" + Environment.NewLine +
                               "Nom: " + Nom + Environment.NewLine +
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
        #endregion

    }
}
