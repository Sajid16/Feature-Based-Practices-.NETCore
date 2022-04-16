using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            //IList<Student> studentList = new List<Student>()
            //{
            //    new Student() { StudentID = 1, StudentName = "John", Age = 13, ProgrammingLanguages = new List<string>{ "vvvvv", "C#", "JavaScript"} } ,
            //    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, ProgrammingLanguages = new List<string>{ "C#", "C++", "TypeScript"}  } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, ProgrammingLanguages = new List<string>{ "Mode.js", "C", "JavaScript"}  } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, ProgrammingLanguages = new List<string>{ "PLSQL", "APEX", ".NetCore"} } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 15, ProgrammingLanguages = new List<string>{ "Linq", "Angular", "TypeScript"}  }
            //};

            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13, ProgrammingLanguages = new List<Techs>{ 
                    new Techs() { Technology = "Linq" }, 
                    new Techs() { Technology = "C#" }, 
                    new Techs() { Technology = "JavaScript" } } } ,
                new Student() { StudentID = 2, StudentName = "John",  Age = 21, ProgrammingLanguages = new List<Techs>{
                    new Techs() { Technology = "Linq" },
                    new Techs() { Technology = "C#" },
                    new Techs() { Technology = "JavaScript" } }  } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, ProgrammingLanguages = new List<Techs>{
                    new Techs() { Technology = "Linq" },
                    new Techs() { Technology = "C#" },
                    new Techs() { Technology = "JavaScript" } }  } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, ProgrammingLanguages = new List<Techs>{
                    new Techs() { Technology = "Linq" },
                    new Techs() { Technology = "C#" },
                    new Techs() { Technology = "JavaScript" } } } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15, ProgrammingLanguages = new List<Techs>{
                    new Techs() { Technology = "Linq" },
                    new Techs() { Technology = "C#" },
                    new Techs() { Technology = "JavaScript" } }  }
            };

            //---------------------------------------------------------------------
            // use of select clause

            //var queryResult = (from student in studentList
            //                   select student).ToList();
            //var queryResult = (from student in studentList
            //                   select new
            //                   {
            //                       studentName = student.StudentName,
            //                       studentId = student.StudentID
            //                   }).ToList();
            //var methodResult = studentList.Select(student => student.Age).ToList();
            //var methodResult = studentList.Select(student => new 
            //{
            //    studentName = student.StudentName,
            //    studentAge = student.Age
            //}).ToList();

            //foreach (var student in queryResult)
            //{
            //    Console.WriteLine(student.studentName + " -> "+student.studentId);
            //}
            // use of select clause

            // --------------------------------------------------------------------

            // use of selectmany clause

            //var queryResult = (from student in studentList
            //                   from skill in student.ProgrammingLanguages
            //                   select skill).Distinct().ToList();

            //var methodResult = studentList.SelectMany(student => student.ProgrammingLanguages).Distinct().ToList();

            //var queryResult = (from student in studentList
            //                   from skill in student.ProgrammingLanguages
            //                   select skill).ToList();

            //var methodResult = studentList.SelectMany(student => student.ProgrammingLanguages).ToList();

            //foreach (var studentInfo in queryResult)
            //{
            //    Console.WriteLine(studentInfo.Technology);
            //}

            // use of selectmany clause

            // --------------------------------------------------------------------

            //use of where clause

            //query syntax
            //var filterResult = (from student in studentList
            //                    where student.Age > 14 && student.Age < 21
            //                    select new Student
            //                    {
            //                        StudentID = student.StudentID,
            //                        StudentName = student.StudentName,
            //                        Age = student.Age
            //                    }).ToList();
            //foreach (var student in filterResult)
            //{
            //    Console.WriteLine(student.StudentName);
            //}

            ////method syntax
            //var filterResult2 = studentList.Where(student => student.Age == 13 || student.Age == 21).ToList();
            //foreach (var student in filterResult2)
            //{
            //    Console.WriteLine(student.StudentName);
            //}

            //use of where clause

            // --------------------------------------------------------------------

            //use of oftype clause

            //List<object> dataSource = new List<object>() { "Sajid", "Mahboob", "Upal", 1, 2, 3, 4 };

            //var querySyntax = (from obj in dataSource
            //                  where obj is string
            //                  select obj).ToList();

            //var methodSyntax = dataSource.OfType<int>().Where(obj => obj >= 2).ToList();

            //foreach (var obj in methodSyntax)
            //{
            //    Console.WriteLine(obj);
            //}

            //use of oftype clause

            // --------------------------------------------------------------------

            //use of orederby, thenby clause

            //List<object> dataSource = new List<object>() { "Sajid", "Mahboob", "Upal", 1, 2, 3, 4 };

            //var querySyntax = from student in studentList
            //                  where student.Age > 18
            //                  orderby student.Age descending
            //                  select student;
            var querySyntax = from student in studentList
                              orderby student.StudentName, student.Age descending
                              select student;
            // var querySyntax = from student in studentList
            //                  where student.Age > 18
            //                  orderby student.Age
            //                  select student;

            // var methodSyntax = studentList.Where(student => student.Age > 18).OrderBy(student => student.Age).ToList();
            // var methodSyntax = studentList.Where(student => student.Age > 18).OrderByDescending(student => student.Age).ToList();
            var methodSyntax = studentList.OrderByDescending(student => student.StudentName).ThenByDescending(student => student.Age).ToList();

            foreach (var obj in methodSyntax)
            {
                Console.WriteLine(obj.StudentID + "-> " + obj.StudentName+ "-> " + obj.Age);
            }

            //use of orederby, thenby clause
        }
    }
}