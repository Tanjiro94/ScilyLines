using bateau.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Liaison
    {
        private int idLiaison;
        private string duree;
        private int portDepart;
        private int portArrivee;
        private int idSecteur;

        public Liaison()
        {
        }

        public Liaison(int idLiaison, string duree, int monPortDepart, int monPortArrivee, int unIdSecteur)
        {
            this.idLiaison = idLiaison;
            this.duree = duree;
            this.portDepart = monPortDepart;
            this.portArrivee = monPortArrivee;
            this.idSecteur = unIdSecteur;

        }
        public int IdLiaison { get => idLiaison; set => idLiaison = value; }
        public string Duree { get => duree; set => duree = value; }
        public int SecteurLie { get => idSecteur; set => idSecteur = value; }
        public int PortDepart { get => portDepart; set => portDepart = value; }
        public int PortArrivee { get => portArrivee; set => portArrivee = value; }



        public virtual string Description
        {

            get
            {
                //Mysql commence par 0 et C# commence à 1
                string unDepart = PortDAO.GetPort()[this.portDepart - 1].Nom;
                string unArrivee = PortDAO.GetPort()[this.portArrivee - 1].Nom;

                return ("Liaison n° " + this.idLiaison + "; Port de Depart : " + unDepart
              + "; Port d'Arrivee : " + unArrivee + "; Duree :" + this.duree);
            }
        }
    }
}
