using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4.KRUCHININA
{
    public class Student<T> : ICloneable, IComparable<Student<T>>
    {

        public string? Name { get; set; }
        public T? GroupNumber { get; set; }
        public int[]? Grades { get; set; }
        public string? Marks { get; set; }
        public double Avg { get; set; }

        public void CalculateAverageGrade()
        {
            double sum = 0;
            foreach (int grade in Grades!)
            {
                sum += grade;
            }
            Avg= (double)sum / Grades.Length;
        }

        public void getString()
        {
            string res = "";
            foreach (int i in Grades!) res += i + " ";
            Marks = res;
        }
        public object Clone()
        {
            return new Student<T>()
            {
                Avg = this.Avg,
                Name = this.Name,
                GroupNumber = this.GroupNumber,
                Marks = this.Marks
            };
        }

        public int CompareTo(Student<T>? other)
        {
            if (other is Student<T>)
            {
                Student<T>? monster = other as Student<T>;
                return this.Avg.CompareTo(monster!.Avg);
            }
            else throw new Exception("Невозможно сравнить два объекта");
        }
        public bool IsGood()
        {
            bool isTrue = true;
            foreach(int i in Grades!)
            {
                if (i < 4) { isTrue = false; break; };
            }
            return isTrue;
        }
    }
}
