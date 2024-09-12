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
    public partial class Inscription : UserControl
    {
        Modele.ModeleBase all;
        Modele.ModeleCandidat unCandidat;
        Controller.SQLcandidat controlleurCandidat;
        public Inscription()
        {
            all = new Modele.ModeleBase();
            unCandidat = new Modele.ModeleCandidat();
            controlleurCandidat = new Controller.SQLcandidat();
            InitializeComponent();
        }
        void chargerCandidat(){
            try
            {
                dgvCandidat.DataSource = controlleurCandidat.getCandidat("all");
        
            }
            catch (Exception ex) { }
        }
        private void Inscription_Load(object sender, EventArgs e)
        {
            try {
                all.dtEcole = controlleurCandidat.get_ecole();
                cbxEcole.Items.Clear();
                if (all.dtEcole.Rows.Count > 0) {
                    for (int i = 0; i < all.dtEcole.Rows.Count; i++) { cbxEcole.Items.Add(all.dtEcole.Rows[i].ItemArray[1].ToString()); }
                }
                chargerCandidat();
            }
            catch(Exception ex){}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void getID(object sender, EventArgs e)
        {
            try { 
                if (all.dtEcole.Rows.Count>0){
                    for (int i = 0; i < all.dtEcole.Rows.Count; i++) {
                        if (cbxEcole.Text == all.dtEcole.Rows[i].ItemArray[1].ToString()) {
                            unCandidat.Ecoleid = int.Parse(all.dtEcole.Rows[i].ItemArray[0].ToString());
                            break;
                        }
                    }
                }
            }
            catch(Exception ex){}
        }
    }
    void chargement{
}
}
