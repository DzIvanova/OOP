using System;
using System.Collections.Generic;

namespace Customer
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            Payments paymentPc = new Payments("PC", 1899);
            Payments paymentOven = new Payments("Oven", 1111);
            Payments paymentBills = new Payments("Bills", 350);
            var payments = new List<Payments>() { paymentPc, paymentOven, paymentBills };

            Customer ivan = new Customer("Ivan",
                "Geshov",
                "Popov",
                8901034546,
                "1000 Sofia, str.Vasil Levski 78",
                0888223344,
                "Vancho@gmail.com",
                payments,
                customType.Regular);

            Customer pesho = new Customer("Pesho",
               "Dobrev",
               "Volev",
               8309034116,
               "Kaspichan, str.Hristo Botev 33",
               0888777777,
               "PeshkoIT@gmail.com",
               payments,
               customType.Diamond);

            Customer cloning = ivan.Clone();

            Console.WriteLine("{0}\n", ivan.ToString());

            Console.WriteLine("\tCompare Customer Ivan with his deep clone \n" +
                "Ivan == cloning : {0}\n", ivan.CompareTo(cloning) == 0 ? "True" : "False");

            Console.WriteLine("{0}\n", pesho.ToString());

            Console.WriteLine("\tCompare Customer Ivan with Pesho \n" +
               "Ivan == Pesho : {0}\n", ivan.CompareTo(pesho) == 0 ? "True" : "False");
        }
    }
}
