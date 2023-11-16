using bateau.Modele; // Importe l'espace de noms bateau.Modele pour utiliser la classe ConnexionSql
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
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql; // Instance de la classe de connexion
        private static MySqlCommand Ocom; // Objet de commande SQL

        // Méthode pour supprimer un secteur
        public static void deleteSecteur(Secteur e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("delete from secteur where id = " + e.Id); // Exécution d'une requête SQL pour supprimer un secteur en fonction de son ID

                int i = Ocom.ExecuteNonQuery(); // Exécution de la commande SQL

                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur); // En cas d'erreur, lance une exception
            }
        }

        // Méthode pour récupérer la liste des secteurs
        public static List<Secteur> getSecteur()
        {
            List<Secteur> lc = new List<Secteur>(); // Liste des secteurs à retourner

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("Select * from Secteur"); // Exécution d'une requête SQL pour récupérer tous les secteurs

                MySqlDataReader reader = Ocom.ExecuteReader(); // Exécution de la commande SQL et récupération des résultats dans un objet MySqlDataReader

                Secteur e; // Objet Secteur

                while (reader.Read()) // Parcourt les résultats
                {
                    // Récupération des données pour créer un nouvel objet Secteur
                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    // Instanciation d'un Secteur
                    e = new Secteur(numero, nom);

                    // Ajout de ce secteur à la liste 
                    lc.Add(e);
                }

                reader.Close(); // Fermeture du lecteur après récupération des données
                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données

                return (lc); // Retourne la liste des secteurs récupérés depuis la base de données
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur); // En cas d'erreur, lance une exception
            }
        }
    }
}
