using bateau.DAL;
using bateau.Modele; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Controleur
{
    public class Mgr
    {
        SecteurDAO empDAO = new SecteurDAO(); 

        List<Secteur> maListeSecteur;

        public Mgr()
        {
            maListeSecteur = new List<Secteur>();
        }

        // Récupération de la liste des secteurs à partir de la DAL
        public List<Secteur> chargementEmpBD()
        {
            maListeSecteur = SecteurDAO.getSecteur();
            return (maListeSecteur); 
        }
    }
}
