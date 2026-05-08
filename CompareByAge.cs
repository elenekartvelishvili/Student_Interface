using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class CompareByAge : IComparer<Student>
    {
        public bool isAsc = false;
        

        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age)*(isAsc?1:-1);
        }
    }
}
