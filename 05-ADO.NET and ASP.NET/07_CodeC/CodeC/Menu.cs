using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeC
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpAddress { get; set; }
        public int DeptId { get; set; }
    }
    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }
    }
    class Menu
    {
        private MySqlConnection con;
        public Menu()
        {
            con = new MySqlConnection("Data Source=localhost;Database=chaitanya;User ID=root;Password=root");
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Insert Employee");
                Console.WriteLine("2. Delete Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Search Employee");
                Console.WriteLine("5. Show All Employees");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InsertEmployee();
                            break;
                        case 2:
                            DeleteEmployee();
                            break;
                        case 3:
                            UpdateEmployee();
                            break;
                        case 4:
                            SearchEmployee();
                            break;
                        case 5:
                            ShowEmployees();
                            break;
                        case 6:
                            Console.WriteLine("Exiting the program....");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                            break;
                    }
            }
        }
        public void InsertEmployee() 
        {
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter employee salary: ");
            Double salary =Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter employee address: ");
            string address = Console.ReadLine();
            Console.Write("Enter department ID: ");
            int deptId = Convert.ToInt32(Console.ReadLine());

            con.Open();
            string query = "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES (@Name, @Salary, @Address, @DeptId)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@DeptId", deptId);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Employee inserted successfully.");
        }
        public void DeleteEmployee() 
        {
            Console.Write("Enter employee ID to delete: ");
            int deleteId= Convert.ToInt32(Console.ReadLine());
            con.Open();
            string query = "DELETE FROM empTable WHERE empid = @EmpId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmpId", deleteId);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Employee deleted successfully.");
            else
                Console.WriteLine("Employee not found.");

        }
        public void UpdateEmployee() 
        {
            Console.Write("Enter employee ID to update: ");
            int updateId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new salary: ");
            double newSalary= Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            Console.Write("Enter new department ID: ");
            int newDeptId= Convert.ToInt32(Console.ReadLine());

            con.Open();
            string query = "UPDATE empTable SET empname = @Name, empsalary = @Salary, empaddress = @Address, deptid = @DeptId WHERE empid = @EmpId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", newName);
            cmd.Parameters.AddWithValue("@Salary", newSalary);
            cmd.Parameters.AddWithValue("@Address", newAddress);
            cmd.Parameters.AddWithValue("@DeptId", newDeptId);
            cmd.Parameters.AddWithValue("@EmpId", updateId);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
                Console.WriteLine("Employee updated successfully.");
            else
                Console.WriteLine("Employee not found.");
        }
        public void SearchEmployee() 
        {
            Console.Write("Enter employee ID to search: ");
            int searchId= Convert.ToInt32(Console.ReadLine());
            con.Open();
            string query = "SELECT * FROM empTable WHERE empid = @EmpId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmpId", searchId);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine($"Id: {reader["empid"]}, Name: {reader["empname"]}, Salary: {reader["empsalary"]}, Address: {reader["empaddress"]}, DeptId: {reader["deptid"]}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
            reader.Close();
        }
        public void ShowEmployees() 
        {
            con.Open();
            string query = "SELECT * FROM empTable";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["empid"]}, Name: {reader["empname"]}, Salary: {reader["empsalary"]}, Address: {reader["empaddress"]}, DeptId: {reader["deptid"]}");
            }
            reader.Close();
            con.Close();
        }
    }
}
