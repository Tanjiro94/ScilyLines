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
        // Attributs de connexion statiques
        private static string provider = "localhost";
        private static string dataBase = "sicilylinesc";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;

        // Méthode pour supprimer un secteur
        public static void deleteSecteur(Secteur e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from bateau where id = " + e.Id); 

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur);
            }
        }

        // Méthode pour récupérer la liste des secteurs
        public static List<Secteur> getSecteur()
        {
            List<Secteur> lc = new List<Secteur>(); // Liste des secteurs à retourner

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

                    e = new Secteur(numero, nom);

                    lc.Add(e);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                return (lc);
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur); 
            }
        }
    }
}
