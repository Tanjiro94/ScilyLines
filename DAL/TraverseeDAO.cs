using bateau.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.DAL
{
    public class TraverseeDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylinesc";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        //Afficher les traversées
        public static List<Traversee> GetTraversee(int idLiaison)
        {

            try
            {
                List<Traversee> list = new List<Traversee>();
                Traversee _traversee = new Traversee();
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from traversee where id_liaison = " + idLiaison);


                MySqlDataReader reader1 = Ocom.ExecuteReader();



                while (reader1.Read())
                {

                    int _idTraversee = (int)reader1.GetValue(0);
                    string _date = (string)reader1.GetValue(1);
                    string _heure = (string)reader1.GetValue(2);
                    int _idLiaison = (int)reader1.GetValue(3);
                    int _idBateau = (int)reader1.GetValue(4);

                    _traversee = new Traversee(_idTraversee, _date, _heure, _idLiaison, _idBateau);

                    //Chaque objet ajouter inséré dans la liste
                    list.Add(_traversee);
                }



                reader1.Close();

                maConnexionSql.closeConnection();


                return (list);

            }

            catch (Exception uneTraversee)
            {

                throw (uneTraversee);
            }
        }


    }
}

