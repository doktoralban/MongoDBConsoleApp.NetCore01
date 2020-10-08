using System;
using MongoDB.Entities;
using System.Threading.Tasks;

namespace MongoDBConsoleApp.NetCore01
{
    class Program
    {
        static async Task Main()
        {
            await DB.InitAsync("MyDatabase", "localhost", 27017);

            var prs = new Person
            {
                Name = "Aydın Türker",
                DateOfBirth = new DateTime(1980, 10, 07),
                SiblingCount =3
            };

            await prs.SaveAsync();

            Console.WriteLine($"Person's ID: {prs.ID}");
            Console.Read();
        }



    }
}
