using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

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
        }
    }
}