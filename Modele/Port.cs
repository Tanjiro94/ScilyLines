using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Port
    {
        private int id;
        private string nom;

        
        public string Nom { get => nom; set => nom = value; }

        
        public int Id { get => id; }

        
        public Port(int unId, string unNom)
        {
            this.id = unId; 
            this.nom = unNom;
        }

        
        public Port(string unNom)
        {
            this.nom = unNom;
        }

        
        public Port()
        {
            
        }

        // Description Port
        public string Description
        {
            get => "Id : " + this.id + " Nom : " + this.nom;
        }
    }
}
