using System;
using System.Collections.Generic;
using DataBase_Design.Models;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataBase_Design.Models
{
    public class Score
    {
      
        public int ScoreID { get; set; }

        public string Description { get; set; }

        
        public DateTime DateAssigned { get; set; }

        
        public DateTime DateDue { get; set; }

        
        public DateTime DateSubmit { get; set; }

        
        public int PointsEarned { get; set; }

       
        public int PointsPossible { get; set; }


    }
   
}