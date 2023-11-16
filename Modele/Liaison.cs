using bateau.DAL; // Importe l'espace de noms bateau.DAL pour utiliser la classe PortDAO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Liaison
    {
        private int idLiaison; // Identifiant de la liaison
        private string duree; // Durée de la liaison
        private int portDepart; // ID du port de départ
        private int portArrivee; // ID du port d'arrivée
        private int idSecteur; // ID du secteur associé à la liaison

        // Constructeur par défaut
        public Liaison()
        {
        }

        // Constructeur avec paramètres pour initialiser une liaison
        public Liaison(int idLiaison, string duree, int monPortDepart, int monPortArrivee, int unIdSecteur)
        {
            this.idLiaison = idLiaison; // Initialisation de l'identifiant de la liaison
            this.duree = duree; // Initialisation de la durée de la liaison
            this.portDepart = monPortDepart; // Initialisation de l'ID du port de départ
            this.portArrivee = monPortArrivee; // Initialisation de l'ID du port d'arrivée
            this.idSecteur = unIdSecteur; // Initialisation de l'ID du secteur associé à la liaison
        }

        // Propriétés pour accéder aux champs privés de la classe
        public int IdLiaison { get => idLiaison; set => idLiaison = value; }
        public string Duree { get => duree; set => duree = value; }
        public int SecteurLie { get => idSecteur; set => idSecteur = value; }
        public int PortDepart { get => portDepart; set => portDepart = value; }
        public int PortArrivee { get => portArrivee; set => portArrivee = value; }

        // Propriété virtuelle pour obtenir une description de la liaison
        public virtual string Description
        {
            get
            {
                // Obtient les noms des ports de départ et d'arrivée à partir de la classe PortDAO
                // Mysql commence par 0 et C# commence à 1, d'où la soustraction de 1 lors de l'accès aux ports
                string unDepart = PortDAO.GetPort()[this.portDepart - 1].Nom;
                string unArrivee = PortDAO.GetPort()[this.portArrivee - 1].Nom;

                // Retourne une description détaillée de la liaison
                return ("Liaison n° " + this.idLiaison + "; Port de Départ : " + unDepart
                        + "; Port d'Arrivée : " + unArrivee + "; Durée : " + this.duree);
            }
        }
    }
}
