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
       
        private static string provider = "localhost";
        private static string dataBase = "sicilylinesc";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom; 

        // Méthode pour récupérer les liaisons en fonction de l'identifiant du secteur
        public static List<Liaison> GetLiaison(int idSecteur)
        {
            try
            {
                List<Liaison> list = new List<Liaison>();
                Liaison _liaison = new Liaison();
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from liaison where idSecteur = " + idSecteur + "+1");

                MySqlDataReader reader1 = Ocom.ExecuteReader(); 

                while (reader1.Read())
                {
                    
                    int _idLiaison = (int)reader1.GetValue(0);
                    string _duree = (string)reader1.GetValue(1);
                    int idPortDepart = (int)reader1.GetValue(2);
                    int idPortArrivee = (int)reader1.GetValue(3);
                    int _idSecteur = (int)reader1.GetValue(4);

                    _liaison = new Liaison(_idLiaison, _duree, idPortDepart, idPortArrivee, _idSecteur);

                    
                    list.Add(_liaison);
                }

                reader1.Close();

                maConnexionSql.closeConnection();

                return (list);
            }
            catch (Exception uneLiaison)
            {
                throw (uneLiaison);
            }
        }

        public static void deleteLiaison(int l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp); 
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("DELETE from liaison where id=" + l);

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public static int GetNbLiaison(int idSecteur)
        {
            int count = 0;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select Count(*) from liaison where idSecteur = " + idSecteur + " + 1");

                int i = Ocom.ExecuteNonQuery();

                MySqlDataReader reader1 = Ocom.ExecuteReader();

                while (reader1.Read())
                {

                    count = Convert.ToInt32(reader1[0]);
                
                }

                reader1.Close();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
            return count;
        }

        // Méthode pour modifier la durée d'une liaison en fonction de son identifiant
        public static void modifLiaison(int idLiaison, string duree)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("update liaison set duree = '" + duree + "' where id = " + idLiaison);

                int i = Ocom.ExecuteNonQuery(); 

                maConnexionSql.closeConnection(); 
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        // Méthode pour ajouter une nouvelle liaison
        public static void ajoutLiaison(string duree, int monPortDepart, int monPortArrivee, int idSecteur)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                // Ajouter une nouvelle liaison
                String sqlReq = "INSERT INTO liaison(duree, port_depart, port_arrivee, idSecteur) VALUES('" + duree + "'," + monPortDepart + "," + monPortArrivee + "," + idSecteur + ");";
                Ocom = maConnexionSql.reqExec(sqlReq);

                int i = Ocom.ExecuteNonQuery(); 

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }
}
