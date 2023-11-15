using bateau.DAL;
using bateau.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Controleur
{
    public class mgr
    {
        SecteurDAO SDAO = new SecteurDAO();  // Création d'une instance de la classe EmployeDAO.

        List<Secteur> maListeSecteur;  // Déclaration d'une liste de type Employe appelée maListeEmploye.

        public mgr()  // Constructeur de la classe Mgr.
        {
            maListeSecteur = new List<Secteur>();  // Initialisation de maListeEmploye en créant une nouvelle liste vide.
        }

        public List<Secteur> chargementEmpBD()  // Déclaration d'une méthode publique qui retourne une liste d'employés.
        {
            maListeSecteur = SecteurDAO.getSecteur();  // Appel de la méthode getEmployes() de la classe EmployeDAO pour charger la liste d'employés depuis la DAL.
            return (maListeSecteur);  // Retour de la liste d'employés chargée.
        }

        // Mise à jour d'un employé dans la DAL
        public void updateEmploye(Secteur s)  // Déclaration d'une méthode publique pour mettre à jour un employé.
        {
            SecteurDAO.updateSecteur(s);  // Appel de la méthode updateEmploye() de la classe EmployeDAO pour effectuer la mise à jour de l'employé dans la DAL.
        }
    }
}
