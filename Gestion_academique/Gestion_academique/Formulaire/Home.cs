using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_academique.Formulaire
{
    public partial class Home : Form
    {   
        Modele.ModeleBase all;//extension d'une classe
        Modele.Personnel unPersonnel;
        Controller.SQLpersonel accesDataPersonnel;
        public Home()
        {
            InitializeComponent();
            all = new Modele.ModeleBase();
            unPersonnel=new Modele.Personnel();
            accesDataPersonnel = new Controller.SQLpersonel();
        }
        void Chargement(UserControl Ctrl) {
            PanelParent.Controls.Clear();
            PanelParent.Controls.Add(Ctrl);
            Ctrl.Dock = DockStyle.Fill;
 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                Deconnection();
                Chargement(all.monControle);
                 
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnconnection.Text == "Se connecter")
                Connection();
            else
                Deconnection();
        }
        void Deconnection() {
            all.monControle = new Views.Accueil(); //renvoi vers l'accueil lorsqu'on clique sur déconnecter
            lblconnection.Text = "Utilisateur Connecté: Néant ";
            txtpwd.Text = "";
            txtuser.Enabled = true;
            txtpwd.Enabled = true;
            txtuser.Focus(); // pour le clignotement (focus)
            btnconnection.Text = "Se connecter";
        }
        void Connection() {
            
            DataTable maTable=new DataTable();
            try
            {
                unPersonnel.Nom = txtuser.Text;
                unPersonnel.Pwd = txtpwd.Text;
               
                maTable = accesDataPersonnel.Authentification(unPersonnel.Nom, unPersonnel.Pwd);
                if (maTable.Rows.Count > 0)
                {
                    txtpwd.Text = ""; // on vide ces textbox
                    txtuser.Text = "";
                    txtpwd.Enabled = false;
                    txtuser.Enabled = false;
                    btnconnection.Text = "Se déconnecter";
                    lblconnection.Text = "Utilisateur Connecté: " + maTable.Rows[0].ItemArray[0].ToString();
                    all.monControle = new Views.Menu();
                    Chargement(all.monControle);  
                }
                else {
                    MessageBox.Show("Les informations fournis sont incorrectes\n Veuillez contacter l'administration du système","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { 
            }
            
        }
    }
}
