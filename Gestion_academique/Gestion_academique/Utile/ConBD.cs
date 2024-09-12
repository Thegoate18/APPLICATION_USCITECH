using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Gestion_academique.Utile
{
    public class ConBD //encapsulation de la classe 
    {
        private SqlConnection cnx; //definie une connexion avec le serveur, cest une route
        private SqlCommand commande;
        private SqlDataAdapter adapter;
        private DataTable donnee;
        protected DataTable _data;
        private string route="Data Source=THE-GOAT-DESTOP\\ZEGOAT;Initial Catalog=academia;Integrated Security=True";
        private Boolean EtablirCon() {
            try {
                cnx = new SqlConnection(route);
                cnx.Open();
                return true;
            }
            catch (Exception ex) {
                Console.Write("Error connection data base");
                MessageBox.Show("Impossible d'établir la connexion au serveur faute de \n " + ex.Message,"Message d'erreur ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
                
            } }
                 protected DataTable getData(string requete){
                        donnee=new DataTable();
                        try
                        {
                            if (cnx == null)
                            {
                                EtablirCon();
                            }
                            adapter = new SqlDataAdapter(requete,cnx);
                            adapter.Fill(donnee);
                        }
                        catch (Exception ex) {
                            Console.Write("Erreur de connection");
                            MessageBox.Show("Aucune donnéé trouver dans la base car " + ex.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return donnee;
        }           
                protected int setData(string requete) { 
                
                 }
    }
}
