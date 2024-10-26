using System;

namespace AppPaiements
{
    class Program
    {
        static void Main(string[] args)
        {
            CarteCredit achat1 = new CarteCredit { Nom = "Grace", Prenom = "Mulumba", Date = DateTime.Now, NumeroCarte = "1234567890123456", Montant = 59.99 };
            CarteCredit achat2 = new CarteCredit { Nom = "Aurelie", Prenom = "Mulumba", Date = DateTime.Now, NumeroCarte = "9876543210987654", Montant = 102.0 };
            CarteCredit achat3 = new CarteCredit { Nom = "Olive", Prenom = "Ndaya", Date = DateTime.Now, NumeroCarte = "1357924680135792", Montant = 151.0 };

            Console.WriteLine(achat1.ToString());
            Console.WriteLine(achat2.ToString());
            Console.WriteLine(achat3.ToString());
        }
    }

}
}
