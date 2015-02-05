using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kurtovo_Konare
{
    public interface ICustomer
    {
         string Customer { get; set; }
         double Balance { get; set; }
         double InterestRate { get; set; }

        void DepositMoney(double money)
        {
            
        }


    }
}
