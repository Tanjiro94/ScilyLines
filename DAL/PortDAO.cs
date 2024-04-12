using bateau.Modele;
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
        private static string dataBase = "sicilylinesc";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;

        // Méthode pour récupérer la liste des ports depuis la base de données
        public static List<Port> GetPort()
        {
            List<Port> lc = new List<Port>(); // Liste des ports à retourner

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection(); 

                Ocom = maConnexionSql.reqExec("Select * from port");

                MySqlDataReader reader = Ocom.ExecuteReader(); 

                Port e; 

                while (reader.Read())
                {
                    
                    string nom = (string)reader.GetValue(1);
                    int id = (int)reader.GetValue(0);

                    e = new Port(id, nom);

                    lc.Add(e);
                }

                reader.Close();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
            return (lc);
        }
    }
}
