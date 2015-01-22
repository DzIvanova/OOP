using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    public class SULSTest
    {
        private static void Main(string[] args)
        {
            List<IPerson> persons = new List<IPerson>();
            var random = new Random();

            persons.Add(new JuniorTrainer("Mashina", "Qka", 120));
            persons.Add(new SeniorTrainer("Mashina1", "Qka2", 120));

            persons.Add(new GraduateStudent("Graduate", "Student", random.Next(1, 60), random.Next(3400, 3500), 3.45F));
            persons.Add(new DropoutStudent("Dropout", "Student", random.Next(1, 60), random.Next(3400, 3500), 4.49F,
                "Otsystviq."));

            persons.Add(new OnlineStudent("Gosho", "Petkov", random.Next(1, 60), random.Next(3400, 3500), 6.00F, "OOP"));
            persons.Add(new OnlineStudent("Aleksandar", "Aleksandrov", random.Next(1, 60), random.Next(3400, 3500),
                6.00F, "OOP"));
            persons.Add(new OnlineStudent("Nafta", "Benzin", random.Next(1, 60), random.Next(3400, 3500), 3.01F, "OOP"));
            persons.Add(new OnlineStudent("Qwe", "asd", random.Next(1, 60), random.Next(3400, 3500), 2.01F, "OOP"));

            persons.Add(new OnsiteStudent("Mitko", "Mitkov", random.Next(1, 60), random.Next(3400, 3500), 3.67F, "OOP",
                5));
            persons.Add(new OnsiteStudent("Aleksei", "Alekseev", random.Next(1, 60), random.Next(3400, 3500), 5.32F,
                "OOP", 10));
            persons.Add(new OnsiteStudent("Smotanqk", "Kak", random.Next(1, 60), random.Next(3400, 3500), 5.59F, "OOP",
                29));
            persons.Add(new OnsiteStudent("Prosto", "Student", random.Next(1, 60), random.Next(3400, 3500), 3.00F, "OOP",
                30));

            var currentStudents = persons
                .Where(student => student.GetType().IsSubclassOf(typeof (CurrentStudent)))
                .OrderBy(student => ((CurrentStudent) student).AverageGrade);
            int index = 1;
            foreach (var item in currentStudents)
            {
                var currentStudent = item as CurrentStudent;
                Console.WriteLine("Current Student #{0}", index++);
                Console.WriteLine("Name: {0} {1}", currentStudent.FirstName, currentStudent.LastName);
                Console.WriteLine("Age: {0}", currentStudent.Age);
                Console.WriteLine("Student number: {0}", currentStudent.StudentNumber);
                Console.WriteLine("Average grade: {0:0.00}", currentStudent.AverageGrade);
                Console.WriteLine("Current course: {0}", currentStudent.CurrentCource);
                Console.WriteLine();
            }
        }
    }
}
