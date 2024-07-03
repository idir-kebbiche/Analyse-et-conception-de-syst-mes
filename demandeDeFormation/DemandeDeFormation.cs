using System;

namespace demandeDeFormation
{
    /// <summary>
    /// Classe représentant une demande de formation.
    /// </summary>
    public class DemandeDeFormation
    {
        /// <summary>
        /// Identifiant unique de la demande de formation.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Identifiant de l'employé soumettant la demande.
        /// </summary>
        public int EmployeId { get; set; }

        /// <summary>
        /// Date de soumission de la demande de formation.
        /// </summary>
        public DateTime DateSoumission { get; set; }

        /// <summary>
        /// Statut de la demande de formation (En attente, Approuvée, Rejetée).
        /// </summary>
        public string Statut { get; set; }

        /// <summary>
        /// Titre du cours demandé.
        /// </summary>
        public string Cours { get; set; }

        /// <summary>
        /// Note de satisfaction attribuée au cours.
        /// </summary>
        public int NoteSatisfaction { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public DemandeDeFormation()
        {
            DateSoumission = DateTime.Now;
            Statut = "En attente";
        }

        /// <summary>
        /// Change le statut de la demande de formation.
        /// </summary>
        /// <param name="nouveauStatut">Le nouveau statut à attribuer.</param>
        public void ChangerStatut(string nouveauStatut)
        {
            Statut = nouveauStatut;
            Console.WriteLine($"Le statut de la demande {Id} a été changé en : {Statut}");
        }

        /// <summary>
        /// Attribue une note de satisfaction à la demande de formation.
        /// </summary>
        /// <param name="note">La note de satisfaction (1 à 5).</param>
        public void AttribuerNote(int note)
        {
            if (note < 1 || note > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(note), "La note doit être comprise entre 1 et 5.");
            }

            NoteSatisfaction = note;
            Console.WriteLine($"Une note de {NoteSatisfaction} a été attribuée à la demande {Id}.");
        }
    }
}
