using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Secteur
    {
        private int id; // Identifiant du secteur
        private string nom; // Nom du secteur

        // Propriété pour accéder au nom du secteur avec les nouveaux getters et setters de C#
        public string Nom { get => nom; set => nom = value; }

        // Propriété pour accéder à l'identifiant du secteur (seulement en lecture)
        public int Id { get => id; }

        // Constructeur avec paramètres pour initialiser un secteur avec un ID et un nom
        public Secteur(int unId, string unNom)
        {
            this.id = unId; // Initialisation de l'identifiant du secteur
            this.nom = unNom; // Initialisation du nom du secteur
        }

        // Constructeur avec un paramètre pour initialiser un secteur seulement avec un nom
        public Secteur(string unNom)
        {
            this.nom = unNom; // Initialisation du nom du secteur
        }

        // Constructeur vide
        public Secteur()
        {
            // Utilisé pour créer une instance de la classe sans paramètres
        }

        // Propriété pour obtenir une description du secteur
        public string Description
        {
            get => "Id : " + this.id + " Nom : " + this.nom; // Retourne une chaîne de description du secteur avec son ID et son nom
        }
    }
}
