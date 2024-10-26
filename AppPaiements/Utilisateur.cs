using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur()
        {
            Paiements = new List<Paiement>();
        }
    }

}
