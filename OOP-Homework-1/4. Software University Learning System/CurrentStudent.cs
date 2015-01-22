using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Software_University_Learning_System
{
    public class CurrentStudent : IStudent
    {
        public CurrentStudent(string firstName, string lastName, int age, 
            int studentNumber, float averageGrade, string currentCource) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCource = currentCource;
        }

        public string CurrentCource { get; set; }
    }
}
