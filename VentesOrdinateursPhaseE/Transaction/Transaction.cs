/*
        Programmeurs:   Ange Yemele, 
                        Ansoumane Condé,
                        Dorian Wontcheu,
                        Emmanuel Takam,
                        Yannis-Arthur Nenzeko

        Date:           Décembre 2023

        Solution:       VentesOrdinateurs.sln
        Projet:         Transaction.csproj
        Classe:         Transaction.cs

        But:            Couche métier 
                        Créer et documenter les membres
                        Surcharger la méthode GetPrix
                        Appliquer diverses techniques pour échanger des données entre un 
                        objet de la couche présentation et un objet métier
                        Valider les données
                        Utiliser une variable statique pour tenir compte des numéros des transactions
•	                    Utiliser des expressions régulières « Regular Expression » pour le numéro de téléphone et le code postal.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;   // Important pour pouvoir utiliser la propriété Regex
using System.Threading.Tasks;

using ce = TransactionNS.Transaction.CodeErreurs;


namespace TransactionNS
{
    /// <summary>
    /// Objet métier : Classe de transaction
    /// </summary>
    /// <remarks>Tous droits réservés: App Creat Inc. 2025</remarks>
    public class Transaction
    {
        #region Déclaration des enumerations, tableaux d'erreurs

        public enum CodeErreurs
        {
            ceNomObligatoire,
            cePrenomObligatoire,
            ceAdresseObligatoire,
            ceCodePostalObligatoire,
            ceCodePostalInvalide,
            ceCodePostalIncorrect,
            ceTelephoneObligatoire,
            ceTelephoneInvalide,
            ceDateLivraisonInvalide,
            ceMarqueInvalide,
            ceCaracteristiqueInvalide,
            ceMarqueObligatoire,
            ceCaracteristiqueObligatoire,
            cePrixOrdinateurInvalide,
            cePrixObligatoire,
            cePrixPositif,
            ceErreurIndeterminee
        }

        public static string[] tMessagesErreursString = new string[17];


        #endregion

        #region Initialisation des tableaux d'erreurs

        public static void InitMessagesMessagesErreurs()
        {
            tMessagesErreursString[(int)ce.ceNomObligatoire] = "Le nom est obligatoire.";  //0
            tMessagesErreursString[(int)ce.cePrenomObligatoire] = "Le prenom est obligatoire."; //1
            tMessagesErreursString[(int)ce.ceAdresseObligatoire] = "L'adresse est obligatoire. ";  //2 
            tMessagesErreursString[(int)ce.ceCodePostalObligatoire] = "Le code postal est obligatoire.";   // 3
            tMessagesErreursString[(int)ce.ceCodePostalInvalide] = "Le code postal est invalide.";  // 4 
            tMessagesErreursString[(int)ce.ceCodePostalIncorrect] = "Le format du code postal est incorrect";
            tMessagesErreursString[(int)ce.ceTelephoneObligatoire] = "Le numero de telephone est obligatoire";  //5
            tMessagesErreursString[(int)ce.ceTelephoneInvalide] = "Le format du numéro de téléphone n'est pas valide";
            tMessagesErreursString[(int)ce.ceDateLivraisonInvalide] = "La date de livraison est invalide."; // 6
            tMessagesErreursString[(int)ce.ceMarqueInvalide] = "La marque de l'ordinateur est invalide. Choisir une marque acceptable."; // 7 
            tMessagesErreursString[(int)ce.ceCaracteristiqueInvalide] = "La caracterstique de l'ordinateur est invalide. Choisir une caracteristique acceptable."; // 8
            tMessagesErreursString[(int)ce.ceMarqueObligatoire] = "La marque de l'ordinateur est obligatoire."; // 9
            tMessagesErreursString[(int)ce.ceCaracteristiqueObligatoire] = "La caracteristique de l'ordinateur est obligatoire."; // 10
            tMessagesErreursString[(int)ce.cePrixOrdinateurInvalide] = "Le prix doit correspondre à la marque et à la caracteristique sélectionnée."; // 11
            tMessagesErreursString[(int)ce.cePrixObligatoire] = "Le prix est obligatoire."; // 12
            tMessagesErreursString[(int)ce.cePrixPositif] = "Le prix est un entier positif différent de zéro."; // 13
            tMessagesErreursString[(int)ce.ceErreurIndeterminee] = "Une erreur indeterminée. Communiquer avec la personne ressource."; // 14

        }


        #endregion

        #region Déclaration des tableaux et variables privées

        private string[] tMarqueStr;
        private string[] tCaracteristiqueStr;
        private Decimal[,] tPrixDecimal;

        public static int idInt = 1;
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

        // Expressions régulières pour la validation
        // E2A 4V3

        private const string CODE_POSTAL_CANADIEN_PATTERN_String = @"[A-Z][0-9][A-Z] ?[0-9][A-Z][0-9]";

        // (506)343-3434  ou 506.343.3434 ou 5063452939
        private const string TELEPHONE_CANADIEN_PATTERN_String = "^(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$";



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

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Transaction()
        {
            InitMarques();
            InitCaracteristique();
            InitPrix();
        }

        /// <summary>									
        /// Constructeur avec paramètres : Information concernant les transactions									
        /// </summary>									
        /// <param name="nomPrinc">Nom du client</param>									
        /// <param name="prenomPrinc">Prénom du client</param>									
        /// <param name="adressePrinc">Adresse du client</param>									
        /// <param name="codePostalPrinc">Code postal du client</param>									
        /// <param name="telephonePrinc">Téléphone du client</param>									
        /// <param name="typePrinc">Type d'ordinateur</param>									
        /// <param name="modelePrinc">Modèle d'ordinateur</param>									
        /// <param name="dateLivraisonPrinc">Date de livraison</param>									
        /// <param name="marquePrinc">Marque d'ordinateur</param>									
        /// <param name="caracteristiquePrinc">Caractéristique d'ordinateur</param>									
        /// <param name="prixPrinc">Prix d'ordinateur</param>									
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

        #region Propriétés 

        /// <summary>
        /// Numéro unique de la transaction
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
        /// Nom du client
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
                if (value != null)  // vérification de la valeur  nulle
                {
                    if (value != String.Empty)    // chaine n'est pas vide
                        nomStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceNomObligatoire]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceNomObligatoire]);
               
            }
        }

        /// <summary>
        /// Prénom du client
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
                    if ( value != String.Empty)
                        prenomStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
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
                    if (value != String.Empty)
                        adresseStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
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
                    //codePostalStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string

                    if (value != String.Empty)
                    {
                        if (Regex.IsMatch(value, CODE_POSTAL_CANADIEN_PATTERN_String, RegexOptions.IgnoreCase))
                            codePostalStr = value.Trim();
                        else
                            throw new FormatException(tMessagesErreursString[(int)ce.ceCodePostalIncorrect]);
                    }
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceCodePostalObligatoire]);

                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceCodePostalObligatoire]);
            }
        }

        /// <summary>
        /// Numéro de téléphone du client
        /// </summary>
        /// <remarks>Obligatoire</remarks>
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
                    //telephoneStr = value.Trim(); // trim:supprime tout les espaces blancs au debut ou a la fin du string
                    
                    if (value != String.Empty)
                    {
                        if (Regex.IsMatch(value, TELEPHONE_CANADIEN_PATTERN_String))
                            telephoneStr = value.Trim();
                        else
                            throw new FormatException(tMessagesErreursString[(int)ce.ceTelephoneInvalide]);

                    }
                    else
                        throw new ArgumentException(tMessagesErreursString[(int)ce.ceTelephoneObligatoire]);              
                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceTelephoneObligatoire]);
            }
        }

        /// <summary>
        /// Type d'ordinateur
        /// </summary>
        public string Type
        {
            get
            {
                return typeStr;
            }
            set
            {
                typeStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
        /// Modèle d'ordinateur
        /// </summary>
        public string Modele
        {
            get
            {
                return modeleStr;
            }
            set
            {
                modeleStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
            }
        }

        /// <summary>
        /// Date de livraison
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
                if (today.AddDays(-15) <= value && value <= today.AddDays(15))  // verifie si la valeur est dans l'intervalle de +15jours ou - 15jours de la date d'aujourd'hui
                {
                    
                    dateLivraisonDateTime = value; // la date etant valide on la stocke dans l'objet metier 
                    datePaiementDateTime = dateLivraisonDateTime.AddDays(30); // la date du paiement se fait par l'ajout de 30jrs
                }
                else
                    throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceDateLivraisonInvalide]);
            }
        }

        /// <summary>
        /// Date du paiement
        /// </summary>
        public DateTime DateDuePaiement
        {
            get 
            {
                return datePaiementDateTime;
            }
        }

        /// <summary>
        /// Marque de l'ordinateur
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
                    if (Array.IndexOf(tMarqueStr, value) != -1) // verifie si la valeur est dans le tableau des marques 
                        marqueStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceMarqueInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceMarqueObligatoire]);
            }
        }

        /// <summary>
        /// Caracteristique de l'ordinateur
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
                    if(Array.IndexOf(tCaracteristiqueStr, value) != -1)
                        caracteristiqueStr = value.Trim(); // trim:supprime tous les espaces blancs au debut ou a la fin du string
                    else
                        throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.ceCaracteristiqueInvalide]);
                }
                else
                    throw new ArgumentNullException(tMessagesErreursString[(int)ce.ceCaracteristiqueObligatoire]);
            }
        }

        /// <summary>
        /// Prix de l'ordinateur 
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                if (value > 0M)     // si le prix est positif et jamais 0
                {
                    if (marqueStr != String.Empty && caracteristiqueStr != String.Empty)  // si la marque et la caracterstique ne sont pas vides
                    {
                        indiceMarqueInt = Array.IndexOf(tMarqueStr, marqueStr);  // obtient la position de notre marque
                        indiceCaracteristiqueInt = Array.IndexOf(tCaracteristiqueStr, caracteristiqueStr);  // obtient la position de notre caracterisque

                        if (tPrixDecimal[indiceMarqueInt, indiceCaracteristiqueInt] == value)  // on verifie si la valeur recu est = au prix dans notre array
                        {
                            prixDecimal = value;
                        }
                        else
                            throw new ArgumentException(tMessagesErreursString[(int)ce.cePrixOrdinateurInvalide]);
                    }
                    else
                        throw new ArgumentNullException(tMessagesErreursString[(int)ce.cePrixObligatoire]);
                }
                else
                    throw new ArgumentOutOfRangeException(tMessagesErreursString[(int)ce.cePrixPositif]);
            }
        }

        #endregion

        #region Enregistrer

        /// <summary>
        /// Enregistrer la transaction
        /// </summary>
        /// <remarks>L'objet métier contient les données de la transaction</remarks>
        public void Enregistrer()
        {
            idInt += 1;

            Console.WriteLine("Information du client :" + Environment.NewLine +
                                "Id: " + Id + Environment.NewLine +
                               "Nom: " + Nom + Environment.NewLine +
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

        #endregion
    }
}
