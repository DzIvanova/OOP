using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class ITrainer : IPerson
    {
        public string courseName;
        public ITrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            this.courseName = courseName;
            Console.WriteLine("The course {0}" + courseName + "has been created.");
        }
    }
}
