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
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionNS
{
    /// <summary>
    /// Objet métier : Classe de transaction
    /// </summary>
    /// <remarks>Tous droits réservés: App Creat Inc.2025</remarks>
    public class Transaction
    {
        #region Declaration des tableaux

        private string[] tMarqueStr;
        private string[] tCaracteristiqueStr;
        private Decimal[,] tPrixDecimal;

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

        public decimal GetPrix(int indiceMarque, int indiceCaracteristique)
        {
            return tPrixDecimal[indiceMarque,indiceCaracteristique];
        }

        #endregion
      
    }
}
