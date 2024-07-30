using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Customer : IComparable<Customer>, IComparer<Customer>, IEquatable<Customer>, ICloneable
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int AccBalance { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public object Clone()
        {
            return new Customer(Id, Name, Age, Address, City, AccBalance);
        }

        public Customer(int Id, String name, int age, String address, String City, int AccBalance)
        {
            this.Id = Id;
            this.Name = name;
            this.Address = address;
            this.City = City;
            this.Age = age;
            this.AccBalance = AccBalance;
        }
        public bool Equals(Customer other)
        {
            return other != null && Id == other.Id && Name == other.Name;
        }

        public int CompareTo(Customer other)
        {
            if (this.Id > other.Id) { return 1; }
            else if (this.Id < other.Id) { return -1; }
            else { return 0; }
        }
        public int Compare(Customer x, Customer y)
        {
            if (x == null || y == null) return 0;
            return y.AccBalance.CompareTo(x.AccBalance);
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Address: {Address}, City: {City}, Age: {Age}, AccBalance: {AccBalance}";
        }
        public static void testCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            var s1 = new Customer(10, "chaitanya", 20, "gangapur road", "Nashik", 10023001);
            var s2 = new Customer(100, "chaitanya", 25, "gangapur gaon", "Nashik", 100001);
            var s3 = new Customer(10, "om", 5, "shanivar wada", "pune", 10003101);
            var s4 = new Customer(30, "Ravi", 35, "Shanivar Wada", "Pune", 20003101);
            customerList.Add(s1);
            customerList.Add(s2);
            customerList.Add(s3);
            customerList.Add(s4);


            while (true)
            {
                Console.WriteLine("Enter the Choice From the Menu:");
                Console.WriteLine("1. Sort Customers by ID");
                Console.WriteLine("2. Reverse the Customer by ID");
                Console.WriteLine("3. Sort Customers by Account Balance");
                Console.WriteLine("4. Check Wether the Equal or not");
                Console.WriteLine("5. Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        customerList.Sort();
                        Console.WriteLine("Customers sorted by ID:");
                        foreach (Customer s in customerList)
                        {
                            Console.WriteLine(s.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Customers list reversed:");
                        customerList.Reverse();

                        foreach (Customer s in customerList)
                        {
                            Console.WriteLine(s.ToString());
                        }
                        break;
                    case 3:
                        customerList.Sort();
                        Console.WriteLine("Customers sorted by Account Balance:");
                        foreach (Customer customer in customerList)
                        {
                            Console.WriteLine(customer.ToString());
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Enter the Valid Choice");
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
