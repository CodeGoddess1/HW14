using System.Collections.Generic;

namespace DataBase_Design.Models
{
    public class SCS
    {
        
        public int SCSID { get; set; }
        
        public int ClassID { get; set; }
        
        public virtual Class Class { get; set; }
       
        public int StudentID { get; set; }
       
        public virtual Student Student { get; set; }
        
        public int ScoreID { get; set; }
        
        public virtual Score Score { get; set; }


       
    }
}