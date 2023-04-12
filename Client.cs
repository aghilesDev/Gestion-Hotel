using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel
{
    internal class Client
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        private int _numeroChambre;

        public int NumeroChambre
        {
            get { return _numeroChambre; }
            set
            {
                if (value > 0)
                    _numeroChambre = value;
                else
                    throw new ArgumentException("Le numéro de chambre doit être supérieur à zéro.");
            }
        }

        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;
        }

        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom: {Prenom}, Courriel: {Courriel}, Carte de crédit: {CarteCredit}, Numéro de chambre: {NumeroChambre}";
        }
    }
}
