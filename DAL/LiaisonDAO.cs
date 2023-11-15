using bateau.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.DAL
{
    public class LiaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "bateau";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Mise à jour d'un employé

        public static void updateLiaison(Liaison l)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update liaison set duree= '" + l.Duree + "' where id = " + l.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        public static List<Liaison> getLiaisonsBySecteur(int secteurId)
        {
            List<Liaison> ll = new List<Liaison>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM liaison WHERE id_secteur = @secteurId");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;

                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string duree = (string)reader.GetValue(1);

                    // Instanciation d'une liaison
                    l = new Liaison(id, duree);

                    // Ajout de cette liaison à la liste 
                    ll.Add(l);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Retourner la liste des liaisons pour ce secteur
                return ll;
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
        // Récupération de la liste des employés
        public static List<Liaison> getLiaison()
        {

            List<Liaison> ll = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from liaison");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string duree = (string)reader.GetValue(1);


                    //Instanciation d'un Emplye
                    l = new Liaison(id, duree);

                    // Ajout de cet employe à la liste 
                    ll.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (ll);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }
}
