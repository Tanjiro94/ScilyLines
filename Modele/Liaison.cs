using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Liaison
    {
        private int id;
        private string duree;


        public Liaison (int id, string duree)
        {
            this.Id = id;
            this.Duree = duree;
        }

        public int Id { get => id; set => id = value; }
        public string Duree { get => duree; set => duree = value; }
    }
}
