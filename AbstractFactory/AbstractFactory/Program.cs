using System;

namespace AbstractFactory
{
    class Program
    {
        /* Client */
        static void Main(string[] args)
        {
        

            DbFactory db = new MongoFactory();

            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();

            Console.ReadLine();
        }
    }
}
