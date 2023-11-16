using bateau.Controleur;
using bateau.DAL;
using bateau.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bateau
{
    public partial class Form1 : Form
    {
        
        Mgr monManager;

        List<Secteur> lSecteur = new List<Secteur>();
        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
        }
        public void affiche()

        {

            try
            {
                //Reset 
                listBoxSecteur.DataSource = null;
                //Connection BDD
                listBoxSecteur.DataSource = lSecteur;
                //Affiche la méthode
                listBoxSecteur.DisplayMember = "Description";

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Permet de prendre l'id de la chose sélectionnée
            int secteur = listBoxSecteur.SelectedIndex;
            //Permet de reset, ou sinon il va garder les précédents valeurs
            listBoxLiaison.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            listBoxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur);
            //Permet d'afficher la description
            listBoxLiaison.DisplayMember = "Description";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lSecteur = monManager.chargementEmpBD();


            //Permet de reset, ou sinon il va garder les précédents valeurs
            selectPortArrivee.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            selectPortArrivee.DataSource = PortDAO.GetPort();
            //Permet d'afficher la description
            selectPortArrivee.DisplayMember = "Description";


            //Permet de reset, ou sinon il va garder les précédents valeurs
            selectPortDepart.DataSource = null;
            //La classe LiaisonDAO va dans getLiaison et va dans l'id de la liste de secteur
            selectPortDepart.DataSource = PortDAO.GetPort();
            //Permet d'afficher la description
            selectPortDepart.DisplayMember = "Description";


            affiche();

        }

        private void labelPortDepart_Click(object sender, EventArgs e)
        {

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Permet de prendre l'id de la chose sélectionnée
            Liaison liaisonSelec = listBoxLiaison.SelectedItem as Liaison;
            
        }

        private void btnSupLiaison_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si un élément est sélectionné dans listBoxLiaison
                if (listBoxLiaison.SelectedItem != null)
                {
                    Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;

                    // Utiliser l'ID de la liaison sélectionnée pour la supprimer
                    LiaisonDAO.deleteLiaison(uneLiaison.IdLiaison);

                    // Mettre à jour l'affichage ou effectuer d'autres opérations nécessaires
                    affiche();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une liaison à supprimer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifDuree_Click(object sender, EventArgs e)
        {
            //Création de l'objet uneLiaison qui prend la liste de liaison 
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            //La classe LiaisonDAO utilise la méthode modifLiaison et prend en paramètre l'id de la liste de liaison)
            LiaisonDAO.modifLiaison(uneLiaison.IdLiaison, textBoxDureeLiaison.Text);
            affiche();
        }

        private void btnAjoutLiaison_Click(object sender, EventArgs e)
        {
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            //L'objet prend la liste des secteurs
            Port portdepart = selectPortDepart.SelectedItem as Port;
            //L'objet prend la liste des secteurs
            Port portarrivee = selectPortArrivee.SelectedItem as Port;

            LiaisonDAO.ajoutLiaison(inputAjoutLiaisonDuree.Text, portdepart.Id, portarrivee.Id, secteur.Id);

            //Permet de reset, ou sinon il va garder les précédents valeurs
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            listBoxLiaison.DataSource = null;
            // Ajout en appellant la méthode

            affiche();
        }

        private void inputAjoutLiaisonDuree_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }

