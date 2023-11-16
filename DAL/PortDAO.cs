using bateau.Modele; // Importe l'espace de noms bateau.Modele pour utiliser la classe ConnexionSql
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bateau.DAL
{
    public class PortDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql; // Instance de la classe de connexion
        private static MySqlCommand Ocom; // Objet de commande SQL

        // Méthode pour récupérer la liste des ports depuis la base de données
        public static List<Port> GetPort()
        {
            List<Port> lc = new List<Port>(); // Liste des ports à retourner

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("Select * from port"); // Exécution d'une requête SQL pour récupérer tous les ports

                MySqlDataReader reader = Ocom.ExecuteReader(); // Exécution de la commande SQL et récupération des résultats dans un objet MySqlDataReader

                Port e; // Objet Port

                while (reader.Read()) // Parcourt les résultats
                {
                    // Récupération des données pour créer un nouvel objet Port
                    string nom = (string)reader.GetValue(1);
                    int id = (int)reader.GetValue(0);

                    e = new Port(id, nom); // Création d'un nouvel objet Port

                    lc.Add(e); // Ajout de l'objet Port à la liste
                }

                reader.Close(); // Fermeture du lecteur après récupération des données
                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données
            }
            catch (Exception emp)
            {
                throw (emp); // En cas d'erreur, lance une exception
            }
            return (lc); // Retourne la liste des ports récupérés depuis la base de données
        }
    }
}
