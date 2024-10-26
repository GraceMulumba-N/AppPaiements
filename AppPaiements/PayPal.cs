using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class PayPal : Paiement
    {
        public string Email { get; set; }
        public double Montant { get; set; }
        public override void EffectuerPaiement()
        {
            Console.WriteLine($"Paiement de {Montant} effectué par {Email}");
        }
    }

}
