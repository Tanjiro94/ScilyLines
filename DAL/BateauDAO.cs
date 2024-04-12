using bateau.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.DAL
{
        public class BateauDAO
        {

            // attributs de connexion statiques
            private static string provider = "localhost";

            private static string dataBase = "sicilylinesc";

            private static string uid = "root";

            private static string mdp = "";



            private static ConnexionSql maConnexionSql;


            private static MySqlCommand Ocom;


            // Mise à jour d'un employé

            public static void updateBateau(Bateau b)
            {

                try
                {


                    maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                    maConnexionSql.openConnection();


                    Ocom = maConnexionSql.reqExec("update bateau set nom= '" + b.Nom + "' where id = " + b.Id);


                    int i = Ocom.ExecuteNonQuery();



                    maConnexionSql.closeConnection();



                }

                catch (Exception emp)
                {

                    throw (emp);
                }


            }

            // Récupération de la liste des employés
            public static List<Bateau> getBateau()
            {

                List<Bateau> lb = new List<Bateau>();

                try
                {

                    maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                    maConnexionSql.openConnection();


                    Ocom = maConnexionSql.reqExec("Select * from bateau");


                    MySqlDataReader reader = Ocom.ExecuteReader();

                    Bateau b;




                    while (reader.Read())
                    {

                        int id = (int)reader.GetValue(0);
                        string nom = (string)reader.GetValue(1);
                        string longueur = (string)reader.GetValue(2);
                        string largeur = (string)reader.GetValue(3);
                        string vitesse = (string)reader.GetValue(4);

                        //Instanciation d'un Emplye
                        b = new Bateau(id, nom, longueur, largeur, vitesse);

                        // Ajout de cet employe à la liste 
                        lb.Add(b);


                    }



                    reader.Close();

                    maConnexionSql.closeConnection();

                    // Envoi de la liste au Manager
                    return (lb);


                }

                catch (Exception emp)
                {

                    throw (emp);

                }


            }

        }
}
