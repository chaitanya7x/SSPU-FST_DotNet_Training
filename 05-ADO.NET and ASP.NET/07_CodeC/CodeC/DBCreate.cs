using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeC
{
    class DBCreate
    {
        private MySqlConnection con;
        public DBCreate()
        {
            con = new MySqlConnection("Data Source=localhost;Database=chaitanya;User ID=root;Password=root");
        }
        public void createTable()
        {
            string DeptTableQuery = @"
                CREATE TABLE dept (
                    deptid INT PRIMARY KEY AUTO_INCREMENT,
                    deptname VARCHAR(50) NOT NULL,
                    deptlocation VARCHAR(100)
                )";

            string EmpTableQuery = @"
                CREATE TABLE empTable (
                    empid INT PRIMARY KEY AUTO_INCREMENT,
                    empname VARCHAR(100) NOT NULL,
                    empsalary DOUBLE,
                    empaddress VARCHAR(100),
                    deptid INT,
                    FOREIGN KEY (deptid) REFERENCES dept(deptid)
                )";

            con.Open();

            MySqlCommand cmdDept = new MySqlCommand(DeptTableQuery, con);
            cmdDept.ExecuteNonQuery();

            MySqlCommand cmdEmp = new MySqlCommand(EmpTableQuery, con);
            cmdEmp.ExecuteNonQuery();

            Console.WriteLine("Tables created successfully.");

            con.Close();
        }

        public void inserRecord()
        {
            con.Open();

            string[] deptQueries = new string[]
            {
                "INSERT INTO dept (deptname, deptlocation) VALUES ('HR', 'Nashik')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('IT', 'Mumbai')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Finance', 'Pune')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Sales', 'Delhi')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Marketing', 'Bangalore')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Operations', 'Chennai')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Legal', 'Kolkata')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Research', 'Hyderabad')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Customer Service', 'Jaipur')",
                "INSERT INTO dept (deptname, deptlocation) VALUES ('Production', 'Ahmedabad')"
            };

            foreach (var query in deptQueries)
            {
                MySqlCommand cmdDept = new MySqlCommand(query, con);
                cmdDept.ExecuteNonQuery();
            }

            string[] empQueries = new string[]
            {
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('John Doe', 80000.00, 'Nashik', 1)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Jane Smith', 75000.00, 'Nashik', 2)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Michael Johnson', 90000.00, 'Nashik', 3)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Emily Brown', 70000.00, 'Nashik', 4)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('David Lee', 85000.00, 'Nashik', 5)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Sarah Wilson', 82000.00, 'Nashik', 6)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Chris Anderson', 78000.00, 'Nashik', 7)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Jessica Thomas', 95000.00, 'Nashik', 8)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Matthew Garcia', 72000.00, 'Nashik', 9)",
                "INSERT INTO empTable (empname, empsalary, empaddress, deptid) VALUES ('Laura Martinez', 88000.00, 'Nashik', 10)"
            };

            foreach (var query in empQueries)
            {
                MySqlCommand cmdEmp = new MySqlCommand(query, con);
                cmdEmp.ExecuteNonQuery();
            }

            Console.WriteLine("Inserted 10 records into dept and empTable.");

            con.Close();
        }
    }
}
