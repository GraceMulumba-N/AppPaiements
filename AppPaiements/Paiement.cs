using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Date { get; set; }
        public abstract void EffectuerPaiement();
       

    }
}
