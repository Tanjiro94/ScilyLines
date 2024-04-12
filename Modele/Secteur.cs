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
        private string nom;

        
        public string Nom { get => nom; set => nom = value; }

        
        public int Id { get => id; }

        
        public Secteur(int unId, string unNom)
        {
            this.id = unId; 
            this.nom = unNom;
        }

       
        public Secteur(string unNom)
        {
            this.nom = unNom;
        }

       
        public Secteur()
        {
            
        }

       
        public string Description
        {
            get => "Id : " + this.id + " Nom : " + this.nom;
        }
    }
}
