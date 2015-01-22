using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Software_University_Learning_System
{
    public class DropoutStudent : IStudent
    {
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, 
            float averageGrade, string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason { get; set; }

        public void Reapply()
        {
            Console.WriteLine("Student info\nFirst name:{0}\nLast name: {1}\nAge: {2}\nStudent number: {3}\n" +
                              "Average grade: {4}\nDropout reason:{5}", this.FirstName, this.LastName,
                              this.Age, this.StudentNumber, this.AverageGrade, this.DropoutReason);
        }
    }
}
