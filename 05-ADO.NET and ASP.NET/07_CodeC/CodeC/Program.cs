using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MongoDB.Driver;
using MongoDB.Bson;
using Org.BouncyCastle.Utilities.IO;
using MongoDB.Driver.Linq;


namespace CodeC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DBConnect.testconnection();
            DBConnect func = new DBConnect();
            mongoDB mongo = new mongoDB();

            // mongo.mongo();

            //func.show();

            //func.Insert();

            //func.count();

            //func.update();
            //func.show();
            //func.delete();
            //func.show();

            DBCreate dBCreate = new DBCreate();
            //dBCreate.createTable();
            //dBCreate.inserRecord();

            Menu menu = new Menu();
            //menu.Run();

            //listConvert convert = new listConvert();
            //List<string> employees = convert.Select();

            //foreach (string employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}


            //employee e1 = new employee();
            List<employee> emp = employee.GetEmployees();

            foreach (employee e in emp)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
            Console.WriteLine();

            var resultSort = from e in emp orderby e.empname select e;
            foreach (employee e in resultSort)
            {
                Console.WriteLine(e.empid + " " + e.empname + " " + e.empsalary + " " + e.empaddress);
            }

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Enter the employee name to search for:");
            string searchName = Console.ReadLine();


            var resultSearch = emp.Where(e=>e.empname.Contains(searchName)).ToList();

           
            Console.WriteLine("Search Results:");
            foreach (employee e in resultSearch)
            {
                    Console.WriteLine(e.empid + " " + e.empname + " " + e.empsalary + " " + e.empaddress);
            }
        }
    }
    class DBConnect
    {
        private MySqlConnection con;
        public DBConnect()
        {
            con = new MySqlConnection("Data Source=localhost;Database=chaitanya;User ID=root;Password=root");
        }
        //public static void testconnection()
        //{
        //    MySqlConnection con = new MySqlConnection("Data Source=localhost;" + "Database=chaitanya; User ID=root; Password=root");
        //    con.Open();
        //    Console.WriteLine("Connected");
        //    con.Close();
        //}

        public bool OpenConnection()
        {
            con.Open();
            return true;
        }

        public void show()
        {
            Console.WriteLine("---Show Records---");
            String query = "SELECT * FROM employee";
            //if (this.OpenConnection() == true)
            //{
            con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null)
                {
                    while (dataReader.Read())
                    {
                        int id = Convert.ToInt32(dataReader["id"]);
                        String name = Convert.ToString(dataReader["name"]);
                        String address = Convert.ToString(dataReader["address"]);
                        Console.WriteLine(id.ToString() + " : " + name + " " + address);
                    }
                }
            //}
            Console.ReadKey();
            con.Close();
        }
        public void Insert()
        {
            Console.WriteLine("---Insert Record---");
            con.Open();
            String query = "INSERT INTO employee(id,name,salary) VALUES(123,'yash','33000')";
            MySqlCommand cmd = new MySqlCommand(query,con);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Inserted...");
            Console.ReadKey();
            con.Close();
        }

        public int count()
        {
            Console.WriteLine("---Count---");
            String query = "SELECT Count(*) FROM employee";
            int Count = -1;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            Count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            Console.ReadKey();
            Console.WriteLine(Count);
            return Count;

        }

        public void update()
        {
            Console.WriteLine("---Update Record---");
            con.Open();
            String newName ="rahul";
            String oldName ="Karthik";
            int oldID = 13;
            int newID = 0;
            String query1 = $"UPDATE employee SET id = {newID}  WHERE id = {oldID}";
            string query2 = "UPDATE employee SET id = @newID WHERE id = @oldID";

            MySqlCommand cmd = new MySqlCommand(query1, con);

            cmd.ExecuteNonQuery();
            Console.ReadKey();
            con.Close();
        }

        public void delete()
        {
            Console.WriteLine("---Delete Record---");
            con.Open();
            int id = 19;
            String query = $"DELETE FROM employee WHERE id={id}";
            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();
            Console.ReadKey();
            con.Close();
        }
    }
    class mongoDB
    {
        public void mongo()
        {
            string connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("LoginFormPractice");

            var collection = database.GetCollection<BsonDocument>("logincollections");
            Console.WriteLine("Connected to MongoDB");

            var filter = new BsonDocument();
            var documents = collection.Find(filter).ToList();

            Console.WriteLine("Retrieved documents:");

            foreach (var doc in documents)
            {
                var id = doc["_id"].ToString();
                var name = doc["name"].ToString();

                Console.WriteLine($"ID: {id}, Name: {name}");
            }
        }
    }
}
