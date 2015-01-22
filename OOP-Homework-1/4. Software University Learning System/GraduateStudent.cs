using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Software_University_Learning_System
{
    public class GraduateStudent : IStudent
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, float averageGrade) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
        }
    }
}
