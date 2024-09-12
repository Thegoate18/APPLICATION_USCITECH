using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_academique.Controller
{
    public class SQLpersonel:Utile.ConBD
    {
        public DataTable Authentification(string user, string Pwd) { 
        string maRequete="select T_personnel.nom +' '+ T_personnel.prenom as Personnel,"+
                        " T_fonction.libelle as Fonction from T_personnel"+
                        " inner join T_fonction on T_fonction.id=T_personnel.fonction where T_personnel.nom='"+ user +"' and T_personnel.Pwd='"+ Pwd +"'";
        _data = getData(maRequete);
        return _data;
        } 
    }
}
