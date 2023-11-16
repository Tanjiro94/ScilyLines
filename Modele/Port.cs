using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Port
    {
        private int id; // Identifiant du port
        private string nom; // Nom du port

        // Propriété pour accéder au nom du port avec les nouveaux getters et setters de C#
        public string Nom { get => nom; set => nom = value; }

        // Propriété pour accéder à l'identifiant du port (seulement en lecture)
        public int Id { get => id; }

        // Constructeur avec paramètres pour initialiser un port avec un ID et un nom
        public Port(int unId, string unNom)
        {
            this.id = unId; // Initialisation de l'identifiant du port
            this.nom = unNom; // Initialisation du nom du port
        }

        // Constructeur avec un paramètre pour initialiser un port seulement avec un nom
        public Port(string unNom)
        {
            this.nom = unNom; // Initialisation du nom du port
        }

        // Constructeur vide
        public Port()
        {
            // Utilisé pour créer une instance de la classe sans paramètres
        }

        // Propriété pour obtenir une description du port
        public string Description
        {
            get => "Id : " + this.id + " Nom : " + this.nom; // Retourne une chaîne de description du port avec son ID et son nom
        }
    }
}
