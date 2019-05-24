using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataBase_Design.Models
{
    public class Student
    {
        
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public Int64 PhoneNumber { get; set; }

        
    }
}