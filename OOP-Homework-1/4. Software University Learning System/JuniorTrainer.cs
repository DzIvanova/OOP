using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Software_University_Learning_System
{
    class JuniorTrainer : ITrainer
    {
        public JuniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
        }
    }
}
