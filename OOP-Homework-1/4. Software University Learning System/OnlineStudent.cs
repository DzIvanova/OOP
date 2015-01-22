using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, int studentNumber, 
            float averageGrade, string currentCource) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCource)
        {
        }
    }
}
