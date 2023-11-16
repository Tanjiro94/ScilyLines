using bateau.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.DAL
{
    public class SecteurDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        //Suppression d'un secteur
        public static void deleteSecteur(Secteur e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                
                Ocom = maConnexionSql.reqExec("delete from secteur where id = " + e.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception unSecteur)
            {

                throw (unSecteur);
            }


        }
        

        // Récupération de la liste des secteur
        public static List<Secteur> getSecteur()
        {

            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from Secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur e;




                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    //Instanciation d'un Emplye
                    e = new Secteur(numero, nom);

                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception unSecteur)
            {

                throw (unSecteur);

            }


        }

    }
}
