using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class OnsiteStudent : CurrentStudent
    {
        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, 
            float averageGrade, string currentCorce, int numberOfVisits) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCorce)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }
    }
}
