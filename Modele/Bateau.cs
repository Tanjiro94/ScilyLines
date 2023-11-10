using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Bateau
    {
        private int id;
        private string nom;
        private string longueur;
        private string largeur;
        private string vitesse;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Longueur { get => longueur; set => longueur = value; }
        public string Largeur { get => largeur; set => largeur = value; }
        public string Vitesse { get => vitesse; set => vitesse = value; }

        public Bateau(int unId, string unNom, string uneLongueur, string uneLargeur, string uneVitesse)
        {
            this.id = unId;
            this.nom = unNom;
            this.longueur = uneLongueur;
            this.largeur = uneLargeur;
            this.vitesse = uneVitesse;

        }
    }
}
