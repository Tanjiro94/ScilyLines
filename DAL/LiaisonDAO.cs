using bateau.Modele; // Importe l'espace de noms bateau.Modele pour utiliser la classe ConnexionSql
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
        // Attributs de connexion statiques
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql; // Instance de la classe de connexion

        private static MySqlCommand Ocom; // Objet de commande SQL

        // Méthode pour récupérer les liaisons en fonction de l'identifiant du secteur
        public static List<Liaison> GetLiaison(int idSecteur)
        {
            try
            {
                List<Liaison> list = new List<Liaison>(); // Liste des liaisons à retourner
                Liaison _liaison = new Liaison(); // Objet liaison
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion

                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("Select * from liaison where idSecteur = " + idSecteur + "+1"); // Exécution d'une requête SQL pour récupérer les liaisons du secteur

                MySqlDataReader reader1 = Ocom.ExecuteReader(); // Exécution de la commande SQL et récupération des résultats dans un objet MySqlDataReader

                while (reader1.Read()) // Parcourt les résultats
                {
                    // Récupération des données pour créer un nouvel objet Liaison
                    int _idLiaison = (int)reader1.GetValue(0);
                    string _duree = (string)reader1.GetValue(1);
                    int idPortDepart = (int)reader1.GetValue(2);
                    int idPortArrivee = (int)reader1.GetValue(3);
                    int _idSecteur = (int)reader1.GetValue(4);

                    _liaison = new Liaison(_idLiaison, _duree, idPortDepart, idPortArrivee, _idSecteur);

                    // Chaque objet ajouté est inséré dans la liste
                    list.Add(_liaison);
                }

                reader1.Close(); // Fermeture du lecteur après récupération des données

                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données

                return (list); // Retourne la liste des liaisons récupérées
            }
            catch (Exception uneLiaison)
            {
                throw (uneLiaison); // En cas d'erreur, lance une exception
            }
        }

        // Méthode pour supprimer une liaison en fonction de son identifiant
        public static void deleteLiaison(int l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("DELETE from liaison where id=" + l); // Exécution d'une requête SQL pour supprimer une liaison en fonction de son ID

                int i = Ocom.ExecuteNonQuery(); // Exécution de la commande SQL

                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données
            }
            catch (Exception emp)
            {
                throw (emp); // En cas d'erreur, lance une exception
            }
        }

        // Méthode pour modifier la durée d'une liaison en fonction de son identifiant
        public static void modifLiaison(int idLiaison, string duree)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + duree + "' where id = " + idLiaison); // Exécution d'une requête SQL pour modifier la durée d'une liaison

                int i = Ocom.ExecuteNonQuery(); // Exécution de la commande SQL

                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données
            }
            catch (Exception emp)
            {
                throw (emp); // En cas d'erreur, lance une exception
            }
        }

        // Méthode pour ajouter une nouvelle liaison avec les détails fournis
        public static void ajoutLiaison(string duree, int monPortDepart, int monPortArrivee, int idSecteur)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); // Récupération de l'instance de connexion
                maConnexionSql.openConnection(); // Ouverture de la connexion à la base de données

                // Construction de la requête SQL pour ajouter une nouvelle liaison
                String sqlReq = "INSERT INTO liaison(duree, port_depart, port_arrivee, idSecteur) VALUES('" + duree + "'," + monPortDepart + "," + monPortArrivee + "," + idSecteur + ");";
                Ocom = maConnexionSql.reqExec(sqlReq); // Exécution de la requête SQL

                int i = Ocom.ExecuteNonQuery(); // Exécution de la commande SQL

                maConnexionSql.closeConnection(); // Fermeture de la connexion à la base de données
            }
            catch (Exception emp)
            {
                throw (emp); // En cas d'erreur, lance une exception
            }
        }
    }
}
