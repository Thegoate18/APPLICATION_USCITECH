using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_academique.Controller
{
    public class SQLcandidat:Utile.ConBD
    {   DataTable table;
        string requete;
        int current = 0;
        public int SetDataCandidat(float pourcentage) {
            try {
                requete = "insert into T_palmares(pourcentage)values "+ pourcentage +"";
                current=SetData
            }
            catch(Exception ex){}
        }
        public DataTable getCandidat(string tri) { 
          table=new DataTable();
            try {
                if (tri == "all") { 
                requete="select T_candidat.id,T_candidat.nom+' '+T_candidat.prenom as [Nom Complet],"+
                   "T_candidat.adresse, T_candidat.dob as [Date de naissance],"+
                    "T_ecole.designation as [Nom de l'ecole],T_palmares.pourcentage"+
                   " from T_ecole inner join T_candidat on T_ecole.id=T_candidat.ecole"+
                   " inner join T_palmares on T_palmares.id=T_candidat.palmares";
                }
                table = getData(requete);
            }
            catch(Exception ex) {
            }
            return table;  
        }
        public DataTable get_ecole() {
            table=new DataTable();
            try {
                requete = "select * from T_ecole";
                table = getData(requete);
            }
            catch(Exception ex) {
            
            }
            return table;
        }  
    }
}
