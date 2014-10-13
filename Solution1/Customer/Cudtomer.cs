using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer: ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string permanentAddress;
        private int mobilePhone;
        private string email;
        private IList<Payments> customPayments;
        private customType customerType;

        public Customer(
            string firstName,
            string middleName,
            string lastName,
            long id,
            string permanentAddress,
            int mobilePhone,
            string email,
            IList<Payments> customPayments,
            customType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomPayments = customPayments;
            this.CustomerType = customerType;

        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long ID { get; set; }
        public string PermanentAddress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public IList<Payments> CustomPayments { get; set; }
        public customType CustomerType { get; set; }

        public override bool Equals(object other)
        {
            Customer otherCustomer = other as Customer;

            if (otherCustomer == null)
            {
                return false;
            }
            if (!Equals(this.ID, otherCustomer.ID))
            {
                return false;
            }
            else return true;

        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.FirstName.GetHashCode() ^ 
                this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1.Equals(c2));
        }

        public override string ToString()
        {
            string output =  string.Format("First Name: {0}\n" + this.FirstName +
                          "Middle Name: {1}\n" + this.MiddleName +
                          "Last Name: {2}\n" + this.LastName +
                          "ID: {3}\n" + this.ID +
                          "Permanent Address: {4}\n" + this.PermanentAddress+
                          "Mobile Phone: {5}\n" + this.MobilePhone +
                          "Email: {6}\n" + this.Email +
                          "Customer payments: {7}" + string.Join(" ", this.CustomPayments.
                          Select(p => p.ToString() + "\n").ToArray()) +
                          "Customer type: {8}" + this.CustomerType.GetType());

            return output;
        }

        public Customer Clone()
        {
            IList<Payments> clonedPayments = new List<Payments>();
            foreach (var payment in this.CustomPayments)
            {
                clonedPayments.Add(payment);
            }

            Customer clonedCustomer = new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.ID,
                this.PermanentAddress,
                this.MobilePhone,
                this.Email,
                clonedPayments,
                this.CustomerType
                );
            return clonedCustomer;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                if (this.MiddleName.CompareTo(other.MiddleName) == 0)
                {
                    if (this.LastName.CompareTo(other.LastName) == 0)
                    {
                        return this.ID.CompareTo(other.ID);
                    }
                }
            }
            
                return -1;
            
        }
    }
}
