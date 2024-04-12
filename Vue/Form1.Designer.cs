namespace bateau
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxLiaison = new System.Windows.Forms.ListBox();
            this.groupBoxModifDuree = new System.Windows.Forms.GroupBox();
            this.btnModifDuree = new System.Windows.Forms.Button();
            this.textBoxDureeLiaison = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSupLiaison = new System.Windows.Forms.Button();
            this.groupBoxAjoutLiaison = new System.Windows.Forms.GroupBox();
            this.btnAjoutLiaison = new System.Windows.Forms.Button();
            this.selectPortArrivee = new System.Windows.Forms.ComboBox();
            this.labelPortArrivee = new System.Windows.Forms.Label();
            this.selectPortDepart = new System.Windows.Forms.ComboBox();
            this.labelPortDepart = new System.Windows.Forms.Label();
            this.inputAjoutLiaisonDuree = new System.Windows.Forms.TextBox();
            this.labelAjoutLiaison = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTraversee = new System.Windows.Forms.ListBox();
            this.groupBoxModifDuree.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAjoutLiaison.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 16;
            this.listBoxSecteur.Location = new System.Drawing.Point(30, 27);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(210, 180);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxLiaison
            // 
            this.listBoxLiaison.FormattingEnabled = true;
            this.listBoxLiaison.ItemHeight = 16;
            this.listBoxLiaison.Location = new System.Drawing.Point(302, 27);
            this.listBoxLiaison.Name = "listBoxLiaison";
            this.listBoxLiaison.Size = new System.Drawing.Size(273, 180);
            this.listBoxLiaison.TabIndex = 1;
            this.listBoxLiaison.SelectedIndexChanged += new System.EventHandler(this.listBoxLiaison_SelectedIndexChanged);
            // 
            // groupBoxModifDuree
            // 
            this.groupBoxModifDuree.Controls.Add(this.btnModifDuree);
            this.groupBoxModifDuree.Controls.Add(this.textBoxDureeLiaison);
            this.groupBoxModifDuree.Controls.Add(this.label1);
            this.groupBoxModifDuree.Location = new System.Drawing.Point(30, 291);
            this.groupBoxModifDuree.Name = "groupBoxModifDuree";
            this.groupBoxModifDuree.Size = new System.Drawing.Size(200, 215);
            this.groupBoxModifDuree.TabIndex = 2;
            this.groupBoxModifDuree.TabStop = false;
            this.groupBoxModifDuree.Text = " Maj durée liaison";
            // 
            // btnModifDuree
            // 
            this.btnModifDuree.Location = new System.Drawing.Point(22, 107);
            this.btnModifDuree.Name = "btnModifDuree";
            this.btnModifDuree.Size = new System.Drawing.Size(75, 23);
            this.btnModifDuree.TabIndex = 3;
            this.btnModifDuree.Text = "Valider";
            this.btnModifDuree.UseVisualStyleBackColor = true;
            this.btnModifDuree.Click += new System.EventHandler(this.btnModifDuree_Click);
            // 
            // textBoxDureeLiaison
            // 
            this.textBoxDureeLiaison.Location = new System.Drawing.Point(22, 57);
            this.textBoxDureeLiaison.Name = "textBoxDureeLiaison";
            this.textBoxDureeLiaison.Size = new System.Drawing.Size(140, 22);
            this.textBoxDureeLiaison.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duree";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSupLiaison);
            this.groupBox2.Location = new System.Drawing.Point(245, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer la liaison";
            // 
            // btnSupLiaison
            // 
            this.btnSupLiaison.Location = new System.Drawing.Point(29, 72);
            this.btnSupLiaison.Name = "btnSupLiaison";
            this.btnSupLiaison.Size = new System.Drawing.Size(147, 23);
            this.btnSupLiaison.TabIndex = 0;
            this.btnSupLiaison.Text = "Supprimer";
            this.btnSupLiaison.UseVisualStyleBackColor = true;
            this.btnSupLiaison.Click += new System.EventHandler(this.btnSupLiaison_Click);
            // 
            // groupBoxAjoutLiaison
            // 
            this.groupBoxAjoutLiaison.Controls.Add(this.btnAjoutLiaison);
            this.groupBoxAjoutLiaison.Controls.Add(this.selectPortArrivee);
            this.groupBoxAjoutLiaison.Controls.Add(this.labelPortArrivee);
            this.groupBoxAjoutLiaison.Controls.Add(this.selectPortDepart);
            this.groupBoxAjoutLiaison.Controls.Add(this.labelPortDepart);
            this.groupBoxAjoutLiaison.Controls.Add(this.inputAjoutLiaisonDuree);
            this.groupBoxAjoutLiaison.Controls.Add(this.labelAjoutLiaison);
            this.groupBoxAjoutLiaison.Location = new System.Drawing.Point(463, 300);
            this.groupBoxAjoutLiaison.Name = "groupBoxAjoutLiaison";
            this.groupBoxAjoutLiaison.Size = new System.Drawing.Size(637, 215);
            this.groupBoxAjoutLiaison.TabIndex = 4;
            this.groupBoxAjoutLiaison.TabStop = false;
            this.groupBoxAjoutLiaison.Text = "Ajouter une liaison";
            // 
            // btnAjoutLiaison
            // 
            this.btnAjoutLiaison.Location = new System.Drawing.Point(224, 164);
            this.btnAjoutLiaison.Name = "btnAjoutLiaison";
            this.btnAjoutLiaison.Size = new System.Drawing.Size(185, 35);
            this.btnAjoutLiaison.TabIndex = 6;
            this.btnAjoutLiaison.Text = "Ajouter";
            this.btnAjoutLiaison.UseVisualStyleBackColor = true;
            this.btnAjoutLiaison.Click += new System.EventHandler(this.btnAjoutLiaison_Click);
            // 
            // selectPortArrivee
            // 
            this.selectPortArrivee.FormattingEnabled = true;
            this.selectPortArrivee.Location = new System.Drawing.Point(391, 91);
            this.selectPortArrivee.Name = "selectPortArrivee";
            this.selectPortArrivee.Size = new System.Drawing.Size(222, 24);
            this.selectPortArrivee.TabIndex = 5;
            this.selectPortArrivee.SelectedIndexChanged += new System.EventHandler(this.selectPortArrivee_SelectedIndexChanged);
            // 
            // labelPortArrivee
            // 
            this.labelPortArrivee.AutoSize = true;
            this.labelPortArrivee.Location = new System.Drawing.Point(388, 63);
            this.labelPortArrivee.Name = "labelPortArrivee";
            this.labelPortArrivee.Size = new System.Drawing.Size(87, 16);
            this.labelPortArrivee.TabIndex = 4;
            this.labelPortArrivee.Text = "Port d\'arrivée";
            // 
            // selectPortDepart
            // 
            this.selectPortDepart.FormattingEnabled = true;
            this.selectPortDepart.Location = new System.Drawing.Point(170, 91);
            this.selectPortDepart.Name = "selectPortDepart";
            this.selectPortDepart.Size = new System.Drawing.Size(197, 24);
            this.selectPortDepart.TabIndex = 3;
            // 
            // labelPortDepart
            // 
            this.labelPortDepart.AutoSize = true;
            this.labelPortDepart.Location = new System.Drawing.Point(167, 63);
            this.labelPortDepart.Name = "labelPortDepart";
            this.labelPortDepart.Size = new System.Drawing.Size(92, 16);
            this.labelPortDepart.TabIndex = 2;
            this.labelPortDepart.Text = "Port de départ";
            this.labelPortDepart.Click += new System.EventHandler(this.labelPortDepart_Click);
            // 
            // inputAjoutLiaisonDuree
            // 
            this.inputAjoutLiaisonDuree.Location = new System.Drawing.Point(49, 91);
            this.inputAjoutLiaisonDuree.Name = "inputAjoutLiaisonDuree";
            this.inputAjoutLiaisonDuree.Size = new System.Drawing.Size(100, 22);
            this.inputAjoutLiaisonDuree.TabIndex = 1;
            this.inputAjoutLiaisonDuree.TextChanged += new System.EventHandler(this.inputAjoutLiaisonDuree_TextChanged);
            // 
            // labelAjoutLiaison
            // 
            this.labelAjoutLiaison.AutoSize = true;
            this.labelAjoutLiaison.Location = new System.Drawing.Point(46, 72);
            this.labelAjoutLiaison.Name = "labelAjoutLiaison";
            this.labelAjoutLiaison.Size = new System.Drawing.Size(44, 16);
            this.labelAjoutLiaison.TabIndex = 0;
            this.labelAjoutLiaison.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxTraversee
            // 
            this.listBoxTraversee.FormattingEnabled = true;
            this.listBoxTraversee.ItemHeight = 16;
            this.listBoxTraversee.Location = new System.Drawing.Point(687, 27);
            this.listBoxTraversee.Name = "listBoxTraversee";
            this.listBoxTraversee.Size = new System.Drawing.Size(399, 180);
            this.listBoxTraversee.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 568);
            this.Controls.Add(this.listBoxTraversee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxAjoutLiaison);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxModifDuree);
            this.Controls.Add(this.listBoxLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxModifDuree.ResumeLayout(false);
            this.groupBoxModifDuree.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxAjoutLiaison.ResumeLayout(false);
            this.groupBoxAjoutLiaison.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxLiaison;
        private System.Windows.Forms.GroupBox groupBoxModifDuree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifDuree;
        private System.Windows.Forms.TextBox textBoxDureeLiaison;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupLiaison;
        private System.Windows.Forms.GroupBox groupBoxAjoutLiaison;
        private System.Windows.Forms.Label labelPortDepart;
        private System.Windows.Forms.TextBox inputAjoutLiaisonDuree;
        private System.Windows.Forms.Label labelAjoutLiaison;
        private System.Windows.Forms.Button btnAjoutLiaison;
        private System.Windows.Forms.ComboBox selectPortArrivee;
        private System.Windows.Forms.Label labelPortArrivee;
        private System.Windows.Forms.ComboBox selectPortDepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTraversee;
    }
}

