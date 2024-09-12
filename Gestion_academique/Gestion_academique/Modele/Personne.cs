using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_academique.Modele
{
   public class Personne
    {
       private string nom;
       private string prenom;
       private string adresse;
       private string telephone;

       public string Nom {
           get { return nom; }
           set
           {
               if (nom != value) { nom = value; }
           }
       }
       public string Prenom {
           get { return prenom; }//c'est une methode 
           set { prenom = value; }
       }
       public string Adresse { get; set;}
       public string Telephone { get; set; }//on accede directement à la variable 
   }


}
