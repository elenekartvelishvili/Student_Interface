using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Student s1 = new Student(20, "Alice");
            Student s2 = new Student(22, "Bob");
            Student s3 = new Student(21, "Charlie");

            s1.AddGrade(90);
            s1.AddGrade(85);
            s1.AddGrade(78);

            s2.AddGrade(88);
            s2.AddGrade(92);
            s2.AddGrade(80);

            s3.AddGrade(70);
            s3.AddGrade(75);

            s3.AddGrade(68);


            Student[] students=new Student[] {s1,s2,s3};    

            Array.Sort(students);

            foreach (Student student in students) {
            
            Console.WriteLine(student.Name);
            
            }



            Console.WriteLine("************************");

            List<Student> students_list = new List<Student>() { s1,s2,s3};

            CompareByAge comparer=new CompareByAge();

            students_list.Sort(comparer);

            foreach (Student student in students_list) {
            
            Console.WriteLine(student.Name);
            
            }


            Student s4 = (Student)s1;
            Console.WriteLine(s4.Name);

            Console.WriteLine(s4.Equals(s1));




            //IEnumerable and IEnumeartor usage


            Console.WriteLine("**************");
            foreach (int grade in s1) { Console.WriteLine(grade); }


            Console.ReadKey();

            }



        }
    }
