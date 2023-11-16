using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Bateau
    {
        private int id; // Identifiant du bateau
        private string nom; // Nom du bateau
        private string longueur; // Longueur du bateau
        private string largeur; // Largeur du bateau
        private string vitesse; // Vitesse du bateau

        // Propriétés pour accéder aux champs privés de la classe
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Longueur { get => longueur; set => longueur = value; }
        public string Largeur { get => largeur; set => largeur = value; }
        public string Vitesse { get => vitesse; set => vitesse = value; }

        // Constructeur de la classe Bateau
        public Bateau(int unId, string unNom, string uneLongueur, string uneLargeur, string uneVitesse)
        {
            this.id = unId; // Initialisation de l'identifiant du bateau
            this.nom = unNom; // Initialisation du nom du bateau
            this.longueur = uneLongueur; // Initialisation de la longueur du bateau
            this.largeur = uneLargeur; // Initialisation de la largeur du bateau
            this.vitesse = uneVitesse; // Initialisation de la vitesse du bateau
        }
    }
}
