using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.Modele
{
    public class Traversee
    {
        private int _idTraversee;
        private string date;
        private string heure;
        private int idLiaison;
        private int _idBateau;

        public Traversee()
        {
        }
        public Traversee(int unIdTraversee, string uneDate, string lheure, int idLiaison, int unIdBateau)
        {
            this._idTraversee = unIdTraversee;
            this.date = uneDate;
            this.heure = lheure;
            this.idLiaison = idLiaison;
            this._idBateau = unIdBateau;

        }

        public int idTraversee { get => _idTraversee; set => _idTraversee = value; }
        public string Date { get => date; set => date = value; }
        public string Heure { get => heure; set => heure = value; }
        public int IdLiaison { get => idLiaison; set => idLiaison = value; }
        public int IdBateau { get => _idBateau; set => _idBateau = value; }

        public virtual string Description
        {

            get
            {
                return ("Traversée n° " + this._idTraversee + "; Date : " + this.date
              + "; Heure : " + this.heure + "; id du Bateau :" + this._idBateau + " id de la liaison :" + this.idLiaison);
            }
        }
    }
}

