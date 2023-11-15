using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Secteur
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Secteur(int unId, string unLibelle) {
            this.id = unId;
            this.libelle = unLibelle; 
        }
        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Libelle :" + this.libelle;
        }
    }
}
