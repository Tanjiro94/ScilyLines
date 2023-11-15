using bateau.Controleur;
using bateau.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bateau
{
    public partial class Form1 : Form
    {
        mgr monManager;

        List<Secteur> lSecteur = new List<Secteur>();
        public Form1()
        {
            InitializeComponent();
            monManager = new mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            lSecteur = monManager.chargementEmpBD();


            affiche();
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

        }
    }
}
