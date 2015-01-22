using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class IStudent : IPerson
    {
        public int StudentNumber { get; set; }
        public int AverageGrade { get; set; }

        public IStudent(string firstName, string lastName, int age, int studentNumber, int averageGrade) 
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }
    }
}
