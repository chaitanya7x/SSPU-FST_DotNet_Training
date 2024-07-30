using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeC
{
    class listConvert
    {
        private MySqlConnection con;
        public listConvert()
        {
            con = new MySqlConnection("Data Source=localhost;Database=chaitanya;User ID=root;Password=root");
        }
        public List<string> Select()
        {
            string query = "Select * from employee";
            List<string> list = new List<string>();
            con.Open();
            MySqlCommand cmd=new MySqlCommand(query, con);
            MySqlDataReader Dataread = cmd.ExecuteReader();
            while (Dataread.Read()) 
            {
                int ID = Convert.ToInt32(Dataread["id"]);
                string Name = Convert.ToString(Dataread["name"]);
                list.Add(ID.ToString() + " " + Name);
            }
            Console.ReadKey();
            Dataread.Close();
            con.Close();
            return list;
        }
    }
}
