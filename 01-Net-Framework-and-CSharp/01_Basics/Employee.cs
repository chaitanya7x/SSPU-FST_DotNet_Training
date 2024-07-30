using System;

namespace ConsoleApp2
{
    public class Employee
    {
        public static string CompanyName = "Wipro";

        double BaseSalary;
        double HRA;
        double DA;
        double ProfessionalTax;
        double GrossSalary;
        double NetSalary;

        int id;
        string name;

        public void GetDetails()
        {
            Console.WriteLine("Enter the Base Salary:");
            BaseSalary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Professional Tax:");
            ProfessionalTax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the HRA:");
            HRA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the DA:");
            DA = Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateGrossSalary()
        {
            GrossSalary = BaseSalary + ((DA / 100.0) * BaseSalary) + ((HRA / 100.0) * BaseSalary);
            Console.WriteLine("Gross Salary = " + GrossSalary);
        }

        public void CalculateNetSalary()
        {
            double tax = CalculateTax(GrossSalary);
            NetSalary = GrossSalary - ProfessionalTax - tax;
            Console.WriteLine("Net Salary = " + NetSalary);
        }

        private double CalculateTax(double grossSalary)
        {
            double tax = 0.0;
            if (grossSalary > 300000)
            {
                tax = 7;
            }
            else if (grossSalary > 200000)
            {
                tax = 0;
            }
            else if (grossSalary > 100000)
            {
                tax = (grossSalary - 100000) * 0.01;
            }
            return tax;
        }
    }
}
