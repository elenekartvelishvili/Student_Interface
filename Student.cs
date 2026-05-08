using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student : IComparable<Student>, IEquatable<Student>,ICloneable,IPrintable,IEnumerable,IEnumerator
    {
        public string Name { get; set; }

        public int Age { get; set; }

        private List<int> Grades = new List<int>();

        private int Position = -1;
        public Student(int age, string name)
        {

            this.Name = name;
            this.Age = age;
            Grades = new List<int>();

        }

        public double GetAverage()
        {
            if (Grades.Count == 0) { return 0; }

            return Grades.Average();
        }

        public int CompareTo(Student other)
        {
            return this.GetAverage().CompareTo(other.GetAverage());
        }

        public bool Equals(Student other)
        {
            return this.Name.Equals(other.Name);
        }

        public object Clone()
        {
            Student student=new Student(this.Age, this.Name);
            student.Grades=new List<int>(this.Grades);

            return student;
        }

        public void AddGrade(int grade)
        {
            this.Grades.Add(grade);
        }

        public void Print()
        {
            Console.WriteLine(this.Name + " " + this.Age);
        }
        
        public object Current => Grades[Position];
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
           Position++;
          return Position<this.Grades.Count;
        }

        public void Reset()
        {
            Position = -1;
        }
    }

}
