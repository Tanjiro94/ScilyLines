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


        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        public string Nom { get => nom; set => nom = value; }

        // remplace getId()
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
        // Constructeur vide
        public Port()
        {


        }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom;
        }
    }
}
