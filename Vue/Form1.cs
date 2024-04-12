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
                
                listBoxSecteur.DataSource = null;
                
                listBoxSecteur.DataSource = lSecteur;
                
                listBoxSecteur.DisplayMember = "Description";

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int secteur = listBoxSecteur.SelectedIndex;
            
            listBoxLiaison.DataSource = null;
            
            listBoxLiaison.DataSource = LiaisonDAO.GetLiaison(secteur);
            
            listBoxLiaison.DisplayMember = "Description";

           
            int nbLiaisons = LiaisonDAO.GetNbLiaison(secteur);
            label2.Text = "Le nombre de liaison est de : "+ nbLiaisons.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lSecteur = monManager.chargementEmpBD();


            
            selectPortArrivee.DataSource = null;
            
            selectPortArrivee.DataSource = PortDAO.GetPort();
            
            selectPortArrivee.DisplayMember = "Description";


            
            selectPortDepart.DataSource = null;
            
            selectPortDepart.DataSource = PortDAO.GetPort();
            
            selectPortDepart.DisplayMember = "Description";


            affiche();

        }

        private void labelPortDepart_Click(object sender, EventArgs e)
        {

        }

        private void listBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Liaison liaisonSelec = listBoxLiaison.SelectedItem as Liaison;
           
            listBoxTraversee.DataSource = null;
            
            if (liaisonSelec != null)
            {
                listBoxTraversee.DataSource = TraverseeDAO.GetTraversee(liaisonSelec.IdLiaison);
                listBoxTraversee.DisplayMember = "Description";


            }
        }

        private void btnSupLiaison_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (listBoxLiaison.SelectedItem != null)
                {
                    Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;

                    
                    LiaisonDAO.deleteLiaison(uneLiaison.IdLiaison);

                    
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
             
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            
            LiaisonDAO.modifLiaison(uneLiaison.IdLiaison, textBoxDureeLiaison.Text);
            affiche();
        }

        private void btnAjoutLiaison_Click(object sender, EventArgs e)
        {
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            
            Port portdepart = selectPortDepart.SelectedItem as Port;
            
            Port portarrivee = selectPortArrivee.SelectedItem as Port;

            LiaisonDAO.ajoutLiaison(inputAjoutLiaisonDuree.Text, portdepart.Id, portarrivee.Id, secteur.Id);

            
            Liaison uneLiaison = (Liaison)listBoxLiaison.SelectedItem;
            listBoxLiaison.DataSource = null;
            

            affiche();
        }

        private void inputAjoutLiaisonDuree_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectPortArrivee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


    }

