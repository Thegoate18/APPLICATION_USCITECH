using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_academique.Modele
{
     public class ModeleCandidat
    {
         private int id, idecole,idpalmares;
         private string nom;
         private string prenom;
         private string adresse;
         private string telephone;
         private string designation;
         private float pourcentage;

         public int Id
         {
             get{
                return id;
             }
             set {
                 id = value;
             }
         }
         public int Ecoleid
         {
             get
             {
                 return idecole;
             }
             set
             {
                 idecole = value;
             }
         }
         public int Palmaresid
         {
             get
             {
                 return idpalmares;
             }
             set
             {
                 idpalmares = value;
             }
         }
         public string Nom
         {
             get
             {
                 return nom;
             }
             set
             {
                 nom = value;
             }
         }
         public string Prenom
         {
             get
             {
                 return prenom;
             }
             set
             {
                 prenom = value;
             }
         }
         public string Adresse
         {
             get
             {
                 return adresse;
             }
             set
             {
                 adresse = value;
             }
         }
         public string Telephone
         {
             get
             {
                 return telephone;
             }
             set
             {
                 telephone = value;
             }
         }
         public string Designation 
         {
             get
             {
                 return designation;
             }
             set
             {
                 designation = value;
             }
         }
         public float Pourcentage
         {
             get
             {
                 return pourcentage;
             }
             set
             {
                 pourcentage = value;
             }
         }

         }
}
