using System;

namespace AppPaiements
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance utilisateur
            Utilisateur utilisateur = new Utilisateur { Nom = "Grace", Prenom = "Mulumba" };

            // instances CarteCredit
            CarteCredit achat1 = new CarteCredit { Nom = "Aurelie", Prenom = "Mulumba", Date = DateTime.Now, NumeroCarte = "1234567890123456", Montant = 59.99 };
            CarteCredit achat2 = new CarteCredit { Nom = "Marie", Prenom = "Katehe", Date = DateTime.Now, NumeroCarte = "9876543210987654", Montant = 102.0 };
            CarteCredit achat3 = new CarteCredit { Nom = "Kesie", Prenom = "Mbutu", Date = DateTime.Now, NumeroCarte = "1357924680135792", Montant = 169.0 };

            // instances PayPal
            PayPal paiement1 = new PayPal { Nom = "Mike", Prenom = "Ross", Date = DateTime.Now, Email = "mike@gmail.com", Montant = 30.0 };
            PayPal paiement2 = new PayPal { Nom = "Bob", Prenom = "Sponge", Date = DateTime.Now, Email = "spongebob@gmail.com", Montant = 75.0 };

            // achats et paiements 
            utilisateur.Paiements.Add(achat1);
            utilisateur.Paiements.Add(achat2);
            utilisateur.Paiements.Add(achat3);
            utilisateur.Paiements.Add(paiement1);
            utilisateur.Paiements.Add(paiement2);

            // Afficher détails des paiements
            foreach (var paiement in utilisateur.Paiements)
            {
                Console.WriteLine(paiement.ToString());
            }
        }
    }

}
