using bateau.DAL; // Importe l'espace de noms bateau.DAL pour utiliser la classe SecteurDAO
using bateau.Modele; // Importe l'espace de noms bateau.Modele pour utiliser la classe Secteur
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Controleur
{
    public class Mgr
    {
        DAL.SecteurDAO empDAO = new DAL.SecteurDAO(); // Instance de la classe SecteurDAO pour interagir avec les secteurs dans la base de données

        List<Modele.Secteur> maListeSecteur; // Liste de secteurs de la classe modèle

        public Mgr()
        {
            maListeSecteur = new List<Modele.Secteur>(); // Initialisation de la liste des secteurs
        }

        // Récupération de la liste des secteurs à partir de la DAL
        public List<Secteur> chargementEmpBD()
        {
            maListeSecteur = SecteurDAO.getSecteur(); // Appel de la méthode de la classe SecteurDAO pour récupérer la liste des secteurs depuis la base de données
            return (maListeSecteur); // Retourne la liste des secteurs récupérés depuis la base de données
        }
    }
}
