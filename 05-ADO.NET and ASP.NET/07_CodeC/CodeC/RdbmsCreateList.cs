using MongoDB.Bson.Serialization.Serializers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeC
{
    public class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        //public int age { get; set; }
        public double empsalary { get; set; }
        public string empaddress { get; set; }
        public int deptid { get; set; }

        public override string ToString()
        {
            return empid + " " + empname + " " + empsalary + " " + empaddress;

        }

        //public employee(int id, string name, int age, double salary, string address, int deptid)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.age = age;
        //    this.salary = salary;
        //    this.address = address;
        //    this.deptid = deptid;
        //}

        public static List<employee> GetEmployees()
        {
            List<employee> employees = new List<employee>();

            string connectionString = "Server=localhost;Database=chaitanya;Uid=root;Pwd=root;";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            string query = "SELECT * FROM emptable";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                employee emp = new employee() {
                    empid = reader.GetInt32("empid"),
                    empname = reader.GetString("empname"),
                    //age = reader.GetInt32("age"),
                    empsalary = reader.GetDouble("empsalary"),
                    empaddress = reader.GetString("empaddress"),
                    deptid = reader.GetInt32("deptid"),
                };
                employees.Add(emp);
            }
            reader.Close();
            con.Close();

            return employees;
        }
    }
}