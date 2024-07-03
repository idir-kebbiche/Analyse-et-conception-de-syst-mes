
using System;

namespace demandeDeFormation
{
    class Program
    {
        static void Main(string[] args)
        {
            DemandeDeFormation demande = new DemandeDeFormation
            {
                Id = 1,
                EmployeId = 123,
                Cours = "Formation en C#"
            };

            Console.WriteLine($"Demande soumise par l'employé {demande.EmployeId} pour le cours {demande.Cours}.");

            // Changer le statut de la demande
            demande.ChangerStatut("Approuvée");

            // Attribuer une note de satisfaction
            demande.AttribuerNote(4);
        }
    }
}
