using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace CollectionProject
{
    [Serializable]
    class Bank
    {
        public int accNo;
        public string name;
        public double balance;
        [NonSerialized()]
        public int otp;
        
    }
    class CurrAcc:Bank
    {
        public static void curracc() 
        {
            //base.accNo = 1231;
            //base.balance = 14241;
            //base.name = "chaitanya";
            //base.otp = 2341;
        }
    }

    class SavingAcc:Bank
    {
        public static void savingracc() { }

    }
    class Display
    {
        public static void display()
        {
            SavingAcc acc1 = new SavingAcc();
            CurrAcc acc2= new CurrAcc();
           // base.accNo = 1231;
            acc1.balance = 14241;
            acc1.name = "chaitanya";
            acc1.otp = 2341;

            acc2.accNo = 1231;
            acc2.balance = 14241;
            acc2.name = "chaitanya";
            acc2.otp = 2341;

            IFormatter f = new BinaryFormatter();
            Stream str = new FileStream(@"E:\bank.txt", FileMode.Create, FileAccess.Write);
            f.Serialize(str, acc1);
            str.Close();

            str = new FileStream(@"E:\bank.txt", FileMode.Open, FileAccess.Read);
            SavingAcc s = (SavingAcc)f.Deserialize(str);

            Console.WriteLine("Account 1");
            Console.WriteLine("Acc No. {0}: ", acc1.accNo);
            Console.WriteLine("Name : {0}", acc1.name);
            Console.WriteLine("Balance : {0}", acc1.balance);
        }
    }
}
