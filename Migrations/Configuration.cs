namespace DataBase_Design.Migrations
{
    using DataBase_Design.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataBase_Design.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataBase_Design.DAL.StudentContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Mary", LastName="Jackson", SSN=21259688, Address="12 West Main", City="South Euclid", State="NY", ZipCode=25211, PhoneNumber=2328589625  },
                new Student{FirstName="Jason", LastName="Mills", SSN=52537859, Address="1586 First Street", City=" Euclid", State="FL", ZipCode=45425, PhoneNumber=6369857414  },
                new Student{FirstName="Harry", LastName="Potter", SSN=44450122, Address="2232 Green Road", City="South Heights", State="OH", ZipCode=63699, PhoneNumber=1256370052  },
                new Student{FirstName="Kim", LastName="Wilson", SSN=525256635, Address="87 NorthPark", City="Beachwood", State="KY", ZipCode=44565, PhoneNumber=6697415252},
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var classes = new List<Class>
            {
                new Class{Title="Microeconomics", Number=101, DepartmentTypes="Econ", Instructor= "" },
                new Class{Title="Calculus", Number=201, DepartmentTypes="Math", Instructor= "" },
                new Class{Title="Literature", Number=102, DepartmentTypes="English", Instructor= "" },
                new Class{Title="BusinessLaw", Number=104, DepartmentTypes="Business", Instructor="" },
            };
            classes.ForEach(c => context.Classes.Add(c));
            context.SaveChanges();

            var scores = new List<Score>
            {
                new Score{ Description="Intro to Microeconomics", DateAssigned=DateTime.Parse("01-02-2019") , DateDue=DateTime.Parse("01-12-2019"), DateSubmit=DateTime.Parse("01-11-2019"), PointsEarned=85, PointsPossible= 100,  },
                new Score{ Description="Principles To Calculus" , DateAssigned=DateTime.Parse("02-12-2019") , DateDue=DateTime.Parse("02-22-2019"), DateSubmit=DateTime.Parse("02-19-2019"), PointsEarned=100, PointsPossible= 100  },
                new Score{ Description="World Literature", DateAssigned=DateTime.Parse("03-07-2019") , DateDue=DateTime.Parse("03-17-2019"), DateSubmit=DateTime.Parse("03-16-2019"), PointsEarned=120, PointsPossible= 125  },
                new Score{ Description="BusinessLaw", DateAssigned=DateTime.Parse("04-01-2019"), DateDue=DateTime.Parse("04-10-2019"), DateSubmit=DateTime.Parse("04-09-2019"), PointsEarned=100, PointsPossible=100 },
         };
            scores.ForEach(s => context.Scores.Add(s));
            context.SaveChanges();

            var scoretypes = new List<ScoreType>
            {
                new ScoreType{Types= "HW" },
                new ScoreType{Types="Lab" },
                new ScoreType{Types="Exam" },
            };
            scoretypes.ForEach(s => context.ScoreTypes.Add(s));
            context.SaveChanges();

            var scss = new List<SCS>
            {
                new SCS {ClassID= 1, StudentID= 1, ScoreID= 1 },
                new SCS {ClassID= 2, StudentID= 2, ScoreID= 2 },
                new SCS {ClassID= 3, StudentID= 3, ScoreID= 3 },
                new SCS {ClassID= 4, StudentID=4, ScoreID= 4 },


            };
            scss.ForEach(s => context.SCSs.Add(s));
            context.SaveChanges();



        }

    }
}
