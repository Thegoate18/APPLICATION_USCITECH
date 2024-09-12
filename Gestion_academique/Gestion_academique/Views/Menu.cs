using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_academique.Views
{
    public partial class Menu : UserControl
    {
        Modele.ModeleBase all;
        public Menu()
        {
            InitializeComponent();
            all = new Modele.ModeleBase();
        }
        void Chargement(UserControl Ctrl)
        {
            principale.Controls.Clear();
            principale.Controls.Add(Ctrl);
            Ctrl.Dock = DockStyle.Fill;

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                all.monControle = new Views.Accueil(); 
                Chargement(all.monControle);

            }
            catch (Exception)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous Confirmer l'arrêt du programme?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
            }
            catch (Exception ex) { }
            
        }

        private void Operations(object sender, EventArgs e)
        {
            try
            {
                all.btn = (Button)sender;//sender est un envoyeur qui recupere les actions que le boutton peut effectuer, il prent ce que le button physique 
                switch (all.btn.Name) { 
                    case "btnInscription":
                        all.monControle = new Inscription();
                        break;
                }
                Chargement(all.monControle);
            }
            catch (Exception ex) { }
        }
    }
}
