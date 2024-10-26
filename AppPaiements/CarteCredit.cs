using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }
        public double Montant { get; set; }
        public override void EffectuerPaiement()
        {
            Console.WriteLine($"Paiement de {Montant} effectué avec la carte {NumeroCarte}");
        }
    }

}
