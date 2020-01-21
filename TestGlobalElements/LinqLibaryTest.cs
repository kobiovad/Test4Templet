using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGlobalElements;

namespace TestGlobalElements
{
    class LinqLibaryTest
    {
        public static void linqList()
        {
            //Create some students
            IList<Student> students = new List<Student>()
            {
            new Student{ StudID = 101, Name = "Karthaik", Class = "10th", Subjects = new List <string> { "C#", "ADO.Net", "EF" } },
            new Student { StudID = 102, Name = "Rama", Class = "11th", Subjects= new List <string> { ".Net", "C#", "SQL", "EF"}},
            new Student { StudID = 103, Name = "John", Class = "9th", Subjects= new List <string> { ".Net", "MVC"}},
            new Student { StudID = 104, Name = "Bill", Class = "9th", Subjects= new List <string>{ "EF", "MVC"}},
             new Student{ StudID = 105, Name = "Karthik", Class = "10th", Subjects = new List <string> { "C#", "ADO.Net", "EF" } },
            new Student { StudID = 106, Name = "Ram", Class = "11th", Subjects= new List <string> { ".Net", "C#", "SQL", "EF"}},
            new Student { StudID = 107, Name = "Jaohana", Class = "9th", Subjects= new List <string> { ".Net", "MVC"}},
            new Student { StudID = 108, Name = "Bill", Class = "9th", Subjects= new List <string>{ "EF", "MVC"}},

            };
            //Remove all the th from the Class
            Console.WriteLine("\nClass with th removed");
            var remove = from student in students
                         select new { Name = student.Name, Class = student.Class.Replace("th", " - yash").Replace("","") };
            foreach (var item in remove)
            {
                Console.WriteLine(item.Name + "\t" + item.Class);
            }
            //Select students whose studentid is greater than 103
            Console.WriteLine("\nStudent ID greater than 103");
            var gStudents = from student in students
                            where student.StudID > 103 
                            select student;

            foreach (var item in gStudents)
            {
                Console.WriteLine(item.StudID + "\t" + item.Name + "\t" + item.Class);
            }

            //Select UNIQUE NAMES from students (remove duplicate)
            Console.WriteLine("\nUNIQUE DATA -- Using UNIQUE method\n");
            var Dresult = (from student in students
                           select new { student.Name, student.Class }).Distinct();

            foreach (var item in Dresult)
            {
                Console.WriteLine(item.Name + "\t" + item.Class);
            }
            //Select All the students with their Name and Classes
            //USING QUERY SYNTAX
            Console.WriteLine("WITH QUERY SYNTAX\n");
            var result = from student in students
                         select student;

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "\t" + item.Class);
            }

            Console.WriteLine("\nWITH METHOD SYNTAX\n");

            //USING METHOD SYNTAX
            var resultM = students.Select(x => x);
            foreach (var item in resultM)
            {
                Console.WriteLine(item.Name + "\t" + item.Class);
            }
        }



        // עבודה עם תקיית לינק 
        // using System.Linq;

        //int[] numbers = { 1, 2, 3, 4, 10, 12, 6, 5, 19, 22, 44 };
        //IEnumerable result = numbers.Where(x=> x>10);
        //IEnumerable result2 = numbers.Reverse();
        //foreach (int item in result)
        //{
        //    Console.Write(item);
        //    Console.Write(",");
        //}
        //Console.WriteLine("\n");
        //foreach (int item in result2)
        //{
        //    Console.Write(item);
        //    Console.Write(",");
        //}
        //Console.WriteLine("\n");
    }
}
