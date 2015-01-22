using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Software_University_Learning_System
{
    public class CurrentStudent : IStudent
    {
        public CurrentStudent(string firstName, string lastName, int age, 
            int studentNumber, int averageGrade, string currentCorce) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCorce = currentCorce;
        }

        public string CurrentCorce { get; set; }
    }
}
