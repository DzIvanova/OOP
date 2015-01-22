using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class SeniorTrainer : ITrainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void DeleteCourse(string courseName)
        {
            this.courseName = courseName;
            Console.WriteLine("The course {0}" + courseName + "has been deleted.");
        }
    }
}
