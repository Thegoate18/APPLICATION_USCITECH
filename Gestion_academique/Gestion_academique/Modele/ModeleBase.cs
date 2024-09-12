using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Gestion_academique.Modele
{ 
   public class ModeleBase
    {
       public Button btn;
       public UserControl monControle;
       private int idfonction;
       private int idgrade;
       private string fonction;
       private string grade;
       public DataTable dtCandidat { get; set; }
       public DataTable dtEcole { get; set; }
       public DataTable dtpalmares { get; set; }
       
       public int Idfonction
       {
           get {return idfonction; }
           set { idfonction = value; }
       }
       public int Idgrade {
           get { return idgrade; }
           set { idgrade = value; }
       }
       public string Fonction
       {
           get { return fonction; }
           set { fonction = value; }
       }
       public string Grade
       {
           get { return grade; }
           set { grade = value; }
       }
       
    }
   
}
