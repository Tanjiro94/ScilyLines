using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace bateau.Modele
{
    /**
     * Classe de connexion à une base de données
     */
    public class ConnexionSql
    {
        private static ConnexionSql connection = null; // Instance statique pour le singleton

        private MySqlConnection mysqlCn; // Objet de connexion MySQL

        private static readonly object mylock = new object(); // Verrou pour le singleton

        private string connString; // Chaîne de connexion à la base de données


        // Constructeur privé pour empêcher l'instanciation directe de la classe
        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            try
            {
                // Création de la chaîne de connexion à partir des paramètres fournis
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";

                try
                {
                    // Initialisation de l'objet de connexion MySQL
                    mysqlCn = new MySqlConnection(connString);
                }
                catch (Exception unSecteur)
                {
                    throw (unSecteur);
                }
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur);
            }
        }

        /**
         * Méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {
            lock ((mylock)) // Utilisation d'un verrou pour éviter les accès concurrents
            {
                try
                {
                    if (null == connection)
                    { // Crée une nouvelle instance si elle n'existe pas déjà
                        connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                    }
                }
                catch (Exception unSecteur)
                {
                    throw (unSecteur);
                }
                return connection; // Retourne l'instance existante ou nouvellement créée
            }
        }

        /**
         * Ouverture de la connexion à la base de données
         */
        public void openConnection()
        {
            try
            {
                mysqlCn.Open(); // Ouvre la connexion à la base de données
            }
            catch (Exception unSecteur)
            {
                throw (unSecteur);
            }
        }

        /**
         * Fermeture de la connexion à la base de données
         */
        public void closeConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close(); // Ferme la connexion si elle est ouverte
        }

        /**
         * Exécution d'une requête sur la base de données
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn); // Crée une commande SQL à partir de la requête et de la connexion
            return (mysqlCom); // Retourne la commande SQL créée
        }
    }
}
